using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace firstwtpf {  
    public partial class Watch_out : Window {
        public Watch_out(string p) {
            try {
                InitializeComponent();
                img.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\" + p + ".jpg", UriKind.Absolute));
                Show();
            }
            catch (System.IO.FileNotFoundException){
                MessageBox.Show("No picture",":(");
            }
        }
    }
}
