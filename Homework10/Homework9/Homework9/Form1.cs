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
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button_crawl_Click(object sender, EventArgs e)
        {
            
            crawler = new SimpleCrawler();
            crawler.isOnHtml = checkBox_onlycertainpage.Checked;
            crawler.isOnSamesite = checkBox_sameWebsite.Checked;
            crawler.isOnRelative = checkBox_reltoabs.Checked;
            if (!int.TryParse(textBox_numofpage.Text, out crawler.numofpages)) {
                richTextBox1.Text += "爬取网站数量错误！\n";
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
                return;
            }
            string startUrl = textBox1.Text;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text += "正在爬取网址：" + startUrl + "\n";
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            crawler.websitetocrawl = SimpleCrawler.GetWebsite(startUrl);
            richTextBox1.Text += "主机名：" + crawler.websitetocrawl + "\n";
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
            if (crawler.isOnHtml) {
                richTextBox1.Text += "配置为仅爬取html/jsp/aspx网页\n";
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            if (crawler.isOnRelative) {
                richTextBox1.Text += "配置为将相对地址转为绝对地址爬取\n";
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            if (crawler.isOnSamesite) {
                richTextBox1.Text += "配置为仅爬取同主机上的网页\n";
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            richTextBox1.Text += "爬取网页数目为：" + crawler.numofpages + "\n";
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
            crawler.urls.TryAdd(startUrl, false);//加入初始页面
            Thread t1=new Thread(crawler.Crawl);
            t1.Start();

            t1.Join();
            richTextBox1.Text += "\n\n爬行已结束！\n\n\n";
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
            button_crawl.Text = "开始爬取";
        }
    }
}
