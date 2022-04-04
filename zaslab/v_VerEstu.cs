using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;


namespace zaslab
{
    public partial class v_VerEstu : Form
    {
        public v_VerEstu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            v_EdiEliEst mensaje2 = new v_EdiEliEst();
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                //nombrec = mensaje2.nombreca;
                // cedulacli = mensaje2.cedulaclia;
                MessageBox.Show("asdasd" + mensaje2.DialogResult.ToString());

            }

        }

        sqlcon sql = new sqlcon();
        private void v_VerEstu_Load(object sender, EventArgs e)
        {

            dtgv_verest.ReadOnly = true;
            dtgv_verest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_verest.AllowUserToResizeRows = false;

            DataTable tabla;
            tabla = sql.tablas("reparacion", "select e.id, e.nombreape, g.genero, e.fechanac, e.edad, e.obser from estudiantes e INNER JOIN generos g ON g.idtipo = e.genero");

            if (tabla.Rows.Count > 0)
            {
                dtgv_verest.DataSource = tabla;
                dtgv_verest.Columns[0].HeaderText = "Codigo Beneficiario";
                dtgv_verest.Columns[1].HeaderText = "Nombre y Apellido";
                dtgv_verest.Columns[2].HeaderText = "Genero";
                dtgv_verest.Columns[3].HeaderText = "Fecha de nacimiento";
                dtgv_verest.Columns[4].HeaderText = "Edad";
                dtgv_verest.Columns[5].HeaderText = "Observación";
            }
        }
    }
}
