namespace Weather
{
    partial class alertsForm
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
            this.statesListBox = new System.Windows.Forms.ListBox();
            this.countiesListBox = new System.Windows.Forms.ListBox();
            this.alertsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alertCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alertsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statesListBox
            // 
            this.statesListBox.FormattingEnabled = true;
            this.statesListBox.Location = new System.Drawing.Point(39, 29);
            this.statesListBox.Name = "statesListBox";
            this.statesListBox.Size = new System.Drawing.Size(221, 459);
            this.statesListBox.TabIndex = 0;
            this.statesListBox.SelectedIndexChanged += new System.EventHandler(this.statesListBox_SelectedIndexChanged);
            // 
            // countiesListBox
            // 
            this.countiesListBox.FormattingEnabled = true;
            this.countiesListBox.Location = new System.Drawing.Point(266, 29);
            this.countiesListBox.Name = "countiesListBox";
            this.countiesListBox.Size = new System.Drawing.Size(226, 459);
            this.countiesListBox.TabIndex = 1;
            this.countiesListBox.SelectedIndexChanged += new System.EventHandler(this.countiesListBox_SelectedIndexChanged);
            // 
            // alertsDataGridView
            // 
            this.alertsDataGridView.AllowUserToAddRows = false;
            this.alertsDataGridView.AllowUserToDeleteRows = false;
            this.alertsDataGridView.AllowUserToOrderColumns = true;
            this.alertsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.alertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertsDataGridView.Location = new System.Drawing.Point(498, 29);
            this.alertsDataGridView.MultiSelect = false;
            this.alertsDataGridView.Name = "alertsDataGridView";
            this.alertsDataGridView.ReadOnly = true;
            this.alertsDataGridView.Size = new System.Drawing.Size(997, 459);
            this.alertsDataGridView.TabIndex = 2;
            this.alertsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alertsDataGridView_CellDoubleClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Alerts:";
            // 
            // alertCountTextBox
            // 
            this.alertCountTextBox.Location = new System.Drawing.Point(564, 5);
            this.alertCountTextBox.Name = "alertCountTextBox";
            this.alertCountTextBox.ReadOnly = true;
            this.alertCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.alertCountTextBox.TabIndex = 5;
            // 
            // alertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 620);
            this.Controls.Add(this.alertCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alertsDataGridView);
            this.Controls.Add(this.countiesListBox);
            this.Controls.Add(this.statesListBox);
            this.Name = "alertsForm";
            this.Text = "Watches, Warnings, and Advisories";
            ((System.ComponentModel.ISupportInitialize)(this.alertsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox statesListBox;
        private System.Windows.Forms.ListBox countiesListBox;
        private System.Windows.Forms.DataGridView alertsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alertCountTextBox;
    }
}

