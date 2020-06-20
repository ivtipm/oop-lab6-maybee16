using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class ClassDay
    {
        int day, month, year;

        public void SetDay(int d)
        {
            if((d>0)&&(d<=31))
                day = d;
        }

        public void SetMonth(int m)
        {
            if((m>0)&&(m<=12))
                month = m;
        }
        public void SetYear(int y)
        {
            if ((y > 1900) && (y <= 2020))
                year = y;
        }
        public string GetDayOfTheWeek()
        {
            int d;
            string s="";
            int a = (14 - month) / 12;
            int b = year - a;
            int c = month + 12 * a - 2;
            d = (7000 + (day + b + b / 4 - b / 100 + b / 400 + (31 * c) / 12)) % 7;
            if (d == 0) s = "в воскресенье";
            if (d == 1) s = "в понедельник";
            if (d == 2) s = "во вторник";
            if (d == 3) s = "в среду";
            if (d == 4) s = "в четверг";
            if (d == 5) s = "в пятницу";
            if (d == 6) s = "в субботу";
            return s;
        }
    }
}
