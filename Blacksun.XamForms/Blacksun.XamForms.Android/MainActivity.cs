﻿using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Blacksun.XamForms.Sample.Core;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Blacksun.XamForms.Droid
{
    [Activity(Label = "Blacksun.XamForms", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this,bundle);
            UserDialogs.Init(this);
            LoadApplication(new App());
        }
    }
}

