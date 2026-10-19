namespace project_1
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.chkbreakfast = new System.Windows.Forms.CheckBox();
            this.details = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHight = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnumberNigth = new System.Windows.Forms.TextBox();
            this.txtnumberGuest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(72, 480);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(111, 42);
            this.Calculate.TabIndex = 16;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(273, 480);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 42);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(486, 480);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 42);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // chkbreakfast
            // 
            this.chkbreakfast.AutoSize = true;
            this.chkbreakfast.Location = new System.Drawing.Point(6, 38);
            this.chkbreakfast.Name = "chkbreakfast";
            this.chkbreakfast.Size = new System.Drawing.Size(281, 24);
            this.chkbreakfast.TabIndex = 19;
            this.chkbreakfast.Text = "Breakfast(10 per Guest per nights)";
            this.chkbreakfast.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.details.FormattingEnabled = true;
            this.details.ItemHeight = 20;
            this.details.Location = new System.Drawing.Point(631, 40);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(421, 424);
            this.details.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbHight);
            this.groupBox1.Location = new System.Drawing.Point(47, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(9, 51);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(97, 24);
            this.rbStandard.TabIndex = 2;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(167, 51);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(82, 24);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbHight
            // 
            this.rbHight.AutoSize = true;
            this.rbHight.Location = new System.Drawing.Point(306, 51);
            this.rbHight.Name = "rbHight";
            this.rbHight.Size = new System.Drawing.Size(69, 24);
            this.rbHight.TabIndex = 0;
            this.rbHight.TabStop = true;
            this.rbHight.Text = "hight";
            this.rbHight.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.chkbreakfast);
            this.groupBox2.Location = new System.Drawing.Point(72, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aditioanl options";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.txtage);
            this.groupBox3.Controls.Add(this.txtnumberNigth);
            this.groupBox3.Controls.Add(this.txtnumberGuest);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(27, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 201);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(169, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 26);
            this.txtname.TabIndex = 18;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(166, 62);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(186, 26);
            this.txtage.TabIndex = 17;
            // 
            // txtnumberNigth
            // 
            this.txtnumberNigth.Location = new System.Drawing.Point(169, 97);
            this.txtnumberNigth.Name = "txtnumberNigth";
            this.txtnumberNigth.Size = new System.Drawing.Size(183, 26);
            this.txtnumberNigth.TabIndex = 16;
            // 
            // txtnumberGuest
            // 
            this.txtnumberGuest.Location = new System.Drawing.Point(166, 137);
            this.txtnumberGuest.Name = "txtnumberGuest";
            this.txtnumberGuest.Size = new System.Drawing.Size(186, 26);
            this.txtnumberGuest.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Guest Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Guest Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of Nights:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Guest:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1093, 659);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.details);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Number of Nights :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox chkbreakfast;
        private System.Windows.Forms.ListBox details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnumberNigth;
        private System.Windows.Forms.TextBox txtnumberGuest;
        private System.Windows.Forms.TextBox txtname;
    }
}

