namespace SmallBusinessManagementSystem.UI
{
    partial class SaleRepotingUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleRepotingUI));
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.crossButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesearchButton = new System.Windows.Forms.Button();
            this.saleRepotingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleRepotingModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.CustomFormat = " ";
            this.enddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddateTimePicker.Location = new System.Drawing.Point(416, 143);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.enddateTimePicker.TabIndex = 41;
            this.enddateTimePicker.ValueChanged += new System.EventHandler(this.enddateTimePicker_ValueChanged);
            this.enddateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enddateTimePicker_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(702, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(88, 34);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(28, 35);
            this.nextButton.TabIndex = 9;
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // crossButton
            // 
            this.crossButton.Image = ((System.Drawing.Image)(resources.GetObject("crossButton.Image")));
            this.crossButton.Location = new System.Drawing.Point(169, 34);
            this.crossButton.Name = "crossButton";
            this.crossButton.Size = new System.Drawing.Size(27, 35);
            this.crossButton.TabIndex = 8;
            this.crossButton.UseVisualStyleBackColor = true;
            this.crossButton.Click += new System.EventHandler(this.crossButton_Click);
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
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(347, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodic Income Expense Report on Purchase";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = " ";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(104, 142);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.startDateTimePicker.TabIndex = 40;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            this.startDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startDateTimePicker_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(2, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 32);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Start date";
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToDeleteRows = false;
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.showDataGridView.DataSource = this.saleRepotingModelBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(12, 184);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.Size = new System.Drawing.Size(766, 206);
            this.showDataGridView.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "end date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.crossButton);
            this.groupBox1.Controls.Add(this.homeButton);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 103);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // datesearchButton
            // 
            this.datesearchButton.Image = ((System.Drawing.Image)(resources.GetObject("datesearchButton.Image")));
            this.datesearchButton.Location = new System.Drawing.Point(704, 136);
            this.datesearchButton.Name = "datesearchButton";
            this.datesearchButton.Size = new System.Drawing.Size(45, 36);
            this.datesearchButton.TabIndex = 42;
            this.datesearchButton.UseVisualStyleBackColor = true;
            this.datesearchButton.Click += new System.EventHandler(this.datesearchButton_Click);
            // 
            // saleRepotingModelBindingSource
            // 
            this.saleRepotingModelBindingSource.DataSource = typeof(SmallBusinessManagementSystem.Model.SaleRepotingModel);
            // 
            // SaleRepotingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datesearchButton);
            this.Controls.Add(this.enddateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleRepotingUI";
            this.Text = "SaleRepotingUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleRepotingUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleRepotingModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker enddateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button crossButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button datesearchButton;
        private System.Windows.Forms.BindingSource saleRepotingModelBindingSource;
    }
}