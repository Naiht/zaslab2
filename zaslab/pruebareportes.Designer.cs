namespace zaslab
{
    partial class pruebareportes
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.bnt_ImprTodo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(683, 25);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.RowHeadersWidth = 51;
            this.dgv_resultado.RowTemplate.Height = 29;
            this.dgv_resultado.Size = new System.Drawing.Size(106, 24);
            this.dgv_resultado.TabIndex = 1;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(17, 76);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 25;
            this.dgvEstudiantes.Size = new System.Drawing.Size(772, 440);
            this.dgvEstudiantes.TabIndex = 27;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(137, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(481, 27);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(23, 41);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(45, 24);
            this.rbtnId.TabIndex = 25;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(23, 8);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(85, 24);
            this.rbtnNombre.TabIndex = 24;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // bnt_ImprTodo
            // 
            this.bnt_ImprTodo.Location = new System.Drawing.Point(556, 526);
            this.bnt_ImprTodo.Name = "bnt_ImprTodo";
            this.bnt_ImprTodo.Size = new System.Drawing.Size(133, 29);
            this.bnt_ImprTodo.TabIndex = 28;
            this.bnt_ImprTodo.Text = "Generar Todo";
            this.bnt_ImprTodo.UseVisualStyleBackColor = true;
            this.bnt_ImprTodo.Click += new System.EventHandler(this.bnt_ImprTodo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Ruta";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(17, 534);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(149, 20);
            this.lbl_total.TabIndex = 29;
            this.lbl_total.Text = "EGO: 0 EGH: 0 BHC: 0";
            // 
            // pruebareportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 567);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.bnt_ImprTodo);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "pruebareportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.pruebareportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dgv_resultado;
        private DataGridView dgvEstudiantes;
        private TextBox txtBuscar;
        private RadioButton rbtnId;
        private RadioButton rbtnNombre;
        private Button bnt_ImprTodo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label lbl_total;
    }
}