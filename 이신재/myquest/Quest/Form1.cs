using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Quest
{
    public partial class Form1 : Form
    {
        Game game = new Game(new Rectangle(120, 20, 675, 320));

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters() //캐릭터 업데이트
        {
            pctplayer.Location = game.PlayerLocation;
            txtplayerhp.Text = game.PlayerHitPoints.ToString();


           
           
        }

        

        private void btnmoveup_Click(object sender, EventArgs e)
        {
            game.Move(enumDirection.Up, random);
            UpdateCharacters();

        }

        private void btnmovedown_Click(object sender, EventArgs e)
        {
            game.Move(enumDirection.Down, random);
            UpdateCharacters();
        }

        private void btnmoveleft_Click(object sender, EventArgs e)
        {
            
            game.Move(enumDirection.Left, random);
            UpdateCharacters();
        }

        private void btnmoveright_Click(object sender, EventArgs e)
        {
            game.Move(enumDirection.Right, random);
            UpdateCharacters();
        }

        private void pctbluepotion_Click(object sender, EventArgs e)
        {

        }
    }
}
