namespace zaslab
{
    partial class v_eliminar
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(761, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(17, 52);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowTemplate.Height = 25;
            this.dgvEstudiantes.Size = new System.Drawing.Size(726, 298);
            this.dgvEstudiantes.TabIndex = 18;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(122, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(421, 23);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(22, 26);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(36, 19);
            this.rbtnId.TabIndex = 16;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(22, 1);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(69, 19);
            this.rbtnNombre.TabIndex = 15;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // v_eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 362);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.rbtnNombre);
            this.Name = "v_eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.v_eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEliminar;
        private DataGridView dgvEstudiantes;
        private TextBox txtBuscar;
        private RadioButton rbtnId;
        private RadioButton rbtnNombre;
    }
}