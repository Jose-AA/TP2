namespace TP2
{
    partial class FrmAgregarMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TexBoxIdNM = new System.Windows.Forms.TextBox();
            this.TexBoxNombreNM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonAceptarNM = new System.Windows.Forms.Button();
            this.MarcasRegistradas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgMarcas = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR NUEVA MARCA";
            // 
            // TexBoxIdNM
            // 
            this.TexBoxIdNM.Enabled = false;
            this.TexBoxIdNM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TexBoxIdNM.Location = new System.Drawing.Point(130, 136);
            this.TexBoxIdNM.Name = "TexBoxIdNM";
            this.TexBoxIdNM.Size = new System.Drawing.Size(53, 20);
            this.TexBoxIdNM.TabIndex = 1;
            // 
            // TexBoxNombreNM
            // 
            this.TexBoxNombreNM.Location = new System.Drawing.Point(130, 176);
            this.TexBoxNombreNM.Name = "TexBoxNombreNM";
            this.TexBoxNombreNM.Size = new System.Drawing.Size(234, 20);
            this.TexBoxNombreNM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(44, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // BotonAceptarNM
            // 
            this.BotonAceptarNM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonAceptarNM.Location = new System.Drawing.Point(240, 243);
            this.BotonAceptarNM.Name = "BotonAceptarNM";
            this.BotonAceptarNM.Size = new System.Drawing.Size(149, 29);
            this.BotonAceptarNM.TabIndex = 5;
            this.BotonAceptarNM.Text = "Agregar Marca";
            this.BotonAceptarNM.UseVisualStyleBackColor = true;
            this.BotonAceptarNM.Click += new System.EventHandler(this.BotonAceptarNM_Click);
            // 
            // MarcasRegistradas
            // 
            this.MarcasRegistradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarcasRegistradas.AutoSize = true;
            this.MarcasRegistradas.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcasRegistradas.ForeColor = System.Drawing.Color.Navy;
            this.MarcasRegistradas.Location = new System.Drawing.Point(12, 285);
            this.MarcasRegistradas.Name = "MarcasRegistradas";
            this.MarcasRegistradas.Size = new System.Drawing.Size(243, 28);
            this.MarcasRegistradas.TabIndex = 7;
            this.MarcasRegistradas.Text = "MarcasRegistradas";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(239, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgMarcas
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            this.dtgMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMarcas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgMarcas.Location = new System.Drawing.Point(12, 335);
            this.dtgMarcas.MultiSelect = false;
            this.dtgMarcas.Name = "dtgMarcas";
            this.dtgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMarcas.ShowEditingIcon = false;
            this.dtgMarcas.Size = new System.Drawing.Size(261, 236);
            this.dtgMarcas.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TP2.Properties.Resources.cerrar_sesion;
            this.pictureBox2.Location = new System.Drawing.Point(394, 595);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2.Properties.Resources.nuevo_producto__4_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(442, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtgMarcas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MarcasRegistradas);
            this.Controls.Add(this.BotonAceptarNM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TexBoxNombreNM);
            this.Controls.Add(this.TexBoxIdNM);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 686);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(458, 686);
            this.Name = "FrmAgregarMarca";
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TexBoxIdNM;
        private System.Windows.Forms.TextBox TexBoxNombreNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonAceptarNM;
        private System.Windows.Forms.Label MarcasRegistradas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgMarcas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}