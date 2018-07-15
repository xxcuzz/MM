using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace firstwtpf {  
    public partial class Watch_out : Window {
        public Watch_out(string p) {
            try {
                InitializeComponent();                
                img.Source = new BitmapImage(new Uri(ProjectPath(p)));
                Show();
            }
            catch (System.IO.FileNotFoundException){
                MessageBox.Show("No picture",":(");
            }
        }
        public string ProjectPath(string p) {
            string s = Directory.GetCurrentDirectory();
            int idx = s.LastIndexOf("\\bin");
            s = s.Substring(0, idx);
            s += "\\picSquad\\" + p + ".jpg";
            return s;
        }
    }
}
