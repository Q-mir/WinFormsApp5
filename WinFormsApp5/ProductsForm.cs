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
    public partial class ProductsForm : Form
    {
        private Form _form;
        public ProductsForm(Form after) 
        {
            InitializeComponent();

            using(Connection conn = new Connection()) 
            {
                if (!conn.Products.Any()) 
                {
                    conn.Products.Add(new Product() { Name = "test1", Price = 1000, Description = "text test 111111111" });
                    conn.Products.Add(new Product() { Name = "test2", Price = 300, Description = "text test 2222222222" });
                    conn.Products.Add(new Product() { Name = "test3", Price = 2000, Description = "text test 333333333" });
                    conn.SaveChanges();
                }
            }



            _form = after;
            _form.Visible= false;
            FormClosed += (s, e) => _form.Visible = true;

            listBox1.SelectedIndexChanged += (s, e) =>
            {
                int index = listBox1.SelectedIndex;

                if (index >= 0)
                {
                    label1.Text = $"Имя: {_products[index].Name}";
                    label2.Text = $"Описание: {_products[index].Description}";
                    label3.Text = $"Цена: {_products[index].Price}";
                }
            };


            AllProductLoadAsync();

            comboBox1.Items.Add("По цене возрастания");
            comboBox1.Items.Add("По цене убыванию");
            comboBox1.Items.Add("По алфавиту возрастания");
            comboBox1.Items.Add("По алфавиту убыванию");
            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                string message = comboBox1.Text;
                switch (message)
                {
                    case "По цене возрастания":     SortAsc(x => x.Price);  break;
                    case "По цене убыванию":        SortDesc(x => x.Price); break;
                    case "По алфавиту возрастания": SortAsc(x => x.Name);   break;
                    case "По алфавиту убыванию":    SortDesc(x => x.Name);  break;
                }
            };
        }
        

        private void SortAsc<T>(Func<Product, T> funct)
        {
            _products = _products.OrderBy(row =>  row.Name).ToList();
            ShowAllProducts();
        }

        private void SortDesc<T>(Func<Product, T> funct)
        {
            _products = _products.OrderByDescending(funct).ToList();
            ShowAllProducts();
        }

        private List<Product> _products = new List<Product>();
        private async void AllProductLoadAsync() 
        {
            using(Connection context = new Connection()) 
            {
                _products = await context.Products.ToListAsync();
            }
            ShowAllProducts(); //??? 
        }

        private void ShowAllProducts()
        {
            listBox1.Items.Clear();
            foreach (Product product in _products) 
            {
                listBox1.Items.Add($"#{product.Id}:{product.Name}");
            }
        }

    }
}
