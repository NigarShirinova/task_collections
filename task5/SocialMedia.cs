using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class SocialMedia
    {
        public Dictionary<string, List<string>> Users { get; set; }
        public SocialMedia()
        {
            Users = new Dictionary<string, List<string>>();
        }
        public void AddUser(string name, List<string> friendsNames)
        {
            Users.Add(name, friendsNames);
        }
        public void RemoveUser(string name)
        {
            Users.Remove(name);
        }

        public void GetAllFriendsByUsername(string username)
        {
            if (Users.ContainsKey(username))
            {
                foreach (var friend in Users[username])
                {
                    Console.WriteLine($"{friend}");
                }
            }
            else
            {
                Console.WriteLine("This dictionary doesn't contain such as user");
            }
        }

    }
}
