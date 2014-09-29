using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_Talk_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if ((TypeComboBox.Text == "prepaid") && (operatorComboBox.Text =="BL"))
            {
                int blPostTalktime = Convert.ToInt32(balanceTextBox.Text)*2;
                string min = Convert.ToString(blPostTalktime);
                showTalkTimeabel.Text = "He or she can talk about"+min +" "+ "min";
            }
            else if ((TypeComboBox.Text == "postpaid") && (operatorComboBox.Text == "BL"))
            {
                int blPostTalktime = (Convert.ToInt32(balanceTextBox.Text)+20) * 2;
                string min = Convert.ToString(blPostTalktime);
                showTalkTimeabel.Text = "He or she can talk about" + min + " " + "min";
            }

            else if((TypeComboBox.Text=="prepaid")&& (operatorComboBox.Text=="GP"))
            {
                int balanceofTalkTime = Convert.ToInt32(balanceTextBox.Text)*3;
                string min = Convert.ToString(balanceofTalkTime);
                showTalkTimeabel.Text = "Coustomer talk about" + " " + min + "minutes";
            }

            else if ((TypeComboBox.Text == "postpaid") && (operatorComboBox.Text == "GP"))
            {
                int balanceofTalkTime = (Convert.ToInt32(balanceTextBox.Text) + 40)*2;
                string min = Convert.ToString(balanceofTalkTime);
                showTalkTimeabel.Text = "Coustomer talk about" + " " + min + "minuts";
            }
        }
    }
}
