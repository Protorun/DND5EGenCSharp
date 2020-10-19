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
            this.LblFirstName = new System.Windows.Forms.Label();
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
            this.lblAttributes = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.lblDisplayRolls = new System.Windows.Forms.Label();
            this.ListSubrace = new System.Windows.Forms.ListBox();
            this.ListRace = new System.Windows.Forms.ListBox();
            this.lblSubrace = new System.Windows.Forms.Label();
            this.lblDisplaySubrace = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblDisplayFeats = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblDeception = new System.Windows.Forms.Label();
            this.lblAnimalHandling = new System.Windows.Forms.Label();
            this.lblArcana = new System.Windows.Forms.Label();
            this.lblAcrobatics = new System.Windows.Forms.Label();
            this.lblAthletics = new System.Windows.Forms.Label();
            this.lblInsight = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblInvestigation = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblStealth = new System.Windows.Forms.Label();
            this.lblSleightofhand = new System.Windows.Forms.Label();
            this.lblPersuasion = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblIntimidation = new System.Windows.Forms.Label();
            this.lblSurvival = new System.Windows.Forms.Label();
            this.lblPerception = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
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
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(16, 30);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(121, 20);
            this.TxtFirstName.TabIndex = 1;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(143, 30);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(121, 20);
            this.TxtLastName.TabIndex = 2;
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
            this.ListClass.Location = new System.Drawing.Point(270, 69);
            this.ListClass.Name = "ListClass";
            this.ListClass.Size = new System.Drawing.Size(121, 212);
            this.ListClass.TabIndex = 8;
            this.ListClass.SelectedIndexChanged += new System.EventHandler(this.ListClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(267, 53);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class:";
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(394, 53);
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
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.ListBackground.Location = new System.Drawing.Point(397, 69);
            this.ListBackground.Name = "ListBackground";
            this.ListBackground.Size = new System.Drawing.Size(121, 212);
            this.ListBackground.TabIndex = 9;
            this.ListBackground.SelectedIndexChanged += new System.EventHandler(this.ListBackground_SelectedIndexChanged);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(270, 30);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(121, 20);
            this.TxtAge.TabIndex = 3;
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
            this.TxtHeight.TabIndex = 4;
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
            this.TxtWeight.TabIndex = 5;
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
            this.lblDisplayFullName.Location = new System.Drawing.Point(521, 69);
            this.lblDisplayFullName.Name = "lblDisplayFullName";
            this.lblDisplayFullName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayFullName.TabIndex = 18;
            this.lblDisplayFullName.Text = "Character Name";
            // 
            // lblDisplayRace
            // 
            this.lblDisplayRace.AutoSize = true;
            this.lblDisplayRace.Location = new System.Drawing.Point(521, 82);
            this.lblDisplayRace.Name = "lblDisplayRace";
            this.lblDisplayRace.Size = new System.Drawing.Size(33, 13);
            this.lblDisplayRace.TabIndex = 19;
            this.lblDisplayRace.Text = "Race";
            // 
            // lblDisplayClass
            // 
            this.lblDisplayClass.AutoSize = true;
            this.lblDisplayClass.Location = new System.Drawing.Point(521, 108);
            this.lblDisplayClass.Name = "lblDisplayClass";
            this.lblDisplayClass.Size = new System.Drawing.Size(32, 13);
            this.lblDisplayClass.TabIndex = 20;
            this.lblDisplayClass.Text = "Class";
            // 
            // lblDisplayBackground
            // 
            this.lblDisplayBackground.AutoSize = true;
            this.lblDisplayBackground.Location = new System.Drawing.Point(521, 121);
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
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(13, 284);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(54, 13);
            this.lblAttributes.TabIndex = 23;
            this.lblAttributes.Text = "Attributes:";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(13, 297);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(56, 13);
            this.lblStrength.TabIndex = 24;
            this.lblStrength.Text = "Strength - ";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(13, 310);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(57, 13);
            this.lblDexterity.TabIndex = 25;
            this.lblDexterity.Text = "Dexterity - ";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(13, 336);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(70, 13);
            this.lblIntelligence.TabIndex = 27;
            this.lblIntelligence.Text = "Intelligence - ";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(13, 323);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(71, 13);
            this.lblConstitution.TabIndex = 26;
            this.lblConstitution.Text = "Constitution - ";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(13, 362);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(59, 13);
            this.lblCharisma.TabIndex = 29;
            this.lblCharisma.Text = "Charisma - ";
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Location = new System.Drawing.Point(13, 349);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(54, 13);
            this.lblWisdom.TabIndex = 28;
            this.lblWisdom.Text = "Wisdom - ";
            // 
            // lblDisplayRolls
            // 
            this.lblDisplayRolls.AutoSize = true;
            this.lblDisplayRolls.Location = new System.Drawing.Point(13, 435);
            this.lblDisplayRolls.Name = "lblDisplayRolls";
            this.lblDisplayRolls.Size = new System.Drawing.Size(123, 13);
            this.lblDisplayRolls.TabIndex = 30;
            this.lblDisplayRolls.Text = "DISPLAY ROLLS HERE";
            // 
            // ListSubrace
            // 
            this.ListSubrace.FormattingEnabled = true;
            this.ListSubrace.Items.AddRange(new object[] {
            "Select Race first"});
            this.ListSubrace.Location = new System.Drawing.Point(143, 69);
            this.ListSubrace.Name = "ListSubrace";
            this.ListSubrace.Size = new System.Drawing.Size(121, 212);
            this.ListSubrace.TabIndex = 7;
            this.ListSubrace.SelectedIndexChanged += new System.EventHandler(this.ListSubrace_SelectedIndexChanged);
            // 
            // ListRace
            // 
            this.ListRace.FormattingEnabled = true;
            this.ListRace.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Halfling",
            "Half-Orc",
            "Human",
            "Tiefling"});
            this.ListRace.Location = new System.Drawing.Point(16, 69);
            this.ListRace.Name = "ListRace";
            this.ListRace.Size = new System.Drawing.Size(121, 212);
            this.ListRace.TabIndex = 6;
            this.ListRace.SelectedIndexChanged += new System.EventHandler(this.ListRace_SelectedIndexChanged);
            // 
            // lblSubrace
            // 
            this.lblSubrace.AutoSize = true;
            this.lblSubrace.Location = new System.Drawing.Point(140, 53);
            this.lblSubrace.Name = "lblSubrace";
            this.lblSubrace.Size = new System.Drawing.Size(50, 13);
            this.lblSubrace.TabIndex = 33;
            this.lblSubrace.Text = "Subrace:";
            // 
            // lblDisplaySubrace
            // 
            this.lblDisplaySubrace.AutoSize = true;
            this.lblDisplaySubrace.Location = new System.Drawing.Point(521, 95);
            this.lblDisplaySubrace.Name = "lblDisplaySubrace";
            this.lblDisplaySubrace.Size = new System.Drawing.Size(47, 13);
            this.lblDisplaySubrace.TabIndex = 34;
            this.lblDisplaySubrace.Text = "Subrace";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(570, 288);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 35;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblDisplayFeats
            // 
            this.lblDisplayFeats.AutoSize = true;
            this.lblDisplayFeats.Location = new System.Drawing.Point(647, 69);
            this.lblDisplayFeats.Name = "lblDisplayFeats";
            this.lblDisplayFeats.Size = new System.Drawing.Size(33, 13);
            this.lblDisplayFeats.TabIndex = 36;
            this.lblDisplayFeats.Text = "Feats";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(140, 284);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(34, 13);
            this.lblSkills.TabIndex = 37;
            this.lblSkills.Text = "Skills:";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(268, 349);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(39, 13);
            this.lblNature.TabIndex = 43;
            this.lblNature.Text = "Nature";
            // 
            // lblDeception
            // 
            this.lblDeception.AutoSize = true;
            this.lblDeception.Location = new System.Drawing.Point(140, 349);
            this.lblDeception.Name = "lblDeception";
            this.lblDeception.Size = new System.Drawing.Size(56, 13);
            this.lblDeception.TabIndex = 42;
            this.lblDeception.Text = "Deception";
            // 
            // lblAnimalHandling
            // 
            this.lblAnimalHandling.AutoSize = true;
            this.lblAnimalHandling.Location = new System.Drawing.Point(140, 336);
            this.lblAnimalHandling.Name = "lblAnimalHandling";
            this.lblAnimalHandling.Size = new System.Drawing.Size(83, 13);
            this.lblAnimalHandling.TabIndex = 41;
            this.lblAnimalHandling.Text = "Animal Handling";
            // 
            // lblArcana
            // 
            this.lblArcana.AutoSize = true;
            this.lblArcana.Location = new System.Drawing.Point(140, 310);
            this.lblArcana.Name = "lblArcana";
            this.lblArcana.Size = new System.Drawing.Size(41, 13);
            this.lblArcana.TabIndex = 40;
            this.lblArcana.Text = "Arcana";
            // 
            // lblAcrobatics
            // 
            this.lblAcrobatics.AutoSize = true;
            this.lblAcrobatics.Location = new System.Drawing.Point(139, 297);
            this.lblAcrobatics.Name = "lblAcrobatics";
            this.lblAcrobatics.Size = new System.Drawing.Size(57, 13);
            this.lblAcrobatics.TabIndex = 39;
            this.lblAcrobatics.Text = "Acrobatics";
            // 
            // lblAthletics
            // 
            this.lblAthletics.AutoSize = true;
            this.lblAthletics.Location = new System.Drawing.Point(140, 323);
            this.lblAthletics.Name = "lblAthletics";
            this.lblAthletics.Size = new System.Drawing.Size(47, 13);
            this.lblAthletics.TabIndex = 38;
            this.lblAthletics.Text = "Athletics";
            // 
            // lblInsight
            // 
            this.lblInsight.AutoSize = true;
            this.lblInsight.Location = new System.Drawing.Point(267, 297);
            this.lblInsight.Name = "lblInsight";
            this.lblInsight.Size = new System.Drawing.Size(38, 13);
            this.lblInsight.TabIndex = 49;
            this.lblInsight.Text = "Insight";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(394, 323);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(45, 13);
            this.lblReligion.TabIndex = 48;
            this.lblReligion.Text = "Religion";
            // 
            // lblInvestigation
            // 
            this.lblInvestigation.AutoSize = true;
            this.lblInvestigation.Location = new System.Drawing.Point(267, 323);
            this.lblInvestigation.Name = "lblInvestigation";
            this.lblInvestigation.Size = new System.Drawing.Size(67, 13);
            this.lblInvestigation.TabIndex = 47;
            this.lblInvestigation.Text = "Investigation";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(140, 362);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(39, 13);
            this.lblHistory.TabIndex = 46;
            this.lblHistory.Text = "History";
            // 
            // lblStealth
            // 
            this.lblStealth.AutoSize = true;
            this.lblStealth.Location = new System.Drawing.Point(394, 349);
            this.lblStealth.Name = "lblStealth";
            this.lblStealth.Size = new System.Drawing.Size(40, 13);
            this.lblStealth.TabIndex = 45;
            this.lblStealth.Text = "Stealth";
            // 
            // lblSleightofhand
            // 
            this.lblSleightofhand.AutoSize = true;
            this.lblSleightofhand.Location = new System.Drawing.Point(394, 336);
            this.lblSleightofhand.Name = "lblSleightofhand";
            this.lblSleightofhand.Size = new System.Drawing.Size(80, 13);
            this.lblSleightofhand.TabIndex = 44;
            this.lblSleightofhand.Text = "Sleight of Hand";
            // 
            // lblPersuasion
            // 
            this.lblPersuasion.AutoSize = true;
            this.lblPersuasion.Location = new System.Drawing.Point(394, 310);
            this.lblPersuasion.Name = "lblPersuasion";
            this.lblPersuasion.Size = new System.Drawing.Size(59, 13);
            this.lblPersuasion.TabIndex = 55;
            this.lblPersuasion.Text = "Persuasion";
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Location = new System.Drawing.Point(394, 297);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(67, 13);
            this.lblPerformance.TabIndex = 54;
            this.lblPerformance.Text = "Performance";
            // 
            // lblIntimidation
            // 
            this.lblIntimidation.AutoSize = true;
            this.lblIntimidation.Location = new System.Drawing.Point(267, 310);
            this.lblIntimidation.Name = "lblIntimidation";
            this.lblIntimidation.Size = new System.Drawing.Size(60, 13);
            this.lblIntimidation.TabIndex = 53;
            this.lblIntimidation.Text = "Intimidation";
            // 
            // lblSurvival
            // 
            this.lblSurvival.AutoSize = true;
            this.lblSurvival.Location = new System.Drawing.Point(394, 362);
            this.lblSurvival.Name = "lblSurvival";
            this.lblSurvival.Size = new System.Drawing.Size(45, 13);
            this.lblSurvival.TabIndex = 52;
            this.lblSurvival.Text = "Survival";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(267, 362);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(58, 13);
            this.lblPerception.TabIndex = 51;
            this.lblPerception.Text = "Perception";
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(268, 336);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(50, 13);
            this.lblMedicine.TabIndex = 50;
            this.lblMedicine.Text = "Medicine";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(570, 317);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 56;
            this.btnReturn.Text = "Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 457);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblPersuasion);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.lblIntimidation);
            this.Controls.Add(this.lblSurvival);
            this.Controls.Add(this.lblPerception);
            this.Controls.Add(this.lblMedicine);
            this.Controls.Add(this.lblInsight);
            this.Controls.Add(this.lblReligion);
            this.Controls.Add(this.lblInvestigation);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblStealth);
            this.Controls.Add(this.lblSleightofhand);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.lblDeception);
            this.Controls.Add(this.lblAnimalHandling);
            this.Controls.Add(this.lblArcana);
            this.Controls.Add(this.lblAcrobatics);
            this.Controls.Add(this.lblAthletics);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblDisplayFeats);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblDisplaySubrace);
            this.Controls.Add(this.lblSubrace);
            this.Controls.Add(this.ListRace);
            this.Controls.Add(this.ListSubrace);
            this.Controls.Add(this.lblDisplayRolls);
            this.Controls.Add(this.lblCharisma);
            this.Controls.Add(this.lblWisdom);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblConstitution);
            this.Controls.Add(this.lblDexterity);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblAttributes);
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
            this.Controls.Add(this.LblFirstName);
            this.Name = "MainForm";
            this.Text = "D&D 5th Edition Character Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
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
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label lblDisplayRolls;
        private System.Windows.Forms.ListBox ListSubrace;
        private System.Windows.Forms.ListBox ListRace;
        private System.Windows.Forms.Label lblSubrace;
        private System.Windows.Forms.Label lblDisplaySubrace;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblDisplayFeats;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblDeception;
        private System.Windows.Forms.Label lblAnimalHandling;
        private System.Windows.Forms.Label lblArcana;
        private System.Windows.Forms.Label lblAcrobatics;
        private System.Windows.Forms.Label lblAthletics;
        private System.Windows.Forms.Label lblInsight;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblInvestigation;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblStealth;
        private System.Windows.Forms.Label lblSleightofhand;
        private System.Windows.Forms.Label lblPersuasion;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Label lblIntimidation;
        private System.Windows.Forms.Label lblSurvival;
        private System.Windows.Forms.Label lblPerception;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Button btnReturn;
    }
}

