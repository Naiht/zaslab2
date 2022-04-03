namespace zaslab
{
    partial class v_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.examenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.editarEliminarToolStripMenuItem1,
            this.verToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarExamenToolStripMenuItem,
            this.editarEliminarToolStripMenuItem,
            this.verExamenToolStripMenuItem});
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // ingresarExamenToolStripMenuItem
            // 
            this.ingresarExamenToolStripMenuItem.Name = "ingresarExamenToolStripMenuItem";
            this.ingresarExamenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresarExamenToolStripMenuItem.Text = "Ingresar";
            // 
            // editarEliminarToolStripMenuItem
            // 
            this.editarEliminarToolStripMenuItem.Name = "editarEliminarToolStripMenuItem";
            this.editarEliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarEliminarToolStripMenuItem.Text = "Editar/Eliminar";
            // 
            // verExamenToolStripMenuItem
            // 
            this.verExamenToolStripMenuItem.Name = "verExamenToolStripMenuItem";
            this.verExamenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verExamenToolStripMenuItem.Text = "Ver Examen";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // editarEliminarToolStripMenuItem1
            // 
            this.editarEliminarToolStripMenuItem1.Name = "editarEliminarToolStripMenuItem1";
            this.editarEliminarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.editarEliminarToolStripMenuItem1.Text = "Editar/Eliminar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // v_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 633);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "v_Principal";
            this.Text = "Zas Lab";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem editarEliminarToolStripMenuItem1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem ingresarExamenToolStripMenuItem;
        private ToolStripMenuItem editarEliminarToolStripMenuItem;
        private ToolStripMenuItem verExamenToolStripMenuItem;
    }
}