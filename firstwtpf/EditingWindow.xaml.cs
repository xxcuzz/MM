using System;
using System.Xml;
using System.Windows;
using System.Windows.Controls;

namespace firstwtpf
{
    public partial class EditingWindow : Window
    {
        public EditingWindow()
        {
            InitializeComponent();
        }
        
        public EditingWindow(string p, string t, string d, ListView a) {
            InitializeComponent();
            PainterBox.Text = p;
            TitleBox.Text = t;
            DescriptionBox.Text = d;

            Apply_Button.Click += (sender, EventArgs) => {
                Apply_Click(sender, EventArgs, a);
            };
        }
        
        private void Apply_Click(object sender, EventArgs e, ListView list) {
            if (PainterBox.Text != "" && TitleBox.Text != "" && DescriptionBox.Text != "") {
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

                dynamic selectedItem = list.SelectedItem;
                string p = selectedItem.Painter;
                XmlNode node = xd.SelectSingleNode("/pictures/picture[Painter='" + p + "']");
                node.ParentNode.RemoveChild(node);
                xd.Save("XMLFile1.xml");
                list.Items.Remove(list.SelectedItem);

                this.Close();
            } else {
                MessageBox.Show("Fill in the fields", "Empty");
            }
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
