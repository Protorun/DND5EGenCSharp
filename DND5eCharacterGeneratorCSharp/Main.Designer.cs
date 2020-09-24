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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Dragonborn");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Shield Dwarf");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Dwarf", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Moon Elf");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("High Elf");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Wild Elf");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Eladrin");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Elf", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Half-Elf");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Halfling");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Half-Orc");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Human");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Human Variant");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Human", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Tiefling");
            this.lblFirstName = new System.Windows.Forms.Label();
            this.treeRaceSelect = new System.Windows.Forms.TreeView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.listClass = new System.Windows.Forms.ListBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.listBackground = new System.Windows.Forms.ListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // treeRaceSelect
            // 
            this.treeRaceSelect.Location = new System.Drawing.Point(16, 69);
            this.treeRaceSelect.Name = "treeRaceSelect";
            treeNode16.Name = "RootDragonborn";
            treeNode16.Text = "Dragonborn";
            treeNode17.Name = "NodeShieldDwarf";
            treeNode17.Text = "Shield Dwarf";
            treeNode18.Name = "RootDwarf";
            treeNode18.Text = "Dwarf";
            treeNode19.Name = "NodeMoonElf";
            treeNode19.Text = "Moon Elf";
            treeNode20.Name = "NodeHighElf";
            treeNode20.Text = "High Elf";
            treeNode21.Name = "NodeWildElf";
            treeNode21.Text = "Wild Elf";
            treeNode22.Name = "NodeEladrin";
            treeNode22.Text = "Eladrin";
            treeNode23.Name = "RootElf";
            treeNode23.Text = "Elf";
            treeNode24.Name = "RootHalfElf";
            treeNode24.Text = "Half-Elf";
            treeNode25.Name = "RootHalfling";
            treeNode25.Text = "Halfling";
            treeNode26.Name = "RootHalf-Orc";
            treeNode26.Text = "Half-Orc";
            treeNode27.Name = "NodeHuman";
            treeNode27.Text = "Human";
            treeNode28.Name = "NodeHumanVariant";
            treeNode28.Text = "Human Variant";
            treeNode29.Name = "RootHuman";
            treeNode29.Text = "Human";
            treeNode30.Name = "RootTiefling";
            treeNode30.Text = "Tiefling";
            this.treeRaceSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode29,
            treeNode30});
            this.treeRaceSelect.Size = new System.Drawing.Size(121, 199);
            this.treeRaceSelect.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(143, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(140, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(13, 53);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(36, 13);
            this.lblRace.TabIndex = 5;
            this.lblRace.Text = "Race:";
            // 
            // listClass
            // 
            this.listClass.FormattingEnabled = true;
            this.listClass.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.listClass.Location = new System.Drawing.Point(143, 69);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(121, 199);
            this.listClass.TabIndex = 6;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(140, 53);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class:";
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(267, 53);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(68, 13);
            this.lblBackground.TabIndex = 9;
            this.lblBackground.Text = "Background:";
            // 
            // listBackground
            // 
            this.listBackground.FormattingEnabled = true;
            this.listBackground.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal/Spy",
            "Entertainer",
            "Folk Hero",
            "Gladiator",
            "Guld Artison/Merchant",
            "Hermit",
            "Knight",
            "Noble",
            "Outlander",
            "Pirate",
            "Safe",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.listBackground.Location = new System.Drawing.Point(270, 69);
            this.listBackground.Name = "listBackground";
            this.listBackground.Size = new System.Drawing.Size(121, 199);
            this.listBackground.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(270, 30);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 20);
            this.txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(267, 13);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(397, 30);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 20);
            this.txtHeight.TabIndex = 13;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(394, 13);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(524, 30);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 20);
            this.txtWeight.TabIndex = 15;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(521, 13);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Weight:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.listBackground);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.treeRaceSelect);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Main";
            this.Text = "D&D 5th Edition Character Generator";
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
        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.ListBox listBackground;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
    }
}

