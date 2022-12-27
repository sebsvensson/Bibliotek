using Biblioteksapplikation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentatationslager
{
    public partial class Huvudmeny : Form
    {
        Bokningssystem bokningssystem { get; set; }

        Bokning Bokning;
        Återlämning Återlämning;

        Form[] allaFormer;

        Point p = new Point(0, 0);

        public Huvudmeny(Bokningssystem system)
        {
            InitializeComponent();

            bokningssystem = system;
            allaFormer = new Form[2];

            Bokning = new Bokning();
            Återlämning = new Återlämning();

            allaFormer[0] = Bokning;
            allaFormer[1] = Återlämning;

            foreach (Form ui in allaFormer)
            {
                ui.MdiParent = this;
                
                ui.WindowState = FormWindowState.Maximized;
            }

            Bokning.Show();
            Bokning.WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Reset()
        {
            foreach (Form form in allaFormer)
            {
                form.Hide();
            }
        }
        private void förstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            Bokning.Show();
            Bokning.WindowState = FormWindowState.Maximized;
            Bokning.Location = p;
            Bokning.UpdateTable();
        }


        private void andraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            Återlämning.Show();
            Återlämning.WindowState = FormWindowState.Maximized;
            Återlämning.Location = p;
            Återlämning.UppdateraVy();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
