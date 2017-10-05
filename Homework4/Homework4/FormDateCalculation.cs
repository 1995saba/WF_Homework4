using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class FormDateCalculation : Form
    {
        public FormDateCalculation()
        {
            InitializeComponent();
        }

        private TimeSpan Difference()
        {
            DateTime target;
            bool result = DateTime.TryParse(textBoxDate.Text, out target);
            if (result == false)
            {
                labelResult.Text = null;
            }
            TimeSpan difference = target - DateTime.Now;

            return difference;
        }

        private void RadioButtonYears_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                int daysInYear = 365;
                double totalYears = Difference().TotalDays / daysInYear;
                labelResult.Text = (Difference().TotalDays / daysInYear).ToString();
            }
        }

        private void RadioButtonMonths_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                int daysInMonth = 30;
                double totalYears = Difference().TotalDays / daysInMonth;
                labelResult.Text = (Difference().TotalDays / daysInMonth).ToString();
            }
        }

        private void RadioButtonDays_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                double totalYears = Difference().TotalDays;
                labelResult.Text = Difference().TotalDays.ToString();
            }
        }

        private void RadioButtonMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                double totalYears = Difference().TotalMinutes;
                labelResult.Text = Difference().TotalMinutes.ToString();
            }
        }

        private void RadioButtonSeconds_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                double totalYears = Difference().TotalSeconds;
                labelResult.Text = Difference().TotalSeconds.ToString();
            }
        }
    }
}
