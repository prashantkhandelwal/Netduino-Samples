using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Temperature_LM35
{
    public class Program
    {
        static SecretLabs.NETMF.Hardware.AnalogInput tempSensor = new SecretLabs.NETMF.Hardware.AnalogInput(Pins.GPIO_PIN_A0);
        
        public static void Main()
        {
            int tempInput = 0;

            while (true)
            {
                //Read the raw sensor value
                tempInput = tempSensor.Read();

                //Debug.Print("Reading :" + tempSensor.Read().ToString());

                //The read value is from 0-1024, so this converts it to a % then
                //multiplies by 3.3v to get the real voltage that was read.
                
                float volts = ((float)tempInput / 1024.0f) * 3.3f;

                //The datasheet for the sensor indicates there's a 500mV (half a volt)
                //offset, this is to allow it to read under 0 degrees
                //float temp = (volts - 0.5f);

                //Finally, every 10mV indicates 1 degree Celcius, so multiply by 100
                //to convert the voltage to a reading
                ///float temp = temp * 100;

                //float temp = (5.0f * tempInput * 100.0f) / 1024.0f;

                float temp_celcius = (volts * 100);
                float temp_fahrenheit = (temp_celcius * 9) / 5 + 32;

                Debug.Print("Celcius: " + temp_celcius.ToString() + " - Fahrenheit: " + temp_fahrenheit.ToString());
                //Debug.Print("Celcius: " + temp.ToString());
                Thread.Sleep(1000);
            }


        }


    }
}
