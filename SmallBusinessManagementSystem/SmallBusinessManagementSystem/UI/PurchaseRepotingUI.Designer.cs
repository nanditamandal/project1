namespace SmallBusinessManagementSystem.UI
{
    partial class PurchaseRepotingUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseRepotingUI));
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.srarchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchlogoButton = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRepotingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRepotingModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = " ";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(104, 142);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.startDateTimePicker.TabIndex = 32;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            this.startDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startDateTimePicker_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodic Income Expense Report on Purchase";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(2, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 32);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // srarchButton
            // 
            this.srarchButton.Location = new System.Drawing.Point(703, 143);
            this.srarchButton.Name = "srarchButton";
            this.srarchButton.Size = new System.Drawing.Size(75, 20);
            this.srarchButton.TabIndex = 29;
            this.srarchButton.Text = "Serach";
            this.srarchButton.UseVisualStyleBackColor = true;
            this.srarchButton.Click += new System.EventHandler(this.Srarch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Start date";
            // 
            // searchlogoButton
            // 
            this.searchlogoButton.Image = ((System.Drawing.Image)(resources.GetObject("searchlogoButton.Image")));
            this.searchlogoButton.Location = new System.Drawing.Point(702, 33);
            this.searchlogoButton.Name = "searchlogoButton";
            this.searchlogoButton.Size = new System.Drawing.Size(45, 36);
            this.searchlogoButton.TabIndex = 10;
            this.searchlogoButton.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(88, 34);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 35);
            this.next.TabIndex = 9;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // offButton
            // 
            this.offButton.Image = ((System.Drawing.Image)(resources.GetObject("offButton.Image")));
            this.offButton.Location = new System.Drawing.Point(169, 34);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(27, 35);
            this.offButton.TabIndex = 8;
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(250, 34);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(43, 35);
            this.homeButton.TabIndex = 7;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(7, 33);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(37, 36);
            this.previousButton.TabIndex = 6;
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(347, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "end date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.searchlogoButton);
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.offButton);
            this.groupBox1.Controls.Add(this.homeButton);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 103);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToDeleteRows = false;
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.date2DataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.purchaseRepotingModelBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(9, 204);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.Size = new System.Drawing.Size(769, 164);
            this.showDataGridView.TabIndex = 23;
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            this.cPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            this.profitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // date2DataGridViewTextBoxColumn
            // 
            this.date2DataGridViewTextBoxColumn.DataPropertyName = "Date2";
            this.date2DataGridViewTextBoxColumn.HeaderText = "Date2";
            this.date2DataGridViewTextBoxColumn.Name = "date2DataGridViewTextBoxColumn";
            this.date2DataGridViewTextBoxColumn.ReadOnly = true;
            this.date2DataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseRepotingModelBindingSource
            // 
            this.purchaseRepotingModelBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.PurchaseRepotingModel);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = " ";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(416, 143);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.endDateTimePicker.TabIndex = 33;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            this.endDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.endDateTimePicker_KeyDown);
            // 
            // PurchaseRepotingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.srarchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showDataGridView);
            this.Name = "PurchaseRepotingUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRepotingModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button srarchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchlogoButton;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseRepotingModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2DataGridViewTextBoxColumn;
    }
}