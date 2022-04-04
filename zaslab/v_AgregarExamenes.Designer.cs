namespace zaslab
{
    partial class v_AgregarExamenes
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.btnSangre = new System.Windows.Forms.Button();
            this.btnOrina = new System.Windows.Forms.Button();
            this.btnHeces = new System.Windows.Forms.Button();
            this.lbNumExam = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "N° Examen";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(1006, 72);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 20);
            this.lbId.TabIndex = 32;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(955, 151);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(0, 20);
            this.lbEdad.TabIndex = 31;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(955, 115);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 20);
            this.lbNombre.TabIndex = 30;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(992, 464);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(890, 464);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Examenes";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(854, 72);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(165, 20);
            this.id.TabIndex = 26;
            this.id.Text = "Código de Beneficiario:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(854, 151);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(46, 20);
            this.edad.TabIndex = 25;
            this.edad.Text = "Edad:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(854, 113);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 20);
            this.nombre.TabIndex = 24;
            this.nombre.Text = "Nombre:";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(24, 72);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 25;
            this.dgvEstudiantes.Size = new System.Drawing.Size(823, 440);
            this.dgvEstudiantes.TabIndex = 23;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtEstudiantes_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(144, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(481, 27);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(30, 37);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(45, 24);
            this.rbtnId.TabIndex = 20;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(30, 4);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(85, 24);
            this.rbtnNombre.TabIndex = 19;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // btnSangre
            // 
            this.btnSangre.Location = new System.Drawing.Point(854, 328);
            this.btnSangre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSangre.Name = "btnSangre";
            this.btnSangre.Size = new System.Drawing.Size(277, 31);
            this.btnSangre.TabIndex = 34;
            this.btnSangre.Text = "Biometria Hemática Completa (BHC)";
            this.btnSangre.UseVisualStyleBackColor = true;
            this.btnSangre.Click += new System.EventHandler(this.btnSangre_Click);
            // 
            // btnOrina
            // 
            this.btnOrina.Location = new System.Drawing.Point(854, 367);
            this.btnOrina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrina.Name = "btnOrina";
            this.btnOrina.Size = new System.Drawing.Size(277, 31);
            this.btnOrina.TabIndex = 35;
            this.btnOrina.Text = "Examen General de Orina (EGO)";
            this.btnOrina.UseVisualStyleBackColor = true;
            this.btnOrina.Click += new System.EventHandler(this.btnOrina_Click);
            // 
            // btnHeces
            // 
            this.btnHeces.Location = new System.Drawing.Point(854, 405);
            this.btnHeces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHeces.Name = "btnHeces";
            this.btnHeces.Size = new System.Drawing.Size(277, 31);
            this.btnHeces.TabIndex = 36;
            this.btnHeces.Text = "Examen General de Heces";
            this.btnHeces.UseVisualStyleBackColor = true;
            this.btnHeces.Click += new System.EventHandler(this.btnHeces_Click);
            // 
            // lbNumExam
            // 
            this.lbNumExam.AutoSize = true;
            this.lbNumExam.Location = new System.Drawing.Point(961, 197);
            this.lbNumExam.Name = "lbNumExam";
            this.lbNumExam.Size = new System.Drawing.Size(0, 20);
            this.lbNumExam.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1006, 237);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 27);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(854, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha del Informe";
            // 
            // v_AgregarExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNumExam);
            this.Controls.Add(this.btnHeces);
            this.Controls.Add(this.btnOrina);
            this.Controls.Add(this.btnSangre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.rbtnNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "v_AgregarExamenes";
            this.Text = "Agregar Resultados";
            this.Load += new System.EventHandler(this.v_AgregarExamenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label lbId;
        private Label lbEdad;
        private Label lbNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label label1;
        private Label id;
        private Label edad;
        private Label nombre;
        private DataGridView dgvEstudiantes;
        private TextBox txtBuscar;
        private RadioButton rbtnId;
        private RadioButton rbtnNombre;
        private Button btnSangre;
        private Button btnOrina;
        private Button btnHeces;
        private Label lbNumExam;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}