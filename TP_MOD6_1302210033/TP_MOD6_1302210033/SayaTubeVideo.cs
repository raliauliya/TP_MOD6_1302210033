using System;


public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        //menggunakan class random
  
        Random r = new Random();

        this.title = title;

        //sepanjang 5 digit

        id = r.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Details video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}