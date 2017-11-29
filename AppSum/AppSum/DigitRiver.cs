using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppSum
{
  public static  class DigitRiver
    {
        public static string NextNumber(string number)
        {
            try
            {
                int n = Convert.ToInt32(number);
                int s = 0;
                int d = n;
                while (d > 0)
                {
                    s += d % 10;
                    d /= 10;
                }
                n += s;
                return n.ToString();
            }
            catch
            {
                return "1";
            }
            
        }
    }
}