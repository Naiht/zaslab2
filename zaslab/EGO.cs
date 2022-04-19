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
        DateTime fechamuestra, fecharecepcion, fecharesultados;

        public EGO(int idexam)
        {
            InitializeComponent();
            exam = idexam;
            //fecha2=fecharesul;
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


            cmbbacte.Items.Add("Poca cantidad x campo");
            cmbbacte.Items.Add("Escasa cantidad x campo");
            cmbbacte.Items.Add("Abundante cantidad x campo");
            cmbbacte.Items.Add("Regular cantidad x campo");


            cmbceluepi.Items.Add("Poca cantidad x campo");
            cmbceluepi.Items.Add("Escasa cantidad x campo");
            cmbceluepi.Items.Add("Abundante cantidad x campo");
            cmbceluepi.Items.Add("Regular cantidad x campo");

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
                //fecha = DateTime.Parse(dgvdatosexam.Rows[0].Cells[20].Value.ToString());
                txtobserva.Text = dgvdatosexam.Rows[0].Cells[21].Value.ToString();
                //txt_obser.Text = dgvdatosexam.Rows[0].Cells[5].Value.ToString();

                // en caso de los examenes anteriores donde la fecha no era individual este if valida errores al asignar una fecha que esta vacia en la base de datos
                if (dgvdatosexam.Rows[0].Cells[22].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[23].Value.ToString() != "" && dgvdatosexam.Rows[0].Cells[20].Value.ToString() != "")
                {
                    //MessageBox.Show("" + dgvdatosexam.Rows[0].Cells[6].Value.ToString()+"" + dgvdatosexam.Rows[0].Cells[7].Value.ToString() +""+ dgvdatosexam.Rows[0].Cells[4].Value.ToString());
                    dtpTomaMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[22].Value.ToString());
                    dtpRecepMuestra.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[23].Value.ToString());
                    dtpRegisResultados.Value = DateTime.Parse(dgvdatosexam.Rows[0].Cells[20].Value.ToString());
                }

                if (cmb_aspecto.Text == "")
                {
                    cmb_aspecto.SelectedIndex = 0;
                }

                if (cmb_color.Text == "")
                {
                    cmb_color.SelectedIndex = 0;
                }

                valordefrabrica();

            }
        }

        private void valordefrabrica()
        {
            if (txtnitritos.Text == "")
            {
                txtnitritos.Text = "Negativo";
            }

            if (txtleucoEQ.Text == "")
            {
                txtleucoEQ.Text = "Negativo";
            }
            if (txtproteina.Text == "")
            {
                txtproteina.Text = "Negativo";
            }
            if (txthemo.Text == "")
            {
                txthemo.Text = "Negativo";
            }
            if (txtcetonas.Text == "")
            {
                txtcetonas.Text = "Negativo";
            }
            if (txtbili.Text == "")
            {
                txtbili.Text = "Negativo";
            }
            if (txtgluco.Text == "")
            {
                txtgluco.Text = "Negativo";
            }
            if (txturobili.Text == "")
            {
                txturobili.Text = "Normal";
            }
            if (txtcrista.Text == "")
            {
                txtcrista.Text = "No se observo";
            }
            if (txtcilin.Text == "")
            {
                txtcilin.Text = "No se observo";
            }
            if (txtleucoEF.Text == ""){

                txtleucoEF.Text = " x campo";
            }
            if (txteritro.Text == ""){
                txteritro.Text = " x campo";
            }

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            fecharesultados = dtpRegisResultados.Value;
            fechamuestra = dtpTomaMuestra.Value;
            fecharecepcion = dtpRecepMuestra.Value;

            sql.multiple("update orina set color = '" + cmb_color.SelectedItem.ToString() +"', aspecto = '"+cmb_aspecto.SelectedItem.ToString()+"', " +
                "ph = '"+ txtph.Text + "', densidad = '"+txtdensi.Text+"', leucocitosEF = '"+txtleucoEF.Text+"', nitritos = '"+txtnitritos.Text+"', " +
                "urobilinogeno = '"+txturobili.Text+"', proteina ='"+txtproteina.Text+"', hemoglobina = '"+txthemo.Text+"', bilirrubinas= '"+txtbili.Text+"', glucosa='"+txtgluco.Text+"', " +
                "celulas_epitaliales='"+cmbceluepi.Text+"', bacterias = '"+cmbbacte.Text+"', leucocitosEM = '"+txtleucoEQ.Text+"', eritrocitos='"+txteritro.Text+"', cristales='"+txtcrista.Text+"', " +
                "otro = '"+txtotros.Text+"', fecharesul ='" + string.Format("{0: yyyy-MM-dd}", fecharesultados) +
                "', fechamuestra ='" + string.Format("{0: yyyy-MM-dd}", fechamuestra) +
                "', fecharecep ='" + string.Format("{0: yyyy-MM-dd}", fecharecepcion) + "', observacion = '" +txtobserva.Text+"', cetonas = '"+txtcetonas.Text+ "', " +
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
