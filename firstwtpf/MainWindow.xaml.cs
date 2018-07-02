using System;
using System.Windows;
using System.Windows.Controls;

using System.Collections.Generic;

namespace FirstWpfApp { 
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            List<Picture> pictures = new List<Picture> {
                new Picture("Leonardo da Vinci", "Savior of the World", "Oil on walnut, 45.4 cm × 65.6 cm, Louvre Abu Dhabi"),
                new Picture("Jheronimus Bosch", "The Garden of Earthly Delights", "Oil on oak panels, 220 cm × 389 cm, Museo del Prado, Madrid"),
                new Picture("Roy Lichtenstein", "Ohhh...Alright...", "91.4 cm × 96.5 cm"),
            };
            this.artlist.ItemsSource = pictures; 
        }

    public class Picture {
        public string Painter { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Picture(string a, string b, string c) {
            this.Painter = a;
            this.Title = b;
            this.Description = c;
        }
    }

        private void Exit_Click(object sender, RoutedEventArgs e) { 
            this.Close();
        }
    }
}