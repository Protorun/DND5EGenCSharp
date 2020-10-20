namespace DND5eCharacterGeneratorCSharp
{
    partial class SkillProficiency
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
            this.BtnFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFinished
            // 
            this.BtnFinished.Location = new System.Drawing.Point(713, 415);
            this.BtnFinished.Name = "BtnFinished";
            this.BtnFinished.Size = new System.Drawing.Size(75, 23);
            this.BtnFinished.TabIndex = 0;
            this.BtnFinished.Text = "Done";
            this.BtnFinished.UseVisualStyleBackColor = true;
            this.BtnFinished.Click += new System.EventHandler(this.BtnFinished_Click);
            // 
            // SkillProficiency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFinished);
            this.Name = "SkillProficiency";
            this.Text = "Select skill proficiencies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFinished;
    }
}