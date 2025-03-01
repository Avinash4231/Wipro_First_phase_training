public class Program
{
    public static void Main()
    {
        // Singleton Example
        Logger logger = Logger.GetInstance();
        logger.Log("Singleton pattern example.");

        // Factory Example
        IDocument doc = DocumentFactory.CreateDocument("pdf");
        doc.Open();

        // Observer Example
        WeatherStation station = new();
        WeatherDisplay display1 = new("Display 1");
        WeatherDisplay display2 = new("Display 2");
        
        station.RegisterObserver(display1);
        station.RegisterObserver(display2);
        
        station.SetTemperature(25.5f);
    }
}