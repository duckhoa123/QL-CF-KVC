using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_COFFE_KVC
{
    public class Alert
    {
        public static Alert Instance { get; } = new Alert();

        Alert()
        {

        }

        public void ShowAlert(string message)
        {
            Format(ref message);
            MessageBox.Show(message);
        }

        public void ShowAlert(string message, string title)
        {
            Format(ref message);
            MessageBox.Show(message, title);
        }

        public DialogResult ShowAlert(string message, string title, MessageBoxButtons buttons)
        {
            Format(ref message);
          return  MessageBox.Show(message, title, buttons);
        }

        string Format(ref string message)
        {
            if (message == "Existed") message = "Đã tồn tại bản ghi";
            else if (message == "Edited") message = "Bản ghi đã được sửa";
            else if (message == "Deleted") message = "Bản ghi đã được xóa";
            return message;
        }
    }
}
