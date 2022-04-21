using ExcelDataReader;
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

        sqlcon sql = new sqlcon();
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Son corretos los datos?", "Datos", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) {
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
                StreamReader miLectura = File.OpenText("proyecto.txt");
                string lineaLeida = miLectura.ReadLine();
                miLectura.Close();

                sql.multiple("insert into estudiantes values('" + codigob + "','" + nombrea + "'," + genero + ",'" + string.Format("{0: yyyy-MM-dd}", fechanac) + "'," + edad + ",'" + txt_obser.Text + "','"+int.Parse(lineaLeida)+"')");

                limpiar();
            }

        }

        valilimpia vali = new valilimpia();
        private void limpiar()
        {
            vali.limpiarfrm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fStream = File.Open(@"C:\Users\Na1hT\Desktop\Libro1.xlsx", FileMode.Open, FileAccess.Read);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fStream);
            DataSet resultDataSet = excelDataReader.AsDataSet();
            excelDataReader.Close();

            DataTable table = resultDataSet.Tables[0];

            string test = "";

            StreamReader miLectura = File.OpenText("proyecto.txt");
            string lineaLeida = miLectura.ReadLine();
            miLectura.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                 //insert into estudiantes values('codp','nombrep',1,'2000-05-05',15,'',3)
                string cod = table.Rows[i][0].ToString();
                string nom = table.Rows[i][1].ToString();

                string fechan = table.Rows[i][2].ToString();

                int genero = int.Parse(table.Rows[i][3].ToString());

                string fecha = "00/00/0000";
                fecha = string.Format("{0: yyyy-MM-dd}", fechan);
                DateTime fechaNacimiento = DateTime.Parse(fecha);

                int edad = DateTime.Today.Year - fechaNacimiento.Year;

                if (DateTime.Today < fechaNacimiento.AddYears(edad))
                    --edad;
                sql.multiple("insert into estudiantes values('" + cod + "','" + nom + "'," + genero + ",'" + string.Format("{0: yyyy-MM-dd}", fechaNacimiento) + "'," + edad + ",'" + txt_obser.Text + "','"+int.Parse(lineaLeida)+"')");

            
            }

            MessageBox.Show("Importado correctamente");

        }
    }
}
