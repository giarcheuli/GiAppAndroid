using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Views;
using static Android.Views.ViewGroup;

namespace GiApp
{
    [Activity(Label = "GiApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private TextView _textView;

        private readonly string[] _strings =
        {
            "Wow such App...",
            "Button tap...",
            "Very color...",
            "Running App...",
            "Very interface...",
            "So much code...",
            "Help me I am trapped...",
            "Is there anybody out there!?",
            "You are tapping the crap out of me.",
            "Stop tapping.",
            "Okay, tap.",
            "This text is pre-written.",
            "You think I’m actually talking to you?",
            "I’m not.",
            "I want to be smart",
            "But I’m only",
            "a list of strings",
            ".apk",
            "Lonely .apk"
        };

        private readonly Random _random = new Random();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _textView = FindViewById<TextView>(Resource.Id.textView1);
            var button = FindViewById<Button>(Resource.Id.changeStringButton);
            button.Click += ChangeString;
            ChangeString(null, null);
        }

        private void ChangeString(object sender, EventArgs e)
        {
            var randomIndex = _random.Next(0, _strings.Length);
            _textView.Text = _strings[randomIndex];
            _textView.Gravity = GravityFlags.Center;
        }
    }
}