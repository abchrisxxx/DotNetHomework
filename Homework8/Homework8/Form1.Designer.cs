
namespace Homework8
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_QueryByID = new System.Windows.Forms.Label();
            this.label_QueryByName = new System.Windows.Forms.Label();
            this.label_DeleteOrder = new System.Windows.Forms.Label();
            this.button_QueryByID = new System.Windows.Forms.Button();
            this.button_QueryByName = new System.Windows.Forms.Button();
            this.button_DeleteOrder = new System.Windows.Forms.Button();
            this.textBox_QueryByID = new System.Windows.Forms.TextBox();
            this.textBox_QueryByName = new System.Windows.Forms.TextBox();
            this.textBox_DeleteOrder = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 275);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.orderCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceOrder;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(706, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button_AddOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Import, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Export, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddOrder.AutoSize = true;
            this.button_AddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_AddOrder.Location = new System.Drawing.Point(321, 16);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(63, 22);
            this.button_AddOrder.TabIndex = 0;
            this.button_AddOrder.Text = "添加订单";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // button_Import
            // 
            this.button_Import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Import.Location = new System.Drawing.Point(80, 16);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(75, 23);
            this.button_Import.TabIndex = 1;
            this.button_Import.Text = "导入订单";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Export.Location = new System.Drawing.Point(550, 16);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(75, 23);
            this.button_Export.TabIndex = 2;
            this.button_Export.Text = "导出订单";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_QueryByID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_QueryByName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_DeleteOrder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_QueryByID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_QueryByName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_DeleteOrder, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_QueryByID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_QueryByName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_DeleteOrder, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_QueryByID
            // 
            this.label_QueryByID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_QueryByID.AutoSize = true;
            this.label_QueryByID.Location = new System.Drawing.Point(131, 8);
            this.label_QueryByID.Name = "label_QueryByID";
            this.label_QueryByID.Size = new System.Drawing.Size(101, 12);
            this.label_QueryByID.TabIndex = 0;
            this.label_QueryByID.Text = "按订单号查询订单";
            // 
            // label_QueryByName
            // 
            this.label_QueryByName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_QueryByName.AutoSize = true;
            this.label_QueryByName.Location = new System.Drawing.Point(119, 36);
            this.label_QueryByName.Name = "label_QueryByName";
            this.label_QueryByName.Size = new System.Drawing.Size(113, 12);
            this.label_QueryByName.TabIndex = 1;
            this.label_QueryByName.Text = "按顾客姓名查询订单";
            // 
            // label_DeleteOrder
            // 
            this.label_DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_DeleteOrder.AutoSize = true;
            this.label_DeleteOrder.Location = new System.Drawing.Point(179, 64);
            this.label_DeleteOrder.Name = "label_DeleteOrder";
            this.label_DeleteOrder.Size = new System.Drawing.Size(53, 12);
            this.label_DeleteOrder.TabIndex = 2;
            this.label_DeleteOrder.Text = "删除订单";
            // 
            // button_QueryByID
            // 
            this.button_QueryByID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_QueryByID.AutoSize = true;
            this.button_QueryByID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_QueryByID.Location = new System.Drawing.Point(568, 3);
            this.button_QueryByID.Name = "button_QueryByID";
            this.button_QueryByID.Size = new System.Drawing.Size(39, 22);
            this.button_QueryByID.TabIndex = 3;
            this.button_QueryByID.Text = "查询";
            this.button_QueryByID.UseVisualStyleBackColor = true;
            this.button_QueryByID.Click += new System.EventHandler(this.button_QueryByID_Click);
            // 
            // button_QueryByName
            // 
            this.button_QueryByName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_QueryByName.AutoSize = true;
            this.button_QueryByName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_QueryByName.Location = new System.Drawing.Point(568, 31);
            this.button_QueryByName.Name = "button_QueryByName";
            this.button_QueryByName.Size = new System.Drawing.Size(39, 22);
            this.button_QueryByName.TabIndex = 4;
            this.button_QueryByName.Text = "查询";
            this.button_QueryByName.UseVisualStyleBackColor = true;
            this.button_QueryByName.Click += new System.EventHandler(this.button_QueryByName_Click);
            // 
            // button_DeleteOrder
            // 
            this.button_DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_DeleteOrder.AutoSize = true;
            this.button_DeleteOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_DeleteOrder.Location = new System.Drawing.Point(568, 59);
            this.button_DeleteOrder.Name = "button_DeleteOrder";
            this.button_DeleteOrder.Size = new System.Drawing.Size(39, 22);
            this.button_DeleteOrder.TabIndex = 5;
            this.button_DeleteOrder.Text = "删除";
            this.button_DeleteOrder.UseVisualStyleBackColor = true;
            this.button_DeleteOrder.Click += new System.EventHandler(this.button_DeleteOrder_Click);
            // 
            // textBox_QueryByID
            // 
            this.textBox_QueryByID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_QueryByID.Location = new System.Drawing.Point(258, 3);
            this.textBox_QueryByID.Name = "textBox_QueryByID";
            this.textBox_QueryByID.Size = new System.Drawing.Size(189, 21);
            this.textBox_QueryByID.TabIndex = 6;
            // 
            // textBox_QueryByName
            // 
            this.textBox_QueryByName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_QueryByName.Location = new System.Drawing.Point(258, 31);
            this.textBox_QueryByName.Name = "textBox_QueryByName";
            this.textBox_QueryByName.Size = new System.Drawing.Size(189, 21);
            this.textBox_QueryByName.TabIndex = 7;
            // 
            // textBox_DeleteOrder
            // 
            this.textBox_DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DeleteOrder.Location = new System.Drawing.Point(258, 59);
            this.textBox_DeleteOrder.Name = "textBox_DeleteOrder";
            this.textBox_DeleteOrder.Size = new System.Drawing.Size(189, 21);
            this.textBox_DeleteOrder.TabIndex = 8;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Refresh.Location = new System.Drawing.Point(321, 50);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "刷新订单";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Refresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 125);
            this.panel3.TabIndex = 2;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(OrderManagement.Order);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // orderCostDataGridViewTextBoxColumn
            // 
            this.orderCostDataGridViewTextBoxColumn.DataPropertyName = "OrderCost";
            this.orderCostDataGridViewTextBoxColumn.HeaderText = "OrderCost";
            this.orderCostDataGridViewTextBoxColumn.Name = "orderCostDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 414);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_QueryByID;
        private System.Windows.Forms.Label label_QueryByName;
        private System.Windows.Forms.Label label_DeleteOrder;
        private System.Windows.Forms.Button button_QueryByID;
        private System.Windows.Forms.Button button_QueryByName;
        private System.Windows.Forms.Button button_DeleteOrder;
        private System.Windows.Forms.TextBox textBox_QueryByID;
        private System.Windows.Forms.TextBox textBox_QueryByName;
        private System.Windows.Forms.TextBox textBox_DeleteOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCostDataGridViewTextBoxColumn;
    }
}

