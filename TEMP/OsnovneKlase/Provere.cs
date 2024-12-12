using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat.OsnovneKlase
{

    internal class Provere
    {
        private static ErrorProvider errorProvider = new ErrorProvider();
        private static void ProveraUnosaTxt(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "Textbox ne sme biti prazan ili sadrzati praznine");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.LightSalmon;
            }
            else
            {
                errorProvider.SetError(txt, "");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = SystemColors.Window;
                txt.ForeColor = SystemColors.ControlText;

            }
        }
        private static void ProveraUnosaBroja(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();

            if (!int.TryParse(txt.Text, out int vrednost) || int.Parse(txt.Text)<=0)
            {
                errorProvider.SetError(txt, "Unutar tekstboksa sme da se unose samo pozitivni brojevi");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.LightBlue;
                txt.ForeColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(txt, "");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = SystemColors.Window;
                txt.ForeColor = SystemColors.ControlText;

            }
        }
        private static void ProveraUnosaBrojaI0(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();

            if (!int.TryParse(txt.Text, out int vrednost) || int.Parse(txt.Text) < 0)
            {
                errorProvider.SetError(txt, "Unutar tekstboksa sme da se unose samo pozitivni brojevi");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.Yellow;
                txt.ForeColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(txt, "");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = SystemColors.Window;
                txt.ForeColor = SystemColors.ControlText;

            }
        }
        public static void DodajProveruUnosa(Control.ControlCollection controls) {
            foreach (Control control in controls) {

                if (control is TextBox && (string)control.Tag == "ignore")
                    continue;

                if (control is TextBox && control.Tag == "br")
                    control.Validated += ProveraUnosaBroja;


                if (control is TextBox && control.Tag != "br")
                    control.Validated += ProveraUnosaTxt;

                if (control is TextBox && control.Tag == "br 0")
                    control.Validated += ProveraUnosaBrojaI0;

                
            }    
        
        }
        public static bool DaLiPostojeGreske(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(control)))
                    return true;

            }
            return false;
        }
    }
}
