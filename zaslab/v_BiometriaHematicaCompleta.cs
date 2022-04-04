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
        DateTime fecha;

        public v_BiometriaHematicaCompleta(int idexam,DateTime fecharesul)
        {
            InitializeComponent();
            exam = idexam;
            fecha = fecharesul;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtGlobulosRojos.Text != "" && txtHematocrito.Text != " " && txtHemoglobina.Text != "" && txtLeucocitos.Text != "" && txtMCV.Text != "" &&
                txtMCH.Text != "" && txtMCHC.Text != "" && txtNeutrofilos.Text != "" && txtLinfocitos.Text != "" && txtMonocitos.Text != "" && txtEosinofilos.Text != "" && txtBasofilos.Text != "")
            {
                sql.multiple("update sangre set globulos_rojos ='" + txtGlobulosRojos.Text + "',hematocrito = '" + txtHematocrito.Text + "', hemoglobina ='" + txtHemoglobina.Text + "',leucocitos ='" + txtLeucocitos.Text +
                    "',MCV ='" + txtMCV.Text + "',MCH='" + txtMCH.Text + "',MCHC='" + txtMCHC.Text + "',neutrofilos ='" + txtNeutrofilos.Text + "',linfocitos ='" + txtLinfocitos.Text + "',monocitos ='" + txtMonocitos.Text +
                    "',eosinofilos ='" + txtEosinofilos.Text + "',basofilos ='" + txtBasofilos.Text + "',fecharesul ='" + string.Format("{0: yyyy-MM-dd}", fecha) + "',observaciones = '" + txtObservacion.Text + "' where id =" + exam);
            }
            else
            {
                MessageBox.Show("debes llenar todos los campos");
            }
            this.Close();
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
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
