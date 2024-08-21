# LibrarySystem

LibrarySystem is a console-based library management system written in C#. It allows users to sign in or sign up as either a customer or a librarian, and provides functionality for borrowing books, displaying borrowed books, and managing the library's book collection.

## Features

- **Sign In / Sign Up**: Users can sign in if they have an existing account or sign up to create a new account.
- **Customer Mode**: Allows customers to display borrowed books and borrow new books from the library.
- **Librarian Mode**: Provides librarians with options to display all books, add new books, remove existing books, and display customer information.

## Classes

### LibrarySystem

The main class that manages the library operations. It includes methods for starting the application, signing in, signing up, and handling different modes for customers and librarians.

#### Methods

- **StartApp()**: Initializes the application.
- **WelComeApp()**: Displays the welcome message and provides options to sign in, sign up, or exit the application.
- **SignIn()**: Handles the sign-in process for customers and librarians.
- **SignUp()**: Handles the sign-up process for new customers and librarians.
- **ModeCustomer(Customer cust)**: Manages the customer mode, allowing customers to display or borrow books.
- **ModeLibrarian(Librarian lib)**: Manages the librarian mode, allowing librarians to display, add, and remove books, and display customer information.

#### Private Members

- **List<Book> books**: A list of books available in the library.
- **List<Customer> customers**: A list of registered customers.
- **List<Librarian> librarians**: A list of registered librarians.

## Usage

### Run the Application

Execute the application to start the library system.

### Welcome Screen

You will be greeted with a welcome message and options to sign in, sign up, or exit the application.

### Sign In / Sign Up

Choose to sign in if you already have an account, or sign up to create a new account.

For sign-up, you can choose to register as a customer (`cust`) or librarian (`lib`).

### Customer Mode

Once signed in as a customer, you can:

- Display borrowed books.
- Borrow new books from the library.

### Librarian Mode

Once signed in as a librarian, you can:

- Display all books in the library.
- Add new books to the library.
- Remove existing books from the library.
- Display customer information.
