using System.Drawing;
namespace HeadFirst_Invader
{
    abstract class InvaderFactory
    {

        private const int invaderInterval = 100;

        private const int StarInvaderScore = 10;
        private const int BugInvaderScore = 30;
        private const int SpaceInvaderScore = 40;
        private const int SatelliteInvaderScore = 50;
        private const int SaucerInvaderScore = 20;

        private static int starxpos = 200;
        private static int starypos = 250;

        private static int spacexpos = 200;
        private static int spaceypos = 100;

        private static int bugxpos = 200;
        private static int bugypos = 150;

        private static int saucerxpos = 200;
        private static int saucerypos = 200;

        private static int satellitexpos = 200;
        private static int satelliteypos = 50;

        public static Invader MakeInvader(InvaderType invaderType)
        {

            Point starInvaderPos = new Point(starxpos, starypos);
            Point spaceInvaderPos = new Point(spacexpos, spaceypos);
            Point saucerInvaderPos = new Point(saucerxpos, saucerypos);
            Point bugInvaderPos = new Point(bugxpos, bugypos);
            Point satelliteInvaderPos = new Point(satellitexpos, satelliteypos);


            switch (invaderType)
            {
                case InvaderType.Star:
                    starxpos += invaderInterval;
                    return new Invader(InvaderType.Star, starInvaderPos, StarInvaderScore);

                case InvaderType.Bug:
                    bugxpos += invaderInterval;
                    return new Invader(InvaderType.Bug, bugInvaderPos, BugInvaderScore);

                case InvaderType.Spaceship:
                    spacexpos += invaderInterval;
                    return new Invader(InvaderType.Spaceship, spaceInvaderPos, SpaceInvaderScore);

                case InvaderType.Satellite:
                    satellitexpos += invaderInterval;
                    return new Invader(InvaderType.Satellite, satelliteInvaderPos, SatelliteInvaderScore);

                case InvaderType.Saucer:
                    saucerxpos += invaderInterval;
                    return new Invader(InvaderType.Saucer, saucerInvaderPos, SaucerInvaderScore);

                default:
                    return null;

            }
        }
    }
}
