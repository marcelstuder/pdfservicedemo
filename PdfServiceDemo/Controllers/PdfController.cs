using EvoPdf;
using Microsoft.AspNetCore.Mvc;

namespace PdfServiceDemo.Controllers
{
    [ApiController]
    [Route("api/getpdf")]
    public class PdfController : ControllerBase
    {

        public IActionResult GetPdf()
        {
            var htmlToPdfConverter = new HtmlToPdfConverter();
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl("https://www.evopdf.com/buy.aspx");
            return File(outPdfBuffer, "application/pdf", "file.pdf");
        }
    }
}
