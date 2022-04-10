using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace zaslab
{
    public partial class pruebareportes : Form
    {

        public pruebareportes()
        {
            InitializeComponent();
        }


        string repnombre = @"\img\Logo.png";
        string repcod = "";
        string logo = Environment.CurrentDirectory + @"\img\Logo.jpg";

        iTextSharp.text.Font contentFontEnca = iTextSharp.text.FontFactory.GetFont("Webdings", 10, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font contentPas = iTextSharp.text.FontFactory.GetFont("Webdings", 10, iTextSharp.text.Font.NORMAL);


        float[] medidaCeldas = { 0.90f, 1.60f, 0.60f, 0.40f };

        public void reporte(int fila, string folderPath) {
            repnombre = dgvEstudiantes.Rows[fila].Cells[1].Value.ToString();//Version que utiliza el nombre del pasciente
            repcod = dgvEstudiantes.Rows[fila].Cells[0].Value.ToString();

            //repnombre = dgvEstudiantes.Rows[fila].Cells[7].Value.ToString();//Version que utilza codigos de examen


            FileStream fs = new FileStream(@"" + folderPath + (repnombre+"-"+repcod) + ".pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 20, 20, 30, 5);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(logo);
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            imagen.SetAbsolutePosition(18f,690);

            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 50);
            

            // Insertamos la imagen en el documento
            doc.Add(imagen);

            Paragraph parrafoinfor = new Paragraph();
            parrafoinfor.Add("Bo. San Luis, Centro de Salud Fco. Buitrago. 1c al Norte.\nManagua, Nicaragua \n+505 8660-2341 \nlaboratorio@grupo-zas.com ");
            parrafoinfor.IndentationLeft = 90;
            parrafoinfor.PaddingTop = 20f;

            doc.Add(parrafoinfor);

            doc.Add(Chunk.NEWLINE);
            //Paciente
            string genero = "";

            if (dgvEstudiantes.Rows[fila].Cells[2].Value.ToString() == "Hombre")
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Femenino";
            }

            String candea = "Paciente: " + dgvEstudiantes.Rows[fila].Cells[1].Value.ToString() + "" +
                "\nEdad: " + dgvEstudiantes.Rows[fila].Cells[3].Value.ToString() + " años" +
                " \nGénero: " + genero +
                "\nFecha de Toma: " + string.Format("{0: dd-MM-yyyy}", dgvEstudiantes.Rows[fila].Cells[8].Value);

            Paragraph parrafopaci = new Paragraph(candea, contentPas);
            

            //parrafopaci.Add();

            doc.Add(parrafopaci);


            /*Encabezado tabla*/
            PdfPTable tbl = new PdfPTable(4);


            // ASIGNAS LAS MEDIDAS A LA TABLA (ANCHO)
            tbl.SetWidths(medidaCeldas);

            Paragraph txtnombre = new Paragraph("Nombre",contentFontEnca);
            //txtnombre.Add("Nombre examen");
            txtnombre.Alignment = Element.ALIGN_LEFT;
            PdfPCell clNombre = new PdfPCell();
            clNombre.AddElement(txtnombre);

            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            tbl.AddCell(clNombre);
            //---------------------------
            Paragraph txtlResultado = new Paragraph("Resultado", contentFontEnca);
            //txtlResultado.Add("Resultado");
            txtlResultado.Alignment = Element.ALIGN_LEFT;
            PdfPCell clResultado = new PdfPCell();
            clResultado.AddElement(txtlResultado);

            clResultado.BorderWidth = 0;
            clResultado.BorderWidthBottom = 0.75f;

            tbl.AddCell(clResultado);
            //---------------------
            Paragraph txtRef = new Paragraph("Valor de referencia",contentFontEnca);
            //txtRef.Add("Valores de Referencia");
            txtRef.Alignment = Element.ALIGN_LEFT;
            PdfPCell clValoresRef = new PdfPCell();
            clValoresRef.AddElement(txtRef);

            clValoresRef.BorderWidth = 0;
            clValoresRef.BorderWidthBottom = 0.75f;

            tbl.AddCell(clValoresRef);

            //--------------------------
            Paragraph txtuni = new Paragraph("Unidad",contentFontEnca);
            //txtuni.Add("Unidad");
            txtuni.Alignment = Element.ALIGN_LEFT;
            PdfPCell clunidad = new PdfPCell();
            clunidad.AddElement(txtuni);

            clunidad.BorderWidth = 0;
            clunidad.BorderWidthBottom = 0.75f;
            tbl.AddCell(clunidad);

            tbl.WidthPercentage = 100;

            //-------------------------------------



            //Agregar Tabla Completa
            doc.Add(tbl);

            /*Datos de la tabla*/


            sangret(doc);
            orinat(doc);
            hecest(doc);



            Paragraph Linea = new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------");
            Linea.Alignment = Element.ALIGN_RIGHT;
            doc.Add(Linea);

            Paragraph NumExam = new Paragraph("N°: " + dgvEstudiantes.Rows[fila].Cells[7].Value.ToString(), contentFont);
            NumExam.Alignment = Element.ALIGN_RIGHT;
            doc.Add(NumExam);

            Paragraph obser = new Paragraph("Observación: ",contentFont2);
            obser.Alignment = Element.ALIGN_LEFT;
            doc.Add(obser);


            Paragraph Piedepagi = new Paragraph("BIOANALISTA CLINICO\nTodos los dias ayudamos a las personas a vivir mejor su vida",contentFont);
            Piedepagi.Alignment = Element.ALIGN_CENTER;
            doc.Add(Piedepagi);


            //Cerrado del documento

            doc.Close();
            pw.Close();
        }

 

        sqlcon sql = new sqlcon();

        int hecese = 0;
        int sangree = 0;
        int orinae = 0;


        //--9 9
        iTextSharp.text.Font contentFont = iTextSharp.text.FontFactory.GetFont("Webdings", 8, iTextSharp.text.Font.BOLD);
        iTextSharp.text.Font contentFont2 = iTextSharp.text.FontFactory.GetFont("Webdings", 8, iTextSharp.text.Font.NORMAL);

        
        float pad = -5;
        float padr = -5;
        float primero = -3;

        public void sangret(Document doc)
        {

            DataTable sangre;
            sangre = sql.tablas("sangre", "select * from sangre where id="+sangree);
            //heces = sql.tablas("sangre", "select * from sangre where id= 3");
            if (sangre.Rows.Count > 0)
            {
                dgv_resultado.DataSource = sangre;
            }
            else
            {
                return;
            }

            Paragraph nom = new Paragraph("",contentFont);
            nom.Clear();
            nom.Add("Biometria Hemática Completa (BHC) \n");
            doc.Add(new Paragraph(""));
            doc.Add(nom);

            PdfPTable tblc = new PdfPTable(4);
            tblc.WidthPercentage = 100;
            // ASIGNAS LAS MEDIDAS A LA TABLA (ANCHO)
            tblc.SetWidths(medidaCeldas);
            /*globulos rojos*/
            Paragraph nombreE = new Paragraph();
            nombreE.Add("Globulos Rojos");//nombre

            PdfPCell celNombrE = new PdfPCell();
            nombreE.Font = contentFont2;
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = -5;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[1].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("3.50 - 5.50");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("x10^6/uL");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);
            /*globulos rojos*/

            /*Hematocrito*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Hematocrito");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[2].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("36.00 - 50.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            /*Hematocrito*/

            /*Hemoglobina*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Hemoglobina");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[3].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("11.00 - 17.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("g/dl");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Hemoglobina*/

            /*Leucocitos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Leucocitos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[4].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("4,000 - 10,000");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("mil/mm3");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Leucocitos*/

            /*MCV*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("MCV");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[5].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("80.00 - 100.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("fL");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*MCV*/

            /*MCH*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("MCH");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[6].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("27.00 - 34.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("pL");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*MCH*/

            /*MCHC*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("MCHC");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[7].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("32.00 - 36.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("g/dL");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*MCHC*/

            /*Neutrofilos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Neutrofilos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[8].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("40.00 - 70.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Neutrofilos*/

            /*Linfocitos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Linfocitos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[9].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("20.00 - 45.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Linfocitos*/

            /*Monocitos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Monocitos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[10].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("0.00 - 10.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Monocitos*/

            /*Eosinofilos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Eosinofilos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[11].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("0.00 - 6.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Eosinofilos*/

            /*Basofilos*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Basofilos");//nombre

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[12].Value.ToString());//resultado

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("0.00 - 3.00");//valores normales

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("%");//unidad

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Basofilos*/

            doc.Add(tblc);

            Paragraph obser = new Paragraph();

        }


        public void hecest(Document doc)
        {

            DataTable heces;
            //heces = sql.tablas("sangre", "select * from heces where id= 3");
            heces = sql.tablas("sangre", "select * from heces where id="+hecese);
            if (heces.Rows.Count > 0)
            {
                dgv_resultado.DataSource = heces;
            }
            else {
                return;
            }


            Paragraph nom = new Paragraph("",contentFont);
            nom.Clear();
            nom.Add("Examen General de Heces (EGH) \n");
            doc.Add(new Paragraph(""));
            doc.Add(nom);

            PdfPTable tblc = new PdfPTable(4);
            tblc.WidthPercentage = 100;
            tblc.SetWidths(medidaCeldas);

            /*Elem1*/
            Paragraph nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Color");

            PdfPCell celNombrE = new PdfPCell();
            celNombrE.PaddingTop = primero;
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            tblc.AddCell(celNombrE);

            nombreE.Clear();
            nombreE.Add("" + dgv_resultado.Rows[0].Cells[1].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = 0;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");
            //
            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            tblc.AddCell(celNombrE);
            /*Elem1*/

            /*Elem2*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Consistencia");

            celNombrE = new PdfPCell();
            celNombrE.PaddingTop = pad;
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[2].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = 0;


            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;


            tblc.AddCell(celNombrE);
            /*Elem2*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Parasito");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[3].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = 0;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Otros");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[5].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            //celNombrE.PaddingTop = pad;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = pad;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            doc.Add(tblc);

        }

        private void orinat(Document doc) {

            DataTable orina;
            orina = sql.tablas("sangre", "select * from orina where id= "+ orinae);
            if (orina.Rows.Count > 0)
            {
                dgv_resultado.DataSource = orina;
            }
            else
            {
                return;
            }



            Paragraph nom = new Paragraph("", contentFont);
            nom.Add("Examen General de Orina (EGO) \n");
            doc.Add(new Paragraph(""));
            doc.Add(nom);

            PdfPTable tblc = new PdfPTable(4);
            tblc.WidthPercentage = 100;
            tblc.SetWidths(medidaCeldas);
            /*Elem1*/
            Paragraph nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Color");

            PdfPCell celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = primero;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[1].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = primero;
            tblc.AddCell(celNombrE);
            /*Elem1*/

            /*Elem2*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Aspecto");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[2].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem2*/

            //Examen Quimico

            /*Elem4*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("QUÍMICO");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem4*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("PH");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[3].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem4*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Densidad");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[4].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem4*/




            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Leucocito");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[15].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Nitritos");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[6].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Urobilinógeno");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[7].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Proteina");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[8].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Hemoglobina");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[9].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Cetonas");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[10].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Bilirrubinas");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[11].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Glucosa");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[12].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            //Examen Microscopico
            /*Elem4*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("MICROSCOPICO");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem4*/


            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Celulas Epiteliales");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[13].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Bacterias");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[14].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Leucocitos");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[5].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Eritrocitos");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;


            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[16].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Cristales");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[17].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Cilindros");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;


            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[18].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);
            /*Elem3*/

            /*Elem3*/
            nombreE = new Paragraph();
            nombreE.Font = contentFont2;
            nombreE.Add("Otros");

            celNombrE = new PdfPCell();
            celNombrE.AddElement(nombreE);
            celNombrE.Border = 0;

            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);

            nombreE.Clear();

            nombreE.Add("" + dgv_resultado.Rows[0].Cells[19].Value.ToString());

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;
            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);


            nombreE.Clear();

            nombreE.Add("");

            celNombrE = new PdfPCell(new Phrase(nombreE));
            celNombrE.Border = 0;
            celNombrE.PaddingTop = padr;

            tblc.AddCell(celNombrE);
            /*Elem3*/

            doc.Add(tblc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dummyFileName = "Guardar aqui";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;
            string folderPath = "";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                folderPath = Path.GetDirectoryName(sf.FileName);
                folderPath += @"\";
                // Do whatever
            }
            else {
                return;
            }

            reporte(fila, folderPath);
            MessageBox.Show("Reporte Generado Exitosamente");
        }

        private void pruebareportes_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEstudiantes.AllowUserToResizeRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//cambia el tamaño de la columna de acuerdo al contenido
            dgvEstudiantes.AllowUserToAddRows = false;
            dgv_resultado.Visible = false;

            rbtnNombre.Checked = true;

            // llena el datagridview al cargar el formulario

            DataTable dt;
            dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombre, g.genero Genero, e.edad as Edad, " +
                "er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen], er.fechatoma as [Fecha de toma], er.fecharecep as [Fecha de recepcion] from estudiantes as e" +
                " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante");
            if (dt.Rows.Count > 0)
            {
                dgvEstudiantes.DataSource = dt;
                dgvEstudiantes.Columns[4].Visible = false;
                dgvEstudiantes.Columns[5].Visible = false;
                dgvEstudiantes.Columns[6].Visible = false;
            }
        }

        int fila;
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dgvEstudiantes.CurrentRow.Index;
            hecese = int.Parse(dgvEstudiantes.Rows[fila].Cells[4].Value.ToString());
            orinae = int.Parse(dgvEstudiantes.Rows[fila].Cells[5].Value.ToString());
            sangree = int.Parse(dgvEstudiantes.Rows[fila].Cells[6].Value.ToString());
        }

        private void bnt_ImprTodo_Click(object sender, EventArgs e)
        {

            string dummyFileName = "Guardar aqui";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;
            string folderPath = "";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                folderPath = Path.GetDirectoryName(sf.FileName);
                folderPath += @"\";
                // Do whatever
            }
            else {
                return;
            }

            fila = dgvEstudiantes.RowCount-1;
            while (fila >= 0)
            {
                hecese = int.Parse(dgvEstudiantes.Rows[fila].Cells[4].Value.ToString());
                orinae = int.Parse(dgvEstudiantes.Rows[fila].Cells[5].Value.ToString());
                sangree = int.Parse(dgvEstudiantes.Rows[fila].Cells[6].Value.ToString());
                reporte(fila, folderPath);
                fila--;
            }


            MessageBox.Show("Reporte Generado Exitosamente");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombe, g.genero Genero, e.edad" +
                    ", er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen],er.fechatoma as [Fecha de toma], er.fecharecep as [Fecha de recepcion]from estudiantes as e" +
                    " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante where e.nombreape like '%"
                   + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                    dgvEstudiantes.Columns[4].Visible = false;
                    dgvEstudiantes.Columns[5].Visible = false;
                    dgvEstudiantes.Columns[6].Visible = false;
                }


            }
            else if (rbtnId.Checked == true)
            {
                DataTable dt;
                dt = sql.tablas("estudiantes", "select e.idb as[Codigo de Beneficiario], e.nombreape as Nombe, g.genero Genero, e.edad" +
                    ", er.idheces as Heces, er.idorina as Orina, er.idsangre as Sangre, er.numexamen as [numero de examen] from estudiantes as e" +
                    " inner join generos as g on e.genero=g.idtipo inner join examrealizados as er on e.idb = er.idestudiante where e.idb like '%"
                   + txtBuscar.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = dt;
                    dgvEstudiantes.Columns[4].Visible = false;
                    dgvEstudiantes.Columns[5].Visible = false;
                    dgvEstudiantes.Columns[6].Visible = false;
                }

            }
        }
    }
}
