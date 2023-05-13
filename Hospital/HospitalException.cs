using System;

namespace Hospital
{
    public class HospitalException : Exception
    {
        private HospitalException(string message)
            : base(message) { }

        public static HospitalException InvalidNameException(string name)
        {
            return new HospitalException($"Имя {name} не является корректным именем.");
        }
        
        public static HospitalException InvalidAddressException(string address)
        {
            return new HospitalException($"Адрес {address} не является корректным адресом.");
        }
    }
}