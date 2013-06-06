using LINQtoCSV;

namespace CsvToWiki.Models
{
    public class LogRecord
    {
        [CsvColumn(FieldIndex = 1)]
        public string Datetime1 { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public string ErrorLogSessionId { get; set; }

        [CsvColumn(FieldIndex = 3)]
        public string FWSessionId { get; set; }

        [CsvColumn(FieldIndex = 4)]
        public string Userid { get; set; }

        [CsvColumn(FieldIndex = 5)]
        public string Username { get; set; }

        [CsvColumn(FieldIndex = 6)]
        public string FtErrorLogID { get; set; }

        [CsvColumn(FieldIndex = 7)]
        public string RequestID { get; set; }

        [CsvColumn(FieldIndex = 8)]
        public string ErrorLogSessionId2 { get; set; }

        [CsvColumn(FieldIndex = 9)]
        public string FwSessionId2 { get; set; }

        [CsvColumn(FieldIndex = 10)]
        public string InternalCookie { get; set; }

        [CsvColumn(FieldIndex = 11)]
        public string AspnetSessionID { get; set; }

        [CsvColumn(FieldIndex = 12)]
        public string TimeStamp { get; set; }

        [CsvColumn(FieldIndex = 13)]
        public string FullName { get; set; }

        [CsvColumn(FieldIndex = 14)]
        public string OsVersion { get; set; }

        [CsvColumn(FieldIndex = 15)]
        public string ClrVersion { get; set; }

        [CsvColumn(FieldIndex = 16)]
        public string AppDomainName { get; set; }

        [CsvColumn(FieldIndex = 17)]
        public string ThreadIdentity { get; set; }

        [CsvColumn(FieldIndex = 18)]
        public string WindowsIdentity { get; set; }

        [CsvColumn(FieldIndex = 19)]
        public string Datetime12 { get; set; }

        [CsvColumn(FieldIndex = 20)]
        public string ReferenceId { get; set; }

        [CsvColumn(FieldIndex = 21)]
        public string Timetaken { get; set; }

        [CsvColumn(FieldIndex = 22)]
        public string Referrerurlvalue { get; set; }

        [CsvColumn(FieldIndex = 23)]
        public string Targeturlvalue { get; set; }

        [CsvColumn(FieldIndex = 24)]
        public string FtExceptionID { get; set; }

        [CsvColumn(FieldIndex = 25)]
        public string ExceptionIdentifier { get; set; }

        [CsvColumn(FieldIndex = 27)]
        public string ExceptionType { get; set; }

        [CsvColumn(FieldIndex = 28)]
        public string CreatedDateTime { get; set; }

        [CsvColumn(FieldIndex = 29)]
        public string Category { get; set; }

        [CsvColumn(FieldIndex = 30)]
        public string Message { get; set; }

        [CsvColumn(FieldIndex = 31)]
        public string Data { get; set; }

        [CsvColumn(FieldIndex = 32)]
        public string TargetSite { get; set; }

        [CsvColumn(FieldIndex = 33)]
        public string HelpLink { get; set; }

        [CsvColumn(FieldIndex = 34)]
        public string Source { get; set; }

        [CsvColumn(FieldIndex = 35)]
        public string StackTrace { get; set; }

        [CsvColumn(FieldIndex = 36)]
        public string FilePath { get; set; } 
    }
}