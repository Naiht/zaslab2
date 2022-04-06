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
        DateTime fecha,fecha2;

        public EGO(int idexam, DateTime fecharesul)
        {
            InitializeComponent();
            exam = idexam;
            fecha2=fecharesul;
            rellenarcm();
            relletabal();
        }

        private void EGO_Load(object sender, EventArgs e)
        {

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

        }

 
        private void relletabal() {
            DataTable orina;
            orina = sql.tablas("orina", "select * from orina where id=" + exam);
            //heces = sql.tablas("sangre", "select * from heces where id= 3");
            if (orina.Rows.Count > 0)
            {
                dgvdatosexam.DataSource = orina;

                cmb_color.SelectedItem = dgvdatosexam.Rows[0].Cells[1].Value.ToString();
                cmb_aspecto.SelectedItem = dgvdatosexam.Rows[0].Cells[2].Value.ToString();
                txtph.Text = dgvdatosexam.Rows[0].Cells[3].Value.ToString();

                txtdensi.Text = dgvdatosexam.Rows[0].Cells[4].Value.ToString();
                
                txtleucoEF.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();
                txtnitritos.Text = dgvdatosexam.Rows[0].Cells[6].Value.ToString();
                txturobili.Text = dgvdatosexam.Rows[0].Cells[7].Value.ToString();
                
                txtproteina.Text = dgvdatosexam.Rows[0].Cells[8].Value.ToString();
                txthemo.Text = dgvdatosexam.Rows[0].Cells[9].Value.ToString();
                
                txtcetonas.Text = dgvdatosexam.Rows[0].Cells[10].Value.ToString();
                txtbili.Text = dgvdatosexam.Rows[0].Cells[11].Value.ToString();
                txtgluco.Text = dgvdatosexam.Rows[0].Cells[12].Value.ToString();
                
                cmbceluepi.Text = dgvdatosexam.Rows[0].Cells[13].Value.ToString();
                cmbbacte.Text = dgvdatosexam.Rows[0].Cells[14].Value.ToString();
                txtleucoEQ.Text = dgvdatosexam.Rows[0].Cells[15].Value.ToString();
                txteritro.Text = dgvdatosexam.Rows[0].Cells[16].Value.ToString();
                txtcrista.Text = dgvdatosexam.Rows[0].Cells[17].Value.ToString();
                txtcilin.Text = dgvdatosexam.Rows[0].Cells[18].Value.ToString();
                txtotros.Text = dgvdatosexam.Rows[0].Cells[19].Value.ToString();
                fecha = DateTime.Parse(dgvdatosexam.Rows[0].Cells[20].Value.ToString());
                txtobserva.Text = dgvdatosexam.Rows[0].Cells[21].Value.ToString();
                //txt_obser.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();


                

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

            sql.multiple("update orina set color = '" + cmb_color.SelectedItem.ToString() +"', aspecto = '"+cmb_aspecto.SelectedItem.ToString()+"', " +
                "ph = "+float.Parse(txtph.Text)+", densidad = '"+txtdensi.Text+"', leucocitosEF = '"+txtleucoEF.Text+"', nitritos = '"+txtnitritos.Text+"', " +
                "urobilinogeno = '"+txturobili.Text+"', proteina ='"+txtproteina.Text+"', hemoglobina = '"+txthemo.Text+"', bilirrubinas= '"+txtbili.Text+"', glucosa='"+txtgluco.Text+"', " +
                "celulas_epitaliales='"+cmbceluepi.Text+"', bacterias = '"+cmbbacte.Text+"', leucocitosEM = '"+txtleucoEQ.Text+"', eritrocitos='"+txteritro.Text+"', cristales='"+txtcrista.Text+"', " +
                "otro = '"+txtotros.Text+"', fecharesul ='" + fecha2 + "', observacion = '"+txtobserva.Text+"', cetonas = '"+txtcetonas.Text+ "', " +
                "clilindros = '"+txtcilin.Text+ "' where id = " + exam);



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
