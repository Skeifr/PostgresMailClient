using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailClient
{
    internal static class dataPg
    {
        public delegate void loadPg(bool inProc, string exMessage = "");
        public static event loadPg Notify;
        internal static bool inProccess = false;

        internal static void LoadContacts()
        {
            try
            {
                inProccess = true;
                Notify(inProccess);
                using (ApplicationContext db = new ApplicationContext())
                {
                    ContactsArr = db.ContactsDBSet.ToList();
                }
            }
            catch (Exception ex)
            {
                Notify(inProccess, ex.Message);
            }
            finally
            {
                inProccess = false;
                Notify(inProccess);
            }
        }
        internal static int? AddContact(Contact newContact)
        {
            int? result = null;
            try
            {
                inProccess = true;
                Notify(inProccess);
                using (ApplicationContext db = new ApplicationContext())
                {
                    
                    db.ContactsDBSet.Add(newContact);
                    db.SaveChanges();
                    result = newContact.id;
                    newContact.Active = true;
                    ContactsArr.Add(newContact);
                }
            }
            catch (Exception ex)
            {
                Notify(inProccess, ex.Message);
            }
            finally
            {
                inProccess = false;
                Notify(inProccess);
            }
            return result;
        }
        internal static void UpdateContacts(bool messaging = true)
        {
            try
            {
                inProccess = true;
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.ContactsDBSet.UpdateRange(ContactsArr);
                    if (messaging)
                    {
                        List<Contact> tempDeleting = new List<Contact>();
                        foreach (var contact in ContactsArr)
                        {
                            if (!contact.Active)
                                tempDeleting.Add(contact);
                            else
                                contact.Active = false;
                        }
                        db.ContactsDBSet.RemoveRange(tempDeleting);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Notify(inProccess, ex.Message);
            }
            finally
            {
                inProccess = false;
            }
        }
        internal static List<Contact> ContactsArr { get; set; }
        internal static void AddMessage(Message message)
        {
            try
            {
                inProccess = true;
                Notify(inProccess);
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.MessagesDBSet.Add(message);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Notify(inProccess, ex.Message);
            }
            finally
            {
                inProccess = false;
                Notify(inProccess);
            }
        }
    }
}