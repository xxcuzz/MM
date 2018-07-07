using System.Windows;

namespace firstwtpf
{
    public partial class AddingWindow : Window
    {
        public AddingWindow()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e) {
            if(PainterBox.Text != "" && TitleBox.Text != "" && DescriptionBox.Text != "") {
                FirstWpfApp.MainWindow.fl = 0;                
                FirstWpfApp.MainWindow.NewArt(PainterBox.Text, TitleBox.Text, DescriptionBox.Text);                                   
                this.Close();
            } else {
                MessageBox.Show("Fill in the fields","Empty");
            }
        }
        
        private void Cancel_Click(object sender, RoutedEventArgs e) {
            FirstWpfApp.MainWindow.fl = 1;
            this.Close();
        }
    }
}
