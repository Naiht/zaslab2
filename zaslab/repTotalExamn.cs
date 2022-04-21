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
    internal class repTotalExamn
    {//

        float[] medidaCeldas = { 0.15f, 0.50f, 1.60f, 0.25f, 0.15f,0.15f, 0.15f };
        iTextSharp.text.Font contentFontEnca = iTextSharp.text.FontFactory.GetFont("Webdings", 10, iTextSharp.text.Font.BOLD);

        iTextSharp.text.Font contentFontEnca2 = iTextSharp.text.FontFactory.GetFont("Webdings", 10, iTextSharp.text.Font.NORMAL);


        int alineacion = Element.ALIGN_LEFT;

        public void reporte(string path,string total)
        {
            string fecha = ""+string.Format("{0: dd-MM-yyyy}", DateTime.Today);
            FileStream fs = new FileStream(@"" + path + fecha + "-Total.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 20, 20, 30, 6);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            /*Encabezado tabla*/
            PdfPTable tbl = new PdfPTable(7);


            // ASIGNAS LAS MEDIDAS A LA TABLA (ANCHO)
            tbl.SetWidths(medidaCeldas);

            Paragraph txtno = new Paragraph("N", contentFontEnca);
            txtno.Alignment = alineacion;
            PdfPCell clno = new PdfPCell();
            clno.AddElement(txtno);
            tbl.AddCell(clno);


            Paragraph txtnombre = new Paragraph("Codigo", contentFontEnca);
            txtnombre.Alignment = alineacion;
            PdfPCell clNombre = new PdfPCell();
            clNombre.AddElement(txtnombre);

        
            tbl.AddCell(clNombre);
            //---------------------------
            Paragraph txtlResultado = new Paragraph("Nombre Y Apellido", contentFontEnca);
            txtlResultado.Alignment = alineacion;
            PdfPCell clResultado = new PdfPCell();
            clResultado.AddElement(txtlResultado);

            
            tbl.AddCell(clResultado);
            //---------------------
            Paragraph txtgene = new Paragraph("Genero", contentFontEnca);
            txtgene.Alignment = alineacion;
            PdfPCell clgene = new PdfPCell();
            clgene.AddElement(txtgene);


            tbl.AddCell(clgene);
            //---------------------
            Paragraph txtRef = new Paragraph("EGH", contentFontEnca);
            txtRef.Alignment = alineacion;
            PdfPCell clValoresRef = new PdfPCell();
            clValoresRef.AddElement(txtRef);

            
            tbl.AddCell(clValoresRef);

            //--------------------------
            Paragraph txtuni = new Paragraph("EGO", contentFontEnca);
            txtuni.Alignment = alineacion;
            PdfPCell clunidad = new PdfPCell();
            clunidad.AddElement(txtuni);
            tbl.AddCell(clunidad);

            //-------------------------------------

            //--------------------------
            Paragraph txtegh = new Paragraph("BHC", contentFontEnca);
            txtegh.Alignment = alineacion;
            PdfPCell cegh = new PdfPCell();
            cegh.AddElement(txtegh);
            tbl.AddCell(cegh);

            //-------------------------------------

            tbl.WidthPercentage = 100;

            //Agregar Tabla Completa
            doc.Add(tbl);

            /*Datos de la tabla*/

            creaTabla(doc);

            //Cerrado del documento


            Paragraph obser = new Paragraph("" + total, contentFontEnca);
            obser.Alignment = Element.ALIGN_RIGHT;
            doc.Add(obser);

            doc.Close();
            pw.Close();
        }

        sqlcon sql = new sqlcon();
        private void creaTabla(Document doc) {
            DataTable tabla;
            string fecha = "" + string.Format("{0: yyyy-MM-dd}", DateTime.Today);
            tabla = sql.tablas("sangre", "select ex.idestudiante, e.nombreape, ex.idheces, ex.idorina, ex.idsangre, e.genero, ex.numexamen from examrealizados ex inner join estudiantes e on e.idb = ex.idestudiante inner join sangre s on s.id = ex.idsangre inner join orina o on o.id = ex.idsangre inner join heces h on h.id = ex.idsangre " +
                "where e.proyecto = 3 and s.fecharecep = '"+fecha+"' or o.fecharecep = '"+ fecha + "' or h.fecharecep = '"+ fecha + "' order by ex.numexamen ");
            if (tabla.Rows.Count > 0)
            {
                //dgv_resultado.DataSource = sangre;
            }
            else
            {
                return;
            }

            for (int i =0; i < tabla.Rows.Count; i++)
            {
                PdfPTable tbl = new PdfPTable(7);


                // ASIGNAS LAS MEDIDAS A LA TABLA (ANCHO)
                tbl.SetWidths(medidaCeldas);

                Paragraph txtno = new Paragraph("" + tabla.Rows[i][6].ToString(), contentFontEnca2);
                txtno.Alignment = alineacion;
                PdfPCell clno = new PdfPCell();
                clno.AddElement(txtno);
                tbl.AddCell(clno);


                Paragraph txtnombre = new Paragraph(""+tabla.Rows[i][0].ToString(), contentFontEnca2);
                txtnombre.Alignment = alineacion;
                PdfPCell clNombre = new PdfPCell();
                clNombre.AddElement(txtnombre);


                tbl.AddCell(clNombre);
                //---------------------------
                Paragraph txtlResultado = new Paragraph(""+tabla.Rows[i][1].ToString(), contentFontEnca2);
                txtlResultado.Alignment = alineacion;
                PdfPCell clResultado = new PdfPCell();
                clResultado.AddElement(txtlResultado);


                tbl.AddCell(clResultado);



                //---------------------
                string genero2;
                if (tabla.Rows[i][5].ToString() == "False") {
                    genero2 = "M";
                }
                else
                {
                    genero2 = "F";
                }

                Paragraph gene = new Paragraph("" + genero2, contentFontEnca2);
                txtlResultado.Alignment = Element.ALIGN_CENTER;
                PdfPCell gen = new PdfPCell();
                gen.AddElement(gene);


                tbl.AddCell(gen);


                //---------------------
                string evalua = "";
                if (int.Parse(tabla.Rows[i][2].ToString()) !=0)
                {
                    evalua = "x";
                }
                Paragraph txtRef = new Paragraph("" + evalua, contentFontEnca2);
                txtRef.Alignment = Element.ALIGN_CENTER;
                PdfPCell clValoresRef = new PdfPCell();
                clValoresRef.AddElement(txtRef);


                tbl.AddCell(clValoresRef);

                //--------------------------
                evalua = "";
                if (int.Parse(tabla.Rows[i][3].ToString()) != 0)
                {
                    evalua = "x";
                }
                Paragraph txtuni = new Paragraph("" + evalua, contentFontEnca2);
                txtuni.Alignment = Element.ALIGN_CENTER;
                PdfPCell clunidad = new PdfPCell();
                clunidad.AddElement(txtuni);
                tbl.AddCell(clunidad);

                //-------------------------------------

                //--------------------------
                evalua = "";
                if (int.Parse(tabla.Rows[i][4].ToString()) != 0)
                {
                    evalua = "x";
                }
                Paragraph txtegh = new Paragraph("" + evalua, contentFontEnca2);
                txtegh.Alignment = Element.ALIGN_CENTER;
                PdfPCell cegh = new PdfPCell();
                cegh.AddElement(txtegh);
                tbl.AddCell(cegh);

                //-------------------------------------

                tbl.WidthPercentage = 100;

                //Agregar Tabla Completa
                doc.Add(tbl);
            }

        }

    }
}
