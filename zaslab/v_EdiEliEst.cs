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

        string codpublico1 = "a";
        public v_EdiEliEst(string cod, string nombre, int genero, DateTime fecha, int edad, string obser)
        {
            InitializeComponent();
            txt_id.Text = cod;
            codpublico1 = cod;
            cmb_Genero.Items.Add("Hombre");
            cmb_Genero.Items.Add("Mujer");
            cmb_Genero.SelectedIndex = 0;
            
            txt_nombrea.Text = nombre;
            cmb_Genero.SelectedIndex = genero;
            dtp_fecha.Value = fecha;

            txt_edad.Text = edad.ToString();
            txt_obser.Text = obser;
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
        sqlcon sql = new sqlcon();

        //Al precionar agregar confirma la orperación
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Son correctos los datos del estudiante?", "Editar estudiante", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                string codigob = txt_id.Text;
                string nombrea = txt_nombrea.Text;
                int genero = cmb_Genero.SelectedIndex;
                DateTime fechanac = dtp_fecha.Value;
                int edad = 0;
                try
                {
                    edad = int.Parse(txt_edad.Text);
                }
                catch (Exception ex)
                {
                }

                string obser = txt_obser.Text;

                sql.multiple("update estudiantes set idb = '"+codigob+"', nombreape = '"+nombrea+"' , genero = "+genero+" , fechanac = '" + string.Format("{0: yyyy-MM-dd}", fechanac) + "', obser = '"+obser+"' where idb = '"+codpublico1+"'");
                

                this.Close();
            }
        }

        private void v_EdiEliEst_Load(object sender, EventArgs e)
        {

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
    }
}
