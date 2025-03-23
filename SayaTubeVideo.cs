using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022330091
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random r = new Random();

            id = r.Next(99999);
            this.title = title;
            playCount = 0;
        }

        public void increasePlayCount(int i)
        {
            playCount += i;
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"Video dengan id {id} dan judul {title} " +
                $"telah dimainkan sebanyak {playCount}");
        }
    }
}
