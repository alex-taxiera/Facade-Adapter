namespace Facade
{
    partial class BookstoreForm
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
            this.checkoutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cartButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.noCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(400, 444);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(75, 23);
            this.checkoutButton.TabIndex = 0;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(599, 423);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 23);
            this.cartButton.TabIndex = 2;
            this.cartButton.Text = "Show Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(82, 446);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "Full Name";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(188, 446);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 4;
            this.addressBox.Text = "Full Address";
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(294, 446);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(100, 20);
            this.cardBox.TabIndex = 5;
            this.cardBox.Text = "Card Number";
            // 
            // noCartButton
            // 
            this.noCartButton.Location = new System.Drawing.Point(599, 452);
            this.noCartButton.Name = "noCartButton";
            this.noCartButton.Size = new System.Drawing.Size(75, 23);
            this.noCartButton.TabIndex = 6;
            this.noCartButton.Text = "Unshow";
            this.noCartButton.UseVisualStyleBackColor = true;
            this.noCartButton.Click += new System.EventHandler(this.noCartButton_Click);
            // 
            // BookstoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 487);
            this.Controls.Add(this.noCartButton);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkoutButton);
            this.Name = "BookstoreForm";
            this.Text = "BookstoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Button noCartButton;
    }
}