using System;

public class Maps
{
    public string id;
    public string userName;
    public static string _inGame = " lmht";

    public Maps(string id, string userName)
    {
        this.id = id;
        this.userName = userName;
    }
    public string ShowData()
    {
        return "ID: " + id + "Name: " + userName + "InGame: " + _inGame;
    }

}
public class Program
{
    public static int Main(string[] args)
    {
        Maps maps = new Maps("2024", "URF");
        Console.WriteLine(maps.ShowData());
        return 0;
    }
}

