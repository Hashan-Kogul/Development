using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicClass
{
    public class Class1
    {
        public string CheckGender (int g)
        {
            if (g < 500)
                return "Male";
            else
                return "Female";
        }
        public string Vote (String v)
        {
            if (v.EndsWith("V"))
                return "Eligible";
            else
                return "Not Eligible";
        }

        public string DateofBirth(int g)
        {
            int days, day = 0, month = 0;

            if (g > 500)
            {
                days = g - 500;
            }
            else
            {
                days = g;
            }
            if(days >335)
            {
                day = days - 335;
                month = 12;
            }
            else if (days >305)
            {
                day = days - 305;
                month = 11;
            }
            else if (days > 274)
            {
                day = days - 274;
                month = 10;
            }
            else if(days>244)
            {
                day = days - 244;
                month = 09;

            }
            else if(days>213)
            {
                day = days - 213;
                month = 08;
            }
            else if (days>182)
            {
                day = days - 182;
                month = 07;
            }
            else if (days>152)
            {
                day = days - 152;
                month = 06;
            }
            else if (days > 121)
            {
                day = days - 121;
                month = 05;
            }
            else if (days > 91)
            {
                day = days - 91;
                month = 04;
            }
            else if (days > 60)
            {
                day = days - 60;
                month = 03;
            }
            else if (days > 32)
            {
                day = days - 32;
                month = 01;
            }
            else if (days > 31)
            {
                day = days - 31;
                month = 02;
            }
            return (month + "." + day);
        }
    }
}
