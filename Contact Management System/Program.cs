using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayContact()
    {
        Console.WriteLine($"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();

        while (true)
        {
            Console.WriteLine("---- Contact Management System ----");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Edit Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact(contacts);
                    break;
                case "2":
                    ViewAllContacts(contacts);
                    break;
                case "3":
                    SearchContact(contacts);
                    break;
                case "4":
                    EditContact(contacts);
                    break;
                case "5":
                    DeleteContact(contacts);
                    break;
                case "6":
                    Console.WriteLine("Exiting the application ...");
                    break;
                default:
                    Console.WriteLine("Enter a valid operaiton !!");
                    break;
            }
        }
    }

    static void AddContact(List<Contact> contacts)
    {
        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        string email = Console.ReadLine();

        Contact newContact = new Contact(name, phoneNumber, email);
        contacts.Add(newContact);
        Console.WriteLine("Contact Added Successfully !");
    }

    static void ViewAllContacts(List<Contact> contacts)
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found ! \n");
        }
        else
        {
            Console.WriteLine("--- Contact List ---");
            foreach (Contact contact in contacts)
            {
                contact.DisplayContact();
            }
            Console.WriteLine();
        }
    }

    void EditContact(List<Contact> contacts)
    {
        Console.WriteLine("Enter the name of the contact to edit: ");
        string searchName = Console.ReadLine();
        Contact foundContact = Contact.Find(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (foundContact != null)
        {
            Console.WriteLine("Enter new name: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter new phone number: ");
            string newPhone = Console.ReadLine();
            Console.WriteLine("Enter new email: ");
            string newEmail = Console.ReadLine();

            if (!string.IsNullOrEmpty(newName)) foundContact.Name = newName;
            if (!string.IsNullOrEmpty(newPhone)) foundContact.Phonenumber = newPhone;
            if (!string.IsNullOrEmpty(newEmail)) foundContact.Email = newEmail;

            Console.WriteLine("Contact Updated Successfully !");
        }
        else
        {
            Console.WriteLine("Contact not found !");
        }
    }

    static void SearchContact(List<Contact> contacts)
    {
        Console.WriteLine("Enter the name of the contact to search: ");
        string searchName = Console.ReadLine();

        if (foundContact != null)
        {
            Console.WriteLine("Contact found !");
            foundContact.DisplayContact();
        }
        else
        {
            Console.WriteLine("Contact Not Found !");
        }
    }

    static void DeleteContact(List<Contact> contacts)
    {
        Console.WriteLine("Enter the name of the contact you want to delete: ");
        string deleteName = Console.ReadLine();
        Contact foundContact = contacts.Find(c => c.Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase));

        if (foundContact != null)
        {
            contacts.Remove(foundContact);
            Console.WriteLine("Contact deleted successfully !");
        }
        else
        {
            Console.WriteLine("Contact Not Found !");
        }
    }
}