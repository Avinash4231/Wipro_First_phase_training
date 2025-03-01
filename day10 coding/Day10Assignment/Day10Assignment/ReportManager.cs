using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    public class ReportManager
    {
        private readonly IReportGenerator _reportGenerator;
        private readonly IReportFormatter _reportFormatter;
        private readonly IReportSaver _reportSaver;

        public ReportManager(IReportGenerator reportGenerator,
                             IReportFormatter reportFormatter,
                             IReportSaver reportSaver)
        {
            _reportGenerator = reportGenerator;
            _reportFormatter = reportFormatter;
            _reportSaver = reportSaver;
        }

        public void GenerateAndSaveReport(string filePath)
        {
            Report report = _reportGenerator.GenerateReport();
            string formattedReport = _reportFormatter.FormatReport(report);
            _reportSaver.SaveReport(formattedReport, filePath);
        }
    }
}
