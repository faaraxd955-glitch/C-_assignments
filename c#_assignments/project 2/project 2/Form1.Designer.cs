namespace project_2
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
            this.AirlineTicketBookingSystem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.ListBox();
            this.TravelClass = new System.Windows.Forms.GroupBox();
            this.rdoBusiness = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoFirst = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.AddtionalOptions = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TravelClass.SuspendLayout();
            this.AddtionalOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirlineTicketBookingSystem
            // 
            this.AirlineTicketBookingSystem.AutoSize = true;
            this.AirlineTicketBookingSystem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AirlineTicketBookingSystem.Location = new System.Drawing.Point(199, 24);
            this.AirlineTicketBookingSystem.Name = "AirlineTicketBookingSystem";
            this.AirlineTicketBookingSystem.Size = new System.Drawing.Size(217, 20);
            this.AirlineTicketBookingSystem.TabIndex = 0;
            this.AirlineTicketBookingSystem.Text = "Airline Ticket Booking System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(45, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.Control;
            this.txtname.Location = new System.Drawing.Point(200, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 26);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBaggage
            // 
            this.txtBaggage.BackColor = System.Drawing.SystemColors.Control;
            this.txtBaggage.Location = new System.Drawing.Point(200, 150);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(253, 26);
            this.txtBaggage.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtAge.Location = new System.Drawing.Point(200, 72);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(248, 26);
            this.txtAge.TabIndex = 10;
            // 
            // txtTickets
            // 
            this.txtTickets.BackColor = System.Drawing.SystemColors.Control;
            this.txtTickets.Location = new System.Drawing.Point(200, 111);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(248, 26);
            this.txtTickets.TabIndex = 11;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(89, 526);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(101, 46);
            this.Calculate.TabIndex = 17;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(266, 531);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(96, 36);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(467, 531);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 34);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Details
            // 
            this.Details.FormattingEnabled = true;
            this.Details.ItemHeight = 20;
            this.Details.Location = new System.Drawing.Point(712, 43);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(479, 544);
            this.Details.TabIndex = 23;
            // 
            // TravelClass
            // 
            this.TravelClass.Controls.Add(this.rdoBusiness);
            this.TravelClass.Controls.Add(this.rdoNormal);
            this.TravelClass.Controls.Add(this.rdoFirst);
            this.TravelClass.Location = new System.Drawing.Point(38, 276);
            this.TravelClass.Name = "TravelClass";
            this.TravelClass.Size = new System.Drawing.Size(564, 118);
            this.TravelClass.TabIndex = 24;
            this.TravelClass.TabStop = false;
            this.TravelClass.Text = "Travel Class";
            // 
            // rdoBusiness
            // 
            this.rdoBusiness.AutoSize = true;
            this.rdoBusiness.Location = new System.Drawing.Point(412, 70);
            this.rdoBusiness.Name = "rdoBusiness";
            this.rdoBusiness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoBusiness.Size = new System.Drawing.Size(142, 24);
            this.rdoBusiness.TabIndex = 15;
            this.rdoBusiness.TabStop = true;
            this.rdoBusiness.Text = "Business Class";
            this.rdoBusiness.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(216, 70);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoNormal.Size = new System.Drawing.Size(127, 24);
            this.rdoNormal.TabIndex = 14;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal Class";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoFirst
            // 
            this.rdoFirst.AutoSize = true;
            this.rdoFirst.Location = new System.Drawing.Point(35, 70);
            this.rdoFirst.Name = "rdoFirst";
            this.rdoFirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoFirst.Size = new System.Drawing.Size(108, 24);
            this.rdoFirst.TabIndex = 13;
            this.rdoFirst.TabStop = true;
            this.rdoFirst.Text = "First Class";
            this.rdoFirst.UseVisualStyleBackColor = true;
            // 
            // AddtionalOptions
            // 
            this.AddtionalOptions.Controls.Add(this.chkInsurance);
            this.AddtionalOptions.Location = new System.Drawing.Point(38, 400);
            this.AddtionalOptions.Name = "AddtionalOptions";
            this.AddtionalOptions.Size = new System.Drawing.Size(564, 109);
            this.AddtionalOptions.TabIndex = 25;
            this.AddtionalOptions.TabStop = false;
            this.AddtionalOptions.Text = "Aditional Options";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(68, 62);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(291, 24);
            this.chkInsurance.TabIndex = 21;
            this.chkInsurance.Text = "Add Travel Insurance($25 per ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.txtBaggage);
            this.groupBox1.Location = new System.Drawing.Point(54, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 191);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Passenger Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Passenger Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number Of Tickets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baggage Weight(kg):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddtionalOptions);
            this.Controls.Add(this.TravelClass);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.AirlineTicketBookingSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TravelClass.ResumeLayout(false);
            this.TravelClass.PerformLayout();
            this.AddtionalOptions.ResumeLayout(false);
            this.AddtionalOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AirlineTicketBookingSystem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTickets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox Details;
        private System.Windows.Forms.GroupBox TravelClass;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RadioButton rdoBusiness;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoFirst;
        private System.Windows.Forms.GroupBox AddtionalOptions;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

