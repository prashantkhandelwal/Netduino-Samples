using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace BlinkLED
{
    public class Program
    {
        public static void Main()
        {
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            OutputPort red = new OutputPort(Pins.GPIO_PIN_D11, false);
            while (true)
            {
                led.Write(true); // turn on the LED
                red.Write(true);
                Thread.Sleep(250); // sleep for 250ms
                led.Write(false); // turn off the LED
                red.Write(false);
                Thread.Sleep(250); // sleep for 250ms
            }


        }

    }
}
