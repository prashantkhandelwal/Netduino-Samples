using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoApplication2
{
    public class Program
    {
        public static void Main()
        {
            // write your code here

            //PWM led1 = new PWM(PWMChannels.PWM_PIN_D3, 500, .5, false);
            //led1.Start();
            //led1.DutyCycle = .05;

            OutputPort led = new OutputPort(Pins.GPIO_PIN_D13, false);



            //A while-loop will make our code loop indefinitely
            while (true)
            {
                led.Write(false);
                Thread.Sleep(1000);

                led.Write(true);
                Thread.Sleep(1000);
            }




            /*
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            while (true)
            {
                led.Write(true); // turn on the LED
                Thread.Sleep(250); // sleep for 250ms
                led.Write(false); // turn off the LED
                Thread.Sleep(250); // sleep for 250ms
            }
            */
        }

    }
}
