using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                client.Headers.Set("IsReadOnly", "true");
                client.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                client.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
                string htmlCode = client.DownloadString("https://graph.facebook.com/me");
                txtResult.Text = htmlCode;
            }
        }
    }
}
