namespace ContactManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_AddContact()
        {
            // Arrange
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };
            string action = "add";
            string name = "David";

            // Act
            List<string> result = ContactManager.CManager.ContactsManager(new List<string>(contacts), action, name);

            // Assert
            Assert.Contains("David", result);
        }

        [Fact]
        public void Test_AddContact_AlreadyExists()
        {
            // Arrange
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };
            string action = "add";
            string name = "Alice";

            // Act
            List<string> result = ContactManager.CManager.ContactsManager(new List<string>(contacts), action, name);

            // Assert
            Assert.Equal(3, result.Count); // No new contact should be added
            Assert.Equal(contacts, result); // Check that the original list remains the same
        }

        [Fact]
        public void Test_RemoveContact()
        {
            // Arrange
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };
            string action = "remove";
            string name = "Bob";

            // Act
            List<string> result = ContactManager.CManager.ContactsManager(new List<string>(contacts), action, name);

            // Assert
            Assert.DoesNotContain("Bob", result);
        }

        [Fact]
        public void Test_RemoveContact_NotExists()
        {
            // Arrange
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };
            string action = "remove";
            string name = "David";

            // Act
            List<string> result = ContactManager.CManager.ContactsManager(new List<string>(contacts), action, name);

            // Assert
            Assert.Equal(3, result.Count); // No contact should be removed
            Assert.Equal(contacts, result); // Check that the original list remains the same
        }

        [Fact]
        public void Test_ViewAllContacts()
        {
            // Arrange
            List<string> contacts = new List<string> { "Alice", "Bob", "Charlie" };
            string action = "view";

            // Act
            List<string> result = ContactManager.CManager.ContactsManager(new List<string>(contacts), action);

            // Assert
            Assert.Equal(contacts, result);
        }
    }
}