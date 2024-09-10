using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGUNDO_PARCIAL_SEGUNDA_FORMA
{


    public partial class SEGUNDO_PARCIAL : Form
    {
        private string Email = "Correo ";  //Aqui debes escribir el gmail al cual mandaras el correo
        private string contrasena = "contraseña"; //Aqui debes escribir la contraseña exclusiva de tu correo
        private string Alias = "MAIKIN ";
        private string[] Adjuntos;
        private MailMessage Correo;


        public SEGUNDO_PARCIAL()
        {
            InitializeComponent();
        }
        //Conexion A Base de datos
        string connectionString = "Data Source=;Initial Catalog=CorreosDB;Integrated Security=True;";
        string query = "SELECT * FROM Correos";


        private void ActualizarDataGridView()
        {    
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar cada fila al DataGridView.
                    dgvCorreo.Rows.Add(reader.GetDateTime(reader.GetOrdinal("Fecha")), reader.GetString(reader.GetOrdinal("Destinatario")), reader.GetString(reader.GetOrdinal("Asunto")));
                }
                reader.Close();
            }
        }

        private void CrearCuerpoCorreo()
        {
            Correo = new MailMessage();
            Correo.From = new MailAddress(Email, Alias, System.Text.Encoding.UTF8);
            Correo.To.Add(txtMF.Text.Trim());
            Correo.Subject = txtASUNTO.Text.Trim();
            Correo.Body = txtMS.Text.Trim();
            Correo.IsBodyHtml = true;
            Correo.IsBodyHtml = false;
            Correo.Priority = MailPriority.High;

            for(int i = 0; i < Adjuntos.Length; i++)
            {
                Correo.Attachments.Add(new Attachment(Adjuntos[i]));
            }

        }

        private void Envio()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(Email, contrasena);
                ServicePointManager.ServerCertificateValidationCallback = delegate
                    (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
                { return true; };
                smtp.EnableSsl = true;
                smtp.Send(Correo);
                MessageBox.Show("Enviado");
                lblDocs.Text = "";
                using (SqlConnection connection = new SqlConnection(connectionString))
               
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Correos (FechaEnvio, Destinatario, Asunto, Mensaje) VALUES (@FechaEnvio, @Destinatario, @Asunto, @Mensaje);";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    insertCommand.Parameters.AddWithValue("@FechaEnvio", DateTime.Now);
                    insertCommand.Parameters.AddWithValue("@Destinatario", Correo.To.ToString());
                    insertCommand.Parameters.AddWithValue("@Asunto", Correo.Subject);
                    insertCommand.Parameters.AddWithValue("@Mensaje", Correo.Body);

                    insertCommand.ExecuteNonQuery();
                }
            ActualizarDataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void AdjuntarArchivos()
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar archivos al correo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Adjuntos = ofd.FileNames;
            }

            for ( int i = 0; i < Adjuntos.Length; i++)
            {
                names += Adjuntos[i] + "\n";
            }

            lblDocs.Text = names + "\n:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }


        private void btnENV_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            Envio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCorreo.Columns.Add("Fecha", "Fecha");

        }

        private void txtClean_Click(object sender, EventArgs e)
        {
            txtASUNTO.Text = string.Empty;
            txtMF.Text = string.Empty;
            txtMS.Text = string.Empty;
            lblDocs.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnRST_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.correosTableAdapter.Fill(this.correosDBDataSet.Correos);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHour2.Text = DateTime.Now.ToString("hh/mm/ss/");
        }
    }
}
