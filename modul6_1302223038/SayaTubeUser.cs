using System;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos ;
    private string Username;

    public SayaTubeUser(string Username)
    {
        this.Username = Username;
        this.uploadedVideos = new List<SayaTubeVideo>();

    }

    public int GetTotalVideoPlayCount()
    {
        int totalVideoPlayCount = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            totalVideoPlayCount = uploadedVideos.ElementAt(i).GetPlayCount();
        }
        return totalVideoPlayCount;
    }

    public void AddVideo(SayaTubeVideo stv)
    {
        uploadedVideos.Add(stv);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {id}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {0} judul: {1}", i, uploadedVideos.ElementAt(i));
        }
        
    }

    

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }
    
}