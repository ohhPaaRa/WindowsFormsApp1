using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Utilisateur> listUser = new List<Utilisateur>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean test = false;
            //foreach (Utilisateur user in listUser)
            //  {
            //      if (user.Pseudo == textBox1.Text && user.MotDePasse == textBox2.Text)
            //      {
            //          this.Visible = false;
            //          Form2 form2 = new Form2();
            //          form2.Show();
            //          test = true;                 
            //      }
            //  }
            //      if (test is false)
            //      {
            //          MessageBox.Show("Identifiant ou mdp incorrect");
            //      }

            if (System.IO.File.Exists("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest"))
            {
                string a = System.IO.File.ReadAllText("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest");
                foreach (string line in a.Split('|'))
                {
                    string nom = line.Split(';')[0];
                    string password = line.Split(';')[1];
                    if (nom == textBox1.Text && password == textBox2.Text)
                    {
                        this.Visible = false;
                        Form2 form2 = new Form2();
                        form2.Show();
                        test = true;

                    }
                }
                if (test is false)
                {
                    MessageBox.Show("Identifiant ou mdp incorrect");
                }
            }
        }


            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.IO.File.WriteAllText("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest", "Simon;oui");
            //System.IO.File.WriteAllText("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest", "Robin;non");
            //System.IO.File.WriteAllText("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest", "Oui;nn");
            System.IO.File.WriteAllText("E:\\ObjetNEt\\WindowsFormsApp1\\WindowsFormsApp1\\MotDePasse\\mdpTest", "fff;ozzui|kjfn;ojef");

            listUser.Add(new Utilisateur("xXSiiM0N_G4M3URENTXx", "azertyuiop123456789"));
            listUser.Add(new Utilisateur("oui", "non"));
            listUser.Add(new Utilisateur("non", "oui"));
        }


    }
}
