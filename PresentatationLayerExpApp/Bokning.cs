using Biblioteksapplikation;
using BiblioteksApplikation.Model;
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
    public partial class Bokning : Form
    {
        Bokningssystem bokningssystem;
        public DataTable table;
        

        public Bokning()
        {
            InitializeComponent();
            dataGridViewBöcker.AllowUserToResizeRows = false;
            dataGridViewBöcker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBöcker.MultiSelect = false;
            dataGridViewBöcker.AllowUserToAddRows = false;
            tillDatum.Value = DateTime.Now.AddDays(7);


        }

        private void Test_Load(object sender, EventArgs e)
        {
            bokningssystem = Bokningssystem.HämtaBöcker();
            UpdateTable();

            dataGridViewBöcker.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewBöcker.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bokaButton_Click(object sender, EventArgs e)
        {
            Bok b;
            bokningError.Text = "";

            if (MedlemsNrTextBox.Text.Length < 1)
            {
                bokningError.Text = "Medlemsnummer saknas.";
                return;
            }

            if (!bokningssystem.ÄrMedlem(MedlemsNrTextBox.Text.ToUpper()))
            {
                bokningError.Text = "Felaktigt Medlemsnummer.";
            }

            if (bokningError.Text == "")
            {
                var aktivBokning = false;

                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToBoolean(row["Låna"]) == true)
                    {

                        Bok bok = bokningssystem.HittaBok((long)Convert.ToInt64(row["ISBN"]));
                        bokningssystem.LäggBokning(MedlemsNrTextBox.Text.ToUpper(), bok, frånDatum.Value, tillDatum.Value);

                        
                        aktivBokning = true;
                    }
                }

                if (aktivBokning == false)
                {
                    bokningError.ForeColor = Color.Red;
                    bokningError.Text = "Ingen bokning har markerats.";
                }
                
                UpdateTable();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            if (table == null)
            {
                table = new DataTable();
                table.Columns.Add("ISBN", typeof(long));
                table.Columns.Add("Titel", typeof(string));
                table.Columns.Add("Låna", typeof(bool));

                table.Columns["ISBN"].ReadOnly = true;
                table.Columns["Titel"].ReadOnly = true;
                table.Columns["Låna"].ReadOnly = false;
            }
            else
                table.Clear();

            if (utlånadeBöcker.Checked)
            {
                var index = new List<int>();
                foreach (Bok bok in bokningssystem.AllaBöcker())
                {
                    DataRow row = table.NewRow();
                    row["ISBN"] = bok.ISBN;
                    row["Titel"] = bok.Titel;
                    row["Låna"] = false;

                    table.Rows.Add(row);

                    if (DateTime.Now >= frånDatum.Value && DateTime.Now <= tillDatum.Value)
                    {
                        index.Add(table.Rows.Count - 1);
                    }
                }

                dataGridViewBöcker.DataSource = table;


            }
            else
            {
                foreach (Bok bok in bokningssystem.TillgängligaBöcker(frånDatum.Value))
                {
                    DataRow row = table.NewRow();
                    row["ISBN"] = bok.ISBN;
                    row["Titel"] = bok.Titel;
                    row["Låna"] = false;

                  
                    table.Rows.Add(row);
                }
                dataGridViewBöcker.DataSource = table;
            }
        }

        private void dataGridViewBöcker_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewBöcker.ClearSelection();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dataGridViewBöcker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           
            if (dataGridViewBöcker.Rows[e.RowIndex].Cells[2].ReadOnly == false && e.ColumnIndex != 2)
            {
                if (Convert.ToBoolean(table.Rows[e.RowIndex]["Låna"]) == false)
                {
                    table.Rows[e.RowIndex]["Låna"] = true;
                }
                else
                {
                    table.Rows[e.RowIndex]["Låna"] = false;
                }
            }
        }

        
    }
}
