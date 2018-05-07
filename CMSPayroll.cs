using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormPayRoll : Form
    {
        public FormPayRoll()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblEmpName_Click(object sender, EventArgs e)
        {

        }

        private void BtnSumbit_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal RegularRate = 15M;
            decimal OTRate = 22.50M;
            decimal RegularHours;
            decimal OTHours;
            decimal TotalHours;
            decimal RegularPay;
            decimal OTPay;
            decimal grossPay;

            // validate that there are no errors
            bool valitdateResults = validatedata();
            if (valitdateResults == false)
            {

                return;
            }
            else
            {
                GrpBoxResults.Show();
            }



           //list for day off checkboxs
            List<CheckBox> cb = new List<CheckBox>();
            
            cb.Add(CbMon);
            cb.Add(CbTues);
            cb.Add(CbWed);
            cb.Add(CbThurs);
            cb.Add(CbFri);
            cb.Add(CbSat);
            cb.Add(CbSun);
            


            // Var for total hours. Days of the week added up
            TotalHours = NumUpDownMonday.Value + NumUpDownTuesday.Value + NumUpDownWednesday.Value + NumUpDownThursday.Value + NumUpDownFriday.Value
                + NumUpDownSaturday.Value + NumUpDownSunday.Value;



            // if hours are greater than 40 calculate overtime
            if (TotalHours > 40)
            {
                // math for regular/OT hours and pay
                OTHours = TotalHours - 40;

                RegularHours = TotalHours - OTHours;

                RegularPay = RegularHours  * RegularRate;

                OTPay = OTHours * OTRate;

                grossPay = RegularPay + OTPay;

                //Display results
                TxtRegHours.Text = RegularHours.ToString("");

                TxtRegRate.Text = RegularRate.ToString("c");

                TxtRegPay.Text = RegularPay.ToString("c");

                TxtOTHours.Text = OTHours.ToString("");

                TxtOTRate.Text = OTRate.ToString("c");

                TxtOTPay.Text = OTPay.ToString("");

                TxtTotalHours.Text = TotalHours.ToString("");

                TxtGrossPay.Text = grossPay.ToString("c");

            }
            // if totalHours is less than 40 calculate Regular pay without OT
            else
            {
                //Math for pay
                RegularPay = TotalHours * RegularRate;

                grossPay = TotalHours * RegularRate;

                //Display output
                TxtRegHours.Text = TotalHours.ToString("");

                TxtRegRate.Text = RegularRate.ToString("c");

                TxtRegPay.Text = RegularPay.ToString("c");

                TxtTotalHours.Text = TotalHours.ToString("");

                TxtGrossPay.Text = grossPay.ToString("c");
            }

            // loop to check how many checkboxes are checked
            var checkCbCount = cb.Where(s => s.Checked == true).Count();
            //display results
            TxtOffDays.Text = checkCbCount.ToString("");

        }

        //Error check method
        private bool validatedata()
        {
            // if statements to check for emtpy textboxes
            if (txtClientName.Text == "")
            {
                MessageBox.Show("Please enter Client Name");
                return false;
            }
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("Please enter Employee Name");
                return false;
            }
            if (TxtSuppName.Text == "")
            {
                MessageBox.Show("Please enter Suppervisor's Name");
                return false;
            }
            if (comboContract.Text == "")
            {
                MessageBox.Show("Please enter Contract Type");
                return false;
            }
            if (comboProject.Text == "")
            {
                MessageBox.Show("Please enter Project Name");
                return false;
            }
            if (NumUpDownWeeksWorked.Value <= 0)
            {
                MessageBox.Show("Please enter weeks worked");
                return false;
            }
        
            if (TxtTotal.Text == "" )
            {
                MessageBox.Show("Please enter total hours Name");
                return false;
            }





            // if no errors
            return true;
        }



        private void CheckMonday_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
