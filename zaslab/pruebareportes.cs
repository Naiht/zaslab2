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

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Na1hTKRZ\Desktop\test.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 3, 3, 5, 5);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            pw.Open();


            // Creamos la imagen y le ajustamos el tamaño
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Users\Na1hTKRZ\Desktop\test.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 60);

            // Insertamos la imagen en el documento
            doc.Add(imagen);


            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1250,BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10,0,BaseColor.BLACK);

            Paragraph parrafoinfor = new Paragraph();
            parrafoinfor.Add("Direccion: Bo. San Luis, Centro de Salud Francisco 1c al Norte \nTelefono: +505 8660-2341 \nCorreo: laboratorio@grupo-zas.com \nWeb: www.grupo-zas.com");
            doc.Add(parrafoinfor);


            //Paciente
            Paragraph parrafopaci = new Paragraph();
            parrafopaci.Add("Paciente: \nNacido el: ,edad \nGenero:");
            doc.Add(parrafopaci);

            /*Encabezado tabla*/
            PdfPTable tbl = new PdfPTable(4);
            Paragraph txtnombre = new Paragraph();
            txtnombre.Add("Nombre examen");
            txtnombre.Alignment = Element.ALIGN_CENTER;
            PdfPCell clNombre = new PdfPCell();
            clNombre.AddElement(txtnombre);

            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;
   
            tbl.AddCell(clNombre);
            //---------------------------
            Paragraph txtlResultado = new Paragraph();
            txtlResultado.Add("Resultado");
            txtlResultado.Alignment = Element.ALIGN_CENTER;
            PdfPCell clResultado = new PdfPCell();
            clResultado.AddElement(txtlResultado);
            
            clResultado.BorderWidth = 0;
            clResultado.BorderWidthBottom = 0.75f;

            tbl.AddCell(clResultado);
            //---------------------
            Paragraph txtRef = new Paragraph();
            txtRef.Add("Valores de Referencia");
            txtRef.Alignment = Element.ALIGN_CENTER;
            PdfPCell clValoresRef = new PdfPCell();
            clValoresRef.AddElement(txtRef);
           
            clValoresRef.BorderWidth = 0;
            clValoresRef.BorderWidthBottom = 0.75f;

            tbl.AddCell(clValoresRef);

            //--------------------------
            Paragraph txtuni = new Paragraph();
            txtuni.Add("Unidad");
            txtuni.Alignment = Element.ALIGN_CENTER;
            PdfPCell clunidad = new PdfPCell();
            clunidad.AddElement(txtuni);
            
            clunidad.BorderWidth = 0;
            clunidad.BorderWidthBottom = 0.75f;
            tbl.AddCell(clunidad);

            tbl.WidthPercentage = 100;
            
            
            /*Datos de la tabla*/


            //Agregar Tabla Completa
            doc.Add(tbl);
            //Cerrado del documento
 
            doc.Close();
            pw.Close();
        }
    }
}
