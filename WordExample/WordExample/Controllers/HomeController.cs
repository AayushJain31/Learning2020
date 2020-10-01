using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Word = Microsoft.Office.Interop.Word;

namespace WordExample.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Document(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                file.SaveAs(path);


                object Sourcepath = path;
                object TargetPath = Server.MapPath("~/App_Data/document.html");
                Word._Application newApp = new Word.Application();
                Word.Documents d = newApp.Documents;
                object Unknown = Type.Missing;
                Word.Document od = d.Open(ref Sourcepath, ref Unknown,
                                         ref Unknown, ref Unknown, ref Unknown,
                                         ref Unknown, ref Unknown, ref Unknown,
                                         ref Unknown, ref Unknown, ref Unknown,
                                         ref Unknown, ref Unknown, ref Unknown, ref Unknown);
                object format = Word.WdSaveFormat.wdFormatHTML;



                newApp.ActiveDocument.SaveAs(ref TargetPath, ref format,
                            ref Unknown, ref Unknown, ref Unknown,
                            ref Unknown, ref Unknown, ref Unknown,
                            ref Unknown, ref Unknown, ref Unknown,
                            ref Unknown, ref Unknown, ref Unknown,
                            ref Unknown, ref Unknown);

                newApp.Documents.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
            return View();
        }

        public ActionResult Doc(HttpPostedFileBase file)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            var fileName = Path.GetFileName(file.FileName);
            var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
            file.SaveAs(path);
            
            object filepath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref filepath, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            string totaltext = "";
            for (int i = 0; i < docs.Paragraphs.Count; i++)
            {
                totaltext += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
             }
            //Console.WriteLine(totaltext);
            docs.Close();
            word.Quit();
            return View("Index");
        }

        public ActionResult Index()
        {
            return View("Document");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}