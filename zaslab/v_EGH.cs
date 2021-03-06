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
    public partial class v_EGH : Form
    {
        public v_EGH()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
 
            DialogResult resultado = MessageBox.Show("¿Son correctos los datos del examen?", "Resultados examen", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                fecharesultados = dtpRegisResultados.Value;
                fechamuestra = dtpTomaMuestra.Value;
                fecharecepcion = dtpRecepMuestra.Value;

                sql.multiple("update heces set color = '" + cmb_color.Text + "'" +
                    ", consistencia = '"+ cmb_Consis.Text + "',fecharesul='" + string.Format("{0: yyyy-MM-dd}", fecharesultados) +
                    "',fechamuestra='" + string.Format("{0: yyyy-MM-dd}", fechamuestra) +
                    "',fecharecep='" + string.Format("{0: yyyy-MM-dd}", fecharecepcion) + "',observacion = '" +txt_obser.Text+ "', parasito= '"+txt_Parasito.Text+"' where id = "+exam); 

                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        sqlcon sql = new sqlcon();
        int exam;
        DateTime fechamuestra, fecharecepcion, fecharesultados;

        public v_EGH(int idexam)
        {
            InitializeComponent();
            exam = idexam;
            //fecha = fecharesul;
        }

        private void v_EGH_Load(object sender, EventArgs e)
        {
            rellenarcmb();

            DataTable heces;
            heces = sql.tablas("sangre", "select * from heces where id=" + exam);
            //heces = sql.tablas("sangre", "select * from heces where id= 3");
            if (heces.Rows.Count > 0)
            {
                dgvdatosexam.DataSource = heces;

                cmb_color.Text = dgvdatosexam.Rows[0].Cells[1].Value.ToString();
                cmb_Consis.Text = dgvdatosexam.Rows[0].Cells[2].Value.ToString();
                txt_Parasito.Text = dgvdatosexam.Rows[0].Cells[3].Value.ToString();
                txt_obser.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();

                // en caso de los examenes anteriores donde la fecha no era individual este if valida errores al asignar una fecha que esta vacia en la base de datos
                if(dgvdatosexam.Rows[0].Cells[6].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[7].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[4].Value.ToString() != "")
                {
                    //MessageBox.Show("" + dgvdatosexam.Rows[0].Cells[6].Value.ToString()+"" + dgvdatosexam.Rows[0].Cells[7].Value.ToString() +""+ dgvdatosexam.Rows[0].Cells[4].Value.ToString());
                    dtpTomaMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[6].Value.ToString());
                    dtpRecepMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[7].Value.ToString());
                    dtpRegisResultados.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[4].Value.ToString());
                }
               

                if (cmb_Consis.SelectedItem == "") {
                    cmb_Consis.SelectedIndex = 0;
                }

                if (cmb_color.SelectedItem == "") {
                    cmb_color.SelectedIndex = 0;
                }
            }

        }

        private void rellenarcmb() {
            cmb_color.Items.Add("Cafe");
            cmb_color.Items.Add("Gris");
            cmb_color.Items.Add("Rojo");
            cmb_color.Items.Add("Verde");
            cmb_color.SelectedIndex = 0;

            cmb_Consis.Items.Add("Pastosa");
            cmb_Consis.Items.Add("Rigida");
            cmb_Consis.Items.Add("Liquida");
            cmb_Consis.Items.Add("Solida");
            cmb_Consis.Items.Add("Semi solida");
            cmb_Consis.Items.Add("Diarreica");
            cmb_Consis.Items.Add("Diarreica mucosa");
            cmb_Consis.Items.Add("Diarreica liquida");

            cmb_Consis.SelectedIndex = 0;
        }
    }
}
