using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookup_KeyMember {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var categories = new List<Category> {
                new Category(){ ID = 0, Name = "Beverages" },
                new Category(){ ID = 1, Name = "Grains" },
                new Category(){ ID = 2, Name = "Seafood" },
            };

            gridControl1.DataSource = new List<Product> {
                new Product(){ ProductName="Chang", Category = new Category() { ID = 0 } },
                new Product(){ ProductName="Ipoh Coffee", Category = new Category() { ID = 0 } },
                new Product(){ ProductName="Ravioli Angelo", Category = new Category() { ID = 1 } },
                new Product(){ ProductName="Filo Mix", Category = new Category() { ID = 1 } },
                new Product(){ ProductName="Tunnbröd", Category = new Category() { ID = 1 } },
                new Product(){ ProductName="Konbu", Category = new Category() { ID = 2 } },
                new Product(){ ProductName="Boston Crab Meat", Category = new Category() { ID = 2 } }
            };

            RepositoryItemLookUpEdit riLookUp = new RepositoryItemLookUpEdit();
            riLookUp.KeyMember = "ID";
            riLookUp.DisplayMember = "Name";
            riLookUp.DataSource = categories;

            gridControl1.RepositoryItems.Add(riLookUp);
            gridView1.Columns["Category"].ColumnEdit = riLookUp;
        }
    }

    public class Product {
        public Category Category { get; set; }
        public string ProductName { get; set; }
    }

    public class Category {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
