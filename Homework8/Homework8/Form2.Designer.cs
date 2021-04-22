
namespace Homework8
{
    partial class Form2
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
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_customerName = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_OrderCost = new System.Windows.Forms.Label();
            this.textBox_OrderID = new System.Windows.Forms.TextBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_TotalCost = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_msg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_OrderID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_customerName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_ProductName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderCost, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_OrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_CustomerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ProductName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_TotalCost, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_OrderID
            // 
            this.label_OrderID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Location = new System.Drawing.Point(112, 7);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(65, 12);
            this.label_OrderID.TabIndex = 0;
            this.label_OrderID.Text = "Order ID: ";
            // 
            // label_customerName
            // 
            this.label_customerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(82, 34);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(95, 12);
            this.label_customerName.TabIndex = 1;
            this.label_customerName.Text = "Customer Name: ";
            // 
            // label_ProductName
            // 
            this.label_ProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(88, 61);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(89, 12);
            this.label_ProductName.TabIndex = 2;
            this.label_ProductName.Text = "Product Name: ";
            // 
            // label_OrderCost
            // 
            this.label_OrderCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_OrderCost.AutoSize = true;
            this.label_OrderCost.Location = new System.Drawing.Point(100, 88);
            this.label_OrderCost.Name = "label_OrderCost";
            this.label_OrderCost.Size = new System.Drawing.Size(77, 12);
            this.label_OrderCost.TabIndex = 3;
            this.label_OrderCost.Text = "Total Cost: ";
            // 
            // textBox_OrderID
            // 
            this.textBox_OrderID.Location = new System.Drawing.Point(183, 3);
            this.textBox_OrderID.Name = "textBox_OrderID";
            this.textBox_OrderID.Size = new System.Drawing.Size(145, 21);
            this.textBox_OrderID.TabIndex = 4;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_CustomerName.Location = new System.Drawing.Point(183, 30);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(145, 21);
            this.textBox_CustomerName.TabIndex = 5;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_ProductName.Location = new System.Drawing.Point(183, 57);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(145, 21);
            this.textBox_ProductName.TabIndex = 6;
            // 
            // textBox_TotalCost
            // 
            this.textBox_TotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_TotalCost.Location = new System.Drawing.Point(183, 84);
            this.textBox_TotalCost.Name = "textBox_TotalCost";
            this.textBox_TotalCost.Size = new System.Drawing.Size(145, 21);
            this.textBox_TotalCost.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button_AddOrder, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 31);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddOrder.Location = new System.Drawing.Point(147, 3);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(66, 25);
            this.button_AddOrder.TabIndex = 2;
            this.button_AddOrder.Text = "确定";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_msg);
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 35);
            this.panel1.TabIndex = 2;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Message.Location = new System.Drawing.Point(0, 0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 12);
            this.label_Message.TabIndex = 0;
            // 
            // label_msg
            // 
            this.label_msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(162, 12);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(0, 12);
            this.label_msg.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_OrderCost;
        private System.Windows.Forms.TextBox textBox_OrderID;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_TotalCost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_msg;
    }
}