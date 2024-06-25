namespace ContactManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };

            while (true)
            {
                // Display menu options
                Console.WriteLine("What operation do you want to perform?");
                Console.WriteLine("1. Add a contact");  
                Console.WriteLine("2. Remove a contact");
                Console.WriteLine("3. View all contacts");
                Console.WriteLine("4. Exit");

                // Get user choice
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the contact to add: ");
                        string nameToAdd = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(nameToAdd))
                        {
                            List<string> resultAdd = CManager.ContactsManager(contacts, "add", nameToAdd);
                            Console.WriteLine($"Contacts after adding {nameToAdd}:");
                            resultAdd.ForEach(contact => Console.WriteLine(contact));
                            contacts = resultAdd; // Update contacts list
                        }
                        else
                        {
                            Console.WriteLine("Invalid contact name. Please enter a non-empty name.");
                        }
                        break;
                    case "2":
                        Console.Write("Enter the name of the contact to remove: ");
                        string nameToRemove = Console.ReadLine().Trim();
                        List<string> resultRemove = CManager.ContactsManager(contacts, "remove", nameToRemove);
                        Console.WriteLine($"Contacts after removing {nameToRemove}:");
                        resultRemove.ForEach(contact => Console.WriteLine(contact));
                        contacts = resultRemove; // Update contacts list
                        break;
                    case "3":
                        List<string> resultView = CManager.ContactsManager(contacts, "view");
                        Console.WriteLine("Current contacts:");
                        resultView.ForEach(contact => Console.WriteLine(contact));
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program...");
                        return; // Exit the Main method
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }

                Console.WriteLine(); // Add a blank line for better readabili
            }
        }
    }
}
