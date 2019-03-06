using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace VLPTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private XDocument xdoc;

        public MainWindow()
        {
            InitializeComponent();

            List<Project> Clients       = new List<Project>();
            List<Project> Projects      = new List<Project>();
            List<Project> AccountCode   = new List<Project>();
            List<Project> ShortCode     = new List<Project>();


        //    XmlDocument xdoc = new XmlDocument();
            xdoc = XDocument.Load("ConfigFile.xml");
            var query = from u in xdoc.Element("Config").Element("Projects").Elements("Project")//.Where(
                        select new
                        {
                            uProject = u.Attribute("Number").Value.ToArray(),
                            uClient = u.Element("Client").Value.ToArray(),
                            uRestriction = u.Element("Restriction").Value.ToArray()
                        };
            foreach (var u in query)
            {
                var projNumber = u.uProject;
                var projClient = u.uClient;
                Projects.Add(projNumber);
            }

        //    List<Country> countries = new List<Country> { new Country("UK"),
        //                             new Country("Australia"),
        //                             new Country("France") };
        //
        //    bindingSource1.DataSource = countries;
        //
        //    comboBox1.DataSource = bindingSource1.DataSource;
        //
        //    comboBox1.DisplayMember = "Name";
        //    comboBox1.ValueMember = "Name";



            //XmlNode node = xdoc.LoadXml.xdoc;//   SelectNodes("Projects");

            //XmlNode node = xdoc.SelectSingleNode("Magasin");

            //XmlNodeList prop = node.SelectNodes("Items");
            //
            //foreach (XmlNode item in prop)
            //{
            //    items Temp = new items();
            //    Temp.AssignInfo(item);
            //    lstitems.Add(Temp);
            //}
    //    }
    //    public class Country
    //    {
    //        public string Name { get; set; }
    //        public IList<City> Cities { get; set; }
    //        public Country(string _name)
    //        {
    //            Cities = new List<City>();
    //            Name = _name;
    //        }
        }
    }

    internal class Project
    {
    }
}
