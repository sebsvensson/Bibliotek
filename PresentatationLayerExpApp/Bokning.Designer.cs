
namespace Presentatationslager
{
    partial class Bokning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bokaButton = new System.Windows.Forms.Button();
            this.dataGridViewBöcker = new System.Windows.Forms.DataGridView();
            this.MedlemsNrTextBox = new System.Windows.Forms.TextBox();
            this.LabelMedlemNr = new System.Windows.Forms.Label();
            this.LabelRubrik = new System.Windows.Forms.Label();
            this.MedlemsNrError = new System.Windows.Forms.Label();
            this.utlånadeBöcker = new System.Windows.Forms.CheckBox();
            this.frånDatum = new System.Windows.Forms.DateTimePicker();
            this.bokningError = new System.Windows.Forms.Label();
            this.reserveraFrån = new System.Windows.Forms.Label();
            this.tillDatum = new System.Windows.Forms.DateTimePicker();
            this.reserveraTill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBöcker)).BeginInit();
            this.SuspendLayout();
            // 
            // bokaButton
            // 
            this.bokaButton.BackColor = System.Drawing.Color.DarkGreen;
            this.bokaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bokaButton.FlatAppearance.BorderSize = 0;
            this.bokaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bokaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bokaButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bokaButton.ForeColor = System.Drawing.Color.Black;
            this.bokaButton.Location = new System.Drawing.Point(775, 638);
            this.bokaButton.Margin = new System.Windows.Forms.Padding(4);
            this.bokaButton.Name = "bokaButton";
            this.bokaButton.Size = new System.Drawing.Size(191, 43);
            this.bokaButton.TabIndex = 0;
            this.bokaButton.Text = "Boka/Reservera";
            this.bokaButton.UseVisualStyleBackColor = false;
            this.bokaButton.Click += new System.EventHandler(this.bokaButton_Click);
            // 
            // dataGridViewBöcker
            // 
            this.dataGridViewBöcker.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBöcker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBöcker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBöcker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBöcker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewBöcker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.dataGridViewBöcker.Location = new System.Drawing.Point(66, 110);
            this.dataGridViewBöcker.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBöcker.Name = "dataGridViewBöcker";
            this.dataGridViewBöcker.RowHeadersVisible = false;
            this.dataGridViewBöcker.RowHeadersWidth = 51;
            this.dataGridViewBöcker.Size = new System.Drawing.Size(900, 500);
            this.dataGridViewBöcker.TabIndex = 1;
            this.dataGridViewBöcker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBöcker_CellClick);
            this.dataGridViewBöcker.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewBöcker_DataBindingComplete);
            // 
            // MedlemsNrTextBox
            // 
            this.MedlemsNrTextBox.Location = new System.Drawing.Point(405, 633);
            this.MedlemsNrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedlemsNrTextBox.Name = "MedlemsNrTextBox";
            this.MedlemsNrTextBox.Size = new System.Drawing.Size(120, 23);
            this.MedlemsNrTextBox.TabIndex = 3;
            // 
            // LabelMedlemNr
            // 
            this.LabelMedlemNr.AutoSize = true;
            this.LabelMedlemNr.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMedlemNr.ForeColor = System.Drawing.Color.Black;
            this.LabelMedlemNr.Location = new System.Drawing.Point(261, 636);
            this.LabelMedlemNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMedlemNr.Name = "LabelMedlemNr";
            this.LabelMedlemNr.Size = new System.Drawing.Size(121, 16);
            this.LabelMedlemNr.TabIndex = 5;
            this.LabelMedlemNr.Text = "Medlemsnummer: ";
            // 
            // LabelRubrik
            // 
            this.LabelRubrik.AutoSize = true;
            this.LabelRubrik.BackColor = System.Drawing.Color.Transparent;
            this.LabelRubrik.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrik.ForeColor = System.Drawing.Color.Black;
            this.LabelRubrik.Location = new System.Drawing.Point(62, 25);
            this.LabelRubrik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrik.Name = "LabelRubrik";
            this.LabelRubrik.Size = new System.Drawing.Size(200, 25);
            this.LabelRubrik.TabIndex = 6;
            this.LabelRubrik.Text = "Registrera bokning";
            // 
            // MedlemsNrError
            // 
            this.MedlemsNrError.AutoSize = true;
            this.MedlemsNrError.ForeColor = System.Drawing.Color.Red;
            this.MedlemsNrError.Location = new System.Drawing.Point(555, 666);
            this.MedlemsNrError.Name = "MedlemsNrError";
            this.MedlemsNrError.Size = new System.Drawing.Size(0, 17);
            this.MedlemsNrError.TabIndex = 7;
            // 
            // utlånadeBöcker
            // 
            this.utlånadeBöcker.AutoSize = true;
            this.utlånadeBöcker.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utlånadeBöcker.ForeColor = System.Drawing.Color.Black;
            this.utlånadeBöcker.Location = new System.Drawing.Point(67, 636);
            this.utlånadeBöcker.Margin = new System.Windows.Forms.Padding(4);
            this.utlånadeBöcker.Name = "utlånadeBöcker";
            this.utlånadeBöcker.Size = new System.Drawing.Size(152, 20);
            this.utlånadeBöcker.TabIndex = 9;
            this.utlånadeBöcker.Text = "Visa utlånade böcker";
            this.utlånadeBöcker.UseVisualStyleBackColor = true;
            this.utlånadeBöcker.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frånDatum
            // 
            this.frånDatum.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frånDatum.Location = new System.Drawing.Point(66, 80);
            this.frånDatum.Name = "frånDatum";
            this.frånDatum.Size = new System.Drawing.Size(227, 23);
            this.frånDatum.TabIndex = 10;
            this.frånDatum.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bokningError
            // 
            this.bokningError.AutoSize = true;
            this.bokningError.ForeColor = System.Drawing.Color.Red;
            this.bokningError.Location = new System.Drawing.Point(281, 664);
            this.bokningError.Name = "bokningError";
            this.bokningError.Size = new System.Drawing.Size(12, 17);
            this.bokningError.TabIndex = 11;
            this.bokningError.Text = " ";
            // 
            // reserveraFrån
            // 
            this.reserveraFrån.AutoSize = true;
            this.reserveraFrån.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveraFrån.ForeColor = System.Drawing.Color.Black;
            this.reserveraFrån.Location = new System.Drawing.Point(64, 61);
            this.reserveraFrån.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reserveraFrån.Name = "reserveraFrån";
            this.reserveraFrån.Size = new System.Drawing.Size(134, 16);
            this.reserveraFrån.TabIndex = 12;
            this.reserveraFrån.Text = "Reservera bok fr.o.m";
            // 
            // tillDatum
            // 
            this.tillDatum.CalendarFont = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.tillDatum.Font = new System.Drawing.Font("Century Schoolbook", 9.75F);
            this.tillDatum.Location = new System.Drawing.Point(314, 80);
            this.tillDatum.Name = "tillDatum";
            this.tillDatum.Size = new System.Drawing.Size(200, 23);
            this.tillDatum.TabIndex = 10;
            this.tillDatum.Value = new System.DateTime(2022, 2, 12, 0, 0, 0, 0);
            // 
            // reserveraTill
            // 
            this.reserveraTill.AutoSize = true;
            this.reserveraTill.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic);
            this.reserveraTill.Location = new System.Drawing.Point(311, 60);
            this.reserveraTill.Name = "reserveraTill";
            this.reserveraTill.Size = new System.Drawing.Size(129, 16);
            this.reserveraTill.TabIndex = 12;
            this.reserveraTill.Text = "Reservera bok t.o.m";
            // 
            // Bokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1044, 702);
            this.Controls.Add(this.reserveraTill);
            this.Controls.Add(this.tillDatum);
            this.Controls.Add(this.reserveraFrån);
            this.Controls.Add(this.bokningError);
            this.Controls.Add(this.frånDatum);
            this.Controls.Add(this.utlånadeBöcker);
            this.Controls.Add(this.MedlemsNrError);
            this.Controls.Add(this.LabelRubrik);
            this.Controls.Add(this.LabelMedlemNr);
            this.Controls.Add(this.MedlemsNrTextBox);
            this.Controls.Add(this.dataGridViewBöcker);
            this.Controls.Add(this.bokaButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bokning";
            this.Text = "       ";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBöcker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bokaButton;
        private System.Windows.Forms.DataGridView dataGridViewBöcker;
        private System.Windows.Forms.TextBox MedlemsNrTextBox;
        private System.Windows.Forms.Label LabelMedlemNr;
        private System.Windows.Forms.Label LabelRubrik;
        private System.Windows.Forms.Label MedlemsNrError;
        private System.Windows.Forms.CheckBox utlånadeBöcker;
        private System.Windows.Forms.DateTimePicker frånDatum;
        private System.Windows.Forms.Label bokningError;
        private System.Windows.Forms.Label reserveraFrån;
        private System.Windows.Forms.DateTimePicker tillDatum;
        private System.Windows.Forms.Label reserveraTill;
    }
}