using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    public partial class LoginView : Form
    {
        MessageView messageView;
        private int arrayContactIndex = -1;
        Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
     
        public LoginView()
        {
            InitializeComponent();
            messageView = new MessageView();
            dataPg.Notify += DataPg_Notify;
        }
        private void DataPg_Notify(bool inProc, string exMessage)
        {
            if (exMessage != "")
                MessageBox.Show(exMessage);
            LoadPb.Invoke(() => LoadPb.Visible = inProc);
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (dataPg.inProccess)
            {
                MessageBox.Show("Дождитесь завершения загрузки контактов!");
                return;
            }
            if (usersCB.SelectedIndex == dataPg.ContactsArr.Count)
            {
                MessageBox.Show("Введите корректный адрес Email!");
                return;
            }
            Match match = regexMail.Match(usersCB.Text);
            if (usersCB.SelectedIndex == -1)
            {
                if (usersCB.Text == "")
                {
                    MessageBox.Show("Добавить Email не удалось.");
                    return;
                }
                if (!match.Success)
                {
                    MessageBox.Show("Введите корректный адрес Email!");
                    return;
                }
                if (arrayContactIndex == -1)
                {
                    int? tempId = dataPg.AddContact(new Contact((SurnameTb.Text != "") ? SurnameTb.Text : ""
                                + ((NameTb.Text != "") ? (SurnameTb.Text != "") ? " " : "" + NameTb.Text : "")
                                + ((PatronymicTb.Text != "") ? (NameTb.Text != "") ? " " : "" + PatronymicTb.Text : ""), usersCB.Text
                                ));
                    if (tempId != null)
                        arrayContactIndex = dataPg.ContactsArr.Count - 1;
                    else
                        MessageBox.Show("Добавить Email не удалось.");
                }
            }
            else
                arrayContactIndex = usersCB.SelectedIndex;
            if (dataPg.ContactsArr[arrayContactIndex].CorrectPasswordHash == null)
            {
                if (PasswordTb.Text == "" && MessageBox.Show("Сохранить пустой пароль?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dataPg.ContactsArr[arrayContactIndex].CorrectPasswordHash = dataPg.ContactsArr[arrayContactIndex].ComputePasswordHash(PasswordTb.Text);
                dataPg.UpdateContacts(false);
                MessageBox.Show("Пароль успешно сохранен!");
            }
            if (dataPg.ContactsArr[arrayContactIndex].IsPasswordValid(PasswordTb.Text))
            {
                messageView.sendedMessage.Sender_id = (int)dataPg.ContactsArr[arrayContactIndex].id;

                if (NameTb.Text != "") dataPg.ContactsArr[arrayContactIndex].Name = NameTb.Text;
                if (SurnameTb.Text != "") dataPg.ContactsArr[arrayContactIndex].Surname = SurnameTb.Text;
                if (PatronymicTb.Text != "") dataPg.ContactsArr[arrayContactIndex].Patronymic = PatronymicTb.Text;

                if (!match.Success)
                {
                    dataPg.UpdateContacts(false);
                    dataPg.ContactsArr[arrayContactIndex].MailAdress = usersCB.Text;
                    MessageBox.Show("Введите корректный адрес Email!");
                    return;
                }
                dataPg.UpdateContacts(false);
                this.Hide();
                messageView.ShowDialog();
                arrayContactIndex = -1;
                this.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенного пароля!");
            }
        }
        private void usersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersCB.SelectedIndex < dataPg.ContactsArr.Count && usersCB.SelectedIndex > 0)
            {
                NameTb.Text = dataPg.ContactsArr[usersCB.SelectedIndex].Name;
                SurnameTb.Text = dataPg.ContactsArr[usersCB.SelectedIndex].Surname;
                PatronymicTb.Text = dataPg.ContactsArr[usersCB.SelectedIndex].Patronymic;
            }
            else
            {
                SurnameTb.Text = NameTb.Text = PatronymicTb.Text = PasswordTb.Text = null;
            }
        }
        public void postgresSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsView settingsView = new SettingsView();
            settingsView.ShowDialog();
            LoginView_VisibleChanged(null, null);
            settingsView.Close();
        }
        private void LoginView_VisibleChanged(object sender, EventArgs e)
        {
            //if (usersCB.Items.Count == 0)
            usersCB.Text = null;
            usersCB.Items.Clear();
            Task.Run(() => dataPg.LoadContacts())
                .ContinueWith(t => usersCB.Invoke(() =>
                {
                    usersCB.Items.AddRange(dataPg.ContactsArr?.Select(contact => contact.MailAdress)?.ToArray() ?? Array.Empty<string>());
                    usersCB.Items.Add("Enter your Email...");
                }));
        }
    }
}
