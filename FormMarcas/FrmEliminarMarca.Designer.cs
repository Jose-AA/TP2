namespace TP2
{
    partial class FrmEliminarMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSeleccionarEM = new System.Windows.Forms.Button();
            this.IdEliminacion = new System.Windows.Forms.TextBox();
            this.Descripcion_a_Eliminar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dgvEliminarM = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(60, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecione la marca a eliminar :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "ELIMINAR MARCA";
            // 
            // BtnSeleccionarEM
            // 
            this.BtnSeleccionarEM.Location = new System.Drawing.Point(66, 467);
            this.BtnSeleccionarEM.Name = "BtnSeleccionarEM";
            this.BtnSeleccionarEM.Size = new System.Drawing.Size(256, 37);
            this.BtnSeleccionarEM.TabIndex = 11;
            this.BtnSeleccionarEM.Text = "Seleccionar";
            this.BtnSeleccionarEM.UseVisualStyleBackColor = true;
            this.BtnSeleccionarEM.Click += new System.EventHandler(this.BtnSeleccionarEM_Click);
            // 
            // IdEliminacion
            // 
            this.IdEliminacion.AccessibleName = "";
            this.IdEliminacion.Enabled = false;
            this.IdEliminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdEliminacion.Location = new System.Drawing.Point(66, 526);
            this.IdEliminacion.Name = "IdEliminacion";
            this.IdEliminacion.Size = new System.Drawing.Size(56, 31);
            this.IdEliminacion.TabIndex = 10;
            // 
            // Descripcion_a_Eliminar
            // 
            this.Descripcion_a_Eliminar.AccessibleName = "CajadescEliminacion";
            this.Descripcion_a_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_a_Eliminar.Location = new System.Drawing.Point(64, 574);
            this.Descripcion_a_Eliminar.Name = "Descripcion_a_Eliminar";
            this.Descripcion_a_Eliminar.Size = new System.Drawing.Size(258, 31);
            this.Descripcion_a_Eliminar.TabIndex = 9;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(64, 626);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(256, 37);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgvEliminarM
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            this.dgvEliminarM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEliminarM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEliminarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEliminarM.Location = new System.Drawing.Point(66, 168);
            this.dgvEliminarM.MultiSelect = false;
            this.dgvEliminarM.Name = "dgvEliminarM";
            this.dgvEliminarM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarM.ShowEditingIcon = false;
            this.dgvEliminarM.Size = new System.Drawing.Size(256, 284);
            this.dgvEliminarM.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2.Properties.Resources.eliminar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 69);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TP2.Properties.Resources.cerrar_sesion;
            this.pictureBox2.Location = new System.Drawing.Point(285, 689);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 45);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // FrmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(373, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionarEM);
            this.Controls.Add(this.IdEliminacion);
            this.Controls.Add(this.Descripcion_a_Eliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.dgvEliminarM);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 788);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 726);
            this.Name = "FrmEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Marca";
            this.Load += new System.EventHandler(this.FrmEliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSeleccionarEM;
        private System.Windows.Forms.TextBox IdEliminacion;
        private System.Windows.Forms.TextBox Descripcion_a_Eliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dgvEliminarM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}