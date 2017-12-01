namespace InventoryTest
{
    partial class CharacterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.helmLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.armsLabel = new System.Windows.Forms.Label();
            this.armorBox = new System.Windows.Forms.ListBox();
            this.equipButton = new System.Windows.Forms.Button();
            this.findHelmButton = new System.Windows.Forms.Button();
            this.findBodyButton = new System.Windows.Forms.Button();
            this.findArmButton = new System.Windows.Forms.Button();
            this.findRingButton = new System.Windows.Forms.Button();
            this.findWeaponButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Helm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arms:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(117, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "nameLabel";
            // 
            // helmLabel
            // 
            this.helmLabel.AutoSize = true;
            this.helmLabel.Location = new System.Drawing.Point(120, 79);
            this.helmLabel.Name = "helmLabel";
            this.helmLabel.Size = new System.Drawing.Size(35, 13);
            this.helmLabel.TabIndex = 5;
            this.helmLabel.Text = "helm?";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(120, 128);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(36, 13);
            this.bodyLabel.TabIndex = 6;
            this.bodyLabel.Text = "body?";
            // 
            // armsLabel
            // 
            this.armsLabel.AutoSize = true;
            this.armsLabel.Location = new System.Drawing.Point(117, 179);
            this.armsLabel.Name = "armsLabel";
            this.armsLabel.Size = new System.Drawing.Size(35, 13);
            this.armsLabel.TabIndex = 7;
            this.armsLabel.Text = "arms?";
            // 
            // armorBox
            // 
            this.armorBox.FormattingEnabled = true;
            this.armorBox.Location = new System.Drawing.Point(12, 323);
            this.armorBox.Name = "armorBox";
            this.armorBox.Size = new System.Drawing.Size(120, 199);
            this.armorBox.TabIndex = 8;
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(262, 323);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(91, 23);
            this.equipButton.TabIndex = 9;
            this.equipButton.Text = "Equip Selected";
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // findHelmButton
            // 
            this.findHelmButton.Location = new System.Drawing.Point(151, 323);
            this.findHelmButton.Name = "findHelmButton";
            this.findHelmButton.Size = new System.Drawing.Size(87, 23);
            this.findHelmButton.TabIndex = 10;
            this.findHelmButton.Text = "Find Helms";
            this.findHelmButton.UseMnemonic = false;
            this.findHelmButton.UseVisualStyleBackColor = true;
            this.findHelmButton.Click += new System.EventHandler(this.findHelmButton_Click);
            // 
            // findBodyButton
            // 
            this.findBodyButton.Location = new System.Drawing.Point(151, 366);
            this.findBodyButton.Name = "findBodyButton";
            this.findBodyButton.Size = new System.Drawing.Size(87, 23);
            this.findBodyButton.TabIndex = 11;
            this.findBodyButton.Text = "Find Body";
            this.findBodyButton.UseVisualStyleBackColor = true;
            this.findBodyButton.Click += new System.EventHandler(this.findBodyButton_Click);
            // 
            // findArmButton
            // 
            this.findArmButton.Location = new System.Drawing.Point(151, 409);
            this.findArmButton.Name = "findArmButton";
            this.findArmButton.Size = new System.Drawing.Size(87, 23);
            this.findArmButton.TabIndex = 12;
            this.findArmButton.Text = "Find Arms";
            this.findArmButton.UseVisualStyleBackColor = true;
            this.findArmButton.Click += new System.EventHandler(this.findArmButton_Click);
            // 
            // findRingButton
            // 
            this.findRingButton.Location = new System.Drawing.Point(151, 452);
            this.findRingButton.Name = "findRingButton";
            this.findRingButton.Size = new System.Drawing.Size(87, 23);
            this.findRingButton.TabIndex = 13;
            this.findRingButton.Text = "Find Rings";
            this.findRingButton.UseVisualStyleBackColor = true;
            this.findRingButton.Click += new System.EventHandler(this.findRingButton_Click);
            // 
            // findWeaponButton
            // 
            this.findWeaponButton.Location = new System.Drawing.Point(151, 495);
            this.findWeaponButton.Name = "findWeaponButton";
            this.findWeaponButton.Size = new System.Drawing.Size(87, 23);
            this.findWeaponButton.TabIndex = 14;
            this.findWeaponButton.Text = "Find Weapons";
            this.findWeaponButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(459, 382);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 544);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.findWeaponButton);
            this.Controls.Add(this.findRingButton);
            this.Controls.Add(this.findArmButton);
            this.Controls.Add(this.findBodyButton);
            this.Controls.Add(this.findHelmButton);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.armorBox);
            this.Controls.Add(this.armsLabel);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.helmLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label helmLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label armsLabel;
        private System.Windows.Forms.ListBox armorBox;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Button findHelmButton;
        private System.Windows.Forms.Button findBodyButton;
        private System.Windows.Forms.Button findArmButton;
        private System.Windows.Forms.Button findRingButton;
        private System.Windows.Forms.Button findWeaponButton;
        private System.Windows.Forms.Button saveButton;
    }
}