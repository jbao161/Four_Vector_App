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
    public partial class Form_LorentzBoost : Form
    {
        public Form_LorentzBoost()
        {
            InitializeComponent();
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

                if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_boosted_Click(sender, e);
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

        private void button_boost3d_Click(object sender, EventArgs e)
        {
            try
            {
                var beta = Convert.ToDouble(textBox_beta3d.Text);
                var gamma = calculate_gamma(beta);
                if (double.IsNaN(gamma))
                {
                    return;
                }
                textBox_gamma3d.Text = gamma.ToString();
                var boostx = Convert.ToDouble(textBox_boostdirectionx3d.Text);
                var boosty = Convert.ToDouble(textBox_boostdirectiony3d.Text);
                var boostz = Convert.ToDouble(textBox_boostdirectionz3d.Text);
                var boost_norm = Math.Sqrt(boostx * boostx + boosty * boosty + boostz * boostz);
                var betax = beta / boost_norm * boostx;
                var betay = beta / boost_norm * boosty;
                var betaz = beta / boost_norm * boostz;
                double[] _beta = { betax, betay, betaz };
                textBox_betax3d.Text = betax.ToString();
                textBox_betay3d.Text = betay.ToString();
                textBox_betaz3d.Text = betaz.ToString();
                textBox_3dboostnormal_x.Text = (boostx / boost_norm).ToString();
                textBox_3dboostnormal_y.Text = (boosty / boost_norm).ToString();
                textBox_3dboostnormal_z.Text = (boostz / boost_norm).ToString();

                double[,] lorentz_array = new double[4, 4];
                lorentz_array[0, 0] = gamma;
                for (int i = 1; i < 4; i++)
                {
                    lorentz_array[i, 0] = -1.0 * gamma * _beta[i - 1];
                    lorentz_array[0, i] = -1.0 * gamma * _beta[i - 1];
                }
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        lorentz_array[i, j] = (gamma - 1.0) * _beta[i - 1] * _beta[j - 1] / (beta * beta);
                    }
                }
                for (int j = 1; j < 4; j++)
                {
                    lorentz_array[j, j] += 1;
                }
                Matrix lorentz_matrix = new Matrix(lorentz_array);


                var ct = Convert.ToDouble(textBox_x0.Text);
                var x = Convert.ToDouble(textBox_x1.Text);
                var y = Convert.ToDouble(textBox_x2.Text);
                var z = Convert.ToDouble(textBox_x3.Text);

                Matrix position_4vector = new Matrix(new double[] { ct, x, y, z });

                Matrix new_position = lorentz_matrix.multiply(position_4vector);

                textBox_3dboosted_x0.Text = new_position.array[0, 0].ToString();
                textBox_3dboosted_x1.Text = new_position.array[1, 0].ToString();
                textBox_3dboosted_x2.Text = new_position.array[2, 0].ToString();
                textBox_3dboosted_x3.Text = new_position.array[3, 0].ToString();

                if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_3dboosted_Click(sender, e);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting inputs to numerical values.");
            }
        }


        private void button_updatefourvector_boosted_Click(object sender, EventArgs e)
        {
            textBox_x0.Text = textBox_x0_boosted.Text;
            textBox_x1.Text = textBox_x1_boosted.Text;
            textBox_x2.Text = textBox_x2_boosted.Text;
            textBox_x3.Text = textBox_x3_boosted.Text;
        }

        private void button_updatefourvector_3dboosted_Click(object sender, EventArgs e)
        {
            textBox_x0.Text = textBox_3dboosted_x0.Text;
            textBox_x1.Text = textBox_3dboosted_x1.Text;
            textBox_x2.Text = textBox_3dboosted_x2.Text;
            textBox_x3.Text = textBox_3dboosted_x3.Text;
        }
    }
}
