using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    /*T01
    public class DateModifier
    {

        private string date1;
        private string date2;
        public string Date1
        {
            get { return date1; }
            set { date1 = value; }
        }

        public string Date2
        {
            get { return date2; }
            set { date2 = value; }
        }

        public DateModifier(string d1, string d2)
        {
            Date1 = d1;
            Date2 = d2;
        }

        public string ReturnDifferenceBetweenDates()
        {
            int[] date1ToInt = Date1.Split().Select(int.Parse).ToArray();
            int[] date2ToInt = Date2.Split().Select(int.Parse).ToArray();

            DateTime firstDate = new DateTime(date1ToInt[0], date1ToInt[1], date1ToInt[2]);
            DateTime secondDate = new DateTime(date2ToInt[0], date2ToInt[1], date2ToInt[2]);

            return Math.Abs((firstDate-secondDate).TotalDays).ToString(); 
        }
    }
    */
}
