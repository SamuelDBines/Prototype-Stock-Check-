namespace CounterApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reportPage = new System.Windows.Forms.TabPage();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.checkedButton = new System.Windows.Forms.CheckBox();
            this.disposedButton = new System.Windows.Forms.CheckBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.reportGroup = new System.Windows.Forms.GroupBox();
            this.reasonBox = new System.Windows.Forms.RichTextBox();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.missingButton = new System.Windows.Forms.CheckBox();
            this.badButton = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockBox = new System.Windows.Forms.RichTextBox();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.showField = new System.Windows.Forms.RichTextBox();
            this.disposed = new System.Windows.Forms.CheckBox();
            this.brokenButton = new System.Windows.Forms.CheckBox();
            this.stockButton = new System.Windows.Forms.CheckBox();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.reportPage.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.reportGroup.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.searchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportPage);
            this.tabControl1.Controls.Add(this.stockPage);
            this.tabControl1.Controls.Add(this.searchPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 406);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabChangeControl);
            // 
            // reportPage
            // 
            this.reportPage.Controls.Add(this.resultGroup);
            this.reportPage.Controls.Add(this.reportGroup);
            this.reportPage.Location = new System.Drawing.Point(4, 22);
            this.reportPage.Name = "reportPage";
            this.reportPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportPage.Size = new System.Drawing.Size(310, 380);
            this.reportPage.TabIndex = 0;
            this.reportPage.Text = "Report";
            this.reportPage.UseVisualStyleBackColor = true;
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.checkedButton);
            this.resultGroup.Controls.Add(this.disposedButton);
            this.resultGroup.Controls.Add(this.resultBox);
            this.resultGroup.Location = new System.Drawing.Point(3, 227);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(301, 147);
            this.resultGroup.TabIndex = 3;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Result";
            // 
            // checkedButton
            // 
            this.checkedButton.AutoSize = true;
            this.checkedButton.Location = new System.Drawing.Point(215, 123);
            this.checkedButton.Name = "checkedButton";
            this.checkedButton.Size = new System.Drawing.Size(69, 17);
            this.checkedButton.TabIndex = 3;
            this.checkedButton.Text = "Checked";
            this.checkedButton.UseVisualStyleBackColor = true;
            this.checkedButton.CheckedChanged += new System.EventHandler(this.checkedButton_CheckedChanged);
            // 
            // disposedButton
            // 
            this.disposedButton.AutoSize = true;
            this.disposedButton.Location = new System.Drawing.Point(6, 123);
            this.disposedButton.Name = "disposedButton";
            this.disposedButton.Size = new System.Drawing.Size(86, 17);
            this.disposedButton.TabIndex = 2;
            this.disposedButton.Text = "Dispose item";
            this.disposedButton.UseVisualStyleBackColor = true;
            this.disposedButton.CheckedChanged += new System.EventHandler(this.disposedButton_CheckedChanged);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(3, 21);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(292, 96);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "";
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // reportGroup
            // 
            this.reportGroup.Controls.Add(this.reasonBox);
            this.reportGroup.Location = new System.Drawing.Point(3, 6);
            this.reportGroup.Name = "reportGroup";
            this.reportGroup.Size = new System.Drawing.Size(301, 215);
            this.reportGroup.TabIndex = 2;
            this.reportGroup.TabStop = false;
            this.reportGroup.Text = "Reason";
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(3, 21);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(292, 188);
            this.reasonBox.TabIndex = 1;
            this.reasonBox.Text = "";
            this.reasonBox.TextChanged += new System.EventHandler(this.reasonBox_TextChanged);
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.groupBox4);
            this.stockPage.Controls.Add(this.groupBox3);
            this.stockPage.Controls.Add(this.groupBox2);
            this.stockPage.Controls.Add(this.groupBox1);
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(310, 380);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Stock Check";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.locationBox);
            this.groupBox4.Location = new System.Drawing.Point(9, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 51);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Location";
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(7, 20);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(279, 20);
            this.locationBox.TabIndex = 0;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemNameBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Name";
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(7, 20);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(279, 20);
            this.itemNameBox.TabIndex = 0;
            this.itemNameBox.TextChanged += new System.EventHandler(this.itemNameBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.missingButton);
            this.groupBox2.Controls.Add(this.badButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condition";
            // 
            // missingButton
            // 
            this.missingButton.AutoSize = true;
            this.missingButton.Location = new System.Drawing.Point(7, 42);
            this.missingButton.Name = "missingButton";
            this.missingButton.Size = new System.Drawing.Size(117, 17);
            this.missingButton.TabIndex = 2;
            this.missingButton.Text = "Missing component";
            this.missingButton.UseVisualStyleBackColor = true;
            this.missingButton.CheckedChanged += new System.EventHandler(this.missingButton_CheckedChanged);
            // 
            // badButton
            // 
            this.badButton.AutoSize = true;
            this.badButton.Location = new System.Drawing.Point(7, 19);
            this.badButton.Name = "badButton";
            this.badButton.Size = new System.Drawing.Size(45, 17);
            this.badButton.TabIndex = 1;
            this.badButton.Text = "Bad";
            this.badButton.UseVisualStyleBackColor = true;
            this.badButton.CheckedChanged += new System.EventHandler(this.badButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(6, 19);
            this.stockBox.Name = "stockBox";
            this.stockBox.ReadOnly = true;
            this.stockBox.Size = new System.Drawing.Size(292, 158);
            this.stockBox.TabIndex = 0;
            this.stockBox.Text = "";
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.showField);
            this.searchPage.Controls.Add(this.disposed);
            this.searchPage.Controls.Add(this.brokenButton);
            this.searchPage.Controls.Add(this.stockButton);
            this.searchPage.Location = new System.Drawing.Point(4, 22);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(310, 380);
            this.searchPage.TabIndex = 3;
            this.searchPage.Text = "Search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // showField
            // 
            this.showField.Location = new System.Drawing.Point(3, 84);
            this.showField.Name = "showField";
            this.showField.ReadOnly = true;
            this.showField.Size = new System.Drawing.Size(304, 293);
            this.showField.TabIndex = 3;
            this.showField.Text = "";
            // 
            // disposed
            // 
            this.disposed.AutoSize = true;
            this.disposed.Location = new System.Drawing.Point(3, 3);
            this.disposed.Name = "disposed";
            this.disposed.Size = new System.Drawing.Size(101, 17);
            this.disposed.TabIndex = 2;
            this.disposed.Text = "Disposed Stock";
            this.disposed.UseVisualStyleBackColor = true;
            this.disposed.CheckedChanged += new System.EventHandler(this.disposed_CheckedChanged);
            // 
            // brokenButton
            // 
            this.brokenButton.AutoSize = true;
            this.brokenButton.Location = new System.Drawing.Point(3, 26);
            this.brokenButton.Name = "brokenButton";
            this.brokenButton.Size = new System.Drawing.Size(91, 17);
            this.brokenButton.TabIndex = 1;
            this.brokenButton.Text = "Broken Stock";
            this.brokenButton.UseVisualStyleBackColor = true;
            this.brokenButton.CheckedChanged += new System.EventHandler(this.brokenButton_CheckedChanged);
            // 
            // stockButton
            // 
            this.stockButton.AutoSize = true;
            this.stockButton.Location = new System.Drawing.Point(3, 49);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(97, 17);
            this.stockButton.TabIndex = 0;
            this.stockButton.Text = "Working Stock";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.CheckedChanged += new System.EventHandler(this.stockButton_CheckedChanged);
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(73, 12);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(257, 20);
            this.itemBox.TabIndex = 1;
            this.itemBox.TextChanged += new System.EventHandler(this.itemBox_TextChanged);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(13, 15);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(54, 13);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "Item code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 454);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.reportPage.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.reportGroup.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage reportPage;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.CheckBox disposedButton;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.GroupBox reportGroup;
        private System.Windows.Forms.RichTextBox reasonBox;
        private System.Windows.Forms.RichTextBox stockBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox missingButton;
        private System.Windows.Forms.CheckBox badButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.RichTextBox showField;
        private System.Windows.Forms.CheckBox disposed;
        private System.Windows.Forms.CheckBox brokenButton;
        private System.Windows.Forms.CheckBox stockButton;
        private System.Windows.Forms.CheckBox checkedButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox locationBox;
    }
}

