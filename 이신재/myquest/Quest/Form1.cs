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
        Game game;
        
        private Random random = new Random();
        Control ItemControl;

        public Form1()
        {
            InitializeComponent();
            game = new Game(new Rectangle(78,57,420,155));
            game.NewLevel(random);

            pctsword.Visible = false;
            pctbow.Visible = false;
            pctaxe.Visible = false;
            pctredpotion.Visible = false;
            pctbluepotion.Visible = false;

            pctteemo.Visible = false;
            pctyasuo.Visible = false;
            pctmasterei.Visible = false;

        }

        private void UpdateCharacters() //캐릭터 업데이트
        {
            
            pctplayer.Location = game.PlayerLocation;
            txtplayerhp.Text = game.PlayerHitPoints.ToString();
            

            bool showTeemo = false;
            bool showYasuo = false;
            bool showMasterei = false;

            int monstersShown = 0;
            
            foreach (Monster monster in game.Monsters) //Monsters에 null걸림
            {
                if (monster is Teemo)
                {
                    pctteemo.Location = monster.Location;
                    txtteemohp.Text = monster.HitPoints.ToString();
                    if (monster.HitPoints > 0)
                    {
                        pctteemo.Visible = true;
                        monstersShown++;
                    }
                }
            }

            foreach (Monster monster in game.Monsters)
            {
                if (monster is Yasuo)
                {
                    pctyasuo.Location = monster.Location;
                    txtyasuohp.Text = monster.HitPoints.ToString();
                    if (monster.HitPoints > 0)
                    {
                        pctyasuo.Visible = true;
                        monstersShown++;
                    }
                }

            }
            foreach (Monster monster in game.Monsters)
            {
                if (monster is Masterei)
                {
                    pctmasterei.Location = monster.Location;
                    txtmastereihp.Text = monster.HitPoints.ToString();
                    if (monster.HitPoints > 0)
                    {
                        pctmasterei.Visible = true;
                        monstersShown++;

                    }
                }
            }
            
            ItemControl = null;

            switch (game.ItemInRoom.Name)
            {
                case "Sword":
                    ItemControl = pctsword; break;
                case "Bow":
                    ItemControl = pctbow; break;
                case "Axe":
                    ItemControl = pctaxe; break;
                case "RedPotion":
                    ItemControl = pctredpotion; break;
                case "BluePotion":
                    ItemControl = pctbluepotion; break;
            }

            ItemControl.Visible = true;

            ItemControl.Location = game.ItemInRoom.Location;
            if(game.ItemInRoom.PickedUp)
            {
                ItemControl.Visible = false;
            }
            else
            {
                ItemControl.Visible = false;
            }
            if(game.PlayerHitPoints <=0)
            {
                MessageBox.Show("Game over...");
                Application.Exit();
            }
            if (monstersShown < 1)
            {
                MessageBox.Show("Game Clear!!");
                game.NewLevel(random);
                UpdateCharacters();
            }
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

        private void btnattackup_Click(object sender, EventArgs e)
        {
            game.Attack(enumDirection.Up, random);
            UpdateCharacters();
        }

        private void btnattackleft_Click(object sender, EventArgs e)
        {
            game.Attack(enumDirection.Left, random);
            UpdateCharacters();
        }

        private void btnattackright_Click(object sender, EventArgs e)
        {
            game.Attack(enumDirection.Right, random);
            UpdateCharacters();
        }

        private void btnattackdown_Click(object sender, EventArgs e)
        {
            game.Attack(enumDirection.Down, random);
            UpdateCharacters();
        }
    }
}
