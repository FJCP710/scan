using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using scan.Services;

namespace scan
{
    public partial class MainPage : ContentPage
    {
        public string id;
        private static SQLiteHelper db;

        public static SQLiteHelper Mydatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "medicinas.db"));

                }
                return db;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            
        }

        public void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                id = result.Text + " (type: " + result.BarcodeFormat.ToString() + ")";
            });
        }
    }
}
