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
    public partial class EGO : Form
    {
        public EGO()
        {
            InitializeComponent();
        }

        sqlcon sql = new sqlcon();
        int exam;
        DateTime fecha;

        public EGO(int idexam, DateTime fecharesul)
        {
            InitializeComponent();
            exam = idexam;
                        rellenarcm();
        }

        private void EGO_Load(object sender, EventArgs e)
        {
            rellenarcm();
            relletabal();
        }

        private void rellenarcm()
        {
            cmb_color.Items.Add("Gris");
            cmb_color.Items.Add("Rojizo");
            cmb_color.Items.Add("Naranja");
            cmb_color.Items.Add("Café");
            cmb_color.Items.Add("Otro");
            cmb_color.Items.Add("Amarillo");

            cmb_aspecto.Items.Add("Otros");
            cmb_aspecto.Items.Add("Muy turbio");
            cmb_aspecto.Items.Add("Transparente");
            cmb_aspecto.Items.Add("Ligeramente Turbio");
            cmb_aspecto.Items.Add("Turbio");

            cmb_sedi.Items.Add("Otros");
            cmb_sedi.Items.Add("Abundante");
            cmb_sedi.Items.Add("Regular Cantidad");
            cmb_sedi.Items.Add("Poca Cantidad");
            cmb_sedi.Items.Add("Escaso");
        }

 
        private void relletabal() {
            DataTable orina;
            orina = sql.tablas("sangre", "select * from orina where id=" + exam);
            //heces = sql.tablas("sangre", "select * from heces where id= 3");
            if (orina.Rows.Count > 0)
            {
                dgvdatosexam.DataSource = orina;

                cmb_color.SelectedItem = dgvdatosexam.Rows[0].Cells[1].Value.ToString();
                cmb_aspecto.SelectedItem = dgvdatosexam.Rows[0].Cells[2].Value.ToString();
                txtph.Text = dgvdatosexam.Rows[0].Cells[3].Value.ToString();

                txtdensi.Text = dgvdatosexam.Rows[0].Cells[4].Value.ToString();
                //txt_obser.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();


                if (cmb_sedi.SelectedItem == "")
                {
                    cmb_sedi.SelectedIndex = 0;
                }

                if (cmb_aspecto.SelectedItem == "")
                {
                    cmb_aspecto.SelectedIndex = 0;
                }

                if (cmb_color.SelectedItem == "")
                {
                    cmb_color.SelectedIndex = 0;
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Son correctos los datos del examen?", "Resultados examen", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

    }
}
