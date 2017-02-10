namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _address;
     private static List<string> _Contactlist = new List<string> {};

    public Contact (string firstName , string lastName, string phoneNumber, string address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _address = address;
    }

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
    public static List<string> GetAll()
    {
      return _Contactlist;
    }
    public void Save()
    {
      _Contactlist.Add(_firstName);
      _Contactlist.Add(_lastName);
      _Contactlist.Add(_phoneNumber);
      _Contactlist.Add(_address);
    }

  }

}
