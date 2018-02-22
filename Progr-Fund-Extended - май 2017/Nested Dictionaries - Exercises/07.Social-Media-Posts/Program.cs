using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Social_Media_Posts
{
    class Program
    {
        class FaceBook
        {
            public int Likes { get; set; }
            public int DisLikes { get; set; }
            public List<string> Comments { get; set; }
            public FaceBook()
            {
                Likes = 0;
                DisLikes = 0;
                Comments = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, FaceBook>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "drop the media")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                if (inputTokens[0] == "post")
                {
                    book[inputTokens[1]] = new FaceBook();
                }
                else if (inputTokens[0] == "like")
                {
                    book[inputTokens[1]].Likes++;
                }
                else if (inputTokens[0] == "dislike")
                {
                    book[inputTokens[1]].DisLikes++;
                }
                else if (inputTokens[0] == "comment")
                {
                    book[inputTokens[1]].Comments.Add($"*  {inputTokens[2]}: {string.Join(" ", inputTokens.Skip(3).ToList())}");
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"Post: {item.Key} | Likes: {item.Value.Likes} | Dislikes: {item.Value.DisLikes}");
                Console.WriteLine($"Comments:");
                if (item.Value.Comments.Count() == 0)
                {
                    Console.WriteLine($"None");
                }
                else
                {
                    foreach (var item2 in item.Value.Comments)
                    {
                        Console.WriteLine(item2);
                    }
                }
            }
        }
    }
}
