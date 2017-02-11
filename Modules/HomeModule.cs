using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["address_book.cshtml", allContacts];
      };
      Get["/new_contact"] =_=>View["contact.cshtml"];
      Get["/contacts/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["/view_contact.cshtml", contact];
      };
      Post["/contact_added"] = _ => {
        Contact newContact = new Contact (Request.Form["firstname"],Request.Form["lastname"],Request.Form["phoneNumber"],Request.Form["address"]);
        return View["contact_added.cshtml", newContact];
      };
      Get["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
