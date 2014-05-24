namespace XMLCreate
{
    partial class XMLOptionSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.version = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamewii = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.FormattingEnabled = true;
            this.version.Items.AddRange(new object[] {
            "1",
            "2"});
            this.version.Location = new System.Drawing.Point(174, 25);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(121, 21);
            this.version.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WiiDisc Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game ID";
            // 
            // gamewii
            // 
            this.gamewii.Location = new System.Drawing.Point(174, 66);
            this.gamewii.MaxLength = 4;
            this.gamewii.Name = "gamewii";
            this.gamewii.Size = new System.Drawing.Size(115, 20);
            this.gamewii.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.FormattingEnabled = true;
            this.amount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.amount.Location = new System.Drawing.Point(12, 25);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(153, 21);
            this.amount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount of Options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go to XML Creator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XMLOptionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.gamewii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.version);
            this.Name = "XMLOptionSet";
            this.Text = "XML Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox version;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox gamewii;
        public System.Windows.Forms.ComboBox amount;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
    }
}