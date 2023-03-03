using System.Text.RegularExpressions;

namespace mailClient
{
    public partial class MessageView : Form
    {
        //postgres users view form
        ContactView contactView;
        typeCallId typeCall;
        Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        //general message
        internal Message sendedMessage;

        private enum typeCallId
        {
            currentRecipient = 0,
            copyRecipient = 1
        }
        public MessageView()
        {
            InitializeComponent();
            contactView = new ContactView();
            sendedMessage = new Message();
        }
        private void DataPg_Notify(bool inProc, string exMessage)
        {
            if (exMessage != "")
                MessageBox.Show(exMessage);
            LoadPb.Invoke(() => LoadPb.Visible = inProc);
        }
        private void ContactView_Notify(Contact? selectedContact)
        {
            if (selectedContact == null)
                return;

            string readyTableRow = (selectedContact.MailAdress == null) ? "" : selectedContact.MailAdress
                        + ((selectedContact.TableRow != "") ? $"({selectedContact.TableRow})" : "");

            switch (typeCall)
            {
                case typeCallId.currentRecipient:
                    recipientTb.Text = readyTableRow;
                    sendedMessage.Recipient_id = (int)selectedContact.id;
                    break;
                case typeCallId.copyRecipient:
                    copyRecipientTb.Text = readyTableRow;
                    sendedMessage.CopyRecipient_id = (int)selectedContact.id;
                    break;
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            Match match = regexMail.Match(recipientTb.Text);
            Match copyMatch = regexMail.Match(copyRecipientTb.Text);

            if (match.Success && recipientTb.Text != "" && sendedMessage.Recipient_id == null)
            {
                if (dataPg.ContactsArr.Where(contact => contact.MailAdress == recipientTb.Text).FirstOrDefault() == null)
                {
                    Contact newContact = new Contact(null, recipientTb.Text);
                    sendedMessage.Recipient_id = dataPg.AddContact(newContact);
                }
                else
                    sendedMessage.Recipient_id = dataPg.ContactsArr.Where(contact => contact.MailAdress == recipientTb.Text).FirstOrDefault().id;
            }
            if (copyMatch.Success && recipientTb.Text != "" && sendedMessage.CopyRecipient_id== null)
            {
                if (dataPg.ContactsArr.Where(contact => contact.MailAdress == copyRecipientTb.Text).FirstOrDefault() == null)
                {
                    Contact newContact = new Contact(null, copyRecipientTb.Text);
                    sendedMessage.CopyRecipient_id = dataPg.AddContact(newContact);
                }
                else
                    sendedMessage.CopyRecipient_id = dataPg.ContactsArr.Where(contact => contact.MailAdress == copyRecipientTb.Text).FirstOrDefault().id;
            }
            if (sendedMessage.Recipient_id == null)
            {
                MessageBox.Show("Для отправки сообщения выберете адресата!");
                return;
            }
            sendedMessage.id = null;
            sendedMessage.Title = titleTb.Text;
            sendedMessage.Body = messageTb.Text;
            sendedMessage.SendedDate = DateTime.Now.ToUniversalTime();

            Task.Run(() => dataPg.AddMessage(sendedMessage))
                .ContinueWith(t =>
                {
                    if (sendedMessage.CopyRecipient_id != null)
                    {
                        sendedMessage.id = null;
                        sendedMessage.Recipient_id = sendedMessage.CopyRecipient_id;
                        dataPg.AddMessage(sendedMessage);
                    }
                })
                .ContinueWith(t => MessageBox.Show("Отправка завершена!"));
        }
        private void recipientContactsPb_Click(object sender, EventArgs e)
        {
            if (dataPg.inProccess)
            {
                MessageBox.Show("Дождитесь завершения загрузки контактов!");
                return;
            }
            typeCall = typeCallId.currentRecipient;
            contactView.Show();
        }
        private void copyRecipientContactsPb_Click(object sender, EventArgs e)
        {
            if (dataPg.inProccess)
            {
                MessageBox.Show("Дождитесь завершения загрузки контактов!");
                return;
            }
            typeCall = typeCallId.copyRecipient;
            DialogResult result = contactView.ShowDialog();
            //contactView.Show();
        }
        private void MessageView_Load(object sender, EventArgs e)
        {
            contactView.Notify += ContactView_Notify;
            dataPg.Notify += DataPg_Notify;
            Task.Run(() => dataPg.LoadContacts());
            //  .ContinueWith(t => this.LoadPb.Visible = false, TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void RecipierLb_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Blue;
        }
        private void RecipierLb_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }
        private void LoadPb_VisibleChanged(object sender, EventArgs e)
        {
            if (LoadPb.Visible)
            {
                recipientTb.Width -= LoadPb.Width;
                copyRecipientTb.Width -= LoadPb.Width;
                titleTb.Width -= LoadPb.Width;
            }
            else
            {
                recipientTb.Width += LoadPb.Width;
                copyRecipientTb.Width += LoadPb.Width;
                titleTb.Width += LoadPb.Width;
            }
        }

        private void MessageView_FormClosing(object sender, FormClosingEventArgs e)
        {
            contactView.Notify -= ContactView_Notify;
            dataPg.Notify -= DataPg_Notify;
        }
    }
}