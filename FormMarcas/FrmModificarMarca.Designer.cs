namespace TP2
{
    partial class FrmModificarMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvModificarM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Descripcion_a_Modificar = new System.Windows.Forms.TextBox();
            this.IdModificacion = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModificarM
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dgvModificarM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModificarM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvModificarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvModificarM.Location = new System.Drawing.Point(66, 103);
            this.dgvModificarM.MultiSelect = false;
            this.dgvModificarM.Name = "dgvModificarM";
            this.dgvModificarM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificarM.ShowEditingIcon = false;
            this.dgvModificarM.Size = new System.Drawing.Size(256, 284);
            this.dgvModificarM.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descripcion_a_Modificar
            // 
            this.Descripcion_a_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_a_Modificar.Location = new System.Drawing.Point(64, 509);
            this.Descripcion_a_Modificar.Name = "Descripcion_a_Modificar";
            this.Descripcion_a_Modificar.Size = new System.Drawing.Size(258, 31);
            this.Descripcion_a_Modificar.TabIndex = 2;
            // 
            // IdModificacion
            // 
            this.IdModificacion.Enabled = false;
            this.IdModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdModificacion.Location = new System.Drawing.Point(66, 461);
            this.IdModificacion.Name = "IdModificacion";
            this.IdModificacion.Size = new System.Drawing.Size(56, 31);
            this.IdModificacion.TabIndex = 3;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(66, 402);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(256, 37);
            this.BtnSeleccionar.TabIndex = 4;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "MODIFICAR MARCA";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(60, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione la marca a modificar :";
            // 
            // FrmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(396, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.IdModificacion);
            this.Controls.Add(this.Descripcion_a_Modificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvModificarM);
            this.Name = "FrmModificarMarca";
            this.Text = "FrmModificarMarca";
            this.Load += new System.EventHandler(this.FrmModificarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModificarM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Descripcion_a_Modificar;
        private System.Windows.Forms.TextBox IdModificacion;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}