using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Validacije
{
   public  class Helper
    {

        public static bool PraznoPoljeValidacija(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool ValidacijaDatuma(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text) ||
                !DateTime.TryParseExact(txt.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                txt.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        internal static bool DoubleValidacija(TextBox txtIznos)
        {
            Regex proveriDouble = new Regex(@"^[0-9]*[.][0-9]*$");

            if (!proveriDouble.IsMatch(txtIznos.Text))
            {
                txtIznos.Text = "Morate uneti decimalni broj";
                txtIznos.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                txtIznos.BackColor = Color.White;
                return true;
            }
            


        }
        internal static bool JMBGValidacija(TextBox txtJMBG)
        {
            Regex proveriJMBG = new Regex(@"^[0-9]{13}$");
            if (!proveriJMBG.IsMatch(txtJMBG.Text))
            {
                txtJMBG.BackColor = Color.LightPink;
                txtJMBG.Text = "Morate uneti decimalni broj";
                txtJMBG.BackColor = Color.Red;
                txtJMBG.Text = "Jmbg mora imati 13 cifara";
                return false;
            }
            else
            {
                txtJMBG.BackColor = Color.White;
                return true;
            }
        }

        public static bool ComboBoxValidacija(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidacija(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int _))
            {
                txt.Text = "Morate uneti broj";
                txt.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
       

       

    }
}
