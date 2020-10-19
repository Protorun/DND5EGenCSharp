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
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.btnLoadCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Location = new System.Drawing.Point(147, 84);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(130, 23);
            this.btnNewCharacter.TabIndex = 0;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            // 
            // btnLoadCharacter
            // 
            this.btnLoadCharacter.Location = new System.Drawing.Point(147, 113);
            this.btnLoadCharacter.Name = "btnLoadCharacter";
            this.btnLoadCharacter.Size = new System.Drawing.Size(130, 23);
            this.btnLoadCharacter.TabIndex = 1;
            this.btnLoadCharacter.Text = "Load/Edit Character";
            this.btnLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 275);
            this.Controls.Add(this.btnLoadCharacter);
            this.Controls.Add(this.btnNewCharacter);
            this.Name = "MainMenu";
            this.Text = "DnD 5th Edition Character Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.Button btnLoadCharacter;
    }
}