using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class GameManager
    {
        private Player player;
        public List<Enemy> Enemies;

        private int playerHitPoints;
        public int PlayerHitPoints { get { return playerHitPoints; } }
               
        public void EquipItem(string itemName)
        {
            player.EquipItem(itemName);
        }

        public bool CheckPlayerInventory(string itemName)
        {
            return player.Items.Contains(itemName);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }              
        
    }
}
