
using System;

namespace SilverWorkJsonLoader
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Maximum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Median = new System.Windows.Forms.TextBox();
            this.Average = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LAS_Maximum = new System.Windows.Forms.TextBox();
            this.LAS_Minimum = new System.Windows.Forms.TextBox();
            this.LAS_Median = new System.Windows.Forms.TextBox();
            this.LAS_Average = new System.Windows.Forms.TextBox();
            this.LAS_Sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IRS_Maximum = new System.Windows.Forms.TextBox();
            this.IRS_Minimum = new System.Windows.Forms.TextBox();
            this.IRS_Median = new System.Windows.Forms.TextBox();
            this.IRS_Average = new System.Windows.Forms.TextBox();
            this.IRS_Sum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SelectSummary = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StateSelector = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.StateMaximum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.StateMinimum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.StateMedian = new System.Windows.Forms.TextBox();
            this.StateAverage = new System.Windows.Forms.TextBox();
            this.StateSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveSummary = new System.Windows.Forms.Button();
            this.SaveState = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Maximum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Minimum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Median);
            this.groupBox1.Controls.Add(this.Average);
            this.groupBox1.Controls.Add(this.Sum);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Appraised Amount Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minimum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average";
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(67, 124);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(115, 20);
            this.Maximum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Median";
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(67, 96);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(115, 20);
            this.Minimum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sum";
            // 
            // Median
            // 
            this.Median.Location = new System.Drawing.Point(67, 71);
            this.Median.Name = "Median";
            this.Median.Size = new System.Drawing.Size(115, 20);
            this.Median.TabIndex = 3;
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(67, 44);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(115, 20);
            this.Average.TabIndex = 3;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(67, 19);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(115, 20);
            this.Sum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LAS_Maximum);
            this.groupBox2.Controls.Add(this.LAS_Minimum);
            this.groupBox2.Controls.Add(this.LAS_Median);
            this.groupBox2.Controls.Add(this.LAS_Average);
            this.groupBox2.Controls.Add(this.LAS_Sum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(233, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Amount Summary";
            // 
            // LAS_Maximum
            // 
            this.LAS_Maximum.Location = new System.Drawing.Point(67, 124);
            this.LAS_Maximum.Name = "LAS_Maximum";
            this.LAS_Maximum.Size = new System.Drawing.Size(115, 20);
            this.LAS_Maximum.TabIndex = 14;
            // 
            // LAS_Minimum
            // 
            this.LAS_Minimum.Location = new System.Drawing.Point(67, 96);
            this.LAS_Minimum.Name = "LAS_Minimum";
            this.LAS_Minimum.Size = new System.Drawing.Size(115, 20);
            this.LAS_Minimum.TabIndex = 15;
            // 
            // LAS_Median
            // 
            this.LAS_Median.Location = new System.Drawing.Point(67, 71);
            this.LAS_Median.Name = "LAS_Median";
            this.LAS_Median.Size = new System.Drawing.Size(115, 20);
            this.LAS_Median.TabIndex = 12;
            // 
            // LAS_Average
            // 
            this.LAS_Average.Location = new System.Drawing.Point(67, 44);
            this.LAS_Average.Name = "LAS_Average";
            this.LAS_Average.Size = new System.Drawing.Size(115, 20);
            this.LAS_Average.TabIndex = 13;
            // 
            // LAS_Sum
            // 
            this.LAS_Sum.Location = new System.Drawing.Point(67, 19);
            this.LAS_Sum.Name = "LAS_Sum";
            this.LAS_Sum.Size = new System.Drawing.Size(115, 20);
            this.LAS_Sum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Maximum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Average";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Median";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IRS_Maximum);
            this.groupBox3.Controls.Add(this.IRS_Minimum);
            this.groupBox3.Controls.Add(this.IRS_Median);
            this.groupBox3.Controls.Add(this.IRS_Average);
            this.groupBox3.Controls.Add(this.IRS_Sum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(425, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "InterestRateSummary";
            // 
            // IRS_Maximum
            // 
            this.IRS_Maximum.Location = new System.Drawing.Point(67, 124);
            this.IRS_Maximum.Name = "IRS_Maximum";
            this.IRS_Maximum.Size = new System.Drawing.Size(115, 20);
            this.IRS_Maximum.TabIndex = 14;
            // 
            // IRS_Minimum
            // 
            this.IRS_Minimum.Location = new System.Drawing.Point(67, 96);
            this.IRS_Minimum.Name = "IRS_Minimum";
            this.IRS_Minimum.Size = new System.Drawing.Size(115, 20);
            this.IRS_Minimum.TabIndex = 15;
            // 
            // IRS_Median
            // 
            this.IRS_Median.Location = new System.Drawing.Point(67, 71);
            this.IRS_Median.Name = "IRS_Median";
            this.IRS_Median.Size = new System.Drawing.Size(115, 20);
            this.IRS_Median.TabIndex = 12;
            // 
            // IRS_Average
            // 
            this.IRS_Average.Location = new System.Drawing.Point(67, 44);
            this.IRS_Average.Name = "IRS_Average";
            this.IRS_Average.Size = new System.Drawing.Size(115, 20);
            this.IRS_Average.TabIndex = 13;
            // 
            // IRS_Sum
            // 
            this.IRS_Sum.Location = new System.Drawing.Point(67, 19);
            this.IRS_Sum.Name = "IRS_Sum";
            this.IRS_Sum.Size = new System.Drawing.Size(115, 20);
            this.IRS_Sum.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Minimum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Maximum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Average";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Median";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Sum";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SelectSummary);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.StateSelector);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.StateMaximum);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.StateMinimum);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.StateMedian);
            this.groupBox4.Controls.Add(this.StateAverage);
            this.groupBox4.Controls.Add(this.StateSum);
            this.groupBox4.Location = new System.Drawing.Point(617, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 215);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subject Appraised Amount Summary";
            // 
            // SelectSummary
            // 
            this.SelectSummary.Enabled = false;
            this.SelectSummary.FormattingEnabled = true;
            this.SelectSummary.Location = new System.Drawing.Point(10, 43);
            this.SelectSummary.Name = "SelectSummary";
            this.SelectSummary.Size = new System.Drawing.Size(171, 21);
            this.SelectSummary.TabIndex = 12;
            this.SelectSummary.SelectedIndexChanged += new System.EventHandler(this.SelectSummary_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Minimum";
            // 
            // StateSelector
            // 
            this.StateSelector.Enabled = false;
            this.StateSelector.FormattingEnabled = true;
            this.StateSelector.Location = new System.Drawing.Point(77, 15);
            this.StateSelector.Name = "StateSelector";
            this.StateSelector.Size = new System.Drawing.Size(104, 21);
            this.StateSelector.TabIndex = 5;
            this.StateSelector.SelectedIndexChanged += new System.EventHandler(this.StateSelector_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Select a state";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Maximum";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Average";
            // 
            // StateMaximum
            // 
            this.StateMaximum.Location = new System.Drawing.Point(66, 188);
            this.StateMaximum.Name = "StateMaximum";
            this.StateMaximum.Size = new System.Drawing.Size(115, 20);
            this.StateMaximum.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Median";
            // 
            // StateMinimum
            // 
            this.StateMinimum.Location = new System.Drawing.Point(66, 160);
            this.StateMinimum.Name = "StateMinimum";
            this.StateMinimum.Size = new System.Drawing.Size(115, 20);
            this.StateMinimum.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Sum";
            // 
            // StateMedian
            // 
            this.StateMedian.Location = new System.Drawing.Point(66, 135);
            this.StateMedian.Name = "StateMedian";
            this.StateMedian.Size = new System.Drawing.Size(115, 20);
            this.StateMedian.TabIndex = 3;
            // 
            // StateAverage
            // 
            this.StateAverage.Location = new System.Drawing.Point(66, 108);
            this.StateAverage.Name = "StateAverage";
            this.StateAverage.Size = new System.Drawing.Size(115, 20);
            this.StateAverage.TabIndex = 3;
            // 
            // StateSum
            // 
            this.StateSum.Location = new System.Drawing.Point(66, 83);
            this.StateSum.Name = "StateSum";
            this.StateSum.Size = new System.Drawing.Size(115, 20);
            this.StateSum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Extract Data From JSON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ImportJson_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Form_Click);
            // 
            // SaveSummary
            // 
            this.SaveSummary.Enabled = false;
            this.SaveSummary.Location = new System.Drawing.Point(425, 177);
            this.SaveSummary.Name = "SaveSummary";
            this.SaveSummary.Size = new System.Drawing.Size(182, 20);
            this.SaveSummary.TabIndex = 8;
            this.SaveSummary.Text = "Save Summary Json As";
            this.SaveSummary.UseVisualStyleBackColor = true;
            this.SaveSummary.Click += new System.EventHandler(this.SaveSummaryAs_Click);
            // 
            // SaveState
            // 
            this.SaveState.Enabled = false;
            this.SaveState.Location = new System.Drawing.Point(425, 198);
            this.SaveState.Name = "SaveState";
            this.SaveState.Size = new System.Drawing.Size(182, 20);
            this.SaveState.TabIndex = 9;
            this.SaveState.Text = "Save State Json As";
            this.SaveState.UseVisualStyleBackColor = true;
            this.SaveState.Click += new System.EventHandler(this.SaveStateAs_Click);
            // 
            // button3
            // 
            this.SaveAll.Enabled = false;
            this.SaveAll.Location = new System.Drawing.Point(425, 231);
            this.SaveAll.Name = "button3";
            this.SaveAll.Size = new System.Drawing.Size(142, 20);
            this.SaveAll.TabIndex = 10;
            this.SaveAll.Text = "Save All Json";
            this.SaveAll.UseVisualStyleBackColor = true;
            this.SaveAll.Click += new System.EventHandler(this.SaveFiles);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 263);
            this.Controls.Add(this.SaveAll);
            this.Controls.Add(this.SaveState);
            this.Controls.Add(this.SaveSummary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Silverworks Json loan Extractor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Maximum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Minimum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Median;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LAS_Maximum;
        private System.Windows.Forms.TextBox LAS_Minimum;
        private System.Windows.Forms.TextBox LAS_Median;
        private System.Windows.Forms.TextBox LAS_Average;
        private System.Windows.Forms.TextBox LAS_Sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox IRS_Maximum;
        private System.Windows.Forms.TextBox IRS_Minimum;
        private System.Windows.Forms.TextBox IRS_Median;
        private System.Windows.Forms.TextBox IRS_Average;
        private System.Windows.Forms.TextBox IRS_Sum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox StateSelector;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox StateMaximum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox StateMinimum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox StateMedian;
        private System.Windows.Forms.TextBox StateAverage;
        private System.Windows.Forms.TextBox StateSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox SelectSummary;
        private System.Windows.Forms.Button SaveSummary;
        private System.Windows.Forms.Button SaveState;
        private System.Windows.Forms.Button SaveAll;
    }
}

