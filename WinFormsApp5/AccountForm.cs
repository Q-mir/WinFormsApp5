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
    public partial class AccountForm : Form {
        private Form prevForm;
        private User user;
        public AccountForm(Form form, User user)
        {
            InitializeComponent();
            this.user = user;
            prevForm = form;
            prevForm.Visible = false;
            FormClosed += (s, e) => prevForm.Visible = true;
            ShowImageAsync();

            var button = new ToolStripButton();
            button.Width = 200;
            button.Text = "Product";
            button.Click += (s, e) => 
            { 
                ProductsForm f = new ProductsForm(this);
                f.ShowDialog();
            };
            statusStrip1.Items.Add(button);

        }

        private async void ShowImageAsync() {
            using (Connection context = new Connection()) {
                var imageUser = await context.UserImages.FindAsync(user.Id);
                if (imageUser != null) {
                    pictureBox1.Image = imageUser.GetImage();
                }
            }
        }


        private async void button1_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK) {
                byte[] array = File.ReadAllBytes(ofd.FileName);

                using (Connection context = new Connection()) {
                    var userImage = await context.UserImages
                                         .FirstOrDefaultAsync(row => row.Id == user.Id);

                    if (userImage == null) {
                        userImage = new UserImage();
                        userImage.Id = user.Id;
                        userImage.Cover = array;
                        context.Add(userImage);
                    }
                    else {
                        userImage.Cover = array;
                    }
                    await context.SaveChangesAsync();
                    pictureBox1.Image = userImage.GetImage();
                }
            }
        }

       
    }
}
