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
    public partial class v_BiometriaHematicaCompleta : Form
    {
        public v_BiometriaHematicaCompleta()
        {
            InitializeComponent();
        }

        sqlcon sql = new sqlcon();
        int exam;
        DateTime fechamuestra, fecharecepcion, fecharesultados;

        public v_BiometriaHematicaCompleta(int idexam)
        {
            InitializeComponent();
            exam = idexam;
            //fecha = fecharesul;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Son correctos los datos del examen?", "Resultados examen", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                fecharesultados = dtpRegisResultados.Value;
                fechamuestra = dtpTomaMuestra.Value;
                fecharecepcion = dtpRecepMuestra.Value;

                if (txtGlobulosRojos.Text != "" && txtHematocrito.Text != " " && txtHemoglobina.Text != "" && txtLeucocitos.Text != "" && txtMCV.Text != "" &&
                    txtMCH.Text != "" && txtMCHC.Text != "" && txtNeutrofilos.Text != "" && txtLinfocitos.Text != "" && txtMonocitos.Text != "" && txtEosinofilos.Text != "" && txtBasofilos.Text != "")
                {
                    sql.multiple("update sangre set globulos_rojos ='" + txtGlobulosRojos.Text + "',hematocrito = '" + txtHematocrito.Text + "', hemoglobina ='" + txtHemoglobina.Text + "',leucocitos ='" + txtLeucocitos.Text +
                        "',MCV ='" + txtMCV.Text + "',MCH='" + txtMCH.Text + "',MCHC='" + txtMCHC.Text + "',neutrofilos ='" + txtNeutrofilos.Text + "',linfocitos ='" + txtLinfocitos.Text + "',monocitos ='" + txtMonocitos.Text +
                        "',eosinofilos ='" + txtEosinofilos.Text + "',basofilos ='" + txtBasofilos.Text + "',fecharesul ='" + string.Format("{0: yyyy-MM-dd}", fecharesultados) +
                        "',fechamuestra ='" + string.Format("{0: yyyy-MM-dd}", fechamuestra) + "',fecharecep ='" + string.Format("{0: yyyy-MM-dd}", fecharecepcion) + "',observaciones = '" + txtObservacion.Text + "' where id =" + exam);
                }
                else
                {
                    MessageBox.Show("debes llenar todos los campos");
                }

                this.Close();
            }

        }

        private void v_BiometriaHematicaCompleta_Load(object sender, EventArgs e)
        {
            DataTable sangre;
            sangre = sql.tablas("sangre", "select * from sangre where id=" + exam);
            if (sangre.Rows.Count > 0)
            {
                dgvdatosexam.DataSource = sangre;
                txtGlobulosRojos.Text = dgvdatosexam.Rows[0].Cells[1].Value.ToString();
                txtHematocrito.Text = dgvdatosexam.Rows[0].Cells[2].Value.ToString();
                txtHemoglobina.Text = dgvdatosexam.Rows[0].Cells[3].Value.ToString();
                txtLeucocitos.Text = dgvdatosexam.Rows[0].Cells[4].Value.ToString();
                txtMCV.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();
                txtMCH.Text = dgvdatosexam.Rows[0].Cells[6].Value.ToString();
                txtMCHC.Text = dgvdatosexam.Rows[0].Cells[7].Value.ToString();
                txtNeutrofilos.Text = dgvdatosexam.Rows[0].Cells[8].Value.ToString();
                txtLinfocitos.Text = dgvdatosexam.Rows[0].Cells[9].Value.ToString();
                txtMonocitos.Text = dgvdatosexam.Rows[0].Cells[10].Value.ToString();
                txtEosinofilos.Text = dgvdatosexam.Rows[0].Cells[11].Value.ToString();
                txtBasofilos.Text = dgvdatosexam.Rows[0].Cells[12].Value.ToString();
                txtObservacion.Text = dgvdatosexam.Rows[0].Cells[14].Value.ToString();

                // en caso de los examenes anteriores donde la fecha no era individual este if valida errores al asignar una fecha que esta vacia en la base de datos
                if (dgvdatosexam.Rows[0].Cells[15].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[16].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[13].Value.ToString() != "")
                {
                    //MessageBox.Show("" + dgvdatosexam.Rows[0].Cells[6].Value.ToString()+"" + dgvdatosexam.Rows[0].Cells[7].Value.ToString() +""+ dgvdatosexam.Rows[0].Cells[4].Value.ToString());
                    dtpTomaMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[15].Value.ToString());
                    dtpRecepMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[16].Value.ToString());
                    dtpRegisResultados.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[13].Value.ToString());
                }

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
