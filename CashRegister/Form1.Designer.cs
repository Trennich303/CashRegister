
namespace CashRegister
{
    partial class Form1
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
            this.RedBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.BaseballHatsLabel = new System.Windows.Forms.Label();
            this.BeanieHats = new System.Windows.Forms.Label();
            this.TopHats = new System.Windows.Forms.Label();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Textbox2 = new System.Windows.Forms.TextBox();
            this.Textbox3 = new System.Windows.Forms.TextBox();
            this.Totalbutton = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.Tendered = new System.Windows.Forms.Label();
            this.TenderedBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.SubTotalsTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ChangeBox = new System.Windows.Forms.TextBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Red;
            this.RedBox.Location = new System.Drawing.Point(-1, -1);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(977, 88);
            this.RedBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Red;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(314, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(301, 51);
            this.Title.TabIndex = 2;
            this.Title.Text = "The Hat Store";
            // 
            // BaseballHatsLabel
            // 
            this.BaseballHatsLabel.AutoSize = true;
            this.BaseballHatsLabel.BackColor = System.Drawing.Color.Black;
            this.BaseballHatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseballHatsLabel.ForeColor = System.Drawing.Color.White;
            this.BaseballHatsLabel.Location = new System.Drawing.Point(40, 120);
            this.BaseballHatsLabel.Name = "BaseballHatsLabel";
            this.BaseballHatsLabel.Size = new System.Drawing.Size(256, 25);
            this.BaseballHatsLabel.TabIndex = 3;
            this.BaseballHatsLabel.Text = "Number of Baseball Hats ";
            // 
            // BeanieHats
            // 
            this.BeanieHats.AutoSize = true;
            this.BeanieHats.ForeColor = System.Drawing.Color.White;
            this.BeanieHats.Location = new System.Drawing.Point(40, 166);
            this.BeanieHats.Name = "BeanieHats";
            this.BeanieHats.Size = new System.Drawing.Size(240, 25);
            this.BeanieHats.TabIndex = 4;
            this.BeanieHats.Text = "Number of Beanie Hats ";
            // 
            // TopHats
            // 
            this.TopHats.AutoSize = true;
            this.TopHats.BackColor = System.Drawing.Color.Black;
            this.TopHats.ForeColor = System.Drawing.Color.White;
            this.TopHats.Location = new System.Drawing.Point(40, 210);
            this.TopHats.Name = "TopHats";
            this.TopHats.Size = new System.Drawing.Size(210, 25);
            this.TopHats.TabIndex = 5;
            this.TopHats.Text = "Number of Top Hats ";
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(323, 120);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(50, 31);
            this.Textbox1.TabIndex = 6;
            // 
            // Textbox2
            // 
            this.Textbox2.Location = new System.Drawing.Point(323, 166);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(50, 31);
            this.Textbox2.TabIndex = 7;
            // 
            // Textbox3
            // 
            this.Textbox3.Location = new System.Drawing.Point(323, 210);
            this.Textbox3.Name = "Textbox3";
            this.Textbox3.Size = new System.Drawing.Size(50, 31);
            this.Textbox3.TabIndex = 8;
            // 
            // Totalbutton
            // 
            this.Totalbutton.BackColor = System.Drawing.Color.Black;
            this.Totalbutton.ForeColor = System.Drawing.Color.White;
            this.Totalbutton.Location = new System.Drawing.Point(95, 278);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(228, 58);
            this.Totalbutton.TabIndex = 9;
            this.Totalbutton.Text = "Calculate Totals ";
            this.Totalbutton.UseVisualStyleBackColor = false;
            this.Totalbutton.Click += new System.EventHandler(this.Totalbutton_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(40, 464);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(60, 25);
            this.Total.TabIndex = 10;
            this.Total.Text = "Total";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.ForeColor = System.Drawing.Color.White;
            this.Tax.Location = new System.Drawing.Point(40, 417);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(48, 25);
            this.Tax.TabIndex = 11;
            this.Tax.Text = "Tax";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.ForeColor = System.Drawing.Color.White;
            this.SubTotal.Location = new System.Drawing.Point(40, 370);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(121, 25);
            this.SubTotal.TabIndex = 12;
            this.SubTotal.Text = "Sub Totals ";
            // 
            // Tendered
            // 
            this.Tendered.AutoSize = true;
            this.Tendered.ForeColor = System.Drawing.Color.White;
            this.Tendered.Location = new System.Drawing.Point(40, 520);
            this.Tendered.Name = "Tendered";
            this.Tendered.Size = new System.Drawing.Size(110, 25);
            this.Tendered.TabIndex = 18;
            this.Tendered.Text = "Tendered ";
            // 
            // TenderedBox
            // 
            this.TenderedBox.Location = new System.Drawing.Point(180, 514);
            this.TenderedBox.Name = "TenderedBox";
            this.TenderedBox.Size = new System.Drawing.Size(100, 31);
            this.TenderedBox.TabIndex = 19;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Black;
            this.ChangeButton.ForeColor = System.Drawing.Color.White;
            this.ChangeButton.Location = new System.Drawing.Point(95, 571);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(228, 60);
            this.ChangeButton.TabIndex = 20;
            this.ChangeButton.Text = "Calculate Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.ForeColor = System.Drawing.Color.White;
            this.ChangeLabel.Location = new System.Drawing.Point(40, 644);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(87, 25);
            this.ChangeLabel.TabIndex = 21;
            this.ChangeLabel.Text = "Change";
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.BackColor = System.Drawing.Color.Black;
            this.ReceiptButton.Enabled = false;
            this.ReceiptButton.ForeColor = System.Drawing.Color.White;
            this.ReceiptButton.Location = new System.Drawing.Point(95, 688);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(228, 59);
            this.ReceiptButton.TabIndex = 26;
            this.ReceiptButton.Text = "Print Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = false;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.BackColor = System.Drawing.Color.Black;
            this.ReceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReceiptLabel.ForeColor = System.Drawing.Color.White;
            this.ReceiptLabel.Location = new System.Drawing.Point(399, 136);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(536, 519);
            this.ReceiptLabel.TabIndex = 27;
            // 
            // SubTotalsTextBox
            // 
            this.SubTotalsTextBox.BackColor = System.Drawing.Color.Black;
            this.SubTotalsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubTotalsTextBox.ForeColor = System.Drawing.Color.White;
            this.SubTotalsTextBox.Location = new System.Drawing.Point(180, 370);
            this.SubTotalsTextBox.Name = "SubTotalsTextBox";
            this.SubTotalsTextBox.Size = new System.Drawing.Size(100, 24);
            this.SubTotalsTextBox.TabIndex = 28;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.BackColor = System.Drawing.Color.Black;
            this.TaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaxTextBox.ForeColor = System.Drawing.Color.White;
            this.TaxTextBox.Location = new System.Drawing.Point(180, 411);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.Size = new System.Drawing.Size(100, 24);
            this.TaxTextBox.TabIndex = 29;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.Black;
            this.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalTextBox.ForeColor = System.Drawing.Color.White;
            this.TotalTextBox.Location = new System.Drawing.Point(180, 464);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 24);
            this.TotalTextBox.TabIndex = 30;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // ChangeBox
            // 
            this.ChangeBox.BackColor = System.Drawing.Color.Black;
            this.ChangeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeBox.ForeColor = System.Drawing.Color.White;
            this.ChangeBox.Location = new System.Drawing.Point(180, 641);
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(100, 24);
            this.ChangeBox.TabIndex = 31;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.Black;
            this.NewOrderButton.Enabled = false;
            this.NewOrderButton.ForeColor = System.Drawing.Color.White;
            this.NewOrderButton.Location = new System.Drawing.Point(557, 688);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(221, 59);
            this.NewOrderButton.TabIndex = 32;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(971, 759);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.ChangeBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.SubTotalsTextBox);
            this.Controls.Add(this.ReceiptLabel);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.TenderedBox);
            this.Controls.Add(this.Tendered);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Totalbutton);
            this.Controls.Add(this.Textbox3);
            this.Controls.Add(this.Textbox2);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.TopHats);
            this.Controls.Add(this.BeanieHats);
            this.Controls.Add(this.BaseballHatsLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RedBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label BaseballHatsLabel;
        private System.Windows.Forms.Label BeanieHats;
        private System.Windows.Forms.Label TopHats;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.TextBox Textbox2;
        private System.Windows.Forms.TextBox Textbox3;
        private System.Windows.Forms.Button Totalbutton;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label Tendered;
        private System.Windows.Forms.TextBox TenderedBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Label ReceiptLabel;
        private System.Windows.Forms.TextBox SubTotalsTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox ChangeBox;
        private System.Windows.Forms.Button NewOrderButton;
    }
}

