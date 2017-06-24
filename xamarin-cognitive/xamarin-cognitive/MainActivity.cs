using Android.App;
using Android.Widget;
using Android.OS;
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
using Emotions;
using System.IO;
using Plugin.Media.Abstractions;

namespace xamarin_cognitive
{
    [Activity(Label = "xamarin_cognitive", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //ItemManager manager;
        static Stream streamCopy;
        string ResultadoEmociones = "RODRIGO: ";
        TextView txtResultado;
        Button btnRegistraResultados;
        Button btnAnalizaFoto;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            //manager = ItemManager.DefaultManager;
            SetContentView(Resource.Layout.Cognitive);
        }
    }
}

