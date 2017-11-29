using Android.App;
using Android.Widget;
using Android.OS;

namespace AppSum
{
    [Activity(Label = "AppSum", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EditText numberText = FindViewById<EditText>(Resource.Id.number);
            Button nextButton = FindViewById<Button>(Resource.Id.buttonstart);

            nextButton.Click += (sender, e) =>
            {
                numberText.Text = DigitRiver.NextNumber(numberText.Text);
            };
        }
    }
}

