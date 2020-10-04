using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._4
{
    class MyDate
    {
        uint day, month, year;
        public MyDate(uint day, uint month, uint year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static uint operator -(MyDate date1, MyDate date2)
        {

            uint result = 0;
            if (date1.day > date2.day && date1.month <= date2.month && date1.year <= date2.year)
                result += date1.day - date2.day;
            else
                result += date1.day;
            if (date1.month > date2.month)
                CalculateMonth();
            if (date1.year > date2.year)
                CalculateYear();
            if (result == 0)
                throw new ArgumentException("Вторая дата позже первой");
            return result;

            void CalculateMonth()
            {
                uint[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (CheckYear(date2.year))
                    months[1] = 29;
                result += months[date2.month - 1] - date2.day;
                for (uint i = date2.month + 1; i < date1.month; i++)
                {
                    result += months[i];
                }
            }

            bool CheckYear(uint year)
            {
                return ((year % 4 == 0) && (year % 100 != 0)) ||
                    ((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0));
            }

            void CalculateYear()
            {
                uint[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (CheckYear(date2.year))
                    months[1] = 29;
                for (uint i = date2.year + 1; i < date1.year; i++)
                {
                    if (CheckYear(i))
                    {
                        result += 366;
                        continue;
                    }
                    result += 365;
                }
                result += date1.day;
                for (uint i = 0; i < date1.month - 1; i++)
                {
                    result += months[i];
                }
            }
        }

    }
}
