using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using NLog;

namespace BookCapture
{    
    public class PdfMaker
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private Document document;

        public PdfMaker(string saveFolder)
        {
            document = new Document(PageSize.A4, 0, 0, 0, 0);
            OpenPdfFile(saveFolder);
        }

        private void OpenPdfFile(string saveFolder)
        {            
            try
            {
                PdfWriter.GetInstance(document, new FileStream(saveFolder + @"\" + DateTime.Now.ToString("yyyyMMddHHmmssffffff") + ".pdf", FileMode.Create));

                document.Open();
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
        }

        public void AddPdfPage(byte[] imageStream)
        {
            Image image = Image.GetInstance(imageStream);

            image.SetDpi(600, 600);

            image.ScaleToFit(PageSize.A4);

            image.Alignment = Image.ALIGN_MIDDLE;

            document.Add(image);
        }

        public void ClosePdfFile()
        {
            document.Close();
        }

    }
}
