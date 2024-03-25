using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null && title.Length <= 200, "Judul video harus memiliki panjang max 200 karakter dan tidak boleh null.");

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count > 0 && count <= 25000000, "Input penambahan play count max 10.000.000.");
        Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi max.");
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Penambahan play count melebihi batas maksimal.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
} 