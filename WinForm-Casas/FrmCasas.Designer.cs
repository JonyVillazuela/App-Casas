namespace WinForm_Casas
{
    partial class FrmCasas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvViviendas = new System.Windows.Forms.DataGridView();
            this.pbxCasas = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViviendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViviendas
            // 
            this.dgvViviendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViviendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViviendas.Location = new System.Drawing.Point(12, 37);
            this.dgvViviendas.MultiSelect = false;
            this.dgvViviendas.Name = "dgvViviendas";
            this.dgvViviendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViviendas.Size = new System.Drawing.Size(558, 166);
            this.dgvViviendas.TabIndex = 0;
            this.dgvViviendas.SelectionChanged += new System.EventHandler(this.dgvViviendas_SelectionChanged);
            // 
            // pbxCasas
            // 
            this.pbxCasas.Location = new System.Drawing.Point(576, 37);
            this.pbxCasas.Name = "pbxCasas";
            this.pbxCasas.Size = new System.Drawing.Size(284, 166);
            this.pbxCasas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCasas.TabIndex = 1;
            this.pbxCasas.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(107, 222);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(207, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(320, 222);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar Físico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // FrmCasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 309);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxCasas);
            this.Controls.Add(this.dgvViviendas);
            this.Name = "FrmCasas";
            this.Text = "FrmCasas";
            this.Load += new System.EventHandler(this.FrmCasas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViviendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCasas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViviendas;
        private System.Windows.Forms.PictureBox pbxCasas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
    }
}

