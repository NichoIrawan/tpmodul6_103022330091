using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 100);

            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul harus kurang dari 100 karakter");

            this.title = checked(title);

            Random r = new Random();
            id = r.Next(99999);
            playCount = 0;
        }

        public void increasePlayCount()
        {
            try
            {
                playCount = checked(playCount + 10000000);
                Contract.EnsuresOnThrow<OverflowException>(playCount < int.MaxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine("Penonton melebihi batas");
                return;
            }

        }

        public void printVideoDetails()
        {
            Console.WriteLine($"Video dengan id {id} dan judul {title} " +
                $"telah dimainkan sebanyak {playCount}");
        }
    }
}
