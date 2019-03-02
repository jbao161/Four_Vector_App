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
    public partial class Form_boost_rotation : Form
    {
        public Form_boost_rotation()
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
        public void button_boost3d_Click(object sender, EventArgs e)
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

                if (textBox_x0.Text == "") textBox_x0.Text = "0";
                if (textBox_x1.Text == "") textBox_x1.Text = "0";
                if (textBox_x2.Text == "") textBox_x2.Text = "0";
                if (textBox_x3.Text == "") textBox_x3.Text = "0";
                var ct = Convert.ToDouble(textBox_x0.Text);
                var x = Convert.ToDouble(textBox_x1.Text);
                var y = Convert.ToDouble(textBox_x2.Text);
                var z = Convert.ToDouble(textBox_x3.Text);

                Matrix position_4vector = new Matrix(new double[] { ct, x, y, z });

                Matrix new_position = lorentz_matrix.multiply(position_4vector);

                textBox_rotated_x0.Text = new_position.array[0, 0].ToString();
                textBox_rotated_x1.Text = new_position.array[1, 0].ToString();
                textBox_rotated_x2.Text = new_position.array[2, 0].ToString();
                textBox_rotated_x3.Text = new_position.array[3, 0].ToString();

                if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_Click(sender, e);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting inputs to numerical values.");
            }
        }

        private void button_updatefourvector_Click(object sender, EventArgs e)
        {
            textBox_x0.Text = textBox_rotated_x0.Text;
            textBox_x1.Text = textBox_rotated_x1.Text;
            textBox_x2.Text = textBox_rotated_x2.Text;
            textBox_x3.Text = textBox_rotated_x3.Text;
        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            try
            {
                var theta = Convert.ToDouble(textBox_rotation_angle.Text);
                if (textBox_rotation_x.Text == "") textBox_rotation_x.Text = "0";
                if (textBox_rotation_y.Text == "") textBox_rotation_y.Text = "0";
                if (textBox_rotation_z.Text == "") textBox_rotation_z.Text = "0";

                var rotation_vectorx = Convert.ToDouble(textBox_rotation_x.Text);
                var rotation_vectory = Convert.ToDouble(textBox_rotation_y.Text);
                var rotation_vectorz = Convert.ToDouble(textBox_rotation_z.Text);
                var rotation_norm = Math.Sqrt(rotation_vectorx * rotation_vectorx + rotation_vectory * rotation_vectory + rotation_vectorz * rotation_vectorz);
                var rotation_norm_x = rotation_vectorx / rotation_norm;
                var rotation_norm_y = rotation_vectory / rotation_norm;
                var rotation_norm_z = rotation_vectorz / rotation_norm;
                double[] _rotationvector = { rotation_norm_x, rotation_norm_y, rotation_norm_z };
                textBox_rotation_norm_x.Text = rotation_norm_x.ToString();
                textBox_rotation_norm_y.Text = rotation_norm_y.ToString();
                textBox_rotation_norm_z.Text = rotation_norm_z.ToString();

                double[,] rotation_array = Matrix.Calculate_spacetime_rotationmatrix(theta, _rotationvector);
                textBox_matrix_1_1.Text = rotation_array[0, 0].ToString("0.########");
                textBox_matrix_1_2.Text = rotation_array[0, 1].ToString("0.########");
                textBox_matrix_1_3.Text = rotation_array[0, 2].ToString("0.########");
                textBox_matrix_1_4.Text = rotation_array[0, 3].ToString("0.########");
                textBox_matrix_2_1.Text = rotation_array[1, 0].ToString("0.########");
                textBox_matrix_2_2.Text = rotation_array[1, 1].ToString("0.########");
                textBox_matrix_2_3.Text = rotation_array[1, 2].ToString("0.########");
                textBox_matrix_2_4.Text = rotation_array[1, 3].ToString("0.########");
                textBox_matrix_3_1.Text = rotation_array[2, 0].ToString("0.########");
                textBox_matrix_3_2.Text = rotation_array[2, 1].ToString("0.########");
                textBox_matrix_3_3.Text = rotation_array[2, 2].ToString("0.########");
                textBox_matrix_3_4.Text = rotation_array[2, 3].ToString("0.########");
                textBox_matrix_4_1.Text = rotation_array[3, 0].ToString("0.########");
                textBox_matrix_4_2.Text = rotation_array[3, 1].ToString("0.########");
                textBox_matrix_4_3.Text = rotation_array[3, 2].ToString("0.########");
                textBox_matrix_4_4.Text = rotation_array[3, 3].ToString("0.########");

                if (textBox_x0.Text == "") textBox_x0.Text = "0";
                if (textBox_x1.Text == "") textBox_x1.Text = "0";
                if (textBox_x2.Text == "") textBox_x2.Text = "0";
                if (textBox_x3.Text == "") textBox_x3.Text = "0";
                var ct = Convert.ToDouble(textBox_x0.Text);
                var x = Convert.ToDouble(textBox_x1.Text);
                var y = Convert.ToDouble(textBox_x2.Text);
                var z = Convert.ToDouble(textBox_x3.Text);

                Matrix position_4vector = new Matrix(new double[] { ct, x, y, z });
                Matrix rotation_matrix = new Matrix(rotation_array);

                Matrix new_position = rotation_matrix.multiply(position_4vector);

                rotation_matrix.print();
                textBox_rotated_x0.Text = new_position.array[0, 0].ToString();
                textBox_rotated_x1.Text = new_position.array[1, 0].ToString();
                textBox_rotated_x2.Text = new_position.array[2, 0].ToString();
                textBox_rotated_x3.Text = new_position.array[3, 0].ToString();

                if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_Click(sender, e);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting inputs to numerical values.");
            }
        }

        private void button_boostrotate_Click(object sender, EventArgs e)
        {
            var ct = textBox_x0.Text;
            var x = textBox_x1.Text;
            var y = textBox_x2.Text;
            var z = textBox_x3.Text;
            button_boost3d_Click(sender, e);
            button_updatefourvector_Click(sender, e); // c# events are synchronous. the values will update at the right time.
            button_rotate_Click(sender, e);
            if (checkBox_autoupdate_fourvector.Checked == false)
            {
                textBox_x0.Text = ct;
                textBox_x1.Text = x;
                textBox_x2.Text = y;
                textBox_x3.Text = z;
            }
        }

        private void button_rotateboost_Click(object sender, EventArgs e)
        {
            var ct = textBox_x0.Text;
            var x = textBox_x1.Text;
            var y = textBox_x2.Text;
            var z = textBox_x3.Text;
            button_rotate_Click(sender, e);
            button_updatefourvector_Click(sender, e);
            button_boost3d_Click(sender, e);
            if (checkBox_autoupdate_fourvector.Checked == false)
            {
                textBox_x0.Text = ct;
                textBox_x1.Text = x;
                textBox_x2.Text = y;
                textBox_x3.Text = z;
            }
        }
    }
}
