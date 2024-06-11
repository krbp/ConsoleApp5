using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class CustomException : Exception
    {
        public DateTime Time { get; }
        public CustomException(string message) : base(message)
        {
            Time = DateTime.Now;
        }

        public static void ThrowError(DateTime t)
        {
            throw new CustomException($"Time: {t} ");
        }
    }
}
