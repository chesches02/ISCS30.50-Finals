using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
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
                    string hashed_password = record.Element("Hashed_Password")?.Value;

                    listBox1.Items.Add($"Website: {website}, Username: {username}, Password: {password}, Hashed Password: {hashed_password}");
                }
            }
        }
        private string EncryptPassword(string source_password)
        {
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(source_password); 
            tmpHash = MD5.HashData(tmpSource);

            int i;
            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));
            }
            return sOutput.ToString();
        }


        // Save Record
        private void button1_Click(object sender, EventArgs e)
        {
            string website = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string hashed_password = EncryptPassword(password);

            PasswordRecord record = new PasswordRecord(website, username, password, hashed_password);
            dataManager.SaveRecord(record);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cur_selected = listBox1.SelectedItem.ToString();

            dataManager.RemoveRecord(cur_selected);

            LoadData();

        }
    }


    public class PasswordRecord
    {
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hashed_Password { get; set; }

        public PasswordRecord(string website, string username, string password, string hashed_password)
        {
            Website = website;
            Username = username;
            Password = password;
            Hashed_Password = hashed_password;
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
                new XElement("Hashed_Password", record.Hashed_Password)
            );

            xmlDoc.Root.Add(newEntry);
            xmlDoc.Save(filePath);
        }

        public void RemoveRecord(string cur_selected)
        {
            XDocument xmlDoc;

            if (File.Exists(filePath))
            {
                xmlDoc = XDocument.Load(filePath);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("PasswordRecords"));
                MessageBox.Show("Lil Bro Go Make A Record First");
            }

            foreach (XElement record in xmlDoc.Descendants("Record"))
            {
                string website = record.Element("Website")?.Value;
                string username = record.Element("Username")?.Value;
                string password = record.Element("Password")?.Value;
                string hashed_password = record.Element("Hashed_Password")?.Value;

                if (cur_selected == $"Website: {website}, Username: {username}, Password: {password}, Hashed Password: {hashed_password}")
                {
                    record.Remove();
                    xmlDoc.Save(filePath);
                    break;
                }
            }
        }
    }

    
}

