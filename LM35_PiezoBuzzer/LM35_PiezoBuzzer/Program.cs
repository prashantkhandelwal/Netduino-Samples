using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.IO.Ports;

namespace LM35_PiezoBuzzer
{
    public class Program
    {
        static SecretLabs.NETMF.Hardware.AnalogInput tempSensor = new SecretLabs.NETMF.Hardware.AnalogInput(Pins.GPIO_PIN_A0);
        static SecretLabs.NETMF.Hardware.PWM speaker = new SecretLabs.NETMF.Hardware.PWM(Pins.GPIO_PIN_D9);



        public static void Main()
        {
            int tempInput = 0;

            while (true)
            {
                tempInput = tempSensor.Read();
                
                float volts = ((float)tempInput / 1024.0f) * 3.3f;
                float temp_celcius = (volts * 100);
                float temp_fahrenheit = (temp_celcius * 9) / 5 + 32;
                
 
                if (temp_celcius > 24.0f)
                {
                    speaker.SetPulse((uint)(1000000 / 2217.46f), (uint)(1000000 / 2217.46f)/2);
                }
                else
                {
                    speaker.SetDutyCycle(0);
                }

                Debug.Print("Celcius: " + temp_celcius.ToString() + " - " + "Fahrenheit: " + temp_fahrenheit.ToString());
                Thread.Sleep(1000);

            }

        }

    }
}
