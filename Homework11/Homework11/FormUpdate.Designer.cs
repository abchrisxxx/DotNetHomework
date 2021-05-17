
namespace Homework11
{
    partial class FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_orderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Apple = new System.Windows.Forms.CheckBox();
            this.checkBox_Book = new System.Windows.Forms.CheckBox();
            this.checkBox_Coke = new System.Windows.Forms.CheckBox();
            this.checkBox_Milk = new System.Windows.Forms.CheckBox();
            this.checkBox_Bread = new System.Windows.Forms.CheckBox();
            this.textBox_Apple = new System.Windows.Forms.TextBox();
            this.textBox_Book = new System.Windows.Forms.TextBox();
            this.textBox_Coke = new System.Windows.Forms.TextBox();
            this.textBox_Milk = new System.Windows.Forms.TextBox();
            this.textBox_Bread = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Update = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_orderId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号：";
            // 
            // textBox_orderId
            // 
            this.textBox_orderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_orderId.Location = new System.Drawing.Point(225, 18);
            this.textBox_orderId.Name = "textBox_orderId";
            this.textBox_orderId.Size = new System.Drawing.Size(100, 21);
            this.textBox_orderId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进行的操作：";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "添加商品",
            "移除商品"});
            this.comboBox1.Location = new System.Drawing.Point(225, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择商品";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.checkBox_Apple, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBox_Book, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.checkBox_Coke, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.checkBox_Milk, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.checkBox_Bread, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Apple, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Book, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Coke, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Milk, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Bread, 2, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(445, 217);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // checkBox_Apple
            // 
            this.checkBox_Apple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Apple.AutoSize = true;
            this.checkBox_Apple.Location = new System.Drawing.Point(158, 13);
            this.checkBox_Apple.Name = "checkBox_Apple";
            this.checkBox_Apple.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Apple.TabIndex = 0;
            this.checkBox_Apple.Text = "苹果";
            this.checkBox_Apple.UseVisualStyleBackColor = true;
            // 
            // checkBox_Book
            // 
            this.checkBox_Book.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Book.AutoSize = true;
            this.checkBox_Book.Location = new System.Drawing.Point(158, 56);
            this.checkBox_Book.Name = "checkBox_Book";
            this.checkBox_Book.Size = new System.Drawing.Size(36, 16);
            this.checkBox_Book.TabIndex = 1;
            this.checkBox_Book.Text = "书";
            this.checkBox_Book.UseVisualStyleBackColor = true;
            // 
            // checkBox_Coke
            // 
            this.checkBox_Coke.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Coke.AutoSize = true;
            this.checkBox_Coke.Location = new System.Drawing.Point(158, 99);
            this.checkBox_Coke.Name = "checkBox_Coke";
            this.checkBox_Coke.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Coke.TabIndex = 2;
            this.checkBox_Coke.Text = "可乐";
            this.checkBox_Coke.UseVisualStyleBackColor = true;
            // 
            // checkBox_Milk
            // 
            this.checkBox_Milk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Milk.AutoSize = true;
            this.checkBox_Milk.Location = new System.Drawing.Point(158, 142);
            this.checkBox_Milk.Name = "checkBox_Milk";
            this.checkBox_Milk.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Milk.TabIndex = 3;
            this.checkBox_Milk.Text = "牛奶";
            this.checkBox_Milk.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bread
            // 
            this.checkBox_Bread.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Bread.AutoSize = true;
            this.checkBox_Bread.Location = new System.Drawing.Point(158, 186);
            this.checkBox_Bread.Name = "checkBox_Bread";
            this.checkBox_Bread.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Bread.TabIndex = 4;
            this.checkBox_Bread.Text = "面包";
            this.checkBox_Bread.UseVisualStyleBackColor = true;
            // 
            // textBox_Apple
            // 
            this.textBox_Apple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Apple.Location = new System.Drawing.Point(224, 11);
            this.textBox_Apple.Name = "textBox_Apple";
            this.textBox_Apple.Size = new System.Drawing.Size(100, 21);
            this.textBox_Apple.TabIndex = 5;
            // 
            // textBox_Book
            // 
            this.textBox_Book.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Book.Location = new System.Drawing.Point(224, 54);
            this.textBox_Book.Name = "textBox_Book";
            this.textBox_Book.Size = new System.Drawing.Size(100, 21);
            this.textBox_Book.TabIndex = 6;
            // 
            // textBox_Coke
            // 
            this.textBox_Coke.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Coke.Location = new System.Drawing.Point(224, 97);
            this.textBox_Coke.Name = "textBox_Coke";
            this.textBox_Coke.Size = new System.Drawing.Size(100, 21);
            this.textBox_Coke.TabIndex = 7;
            // 
            // textBox_Milk
            // 
            this.textBox_Milk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Milk.Location = new System.Drawing.Point(224, 140);
            this.textBox_Milk.Name = "textBox_Milk";
            this.textBox_Milk.Size = new System.Drawing.Size(100, 21);
            this.textBox_Milk.TabIndex = 8;
            // 
            // textBox_Bread
            // 
            this.textBox_Bread.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Bread.Location = new System.Drawing.Point(224, 184);
            this.textBox_Bread.Name = "textBox_Bread";
            this.textBox_Bread.Size = new System.Drawing.Size(100, 21);
            this.textBox_Bread.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_Update, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 376);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 74);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Update.Location = new System.Drawing.Point(185, 25);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 0;
            this.button_Update.Text = "修改";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormUpdate";
            this.Text = "修改订单";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_orderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkBox_Apple;
        private System.Windows.Forms.CheckBox checkBox_Book;
        private System.Windows.Forms.CheckBox checkBox_Coke;
        private System.Windows.Forms.CheckBox checkBox_Milk;
        private System.Windows.Forms.CheckBox checkBox_Bread;
        private System.Windows.Forms.TextBox textBox_Apple;
        private System.Windows.Forms.TextBox textBox_Book;
        private System.Windows.Forms.TextBox textBox_Coke;
        private System.Windows.Forms.TextBox textBox_Milk;
        private System.Windows.Forms.TextBox textBox_Bread;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_Update;
    }
}