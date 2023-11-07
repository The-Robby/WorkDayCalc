using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkDayCalc
{
    public partial class Form1 : Form
    {
        class Global
        {
            public static string s_txtStartHour, s_txtEndHour, s_txtDayHours, s_txtLunchTime /*s_Converted*/;
            public static double d_txtStartHour, d_txtEndHour, d_txtDayHours, d_txtLunchTime /*d_Converted*/, d_ConvertedDecimals;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEndHour.Clear();
            if (string.IsNullOrEmpty(txtStartHour.Text))
            {
                txtStartHour.SelectedText = "8:00";
            }

            Global.s_txtDayHours = txtDayHours.Text.ToString();
            Global.s_txtLunchTime = txtLunchTime.Text.ToString();
            Global.s_txtStartHour = txtStartHour.Text.ToString();
            try
            {
                Global.d_txtStartHour = MinutesToDecimal(Global.s_txtStartHour);
                Global.d_txtDayHours = MinutesToDecimal(Global.s_txtDayHours);
                Global.d_txtLunchTime = MinutesToDecimal(Global.s_txtLunchTime);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the format(HH:MM). H stands for hours and M for minutes.\nAlso it must have a ':' and not a '.'");
            }

            try
            {
            if (checkPaidLunch.Checked && checkHalfDay.Checked)
            {
                Global.d_txtEndHour = Global.d_txtStartHour + (Global.d_txtDayHours/2);
            }else if (checkPaidLunch.Checked)
            {
                Global.d_txtEndHour = Global.d_txtStartHour + Global.d_txtDayHours;
            }else if (checkHalfDay.Checked)
            {
                Global.d_txtEndHour = Global.d_txtStartHour + (Global.d_txtDayHours/2) + Global.d_txtLunchTime;
            }else
            {
                Global.d_txtEndHour = Global.d_txtStartHour + Global.d_txtDayHours + Global.d_txtLunchTime;
            }

            Global.s_txtEndHour = DecimalToMinutes(Global.d_txtEndHour);
            //Global.s_txtEndHour = Convert.ToString(Global.d_txtEndHour);
            txtEndHour.SelectedText += Global.s_txtEndHour;
            Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please check that you have the right format(HH:MM).\nIt must include a ':' and not a '.' or something else.");
            }
            
        }

        private void txtStartHour_TextChanged(object sender, EventArgs e)
        {


            Global.s_txtStartHour = txtStartHour.Text.ToString();
            //Global.d_txtStartHour = Convert.ToDouble(Global.s_txtStartHour);
        }
        private void txtEndHour_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtEndHour.Text))
            //{
            //    txtEndHour.SelectedText = "0";
            //}
        }
        public String DecimalToMinutes(double d_ToConvert) 
        {
            TimeSpan t_ToConvert = TimeSpan.FromHours(d_ToConvert);
            //Global.s_Converted = Convert.ToString(t_ToConvert);

            //return Global.s_Converted;
            return t_ToConvert.Hours.ToString("00") + ":" + t_ToConvert.Minutes.ToString("00");
        }
        public double MinutesToDecimal(string s_ToConvert)
        {

                Global.d_ConvertedDecimals = Convert.ToDouble(TimeSpan.Parse(s_ToConvert).TotalHours);

                return Global.d_ConvertedDecimals;
  
        }
        private void txtDayHours_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DayHours = txtDayHours.Text.ToString();
            
            if (string.IsNullOrEmpty(txtDayHours.Text))
            {
                txtDayHours.SelectedText = "00";
            }

            Global.s_txtDayHours = txtDayHours.Text.ToString();
        }
        private void txtLunchTime_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LunchTime = txtLunchTime.Text.ToString();

            if (string.IsNullOrEmpty(txtLunchTime.Text))
            {
                txtLunchTime.SelectedText = "00";
            }

            Global.s_txtLunchTime = txtLunchTime.Text.ToString();
        }
        private void checkPaidLunch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}
