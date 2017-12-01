namespace InventoryTest
{
    partial class ShopForm
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
            this.shopBox = new System.Windows.Forms.ListBox();
            this.costBox = new System.Windows.Forms.ListBox();
            this.invCostBox = new System.Windows.Forms.ListBox();
            this.invBox = new System.Windows.Forms.ListBox();
            this.gilLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shopBox
            // 
            this.shopBox.FormattingEnabled = true;
            this.shopBox.Location = new System.Drawing.Point(12, 72);
            this.shopBox.Name = "shopBox";
            this.shopBox.Size = new System.Drawing.Size(120, 290);
            this.shopBox.TabIndex = 0;
            // 
            // costBox
            // 
            this.costBox.FormattingEnabled = true;
            this.costBox.Location = new System.Drawing.Point(138, 72);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(120, 290);
            this.costBox.TabIndex = 1;
            // 
            // invCostBox
            // 
            this.invCostBox.FormattingEnabled = true;
            this.invCostBox.Location = new System.Drawing.Point(527, 72);
            this.invCostBox.Name = "invCostBox";
            this.invCostBox.Size = new System.Drawing.Size(120, 290);
            this.invCostBox.TabIndex = 3;
            // 
            // invBox
            // 
            this.invBox.FormattingEnabled = true;
            this.invBox.Location = new System.Drawing.Point(401, 72);
            this.invBox.Name = "invBox";
            this.invBox.Size = new System.Drawing.Size(120, 290);
            this.invBox.TabIndex = 2;
            // 
            // gilLabel
            // 
            this.gilLabel.AutoSize = true;
            this.gilLabel.Location = new System.Drawing.Point(12, 9);
            this.gilLabel.Name = "gilLabel";
            this.gilLabel.Size = new System.Drawing.Size(19, 13);
            this.gilLabel.TabIndex = 4;
            this.gilLabel.Text = "Gil";
            this.gilLabel.Click += new System.EventHandler(this.gilLabel_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(75, 384);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(33, 20);
            this.amountBox.TabIndex = 5;
            this.amountBox.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.gilLabel);
            this.Controls.Add(this.invCostBox);
            this.Controls.Add(this.invBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.shopBox);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shopBox;
        private System.Windows.Forms.ListBox costBox;
        private System.Windows.Forms.ListBox invCostBox;
        private System.Windows.Forms.ListBox invBox;
        private System.Windows.Forms.Label gilLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button button1;
    }
}