namespace InteractiveStory
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.enterInput = new System.Windows.Forms.Button();
            this.StoryTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.StoryLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBoxLabel = new System.Windows.Forms.Label();
            this.DisplayInventory = new System.Windows.Forms.Button();
            this.ContinueStoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterInput
            // 
            this.enterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterInput.Location = new System.Drawing.Point(317, 128);
            this.enterInput.Name = "enterInput";
            this.enterInput.Size = new System.Drawing.Size(75, 35);
            this.enterInput.TabIndex = 0;
            this.enterInput.Text = "Enter";
            this.enterInput.UseVisualStyleBackColor = true;
            this.enterInput.Click += new System.EventHandler(this.EnterInput_Click);
            // 
            // StoryTextBox
            // 
            this.StoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryTextBox.Location = new System.Drawing.Point(41, 380);
            this.StoryTextBox.Multiline = true;
            this.StoryTextBox.Name = "StoryTextBox";
            this.StoryTextBox.ReadOnly = true;
            this.StoryTextBox.Size = new System.Drawing.Size(673, 297);
            this.StoryTextBox.TabIndex = 1;
            this.StoryTextBox.Text = resources.GetString("StoryTextBox.Text");
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(41, 137);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(190, 20);
            this.InputTextBox.TabIndex = 2;
            // 
            // StoryLabel
            // 
            this.StoryLabel.AutoSize = true;
            this.StoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryLabel.Location = new System.Drawing.Point(232, 345);
            this.StoryLabel.Name = "StoryLabel";
            this.StoryLabel.Size = new System.Drawing.Size(80, 20);
            this.StoryLabel.TabIndex = 3;
            this.StoryLabel.Text = "Story Text";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(87, 104);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(84, 20);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Input Field";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fight",
            "Run",
            "Hide"});
            this.comboBox1.Location = new System.Drawing.Point(523, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboBoxLabel
            // 
            this.ComboBoxLabel.AutoSize = true;
            this.ComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxLabel.Location = new System.Drawing.Point(519, 104);
            this.ComboBoxLabel.Name = "ComboBoxLabel";
            this.ComboBoxLabel.Size = new System.Drawing.Size(148, 20);
            this.ComboBoxLabel.TabIndex = 6;
            this.ComboBoxLabel.Text = "Options Drop Down";
            // 
            // DisplayInventory
            // 
            this.DisplayInventory.Enabled = false;
            this.DisplayInventory.Location = new System.Drawing.Point(852, 141);
            this.DisplayInventory.Name = "DisplayInventory";
            this.DisplayInventory.Size = new System.Drawing.Size(125, 23);
            this.DisplayInventory.TabIndex = 7;
            this.DisplayInventory.Text = "Display Inventory";
            this.DisplayInventory.UseVisualStyleBackColor = true;
            this.DisplayInventory.Click += new System.EventHandler(this.DisplayInventory_Click);
            // 
            // ContinueStoryButton
            // 
            this.ContinueStoryButton.Location = new System.Drawing.Point(1111, 141);
            this.ContinueStoryButton.Name = "ContinueStoryButton";
            this.ContinueStoryButton.Size = new System.Drawing.Size(123, 23);
            this.ContinueStoryButton.TabIndex = 8;
            this.ContinueStoryButton.Text = "Continue Story";
            this.ContinueStoryButton.UseVisualStyleBackColor = true;
            this.ContinueStoryButton.Click += new System.EventHandler(this.ContinueStoryButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InteractiveStory.Properties.Resources.Welcome;
            this.ClientSize = new System.Drawing.Size(1340, 707);
            this.Controls.Add(this.ContinueStoryButton);
            this.Controls.Add(this.DisplayInventory);
            this.Controls.Add(this.ComboBoxLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.StoryLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.StoryTextBox);
            this.Controls.Add(this.enterInput);
            this.Name = "FormMain";
            this.Text = "InteractiveStory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterInput;
        private System.Windows.Forms.TextBox StoryTextBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label StoryLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ComboBoxLabel;
        private System.Windows.Forms.Button DisplayInventory;
        private System.Windows.Forms.Button ContinueStoryButton;
    }
}

