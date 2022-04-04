namespace zaslab
{
    partial class v_EdiEliEst
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_obser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombrea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(426, 391);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(113, 29);
            this.btn_Agregar.TabIndex = 33;
            this.btn_Agregar.Text = "Guardar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(556, 391);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 29);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_obser
            // 
            this.txt_obser.Location = new System.Drawing.Point(190, 251);
            this.txt_obser.Multiline = true;
            this.txt_obser.Name = "txt_obser";
            this.txt_obser.Size = new System.Drawing.Size(479, 115);
            this.txt_obser.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Observación";
            // 
            // txt_edad
            // 
            this.txt_edad.Enabled = false;
            this.txt_edad.Location = new System.Drawing.Point(581, 194);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(88, 27);
            this.txt_edad.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Edad: ";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "";
            this.dtp_fecha.Location = new System.Drawing.Point(190, 194);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(250, 27);
            this.dtp_fecha.TabIndex = 45;
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Location = new System.Drawing.Point(190, 134);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(160, 28);
            this.cmb_Genero.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(16, 137);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(57, 20);
            this.Genero.TabIndex = 42;
            this.Genero.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo de beneficiario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre y apellido";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(190, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 27);
            this.txt_id.TabIndex = 39;
            // 
            // txt_nombrea
            // 
            this.txt_nombrea.Location = new System.Drawing.Point(190, 77);
            this.txt_nombrea.Name = "txt_nombrea";
            this.txt_nombrea.Size = new System.Drawing.Size(492, 27);
            this.txt_nombrea.TabIndex = 38;
            // 
            // v_EdiEliEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 439);
            this.Controls.Add(this.txt_obser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_nombrea);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Name = "v_EdiEliEst";
            this.Text = "Editar o Eliminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.v_EdiEliEst_FormClosed);
            this.Load += new System.EventHandler(this.v_EdiEliEst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private TextBox txt_obser;
        private Label label5;
        private TextBox txt_edad;
        private Label label3;
        private DateTimePicker dtp_fecha;
        private ComboBox cmb_Genero;
        private Label label4;
        private Label Genero;
        private Label label2;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_nombrea;
    }
}