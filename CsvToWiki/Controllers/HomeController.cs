using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvToWiki.Models;
using LINQtoCSV;
using Microsoft.Ajax.Utilities;
using WebGrease.Css.Extensions;

namespace CsvToWiki.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logRecords = GetLogRecords();

            ViewBag.WikiPageText = "";

            return View();
        }
        private string trimUrl(string refUrl) {
            return refUrl.Replace("https://grants3.hrsa.gov/2010", "").Replace("https://grants3.hrsa.gov", "");
        }

        private string replaceAt(string stackTraceWithAt)
        {
            return stackTraceWithAt.Replace(" at ", "\n at ");
        }
        [HttpPost]
        public ActionResult Index(string selectedException)
        {
            var logRecords = GetLogRecords();
            ViewBag.WikiPageText = "h2. " + selectedException;

             logRecords.Where(k => k.ExceptionType == selectedException)
                .GroupBy(item => item.StackTrace).Select(grouped => new
                {
                    Urls = String.Join("\n# ", grouped.Select(url => trimUrl(url.Referrerurlvalue)).Distinct()),
                    Count = grouped.Count(),
                    StackTrace = grouped.Key
                }).ForEach(processedItem =>
                {
                   
                ViewBag.WikiPageText += String.Format(@"

----

h5. Referral URL/Suspected Pages

# {0}



h5. Count 

{1}

h5. Stack Trace

{{code:title=Stack Trace|borderStyle=solid}}
   
   
{2}


{{code}}


h5. Synopsis ", processedItem.Urls, processedItem.Count, replaceAt(processedItem.StackTrace)); 
                });
            

            //ViewBag.WikiPageText = "h2. "+selectedException;

            return View();
        }

        private IEnumerable<LogRecord> GetLogRecords() {
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "bin");
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = false,
                EnforceCsvColumnAttribute = true
            };
            CsvContext cc = new CsvContext();

            IEnumerable<LogRecord> logRecords;
            logRecords = cc.Read<LogRecord>(path + @"\RawData.csv", inputFileDescription);

            ViewBag.ExceptionNames = logRecords.Select(i => i.ExceptionType)
                .Distinct()
                .Select(x => new SelectListItem {Text = x, Value = x});
            return logRecords;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
