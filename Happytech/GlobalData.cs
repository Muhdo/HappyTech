using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Happytech.Classes;

namespace Happytech
{
    public class ApplicationReviewing
    {
        public static List<int> ToBeReviewed = new List<int>();

        public static string GetMessage(string name, int[] comments)
        {
            Database db = new Database();

            string opening = $"Hello {name},\n\nAfter Reviewing your application we have concluded that.";
            string ending = $"\nThank you for your interest in working at HappyTech.\nWe hope to see you again.\n\nBest Regards,\n{CurrentEmployee.Name}.\n{CurrentEmployee.Role}.";

            string finalMessage = $"{opening}\n";

            foreach (int comment in comments)
            {
                string com = db.GetComment(comment);

                finalMessage = string.Concat(finalMessage, com, "\n");
            }

            return string.Concat(finalMessage, ending);;
        }
    }

    class UserPages
    {
        public static string firstAction { get; set; }
    }

    public class CurrentEmployee
    {
        public static int Id;
        public static string Name;
        public static string Role;
        public static bool IsAdmin;

        public void SetEmployee(int id, string name, string role, bool isAdmin)
        {
            CurrentEmployee.Id = id;
            CurrentEmployee.Name = name;
            CurrentEmployee.Role = role;
            CurrentEmployee.IsAdmin = isAdmin;
        }
    }
}
