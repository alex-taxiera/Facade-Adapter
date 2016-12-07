namespace Facade_Adapter.Forms
{
    partial class AdminForm
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
            this.userLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.adminExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(49, 25);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(51, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Add User";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(202, 24);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(54, 13);
            this.stockLabel.TabIndex = 1;
            this.stockLabel.Text = "Set Stock";
            // 
            // stockButton
            // 
            this.stockButton.Location = new System.Drawing.Point(172, 93);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(75, 23);
            this.stockButton.TabIndex = 2;
            this.stockButton.Text = "Set Stock";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(25, 119);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "Add User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(24, 41);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 4;
            this.userBox.Text = "Username";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(24, 93);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 5;
            this.typeBox.Text = "User Type";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(24, 67);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 6;
            this.passBox.Text = "Password";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(172, 41);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 7;
            this.idBox.Text = "Product ID";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(172, 67);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 20);
            this.stockBox.TabIndex = 8;
            this.stockBox.Text = "Stock Number";
            // 
            // adminExitButton
            // 
            this.adminExitButton.Location = new System.Drawing.Point(188, 226);
            this.adminExitButton.Name = "adminExitButton";
            this.adminExitButton.Size = new System.Drawing.Size(75, 23);
            this.adminExitButton.TabIndex = 9;
            this.adminExitButton.Text = "Sign Out";
            this.adminExitButton.UseVisualStyleBackColor = true;
            this.adminExitButton.Click += new System.EventHandler(this.adminExitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.adminExitButton);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Button adminExitButton;
    }
}