using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace webScraper
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbxURL.Text))
            {
                MessageBox.Show("Please enter an URL in the textbox.");
            }
            else
            {
                Uri u= new Uri(tbxURL.Text);
                if(!u.IsWellFormedOriginalString())
                {
                    MessageBox.Show("Please enter an valid URL in the textbox.");
                    tbxURL.Clear();
                }
                else
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(u);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    File.WriteAllText(@".\output.html", responseString);
                    MessageBox.Show("Scraping complete.");
                    tbxURL.Clear();
                }
            }
        }
    }
}
