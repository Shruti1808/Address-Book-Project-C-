using Nancy;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["address_book.cshtml"];
    }
  }
}
