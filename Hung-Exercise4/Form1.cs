using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hung_Exercise4
{
    public partial class Form1 : Form
    {
        private string xmlFilePath = "PasswordManager.xml";
        private PasswordDataManager dataManager;
        public Form1()
        {
            InitializeComponent();

            dataManager = new PasswordDataManager(xmlFilePath);
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(xmlFilePath))
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);
                listBox1.Items.Clear();

                foreach (XElement record in xmlDoc.Descendants("Record"))
                {
                    string website = record.Element("Website")?.Value;
                    string username = record.Element("Username")?.Value;
                    string password = record.Element("Password")?.Value;

                    listBox1.Items.Add($"{website}, Age: {username}, Vaccine: {password}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }


        private void buttonDeleteOldest_Click(object sender, EventArgs e)
        {
            
        }

    }


    public class PasswordRecord
    {
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PasswordRecord(string Website, string Username, string Password)
        {
            Website = Website;
            Username = Username;
            Password = Password;
        }
    }

    public class PasswordDataManager
    {
        private string filePath;

        public PasswordDataManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveRecord(PasswordRecord record)
        {
            XDocument xmlDoc;

            if (File.Exists(filePath))
            {
                xmlDoc = XDocument.Load(filePath);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("PasswordRecords"));
            }

            XElement newEntry = new XElement("Record",
                new XElement("Website", record.Website),
                new XElement("Username", record.Username),
                new XElement("Password", record.Password),
            );

            xmlDoc.Root.Add(newEntry);
            xmlDoc.Save(filePath);
        }
    }
}

