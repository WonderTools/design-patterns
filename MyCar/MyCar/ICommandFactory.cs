namespace WonderTools.MyCar
{
    public interface ICommandFactory
    {
        Command GetICommand();
        Command GetDCommand();
        Command GetLCommand();
        Command GetUCommand();
        Command GetECommand();
    }
}