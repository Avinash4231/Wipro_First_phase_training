using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    public class PdfReportGenerator : IReportGenerator
    {
        public Report GenerateReport()
        {
            // Logic to generate report data
            Report report = new Report
            {
                Title = "My PDF Report",
                Content = "Report content..."
            };
            return report;
        }
    }

    public class ExcelReportGenerator : IReportGenerator
    {
        public Report GenerateReport()
        {
            // Logic to generate report data
            Report report = new Report
            {
                Title = "My Excel Report",
                Content = "Report content..."
            };
            return report;
        }
    }

    public class PdfReportFormatter : IReportFormatter
    {
        public string FormatReport(Report report)
        {
            // Logic to format report as PDF
            return $"PDF Report: {report.Title}\n{report.Content}";
        }
    }

    public class ExcelReportFormatter : IReportFormatter
    {
        public string FormatReport(Report report)
        {
            // Logic to format report as Excel 
            return $"Excel Report: {report.Title}\n{report.Content}";
        }
    }

    public class FileReportSaver : IReportSaver
    {
        public void SaveReport(string report, string filePath)
        {
            // Logic to save report to file
            File.WriteAllText(filePath, report);
        }
    }


    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
