//using Xunit;
using Day10Assignment;
namespace TestProject
{
    [TestFixture]
    public class ReportManagerTests
    {
        [Test]
        public void GenerateAndSavePdfReport()
        {
            // Arrange
            string filePath = "test_report.pdf";
            IReportGenerator generator = new PdfReportGenerator();
            IReportFormatter formatter = new PdfReportFormatter();
            IReportSaver saver = new FileReportSaver();
            ReportManager manager = new ReportManager(generator, formatter, saver);

            // Act
            manager.GenerateAndSaveReport(filePath);

            // Assert
            string actualReport = File.ReadAllText(filePath);
            string expectedReport = "PDF Report: My PDF Report\nReport content...";
            Assert.That(expectedReport.Equals(actualReport));

            // Clean up (optional)
            File.Delete(filePath);
        }

    }
}