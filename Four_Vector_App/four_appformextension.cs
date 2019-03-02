using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four_Vector_App
{
    public static partial class four_appformextension
    {
        public static void textBox_numerical_KeyPress(this Form fourappform, object sender, KeyPressEventArgs e)
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

    }
}
