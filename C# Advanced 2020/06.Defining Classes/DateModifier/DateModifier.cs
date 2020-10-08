using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public string date1;
        public string date2;


        public string Date1
        {
            get { return date1; }
            set { date1 = Date1; }
        }  

        public string Date2
        {
            get { return date2; }
            set { date2 = Date2; }
        }

        public DateModifier(string Date1,string Date2)
        {
            date1 = Date1;
            date2 = Date2;
        }

        public double DiffDates()
        {
            DateTime DatE1 = DateTime.Parse(Date1);
            DateTime DatE2 = DateTime.Parse(Date2);

            var res = (DatE1 - DatE2).TotalDays;

            return res;
        }

       



    }
}
