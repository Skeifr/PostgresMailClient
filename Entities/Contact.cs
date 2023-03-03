using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace mailClient
{
    [Table("users", Schema = "public")]
    public class Contact    
    {
        [Key]
        public int? id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("surname")]
        public string? Surname { get; set; }
        [Column("patronymic")]
        public string? Patronymic { get; set; }
        [Column("mailadress")]
        public string MailAdress { get; set; }
        [Column("passhash")]
        public byte[]? CorrectPasswordHash { get; set; }
        [Column("hashmodifier")]
        public int? Salt { get; set; }
        [NotMapped]
        public string TableRow
        {
            get
            {
                string tempLine = Surname + ((Surname is not null and not "") ? " " : "")
                    + Name + ((Patronymic is not null and not "") ? " " : "") + Patronymic;
                return tempLine;
            }
            set
            {
                if (value == null || value == "")
                {
                    Name = null; Surname = null; Patronymic = null;
                }
                else
                {
                    string[] fullParse = value.Split(" ");
                    if (fullParse.Length == 1 || fullParse.Length > 3)
                    {
                        Name = value; Surname = null; Patronymic = null;
                    }
                    else if (fullParse.Length == 2)
                    {
                        Name = fullParse[1]; Surname = fullParse[0]; Patronymic = null;
                    }
                    else if (fullParse.Length == 3)
                    {
                        Name = fullParse[1]; Surname = fullParse[0]; Patronymic = fullParse[2];
                    }
                }
            }
        }
        [NotMapped]
        public bool Active = false;
        public Contact(object? tableRow, object? mail)
        {
            if (mail is not null and not "")
                MailAdress = mail.ToString();
            if (tableRow is not null and not "")
                TableRow = tableRow.ToString();
            id = null;
            Active = true;
        }
        public Contact() { }
        public void Update(string? tableRow, string? mail)
        {
            if (mail is not null)
                MailAdress = mail;
            if (tableRow is not null)
                TableRow = tableRow;
            Active = true;
        }
        private int GenerateSaltForPassword()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[4];
            rng.GetNonZeroBytes(saltBytes);
            return (((int)saltBytes[0]) << 24) + (((int)saltBytes[1]) << 16) + (((int)saltBytes[2]) << 8) + ((int)saltBytes[3]);
        }
        internal byte[] ComputePasswordHash(string password)
        {
            if (Salt == null)
                Salt = GenerateSaltForPassword();

            byte[] saltBytes = new byte[4];
            saltBytes[0] = (byte)(Salt >> 24);
            saltBytes[1] = (byte)(Salt >> 16);
            saltBytes[2] = (byte)(Salt >> 8);
            saltBytes[3] = (byte)(Salt);

            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(password);

            byte[] preHashed = new byte[saltBytes.Length + passwordBytes.Length];
            System.Buffer.BlockCopy(passwordBytes, 0, preHashed, 0, passwordBytes.Length);
            System.Buffer.BlockCopy(saltBytes, 0, preHashed, passwordBytes.Length, saltBytes.Length);

            SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(preHashed);
        }
        public bool IsPasswordValid(string passwordToValidate)
        {
            byte[] hashedPassword = ComputePasswordHash(passwordToValidate);

            return hashedPassword.SequenceEqual(CorrectPasswordHash);
        }
    }
}
