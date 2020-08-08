namespace InteractiveStory
{
    partial class Form2
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
            this.StoryTextBox = new System.Windows.Forms.TextBox();
            this.Options1ComboBox = new System.Windows.Forms.ComboBox();
            this.Option2ComboBox = new System.Windows.Forms.ComboBox();
            this.Option2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoryTextBox
            // 
            this.StoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryTextBox.Location = new System.Drawing.Point(15, 367);
            this.StoryTextBox.Multiline = true;
            this.StoryTextBox.Name = "StoryTextBox";
            this.StoryTextBox.ReadOnly = true;
            this.StoryTextBox.Size = new System.Drawing.Size(522, 226);
            this.StoryTextBox.TabIndex = 0;
            // 
            // Options1ComboBox
            // 
            this.Options1ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options1ComboBox.FormattingEnabled = true;
            this.Options1ComboBox.Items.AddRange(new object[] {
            "Find more supplies",
            "Go back to camp",
            "Zombie killing rampage"});
            this.Options1ComboBox.Location = new System.Drawing.Point(15, 67);
            this.Options1ComboBox.Name = "Options1ComboBox";
            this.Options1ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Options1ComboBox.TabIndex = 1;
            this.Options1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Options1ComboBox_SelectedIndexChanged);
            // 
            // Option2ComboBox
            // 
            this.Option2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option2ComboBox.FormattingEnabled = true;
            this.Option2ComboBox.Items.AddRange(new object[] {
            "Fight",
            "Run"});
            this.Option2ComboBox.Location = new System.Drawing.Point(299, 67);
            this.Option2ComboBox.Name = "Option2ComboBox";
            this.Option2ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Option2ComboBox.TabIndex = 2;
            this.Option2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Option2ComboBox_SelectedIndexChanged);
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option2Label.Location = new System.Drawing.Point(296, 33);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(87, 16);
            this.Option2Label.TabIndex = 3;
            this.Option2Label.Text = "Fight or Flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "What do you want to do next?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Option2Label);
            this.Controls.Add(this.Option2ComboBox);
            this.Controls.Add(this.Options1ComboBox);
            this.Controls.Add(this.StoryTextBox);
            this.Name = "Form2";
            this.Text = "Story Continued";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoryTextBox;
        private System.Windows.Forms.ComboBox Options1ComboBox;
        private System.Windows.Forms.ComboBox Option2ComboBox;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Label label1;
    }
}