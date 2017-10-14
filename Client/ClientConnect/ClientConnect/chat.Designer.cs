namespace ClientConnect
{
    partial class chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.listView1 = new System.Windows.Forms.ListView();
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chatList = new System.Windows.Forms.ListBox();
            this.chatField = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameHeader});
            this.listView1.Location = new System.Drawing.Point(-1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username:";
            this.usernameHeader.Width = 120;
            // 
            // chatList
            // 
            this.chatList.BackColor = System.Drawing.Color.Black;
            this.chatList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chatList.FormattingEnabled = true;
            this.chatList.Items.AddRange(new object[] {
            "a"});
            this.chatList.Location = new System.Drawing.Point(-1, 0);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(363, 316);
            this.chatList.TabIndex = 1;
            this.chatList.SelectedIndexChanged += new System.EventHandler(this.chatList_SelectedIndexChanged);
            // 
            // chatField
            // 
            this.chatField.BackColor = System.Drawing.Color.Silver;
            this.chatField.Location = new System.Drawing.Point(-1, 313);
            this.chatField.Name = "chatField";
            this.chatField.Size = new System.Drawing.Size(275, 26);
            this.chatField.TabIndex = 2;
            this.chatField.Text = "";
            this.chatField.TextChanged += new System.EventHandler(this.chatField_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(274, 316);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(88, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 340);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatField);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chat";
            this.Text = "chat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.RichTextBox chatField;
        private System.Windows.Forms.Button sendButton;
    }
}