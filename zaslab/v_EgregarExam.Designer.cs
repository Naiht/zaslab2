﻿namespace zaslab
{
    partial class v_AgregarExam
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
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
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
            this.dtpTomaMuestra = new System.Windows.Forms.DateTimePicker();
            this.dtpRecepcionMuestra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTomaDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTomaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(16, 4);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(85, 24);
            this.rbtnNombre.TabIndex = 0;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(16, 37);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(45, 24);
            this.rbtnId.TabIndex = 1;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "ID";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(130, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(481, 27);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(10, 72);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 25;
            this.dgvEstudiantes.Size = new System.Drawing.Size(830, 397);
            this.dgvEstudiantes.TabIndex = 4;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(847, 109);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 20);
            this.nombre.TabIndex = 5;
            this.nombre.Text = "Nombre:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(847, 144);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(46, 20);
            this.edad.TabIndex = 7;
            this.edad.Text = "Edad:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(847, 72);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(165, 20);
            this.id.TabIndex = 8;
            this.id.Text = "Código de Beneficiario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Examenes";
            // 
            // chbSangre
            // 
            this.chbSangre.AutoSize = true;
            this.chbSangre.Location = new System.Drawing.Point(850, 287);
            this.chbSangre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbSangre.Name = "chbSangre";
            this.chbSangre.Size = new System.Drawing.Size(276, 24);
            this.chbSangre.TabIndex = 10;
            this.chbSangre.Text = "Biometria Hemática Completa (BHC)";
            this.chbSangre.UseVisualStyleBackColor = true;
            // 
            // chbOrina
            // 
            this.chbOrina.AutoSize = true;
            this.chbOrina.Location = new System.Drawing.Point(850, 320);
            this.chbOrina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbOrina.Name = "chbOrina";
            this.chbOrina.Size = new System.Drawing.Size(242, 24);
            this.chbOrina.TabIndex = 11;
            this.chbOrina.Text = "Examen General de Orina (EGO)";
            this.chbOrina.UseVisualStyleBackColor = true;
            // 
            // chbHeces
            // 
            this.chbHeces.AutoSize = true;
            this.chbHeces.Location = new System.Drawing.Point(850, 353);
            this.chbHeces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbHeces.Name = "chbHeces";
            this.chbHeces.Size = new System.Drawing.Size(203, 24);
            this.chbHeces.TabIndex = 12;
            this.chbHeces.Text = "Examen General de Heces";
            this.chbHeces.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(858, 439);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(951, 439);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(915, 109);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 20);
            this.lbNombre.TabIndex = 15;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(915, 144);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(0, 20);
            this.lbEdad.TabIndex = 16;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(993, 72);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 20);
            this.lbId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "N° Examen";
            // 
            // txtNumExam
            // 
            this.txtNumExam.Location = new System.Drawing.Point(949, 387);
            this.txtNumExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumExam.Name = "txtNumExam";
            this.txtNumExam.Size = new System.Drawing.Size(114, 27);
            this.txtNumExam.TabIndex = 19;
            // 
            // dtpTomaMuestra
            // 
            this.dtpTomaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTomaMuestra.Location = new System.Drawing.Point(1006, 171);
            this.dtpTomaMuestra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTomaMuestra.Name = "dtpTomaMuestra";
            this.dtpTomaMuestra.Size = new System.Drawing.Size(117, 27);
            this.dtpTomaMuestra.TabIndex = 20;
            // 
            // dtpRecepcionMuestra
            // 
            this.dtpRecepcionMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecepcionMuestra.Location = new System.Drawing.Point(1006, 223);
            this.dtpRecepcionMuestra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpRecepcionMuestra.Name = "dtpRecepcionMuestra";
            this.dtpRecepcionMuestra.Size = new System.Drawing.Size(117, 27);
            this.dtpRecepcionMuestra.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Toma de Muestra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Recepción de Muestra";
            // 
            // dgvTomaDatos
            // 
            this.dgvTomaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTomaDatos.Location = new System.Drawing.Point(1026, 53);
            this.dgvTomaDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTomaDatos.Name = "dgvTomaDatos";
            this.dgvTomaDatos.RowHeadersWidth = 51;
            this.dgvTomaDatos.RowTemplate.Height = 25;
            this.dgvTomaDatos.Size = new System.Drawing.Size(97, 76);
            this.dgvTomaDatos.TabIndex = 24;
            this.dgvTomaDatos.Visible = false;
            // 
            // v_AgregarExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 483);
            this.Controls.Add(this.dgvTomaDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRecepcionMuestra);
            this.Controls.Add(this.dtpTomaMuestra);
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
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.rbtnNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "v_AgregarExam";
            this.Text = "Agregar Examenes";
            this.Load += new System.EventHandler(this.v_AgregarExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTomaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbtnNombre;
        private RadioButton rbtnId;
        private TextBox txtBuscar;
        private DataGridView dgvEstudiantes;
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
        private DateTimePicker dtpTomaMuestra;
        private DateTimePicker dtpRecepcionMuestra;
        private Label label3;
        private Label label4;
        private DataGridView dgvTomaDatos;
    }
}