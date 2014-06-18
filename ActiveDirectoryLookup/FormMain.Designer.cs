namespace ActiveDirectoryLookup
{
    partial class FormMain
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
            this.searchButton = new System.Windows.Forms.Button();
            this.entryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.recordsFoundLabel = new System.Windows.Forms.Label();
            this.numOfRecordsFoundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(369, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // entryBox
            // 
            this.entryBox.Location = new System.Drawing.Point(165, 10);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(195, 20);
            this.entryBox.TabIndex = 0;
            this.entryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Username Here:";
            // 
            // displayBox
            // 
            this.displayBox.AcceptsReturn = true;
            this.displayBox.AcceptsTab = true;
            this.displayBox.AllowDrop = true;
            this.displayBox.CausesValidation = false;
            this.displayBox.Location = new System.Drawing.Point(15, 41);
            this.displayBox.MaxLength = 999999999;
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayBox.Size = new System.Drawing.Size(1100, 481);
            this.displayBox.TabIndex = 3;
            this.displayBox.WordWrap = false;
            // 
            // recordsFoundLabel
            // 
            this.recordsFoundLabel.AutoSize = true;
            this.recordsFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsFoundLabel.Location = new System.Drawing.Point(517, 11);
            this.recordsFoundLabel.Name = "recordsFoundLabel";
            this.recordsFoundLabel.Size = new System.Drawing.Size(109, 17);
            this.recordsFoundLabel.TabIndex = 4;
            this.recordsFoundLabel.Text = "Records Found:";
            // 
            // numOfRecordsFoundLabel
            // 
            this.numOfRecordsFoundLabel.AutoSize = true;
            this.numOfRecordsFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRecordsFoundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numOfRecordsFoundLabel.Location = new System.Drawing.Point(628, 11);
            this.numOfRecordsFoundLabel.Name = "numOfRecordsFoundLabel";
            this.numOfRecordsFoundLabel.Size = new System.Drawing.Size(16, 17);
            this.numOfRecordsFoundLabel.TabIndex = 5;
            this.numOfRecordsFoundLabel.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 534);
            this.Controls.Add(this.numOfRecordsFoundLabel);
            this.Controls.Add(this.recordsFoundLabel);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryBox);
            this.Controls.Add(this.searchButton);
            this.Name = "FormMain";
            this.Text = "AD Lookup";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox entryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Label recordsFoundLabel;
        private System.Windows.Forms.Label numOfRecordsFoundLabel;
    }
}

