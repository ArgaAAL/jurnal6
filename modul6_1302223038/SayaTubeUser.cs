using System;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos ;
    private string Username;

    public SayaTubeUser(string Username)
    {
        Contract.Requires(Username != null && Username.Length <= 200, "Username harus memiliki panjang max 100 karakter dan tidak boleh null.");
        this.id = GenerateRandomId();
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
        Contract.Requires(stv != null && stv.GetPlayCount() <= int.MaxValue, "Video yang ditambahkan tidak boleh null.");
        uploadedVideos.Add(stv);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 1; i < uploadedVideos.Count; i++)
        {
            if (i > 8)
            {
                break;
            }
            Console.WriteLine($"Video {i} judul: {uploadedVideos.ElementAt(i).GetTitle()} Play Count :{uploadedVideos.ElementAt(i).GetPlayCount()} " );
        }
        
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }
    
}