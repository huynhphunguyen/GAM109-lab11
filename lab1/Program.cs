using System;


public static class UserData
{
    public static string id;
    public static string username;
    public static string gold;
    public static string point;

    static UserData() 
    {
        id = "1803";
        username = "nguyen";
        
    }

    public static void ShowData()
    {
        Console.WriteLine("Id : "+ id);
        Console.WriteLine("username : "+username);
        
    }

    public class Program
    {
        public static int Main(string[] args)
        {
            UserData.ShowData();
            return 0;
        }
    }
}




