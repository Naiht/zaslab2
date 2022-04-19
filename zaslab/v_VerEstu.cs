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


            string codigob = "" + dtgv_verest.CurrentRow.Cells[0].Value.ToString();
            string nombrea = "" + dtgv_verest.CurrentRow.Cells[1].Value.ToString();
            int genero = 0;
            if (dtgv_verest.CurrentRow.Cells[2].Value.ToString() == "Mujer") {
                genero = 1;
            }

            DateTime fechanac = DateTime.Parse("" + dtgv_verest.CurrentRow.Cells[3].Value.ToString());
            int edad = int.Parse("" + dtgv_verest.CurrentRow.Cells[4].Value.ToString());
            string obser = "" + dtgv_verest.CurrentRow.Cells[5].Value.ToString();

            v_EdiEliEst mensaje2 = new v_EdiEliEst(codigob,nombrea,genero,fechanac,edad,obser);
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                //nombrec = mensaje2.nombreca;
                // cedulacli = mensaje2.cedulaclia;
                cargadatos();
                MessageBox.Show("Operación Exitosa");

            }

        }

        sqlcon sql = new sqlcon();
        private void v_VerEstu_Load(object sender, EventArgs e)
        {
            cargadatos();
            rdb_Nombre.Checked = true;
        }
        v_Principal proy = new v_Principal();
        private void cargadatos() {

            dtgv_verest.ReadOnly = true;
            dtgv_verest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_verest.AllowUserToResizeRows = false;

            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();

            DataTable tabla;
            tabla = sql.tablas("reparacion", "select e.idb, e.nombreape, g.genero, e.fechanac, e.edad, e.obser from estudiantes e " +
                "INNER JOIN generos g ON g.idtipo = e.genero where e.proyecto = 2 and proyecto = "+int.Parse(lineaLeida));

            /*tabla = sql.tablas("reparacion", "select e.idb, e.nombreape, g.genero, e.fechanac, e.edad, e.obser from estudiantes e " +
            "INNER JOIN generos g ON g.idtipo = e.genero where e.proyecto = "+ proy.proy);*/


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtgv_verest.ReadOnly = true;
            dtgv_verest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_verest.AllowUserToResizeRows = false;

            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();


            if (rdb_id.Checked == true)
            {

                DataTable tabla;
                tabla = sql.tablas("estudiantes", "select e.idb, e.nombreape, g.genero, e.fechanac, e.edad, e.obser from estudiantes e INNER JOIN generos g ON g.idtipo = e.genero where e.idb like '%" + textBox1.Text + "%' and proyecto = "+int.Parse(lineaLeida));

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
            else if (rdb_Nombre.Checked == true)
            {
                DataTable tabla;
                tabla = sql.tablas("estudiantes", "select e.idb, e.nombreape, g.genero, e.fechanac, e.edad, e.obser from estudiantes e INNER JOIN generos g ON g.idtipo = e.genero where e.nombreape like '%" + textBox1.Text + "%' and proyecto = " + int.Parse(lineaLeida));

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
}
