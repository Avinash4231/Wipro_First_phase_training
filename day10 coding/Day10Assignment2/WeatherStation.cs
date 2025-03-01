// Observer Pattern - WeatherStation
public interface IObserver
{
    void Update(float temperature);
}

public class WeatherDisplay : IObserver
{
    private string _name;
    public WeatherDisplay(string name) => _name = name;
    
    public void Update(float temperature)
    {
        Console.WriteLine($"{_name} received update: Temperature is {temperature}°C");
    }
}

public class WeatherStation
{
    private List<IObserver> _observers = new();
    private float _temperature;

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
    public void UnregisterObserver(IObserver observer) => _observers.Remove(observer);
    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        NotifyObservers();
    }
    
    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}