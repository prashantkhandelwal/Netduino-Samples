using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace LightSensor
{
    public class Program
    {
        static SecretLabs.NETMF.Hardware.AnalogInput lightSensor = new SecretLabs.NETMF.Hardware.AnalogInput(Pins.GPIO_PIN_A0);

        public static void Main()
        {
            // write your code here
            int value = 0;

            //lightSensor.SetRange(0, 10);

            while (true)
            {
                value = lightSensor.Read();

                Debug.Print(value.ToString());
                Thread.Sleep(1000);
            }



        }

    }
}
