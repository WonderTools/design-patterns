namespace MyCar
{
    public interface ISpeedSource
    {
        void AddSpeedObserver(ISpeedObserver speedObserver);
    }
}