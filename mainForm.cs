using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook
{
    public partial class mainForm : Form
    {
        private struct PhoneRecord
        {
            public String name;
            public String phone;
            public String mobile;
            public void initialize()
            {
                name = "";
                phone = "";
                mobile = "";
            }
            public void setName(String n)
            {
                name = n;
            }
            public void setMobile(String n)
            {
                mobile = n;
            }
            public void setPhone(String n)
            {
                phone = n;
            }
        }
        private List<PhoneRecord> phoneList;
        public mainForm()
        {
            InitializeComponent();
            phoneList = new List<PhoneRecord>();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dumpToFile()
        {
            using (StreamWriter outputFile = new StreamWriter("phonebook.txt"))
            {

                foreach (PhoneRecord record in phoneList)
                {
                    String line = record.name + "," + record.phone + "," + record.mobile;
                    outputFile.WriteLine(line);
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.TrimStart().TrimEnd() == "")
            {
                nameTextBox.Focus();
                return;
            }
            PhoneRecord record = new PhoneRecord();
            record.initialize();
            record.name = nameTextBox.Text.TrimStart().TrimEnd();
            record.mobile = mobileTextBox.Text.TrimStart().TrimEnd();
            record.phone = telTextBox.Text.TrimStart().TrimEnd();
            phoneList.Add(record);
            phoneListView.Items.Add(record.name);
            dumpToFile();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (phoneListView.SelectedItems.Count > 0)
            {
                phoneList.RemoveAt(phoneListView.SelectedItems[0].Index);
                phoneListView.Items.RemoveAt(phoneListView.SelectedItems[0].Index);
                dumpToFile();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (phoneListView.SelectedItems.Count > 0)
            {
                if (nameTextBox.Text.TrimStart().TrimEnd() == "")
                {
                    nameTextBox.Focus();
                    return;
                }
                phoneList[phoneListView.SelectedItems[0].Index].setName(nameTextBox.Text.TrimStart().TrimEnd());
                phoneListView.Items[phoneListView.SelectedItems[0].Index].Text = nameTextBox.Text.TrimStart().TrimEnd();
                phoneList[phoneListView.SelectedItems[0].Index].setMobile(mobileTextBox.Text);
                phoneList[phoneListView.SelectedItems[0].Index].setPhone(telTextBox.Text);
                dumpToFile();
            }
        }

        private void phoneListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phoneListView.SelectedItems.Count > 0)
            {
                nameTextBox.Text = phoneList[phoneListView.SelectedItems[0].Index].name;
                mobileTextBox.Text = phoneList[phoneListView.SelectedItems[0].Index].mobile;
                telTextBox.Text = phoneList[phoneListView.SelectedItems[0].Index].phone;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (phoneListView.SelectedItems.Count > 0)
            {
                for (int i = phoneListView.SelectedItems[0].Index; i < phoneListView.Items.Count; i++)
                {
                    if (phoneList[i].name.Contains(nameTextBox.Text.TrimStart().TrimEnd()))
                    {
                        phoneListView.Focus();
                        phoneListView.Items[i].Selected = true;
                        phoneListView.Items[i].Focused = true;
                        return;
                    }
                }
                for (int j = 0; j < phoneListView.SelectedItems[0].Index; j++)
                {
                    if (phoneList[j].name.Contains(nameTextBox.Text.TrimStart().TrimEnd()))
                    {
                        phoneListView.Focus();
                        phoneListView.Items[j].Selected = true;
                        phoneListView.Items[j].Focused = true;
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < phoneListView.Items.Count; i++)
                {
                    if (phoneList[i].name.Contains(nameTextBox.Text.TrimStart().TrimEnd()))
                    {
                        phoneListView.Focus();
                        phoneListView.Items[i].Selected = true;
                        phoneListView.Items[i].Focused = true;
                        return;
                    }
                }
            }
        }
        private void readFile()
        {
            if (!File.Exists("phonebook.txt"))
                return;
            string[] lines = File.ReadAllLines("phonebook.txt");

            foreach (string line in lines)
            {
                PhoneRecord record = new PhoneRecord();
                string[] subs = line.Split(',');
                record.name = subs[0];
                record.phone = subs[1];
                record.mobile = subs[2];
                phoneList.Add(record);
                phoneListView.Items.Add(record.name);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            readFile();
        }
    }
}
