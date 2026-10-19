namespace project_three
{
    partial class VehecleRentalManagement
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
            this.CustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfRentalDays = new System.Windows.Forms.Label();
            this.CustomerAge = new System.Windows.Forms.Label();
            this.CutomerInformation = new System.Windows.Forms.Label();
            this.VehicleType = new System.Windows.Forms.GroupBox();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.InsuranceOption = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Rental = new System.Windows.Forms.ListBox();
            this.CustomerInformation.SuspendLayout();
            this.VehicleType.SuspendLayout();
            this.InsuranceOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerInformation
            // 
            this.CustomerInformation.Controls.Add(this.txtexperience);
            this.CustomerInformation.Controls.Add(this.txtdays);
            this.CustomerInformation.Controls.Add(this.txtage);
            this.CustomerInformation.Controls.Add(this.txtname);
            this.CustomerInformation.Controls.Add(this.label4);
            this.CustomerInformation.Controls.Add(this.NumberOfRentalDays);
            this.CustomerInformation.Controls.Add(this.CustomerAge);
            this.CustomerInformation.Controls.Add(this.CutomerInformation);
            this.CustomerInformation.Location = new System.Drawing.Point(0, 0);
            this.CustomerInformation.Name = "CustomerInformation";
            this.CustomerInformation.Size = new System.Drawing.Size(539, 209);
            this.CustomerInformation.TabIndex = 0;
            this.CustomerInformation.TabStop = false;
            this.CustomerInformation.Text = "Customer Information";
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(245, 150);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(154, 26);
            this.txtexperience.TabIndex = 4;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(245, 119);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(154, 26);
            this.txtdays.TabIndex = 3;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(245, 82);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(154, 26);
            this.txtage.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(245, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(154, 26);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Years Of Driving Experience:";
            // 
            // NumberOfRentalDays
            // 
            this.NumberOfRentalDays.AutoSize = true;
            this.NumberOfRentalDays.Location = new System.Drawing.Point(28, 119);
            this.NumberOfRentalDays.Name = "NumberOfRentalDays";
            this.NumberOfRentalDays.Size = new System.Drawing.Size(174, 20);
            this.NumberOfRentalDays.TabIndex = 2;
            this.NumberOfRentalDays.Text = "Number Of rental Days:";
            // 
            // CustomerAge
            // 
            this.CustomerAge.AutoSize = true;
            this.CustomerAge.Location = new System.Drawing.Point(28, 82);
            this.CustomerAge.Name = "CustomerAge";
            this.CustomerAge.Size = new System.Drawing.Size(115, 20);
            this.CustomerAge.TabIndex = 1;
            this.CustomerAge.Text = "Customer Age:";
            // 
            // CutomerInformation
            // 
            this.CutomerInformation.AutoSize = true;
            this.CutomerInformation.Location = new System.Drawing.Point(28, 39);
            this.CutomerInformation.Name = "CutomerInformation";
            this.CutomerInformation.Size = new System.Drawing.Size(128, 20);
            this.CutomerInformation.TabIndex = 0;
            this.CutomerInformation.Text = "Customer Name:";
            // 
            // VehicleType
            // 
            this.VehicleType.Controls.Add(this.rdoluxury);
            this.VehicleType.Controls.Add(this.rdosuv);
            this.VehicleType.Controls.Add(this.rdoeconomy);
            this.VehicleType.Location = new System.Drawing.Point(32, 227);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(507, 138);
            this.VehicleType.TabIndex = 1;
            this.VehicleType.TabStop = false;
            this.VehicleType.Text = "Veheicle Type";
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Location = new System.Drawing.Point(373, 74);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(80, 24);
            this.rdoluxury.TabIndex = 2;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Location = new System.Drawing.Point(192, 74);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(68, 24);
            this.rdosuv.TabIndex = 1;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Location = new System.Drawing.Point(24, 74);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(100, 24);
            this.rdoeconomy.TabIndex = 0;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // InsuranceOption
            // 
            this.InsuranceOption.Controls.Add(this.chkinsurance);
            this.InsuranceOption.Location = new System.Drawing.Point(32, 371);
            this.InsuranceOption.Name = "InsuranceOption";
            this.InsuranceOption.Size = new System.Drawing.Size(507, 84);
            this.InsuranceOption.TabIndex = 2;
            this.InsuranceOption.TabStop = false;
            this.InsuranceOption.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Location = new System.Drawing.Point(24, 37);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(232, 24);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(197, 487);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(110, 36);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(427, 487);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 36);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(630, 487);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 36);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Rental
            // 
            this.Rental.FormattingEnabled = true;
            this.Rental.ItemHeight = 20;
            this.Rental.Location = new System.Drawing.Point(584, 25);
            this.Rental.Name = "Rental";
            this.Rental.Size = new System.Drawing.Size(352, 424);
            this.Rental.TabIndex = 5;
            // 
            // VehecleRentalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 570);
            this.Controls.Add(this.Rental);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.InsuranceOption);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.CustomerInformation);
            this.Name = "VehecleRentalManagement";
            this.Text = "vehicle Rental Management";
            this.Load += new System.EventHandler(this.VehecleRentalManagement_Load);
            this.CustomerInformation.ResumeLayout(false);
            this.CustomerInformation.PerformLayout();
            this.VehicleType.ResumeLayout(false);
            this.VehicleType.PerformLayout();
            this.InsuranceOption.ResumeLayout(false);
            this.InsuranceOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NumberOfRentalDays;
        private System.Windows.Forms.Label CustomerAge;
        private System.Windows.Forms.Label CutomerInformation;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox VehicleType;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.GroupBox InsuranceOption;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox Rental;
    }
}

