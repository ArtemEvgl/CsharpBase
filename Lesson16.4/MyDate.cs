﻿using System;
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
            
            if(day >= DateTime.DaysInMonth((int)year, (int)month) && day != 0)
                this.day = day;
            else
                throw new ArgumentException("День введен неправильно");
            if (month <= 12)           
                this.month = month;
             else
                throw new ArgumentException("Месяц не может быть больше 12ти");
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

        public static MyDate operator +(MyDate date1, uint days)
        {
            FillUpYear();
            if (days > 0)
                FillAfterYear();
            return date1;
            

            void FillUpYear()
            {
                uint[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (CheckYear(date1.year))
                    months[1] = 29;
                if(months[date1.month - 1] - date1.day + 1 > days)
                {
                    date1.day += days;
                    days = 0;
                } else
                {
                    if(date1.month == 12)
                    {
                        date1.month = 1;
                        date1.year += 1;
                    } else
                    {
                        date1.month += 1;
                    }
                    days -= months[date1.month - 1] + 1 - date1.day;
                    date1.day = 1;
                }
                if(date1.month != 1)
                {
                    for (uint i = date1.month; i <= 11; i++)
                    {
                        if(months[i] > days)
                        {
                            date1.day += days;
                            days = 0;
                            break;
                        }
                        date1.month += 1;
                        days -= months[i];
                        if(i == 11)
                        {
                            date1.month = 1;
                            date1.year += 1;
                        }
                    }
                }

            }
            void FillAfterYear()
            {
                while(days >= 365)
                {
                    uint subDays = 365;
                    if(CheckYear(date1.year))
                    {
                        if (days == 365)
                            break;
                        subDays = 366;
                    }
                    days -= subDays;
                    date1.year += 1;
                }
                uint[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (CheckYear(date1.year))
                    months[1] = 29;
                uint daysInMonth = months[0];
                int index = 0;
                while (days > daysInMonth)
                {
                    date1.month += 1;
                    days -= daysInMonth;
                    index++;
                    daysInMonth = months[index];
                }
                if(days > 0)
                {
                    date1.day += days;
                    days = 0;
                }
            }
            bool CheckYear(uint year)
            {
                return ((year % 4 == 0) && (year % 100 != 0)) ||
                    ((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0));
            }
        }
    }
}
