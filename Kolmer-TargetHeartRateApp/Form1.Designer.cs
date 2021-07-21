namespace Kolmer_TargetHeartRateApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ageInput = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.activityInput = new System.Windows.Forms.ComboBox();
            this.displayTHRbutton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputView = new System.Windows.Forms.ListView();
            this.ageColumn = new System.Windows.Forms.ColumnHeader();
            this.mhrColumn = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.thrColumn = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(115, 33);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(119, 23);
            this.ageInput.TabIndex = 0;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(23, 36);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(86, 15);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Enter your age:";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(23, 83);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(77, 15);
            this.activityLabel.TabIndex = 2;
            this.activityLabel.Text = "Activity Type:";
            // 
            // activityInput
            // 
            this.activityInput.FormattingEnabled = true;
            this.activityInput.Items.AddRange(new object[] {
            "--Select an Activity--",
            "Running (Vigorous)",
            "Swimming (Vigorous)",
            "Walking (Moderate)",
            "Jogging (Moderate)",
            "Biking (Vigorous)",
            "Kayaking (Moderate)"});
            this.activityInput.Location = new System.Drawing.Point(113, 83);
            this.activityInput.Name = "activityInput";
            this.activityInput.Size = new System.Drawing.Size(142, 23);
            this.activityInput.TabIndex = 3;
            this.activityInput.Text = "--Select an Activity--";
            // 
            // displayTHRbutton
            // 
            this.displayTHRbutton.Location = new System.Drawing.Point(43, 143);
            this.displayTHRbutton.Name = "displayTHRbutton";
            this.displayTHRbutton.Size = new System.Drawing.Size(95, 25);
            this.displayTHRbutton.TabIndex = 4;
            this.displayTHRbutton.Text = "Display THR";
            this.displayTHRbutton.UseVisualStyleBackColor = true;
            this.displayTHRbutton.Click += new System.EventHandler(this.displayTHRButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 143);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 25);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 143);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 25);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputView
            // 
            this.outputView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.outputView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ageColumn,
            this.mhrColumn,
            this.columnHeader3,
            this.thrColumn});
            this.outputView.HideSelection = false;
            this.outputView.Location = new System.Drawing.Point(23, 174);
            this.outputView.Name = "outputView";
            this.outputView.Size = new System.Drawing.Size(544, 231);
            this.outputView.TabIndex = 5;
            this.outputView.UseCompatibleStateImageBehavior = false;
            this.outputView.View = System.Windows.Forms.View.Details;
            // 
            // ageColumn
            // 
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.Text = "Age";
            this.ageColumn.Width = 100;
            // 
            // mhrColumn
            // 
            this.mhrColumn.Name = "mhrColumn";
            this.mhrColumn.Text = "Max Heart Rate";
            this.mhrColumn.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "activityColumn ";
            this.columnHeader3.Text = "Activity Type";
            this.columnHeader3.Width = 150;
            // 
            // thrColumn
            // 
            this.thrColumn.Name = "thrColumn";
            this.thrColumn.Text = "Target Heart Rate";
            this.thrColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayTHRbutton);
            this.Controls.Add(this.activityInput);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Target Heart Rate (THR) Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.ComboBox activityInput;
        private System.Windows.Forms.Button displayTHRbutton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView outputView;
        private System.Windows.Forms.ColumnHeader ageCoulmn;
        private System.Windows.Forms.ColumnHeader mhrHeader;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader ageColumn;
        private System.Windows.Forms.ColumnHeader mhrColumn;
        private System.Windows.Forms.ColumnHeader thrColumn;
    }
}

