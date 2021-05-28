using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgChest
{
    class PdfDownloader
    {

        public string PdfDownloadMethod()
        {

            using (var stream = File.OpenRead(@"D:\Textfiles\KARTAPOSTACI.pdf"))
            using (UglyToad.PdfPig.PdfDocument document = UglyToad.PdfPig.PdfDocument.Open(stream))
            {
                var page = document.GetPage(1);
                return string.Join(" ", page.GetWords());
            }


        }



    }
}
