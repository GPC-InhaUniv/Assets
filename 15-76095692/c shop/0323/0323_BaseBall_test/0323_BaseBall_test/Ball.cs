using System;

namespace _0323_BaseBall_test
{
    public class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            //if (BallInPlay != null)
            //{
            //    BallInPlay(this, e);
            //}
            BallInPlay?.Invoke(this, e);
        }
    }
}