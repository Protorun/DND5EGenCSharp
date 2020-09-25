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
        public Main()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            String FirstName;
            FirstName = txtFirstName.Text;
            //lblFirstName.Text = FirstName;
            if (String.IsNullOrEmpty(FirstName))
            {
                
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CharacterClass;
            CharacterClass = listClass.SelectedItem.ToString();
            //lblAge.Text = CharacterClass;

        }
    }
}
