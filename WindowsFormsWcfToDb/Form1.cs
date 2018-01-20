using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWcfToDb.ServiceReference1;

namespace WindowsFormsWcfToDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Username = txtUsername.Text;
            p.Password = txtPassword.Text;
            p.Email = txtEmail.Text;


            Service1Client service = new Service1Client();

            if (service.InsertPerson(p) == 1)
            {
                MessageBox.Show("Person Inserted Successfully");


            }


        }

       
    }
}
