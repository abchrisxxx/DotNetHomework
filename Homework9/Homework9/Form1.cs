using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        
        private SimpleCrawler crawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_crawl_Click(object sender, EventArgs e)
        {
            crawler = new SimpleCrawler();
            crawler.isOnHtml = checkBox_onlycertainpage.Checked;
            crawler.isOnSamesite = checkBox_sameWebsite.Checked;
            crawler.isOnRelative = checkBox_reltoabs.Checked;
            textBox2.Text = "";
            if (!int.TryParse(textBox_numofpage.Text, out crawler.numofpages)) {
                textBox2.Text = "爬取网站数量错误！";
                return;
            }
            string startUrl = textBox1.Text;
            crawler.websitetocrawl = SimpleCrawler.GetWebsite(startUrl);
            crawler.urls.Add(startUrl, false);//加入初始页面
            Thread t1=new Thread(crawler.Crawl);
            t1.Start();

            while (true)
            {
                if (t1.IsAlive) {
                    continue;
                }
                else
                {
                    break;
                }
            }
            textBox2.Text = "\n\n爬行已结束！\n";
        }
    }
}
