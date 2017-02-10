namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    private string _address;


    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
  }

}
