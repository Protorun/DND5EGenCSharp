namespace DND5eCharacterGeneratorCSharp
{
    partial class MainForm
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
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TreeRaceSelect = new System.Windows.Forms.TreeView();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.ListClass = new System.Windows.Forms.ListBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.ListBackground = new System.Windows.Forms.ListBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.lblDisplayFullName = new System.Windows.Forms.Label();
            this.lblDisplayRace = new System.Windows.Forms.Label();
            this.lblDisplayClass = new System.Windows.Forms.Label();
            this.lblDisplayBackground = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(13, 13);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(60, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name:";
            // 
            // TreeRaceSelect
            // 
            this.TreeRaceSelect.HideSelection = false;
            this.TreeRaceSelect.Location = new System.Drawing.Point(16, 69);
            this.TreeRaceSelect.Name = "TreeRaceSelect";
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
            this.TreeRaceSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode29,
            treeNode30});
            this.TreeRaceSelect.Size = new System.Drawing.Size(121, 212);
            this.TreeRaceSelect.TabIndex = 1;
            this.TreeRaceSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeRaceSelect_AfterSelect);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(16, 30);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(121, 20);
            this.TxtFirstName.TabIndex = 2;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(143, 30);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(121, 20);
            this.TxtLastName.TabIndex = 4;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(140, 13);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(61, 13);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Last Name:";
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
            // ListClass
            // 
            this.ListClass.FormattingEnabled = true;
            this.ListClass.Items.AddRange(new object[] {
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
            this.ListClass.Location = new System.Drawing.Point(143, 69);
            this.ListClass.Name = "ListClass";
            this.ListClass.Size = new System.Drawing.Size(121, 212);
            this.ListClass.TabIndex = 6;
            this.ListClass.SelectedIndexChanged += new System.EventHandler(this.ListClass_SelectedIndexChanged);
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
            // ListBackground
            // 
            this.ListBackground.FormattingEnabled = true;
            this.ListBackground.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal/Spy",
            "Entertainer",
            "Folk Hero",
            "Gladiator",
            "Guild Artison/Merchant",
            "Hermit",
            "Knight",
            "Noble",
            "Outlander",
            "Pirate",
            "Safe",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.ListBackground.Location = new System.Drawing.Point(270, 69);
            this.ListBackground.Name = "ListBackground";
            this.ListBackground.Size = new System.Drawing.Size(121, 212);
            this.ListBackground.TabIndex = 8;
            this.ListBackground.SelectedIndexChanged += new System.EventHandler(this.ListBackground_SelectedIndexChanged);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(270, 30);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(121, 20);
            this.TxtAge.TabIndex = 11;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(267, 13);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(29, 13);
            this.LblAge.TabIndex = 10;
            this.LblAge.Text = "Age:";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(397, 30);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(121, 20);
            this.TxtHeight.TabIndex = 13;
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(394, 13);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(41, 13);
            this.LblHeight.TabIndex = 12;
            this.LblHeight.Text = "Height:";
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(524, 30);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(121, 20);
            this.TxtWeight.TabIndex = 15;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(521, 13);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(44, 13);
            this.LblWeight.TabIndex = 14;
            this.LblWeight.Text = "Weight:";
            // 
            // lblDisplayFullName
            // 
            this.lblDisplayFullName.AutoSize = true;
            this.lblDisplayFullName.Location = new System.Drawing.Point(397, 69);
            this.lblDisplayFullName.Name = "lblDisplayFullName";
            this.lblDisplayFullName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayFullName.TabIndex = 18;
            this.lblDisplayFullName.Text = "Character Name";
            // 
            // lblDisplayRace
            // 
            this.lblDisplayRace.AutoSize = true;
            this.lblDisplayRace.Location = new System.Drawing.Point(397, 82);
            this.lblDisplayRace.Name = "lblDisplayRace";
            this.lblDisplayRace.Size = new System.Drawing.Size(33, 13);
            this.lblDisplayRace.TabIndex = 19;
            this.lblDisplayRace.Text = "Race";
            // 
            // lblDisplayClass
            // 
            this.lblDisplayClass.AutoSize = true;
            this.lblDisplayClass.Location = new System.Drawing.Point(397, 95);
            this.lblDisplayClass.Name = "lblDisplayClass";
            this.lblDisplayClass.Size = new System.Drawing.Size(32, 13);
            this.lblDisplayClass.TabIndex = 20;
            this.lblDisplayClass.Text = "Class";
            // 
            // lblDisplayBackground
            // 
            this.lblDisplayBackground.AutoSize = true;
            this.lblDisplayBackground.Location = new System.Drawing.Point(397, 108);
            this.lblDisplayBackground.Name = "lblDisplayBackground";
            this.lblDisplayBackground.Size = new System.Drawing.Size(65, 13);
            this.lblDisplayBackground.TabIndex = 21;
            this.lblDisplayBackground.Text = "Background";
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreate.Location = new System.Drawing.Point(570, 258);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDisplayBackground);
            this.Controls.Add(this.lblDisplayClass);
            this.Controls.Add(this.lblDisplayRace);
            this.Controls.Add(this.lblDisplayFullName);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.LblWeight);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.ListBackground);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.ListClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TreeRaceSelect);
            this.Controls.Add(this.LblFirstName);
            this.Name = "MainForm";
            this.Text = "D&D 5th Edition Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TreeView TreeRaceSelect;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ListBox ListClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.ListBox ListBackground;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label lblDisplayFullName;
        private System.Windows.Forms.Label lblDisplayRace;
        private System.Windows.Forms.Label lblDisplayClass;
        private System.Windows.Forms.Label lblDisplayBackground;
        private System.Windows.Forms.Button btnCreate;
    }
}

