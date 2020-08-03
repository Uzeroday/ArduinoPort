using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace ArduinoPort
{
    class Program
    {
       
 private static void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write("Value : "  + indata);
            
        }


        static void Main(string[] args)
        {
            String portNumber = "COM3";
            SerialPort port = new SerialPort(portNumber, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            Console.WriteLine( "ArdionpPort ep.1");
            Console.WriteLine();



            try
            {
                port.Open();
                Console.WriteLine( "Port : " + portNumber + " Sucsess");

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                Console.ReadKey();
                return;
            }
            for (int i = 0; i <= 100; i++)
            {
                String key = Console.ReadLine();
                if (key.Equals("end"))
                {
                    port.Close();
                    i = 101;
                }
                else
                {
                    port.Write(key);
                }
            }
        }
    }
}

