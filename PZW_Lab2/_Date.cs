using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Klasa mora podržati slijedeće funkcionalnosti: getMonthName, 
 * getNumberOfRemaingDaysInMonth, isLeapYear (prijestupne godine su sve djeljive s 4, ako nisu djeljive sa 100, 
 * kojima se dodaju one koju su djeljive sa 400, npr 2000-ta je prijestupna iako je djeljiva sa 100, 
 * jer je djeljiva sa 400). Napraviti unit-testove koji postižu potpunu pokrivenost koda.*/

namespace PZW_Lab2
{
    public class _Date
    {
        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        private int year;
        private string[] months= {"January",
                                  "February", 
                                  "March",
                                  "April",
                                  "May",
                                  "June",
                                  "July",
                                  "August",
                                  "September",
                                  "October",
                                  "November",
                                  "December"};

        public _Date(int day, int month, int year)
        {
            if(day >= 1 && day <= 31 && month >= 1 && month <=12)
            {
                this.day = day;
                this.month = month;
                this.year = year;

           
            }
        }

        public string getMonthName
        {
            get { return months[month-1]; }
        }

        public int Year
        {
            get { return this.year; }
        }

        public bool isLeapYear()
        {
            if (Year % 4 != 0) { return false; }
            if (Year % 100 == 0 && Year % 400 != 0) { return false; }
            
            return true;
        }

        public int getNumberOfRemaingDaysInMonth()
        {
            return 31 - this.day;
        }

        
    }
}
