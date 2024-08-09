using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax.Business.Util
{
    internal class Helper
    {
        public static int OpenPages = 0;
        public static DialogResult ShowMessage(string question)
        {
            return MessageBox.Show(question, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowMessage(string message, bool status)
        {
            if (status) { MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static DateTime EditDateForSearch(DateTime date, int hour, int seconds, int splitSecond)
        {
            TimeSpan time = new TimeSpan(hour, seconds, splitSecond);
            return date.Date + time;
        }

        public static string StatusToString(bool value)
        {
            if (value) { return "Açık"; }
            else { return "Kapalı"; }
        }
    }
}
