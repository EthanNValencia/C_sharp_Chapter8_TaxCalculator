using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * How to create this app
 * 
 * 1. Drag and drop all the controls in the Form1.cs
 * 2. Size and rename all controls.
 * 3. For the button, go to properties, events tab, and double click "click"
 * 4. btCompute_Click() is auto generated as an event method. 
 * 
 */
namespace Chapter8_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt;
            inValue = txtPurchase.Text;
            purchaseAmt = double.Parse(inValue);

            // pg 442
            double percent; 
            inValue = label5.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1); // This removes the last char, which is %.
            percent = double.Parse(inValue) / 100; // Converts the percent to a decimal. 

            // pg 442 (this is a different way of writing the above 2 lines), a little more confusing, but more compact. 
            percent = (double.Parse(label5.Text.Remove(label5.Text.Length - 1, 1))) / 100;

            // pg 442
            double ans;
            ans = (purchaseAmt * percent) + purchaseAmt;
            txtTotalDue.Text = String.Format("{0:C}", ans).ToString(); // Formats the number to a currency. 
        }
    }
}
