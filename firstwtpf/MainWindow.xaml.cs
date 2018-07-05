using System;
using System.Windows;
using System.Windows.Controls;

using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace FirstWpfApp { 
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            List<Picture> pictures = new List<Picture>();

            XmlDocument xd = new XmlDocument();
            xd.Load("XMLFile1.xml");
            XmlElement xRoot = xd.DocumentElement;          //get root element
            foreach (XmlNode xNode in xRoot) {
                Picture pic = new Picture();
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
                artlist.Items.Add(pic);
                pictures.Add(pic);
            }
        }

        public class Picture {
            public string Painter { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public Picture() {
                this.Painter = "";
                this.Title = "";
                this.Description = "";
            }

            public Picture(string a, string b, string c) {
                this.Painter = a;
                this.Title = b;
                this.Description = c;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            int count = artlist.SelectedItems.Count;

            XmlDocument xd = new XmlDocument();
            xd.Load("XMLFile1.xml");
            XmlElement xRoot = xd.DocumentElement;

            if (count > 0) {
                while (artlist.SelectedItems.Count > 0) {
                    dynamic selectedItem = artlist.SelectedItem;
                    var p = selectedItem.Painter;
                    XmlNode node = xd.SelectSingleNode("/pictures/picture[Painter='" + p + "']");
                    node.ParentNode.RemoveChild(node);

                    xd.Save("XMLFile1.xml");

                    artlist.Items.Remove(artlist.SelectedItem);
                }
            }
            if(artlist.Items.Count == 0) {
                delete_button.IsEnabled = false;
            }
        }

    }
}