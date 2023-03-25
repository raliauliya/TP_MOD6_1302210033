using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        //menggunakan class random
        Contract.Requires(title.Length < 100);
        Contract.Requires(title != null);

        Random r = new Random();

        this.title = title;

        //sepanjang 5 digit

        id = r.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount <= 10000000);
        try
        {
            int cek = checked(this.playCount + playCount);
            this.playCount = cek;
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Overflow Exception : " + ex.Message);
        }

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Details video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}