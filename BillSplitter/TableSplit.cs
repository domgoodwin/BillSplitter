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

namespace BillSplitter
{
    public class TableSplit
    {
        public static string CalculateTable(string txtPeopleCount, string txtCost, string txtTip)
        {
            double cost = Convert.ToDouble(txtCost);
            double tip = Convert.ToDouble(txtTip);
            double peopleCount = Convert.ToDouble(txtPeopleCount);
            tip = tip / 100;
            tip = +1;
            cost = cost * tip;
            double total = cost / peopleCount;
            return total.ToString();
        }
    }
}