using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Student_Groups
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }
        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }
        static void Main(string[] args)
        {
            var towns = new List<Town>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input.Contains("=>"))
                {
                    var newTown = new Town();
                    var inputTokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var townName = inputTokens[0];
                    var seats = inputTokens[1].Split(' ').ToArray();
                    var totalSeats = int.Parse(seats[0]);
                    newTown.Name = townName;
                    newTown.SeatsCount = totalSeats;
                    newTown.Students = new List<Student>();
                    towns.Add(newTown);
                }
                else
                {
                    var newStudentObj = new Student();
                    var inputTokens = input.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
                    var name = inputTokens[0];
                    var email = inputTokens[1];
                    var date = DateTime.ParseExact(inputTokens[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    newStudentObj.Name = name;
                    newStudentObj.Email = email;
                    newStudentObj.RegistrationDate = date;
                    towns[towns.Count() - 1].Students.Add(newStudentObj);
                }
            }
            var groups = new List<Group>();
            foreach (var town in towns.OrderBy(a => a.Name))
            {
                var students = town.Students.OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name).ThenBy(a => a.Email);
                var skippedStudents = 0;
                while (skippedStudents <= students.Count() - 1)
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Skip(skippedStudents).Take(group.Town.SeatsCount).ToList();
                    skippedStudents += group.Town.SeatsCount;
                    groups.Add(group);
                }
            }
            Console.WriteLine($"Created {groups.Count()} groups in {towns.Count()} towns:");
            foreach (var item in groups.OrderBy(a => a.Town.Name))
            {
                var emails = new List<string>();
                item.Students.ToList().ForEach(a => emails.Add(a.Email));
                Console.WriteLine($"{item.Town.Name} => {string.Join(", ", emails)}");
            }
        }
    }
}
