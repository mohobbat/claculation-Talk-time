namespace Calculating_Talk_time
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showTalkTimeabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "select operator";
            // 
            // showTalkTimeabel
            // 
            this.showTalkTimeabel.AutoSize = true;
            this.showTalkTimeabel.Location = new System.Drawing.Point(31, 263);
            this.showTalkTimeabel.Name = "showTalkTimeabel";
            this.showTalkTimeabel.Size = new System.Drawing.Size(53, 13);
            this.showTalkTimeabel.TabIndex = 3;
            this.showTalkTimeabel.Text = "Talk time:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(160, 21);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(123, 20);
            this.balanceTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(143, 182);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "prepaid",
            "postpaid"});
            this.TypeComboBox.Location = new System.Drawing.Point(162, 68);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 6;
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "GP",
            "BL"});
            this.operatorComboBox.Location = new System.Drawing.Point(160, 109);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.operatorComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 313);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.showTalkTimeabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Talk time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label showTalkTimeabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox operatorComboBox;
    }
}

