using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    internal class DateTime
    {
        private int day;
        private int month;
        private int year;
        private int hour;
        private int minute;
        public DateTime(int day, int month, int year, int hour, int minute) 
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.hour = hour;
            this.minute = minute;
        }

        public void SetDay(int day) {  this.day = day; }
        public void SetMonth(int month) { this.month = month; }
        public void SetYear(int year) { this.year = year; }
        public void SetHour(int hour) { this.hour = hour; }
        public void SetMinute(int minute) { this.minute = minute; }

        public int GetDay() { return day; }
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
        public int GetHour() { return hour; }
        public int GetMinute() { return minute; }

        public string DisplayDatetime()
        {
            return this.day + "/" + this.month + "/" + this.year + "at " + this.hour + ":" + this.minute;
        }
    }
}
