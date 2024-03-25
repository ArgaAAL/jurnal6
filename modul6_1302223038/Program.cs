using System;

class Program
{
    static void Main()
    { 

        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Rush oleh Arga Adolf Lumunon");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Mada oleh Arga Adolf Lumunon");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Gey oleh Arga Adolf Lumunon");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Hei oleh Arga Adolf Lumunon");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Wadaw oleh Arga Adolf Lumunon");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Ultraboost oleh Arga Adolf Lumunon");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Lexi oleh Arga Adolf Lumunon");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film XMAX oleh Arga Adolf Lumunon");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Spion oleh Arga Adolf Lumunon");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Halo oleh Arga Adolf Lumunon");

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


        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();
        video7.PrintVideoDetails();
        video8.PrintVideoDetails();
        video9.PrintVideoDetails();
        video1.PrintVideoDetails();




    }
}