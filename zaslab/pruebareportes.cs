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
            Document doc = new Document(PageSize.LETTER,3,3,5,5);
            PdfWriter pw = PdfWriter.GetInstance(doc,fs);

            doc.Open();

            doc.Add(new Paragraph("Cliente:"));
            doc.Add(Chunk.NEWLINE);
            PdfPTable tbl = new PdfPTable(2);
            tbl.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre"));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            tbl.AddCell(clNombre);
            doc.Add(tbl);

            doc.Close();
        }
    }
}
