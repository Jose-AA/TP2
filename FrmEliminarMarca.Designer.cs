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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSeleccionarEM = new System.Windows.Forms.Button();
            this.IdEliminacion = new System.Windows.Forms.TextBox();
            this.Descripcion_a_Eliminar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dgvEliminarM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarM)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(55, 65);
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
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "ELIMINAR MARCA";
            // 
            // BtnSeleccionarEM
            // 
            this.BtnSeleccionarEM.Location = new System.Drawing.Point(61, 398);
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
            this.IdEliminacion.Location = new System.Drawing.Point(61, 457);
            this.IdEliminacion.Name = "IdEliminacion";
            this.IdEliminacion.Size = new System.Drawing.Size(56, 31);
            this.IdEliminacion.TabIndex = 10;
            // 
            // Descripcion_a_Eliminar
            // 
            this.Descripcion_a_Eliminar.AccessibleName = "CajadescEliminacion";
            this.Descripcion_a_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_a_Eliminar.Location = new System.Drawing.Point(59, 505);
            this.Descripcion_a_Eliminar.Name = "Descripcion_a_Eliminar";
            this.Descripcion_a_Eliminar.Size = new System.Drawing.Size(258, 31);
            this.Descripcion_a_Eliminar.TabIndex = 9;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(59, 557);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(256, 37);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgvEliminarM
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            this.dgvEliminarM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEliminarM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEliminarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEliminarM.Location = new System.Drawing.Point(61, 99);
            this.dgvEliminarM.MultiSelect = false;
            this.dgvEliminarM.Name = "dgvEliminarM";
            this.dgvEliminarM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarM.ShowEditingIcon = false;
            this.dgvEliminarM.Size = new System.Drawing.Size(256, 284);
            this.dgvEliminarM.TabIndex = 7;
            // 
            // FrmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionarEM);
            this.Controls.Add(this.IdEliminacion);
            this.Controls.Add(this.Descripcion_a_Eliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.dgvEliminarM);
            this.Name = "FrmEliminarMarca";
            this.Text = "FrmEliminarMarca";
            this.Load += new System.EventHandler(this.FrmEliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarM)).EndInit();
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
    }
}