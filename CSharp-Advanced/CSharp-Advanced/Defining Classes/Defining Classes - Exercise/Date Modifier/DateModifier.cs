using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateModifier(string date)
        {
            this.Date = date;
        }
        public string Date { get; set; }
        public static string Difference(string firstDate, string secondDate)
        {
            var dateFirst = firstDate.Split(" ");
            var dateSecond = secondDate.Split(" ");
            var first = new DateTime(int.Parse(dateFirst[0]), int.Parse(dateFirst[1]), int.Parse(dateFirst[2]));
            var second = new DateTime(int.Parse(dateSecond[0]), int.Parse(dateSecond[1]), int.Parse(dateSecond[2]));
            var difference = Math.Abs((second - first).TotalDays).ToString();

            return difference;
        }
    }
}
