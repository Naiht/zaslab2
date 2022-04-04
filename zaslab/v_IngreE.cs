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
    public partial class v_IngreE : Form
    {
        public v_IngreE()
        {
            InitializeComponent();     

        }
        private void v_IngreE_Load(object sender, EventArgs e)
        {
            cmb_Genero.Items.Add("Hombre");
            cmb_Genero.Items.Add("Mujer");
            cmb_Genero.SelectedIndex = 0;
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            string fecha = "00/00/0000";
            fecha = string.Format("{0: yyyy-MM-dd}", dtp_fecha.Value);
            DateTime fechaNacimiento = DateTime.Parse(fecha);

            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (DateTime.Today < fechaNacimiento.AddYears(edad))
                --edad;

            txt_edad.Text = edad.ToString();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        valilimpia vali = new valilimpia();
        private void limpiar()
        {
            vali.limpiarfrm(this);
        }

    }
}
