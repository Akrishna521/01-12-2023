using System;

namespace MySharedLibrary
{
    public class MyUtilityClass
    {
        public void ValidateData(string data)
        {
            Console.WriteLine($"Validating data: {data}");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"Logging message: {message}");
        }

        public string EncryptData(string data)
        {
            return $"Encrypted: {data}";
        }
    }
}
