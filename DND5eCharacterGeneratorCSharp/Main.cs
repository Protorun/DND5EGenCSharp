using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace DND5eCharacterGeneratorCSharp
{
    public partial class MainForm : Form
    {
        readonly List<Character>  CharacterList = new List<Character>();
        String FullName, FirstName, LastName, CharacterRace, CharacterClass, CharacterBackground;

        public MainForm()
        {
            InitializeComponent();
        }


        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = TxtFirstName.Text;
            FullName = FirstName + " " + LastName;
            if (String.IsNullOrEmpty(FirstName))
            {
                TxtFirstName.Text = "Input name";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            LastName = TxtLastName.Text;
            if (String.IsNullOrEmpty(FirstName))
            {
                TxtFirstName.Text = "Input name";
            }
        }

        private void ListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterClass = ListClass.SelectedItem.ToString();
        }

        private void TreeRaceSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CharacterRace = TreeRaceSelect.SelectedNode.Text;
        }

        private void ListBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterBackground = ListBackground.SelectedItem.ToString();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.Text = FirstName + " " + LastName + " - " + " - D&D 5th Edition Character Generator";
            FullName = FirstName + " " + LastName;
            lblDisplayFullName.Text = FullName;
            lblDisplayRace.Text = CharacterRace;
            lblDisplayClass.Text = CharacterClass;
            lblDisplayBackground.Text = CharacterBackground;
            Character ThisToon = new Character(FirstName, LastName, TxtAge.Text, TxtHeight.Text, TxtWeight.Text, CharacterRace, CharacterClass, CharacterBackground);
            CharacterList.Add(ThisToon);
            //lblDisplayFullName.Text = CharacterList[0].FirstName + CharacterList[0].Race + CharacterList[0].Class;
            int Att = Calcs.RollAttribute();
            String AttString = Att.ToString();
            //lblDisplayFullName.Text = "Attribute roll is - " + Att.ToString();
        }

    }
}
