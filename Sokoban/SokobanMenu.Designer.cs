namespace Sokoban
{
    partial class SokobanMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_button = new System.Windows.Forms.Button();
            this.Level_comboBox = new System.Windows.Forms.ComboBox();
            this.Level_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_button.Location = new System.Drawing.Point(12, 66);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(140, 46);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Level_comboBox
            // 
            this.Level_comboBox.FormattingEnabled = true;
            this.Level_comboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Level_comboBox.Location = new System.Drawing.Point(87, 20);
            this.Level_comboBox.Name = "Level_comboBox";
            this.Level_comboBox.Size = new System.Drawing.Size(65, 40);
            this.Level_comboBox.TabIndex = 1;
            // 
            // Level_label
            // 
            this.Level_label.AutoSize = true;
            this.Level_label.Location = new System.Drawing.Point(12, 23);
            this.Level_label.Name = "Level_label";
            this.Level_label.Size = new System.Drawing.Size(69, 32);
            this.Level_label.TabIndex = 2;
            this.Level_label.Text = "Level";
            // 
            // SokobanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Level_label);
            this.Controls.Add(this.Level_comboBox);
            this.Controls.Add(this.Start_button);
            this.Name = "SokobanMenu";
            this.Text = "Sokoban menu";
            this.Load += new System.EventHandler(this.SokobanMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start_button;
        private ComboBox Level_comboBox;
        private Label Level_label;
    }
}