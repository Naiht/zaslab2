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
    public partial class v_AgregarExam : Form
    {
        public v_AgregarExam()
        {
            InitializeComponent();
        }

        sqlcon sql = new sqlcon();

        private void v_AgregarExam_Load(object sender, EventArgs e)
        {
            /*dtpTomaMuestra.Format = DateTimePickerFormat.Custom;
            dtpTomaMuestra.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";*/

            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.auto
            dgvEstudiantes.AllowUserToAddRows = false;

            DataTable dt;
            dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                " e.edad as Edad, e.obser as Observaciones  from estudiantes as e " +
                "inner join generos as g on e.genero=g.idtipo");
            if(dt.Rows.Count > 0)
            {
                dgvEstudiantes.DataSource = dt;
            }
        }
        int fila;
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dgvEstudiantes.CurrentRow.Index;
            lbId.Text = dgvEstudiantes.Rows[fila].Cells[0].Value.ToString();
            lbNombre.Text = dgvEstudiantes.Rows[fila].Cells[1].Value.ToString();
            lbEdad.Text = dgvEstudiantes.Rows[fila].Cells[4].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                    " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                    " e.edad as Edad, e.obser as Observaciones  from estudiantes as e " +
                    "inner join generos as g on e.genero=g.idtipo where e.nombreape like '%" + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                }
            }
            else if (rbtnId.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                    " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                    " e.edad as Edad, e.obser as Observaciones  from estudiantes as e " +
                    "inner join generos as g on e.genero=g.idtipo where e.idb like '%" + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                }
            }
        }
    }
}
