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
        Game game = new Game(new Rectangle(120, 20, 675, 280));
       
        private Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();

            pctsword.Visible = false;
            pctbow.Visible = false;
            pctaxe.Visible = false;
            pctredpotion.Visible = false;
            pctbluepotion.Visible = false;

            pctinvenaxe.Visible = false;
            pctinvensword.Visible = false;
            pctinvenbow.Visible = false;
            pctinvenbluepotion.Visible = false;
            pctinvenredpotion.Visible = false;


            


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
