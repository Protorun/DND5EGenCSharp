namespace DND5eCharacterGeneratorCSharp
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dragonborn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Shield Dwarf");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dwarf", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Moon Elf");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("High Elf");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Wild Elf");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Eladrin");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Elf", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Half-Elf");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Halfling");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Half-Orc");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Human");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Human Variant");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Human", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tiefling");
            this.lblFirstName = new System.Windows.Forms.Label();
            this.treeRaceSelect = new System.Windows.Forms.TreeView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // treeRaceSelect
            // 
            this.treeRaceSelect.Location = new System.Drawing.Point(16, 69);
            this.treeRaceSelect.Name = "treeRaceSelect";
            treeNode1.Name = "RootDragonborn";
            treeNode1.Text = "Dragonborn";
            treeNode2.Name = "NodeShieldDwarf";
            treeNode2.Text = "Shield Dwarf";
            treeNode3.Name = "RootDwarf";
            treeNode3.Text = "Dwarf";
            treeNode4.Name = "NodeMoonElf";
            treeNode4.Text = "Moon Elf";
            treeNode5.Name = "NodeHighElf";
            treeNode5.Text = "High Elf";
            treeNode6.Name = "NodeWildElf";
            treeNode6.Text = "Wild Elf";
            treeNode7.Name = "NodeEladrin";
            treeNode7.Text = "Eladrin";
            treeNode8.Name = "RootElf";
            treeNode8.Text = "Elf";
            treeNode9.Name = "RootHalfElf";
            treeNode9.Text = "Half-Elf";
            treeNode10.Name = "RootHalfling";
            treeNode10.Text = "Halfling";
            treeNode11.Name = "RootHalf-Orc";
            treeNode11.Text = "Half-Orc";
            treeNode12.Name = "NodeHuman";
            treeNode12.Text = "Human";
            treeNode13.Name = "NodeHumanVariant";
            treeNode13.Text = "Human Variant";
            treeNode14.Name = "RootHuman";
            treeNode14.Text = "Human";
            treeNode15.Name = "RootTiefling";
            treeNode15.Text = "Tiefling";
            this.treeRaceSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode14,
            treeNode15});
            this.treeRaceSelect.Size = new System.Drawing.Size(121, 196);
            this.treeRaceSelect.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(122, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(119, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(13, 53);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 5;
            this.lblRace.Text = "Race";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.treeRaceSelect);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TreeView treeRaceSelect;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRace;
    }
}

