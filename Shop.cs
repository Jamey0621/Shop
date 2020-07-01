using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_UI
{
    public partial class Shop : Form
    {

        private Store store = new Store();
        private List<Item> ShopingCartData = new List<Item>();
        // make the binding to be able to populate the itme box
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();


        public Shop()
        {
            InitializeComponent();
            SetupData();
            // set it
            itemBinding.DataSource = store.item;
            // set it to the box itself 
            ItemListBox.DataSource = itemBinding;

            ItemListBox.DisplayMember = "Display";
            ItemListBox.ValueMember = "Display";

            //shoping cart binding and linking it to the cart box
            cartBinding.DataSource = ShopingCartData;
            ShopingCartList.DataSource = cartBinding;

            ShopingCartList.DisplayMember = "Display";
            ShopingCartList.ValueMember = "Display";



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yayyyyyy You DiD It!");

            foreach (var item in ShopingCartData)
            {
                item.sold = true;
            }
            ShopingCartData.Clear();// clear the cart

            cartBinding.ResetBindings(false);




        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {   // creat a vendor obj
            Vendor demoVendor = new Vendor();
            demoVendor.Firstname = "Jay";
            demoVendor.LastName = "Jay";

            // new vendor obj
            demoVendor = new Vendor();
            demoVendor.Firstname = "sue";
            demoVendor.LastName = "Ann";

            // learnded how to do this a bit better
            store.vendor.Add(new Vendor { Firstname = "Billy", LastName = "Bob", Commision = .2 });
            store.vendor.Add(new Vendor { Firstname = "Sammy", LastName = "Whinchester", Commision = .4 });

            store.item.Add(new Item
            {
                item = "book",
                description = "Moby Dick",
                Price = 5,
                
            });


            store.item.Add(new Item
            {
                item = "book",
                description = "HarryPotter",
                Price = 10,
                
            });


            store.item.Add(new Item
            {
                item = "book",
                description = "Lord Of the rings",
                Price = 5,
               
            });


            store.item.Add(new Item
            {
                item = "book light ",
                description = "a little ligh",
                Price = 5.99,
                
            });

            store.Name = "Gs Little book Stop";

        }

       private void Shop_Click(object sender, EventArgs e)
        {
          
        }
      
        private void AddToCart_Click(object sender, EventArgs e)
        {
            // figure out what is selected 
            // copy the items to the shoping car
            Item selectedItem = (Item)ItemListBox.SelectedItem;
            // move item
            ShopingCartData.Add(selectedItem);
            //refresh 
            cartBinding.ResetBindings(false);
            
        }
    }
}
