using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5 {
    public partial class RegistrationForm : Form {

        private Form form;
        public RegistrationForm(Form form) {
            InitializeComponent();
            this.form = form;
            form.Visible = false;
            FormClosed += (s, e) => this.form.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) return;
            if (textBox1.Text.Length <3 || textBox2.Text.Length<4) return;

            if(textBox2.Text == textBox3.Text)
            {
                using(Connection context = new Connection()) 
                {
                    User user= new User();
                    user.Login = textBox1.Text;
                    user.Password = textBox2.Text;

                    var result = await context.Users.AnyAsync(row => row.Login == user.Login);
                    if(result==false) 
                    {
                        context.Add(user);
                        await context.SaveChangesAsync(); //Update Delete Insert 
                        Close();
                    }
                }
            }
        }
    }
}
