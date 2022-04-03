namespace zaslab
{
    partial class v_VerEstu
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
            this.dtgv_verest = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.rdb_Nombre = new System.Windows.Forms.RadioButton();
            this.rdb_id = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_verest)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_verest
            // 
            this.dtgv_verest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_verest.Location = new System.Drawing.Point(12, 75);
            this.dtgv_verest.Name = "dtgv_verest";
            this.dtgv_verest.RowHeadersWidth = 51;
            this.dtgv_verest.RowTemplate.Height = 29;
            this.dtgv_verest.Size = new System.Drawing.Size(776, 363);
            this.dtgv_verest.TabIndex = 0;
            this.dtgv_verest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(470, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(106, 29);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // rdb_Nombre
            // 
            this.rdb_Nombre.AutoSize = true;
            this.rdb_Nombre.Location = new System.Drawing.Point(12, 12);
            this.rdb_Nombre.Name = "rdb_Nombre";
            this.rdb_Nombre.Size = new System.Drawing.Size(80, 24);
            this.rdb_Nombre.TabIndex = 4;
            this.rdb_Nombre.TabStop = true;
            this.rdb_Nombre.Text = "Nombe";
            this.rdb_Nombre.UseVisualStyleBackColor = true;
            // 
            // rdb_id
            // 
            this.rdb_id.AutoSize = true;
            this.rdb_id.Location = new System.Drawing.Point(12, 42);
            this.rdb_id.Name = "rdb_id";
            this.rdb_id.Size = new System.Drawing.Size(45, 24);
            this.rdb_id.TabIndex = 5;
            this.rdb_id.TabStop = true;
            this.rdb_id.Text = "ID";
            this.rdb_id.UseVisualStyleBackColor = true;
            // 
            // v_VerEstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdb_id);
            this.Controls.Add(this.rdb_Nombre);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgv_verest);
            this.Name = "v_VerEstu";
            this.Text = "Ver estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_verest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgv_verest;
        private TextBox textBox1;
        private Button btn_Buscar;
        private RadioButton rdb_Nombre;
        private RadioButton rdb_id;
    }
}