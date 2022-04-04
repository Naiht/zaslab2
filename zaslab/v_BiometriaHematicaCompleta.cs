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
                sql.multiple("update estudiantes set globulos_rojos ='" + txtGlobulosRojos.Text + "',hematocrito = '" + txtHematocrito.Text + "', hemoglobina ='" + txtHemoglobina.Text + "',leucocitos ='" + txtLeucocitos.Text +
                    "',MCV ='" + txtMCV.Text + "',MCH='" + txtMCH.Text + "',MCHC='" + txtMCHC.Text + "',neutrofilos ='" + txtNeutrofilos.Text + "',linfocitos ='" + txtLinfocitos.Text + "',monocitos ='" + txtMonocitos.Text +
                    "',eosinofilos ='" + txtEosinofilos.Text + "',basofilos ='" + txtBasofilos.Text + "',fecharesul ='" + string.Format("{0: yyyy-MM-dd}", fecha) + "',observaciones'" + txtObservacion + "' where id =" + exam);
            }
            else
            {
                MessageBox.Show("debes llenar todos los campos");
            }
        }
    }
}
