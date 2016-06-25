using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BillSplitter
{
    [Activity(Label = "BillSplitter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnSplit = FindViewById<Button>(Resource.Id.Split);
            EditText txtNumOfPeople = FindViewById<EditText>(Resource.Id.NumOfPeople);
            EditText txtCost = FindViewById<EditText>(Resource.Id.Cost);
            EditText txtPercentageTip = FindViewById<EditText>(Resource.Id.Tip);
            TextView txtvResult = FindViewById<TextView>(Resource.Id.Result);

            btnSplit.Click += (object sender, EventArgs e) =>
            {
                txtvResult.Text = TableSplit.CalculateTable(txtNumOfPeople.Text, txtCost.Text, txtPercentageTip.Text);
            };
        }
    }
}

