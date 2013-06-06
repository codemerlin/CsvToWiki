using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvToWiki.Models;
using LINQtoCSV;

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

        [HttpPost]
        public ActionResult Index(string selectedException)
        {
            var logRecords = GetLogRecords();

            logRecords.Where(k => k.ExceptionType == selectedException);

            ViewBag.WikiPageText = "";

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
