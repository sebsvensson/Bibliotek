using Biblioteksapplikation;
using Biblioteksapplikation.Model;
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
    public partial class Återlämning : Form
    {

        Bokningssystem bokningssystem;
        private DataTable table;


        public Återlämning()
        {
            InitializeComponent();
            bokningssystem = Bokningssystem.HämtaBöcker();
            dataGridViewÅterlämnade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewÅterlämnade.MultiSelect = false;
            dataGridViewÅterlämnade.AllowUserToResizeRows = false;
            dataGridViewÅterlämnade.AllowUserToAddRows = false;
        }
        private void Andra_Load(object sender, EventArgs e)
        {
            UppdateraVy();


        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in table.Rows)
            {
                if ((bool)row["Återlämna"])
                {


                    try
                    {
                        bokningssystem.ÅterlämnaBok(Convert.ToString(row["Ref."]));
                    }
                    catch (ArgumentException)
                    {
                        ErrorMessageLabel.Text = "Alla bokningar finns inte med.";
                    }
                
            }
            
        }
            UppdateraVy();
        }


        private void checkbox_StatusBookings(object sender, EventArgs e)
        {

            if (färdigaBokningar.Checked)
            {
                table.Columns.Add("Återlämnad", typeof(DateTime));
                table.Columns.Add("Faktura", typeof(string));
                dataGridViewÅterlämnade.Columns["Återlämna"].DisplayIndex = (table.Columns.Count - 1);
                
            }
            else
            {
                table.Columns.Remove("Återlämnad");
                table.Columns.Remove("Faktura");
            }
            UppdateraVy();


        }

        public void UppdateraVy()
        {

            if (table == null)
            {
                table = new DataTable();


                table.Columns.Add("Ref.", typeof(string));
                table.Columns.Add("MedlemID", typeof(string));
                table.Columns.Add("Titel", typeof(string));
                table.Columns.Add("ISBN", typeof(long));
                table.Columns.Add("Datum", typeof(DateTime));
                table.Columns.Add("FörfalloDatum", typeof(DateTime));
                table.Columns.Add("Återlämna", typeof(bool));



                table.Columns["Ref."].ReadOnly = true;
                table.Columns["MedlemID"].ReadOnly = true;
                table.Columns["Titel"].ReadOnly = true;
                table.Columns["ISBN"].ReadOnly = true;
                table.Columns["Datum"].ReadOnly = true;
                table.Columns["FörfalloDatum"].ReadOnly = true;
                table.Columns["Återlämna"].ReadOnly = false;
            }
            else
                table.Clear();

            if (färdigaBokningar.Checked)
            {
                var bokningar = bokningssystem.AllaBokningar();


                foreach (Biblioteksapplikation.Model.Bokning bokning in bokningar)
                {
                    DataRow row = table.NewRow();
                    row["Ref."] = bokning.Bokningsreferens;
                    row["MedlemID"] = bokning.MedlemID;
                    row["Titel"] = bokning.Titel;
                    row["ISBN"] = bokning.ISBN;
                    row["Datum"] = bokning.Datum;
                    row["FörfalloDatum"] = bokning.UtgångsDatum;
                    if (bokning.Återlämnad != null)
                        row["Återlämnad"] = bokning.Återlämnad;
                    row["Faktura"] = Convert.ToString(bokning.Totalpris) + " SEK";
                    table.Rows.Add(row);
                }
                dataGridViewÅterlämnade.DataSource = table;
                
                

            }
            else
            {
                var bokningar = bokningssystem.LagdaBokningar();

                foreach (Biblioteksapplikation.Model.Bokning bokning in bokningssystem.LagdaBokningar())
                {
                    DataRow row = table.NewRow();
                    row["Ref."] = bokning.Bokningsreferens;
                    row["MedlemID"] = bokning.MedlemID;
                    row["Titel"] = bokning.Titel;
                    row["ISBN"] = bokning.ISBN;
                    row["Datum"] = bokning.Datum;
                    row["FörfalloDatum"] = bokning.UtgångsDatum;
                    row["Återlämna"] = false;
                    table.Rows.Add(row);



                }
                dataGridViewÅterlämnade.DataSource = table;

            }

            dataGridViewÅterlämnade.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewÅterlämnade.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        public void RefreshForm()
        {
            UppdateraVy();
        }

        private void dataGridViewÅterlämnade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (!färdigaBokningar.Checked)
            {
                if (Convert.ToBoolean(table.Rows[e.RowIndex]["Återlämna"]) == false)
                {
                    table.Rows[e.RowIndex]["Återlämna"] = true;

                }
                else
                {
                    dataGridViewÅterlämnade.Rows[e.RowIndex].Cells["Återlämna"].Value = false;

                }
            }

            bokningsNummerTextBox.Text = "";
            medlemsNummerTextBox.Text = Convert.ToString(dataGridViewÅterlämnade.Rows[e.RowIndex].Cells[1].Value);
        }



    }
}
