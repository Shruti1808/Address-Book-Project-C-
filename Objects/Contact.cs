using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _address;
    private int _id;
    private static List<Contact> _Contactlist = new List<Contact> {};
    //  Create Contact Constructor..........>
    public Contact (string firstName , string lastName, string phoneNumber, string address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _address = address;
      _Contactlist.Add(this);
      _id = _Contactlist.Count;               //Gives each contact an ID  to organize it
    }
    //  Getters and Setters..............................>
    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    //To show list of all Contacts........................>
    public static List<Contact> GetAll()
    {
      return _Contactlist;
    }
    // Clear all contacts from the list............>
    public static void ClearAll()
    {
      _Contactlist.Clear();
    }
    public static Contact Find(int searchId)
        {
          return _Contactlist[searchId-1];
        }

  }

}
