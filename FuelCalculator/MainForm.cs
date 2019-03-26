using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelCalculator
{
    public partial class MainForm : Form
    {
        private const decimal GAL_TO_KG_100LL = 2.68735M;
        private const decimal GAL_TO_KG_JETA = 3.08447722M;
        private const decimal KG_TO_POUND = 2.205M;
        private const decimal GAL_TO_LITER = 3.7854M;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFuelAmount.Text))
            {
                MessageBox.Show("Please specify the total fuel amount in gallons", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuelAmount.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(tbTankCount.Text))
            {
                MessageBox.Show("Please specify the number of available tanks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTankCount.Focus();
                return;
            }

            decimal fuelAmount = 0.0M;
            if (!Decimal.TryParse(tbFuelAmount.Text, out fuelAmount))
            {
                MessageBox.Show("Invalid number format for fuel amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuelAmount.Focus();
                return;
            }

            short tankCount = 0;
            if (!Int16.TryParse(tbTankCount.Text, out tankCount))
            {
                MessageBox.Show("Invalid number format for tank count", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTankCount.Focus();
                return;
            }

            decimal fuelAmountLiter = fuelAmount * GAL_TO_LITER;
            decimal fuelWeightKg = fuelAmount * (rb100LL.Checked ? GAL_TO_KG_100LL : GAL_TO_KG_JETA);
            decimal fuelWeightLb = fuelWeightKg * KG_TO_POUND;

            tbFuelWeightKg.Text = string.Format("{0:###0.0}", fuelWeightKg);
            tbFuelWeightKgPerTank.Text = string.Format("{0:##0.0}", fuelWeightKg / tankCount);

            tbFuelWeightLb.Text = string.Format("{0:###0.0}", fuelWeightLb);
            tbFuelWeightLbPerTank.Text = string.Format("{0:##0.0}", fuelWeightLb / tankCount);

            tbFuelAmountLtr.Text = string.Format("{0:###0.0}", fuelAmountLiter);
            tbFuelAmountLtrPerTank.Text = string.Format("{0:##0.0}", fuelAmountLiter / tankCount);
        }
    }
}
