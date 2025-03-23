using tpmodul6_103022330091;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo(
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" +
            "Tutorial Design By Contract – Nicholas Putra Irawan" + ""
            );

        for (int i = 1; i < 216;  i++) {
            video.increasePlayCount();
        }

        video.printVideoDetails();
    }

}