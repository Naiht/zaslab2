namespace zaslab
{
    public partial class v_Principal : Form
    {
        
        public v_Principal()
        {
            InitializeComponent();




            if (File.Exists("proyecto.txt"))
            {

            }
            else
            {
                StreamWriter miEscritura = File.CreateText("proyecto.txt");
                miEscritura.WriteLine("2");
                miEscritura.Close();
            }

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_IngreE ingre = new v_IngreE();
            ingre.MdiParent = this;
            ingre.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_VerEstu ver = new v_VerEstu();
            ver.MdiParent = this;
            ver.Show();
        }

        private void ingresarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_AgregarExam ver = new v_AgregarExam();
            ver.MdiParent = this;
            ver.Show();
        }

        private void verExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_AgregarExamenes ver = new v_AgregarExamenes();
            ver.MdiParent = this;
            ver.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pruebareportes ver = new pruebareportes();
            ver.MdiParent = this;
            ver.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProySelect ver = new ProySelect();
            ver.MdiParent = this;
            ver.Show();
        }
    }
}