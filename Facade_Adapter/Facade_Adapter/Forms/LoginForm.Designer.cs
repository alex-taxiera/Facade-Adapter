namespace Facade_Adapter
{
    partial class LoginForm
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
            this.Title_label = new System.Windows.Forms.Label();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(42, 41);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(532, 37);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "[We need a name] Online Bookstore";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(221, 145);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(164, 20);
            this.Username_Textbox.TabIndex = 2;
            this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(221, 199);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(164, 20);
            this.Password_Textbox.TabIndex = 3;
            this.Password_Textbox.TextChanged += new System.EventHandler(this.Password_Textbox_TextChanged);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(218, 129);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(55, 13);
            this.Username_Label.TabIndex = 4;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(218, 183);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Password";
            // 
            // Login_Button
            // 
            this.Login_Button.AutoSize = true;
            this.Login_Button.Location = new System.Drawing.Point(264, 225);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 298);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.Title_label);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
    }
}