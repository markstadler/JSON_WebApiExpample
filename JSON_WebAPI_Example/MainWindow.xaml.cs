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
using JSON_WebAPI_Example;
using System.Web.Script.Serialization; // adds this but before add rference --> System.Web.Extensions
using Newtonsoft.Json; // adds this but before add rference --> JSON.net

namespace JSON_WebAPI_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // fetch data as Json String
            var url = new Uri("http://localhost:1234/MyService.svc/json/4");
            var client = new System.Net.WebClient();
            // var json =  await client.DownloadStringTaskAsync(url);
            var json = client.DownloadStringTaskAsync(url);

            // deserialize JSON into object
            var serializer = new JavaScriptSerializer();

            //var jsonResult =  serializer.Deserialize(json);

            // use the objects 
        //    tblkJSON.Text = data;
        }
    }
}
