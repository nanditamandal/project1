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
    public partial class SaleRepotingUI : Form
    {
        public SaleRepotingUI()
        {
            InitializeComponent();
        }

        private void Srarch_Click(object sender, EventArgs e)
        {

        }

        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void SaleRepotingUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            PurchaseRepotingUI newForm = new PurchaseRepotingUI();
            newForm.Show();
            this.Hide();
        }

        private void enddateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat = " ";

            }
        }

        private void startDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                startDateTimePicker.CustomFormat = " ";

            }
        }

        private void enddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            enddateTimePicker.CustomFormat = "yyyy / MM / dd";
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            enddateTimePicker.CustomFormat = "yyyy / MM / dd";
        }
        SaleRepotingManager _saleRepotingManager = new SaleRepotingManager();

        private void datesearchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            SaleRepotingModel salerepotingModel = new SaleRepotingModel();

            if (startDateTimePicker.Text == " " && startDateTimePicker.Text == " ")
            {
                MessageBox.Show("please insert date");
                return;

            }
            salerepotingModel.Date = startDateTimePicker.Text;
            salerepotingModel.Date2 = enddateTimePicker.Text;
            // List<PurchaseRepotingModel> purchaseRepotingModels = new List<PurchaseRepotingModel>();
            // purchaseRepotingModels = _purchaseRepotingManager.SearchValue(purchaserepotingModel);
            bool ishas = !_saleRepotingManager.SearchValue(salerepotingModel).Any();
            if (ishas)
            {
                MessageBox.Show("no data");
                return;
            }
            else
            {
                showDataGridView.DataSource = _saleRepotingManager.SearchValue(salerepotingModel);
            }
        }
    }
}
