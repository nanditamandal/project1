﻿namespace SmallBusinessManagementSystem.UI
{
    partial class PurchaseUI
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
            this.supplierGroupBox = new System.Windows.Forms.GroupBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priviousUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.manufactureDateTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.expireDateTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.remarksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.supplierGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.Controls.Add(this.invoiceNoTextBox);
            this.supplierGroupBox.Controls.Add(this.dateDateTimePicker);
            this.supplierGroupBox.Controls.Add(this.label3);
            this.supplierGroupBox.Controls.Add(this.supplierComboBox);
            this.supplierGroupBox.Controls.Add(this.dateLabel);
            this.supplierGroupBox.Controls.Add(this.label1);
            this.supplierGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierGroupBox.Location = new System.Drawing.Point(336, 3);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Size = new System.Drawing.Size(439, 147);
            this.supplierGroupBox.TabIndex = 0;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(176, 101);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(187, 32);
            this.supplierComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice No";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(176, 28);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(187, 29);
            this.dateDateTimePicker.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 24);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier";
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.Location = new System.Drawing.Point(176, 63);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.ReadOnly = true;
            this.invoiceNoTextBox.Size = new System.Drawing.Size(187, 29);
            this.invoiceNoTextBox.TabIndex = 1;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.button4);
            this.productGroupBox.Controls.Add(this.addButton);
            this.productGroupBox.Controls.Add(this.remarksRichTextBox);
            this.productGroupBox.Controls.Add(this.previousMrpTextBox);
            this.productGroupBox.Controls.Add(this.label2);
            this.productGroupBox.Controls.Add(this.priviousUnitPriceTextBox);
            this.productGroupBox.Controls.Add(this.label14);
            this.productGroupBox.Controls.Add(this.unitPriceTextBox);
            this.productGroupBox.Controls.Add(this.label17);
            this.productGroupBox.Controls.Add(this.mrpTextBox);
            this.productGroupBox.Controls.Add(this.label18);
            this.productGroupBox.Controls.Add(this.quantityTextBox);
            this.productGroupBox.Controls.Add(this.label15);
            this.productGroupBox.Controls.Add(this.totalPriceTextBox);
            this.productGroupBox.Controls.Add(this.label16);
            this.productGroupBox.Controls.Add(this.expireDateTextBox);
            this.productGroupBox.Controls.Add(this.label7);
            this.productGroupBox.Controls.Add(this.label21);
            this.productGroupBox.Controls.Add(this.manufactureDateTextBox);
            this.productGroupBox.Controls.Add(this.label20);
            this.productGroupBox.Controls.Add(this.codeTextBox);
            this.productGroupBox.Controls.Add(this.label19);
            this.productGroupBox.Controls.Add(this.availableQuantityTextBox);
            this.productGroupBox.Controls.Add(this.label4);
            this.productGroupBox.Controls.Add(this.label5);
            this.productGroupBox.Controls.Add(this.label6);
            this.productGroupBox.Controls.Add(this.productComboBox);
            this.productGroupBox.Controls.Add(this.categoryComboBox);
            this.productGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGroupBox.Location = new System.Drawing.Point(88, 142);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(931, 435);
            this.productGroupBox.TabIndex = 2;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(204, 146);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.ReadOnly = true;
            this.availableQuantityTextBox.Size = new System.Drawing.Size(187, 29);
            this.availableQuantityTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(204, 35);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(187, 32);
            this.categoryComboBox.TabIndex = 0;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(204, 73);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(187, 32);
            this.productComboBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Location = new System.Drawing.Point(107, 602);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(912, 193);
            this.purchaseDataGridView.TabIndex = 11;
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Location = new System.Drawing.Point(731, 162);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.ReadOnly = true;
            this.previousMrpTextBox.Size = new System.Drawing.Size(187, 29);
            this.previousMrpTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Previous MRP (Tk)";
            // 
            // priviousUnitPriceTextBox
            // 
            this.priviousUnitPriceTextBox.Location = new System.Drawing.Point(731, 127);
            this.priviousUnitPriceTextBox.Name = "priviousUnitPriceTextBox";
            this.priviousUnitPriceTextBox.ReadOnly = true;
            this.priviousUnitPriceTextBox.Size = new System.Drawing.Size(187, 29);
            this.priviousUnitPriceTextBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(511, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "Previous Unit Price (Tk)";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(731, 22);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(187, 29);
            this.quantityTextBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = "Quantity";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(731, 92);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(187, 29);
            this.totalPriceTextBox.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 24);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total Price (Tk)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 24);
            this.label19.TabIndex = 1;
            this.label19.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(204, 111);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(187, 29);
            this.codeTextBox.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 24);
            this.label20.TabIndex = 1;
            this.label20.Text = "Manufacture Date";
            // 
            // manufactureDateTextBox
            // 
            this.manufactureDateTextBox.Location = new System.Drawing.Point(204, 181);
            this.manufactureDateTextBox.Name = "manufactureDateTextBox";
            this.manufactureDateTextBox.Size = new System.Drawing.Size(187, 29);
            this.manufactureDateTextBox.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 24);
            this.label21.TabIndex = 1;
            this.label21.Text = "Expire Date";
            // 
            // expireDateTextBox
            // 
            this.expireDateTextBox.Location = new System.Drawing.Point(204, 216);
            this.expireDateTextBox.Name = "expireDateTextBox";
            this.expireDateTextBox.Size = new System.Drawing.Size(187, 29);
            this.expireDateTextBox.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(511, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 24);
            this.label17.TabIndex = 18;
            this.label17.Text = "Unit Price (Tk)";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(731, 57);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(187, 29);
            this.unitPriceTextBox.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(511, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 24);
            this.label18.TabIndex = 18;
            this.label18.Text = "MRP (Tk)";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(731, 197);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(187, 29);
            this.mrpTextBox.TabIndex = 17;
            // 
            // remarksRichTextBox
            // 
            this.remarksRichTextBox.Location = new System.Drawing.Point(204, 271);
            this.remarksRichTextBox.Name = "remarksRichTextBox";
            this.remarksRichTextBox.Size = new System.Drawing.Size(714, 96);
            this.remarksRichTextBox.TabIndex = 21;
            this.remarksRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Remarks";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(823, 373);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 42);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(911, 801);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(95, 42);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 659);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 42);
            this.button4.TabIndex = 22;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 881);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.supplierGroupBox);
            this.Name = "Purchase";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.supplierGroupBox.ResumeLayout(false);
            this.supplierGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priviousUnitPriceTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox remarksRichTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox expireDateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox manufactureDateTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button submitButton;
    }
}