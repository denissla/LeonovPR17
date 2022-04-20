using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeonovPR17
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                lable1.TextColor = Color.Black;
                string req = webClient.DownloadString($"http://numbersapi.com/{Number.Text.Replace(".", "")}?notfound=ceil");
                lable1.Text = Translate(req);
            }
        }

        public string Translate(string word)
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl=ru&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }
    }
}