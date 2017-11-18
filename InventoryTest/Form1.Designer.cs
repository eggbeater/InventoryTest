namespace InventoryTest
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
            this.allItemsBox = new System.Windows.Forms.ListBox();
            this.currentItemsBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.testButton2 = new System.Windows.Forms.Button();
            this.add256Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allItemsBox
            // 
            this.allItemsBox.FormattingEnabled = true;
            this.allItemsBox.Location = new System.Drawing.Point(13, 32);
            this.allItemsBox.Name = "allItemsBox";
            this.allItemsBox.Size = new System.Drawing.Size(120, 147);
            this.allItemsBox.TabIndex = 0;
            // 
            // currentItemsBox
            // 
            this.currentItemsBox.FormattingEnabled = true;
            this.currentItemsBox.Location = new System.Drawing.Point(447, 32);
            this.currentItemsBox.Name = "currentItemsBox";
            this.currentItemsBox.Size = new System.Drawing.Size(120, 147);
            this.currentItemsBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(38, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(460, 207);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete 1";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(38, 245);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print Inv";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(38, 283);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Test Swap";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.AcceptsReturn = true;
            this.inputBox.AllowDrop = true;
            this.inputBox.Location = new System.Drawing.Point(38, 371);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(453, 20);
            this.inputBox.TabIndex = 6;
            this.inputBox.Text = "Type function here";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(38, 439);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(453, 96);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // testButton2
            // 
            this.testButton2.Location = new System.Drawing.Point(38, 321);
            this.testButton2.Name = "testButton2";
            this.testButton2.Size = new System.Drawing.Size(75, 23);
            this.testButton2.TabIndex = 8;
            this.testButton2.Text = "Sort TEst";
            this.testButton2.UseVisualStyleBackColor = true;
            this.testButton2.Click += new System.EventHandler(this.testButton2_Click);
            // 
            // add256Button
            // 
            this.add256Button.Location = new System.Drawing.Point(133, 207);
            this.add256Button.Name = "add256Button";
            this.add256Button.Size = new System.Drawing.Size(75, 23);
            this.add256Button.TabIndex = 9;
            this.add256Button.Text = "Add 256";
            this.add256Button.UseVisualStyleBackColor = true;
            this.add256Button.Click += new System.EventHandler(this.add256Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 553);
            this.Controls.Add(this.add256Button);
            this.Controls.Add(this.testButton2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.currentItemsBox);
            this.Controls.Add(this.allItemsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allItemsBox;
        private System.Windows.Forms.ListBox currentItemsBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button testButton2;
        private System.Windows.Forms.Button add256Button;
    }
}

