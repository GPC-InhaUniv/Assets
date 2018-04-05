using System.Drawing;

namespace HeadFirst_Invader
{
    class Items : Objects
    {
        private ItemType itemType;
        public ItemType ItemType { get { return itemType; } }

        Bitmap bitmap;
        Game game;
        public Items(ItemType item, Game game)
        {

            this.game = game;
            this.itemType = item;
            this.Alive = false;
            string path = "";

            if (this.itemType == ItemType.HpPortion)
            {
                path = @"images\portion.png";
                bitmap = new Bitmap(path);
            }

            else if (this.itemType == ItemType.BulletPortion)
            {
                path = @"images\AttackPortion.png";
                bitmap = new Bitmap(path);
            }


        }

        public void DropItem(Point p)
        {
            this.location = p;
            this.Alive = true;
        }




        public void GetItem(Player p)
        {
            if (p.Location.X <= location.X + 30 && p.Location.X >= location.X - 30
                && p.Location.Y <= location.Y + 10 && p.Location.Y >= location.Y - 10)
            {
                this.Alive = false;
                this.location.X = -10;
                this.location.Y = -10;
                if (this.itemType == ItemType.HpPortion)
                {
                    game.GetHpItem();
                    p.GetHp();
                }
                else if (this.itemType == ItemType.BulletPortion)
                    game.GetBulletItem();

            }

        }




        public override void Draw(Graphics g)
        {
            if (this.Alive)
            {

                g.DrawImage(bitmap, this.location);


            }
        }


        public override void Move(Direction direction)
        {
            location.Y += 5;
            if (location.Y >= game.Boundaries.Bottom - 50)
            {
                this.Alive = false;
                location.X = -10;
                location.Y = -10;
            }
        }
    }
}
