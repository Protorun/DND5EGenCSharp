namespace DND5eCharacterGeneratorCSharp
{
    partial class MainMenu
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
            this.BtnNewCharacter = new System.Windows.Forms.Button();
            this.BtnLoadCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewCharacter
            // 
            this.BtnNewCharacter.Location = new System.Drawing.Point(147, 84);
            this.BtnNewCharacter.Name = "BtnNewCharacter";
            this.BtnNewCharacter.Size = new System.Drawing.Size(130, 23);
            this.BtnNewCharacter.TabIndex = 0;
            this.BtnNewCharacter.Text = "New Character";
            this.BtnNewCharacter.UseVisualStyleBackColor = true;
            this.BtnNewCharacter.Click += new System.EventHandler(this.BtnNewCharacter_Click);
            // 
            // BtnLoadCharacter
            // 
            this.BtnLoadCharacter.Location = new System.Drawing.Point(147, 113);
            this.BtnLoadCharacter.Name = "BtnLoadCharacter";
            this.BtnLoadCharacter.Size = new System.Drawing.Size(130, 23);
            this.BtnLoadCharacter.TabIndex = 1;
            this.BtnLoadCharacter.Text = "Load/Edit Character";
            this.BtnLoadCharacter.UseVisualStyleBackColor = true;
            this.BtnLoadCharacter.Click += new System.EventHandler(this.BtnLoadCharacter_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 275);
            this.Controls.Add(this.BtnLoadCharacter);
            this.Controls.Add(this.BtnNewCharacter);
            this.Name = "MainMenu";
            this.Text = "DnD 5th Edition Character Generator";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewCharacter;
        private System.Windows.Forms.Button BtnLoadCharacter;
    }
}