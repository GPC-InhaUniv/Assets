using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0323_BaseBall_test
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance > 400) && (ballEventArgs.Trajectory >30))
                {
                    //홈런 Fan : Home run! I'm going for the ball!
                    HomeRun();
                }
                else
                {
                    //아닐경우 울상을 짖는다 //Fan : Woo-hoo! Yeah!
                    WohoYe();
                }

            }
        }

        private void WohoYe()
        {
            Console.WriteLine("Fan : Woo-hoo! Yeah!");
        }

        private void HomeRun()
        {
            Console.WriteLine("Fan : Home run! I'm going for the ball!");
        }
    }
}
