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
    public partial class v_eliminar : Form
    {
        public v_eliminar()
        {
            InitializeComponent();
        }

        sqlcon sql = new sqlcon();

        private void borrarcolumnas()
        {
            dgvEstudiantes.Columns[6].Visible = false;
            dgvEstudiantes.Columns[7].Visible = false;
            dgvEstudiantes.Columns[8].Visible = false;
            dgvEstudiantes.Columns[9].Visible = false;
        }

        private void v_eliminar_Load(object sender, EventArgs e)
        {
            
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//cambia el tamaño de la columna de acuerdo al contenido

            dgvEstudiantes.AllowUserToAddRows = false;
            DataTable dt;
            dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                " e.edad as Edad, e.obser as Observaciones, idheces, idorina,idsangre, er.numexamen from estudiantes as e " +
                "inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb=er.idestudiante ");
            if (dt.Rows.Count > 0)
            {
                dgvEstudiantes.DataSource = dt;
            }
            borrarcolumnas();
        }

        int fila;
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dgvEstudiantes.CurrentRow.Index;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                " e.edad as Edad, e.obser as Observaciones, idheces, idorina,idsangre, er.numexamen from estudiantes as e " +
                "inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb=er.idestudiante where e.nombreape like '%" + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                }
                borrarcolumnas();
            }
            else if (rbtnId.Checked == true)
            {
                DataTable dt;
               
                dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                " e.edad as Edad, e.obser as Observaciones, idheces, idorina,idsangre, er.numexamen from estudiantes as e " +
                "inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb=er.idestudiante where e.idb like '%" + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                }
                borrarcolumnas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + int.Parse(dgvEstudiantes.Rows[fila].Cells[9].Value.ToString()));

            sql.multiple("Delete from heces where numexamen =" + int.Parse(dgvEstudiantes.Rows[fila].Cells[6].Value.ToString()));
            sql.multiple("Delete from orina where id =" + int.Parse(dgvEstudiantes.Rows[fila].Cells[7].Value.ToString()));
            sql.multiple("Delete from sangre where id =" + int.Parse(dgvEstudiantes.Rows[fila].Cells[8].Value.ToString()));
            sql.multiple("Delete from examrealizados where id =" + int.Parse(dgvEstudiantes.Rows[fila].Cells[9].Value.ToString()));
        }
    }
}
