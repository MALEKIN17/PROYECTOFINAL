using ENTIDADES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace LOGICAS
{
    public class ServicioReporte
    {
        public void GenerarPDFFactura(Factura factura, List<Detalle> detalles, string nombrePDF)
        {
            iTextSharp.text.Font font = new iTextSharp.text.Font(0);

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(nombrePDF + ".pdf", FileMode.OpenOrCreate));
            document.Open();

            Chunk chunk = new Chunk(nombrePDF + "\n" + "\n",
                FontFactory.GetFont("ARIAL", 19, iTextSharp.text.Font.BOLD));
            var paraf = new Paragraph(chunk);
            paraf.Alignment = 1;
            document.Add(paraf);

            var titleChunk = new Chunk("Codigo Factura: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var valueChunk = new Chunk(factura.numerofactura.ToString(), font);
            var titleParagraph = new Paragraph();
            titleParagraph.Alignment = 1;
            titleParagraph.Add(titleChunk);
            titleParagraph.Add(valueChunk);
            document.Add(titleParagraph);

            var serviciosChunk = new Chunk("Servicio: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            foreach (var detalle in detalles)
            {
                var serviciosValueChunk = new Chunk(detalle.descripcion.ToString()+"  " +detalle.precio.ToString(), font);
                var serviciosParagraph = new Paragraph();
                serviciosParagraph.Alignment = 1;
                serviciosParagraph.Add(serviciosChunk);
                serviciosParagraph.Add(serviciosValueChunk);
                document.Add(serviciosParagraph);
            }
            

            var prcRevisionChunk = new Chunk("Presio de servicios: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var prcRevisionValueChunk = new Chunk(factura.preciototal.ToString(), font);
            var prcRevisionParagraph = new Paragraph();
            prcRevisionParagraph.Alignment = 1;
            prcRevisionParagraph.Add(prcRevisionChunk);
            prcRevisionParagraph.Add(prcRevisionValueChunk);
            document.Add(prcRevisionParagraph);

            var fechaFacturaChunk = new Chunk("Fecha de Factura: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var fechaFacturaValueChunk = new Chunk(factura.fecha.ToString(), font);
            var fechaFacturaParagraph = new Paragraph();
            fechaFacturaParagraph.Alignment = 1;
            fechaFacturaParagraph.Add(fechaFacturaChunk);
            fechaFacturaParagraph.Add(fechaFacturaValueChunk);
            document.Add(fechaFacturaParagraph);

            var clienteCCChunk = new Chunk("Cliente cedula: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var clienteCCValueChunk = new Chunk(factura.cedulaCliente, font);
            var clienteCCParagraph = new Paragraph();
            clienteCCParagraph.Alignment = 1;
            clienteCCParagraph.Add(clienteCCChunk);
            clienteCCParagraph.Add(clienteCCValueChunk);
            document.Add(clienteCCParagraph);

            var empleadoCCChunk = new Chunk("Empleado cedula: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var empleadoCCValueChunk = new Chunk(factura.cedulaempleado, font);
            var empleadoCCParagraph = new Paragraph();
            empleadoCCParagraph.Alignment = 1;
            empleadoCCParagraph.Add(empleadoCCChunk);
            empleadoCCParagraph.Add(empleadoCCValueChunk);
            document.Add(empleadoCCParagraph);

            var placaChunk = new Chunk("Placa: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var placaValueChunk = new Chunk(factura.placa, font);
            var placaParagraph = new Paragraph();
            placaParagraph.Alignment = 1;
            placaParagraph.Add(placaChunk);
            placaParagraph.Add(placaValueChunk);
            document.Add(placaParagraph);

            var Prc_TotalChunk = new Chunk("Precio Total: ", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
            var Prc_TotalValueChunk = new Chunk(factura.preciototal.ToString(), font);
            var Prc_TotalParagraph = new Paragraph();
            Prc_TotalParagraph.Alignment = 1;
            Prc_TotalParagraph.Add(Prc_TotalChunk);
            Prc_TotalParagraph.Add(Prc_TotalValueChunk);
            document.Add(Prc_TotalParagraph);

            document.Close();
        }
    }
}
