namespace zaslab
{
    public partial class v_Principal : Form
    {
        public v_Principal()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_IngreE ingre = new v_IngreE();
            ingre.MdiParent = this;
            ingre.Show();
        }
    }
}