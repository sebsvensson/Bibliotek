using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteksapplikation;

namespace Presentatationslager
{
    public partial class LoggaIn : Form
    {
        Bokningssystem bokningssystem;

        public LoggaIn()
        {
            InitializeComponent();
            bokningssystem = Bokningssystem.
                HämtaBöcker();
        }

        private void LogginButton_Click(object sender, EventArgs e)
        {
            string personalID = användarnamnTextbox.Text;
            string lösenord = lösenordTextbox.Text;
            if (!string.IsNullOrEmpty(personalID) && !string.IsNullOrEmpty(lösenord))
            {
                var inloggning = bokningssystem.LoggaIn(personalID, lösenord);
                if (inloggning)

                {
                    Huvudmeny ui = new Huvudmeny(bokningssystem);
                    ui.Show();
                    this.Hide();
                }

                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Andvändarnamn eller Lösenord är felaktigt.";
                }
            }
        }

        private void FelhanteringInlogg_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }
    }
}
