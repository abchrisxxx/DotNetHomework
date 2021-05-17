
namespace Homework11
{
    partial class FormAdd
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_orderId = new System.Windows.Forms.TextBox();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_newOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_orderId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_customer, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 92);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "订单号：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "顾客姓名：";
            // 
            // textBox_orderId
            // 
            this.textBox_orderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_orderId.Location = new System.Drawing.Point(220, 12);
            this.textBox_orderId.Name = "textBox_orderId";
            this.textBox_orderId.Size = new System.Drawing.Size(100, 21);
            this.textBox_orderId.TabIndex = 2;
            // 
            // textBox_customer
            // 
            this.textBox_customer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_customer.Location = new System.Drawing.Point(220, 58);
            this.textBox_customer.Name = "textBox_customer";
            this.textBox_customer.Size = new System.Drawing.Size(100, 21);
            this.textBox_customer.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_newOrder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(435, 48);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button_newOrder
            // 
            this.button_newOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_newOrder.Location = new System.Drawing.Point(180, 12);
            this.button_newOrder.Name = "button_newOrder";
            this.button_newOrder.Size = new System.Drawing.Size(75, 23);
            this.button_newOrder.TabIndex = 0;
            this.button_newOrder.Text = "添加";
            this.button_newOrder.UseVisualStyleBackColor = true;
            this.button_newOrder.Click += new System.EventHandler(this.button_newOrder_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(435, 41);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择商品";
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
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 133);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(435, 217);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // checkBox_Apple
            // 
            this.checkBox_Apple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Apple.AutoSize = true;
            this.checkBox_Apple.Location = new System.Drawing.Point(155, 13);
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
            this.checkBox_Book.Location = new System.Drawing.Point(155, 56);
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
            this.checkBox_Coke.Location = new System.Drawing.Point(155, 99);
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
            this.checkBox_Milk.Location = new System.Drawing.Point(155, 142);
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
            this.checkBox_Bread.Location = new System.Drawing.Point(155, 186);
            this.checkBox_Bread.Name = "checkBox_Bread";
            this.checkBox_Bread.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Bread.TabIndex = 4;
            this.checkBox_Bread.Text = "面包";
            this.checkBox_Bread.UseVisualStyleBackColor = true;
            // 
            // textBox_Apple
            // 
            this.textBox_Apple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Apple.Location = new System.Drawing.Point(220, 11);
            this.textBox_Apple.Name = "textBox_Apple";
            this.textBox_Apple.Size = new System.Drawing.Size(100, 21);
            this.textBox_Apple.TabIndex = 5;
            // 
            // textBox_Book
            // 
            this.textBox_Book.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Book.Location = new System.Drawing.Point(220, 54);
            this.textBox_Book.Name = "textBox_Book";
            this.textBox_Book.Size = new System.Drawing.Size(100, 21);
            this.textBox_Book.TabIndex = 6;
            // 
            // textBox_Coke
            // 
            this.textBox_Coke.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Coke.Location = new System.Drawing.Point(220, 97);
            this.textBox_Coke.Name = "textBox_Coke";
            this.textBox_Coke.Size = new System.Drawing.Size(100, 21);
            this.textBox_Coke.TabIndex = 7;
            // 
            // textBox_Milk
            // 
            this.textBox_Milk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Milk.Location = new System.Drawing.Point(220, 140);
            this.textBox_Milk.Name = "textBox_Milk";
            this.textBox_Milk.Size = new System.Drawing.Size(100, 21);
            this.textBox_Milk.TabIndex = 8;
            // 
            // textBox_Bread
            // 
            this.textBox_Bread.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Bread.Location = new System.Drawing.Point(220, 184);
            this.textBox_Bread.Name = "textBox_Bread";
            this.textBox_Bread.Size = new System.Drawing.Size(100, 21);
            this.textBox_Bread.TabIndex = 9;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 398);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormAdd";
            this.Text = "添加订单";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_orderId;
        private System.Windows.Forms.TextBox textBox_customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_newOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
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
    }
}