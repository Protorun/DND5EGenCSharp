using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DND5eCharacterGeneratorCSharp
{
    public partial class Main : Form
    {
        String FullName, FirstName, LastName;

        public Main()
        {
            InitializeComponent();
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            //lblFirstName.Text = FirstName;
            FullName = FirstName + " " + LastName;
            lblDisplayFullName.Text = FullName;
            if (String.IsNullOrEmpty(FirstName))
            {
                
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CharacterClass;
            CharacterClass = listClass.SelectedItem.ToString();
            lblDisplayClass.Text = CharacterClass;
            //lblAge.Text = CharacterClass;

        }

        private void treeRaceSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String CharacterRace;
            CharacterRace = treeRaceSelect.SelectedNode.Text;
            lblDisplayRace.Text = CharacterRace;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Text = FirstName + " " + LastName + " - " + txtPlayerName.Text + " - D&D 5th Edition Character Generator";
        }

        private void listBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CharacterBackground;
            CharacterBackground = listBackground.SelectedItem.ToString();
            lblDisplayBackground.Text = CharacterBackground;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {           
            LastName = txtLastName.Text;
            FullName = FirstName + " " + LastName;
            lblDisplayFullName.Text = FullName;
        }
    }
}
