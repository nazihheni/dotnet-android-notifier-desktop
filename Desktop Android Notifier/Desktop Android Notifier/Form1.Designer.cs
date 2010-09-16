namespace Desktop_Android_Notifier
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
            this.button1 = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.batteryButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.callTextBox = new System.Windows.Forms.TextBox();
            this.batteryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Notify!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(12, 12);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(88, 37);
            this.messageButton.TabIndex = 1;
            this.messageButton.Text = "TXT Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(12, 55);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(88, 37);
            this.callButton.TabIndex = 2;
            this.callButton.Text = "Phone Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // batteryButton
            // 
            this.batteryButton.Location = new System.Drawing.Point(12, 98);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(88, 37);
            this.batteryButton.TabIndex = 3;
            this.batteryButton.Text = "Battery Level";
            this.batteryButton.UseVisualStyleBackColor = true;
            this.batteryButton.Click += new System.EventHandler(this.batteryButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(146, 21);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(126, 20);
            this.messageTextBox.TabIndex = 4;
            // 
            // callTextBox
            // 
            this.callTextBox.Location = new System.Drawing.Point(146, 64);
            this.callTextBox.Name = "callTextBox";
            this.callTextBox.Size = new System.Drawing.Size(126, 20);
            this.callTextBox.TabIndex = 5;
            // 
            // batteryTextBox
            // 
            this.batteryTextBox.Location = new System.Drawing.Point(146, 107);
            this.batteryTextBox.Name = "batteryTextBox";
            this.batteryTextBox.Size = new System.Drawing.Size(126, 20);
            this.batteryTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.batteryTextBox);
            this.Controls.Add(this.callTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.batteryButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button batteryButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox callTextBox;
        private System.Windows.Forms.TextBox batteryTextBox;
    }
}

