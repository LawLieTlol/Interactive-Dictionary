using Android.App;
using Android.Widget;
using Android.OS;

namespace Interactive_Dictionary
{
    [Activity(Label = "Interactive_Dictionary", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        string msg;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.My_button);
            TextView textView = FindViewById<TextView>(Resource.Id.output_text);
            msg = string.Format($"Btn clicked! Text appeared right here! ");
            count = msg.Length;
            button.Click += delegate { textView.Text = msg + count; };

        }
    }
}

