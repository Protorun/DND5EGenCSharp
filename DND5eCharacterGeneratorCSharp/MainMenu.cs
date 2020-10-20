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
    public partial class MainMenu : Form
    {
        //private Form NewCharacter;
        private Form LoadCharacter;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnNewCharacter_Click(object sender, EventArgs e)
        {
            Form NewCharacter = new NewToon();
            this.Hide();
            NewCharacter.Show();
        }

        private void BtnLoadCharacter_Click(object sender, EventArgs e)
        {
            LoadCharacter = new LoadToon();
            this.Hide();
            LoadCharacter.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Feats.InitialiseFeats();
        }
    }
}
