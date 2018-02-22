using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class Program
    {
        class Message
        {
            public string Content { get; set; }
            public string Sender { get; set; }
        }
        class User
        {
            public string Username { get; set; }
            public List<Message> ReceivedMessages { get; set; }
            public User(string userName)
            {
                Username = userName;
                ReceivedMessages = new List<Message>();
            }
        }
        static void Main(string[] args)
        {
            var book = new List<User>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                if (inputTokens[0] == "register")
                {
                    book.Add(new User(inputTokens[1]));
                }
                else
                {
                    var senderName = inputTokens[2];
                    var recipientUsername = inputTokens[0];
                    var content = inputTokens[3];
                    if (book.All(a => a.Username != senderName) || book.All(a => a.Username != recipientUsername))
                    {
                        continue;
                    }
                    var newMessage = new Message();
                    newMessage.Sender = senderName;
                    newMessage.Content = content;
                    foreach (var item in book.Where(a => a.Username == recipientUsername))
                    {
                        item.ReceivedMessages.Add(newMessage);
                    }
                }
            }
            var messageBetweenNames = Console.ReadLine().Split(' ').ToArray();
            var firstPersonMessages = new List<string>();
            var secondPersonMessages = new List<string>();           
            foreach (var item in book.Where(a => a.Username == messageBetweenNames[0]))
            {
                foreach (var item2 in item.ReceivedMessages.Where(a => a.Sender == messageBetweenNames[1]))
                {
                    firstPersonMessages.Add(item2.Content);
                }
            }
            foreach (var item in book.Where(a => a.Username == messageBetweenNames[1]))
            {
                foreach (var item2 in item.ReceivedMessages.Where(a => a.Sender == messageBetweenNames[0]))
                {
                    secondPersonMessages.Add(item2.Content);
                }
            }
            if (firstPersonMessages.Count() == 0 && secondPersonMessages.Count() == 0)
            {
                Console.WriteLine($"No messages");
            }
            for (int i = 0; i < Math.Max(firstPersonMessages.Count(), secondPersonMessages.Count()); i++)
            {
                if (firstPersonMessages.Count - 1 >= i)
                {
                    Console.WriteLine($"{messageBetweenNames[0]}: {firstPersonMessages[i]}");
                }
                if (secondPersonMessages.Count - 1 >= i)
                {
                    Console.WriteLine($"{secondPersonMessages[i]} :{messageBetweenNames[1]}");
                }
            }
        }
    }
}
