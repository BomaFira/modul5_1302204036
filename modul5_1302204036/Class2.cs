using System;

namespace modul5_1302204036
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo t = new SayaTubeVideo("tutorial...");
            SayaTubeVideo t1 = new SayaTubeVideo("tutorial masak air");
            SayaTubeVideo t2 = new SayaTubeVideo("tutorial ikat tali sepatu");
            SayaTubeVideo t3 = new SayaTubeVideo("tutorial buat akun facebook");
            SayaTubeVideo t4 = new SayaTubeVideo("tutorial buat akun instagram");
            SayaTubeVideo t5 = new SayaTubeVideo("tutorial buat akun tweeter");
            SayaTubeVideo t6 = new SayaTubeVideo("tutorial rakit komputer");
            SayaTubeVideo t7 = new SayaTubeVideo("tutorial instal visual studio code 2022");
            SayaTubeVideo t8 = new SayaTubeVideo("tutorial membuat bolu gulung");
            SayaTubeVideo t9 = new SayaTubeVideo("tutorial tidak ngapa-ngapain");
            SayaTubeVideo t10 = new SayaTubeVideo("tutorial parkour dari lantai 40");

            SayaTubeUser d = new SayaTubeUser("Fahrizal Hilmi");
            t.IncreasePlayCount(1);
            t1.IncreasePlayCount(2);
            t2.IncreasePlayCount(3);
            t3.IncreasePlayCount(4);
            t4.IncreasePlayCount(5);
            t5.IncreasePlayCount(6);
            t6.IncreasePlayCount(7);
            t7.IncreasePlayCount(8);
            t8.IncreasePlayCount(9);
            t9.IncreasePlayCount(10);
            t10.IncreasePlayCount(11);


            d.AddVideo(t);
            d.AddVideo(t1);
            d.AddVideo(t2);
            d.AddVideo(t3);
            d.AddVideo(t4);
            d.AddVideo(t5);
            d.AddVideo(t6);
            d.AddVideo(t7);
            d.AddVideo(t8);
            d.AddVideo(t9);
            d.AddVideo(t10);


            t.PrintVideoDetails();

            d.PrintAllVideoPlaycount();
        }
    }
}