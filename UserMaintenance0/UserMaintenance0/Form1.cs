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
using UserMaintenance0.Entities;

namespace UserMaintenance0
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.FullName; 
            lblFirstName.Text = Resource1.FullName; 
            btnAdd.Text = Resource1.Add;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLastName.Text + " " + txtFirstName.Text
            };
            users.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "DefaultOutputName.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                for (int i = 0; i < 2; i++)
                {
                    writer.WriteLine(Resource1.FullName[i].ToString());
                }
                writer.Dispose();
                writer.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int del;
            del = listUsers.SelectedIndex;
            users.RemoveAt(del);
            
        }
    }
}
