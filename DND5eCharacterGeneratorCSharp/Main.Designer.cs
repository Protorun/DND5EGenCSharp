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
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Dragonborn");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Shield Dwarf");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Dwarf", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Moon Elf");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("High Elf");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Wild Elf");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Eladrin");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Elf", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Half-Elf");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Halfling");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Half-Orc");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Human");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Human Variant");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Human", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Tiefling");
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblDisplayFullName = new System.Windows.Forms.Label();
            this.lblDisplayRace = new System.Windows.Forms.Label();
            this.lblDisplayClass = new System.Windows.Forms.Label();
            this.lblDisplayBackground = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.treeRaceSelect.HideSelection = false;
            this.treeRaceSelect.Location = new System.Drawing.Point(16, 69);
            this.treeRaceSelect.Name = "treeRaceSelect";
            treeNode31.Name = "RootDragonborn";
            treeNode31.Text = "Dragonborn";
            treeNode32.Name = "NodeShieldDwarf";
            treeNode32.Text = "Shield Dwarf";
            treeNode33.Name = "RootDwarf";
            treeNode33.Text = "Dwarf";
            treeNode34.Name = "NodeMoonElf";
            treeNode34.Text = "Moon Elf";
            treeNode35.Name = "NodeHighElf";
            treeNode35.Text = "High Elf";
            treeNode36.Name = "NodeWildElf";
            treeNode36.Text = "Wild Elf";
            treeNode37.Name = "NodeEladrin";
            treeNode37.Text = "Eladrin";
            treeNode38.Name = "RootElf";
            treeNode38.Text = "Elf";
            treeNode39.Name = "RootHalfElf";
            treeNode39.Text = "Half-Elf";
            treeNode40.Name = "RootHalfling";
            treeNode40.Text = "Halfling";
            treeNode41.Name = "RootHalf-Orc";
            treeNode41.Text = "Half-Orc";
            treeNode42.Name = "NodeHuman";
            treeNode42.Text = "Human";
            treeNode43.Name = "NodeHumanVariant";
            treeNode43.Text = "Human Variant";
            treeNode44.Name = "RootHuman";
            treeNode44.Text = "Human";
            treeNode45.Name = "RootTiefling";
            treeNode45.Text = "Tiefling";
            this.treeRaceSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode33,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode44,
            treeNode45});
            this.treeRaceSelect.Size = new System.Drawing.Size(121, 212);
            this.treeRaceSelect.TabIndex = 1;
            this.treeRaceSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeRaceSelect_AfterSelect);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(143, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
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
            this.listClass.Size = new System.Drawing.Size(121, 212);
            this.listClass.TabIndex = 6;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
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
            this.listBackground.Location = new System.Drawing.Point(270, 69);
            this.listBackground.Name = "listBackground";
            this.listBackground.Size = new System.Drawing.Size(121, 212);
            this.listBackground.TabIndex = 8;
            this.listBackground.SelectedIndexChanged += new System.EventHandler(this.listBackground_SelectedIndexChanged);
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
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(651, 30);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtPlayerName.TabIndex = 17;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(648, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 16;
            this.lblPlayerName.Text = "Player Name:";
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
            this.btnCreate.Location = new System.Drawing.Point(696, 257);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDisplayBackground);
            this.Controls.Add(this.lblDisplayClass);
            this.Controls.Add(this.lblDisplayRace);
            this.Controls.Add(this.lblDisplayFullName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
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
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblDisplayFullName;
        private System.Windows.Forms.Label lblDisplayRace;
        private System.Windows.Forms.Label lblDisplayClass;
        private System.Windows.Forms.Label lblDisplayBackground;
        private System.Windows.Forms.Button btnCreate;
    }
}

