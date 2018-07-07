using System.Windows;
using System.Xml;

namespace FirstWpfApp {
    public partial class MainWindow : Window {
        public static int fl = 0;           //bad

        public MainWindow() {
            InitializeComponent();
            
            XmlDocument xd = new XmlDocument();
            xd.Load("XMLFile1.xml");
            XmlElement xRoot = xd.DocumentElement;          
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

        private void Add_Click(object sender, RoutedEventArgs e) {
            firstwtpf.AddingWindow adding = new firstwtpf.AddingWindow {
                Owner = this
            };
            adding.ShowDialog();
            if (fl == 0) {
                XmlDocument xd = new XmlDocument();
                xd.Load("XMLFile1.xml");
                XmlElement xRoot = xd.DocumentElement;
                Picture pic = new Picture();
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
                artlist.Items.Add(pic);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e) {
            dynamic selectedItem = artlist.SelectedItem;
            if (selectedItem != null && artlist.SelectedItems.Count == 1) {
                string p = selectedItem.Painter;
                string t = selectedItem.Title;
                string d = selectedItem.Description;

                firstwtpf.EditingWindow epicWin = new firstwtpf.EditingWindow(p, t, d) {
                    Owner = this
                };
                epicWin.ShowDialog();
                if (fl == 0) {
                    XmlDocument xd = new XmlDocument();
                    xd.Load("XMLFile1.xml");
                    XmlElement xRoot = xd.DocumentElement;
                    Picture pic = new Picture();
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
                    artlist.Items.Add(pic);

                    selectedItem = artlist.SelectedItem;
                    p = selectedItem.Painter;
                    XmlNode node = xd.SelectSingleNode("/pictures/picture[Painter='" + p + "']");
                    node.ParentNode.RemoveChild(node);
                    xd.Save("XMLFile1.xml");
                    artlist.Items.Remove(artlist.SelectedItem);
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            XmlDocument xd = new XmlDocument();
            xd.Load("XMLFile1.xml");
            XmlElement xRoot = xd.DocumentElement;

            while (artlist.SelectedItems.Count > 0) {
                dynamic selectedItem = artlist.SelectedItem;
                var p = selectedItem.Painter;
                XmlNode node = xd.SelectSingleNode("/pictures/picture[Painter='" + p + "']");
                node.ParentNode.RemoveChild(node);
                xd.Save("XMLFile1.xml");

                artlist.Items.Remove(artlist.SelectedItem);
            }

            if (artlist.Items.Count == 0) {
                delete_button.IsEnabled = false;
            }
        }

        public static void NewArt(string p, string t, string d) {
            XmlDocument xd = new XmlDocument();
            xd.Load("XMLFile1.xml");
            XmlElement xRoot = xd.DocumentElement;
            XmlElement picElem = xd.CreateElement("picture");

            XmlElement painElem = xd.CreateElement("Painter");
            XmlElement titleElem = xd.CreateElement("Title");
            XmlElement descElem = xd.CreateElement("Description");

            XmlText painText = xd.CreateTextNode(p);
            XmlText titleText = xd.CreateTextNode(t);
            XmlText descText = xd.CreateTextNode(d);

            painElem.AppendChild(painText);
            titleElem.AppendChild(titleText);
            descElem.AppendChild(descText);

            picElem.AppendChild(painElem);
            picElem.AppendChild(titleElem);
            picElem.AppendChild(descElem);
            xRoot.AppendChild(picElem);
            xd.Save("XMLFile1.xml");
        }
    }
}