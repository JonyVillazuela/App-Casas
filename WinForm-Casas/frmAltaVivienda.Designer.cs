namespace WinForm_Casas
{
    partial class frmAltaVivienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtAmbientes = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVentana = new System.Windows.Forms.Label();
            this.lblCalefaccion = new System.Windows.Forms.Label();
            this.cboVentana = new System.Windows.Forms.ComboBox();
            this.cboCalefaccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDormitorios = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.cboPiscina = new System.Windows.Forms.ComboBox();
            this.lblImagenDescriptiva = new System.Windows.Forms.Label();
            this.txtImagenDescriptiva = new System.Windows.Forms.TextBox();
            this.pbxCasas = new System.Windows.Forms.PictureBox();
            this.AgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casa/Lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ambientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "M2:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(113, 15);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(121, 20);
            this.txtLote.TabIndex = 0;
            // 
            // txtAmbientes
            // 
            this.txtAmbientes.Location = new System.Drawing.Point(113, 50);
            this.txtAmbientes.Name = "txtAmbientes";
            this.txtAmbientes.Size = new System.Drawing.Size(121, 20);
            this.txtAmbientes.TabIndex = 1;
            // 
            // txtM2
            // 
            this.txtM2.Location = new System.Drawing.Point(113, 76);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(121, 20);
            this.txtM2.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(48, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVentana
            // 
            this.lblVentana.AutoSize = true;
            this.lblVentana.Location = new System.Drawing.Point(14, 224);
            this.lblVentana.Name = "lblVentana";
            this.lblVentana.Size = new System.Drawing.Size(93, 13);
            this.lblVentana.TabIndex = 8;
            this.lblVentana.Text = "Tipo de ventanas:";
            // 
            // lblCalefaccion
            // 
            this.lblCalefaccion.AutoSize = true;
            this.lblCalefaccion.Location = new System.Drawing.Point(3, 251);
            this.lblCalefaccion.Name = "lblCalefaccion";
            this.lblCalefaccion.Size = new System.Drawing.Size(104, 13);
            this.lblCalefaccion.TabIndex = 9;
            this.lblCalefaccion.Text = "Tipo de calefacción:";
            // 
            // cboVentana
            // 
            this.cboVentana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVentana.FormattingEnabled = true;
            this.cboVentana.Location = new System.Drawing.Point(113, 216);
            this.cboVentana.Name = "cboVentana";
            this.cboVentana.Size = new System.Drawing.Size(121, 21);
            this.cboVentana.TabIndex = 7;
            // 
            // cboCalefaccion
            // 
            this.cboCalefaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalefaccion.FormattingEnabled = true;
            this.cboCalefaccion.Location = new System.Drawing.Point(113, 243);
            this.cboCalefaccion.Name = "cboCalefaccion";
            this.cboCalefaccion.Size = new System.Drawing.Size(121, 21);
            this.cboCalefaccion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dormitorios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Baños:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Piscina:";
            // 
            // txtDormitorios
            // 
            this.txtDormitorios.Location = new System.Drawing.Point(113, 129);
            this.txtDormitorios.Name = "txtDormitorios";
            this.txtDormitorios.Size = new System.Drawing.Size(121, 20);
            this.txtDormitorios.TabIndex = 4;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(113, 155);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(121, 20);
            this.txtBaños.TabIndex = 5;
            // 
            // cboPiscina
            // 
            this.cboPiscina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPiscina.FormattingEnabled = true;
            this.cboPiscina.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cboPiscina.Location = new System.Drawing.Point(113, 181);
            this.cboPiscina.Name = "cboPiscina";
            this.cboPiscina.Size = new System.Drawing.Size(121, 21);
            this.cboPiscina.TabIndex = 6;
            // 
            // lblImagenDescriptiva
            // 
            this.lblImagenDescriptiva.AutoSize = true;
            this.lblImagenDescriptiva.Location = new System.Drawing.Point(14, 107);
            this.lblImagenDescriptiva.Name = "lblImagenDescriptiva";
            this.lblImagenDescriptiva.Size = new System.Drawing.Size(99, 13);
            this.lblImagenDescriptiva.TabIndex = 18;
            this.lblImagenDescriptiva.Text = "Imagen descriptiva:";
            // 
            // txtImagenDescriptiva
            // 
            this.txtImagenDescriptiva.Location = new System.Drawing.Point(113, 100);
            this.txtImagenDescriptiva.Name = "txtImagenDescriptiva";
            this.txtImagenDescriptiva.Size = new System.Drawing.Size(121, 20);
            this.txtImagenDescriptiva.TabIndex = 3;
            this.txtImagenDescriptiva.Leave += new System.EventHandler(this.txtImagenDescriptiva_Leave);
            // 
            // pbxCasas
            // 
            this.pbxCasas.Location = new System.Drawing.Point(289, 15);
            this.pbxCasas.Name = "pbxCasas";
            this.pbxCasas.Size = new System.Drawing.Size(318, 259);
            this.pbxCasas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCasas.TabIndex = 20;
            this.pbxCasas.TabStop = false;
            // 
            // AgregarImagen
            // 
            this.AgregarImagen.Location = new System.Drawing.Point(240, 100);
            this.AgregarImagen.Name = "AgregarImagen";
            this.AgregarImagen.Size = new System.Drawing.Size(32, 20);
            this.AgregarImagen.TabIndex = 21;
            this.AgregarImagen.Text = "+";
            this.AgregarImagen.UseVisualStyleBackColor = true;
            this.AgregarImagen.Click += new System.EventHandler(this.AgregarImagen_Click);
            // 
            // frmAltaVivienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 386);
            this.Controls.Add(this.AgregarImagen);
            this.Controls.Add(this.pbxCasas);
            this.Controls.Add(this.txtImagenDescriptiva);
            this.Controls.Add(this.lblImagenDescriptiva);
            this.Controls.Add(this.cboPiscina);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtDormitorios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCalefaccion);
            this.Controls.Add(this.cboVentana);
            this.Controls.Add(this.lblCalefaccion);
            this.Controls.Add(this.lblVentana);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(this.txtAmbientes);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaVivienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Vivienda";
            this.Load += new System.EventHandler(this.frmAltaVivienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtAmbientes;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVentana;
        private System.Windows.Forms.Label lblCalefaccion;
        private System.Windows.Forms.ComboBox cboVentana;
        private System.Windows.Forms.ComboBox cboCalefaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDormitorios;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.ComboBox cboPiscina;
        private System.Windows.Forms.Label lblImagenDescriptiva;
        private System.Windows.Forms.TextBox txtImagenDescriptiva;
        private System.Windows.Forms.PictureBox pbxCasas;
        private System.Windows.Forms.Button AgregarImagen;
    }
}