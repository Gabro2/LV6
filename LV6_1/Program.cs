using System;
using System.Collections.Generic;

namespace LV6_1
{
    class Program
    {
        private static Dictionary<string, Post> posts;
        private static Dictionary<string, Post> postscopies;
        static void Main(string[] args)
        {
            RunSimpleDemo();
        }

        static void RunSimpleDemo()
        {
            posts = new Dictionary<string, Post>();
            postscopies = new Dictionary<string, Post>();
            posts.Add("Patrik1", new Post("Patrik1","Aloha"));
            posts.Add("Patrik2", new Post("Patrik2","Pozz"));
            posts.Add("Mirko", new Post("Mirko","Hello"));
            foreach (var post in posts)
            {
                Console.WriteLine(post.Value+Environment.NewLine);
            }
            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Key} unesi svoj/e hashtag/hashtagove:");
                string input;
                do
                {
                    input = Console.ReadLine();
                    post.Value.Tag(input);
                } while (input != string.Empty);
            }
            Console.WriteLine("-------");
            Console.WriteLine("Copies:");
            Console.WriteLine("-------");
            foreach (var post in posts)
            {
                postscopies.Add(post.Key, new Post(post.Value));
                postscopies[post.Key].Untag();
                Console.WriteLine(postscopies[post.Key] + Environment.NewLine);
            }
            Console.WriteLine("---------");
            Console.WriteLine("Original:");
            Console.WriteLine("---------");
            foreach (var post in posts)
            {
                Console.WriteLine(post.Value + Environment.NewLine);
            }
        }
    }
}
