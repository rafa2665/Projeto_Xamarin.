using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using System;

namespace TesteJapaMiiller
{
    [Activity(Label = "TesteJapaMiiller", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button entrar;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            entrar = FindViewById<Button>(TesteJapaMiiller.Resource.Id.entrar);
            textView = FindViewById<TextView>(TesteJapaMiiller.Resource.Id.textView1);
            entrar.Click += entrar_Click;
        }

        void entrar_Click(object sender, EventArgs e)
        {
            textView.Text = "teste";
        }
    }
}

