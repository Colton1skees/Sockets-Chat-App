namespace ServerProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portField = new System.Windows.Forms.TextBox();
            this.ipField = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portField
            // 
            this.portField.Location = new System.Drawing.Point(12, 105);
            this.portField.Name = "portField";
            this.portField.Size = new System.Drawing.Size(230, 20);
            this.portField.TabIndex = 0;
            this.portField.TextChanged += new System.EventHandler(this.portField_TextChanged);
            // 
            // ipField
            // 
            this.ipField.Location = new System.Drawing.Point(12, 45);
            this.ipField.Name = "ipField";
            this.ipField.Size = new System.Drawing.Size(230, 20);
            this.ipField.TabIndex = 1;
            this.ipField.TextChanged += new System.EventHandler(this.ipField_TextChanged);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(111, 29);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP:";
            this.ipLabel.Click += new System.EventHandler(this.ipLabel_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(100, 89);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(40, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "PORT:";
            this.portLabel.Click += new System.EventHandler(this.portLabel_Click);
            // 
            // serverStartButton
            // 
            this.serverStartButton.Location = new System.Drawing.Point(81, 175);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(86, 23);
            this.serverStartButton.TabIndex = 4;
            this.serverStartButton.Text = "Start";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 235);
            this.Controls.Add(this.serverStartButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipField);
            this.Controls.Add(this.portField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portField;
        private System.Windows.Forms.TextBox ipField;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button serverStartButton;
    }
}

