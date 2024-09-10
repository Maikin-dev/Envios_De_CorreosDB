namespace SEGUNDO_PARCIAL_SEGUNDA_FORMA
{
    partial class SEGUNDO_PARCIAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMF = new System.Windows.Forms.TextBox();
            this.txtASUNTO = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDocs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnENV = new System.Windows.Forms.Button();
            this.txtClean = new System.Windows.Forms.Button();
            this.dgvCorreo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correosDBDataSet = new SEGUNDO_PARCIAL_SEGUNDA_FORMA.CorreosDBDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRST = new System.Windows.Forms.Button();
            this.correosTableAdapter = new SEGUNDO_PARCIAL_SEGUNDA_FORMA.CorreosDBDataSetTableAdapters.CorreosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHour = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHour2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correosDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ASUNTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MENSAJE:";
            // 
            // txtMF
            // 
            this.txtMF.Location = new System.Drawing.Point(117, 14);
            this.txtMF.Multiline = true;
            this.txtMF.Name = "txtMF";
            this.txtMF.Size = new System.Drawing.Size(344, 23);
            this.txtMF.TabIndex = 3;
            // 
            // txtASUNTO
            // 
            this.txtASUNTO.Location = new System.Drawing.Point(117, 47);
            this.txtASUNTO.Multiline = true;
            this.txtASUNTO.Name = "txtASUNTO";
            this.txtASUNTO.Size = new System.Drawing.Size(344, 20);
            this.txtASUNTO.TabIndex = 4;
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(117, 87);
            this.txtMS.Multiline = true;
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(344, 156);
            this.txtMS.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADJUNTAR ARCHIVOS";
            // 
            // lblDocs
            // 
            this.lblDocs.AutoSize = true;
            this.lblDocs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocs.Location = new System.Drawing.Point(13, 284);
            this.lblDocs.Name = "lblDocs";
            this.lblDocs.Size = new System.Drawing.Size(19, 13);
            this.lblDocs.TabIndex = 7;
            this.lblDocs.Text = "...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADJUNTAR ARCHIVOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnENV
            // 
            this.btnENV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENV.Location = new System.Drawing.Point(282, 358);
            this.btnENV.Name = "btnENV";
            this.btnENV.Size = new System.Drawing.Size(75, 23);
            this.btnENV.TabIndex = 9;
            this.btnENV.Text = "ENVIAR";
            this.btnENV.UseVisualStyleBackColor = true;
            this.btnENV.Click += new System.EventHandler(this.btnENV_Click);
            // 
            // txtClean
            // 
            this.txtClean.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClean.Location = new System.Drawing.Point(281, 255);
            this.txtClean.Name = "txtClean";
            this.txtClean.Size = new System.Drawing.Size(87, 23);
            this.txtClean.TabIndex = 10;
            this.txtClean.Text = "LIMPIAR";
            this.txtClean.UseVisualStyleBackColor = true;
            this.txtClean.Click += new System.EventHandler(this.txtClean_Click);
            // 
            // dgvCorreo
            // 
            this.dgvCorreo.AutoGenerateColumns = false;
            this.dgvCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaEnvioDataGridViewTextBoxColumn,
            this.destinatarioDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.mensajeDataGridViewTextBoxColumn});
            this.dgvCorreo.DataSource = this.correosBindingSource;
            this.dgvCorreo.Location = new System.Drawing.Point(484, 45);
            this.dgvCorreo.Name = "dgvCorreo";
            this.dgvCorreo.Size = new System.Drawing.Size(541, 348);
            this.dgvCorreo.TabIndex = 11;
            this.dgvCorreo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEnvioDataGridViewTextBoxColumn
            // 
            this.fechaEnvioDataGridViewTextBoxColumn.DataPropertyName = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.HeaderText = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.Name = "fechaEnvioDataGridViewTextBoxColumn";
            // 
            // destinatarioDataGridViewTextBoxColumn
            // 
            this.destinatarioDataGridViewTextBoxColumn.DataPropertyName = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.HeaderText = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.Name = "destinatarioDataGridViewTextBoxColumn";
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            // 
            // mensajeDataGridViewTextBoxColumn
            // 
            this.mensajeDataGridViewTextBoxColumn.DataPropertyName = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn.Name = "mensajeDataGridViewTextBoxColumn";
            // 
            // correosBindingSource
            // 
            this.correosBindingSource.DataMember = "Correos";
            this.correosBindingSource.DataSource = this.correosDBDataSet;
            // 
            // correosDBDataSet
            // 
            this.correosDBDataSet.DataSetName = "CorreosDBDataSet";
            this.correosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(190, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRST
            // 
            this.btnRST.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRST.Location = new System.Drawing.Point(-2, 12);
            this.btnRST.Name = "btnRST";
            this.btnRST.Size = new System.Drawing.Size(124, 25);
            this.btnRST.TabIndex = 13;
            this.btnRST.Text = "RESULTADOS";
            this.btnRST.UseVisualStyleBackColor = true;
            this.btnRST.Click += new System.EventHandler(this.btnRST_Click);
            // 
            // correosTableAdapter
            // 
            this.correosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-5, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 402);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDate2);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblHour2);
            this.panel2.Controls.Add(this.lblHour);
            this.panel2.Controls.Add(this.btnRST);
            this.panel2.Location = new System.Drawing.Point(484, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 392);
            this.panel2.TabIndex = 15;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(133, 15);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(53, 16);
            this.lblHour.TabIndex = 14;
            this.lblHour.Text = "HORA:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnENV);
            this.panel3.Controls.Add(this.lblDocs);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(104, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 394);
            this.panel3.TabIndex = 16;
            // 
            // lblHour2
            // 
            this.lblHour2.AutoSize = true;
            this.lblHour2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour2.Location = new System.Drawing.Point(192, 16);
            this.lblHour2.Name = "lblHour2";
            this.lblHour2.Size = new System.Drawing.Size(40, 15);
            this.lblHour2.TabIndex = 15;
            this.lblHour2.Text = "label5";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(279, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 16);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "FECHA:";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(345, 15);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(40, 15);
            this.lblDate2.TabIndex = 17;
            this.lblDate2.Text = "label7";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SEGUNDO_PARCIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 393);
            this.Controls.Add(this.dgvCorreo);
            this.Controls.Add(this.txtClean);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.txtASUNTO);
            this.Controls.Add(this.txtMF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "SEGUNDO_PARCIAL";
            this.Text = "SEGUNDO_PARCIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correosDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMF;
        private System.Windows.Forms.TextBox txtASUNTO;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDocs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnENV;
        private System.Windows.Forms.Button txtClean;
        private System.Windows.Forms.DataGridView dgvCorreo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRST;
        private CorreosDBDataSet correosDBDataSet;
        private System.Windows.Forms.BindingSource correosBindingSource;
        private CorreosDBDataSetTableAdapters.CorreosTableAdapter correosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour2;
        private System.Windows.Forms.Timer timer1;
    }
}

