using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;


namespace zaslab
{
    public partial class v_VerEstu : Form
    {
        public v_VerEstu()
        {
            InitializeComponent();
            /*dtgv_verest.Columns.Add("","");
            dtgv_verest.Columns[0].HeaderText = "Nombre";
            dtgv_verest.Rows.Add();*/
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            v_EdiEliEst mensaje2 = new v_EdiEliEst();
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                //nombrec = mensaje2.nombreca;
                // cedulacli = mensaje2.cedulaclia;
                MessageBox.Show("asdasd" + mensaje2.DialogResult.ToString());

            }

        }

        private void v_VerEstu_Load(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            FileStream fStream = File.Open(@"C:\Users\Na1hTKRZ\Desktop\holi.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fStream);
            DataSet resultDataSet = excelDataReader.AsDataSet();
            excelDataReader.Close();

            DataTable table = resultDataSet.Tables[0];
            DataRow row = table.Rows[0];
            string cell = row[0].ToString();
            dtgv_verest.DataSource = table;

            sqlcon sql = new sqlcon();

            DataRow row2 = table.Rows[1];
            string id = row2[0].ToString();
            string nombre = row2[1].ToString();
            string genero = row2[2].ToString();
            string fecha = "00/00/0000";

            fecha = string.Format("{0: yyyy-MM-dd}", row2[3].ToString());

            DateTime fecha2 = DateTime.Parse(fecha);
            DateTime hoy = DateTime.Now;
            int ed = fecha2.Year;
            int h = hoy.Year;

            int edad = h - ed;

            int gene = 0;
            if (genero == "Female" || genero == "Mujer")
            {
                gene = 1;
            }
            else
            {
                gene = 0;
            }

            MessageBox.Show("" + id + " " + nombre +" " + genero + " "+fecha + "" + edad);

            /*foreach (DataRow dr in table.Rows)
            {
                DataRow row2 = table.Rows[0];
                string nombre = row[0].ToString();
            }*/


        }
    }
}
