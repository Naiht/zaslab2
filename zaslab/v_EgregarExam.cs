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
            btnGuardar.Enabled = false;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//cambia el tamaño de la columna de acuerdo al contenido

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
            btnGuardar.Enabled = true;
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

        int valor;
        private void ultimoexamen(string tabla)//recibe el nombre del examen y devulve el id del ultimo ingresado
        {
            DataTable sangre;
            sangre = sql.tablas("sangre", "select MAX(id) from " + tabla);
            if (sangre.Rows.Count > 0)
            {
                dgvTomaDatos.DataSource = sangre;
            }
            valor = int.Parse(dgvTomaDatos.Rows[0].Cells[0].Value.ToString());

            //MessageBox.Show("hola" + valor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int s, o, h;
            if (txtNumExam.Text != "")
            {
                if (chbSangre.Checked == true)
                {
                    sql.multiple("insert into sangre values('','','','','','','','','','','','')");
                    ultimoexamen("sangre");
                    s = valor;
                    //MessageBox.Show("" + s);
                    if (chbOrina.Checked == true)
                    {
                        sql.multiple("insert into orina values('','','','','','','','','','','','','','','','','','','','')");
                        ultimoexamen("orina");
                        o = valor;
                        //MessageBox.Show("" + o);
                        if (chbHeces.Checked == true)
                        {
                            sql.multiple("insert into heces values('','','','')");
                            ultimoexamen("heces");
                            h = valor;
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + "," + h + "," + o + "," + s + ")");
                            //MessageBox.Show("" + h);
                        }
                        else
                        {
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + ",''," + o + "," + s + ")");
                        }
                    }
                    else
                    {
                        if (chbHeces.Checked == true)
                        {
                            sql.multiple("insert into heces values('','','','')");
                            ultimoexamen("heces");
                            h = valor;
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + "," + h + ",''," + s + ")");
                            //MessageBox.Show("" + h);
                        }
                        else
                        {
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + ",'',''," + s + ")");
                        }
                    }
                }
                else
                {
                    if (chbOrina.Checked == true)
                    {
                        sql.multiple("insert into orina values('','','','','','','','','','','','','','','','','','','','')");
                        ultimoexamen("orina");
                        o = valor;
                        //MessageBox.Show("" + o);
                        if (chbHeces.Checked == true)
                        {
                            sql.multiple("insert into heces values('','','','')");
                            ultimoexamen("heces");
                            h = valor;
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + "," + h + "," + o + ",'')");

                            //MessageBox.Show("" + h);
                        }
                        else
                        {
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + ",''," + o + ",'')");

                        }
                    }
                    else
                    {
                        if (chbHeces.Checked == true)
                        {
                            sql.multiple("insert into heces values('','','','')");
                            ultimoexamen("heces");
                            h = valor;
                            sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + int.Parse(lbId.Text) + "," + h + ",'','')");

                            //MessageBox.Show("" + h);
                        }
                        else
                        {
                            MessageBox.Show("debes seleccionar minimo un examen");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ingresa el numero de examen");
            }
        }
    }
}
