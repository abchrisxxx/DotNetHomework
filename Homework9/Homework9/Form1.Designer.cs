
namespace Homework9
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_sameWebsite = new System.Windows.Forms.CheckBox();
            this.checkBox_onlycertainpage = new System.Windows.Forms.CheckBox();
            this.checkBox_reltoabs = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_numofpage = new System.Windows.Forms.TextBox();
            this.button_crawl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_sameWebsite, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_onlycertainpage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_reltoabs, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_numofpage, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "爬取网站：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仅爬取同一主机的网站";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "仅爬取html/aspx/jsp页面";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "将相对地址转为绝对地址爬取";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(358, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // checkBox_sameWebsite
            // 
            this.checkBox_sameWebsite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_sameWebsite.AutoSize = true;
            this.checkBox_sameWebsite.Checked = true;
            this.checkBox_sameWebsite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sameWebsite.Location = new System.Drawing.Point(358, 39);
            this.checkBox_sameWebsite.Name = "checkBox_sameWebsite";
            this.checkBox_sameWebsite.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sameWebsite.TabIndex = 5;
            this.checkBox_sameWebsite.UseVisualStyleBackColor = true;
            // 
            // checkBox_onlycertainpage
            // 
            this.checkBox_onlycertainpage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_onlycertainpage.AutoSize = true;
            this.checkBox_onlycertainpage.Checked = true;
            this.checkBox_onlycertainpage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_onlycertainpage.Location = new System.Drawing.Point(358, 70);
            this.checkBox_onlycertainpage.Name = "checkBox_onlycertainpage";
            this.checkBox_onlycertainpage.Size = new System.Drawing.Size(15, 14);
            this.checkBox_onlycertainpage.TabIndex = 6;
            this.checkBox_onlycertainpage.UseVisualStyleBackColor = true;
            // 
            // checkBox_reltoabs
            // 
            this.checkBox_reltoabs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_reltoabs.AutoSize = true;
            this.checkBox_reltoabs.Checked = true;
            this.checkBox_reltoabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_reltoabs.Location = new System.Drawing.Point(358, 101);
            this.checkBox_reltoabs.Name = "checkBox_reltoabs";
            this.checkBox_reltoabs.Size = new System.Drawing.Size(15, 14);
            this.checkBox_reltoabs.TabIndex = 7;
            this.checkBox_reltoabs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "爬取的网页数量：";
            // 
            // textBox_numofpage
            // 
            this.textBox_numofpage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_numofpage.Location = new System.Drawing.Point(358, 129);
            this.textBox_numofpage.Name = "textBox_numofpage";
            this.textBox_numofpage.Size = new System.Drawing.Size(230, 21);
            this.textBox_numofpage.TabIndex = 9;
            this.textBox_numofpage.Text = "10";
            // 
            // button_crawl
            // 
            this.button_crawl.Location = new System.Drawing.Point(318, 161);
            this.button_crawl.Name = "button_crawl";
            this.button_crawl.Size = new System.Drawing.Size(75, 23);
            this.button_crawl.TabIndex = 1;
            this.button_crawl.Text = "开始爬取";
            this.button_crawl.UseVisualStyleBackColor = true;
            this.button_crawl.Click += new System.EventHandler(this.button_crawl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 418);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(710, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "设置查询条件后点击“开始爬取”";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_crawl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_sameWebsite;
        private System.Windows.Forms.CheckBox checkBox_onlycertainpage;
        private System.Windows.Forms.CheckBox checkBox_reltoabs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_numofpage;
        private System.Windows.Forms.Button button_crawl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

