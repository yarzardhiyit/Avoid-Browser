using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avoid_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            webAvoid.Refresh();
        }

        private void tlsForward_Click(object sender, EventArgs e)
        {
            webAvoid.GoForward();
        }

        private void tlsBack_Click(object sender, EventArgs e)
        {
            webAvoid.GoBack();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            string sUrl = txtUrl.Text.ToString();

            if (e.KeyCode == Keys.Enter)
            {
                webAvoid.Navigate(sUrl);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtSearch.Text.ToString();
                string sGoogle = "https://www.google.com/search?q=" + search;
                string sBing = "https://www.bing.com/search?q=" + search;
                string sYahoo = "https://search.yahoo.com/search?p=" + search;
                string sBaidu = "http://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=" + search;
                string sYandex = "https://yandex.com/search/?text=" + search;

                string sEngine;
                sEngine = Text.ToString();

                switch (cbSearchEngine.SelectedIndex)
                {
                    case 0: sEngine = sGoogle; break;
                    case 1: sEngine = sBing; break;
                    case 2: sEngine = sYahoo; break;
                    case 3: sEngine = sBaidu; break;
                    case 4: sEngine = sYahoo; break;
                }

                txtUrl.Text = sEngine;
                webAvoid.Navigate(sEngine);
            }
        }
    }
}
