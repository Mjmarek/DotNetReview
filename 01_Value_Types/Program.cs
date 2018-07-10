using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Monica";
            int number = 1;
            bool isReady = true;
            byte value = 124;
            char[] chars = new char[3];
            decimal money = 7.00m;
        }

        struct Address
        {
            public string AddressLine1;
            public string AddressLine2;
            public string City;
            public string State;
            public string ZIP;
        }
    }
}
