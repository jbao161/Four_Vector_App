using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four_Vector_App
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void textBox_numerical_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one negative sign at beginning
            if ((e.KeyChar == '-') && (sender as TextBox).SelectionStart > 0)
            {
                e.Handled = true;
            }

        }

        private double calculate_gamma(double beta)
        {
            if (beta > -1.0 && beta < 1.0)
            {
                return 1.0 / Math.Sqrt(1.0 - beta * beta);
            }
            return double.NaN;
        }
        private double lorentz_boost_position(double ct, double x, double beta, double gamma)
        {
            return -1.0 * beta * gamma * ct + gamma * x;
        }
        private double lorentz_boost_time(double ct, double x, double beta, double gamma)
        {
            return gamma * ct - beta * gamma * x;
        }
        private void textBox_beta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    var beta = Convert.ToDouble(textBox_beta.Text);
                    var gamma = calculate_gamma(beta);
                    textBox_gamma.Text = double.IsNaN(gamma) ? "" : gamma.ToString();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", textBox_beta.Text);
                    textBox_gamma.Text = "";
                }

            }
        }

        private void button_lorentzboost_Click(object sender, EventArgs e)
        {
            try
            {
                var beta = Convert.ToDouble(textBox_beta.Text);
                var gamma = calculate_gamma(beta);
                if (double.IsNaN(gamma))
                {
                    return;
                }
                textBox_gamma.Text = gamma.ToString();
                var ct = Convert.ToDouble(textBox_x0.Text);
                var x = Convert.ToDouble(textBox_x1.Text);
                var y = Convert.ToDouble(textBox_x2.Text);
                var z = Convert.ToDouble(textBox_x3.Text);
                // https://stackoverflow.com/questions/6466952/how-to-get-a-checked-radio-button-in-a-groupbox
                var checkedButton = groupBox_boostdirection.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(rb => rb.Checked);
                switch (checkedButton.Name)
                {
                    case "radioButton_boostx":
                        textBox_x0_boosted.Text = lorentz_boost_time(ct, x, beta, gamma).ToString();
                        textBox_x1_boosted.Text = lorentz_boost_position(ct, x, beta, gamma).ToString();
                        textBox_x2_boosted.Text = textBox_x2.Text;
                        textBox_x3_boosted.Text = textBox_x3.Text;
                        break;
                    case "radioButton_boosty":
                        textBox_x0_boosted.Text = lorentz_boost_time(ct, y, beta, gamma).ToString();
                        textBox_x1_boosted.Text = textBox_x1.Text;
                        textBox_x2_boosted.Text = lorentz_boost_position(ct, y, beta, gamma).ToString();
                        textBox_x3_boosted.Text = textBox_x3.Text;
                        break;
                    case "radioButton_boostz":
                        textBox_x0_boosted.Text = lorentz_boost_time(ct, z, beta, gamma).ToString();
                        textBox_x1_boosted.Text = textBox_x1.Text;
                        textBox_x2_boosted.Text = textBox_x2.Text;
                        textBox_x3_boosted.Text = lorentz_boost_position(ct, z, beta, gamma).ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting inputs to numerical values.");
            }
        }

        private void linkLabel_lorentz_reference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }
    }
}
