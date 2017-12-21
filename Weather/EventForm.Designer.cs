namespace Weather
{
    partial class EventForm
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
            this.eventLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.instrctTextBox = new System.Windows.Forms.TextBox();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expiresTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.severityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Location = new System.Drawing.Point(56, 52);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(38, 13);
            this.eventLabel.TabIndex = 0;
            this.eventLabel.Text = "Event:";
            // 
            // descTextBox
            // 
            this.descTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descTextBox.Location = new System.Drawing.Point(100, 300);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.ReadOnly = true;
            this.descTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descTextBox.Size = new System.Drawing.Size(324, 250);
            this.descTextBox.TabIndex = 1;
            // 
            // instrctTextBox
            // 
            this.instrctTextBox.Location = new System.Drawing.Point(507, 300);
            this.instrctTextBox.Multiline = true;
            this.instrctTextBox.Name = "instrctTextBox";
            this.instrctTextBox.ReadOnly = true;
            this.instrctTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instrctTextBox.Size = new System.Drawing.Size(324, 250);
            this.instrctTextBox.TabIndex = 2;
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(100, 49);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.ReadOnly = true;
            this.eventTextBox.Size = new System.Drawing.Size(226, 20);
            this.eventTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expires:";
            // 
            // expiresTextBox
            // 
            this.expiresTextBox.Location = new System.Drawing.Point(100, 75);
            this.expiresTextBox.Name = "expiresTextBox";
            this.expiresTextBox.ReadOnly = true;
            this.expiresTextBox.Size = new System.Drawing.Size(226, 20);
            this.expiresTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // severityTextBox
            // 
            this.severityTextBox.Location = new System.Drawing.Point(100, 101);
            this.severityTextBox.Name = "severityTextBox";
            this.severityTextBox.ReadOnly = true;
            this.severityTextBox.Size = new System.Drawing.Size(226, 20);
            this.severityTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Severity:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.areaTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.senderTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.severityTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.expiresTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eventTextBox);
            this.groupBox1.Controls.Add(this.instrctTextBox);
            this.groupBox1.Controls.Add(this.descTextBox);
            this.groupBox1.Controls.Add(this.eventLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 681);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Alert";
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(100, 128);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.ReadOnly = true;
            this.senderTextBox.Size = new System.Drawing.Size(226, 20);
            this.senderTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sender:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(100, 154);
            this.areaTextBox.Multiline = true;
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.ReadOnly = true;
            this.areaTextBox.Size = new System.Drawing.Size(324, 140);
            this.areaTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Instruction:";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(965, 705);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EventForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox instrctTextBox;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expiresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox severityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox areaTextBox;
    }
}