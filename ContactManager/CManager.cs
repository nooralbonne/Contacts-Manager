using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class CManager
    {
        public static List<string> ContactsManager(List<string> contacts, string action, string name = "")
        {
            switch (action)
            {
                case "add":
                    if (!string.IsNullOrEmpty(name))
                    {
                        AddContact(contacts, name);
                    }
                    break;
                case "remove":
                    if (!string.IsNullOrEmpty(name))
                    {
                        RemoveContact(contacts, name);
                    }
                    break;
                case "view":
                    return ViewAllContacts(contacts);
                default:
                    throw new ArgumentException("Invalid action specified");
            }
            return contacts;
        }

        public static List<string> AddContact(List<string> contacts, string name)
        {
            if (!contacts.Contains(name))
            {
                contacts.Add(name);
            }
            return contacts;
        }

        public static List<string> RemoveContact(List<string> contacts, string name)
        {
            contacts.Remove(name);
            return contacts;
        }

        public static List<string> ViewAllContacts(List<string> contacts)
        {
            return new List<string>(contacts);
        }
    }
}
