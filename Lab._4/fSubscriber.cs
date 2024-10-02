using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._4
{
    public partial class fSubscriber : Form
    {

        internal Subscriber TheSubscriber;

        internal fSubscriber(Subscriber s)
        {
            TheSubscriber = s;
            InitializeComponent();
        }

        private void fSubscriber_Load(object sender, EventArgs e)
        {
            tbName.Text = TheSubscriber.Name;
            tbPhoneNumber.Text = TheSubscriber.PhoneNumber;
            tbAddress.Text = TheSubscriber.Address;
            tbSMSPerMonth.Text = TheSubscriber.CallMinutesPerMonth.ToString();
            tbCallMinutes.Text = TheSubscriber.SMSPerMonth.ToString();
            tbMonthlyFee.Text = TheSubscriber.MonthlyFee.ToString();

            chbHasDataPlan.Checked = TheSubscriber.HasDataPlan;
            chbHasRoaming.Checked = TheSubscriber.HasRoaming;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            TheSubscriber.Name = tbName.Text;
            TheSubscriber.PhoneNumber = tbPhoneNumber.Text;
            TheSubscriber.Address = tbAddress.Text;
            TheSubscriber.CallMinutesPerMonth = Convert.ToInt32(tbSMSPerMonth.Text);
            TheSubscriber.SMSPerMonth = Convert.ToInt32(tbCallMinutes.Text);
            TheSubscriber.MonthlyFee = (double)Convert.ToDecimal(tbMonthlyFee.Text);

            TheSubscriber.HasRoaming = chbHasRoaming.Checked;
            TheSubscriber.HasDataPlan = chbHasDataPlan.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbCallMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSMSPerMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbHasDataPlan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                !int.TryParse(tbSMSPerMonth.Text, out var smsPerMonth) ||
                !int.TryParse(tbCallMinutes.Text, out var callMinutes) ||
                !double.TryParse(tbMonthlyFee.Text, out var monthlyFee))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно.");
                return;
            }

            TheSubscriber.Name = tbName.Text;
            TheSubscriber.PhoneNumber = tbPhoneNumber.Text;
            TheSubscriber.Address = tbAddress.Text;
            TheSubscriber.CallMinutesPerMonth = smsPerMonth;
            TheSubscriber.SMSPerMonth = callMinutes;
            TheSubscriber.MonthlyFee = monthlyFee;

            TheSubscriber.HasRoaming = chbHasRoaming.Checked;
            TheSubscriber.HasDataPlan = chbHasDataPlan.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void chbHasRoaming_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}