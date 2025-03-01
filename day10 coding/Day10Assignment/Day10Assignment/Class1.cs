namespace Day10Assignment
{
    public interface IReportGenerator
    {
        Report GenerateReport();
    }

    public interface IReportFormatter
    {
        string FormatReport(Report report);
    }

    public interface IReportSaver
    {
        void SaveReport(string report, string filePath);
    }
}
