using System;

class Program
{
    static void Main()
    {

        SayaTubeUser user = new SayaTubeUser("ArgaAAL");

        SayaTubeVideo video1 = null;
        SayaTubeVideo video2 = null;
        SayaTubeVideo video3 = null;
        SayaTubeVideo video4 = null;
        SayaTubeVideo video5 = null;
        SayaTubeVideo video6 = null;
        SayaTubeVideo video7 = null; 
        SayaTubeVideo video8 = null;
        SayaTubeVideo video9 = null;
        SayaTubeVideo video10 = null;



        try
        {
            video1 = new SayaTubeVideo("Review Film Rush oleh Arga Adolf Lumunon");
            video2 = new SayaTubeVideo("Review Film Mada oleh Arga Adolf Lumunon");
            video3 = new SayaTubeVideo("Review Film Gey oleh Arga Adolf Lumunon");
            video4 = new SayaTubeVideo("Review Film Hei oleh Arga Adolf Lumunon");
            video5 = new SayaTubeVideo("Review Film Wadaw oleh Arga Adolf Lumunon");
            video6 = new SayaTubeVideo("Review Film Ultraboost oleh Arga Adolf Lumunon");
            video7 = new SayaTubeVideo("Review Film Lexi oleh Arga Adolf Lumunon");
            video8 = new SayaTubeVideo("Review Film XMAX oleh Arga Adolf Lumunon");
            video9 = new SayaTubeVideo("Review Film Spion oleh Arga Adolf Lumunon");
            video10 = new SayaTubeVideo("Review Film Halo oleh Arga Adolf Lumunon");

            video1.IncreasePlayCount(1);
            video2.IncreasePlayCount(1);
            video3.IncreasePlayCount(1);
            video4.IncreasePlayCount(1);
            video5.IncreasePlayCount(1);
            video6.IncreasePlayCount(1);
            video7.IncreasePlayCount(1);
            video8.IncreasePlayCount(1);
            video9.IncreasePlayCount(1);
            video10.IncreasePlayCount(1);

            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);
        }
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            user.PrintAllVideoPlayCount();

        }
    }
}