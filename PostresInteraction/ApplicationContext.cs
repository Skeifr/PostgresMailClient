using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace mailClient
{
    internal class ApplicationContext : DbContext
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        internal DbSet<Contact> ContactsDBSet { get; set; }
        internal DbSet<Message> MessagesDBSet { get; set; }
        internal ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=" + config.AppSettings.Settings["pg_host"].Value +
                ";Port=" + config.AppSettings.Settings["pg_port"].Value +
                ";Database=" + config.AppSettings.Settings["pg_dbName"].Value +
                ";Username=" + config.AppSettings.Settings["pg_user"].Value +
                ";Password=" + config.AppSettings.Settings["pg_pass"].Value);
        }
    }
}