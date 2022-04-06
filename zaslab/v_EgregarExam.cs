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
            //dgvdatos.Visible = true;
            recarga();
        }


        private void recarga() {
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//cambia el tamaño de la columna de acuerdo al contenido

            dgvEstudiantes.AllowUserToAddRows = false;

            DataTable dt;
            dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                 " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                 " e.edad as Edad, e.obser as Observaciones from estudiantes as e " +
                 "inner join generos as g on e.genero=g.idtipo  ");

               if (dt.Rows.Count > 0)
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

            DataTable sangre;
            sangre = sql.tablas("examrealizado", "select * from examrealizados where idestudiante = '" + dgvEstudiantes.Rows[fila].Cells[0].Value.ToString() + "'");
            

            if (sangre.Rows.Count > 0) {

                dgvdatos.DataSource = sangre;
                //NuevaConsultaQueIncluyaLosParametros

                int h = int.Parse(dgvdatos.Rows[0].Cells[3].Value.ToString());
                int o = int.Parse(dgvdatos.Rows[0].Cells[4].Value.ToString());
                int s = int.Parse(dgvdatos.Rows[0].Cells[5].Value.ToString());
                dtpTomaMuestra.Value = DateTime.Parse(dgvdatos.Rows[0].Cells[6].Value.ToString());
                dtpRecepcionMuestra.Value = DateTime.Parse(dgvdatos.Rows[0].Cells[7].Value.ToString());
                txtNumExam.Text = dgvdatos.Rows[0].Cells[1].Value.ToString();
                

                if (h != 0)
                {
                    chbHeces.Checked = true;
                }
                else
                {
                    chbHeces.Checked = false;
                }

                if (o != 0)
                {
                    chbOrina.Checked = true;
                }
                else
                {
                    chbOrina.Checked = false;
                }

                if (s != 0)
                {
                    chbSangre.Checked = true;
                }
                else
                {
                    chbSangre.Checked = false;
                }
            }
            else {
                chbHeces.Checked = false;
                chbOrina.Checked = false;
                chbSangre.Checked = false;
                txtNumExam.Text = "";
            }


            btnGuardar.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as [Codigo de Beneficiario], e.nombreape as Nombre," +
                " g.genero as Genero, e.fechanac as [Fecha de Nacimiento]," +
                " e.edad as Edad, e.obser as Observaciones from estudiantes as e " +
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
                " e.edad as Edad, e.obser as Observaciones from estudiantes as e " +
                "inner join generos as g on e.genero=g.idtipo  where e.idb like '%" + txtBuscar.Text + "%'");
               
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

        }

    

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int s, o, h;

            DataTable sangre;
            sangre = sql.tablas("examrealizado","select * from examrealizados where idestudiante = '" + dgvEstudiantes.Rows[fila].Cells[0].Value.ToString() + "'");

            if (sangre.Rows.Count == 0 )
            {
                if (txtNumExam.Text != "")
                {
                    if (chbSangre.Checked == true)
                    {
                        sql.multiple("insert into sangre values('','','','','','','','','','','','','','')");
                        ultimoexamen("sangre");
                        s = valor;
                        //MessageBox.Show("" + s);
                        if (chbOrina.Checked == true)
                        {
                            sql.multiple("insert into orina values('','','','','','','','','','','','','','','','','','','','','')");
                            ultimoexamen("orina");
                            o = valor;
                            //MessageBox.Show("" + o);
                            if (chbHeces.Checked == true)
                            {
                                sql.multiple("insert into heces values('','','','','')");
                                ultimoexamen("heces");
                                h = valor;
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + ",'" + lbId.Text + "'," + h + "," + o + "," + s + ",'" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "','" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");
                                //MessageBox.Show("" + h);
                            }
                            else
                            {
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + ",'" + lbId.Text + "',''," + o + "," + s + ",'" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "','" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");
                            }
                        }
                        else
                        {
                            if (chbHeces.Checked == true)
                            {
                                sql.multiple("insert into heces values('','','','','')");
                                ultimoexamen("heces");
                                h = valor;
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + ",'" + lbId.Text + "'," + h + ",''," + s + ",'" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "','" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");
                                //MessageBox.Show("" + h);
                            }
                            else
                            {
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + ",'" + lbId.Text + "','',''," + s + ",'" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "','" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");
                            }
                        }
                    }
                    else
                    {
                        if (chbOrina.Checked == true)
                        {
                            sql.multiple("insert into orina values('','','','','','','','','','','','','','','','','','','','','')");
                            ultimoexamen("orina");
                            o = valor;
                            //MessageBox.Show("" + o);
                            if (chbHeces.Checked == true)
                            {
                                sql.multiple("insert into heces values('','','','','')");
                                ultimoexamen("heces");
                                h = valor;
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + lbId.Text + "," + h + "," + o + ",'','" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "','" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");

                                //MessageBox.Show("" + h);
                            }
                            else
                            {
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + lbId.Text + ",''," + o + ",'', '" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");

                            }
                        }
                        else
                        {
                            if (chbHeces.Checked == true)
                            {
                                sql.multiple("insert into heces values('','','','','')");
                                ultimoexamen("heces");
                                h = valor;
                                sql.multiple("insert into  examrealizados values(" + txtNumExam.Text + "," + lbId.Text + "," + h + ",'','', '" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "')");

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
            else 
            {
                dgvdatos.DataSource = sangre;
                //Paara actualizar
                if(chbSangre.Checked == true)
                {
                    if (int.Parse(dgvdatos.Rows[0].Cells[5].Value.ToString()) == 0)
                    {
                        sql.multiple("insert into sangre values('','','','','','','','','','','','','','')");
                        ultimoexamen("sangre");
                        sql.multiple("update examrealizados set idsangre = " + valor + " where idestudiante = '" + lbId.Text + "'");
                    }
                    else
                    {
                        sql.multiple("update examrealizados set fechatoma ='" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', fecharecep = '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "'  where idestudiante = '" + lbId.Text + "'");

                    }
                }
                else
                {
                    sql.multiple("delete from sangre where id=" + int.Parse(dgvdatos.Rows[0].Cells[5].Value.ToString()));
                    sql.multiple("update examrealizados set idsangre = 0, fechatoma ='" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', fecharecep = '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "'  where idestudiante = '" + lbId.Text + "'");
                }
                if(chbOrina.Checked == true)
                {
                    if (int.Parse(dgvdatos.Rows[0].Cells[4].Value.ToString()) == 0)
                    {
                        sql.multiple("insert into orina values('','','','','','','','','','','','','','','','','','','','','')");
                        ultimoexamen("orina");
                        sql.multiple("update examrealizados set idorina = " + valor + " where idestudiante = '" + lbId.Text + "'");

                    }
                    else
                    {
                        sql.multiple("update examrealizados set fechatoma ='" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', fecharecep = '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "'  where idestudiante = '" + lbId.Text + "'");

                    }
                }
                else
                {
                    sql.multiple("delete from orina where id=" + int.Parse(dgvdatos.Rows[0].Cells[4].Value.ToString()));
                    sql.multiple("update examrealizados set idorina = 0, fechatoma ='"+ string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value)+"', fecharecep = '"+ string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value)+"' where idestudiante = '" + lbId.Text + "'");
                }
                if (chbHeces.Checked == true)
                {
                    if (int.Parse(dgvdatos.Rows[0].Cells[3].Value.ToString()) == 0)
                    {
                        sql.multiple("insert into heces values('','','','','')");
                        ultimoexamen("heces");
                        sql.multiple("update examrealizados set idheces = " + valor + " where idestudiante = '" + lbId.Text + "'");
                    }
                    else
                    {
                        sql.multiple("update examrealizados set fechatoma ='" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', fecharecep = '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "'  where idestudiante = '" + lbId.Text + "'");

                    }
                }
                else
                {
                    sql.multiple("delete from heces where id=" + int.Parse(dgvdatos.Rows[0].Cells[3].Value.ToString()));
                    sql.multiple("update examrealizados set idheces = 0, fechatoma ='" + string.Format("{0: yyyy-MM-dd}", dtpTomaMuestra.Value) + "', fecharecep = '" + string.Format("{0: yyyy-MM-dd}", dtpRecepcionMuestra.Value) + "'  where idestudiante = '" + lbId.Text + "'");
                }
                //MessageBox.Show("ingresa el numero de exame22n");
            }

            lbId.Text = "";
            lbNombre.Text = "";
            lbEdad.Text = "";
            chbSangre.Checked = false;
            chbOrina.Checked = false;
            chbHeces.Checked = false;
            dtpTomaMuestra.Value = DateTime.Today;
            dtpRecepcionMuestra.Value = DateTime.Today;
            btnGuardar.Enabled = false;
            txtNumExam.Text = "";
            recarga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            v_eliminar eliminar = new v_eliminar();
            eliminar.ShowDialog();
        }
    }
}
