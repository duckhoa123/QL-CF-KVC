using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public static class ControlExtension
    {
        public static void EnableNumeric(this TextBox textBox)
        {
            textBox.Text = "0";
            textBox.KeyPress += OnNumbericBoxKeyPress;
        }

        static void OnNumbericBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }
    }
}
