namespace zaslab
{
    partial class v_EgregarExam
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
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgtEstudiantes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbSangre = new System.Windows.Forms.CheckBox();
            this.chbOrina = new System.Windows.Forms.CheckBox();
            this.chbHeces = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumExam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(14, 3);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(69, 19);
            this.rbtnNombre.TabIndex = 0;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(14, 28);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(36, 19);
            this.rbtnId.TabIndex = 1;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(421, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgtEstudiantes
            // 
            this.dgtEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtEstudiantes.Location = new System.Drawing.Point(9, 54);
            this.dgtEstudiantes.Name = "dgtEstudiantes";
            this.dgtEstudiantes.RowTemplate.Height = 25;
            this.dgtEstudiantes.Size = new System.Drawing.Size(494, 308);
            this.dgtEstudiantes.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(509, 65);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(54, 15);
            this.nombre.TabIndex = 5;
            this.nombre.Text = "Nombre:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(509, 92);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(36, 15);
            this.edad.TabIndex = 7;
            this.edad.Text = "Edad:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(509, 122);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 15);
            this.id.TabIndex = 8;
            this.id.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Examenes";
            // 
            // chbSangre
            // 
            this.chbSangre.AutoSize = true;
            this.chbSangre.Location = new System.Drawing.Point(512, 173);
            this.chbSangre.Name = "chbSangre";
            this.chbSangre.Size = new System.Drawing.Size(221, 19);
            this.chbSangre.TabIndex = 10;
            this.chbSangre.Text = "Biometria Hemática Completa (BHC)";
            this.chbSangre.UseVisualStyleBackColor = true;
            // 
            // chbOrina
            // 
            this.chbOrina.AutoSize = true;
            this.chbOrina.Location = new System.Drawing.Point(512, 198);
            this.chbOrina.Name = "chbOrina";
            this.chbOrina.Size = new System.Drawing.Size(193, 19);
            this.chbOrina.TabIndex = 11;
            this.chbOrina.Text = "Examen General de Orina (EGO)";
            this.chbOrina.UseVisualStyleBackColor = true;
            // 
            // chbHeces
            // 
            this.chbHeces.AutoSize = true;
            this.chbHeces.Location = new System.Drawing.Point(512, 223);
            this.chbHeces.Name = "chbHeces";
            this.chbHeces.Size = new System.Drawing.Size(162, 19);
            this.chbHeces.TabIndex = 12;
            this.chbHeces.Text = "Examen General de Heces";
            this.chbHeces.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(519, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(600, 287);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(598, 66);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(67, 15);
            this.lbNombre.TabIndex = 15;
            this.lbNombre.Text = "josue mejia";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(598, 92);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(19, 15);
            this.lbEdad.TabIndex = 16;
            this.lbEdad.Text = "23";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(598, 122);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(25, 15);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "N° Examen";
            // 
            // txtNumExam
            // 
            this.txtNumExam.Location = new System.Drawing.Point(598, 248);
            this.txtNumExam.Name = "txtNumExam";
            this.txtNumExam.Size = new System.Drawing.Size(100, 23);
            this.txtNumExam.TabIndex = 19;
            // 
            // v_EgregarExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 374);
            this.Controls.Add(this.txtNumExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chbHeces);
            this.Controls.Add(this.chbOrina);
            this.Controls.Add(this.chbSangre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dgtEstudiantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.rbtnNombre);
            this.Name = "v_EgregarExam";
            this.Text = "v_EgregarExam";
            ((System.ComponentModel.ISupportInitialize)(this.dgtEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbtnNombre;
        private RadioButton rbtnId;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgtEstudiantes;
        private Label nombre;
        private Label edad;
        private Label id;
        private Label label1;
        private CheckBox chbSangre;
        private CheckBox chbOrina;
        private CheckBox chbHeces;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lbNombre;
        private Label lbEdad;
        private Label lbId;
        private Label label2;
        private TextBox txtNumExam;
    }
}