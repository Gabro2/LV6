using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_1
{
    class Post
    {
        private string name, message;
        List<string> hashtags = new List<string>();
        DateTime time;
        public Post(string name, string message)
        {
            this.name = name;
            this.message = message;
            time = DateTime.Now;
        }
        public Post(Post post)
        {
            hashtags = new List<string>();
            hashtags.AddRange(post.hashtags);
            name = post.name;
            message = post.message;
            time = post.time;
        }
        public void Tag(string hashtag)
        {
            hashtags.Add(hashtag);
        }
        public void Untag(string hashtag)
        {
            hashtags.Remove(hashtag);
        }
        public void Untag()
        {
            hashtags.Clear();
        }
        public override string ToString()
        {
            string hashtags = string.Join(" ", this.hashtags);
            return $"{name}" + $"\n{message}\n{(hashtags != string.Empty ? hashtags : "*No hashtags found*")}\n{time}";
        }
    }
}
