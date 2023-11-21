namespace FirstApi.Models
{
    public interface IAccessories
    {
        void Log(string message);
    }

    public class CarAccessories : IAccessories
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    public interface IApiLogger
    {
        void Log(string message);
    }
    public class ApiLogger : IApiLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
    public class FileApiLogger : IApiLogger
    {
        private string _fileName;
        public FileApiLogger()
        {
            //file handling, i/o - interoperate
            _fileName = $"Log_{DateTime.Now.ToFileTime()}.log";
            File.WriteAllText(_fileName,"This is a log file" + Environment.NewLine); //if file not there will create, if there overwritten
        }
        public void Log(string message)
        {
            //do not override the existing contents, just append
            File.AppendAllText(_fileName, $"{DateTime.Now}: { message}");
            File.AppendAllText(_fileName, Environment.NewLine);
        }
    }

}
