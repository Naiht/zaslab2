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
    public partial class v_EdiEliEst : Form
    {
        public v_EdiEliEst()
        {
            InitializeComponent();
        }

        private void v_EdiEliEst_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }

        //Al precionar eliminar cancela la operación
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro de eliminar?", "Eliminar estudiante", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;

                this.Close();
            }
        }
        //Al precionar agregar confirma la orperación
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Son correctos los datos del estudiante?", "Editar estudiante", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void v_EdiEliEst_Load(object sender, EventArgs e)
        {
            cmb_Genero.Items.Add("Hombre");
            cmb_Genero.Items.Add("Mujer");
            cmb_Genero.SelectedIndex = 0;
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            int edad = 0;

            edad = DateTime.Now.Year - dtp_fecha.Value.Year;

            txt_edad.Text = edad.ToString();
        }
    }
}
