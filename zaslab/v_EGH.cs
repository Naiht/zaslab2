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

        private void v_EGH_Load(object sender, EventArgs e)
        {
            rellenarcmb();
        }

        private void rellenarcmb() {
            cmb_color.Items.Add("Cafe");
            cmb_color.Items.Add("Gris");
            cmb_color.Items.Add("Rojo");
            cmb_color.Items.Add("Verda");

            cmb_Consis.Items.Add("Pastosa");
            cmb_Consis.Items.Add("Rigida");
        }
    }
}
