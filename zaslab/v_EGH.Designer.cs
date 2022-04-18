namespace zaslab
{
    partial class v_EGH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Consis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Parasito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_obser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdatosexam = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpRegisResultados = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpRecepMuestra = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpTomaMuestra = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosexam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Consis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_color);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(600, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examen Fisico";
            // 
            // cmb_Consis
            // 
            this.cmb_Consis.FormattingEnabled = true;
            this.cmb_Consis.Location = new System.Drawing.Point(122, 66);
            this.cmb_Consis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Consis.Name = "cmb_Consis";
            this.cmb_Consis.Size = new System.Drawing.Size(133, 23);
            this.cmb_Consis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consistencia";
            // 
            // cmb_color
            // 
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(122, 28);
            this.cmb_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(133, 23);
            this.cmb_color.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Parasito);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(600, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Examen Microscopico";
            // 
            // txt_Parasito
            // 
            this.txt_Parasito.Location = new System.Drawing.Point(101, 35);
            this.txt_Parasito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Parasito.Name = "txt_Parasito";
            this.txt_Parasito.Size = new System.Drawing.Size(254, 23);
            this.txt_Parasito.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parasito";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(442, 372);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(82, 22);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(529, 372);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(82, 22);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_obser
            // 
            this.txt_obser.Location = new System.Drawing.Point(95, 214);
            this.txt_obser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_obser.Multiline = true;
            this.txt_obser.Name = "txt_obser";
            this.txt_obser.Size = new System.Drawing.Size(516, 68);
            this.txt_obser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observación";
            // 
            // dgvdatosexam
            // 
            this.dgvdatosexam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosexam.Location = new System.Drawing.Point(10, 296);
            this.dgvdatosexam.Name = "dgvdatosexam";
            this.dgvdatosexam.RowHeadersWidth = 51;
            this.dgvdatosexam.RowTemplate.Height = 25;
            this.dgvdatosexam.Size = new System.Drawing.Size(116, 22);
            this.dgvdatosexam.TabIndex = 28;
            this.dgvdatosexam.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(95, 380);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(144, 15);
            this.label28.TabIndex = 39;
            this.label28.Text = "Registro de los Resultados";
            // 
            // dtpRegisResultados
            // 
            this.dtpRegisResultados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisResultados.Location = new System.Drawing.Point(248, 372);
            this.dtpRegisResultados.Name = "dtpRegisResultados";
            this.dtpRegisResultados.Size = new System.Drawing.Size(106, 23);
            this.dtpRegisResultados.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(95, 351);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 15);
            this.label26.TabIndex = 37;
            this.label26.Text = "Recepción de la Muestra";
            // 
            // dtpRecepMuestra
            // 
            this.dtpRecepMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecepMuestra.Location = new System.Drawing.Point(248, 343);
            this.dtpRecepMuestra.Name = "dtpRecepMuestra";
            this.dtpRecepMuestra.Size = new System.Drawing.Size(106, 23);
            this.dtpRecepMuestra.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(95, 322);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(110, 15);
            this.label25.TabIndex = 35;
            this.label25.Text = "Toma de la Muestra";
            // 
            // dtpTomaMuestra
            // 
            this.dtpTomaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTomaMuestra.Location = new System.Drawing.Point(248, 314);
            this.dtpTomaMuestra.Name = "dtpTomaMuestra";
            this.dtpTomaMuestra.Size = new System.Drawing.Size(106, 23);
            this.dtpTomaMuestra.TabIndex = 34;
            // 
            // v_EGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(621, 420);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dtpRegisResultados);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpRecepMuestra);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dtpTomaMuestra);
            this.Controls.Add(this.dgvdatosexam);
            this.Controls.Add(this.txt_obser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "v_EGH";
            this.Text = "Examen General de Heces";
            this.Load += new System.EventHandler(this.v_EGH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosexam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmb_Consis;
        private Label label2;
        private ComboBox cmb_color;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_Parasito;
        private Label label3;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private TextBox txt_obser;
        private Label label4;
        private DataGridView dgvdatosexam;
        private Label label28;
        private DateTimePicker dtpRegisResultados;
        private Label label26;
        private DateTimePicker dtpRecepMuestra;
        private Label label25;
        private DateTimePicker dtpTomaMuestra;
    }
}