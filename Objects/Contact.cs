namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _address;

    public Contact (string firstName , string lastName, string phoneNumber, string address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phoneNumber = phoneNumber;
      _address = address;
    }

    public string GetfirstName()
    {
      return _firstName;
    }
    public void SetfirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetlastName()
    {
      return _lastName;
    }

    public void SetlastName(string newLastName)
    {
      _lastName = newLastName;
    }
    public string GetphoneNumber()
    {
      return _phoneNumber;
    }
    public void SetphoneNumber(string newphoneNumber)
    {
      _phoneNumber = newphoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

  }

}
