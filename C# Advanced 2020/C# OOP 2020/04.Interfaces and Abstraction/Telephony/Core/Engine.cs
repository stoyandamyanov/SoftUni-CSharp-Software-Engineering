using System;
using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine : IEngine
    {

        private StationaryPhone stationaryPhone;
        private Smartphone smartphone;

        private IReader reader;
        private IWriter writer;


        private Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer)
            :this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        

        public void Run()
        {
            string[] phoneNumbers = reader.ReadLine()
                 .Split(' ')
                 .ToArray();

            string[] sites = reader.ReadLine()
                .Split(' ')
                .ToArray();


            CallNumbers(phoneNumbers);
            BrowseSites(sites);
        }

        private void BrowseSites(string[] sites)
        {
            foreach (var site in sites)
            {
                try
                {
                   writer.WriteLine(smartphone.Browse(site)); 
                }
                catch (InvalidURLException iurl)
                {
                    writer.WriteLine(iurl.Message);
                }

            }
        }

        private void CallNumbers(string[] phoneNumbers)
        {
            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        writer.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        writer.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidNumberException();
                    }
                }
                catch (InvalidNumberException e)
                {

                    writer.WriteLine(e.Message);
                }

            }
        }

        
    }
}
