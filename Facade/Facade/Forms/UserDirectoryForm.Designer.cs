namespace Facade
{
    partial class UserDirectoryForm
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
            this.Prompt_Label = new System.Windows.Forms.Label();
            this.Radio_Groupbox = new System.Windows.Forms.GroupBox();
            this.eBook_RadioButton = new System.Windows.Forms.RadioButton();
            this.store_RadioButton = new System.Windows.Forms.RadioButton();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Radio_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prompt_Label
            // 
            this.Prompt_Label.AutoSize = true;
            this.Prompt_Label.Location = new System.Drawing.Point(21, 9);
            this.Prompt_Label.Name = "Prompt_Label";
            this.Prompt_Label.Size = new System.Drawing.Size(332, 13);
            this.Prompt_Label.TabIndex = 0;
            this.Prompt_Label.Text = "Would you like to go to the store or browse our collection of eBooks?";
            // 
            // Radio_Groupbox
            // 
            this.Radio_Groupbox.AutoSize = true;
            this.Radio_Groupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Radio_Groupbox.Controls.Add(this.eBook_RadioButton);
            this.Radio_Groupbox.Controls.Add(this.store_RadioButton);
            this.Radio_Groupbox.Location = new System.Drawing.Point(133, 34);
            this.Radio_Groupbox.Name = "Radio_Groupbox";
            this.Radio_Groupbox.Size = new System.Drawing.Size(96, 78);
            this.Radio_Groupbox.TabIndex = 1;
            this.Radio_Groupbox.TabStop = false;
            // 
            // eBook_RadioButton
            // 
            this.eBook_RadioButton.Location = new System.Drawing.Point(0, 42);
            this.eBook_RadioButton.Name = "eBook_RadioButton";
            this.eBook_RadioButton.Size = new System.Drawing.Size(90, 17);
            this.eBook_RadioButton.TabIndex = 1;
            this.eBook_RadioButton.TabStop = true;
            this.eBook_RadioButton.Text = "eBook";
            this.eBook_RadioButton.UseVisualStyleBackColor = true;
            // 
            // store_RadioButton
            // 
            this.store_RadioButton.Location = new System.Drawing.Point(0, 19);
            this.store_RadioButton.Name = "store_RadioButton";
            this.store_RadioButton.Size = new System.Drawing.Size(90, 17);
            this.store_RadioButton.TabIndex = 0;
            this.store_RadioButton.TabStop = true;
            this.store_RadioButton.Text = "Store";
            this.store_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(133, 119);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(96, 23);
            this.Accept_Button.TabIndex = 2;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // UserDirectoryForm
            // 
            this.AcceptButton = this.Accept_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 150);
            this.ControlBox = false;
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Radio_Groupbox);
            this.Controls.Add(this.Prompt_Label);
            this.Name = "UserDirectoryForm";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.UserDirectoryForm_Load);
            this.Radio_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prompt_Label;
        private System.Windows.Forms.GroupBox Radio_Groupbox;
        private System.Windows.Forms.RadioButton eBook_RadioButton;
        private System.Windows.Forms.RadioButton store_RadioButton;
        private System.Windows.Forms.Button Accept_Button;
    }
}