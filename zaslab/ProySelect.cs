using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaslab
{
    public partial class ProySelect : Form
    {
     
        sqlcon sql = new sqlcon();
        public ProySelect()
        {
            InitializeComponent();

            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();

            DataTable tabla;
            tabla = sql.tablas("reparacion", "select * from proyecto");

            if (tabla.Rows.Count > 0)
            {
                dgvlista.DataSource = tabla;

            }

            for (int i = 0; i < dgvlista.RowCount-1; i++) {
                comboBox1.Items.Add(""+dgvlista.Rows[i].Cells[1].Value.ToString());
            }

            comboBox1.SelectedIndex = int.Parse(lineaLeida)-1;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            StreamWriter miEscritura = File.CreateText("proyecto.txt");
            miEscritura.WriteLine(""+(comboBox1.SelectedIndex+1));
            miEscritura.Close();
        }
    }
}
