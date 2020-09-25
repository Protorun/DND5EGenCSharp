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
        String FullName, FirstName, LastName, CharacterRace, CharacterClass, CharacterBackground;

        public Main()
        {
            InitializeComponent();
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            FullName = FirstName + " " + LastName;
            if (String.IsNullOrEmpty(FirstName))
            {
                txtFirstName.Text = "Input name";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            LastName = txtLastName.Text;
            if (String.IsNullOrEmpty(FirstName))
            {
                txtFirstName.Text = "Input name";
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterClass = listClass.SelectedItem.ToString();
        }

        private void treeRaceSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CharacterRace = treeRaceSelect.SelectedNode.Text;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Text = FirstName + " " + LastName + " - " + txtPlayerName.Text + " - D&D 5th Edition Character Generator";
            FullName = FirstName + " " + LastName;
            lblDisplayFullName.Text = FullName;
            lblDisplayRace.Text = CharacterRace;
            lblDisplayClass.Text = CharacterClass;
            lblDisplayBackground.Text = CharacterBackground;
        }

        private void listBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterBackground = listBackground.SelectedItem.ToString();
        }


    }
}
