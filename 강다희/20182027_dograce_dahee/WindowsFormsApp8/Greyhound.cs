using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp8
{
    internal class Greyhound
    {
        public int StartingPosition; // PictureBox 시작 위치 : 메소드를 넣으라는데, 각 개마다 시작 위치가 달라서 어떻게 넣어야 할지 모르겠음.
        public int RacetrackLength; //경주 트랙의 길이 : 메소드를 넣으라는데, 경주 트랙의 길이를 어떻게 재야할지 모르겠음.
        public PictureBox MyPictureBox = null; // 이 개의 PictureBox 객체 : 메소드를 넣으라는데, 무슨 메소드를 넣어야 하는지 모르겠음. 각 개의 이름..?
        public int Location = 0; //경주 트랙에서의 위치 : 메소드를 넣으라는데, 개마다 트랙위치가 다 달라서 어떻게 넣어야 할지 모르겠음.
        public Random Randomizer; //Random 객체 인스턴스 : 하단에 Run에서 무작위 전진하라는 내용이 있는 걸로 보아 거기에서 쓰일 거 같음. 근데 메소드를 뭘 넣어야할지 모르겠음.

        public bool Run()
        {
            Random random = new Random();
            int num = random.Next(0, 4);

            //1,2,3,4칸을 무작위로 전진하기 : 화면의 경주 트랙을 1,2,3,4 구간으로 나눠서 매 초마다 이동하는 구간을 다르게 설정하는 코드를 써야하지 않을까 추측..
            //폼에서 픽처박스의 위치 갱신 : 개가 이 초 이동한 거리를 저장해놔야 거기에 더해서 다시 이동할 수 있으므로 위치 갱신이 필요한 거 같은데, 코드를 어떻게 써야할지 모르겠음.

            return true; //경주에서 우승한 경우 true반환 : 개가 결승점 위치에 들어왔을 때는 true, 아닐경우 false를 써야할 거 같은데 어떤 코드를 사용해야할지 모르겠음.
        }

        public void TakeStartingPosition()
        {
            //경주 시작 위치로 돌아가기. : 각 PictureBox의 위치를 다시 제자리로 돌리는 코드가 필요할 거 같은데 뭘 넣어야 할지 모르겠음.
        }
    }
}