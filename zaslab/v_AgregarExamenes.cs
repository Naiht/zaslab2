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
    public partial class v_AgregarExamenes : Form
    {
        public v_AgregarExamenes()
        {
            InitializeComponent();
        }

        sqlcon sql = new sqlcon();
     
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();
            int proy = int.Parse(lineaLeida);
            if (rbtnNombre.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombe, g.genero Genero, e.edad" +
                    ", er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen] from estudiantes as e" +
                    " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante where e.nombreape like '%"
                   + txtBuscar.Text + "%' and e.proyecto = "+proy);
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                    dgvEstudiantes.Columns[4].Visible = false;
                    dgvEstudiantes.Columns[5].Visible = false;
                    dgvEstudiantes.Columns[6].Visible = false;
                }

                
            }
            else if (rbtnId.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombe, g.genero Genero, e.edad" +
                    ", er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen] from estudiantes as e" +
                    " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante where e.idb like '%"
                   + txtBuscar.Text + "%' and e.proyecto ="+proy);
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                    dgvEstudiantes.Columns[4].Visible = false;
                    dgvEstudiantes.Columns[5].Visible = false;
                    dgvEstudiantes.Columns[6].Visible = false;
                }
               
            }
        }

        int fila;
        private void dgtEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dgvEstudiantes.CurrentRow.Index;
            lbId.Text = dgvEstudiantes.Rows[fila].Cells[0].Value.ToString();
            lbNombre.Text = dgvEstudiantes.Rows[fila].Cells[1].Value.ToString();
            lbEdad.Text = dgvEstudiantes.Rows[fila].Cells[3].Value.ToString();
            lbNumExam.Text = dgvEstudiantes.Rows[fila].Cells[7].Value.ToString();
            int h = int.Parse(dgvEstudiantes.Rows[fila].Cells[4].Value.ToString());
            int o = int.Parse(dgvEstudiantes.Rows[fila].Cells[5].Value.ToString());
            int s = int.Parse(dgvEstudiantes.Rows[fila].Cells[6].Value.ToString());
            if (h != 0){
                btnHeces.Enabled = true;
            }
            else {
                btnHeces.Enabled = false;
            }

            if (o != 0) {
                btnOrina.Enabled = true;
            }
            else
            {
                btnOrina.Enabled = false;
            }

            if (s != 0) {
                btnSangre.Enabled = true;
            }
            else
            {
                btnSangre.Enabled = false;
            }
        }

        private void v_AgregarExamenes_Load(object sender, EventArgs e)
        {
            btnSangre.Enabled = false;
            btnOrina.Enabled = false;
            btnHeces.Enabled = false;

            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.AllowUserToResizeRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//cambia el tamaño de la columna de acuerdo al contenido
            dgvEstudiantes.AllowUserToAddRows = false;



            // llena el datagridview al cargar el formulario
            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();
            int proy = int.Parse(lineaLeida);
            DataTable dt;
            dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombe, g.genero Genero, e.edad as Edad, " +
                "er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen] from estudiantes as e" +
                " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante where e.proyecto ="+proy);
            if (dt.Rows.Count > 0)
            {
                dgvEstudiantes.DataSource = dt;
                dgvEstudiantes.Columns[4].Visible = false;
                dgvEstudiantes.Columns[5].Visible = false;
                dgvEstudiantes.Columns[6].Visible = false;
            }
           
        }

        private void btnSangre_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEstudiantes.Rows[fila].Cells[6].Value.ToString()); ;
            //DateTime fecha = dateTimePicker1.Value; tomaba la fecha en que se registran los examenes

            //MessageBox.Show("" + id + "" + fecha);
            v_BiometriaHematicaCompleta datossangre = new v_BiometriaHematicaCompleta(id);
            datossangre.ShowDialog();
            if (datossangre.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Operación Exitosa");
            }
        }

        private void btnOrina_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dgvEstudiantes.Rows[fila].Cells[5].Value.ToString()); ;
            //DateTime fecha = dateTimePicker1.Value;

            EGO mensaje2 = new EGO(id);
            mensaje2.ShowDialog();
            if (mensaje2.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Operación Exitosa");
            }
        }

        private void btnHeces_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEstudiantes.Rows[fila].Cells[4].Value.ToString()); ;
            //DateTime fecha = dateTimePicker1.Value;

            v_EGH mensaje2 = new v_EGH(id);
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Operación Exitosa");
            }
        }
    }
}
