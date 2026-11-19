using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesSalesTrackingApplication
{
    public partial class Form1 : Form
    {
        private double DanielleTotal = 0;
        private double EdwardTotal = 0;
        private double FatimaTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblGuide_Click(object sender, EventArgs e)
        {

        }

        private void lblInitial_Click(object sender, EventArgs e)
        {

        }

        private void txtSalesinitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtAmountOfSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void getSalesPerson_Amount(
            string salesInitial, double salesAmount)
        {
            string initial = salesInitial.Trim().ToUpper();

            switch (initial)
            {
                case "D":
                    DanielleTotal += salesAmount;

                    lblOutput.Text =
                        "Salesperson: Danielle\n" +
                        "Amount of Sale: " + salesAmount.ToString("C") +
                        "\nDanielle's Total Sales: " +
                        DanielleTotal.ToString("C");
                    break;
                case ("E"):
                    EdwardTotal += salesAmount;

                    lblOutput.Text =
                        "Salesperson: Edward\n" +
                        "Amount of Sale: " + salesAmount.ToString("C") +
                        "\nEdward's Total Sales: " +
                        EdwardTotal.ToString("C");
                    break;
                case ("F"):
                    FatimaTotal += salesAmount;

                    lblOutput.Text =
                        "Salesperson: Fatima\n" +
                        "Amount of Sale: " + salesAmount.ToString("C") +
                        "\nFatima's Total Sales: " +
                        FatimaTotal.ToString("C");
                    break;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string initial = txtSalesinitial.Text.Trim();

            double amount;

            if (initial == "") 
            {
                MessageBox.Show("Please enter salesperson initial.");
                txtSalesinitial.Focus();
                return;
            }
            if (initial.ToUpper() != "D" &&
                initial.ToUpper() != "E" &&
                initial.ToUpper() != "F")
            {
                MessageBox.Show(
                    "Invalid initial! Please enter D, E, or F.");
                txtSalesinitial.Focus();
                return;
            }
            if (!double.TryParse(txtAmountOfSale.Text, out amount)
                || amount <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid sale amount greater than zero.");
                txtAmountOfSale.Focus();
                return;
            }
            getSalesPerson_Amount(initial, amount);

            txtSalesinitial.Clear();
            txtAmountOfSale.Clear();

            txtSalesinitial.Focus();
        }
        private void clearEntry()
        {
            txtSalesinitial.Clear();
            txtAmountOfSale.Clear();
            lblOutput.Text = "";

            txtSalesinitial.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double grandTotal =
                DanielleTotal + EdwardTotal + FatimaTotal;

            string report =
                "HOME SALES SUMMARY REPORT\n\n" +
                "Danielle (D): " + DanielleTotal.ToString("C") + "\n" +
                "Edward (E): " + EdwardTotal.ToString("C") + "\n" +
                "Fatima (D): " + FatimaTotal.ToString("C") + "\n" +
                "--------------------------------\n" +
                "GRAND TOTAL:" + grandTotal.ToString("C");

            MessageBox.Show(
                report,
                "Home Sales Tracking Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}


