using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_Checker
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            dateTimePicker_to.MinDate = dateTimePicker_from.Value;
            dateTimePicker_from.MaxDate = dateTimePicker_to.Value;
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_to.MinDate = dateTimePicker_from.Value;
            label_dayCount.Text = CountDaysOfWeekInRange(dateTimePicker_from.Value.Date, dateTimePicker_from.Value.Date, DayOfWeek.Monday).ToString();
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_from.MaxDate = dateTimePicker_to.Value;
            label_dayCount.Text = CountDaysOfWeekInRange(dateTimePicker_from.Value.Date, dateTimePicker_from.Value.Date, DayOfWeek.Monday).ToString();
        }

        public static int CountDaysOfWeekInRange(DateTime startDate, DateTime endDate, DayOfWeek dayOfWeek)
        {
            int count = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
