/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.GData.Client;
using Google.Contacts;
using Google.GData.Extensions;
using Google.GData.Contacts;
namespace AdvertisingOnline.Helpers
{
    public class GoogleHelpers
    {
        public List<CustomerGmail> RetriveContacts(string AccessToken,List<string> ExistPhone)
        {
            RequestSettings contactrequest = new RequestSettings("import contact", AccessToken);//import contact
            ContactsRequest req = new ContactsRequest(contactrequest);
            //PhoneHelpers phoneHelpers = new PhoneHelpers();
            //ExcelHelpers excelHelpers = new ExcelHelpers();
            List<CustomerGmail> ListImport = new List<CustomerGmail>();
            foreach (Contact contact in req.GetContacts().Entries)
            {
                bool IsValidPhone = false;
                CustomerGmail customer = null;
                if (contact.Phonenumbers.Count>0)
                {
                    foreach (var phone in contact.Phonenumbers)
                    {
                        //string temp = phoneHelpers.ExtractPhoneNumber(phone.Value);
                        //if (phoneHelpers.IsNumber(temp) && !ExistPhone.Any(x=>x.Equals(temp)))
                        //{
                        //    customer = new CustomerGmail();
                        //    IsValidPhone = true;
                        //    customer.Phone = temp;
                        //    break;
                        //}
                    }
                    if (IsValidPhone)
                    {
                        if (contact.ContactEntry.PrimaryEmail != null)
                            customer.Email = contact.ContactEntry.PrimaryEmail.Address;
                        if (contact.ContactEntry.Name.FullName != null)
                            customer.Name = contact.ContactEntry.Name.FullName;
                        if (!string.IsNullOrEmpty(contact.ContactEntry.Birthday))
                        {
                            //string tempDOB = excelHelpers.FormatDateOfBitrh(contact.ContactEntry.Birthday);
                            //if (excelHelpers.IsValidDateOfBirth(tempDOB))
                            //    customer.DateOfBirth = tempDOB;
                        }
                    }
                }
                if (IsValidPhone)
                    ListImport.Add(customer);
                //if(excelHelpers != null)
                //{
                //    excelHelpers.Dispose();
                //}
                //if(phoneHelpers != null)
                //{
                //    phoneHelpers.Dispose();
                //}
            }
            return ListImport;
        }
    }

    public class CustomerGmail
    {
        public string Phone { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}