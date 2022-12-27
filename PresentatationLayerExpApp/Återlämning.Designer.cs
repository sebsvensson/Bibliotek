
namespace Presentatationslager
{
    partial class Återlämning
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
            this.LabelRubrikÅterlämna = new System.Windows.Forms.Label();
            this.dataGridViewÅterlämnade = new System.Windows.Forms.DataGridView();
            this.återlämnaButton = new System.Windows.Forms.Button();
            this.bokningsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medlemsNummerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.färdigaBokningar = new System.Windows.Forms.CheckBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.ReturnTextBoxError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRubrikÅterlämna
            // 
            this.LabelRubrikÅterlämna.AutoSize = true;
            this.LabelRubrikÅterlämna.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRubrikÅterlämna.Location = new System.Drawing.Point(72, 63);
            this.LabelRubrikÅterlämna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRubrikÅterlämna.Name = "LabelRubrikÅterlämna";
            this.LabelRubrikÅterlämna.Size = new System.Drawing.Size(159, 25);
            this.LabelRubrikÅterlämna.TabIndex = 13;
            this.LabelRubrikÅterlämna.Text = "Återlämna bok";
            // 
            // dataGridViewÅterlämnade
            // 
            this.dataGridViewÅterlämnade.AllowUserToDeleteRows = false;
            this.dataGridViewÅterlämnade.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewÅterlämnade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewÅterlämnade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämnade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.dataGridViewÅterlämnade.Location = new System.Drawing.Point(71, 97);
            this.dataGridViewÅterlämnade.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewÅterlämnade.Name = "dataGridViewÅterlämnade";
            this.dataGridViewÅterlämnade.ReadOnly = true;
            this.dataGridViewÅterlämnade.RowHeadersVisible = false;
            this.dataGridViewÅterlämnade.RowHeadersWidth = 51;
            this.dataGridViewÅterlämnade.Size = new System.Drawing.Size(896, 503);
            this.dataGridViewÅterlämnade.TabIndex = 8;
            this.dataGridViewÅterlämnade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämnade_CellClick);
            // 
            // återlämnaButton
            // 
            this.återlämnaButton.BackColor = System.Drawing.Color.DarkGreen;
            this.återlämnaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.återlämnaButton.FlatAppearance.BorderSize = 0;
            this.återlämnaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.återlämnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.återlämnaButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.återlämnaButton.ForeColor = System.Drawing.Color.White;
            this.återlämnaButton.Location = new System.Drawing.Point(776, 629);
            this.återlämnaButton.Margin = new System.Windows.Forms.Padding(4);
            this.återlämnaButton.Name = "återlämnaButton";
            this.återlämnaButton.Size = new System.Drawing.Size(191, 43);
            this.återlämnaButton.TabIndex = 7;
            this.återlämnaButton.Text = "Bekräfta återlämning";
            this.återlämnaButton.UseVisualStyleBackColor = false;
            this.återlämnaButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // bokningsNummerTextBox
            // 
            this.bokningsNummerTextBox.Location = new System.Drawing.Point(507, 65);
            this.bokningsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bokningsNummerTextBox.Name = "bokningsNummerTextBox";
            this.bokningsNummerTextBox.Size = new System.Drawing.Size(120, 23);
            this.bokningsNummerTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bokningsnummer";
            // 
            // medlemsNummerTextBox
            // 
            this.medlemsNummerTextBox.Location = new System.Drawing.Point(340, 65);
            this.medlemsNummerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.medlemsNummerTextBox.Name = "medlemsNummerTextBox";
            this.medlemsNummerTextBox.Size = new System.Drawing.Size(120, 23);
            this.medlemsNummerTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Medlemsnummer";
            // 
            // färdigaBokningar
            // 
            this.färdigaBokningar.AutoSize = true;
            this.färdigaBokningar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.färdigaBokningar.Location = new System.Drawing.Point(823, 68);
            this.färdigaBokningar.Margin = new System.Windows.Forms.Padding(4);
            this.färdigaBokningar.Name = "färdigaBokningar";
            this.färdigaBokningar.Size = new System.Drawing.Size(179, 20);
            this.färdigaBokningar.TabIndex = 22;
            this.färdigaBokningar.Text = "Visa avslutade bokningar";
            this.färdigaBokningar.UseVisualStyleBackColor = true;
            this.färdigaBokningar.CheckedChanged += new System.EventHandler(this.checkbox_StatusBookings);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(74, 604);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(12, 17);
            this.ErrorMessageLabel.TabIndex = 24;
            this.ErrorMessageLabel.Text = " ";
            // 
            // ReturnTextBoxError
            // 
            this.ReturnTextBoxError.AutoSize = true;
            this.ReturnTextBoxError.ForeColor = System.Drawing.Color.Red;
            this.ReturnTextBoxError.Location = new System.Drawing.Point(639, 604);
            this.ReturnTextBoxError.Name = "ReturnTextBoxError";
            this.ReturnTextBoxError.Size = new System.Drawing.Size(12, 17);
            this.ReturnTextBoxError.TabIndex = 30;
            this.ReturnTextBoxError.Text = " ";
            // 
            // Återlämning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1044, 702);
            this.Controls.Add(this.ReturnTextBoxError);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.färdigaBokningar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medlemsNummerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bokningsNummerTextBox);
            this.Controls.Add(this.LabelRubrikÅterlämna);
            this.Controls.Add(this.dataGridViewÅterlämnade);
            this.Controls.Add(this.återlämnaButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Återlämning";
            this.Text = "Andra";
            this.Load += new System.EventHandler(this.Andra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämnade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRubrikÅterlämna;
        private System.Windows.Forms.DataGridView dataGridViewÅterlämnade;
        private System.Windows.Forms.Button återlämnaButton;
        private System.Windows.Forms.TextBox bokningsNummerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medlemsNummerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label ReturnTextBoxError;
        private System.Windows.Forms.CheckBox färdigaBokningar;
    }
}