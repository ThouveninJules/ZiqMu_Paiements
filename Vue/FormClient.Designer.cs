namespace Banque
{
    partial class FormClient
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Enabled = false;
            this.tbNum.Location = new System.Drawing.Point(144, 50);
            this.tbNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbNum.Name = "tbNum";
            this.tbNum.ReadOnly = true;
            this.tbNum.Size = new System.Drawing.Size(148, 31);
            this.tbNum.TabIndex = 0;
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbNom.Location = new System.Drawing.Point(144, 140);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(148, 31);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPrenom.Location = new System.Drawing.Point(144, 262);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(148, 31);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(144, 354);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(148, 31);
            this.tbAdresse.TabIndex = 3;
            this.tbAdresse.TextChanged += new System.EventHandler(this.tbAdresse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbNum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}