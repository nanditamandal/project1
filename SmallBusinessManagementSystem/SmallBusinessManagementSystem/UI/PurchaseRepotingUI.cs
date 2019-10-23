using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Manager;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.UI
{
    public partial class PurchaseRepotingUI : Form
    {
        public PurchaseRepotingUI()
        {
            InitializeComponent();
        }
        PurchaseRepotingManager _purchaseRepotingManager =new PurchaseRepotingManager();

        private void Srarch_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            PurchaseRepotingModel purchaserepotingModel = new PurchaseRepotingModel();

            if (startDateTimePicker.Text == " " && startDateTimePicker.Text == " ")
            {
                MessageBox.Show("please insert date");
                return;

            }
            purchaserepotingModel.Date = startDateTimePicker.Text;
            purchaserepotingModel.Date2 = endDateTimePicker.Text;
            // List<PurchaseRepotingModel> purchaseRepotingModels = new List<PurchaseRepotingModel>();
            // purchaseRepotingModels = _purchaseRepotingManager.SearchValue(purchaserepotingModel);
            bool ishas = !_purchaseRepotingManager.SearchValue(purchaserepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showDataGridView.DataSource = _purchaseRepotingManager.SearchValue(purchaserepotingModel);
            }
        }

            
            
            


        

        private void next_Click(object sender, EventArgs e)
        {
            SaleRepotingUI newForm = new SaleRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTimePicker.CustomFormat = "yyyy / MM / dd";
        }

        private void startDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode== Keys.Back) || (e.KeyCode==Keys.Delete))
            {
                startDateTimePicker.CustomFormat = " ";

            }
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.CustomFormat = "yyyy / MM / dd";
        }

        private void endDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat = " ";

            }
        }
    }
}
