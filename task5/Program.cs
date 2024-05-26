using System;
using task5;

class Program
{
    public static void Main(string[] args)
    {
        SocialMedia instagram = new SocialMedia();
        instagram.AddUser("thenshyrn", new List<string> { "dhjs", "hjak", "wosk" });
        instagram.AddUser("salam", new List<string> { "sakkaman", "dghsj", "dhsjk" });
        instagram.RemoveUser("salam");
        instagram.GetAllFriendsByUsername("thenshyrn");


    }
}