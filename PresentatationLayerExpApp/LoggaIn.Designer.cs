
namespace Presentatationslager
{
    partial class LoggaIn
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
            this.användarnamnTextbox = new System.Windows.Forms.TextBox();
            this.lösenordTextbox = new System.Windows.Forms.TextBox();
            this.loggaInButton = new System.Windows.Forms.Button();
            this.labelAnvändarnamn = new System.Windows.Forms.Label();
            this.labenLösenord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // användarnamnTextbox
            // 
            this.användarnamnTextbox.Location = new System.Drawing.Point(195, 112);
            this.användarnamnTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.användarnamnTextbox.Name = "användarnamnTextbox";
            this.användarnamnTextbox.Size = new System.Drawing.Size(116, 21);
            this.användarnamnTextbox.TabIndex = 0;
            this.användarnamnTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FelhanteringInlogg_KeyPress);
            // 
            // lösenordTextbox
            // 
            this.lösenordTextbox.Location = new System.Drawing.Point(195, 154);
            this.lösenordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lösenordTextbox.Name = "lösenordTextbox";
            this.lösenordTextbox.PasswordChar = '*';
            this.lösenordTextbox.Size = new System.Drawing.Size(116, 21);
            this.lösenordTextbox.TabIndex = 1;
            // 
            // loggaInButton
            // 
            this.loggaInButton.BackColor = System.Drawing.Color.DarkGreen;
            this.loggaInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loggaInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.loggaInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggaInButton.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggaInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loggaInButton.Location = new System.Drawing.Point(135, 243);
            this.loggaInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loggaInButton.Name = "loggaInButton";
            this.loggaInButton.Size = new System.Drawing.Size(117, 33);
            this.loggaInButton.TabIndex = 2;
            this.loggaInButton.Text = "Logga in";
            this.loggaInButton.UseVisualStyleBackColor = false;
            this.loggaInButton.Click += new System.EventHandler(this.LogginButton_Click);
            // 
            // labelAnvändarnamn
            // 
            this.labelAnvändarnamn.AutoSize = true;
            this.labelAnvändarnamn.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnvändarnamn.Location = new System.Drawing.Point(30, 111);
            this.labelAnvändarnamn.Name = "labelAnvändarnamn";
            this.labelAnvändarnamn.Size = new System.Drawing.Size(159, 19);
            this.labelAnvändarnamn.TabIndex = 3;
            this.labelAnvändarnamn.Text = "Andvändarnamn: ";
            // 
            // labenLösenord
            // 
            this.labenLösenord.AutoSize = true;
            this.labenLösenord.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labenLösenord.Location = new System.Drawing.Point(76, 154);
            this.labenLösenord.Name = "labenLösenord";
            this.labenLösenord.Size = new System.Drawing.Size(97, 19);
            this.labenLösenord.TabIndex = 4;
            this.labenLösenord.Text = "Lösenord: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            // 
            // loginTitel
            // 
            this.loginTitel.AutoSize = true;
            this.loginTitel.Font = new System.Drawing.Font("Century Schoolbook", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitel.Location = new System.Drawing.Point(130, 32);
            this.loginTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginTitel.Name = "loginTitel";
            this.loginTitel.Size = new System.Drawing.Size(125, 28);
            this.loginTitel.TabIndex = 7;
            this.loginTitel.Text = "Inloggning";
            // 
            // LoggaIn
            // 
            this.AcceptButton = this.loggaInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.loginTitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labenLösenord);
            this.Controls.Add(this.labelAnvändarnamn);
            this.Controls.Add(this.loggaInButton);
            this.Controls.Add(this.lösenordTextbox);
            this.Controls.Add(this.användarnamnTextbox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoggaIn";
            this.Text = "Bibliotek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox användarnamnTextbox;
        private System.Windows.Forms.TextBox lösenordTextbox;
        private System.Windows.Forms.Button loggaInButton;
        private System.Windows.Forms.Label labelAnvändarnamn;
        private System.Windows.Forms.Label labenLösenord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginTitel;
    }
}