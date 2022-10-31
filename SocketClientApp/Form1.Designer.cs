namespace SocketClientApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.MainText = new System.Windows.Forms.TextBox();
            this.Members = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ConnectionLabel);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(767, 18);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionLabel.ForeColor = System.Drawing.Color.White;
            this.ConnectionLabel.Location = new System.Drawing.Point(15, 9);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(258, 37);
            this.ConnectionLabel.TabIndex = 0;
            this.ConnectionLabel.Text = "Socket Client ID: 0";
            this.ConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Send
            // 
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.Color.Lime;
            this.Send.Location = new System.Drawing.Point(648, 383);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(140, 55);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // TextInput
            // 
            this.TextInput.AcceptsTab = true;
            this.TextInput.BackColor = System.Drawing.Color.Black;
            this.TextInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextInput.Location = new System.Drawing.Point(12, 383);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(630, 55);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "Enter Message Here";
            this.TextInput.Enter += new System.EventHandler(this.TextInput_Enter);
            this.TextInput.Leave += new System.EventHandler(this.TextInput_Leave);
            // 
            // MainText
            // 
            this.MainText.BackColor = System.Drawing.Color.Black;
            this.MainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainText.Enabled = false;
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.ForeColor = System.Drawing.Color.White;
            this.MainText.Location = new System.Drawing.Point(12, 78);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.ReadOnly = true;
            this.MainText.Size = new System.Drawing.Size(630, 299);
            this.MainText.TabIndex = 4;
            this.MainText.Text = "Awaiting Connection To Server";
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.Black;
            this.Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.Color.White;
            this.Members.Location = new System.Drawing.Point(648, 78);
            this.Members.Multiline = true;
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(145, 299);
            this.Members.TabIndex = 5;
            this.Members.Text = "ID: 0 (You)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Socket Client ID: 0";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.TextBox Members;

        private System.Windows.Forms.TextBox MainText;

        private System.Windows.Forms.TextBox TextInput;

        private System.Windows.Forms.Button Send;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label ConnectionLabel;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}