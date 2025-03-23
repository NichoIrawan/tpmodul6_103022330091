using tpmodul6_103022330091;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo(
            "Tutorial Design By Contract – Nicholas Putra Irawan"
            );

        video.increasePlayCount(3);

        video.printVideoDetails();
    }

}