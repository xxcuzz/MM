using System;
using System.Windows;
using System.Xml;
using System.Windows.Controls;

namespace firstwtpf {
    public partial class AddingWindow : Window {
        public AddingWindow() {
            InitializeComponent();
        }

        public AddingWindow(ListView a) {
            InitializeComponent();

            Apply_Button.Click +=(sender, EventArgs)=> {
                Apply_Click(sender, EventArgs, a);
            };
        }

        private void Apply_Click(object sender, EventArgs e, ListView list) {
            if(PainterBox.Text != "" && TitleBox.Text != "" && DescriptionBox.Text != "") {
                FirstWpfApp.MainWindow.NewArt(PainterBox.Text, TitleBox.Text, DescriptionBox.Text);
                XmlDocument xd = new XmlDocument();
                xd.Load("XMLFile1.xml");
                XmlElement xRoot = xd.DocumentElement;
                FirstWpfApp.MainWindow.Picture pic = new FirstWpfApp.MainWindow.Picture();
                XmlNode xNode = xRoot.LastChild;
                foreach (XmlNode childNode in xNode.ChildNodes) {
                    if (childNode.Name == "Painter") {
                        pic.Painter = childNode.InnerText;
                    }

                    if (childNode.Name == "Title") {
                        pic.Title = childNode.InnerText;
                    }

                    if (childNode.Name == "Description") {
                        pic.Description = childNode.InnerText;
                    }
                }
                list.Items.Add(pic);
                this.Close();
            } else {
                MessageBox.Show("Fill in the fields","Empty");
            }
        }
        
        private void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
