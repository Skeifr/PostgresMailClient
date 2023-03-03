using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace mailClient
{
    public partial class ContactView : Form
    {
        public delegate void selectingContact(Contact selectedContact);
        public event selectingContact Notify;
        Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public void checkUpdates()
        {
            foreach (DataGridViewRow line in contactsDGV.Rows)
            {
                try
                {
                    if (line.Index == contactsDGV.Rows.Count - 1)
                        break;
                    //contactsDGV columns:
                    //[0]-email
                    //[1]-full name
                    //[2]-id
                    if (line.Cells[2].Value == null)
                    {
                        Match match = regexMail.Match((string)line.Cells[0].Value);
                        if (!match.Success)
                        {
                            MessageBox.Show("Введите корректный адрес Email!");
                            continue;
                        }
                        Contact newContact = new Contact(line.Cells[1].Value, line.Cells[0].Value);
                        line.Cells[2].Value = dataPg.AddContact(newContact);
                    }
                    else
                    {
                        int contactIndex = (int)line.Cells[2].Value;
                        dataPg.ContactsArr.Where(contact => contact.id == contactIndex).FirstOrDefault()
                            .Update(line.Cells[1].Value.ToString(), line.Cells[0].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Task.Run(() => dataPg.UpdateContacts())
                .ContinueWith(t => dataPg.LoadContacts());
        }
        public ContactView()
        {
            InitializeComponent();
            contactsDGV.MultiSelect = false;
        }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            checkUpdates();

            var selectedIndex = contactsDGV.Rows[contactsDGV.SelectedCells[0].RowIndex].Cells[2].Value;
            if (selectedIndex != null)
                Notify?.Invoke(dataPg.ContactsArr.Where(contact => contact.id == (int)selectedIndex).FirstOrDefault());
            else
                MessageBox.Show("Ошибка добавления контакта.");
            this.Hide();
        }
        private void ContactView_Load(object sender, EventArgs e)
        {
            try
            {
                contactsDGV.Rows.Clear();
                foreach (Contact contact in dataPg.ContactsArr)
                    contactsDGV.Rows.Add(contact.MailAdress, contact.TableRow, contact.id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ContactView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Notify?.Invoke(null);
            this.Hide();
        }
    }
}