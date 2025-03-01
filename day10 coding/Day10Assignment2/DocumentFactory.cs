// Factory Pattern - Document Factory
public interface IDocument
{
    void Open();
}

public class PDFDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF Document");
}

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word Document");
}

public class DocumentFactory
{
    public static IDocument CreateDocument(string type)
    {
        return type.ToLower() switch
        {
            "pdf" => new PDFDocument(),
            "word" => new WordDocument(),
            _ => throw new ArgumentException("Invalid document type")
        };
    }
}