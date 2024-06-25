# ContactManager

This project is a simple contact management application written in C#. It allows you to add, remove, and view contacts using a console application and includes unit tests for each functionality.

## Getting Started

### Prerequisites

- .NET Core SDK
- A code editor like Visual Studio or Visual Studio Code

### Running the Application

1. Clone the repository to your local machine:

    ```sh
    git clone https://github.com/yourusername/ContactManager.git
    cd ContactManager
    ```

2. Build the project:

    ```sh
    dotnet build
    ```

3. Run the application:

    ```sh
    dotnet run --project ContactManager
    ```

### Running the Tests

1. Navigate to the test project directory:

    ```sh
    cd ContactManagerTests
    ```

2. Run the tests:

    ```sh
    dotnet test
    ```

## Project Structure

- `ContactManager/Program.cs`: Contains the main application code to manage contacts.
- `ContactManager/CManager.cs`: Contains the logic for adding, removing, and viewing contacts.
- `ContactManagerTests/UnitTest1.cs`: Contains unit tests to verify the functionality of the contact manager.

## Usage

The application supports three actions: `add`, `remove`, and `view`. It interacts with the user via the console, repeatedly asking for the operation to perform until the user chooses to exit.

### Example Operations

1. **Add a Contact**
    - Prompts the user to enter a contact name to add to the list.
    - Example: Adding `"David"` to the list of contacts.

2. **Remove a Contact**
    - Prompts the user to enter a contact name to remove from the list.
    - Example: Removing `"David"` from the list of contacts.

3. **View All Contacts**
    - Displays all contacts currently in the list.

4. **Exit**
    - Exits the application.

### Initial Contacts

The application starts with the following contacts:
- `"Alice"`
- `"Bob"`
- `"Charlie"`

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
