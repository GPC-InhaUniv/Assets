using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class Bow : Weapon
    {
        public Bow (Game game, Point location) : base(game, location) { }

        public override string Name { get { return "최후의속삭임"; } }

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i < game.MinionList.Count; i++)
                if(direction == Direction.위쪽)
                {
                    if (Math.Abs(game.PlayerLocation.X - game.MinionList[i].Location.X) < 20 && Math.Abs(game.PlayerLocation.Y - game.MinionList[i].Location.Y) < 80 && game.PlayerLocation.Y >= game.MinionList[i].Location.Y)
                    {
                        game.MinionList[i].MinionHit(2, random);
                    }
                }else if(direction == Direction.아래쪽)
                {
                    if (Math.Abs(game.PlayerLocation.X - game.MinionList[i].Location.X) < 20 && Math.Abs(game.PlayerLocation.Y - game.MinionList[i].Location.Y) < 80 && game.PlayerLocation.Y <= game.MinionList[i].Location.Y)
                    {
                        game.MinionList[i].MinionHit(2, random);
                    }
                }
                else if(direction == Direction.왼쪽)
                {
                    if (Math.Abs(game.PlayerLocation.X - game.MinionList[i].Location.X) < 80 && Math.Abs(game.PlayerLocation.Y - game.MinionList[i].Location.Y) < 20 && game.PlayerLocation.X >= game.MinionList[i].Location.X)
                    {
                        game.MinionList[i].MinionHit(2, random);
                    }
                }
                else
                {
                    if (Math.Abs(game.PlayerLocation.X - game.MinionList[i].Location.X) < 80 && Math.Abs(game.PlayerLocation.Y - game.MinionList[i].Location.Y) < 20 && game.PlayerLocation.X <= game.MinionList[i].Location.X)
                    {
                        game.MinionList[i].MinionHit(2, random);
                    }
                }
                
        }
    }
}
