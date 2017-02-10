using Nancy;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["address_book.cshtml"];
      //  Get["/contact_form"] = _ => View["add_contact.cshtml"];

      Get["contact_form"]= _ => {
        Contact newContact = new Contact(Request.Query["firstname"],Request.Query["lastname"],Request.Query["phoneNumber"],Request.Query["address"]);
        return View["view_contact.cshtml", newContact];
        Post["/contact_added"] = _ => {
          Contact newContact = new Contact (Request.Form["new-contact"]);
          newContact.Save();
          return View["contact_added.cshtml", newContact];
        };
      };
    }
  }
}
