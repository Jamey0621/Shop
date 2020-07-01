namespace Shop_UI
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxLable = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.BuyCart = new System.Windows.Forms.Button();
            this.ShopingCartList = new System.Windows.Forms.ListBox();
            this.ShopingCartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Demo";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(0, 76);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(296, 184);
            this.ItemListBox.TabIndex = 1;
            this.ItemListBox.Tag = "";
            this.ItemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // ItemsListBoxLable
            // 
            this.ItemsListBoxLable.AutoSize = true;
            this.ItemsListBoxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBoxLable.Location = new System.Drawing.Point(95, 23);
            this.ItemsListBoxLable.Name = "ItemsListBoxLable";
            this.ItemsListBoxLable.Size = new System.Drawing.Size(54, 20);
            this.ItemsListBoxLable.TabIndex = 2;
            this.ItemsListBoxLable.Text = "Items";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(330, 76);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(136, 40);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add to Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // BuyCart
            // 
            this.BuyCart.Location = new System.Drawing.Point(610, 269);
            this.BuyCart.Name = "BuyCart";
            this.BuyCart.Size = new System.Drawing.Size(186, 40);
            this.BuyCart.TabIndex = 5;
            this.BuyCart.Text = "Buy";
            this.BuyCart.UseVisualStyleBackColor = true;
            this.BuyCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopingCartList
            // 
            this.ShopingCartList.FormattingEnabled = true;
            this.ShopingCartList.ItemHeight = 20;
            this.ShopingCartList.Location = new System.Drawing.Point(500, 76);
            this.ShopingCartList.Name = "ShopingCartList";
            this.ShopingCartList.Size = new System.Drawing.Size(296, 184);
            this.ShopingCartList.TabIndex = 4;
            this.ShopingCartList.Tag = "";
            this.ShopingCartList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ShopingCartLabel
            // 
            this.ShopingCartLabel.AutoSize = true;
            this.ShopingCartLabel.Location = new System.Drawing.Point(596, 23);
            this.ShopingCartLabel.Name = "ShopingCartLabel";
            this.ShopingCartLabel.Size = new System.Drawing.Size(102, 20);
            this.ShopingCartLabel.TabIndex = 6;
            this.ShopingCartLabel.Text = "Shoping Cart";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 321);
            this.Controls.Add(this.ShopingCartLabel);
            this.Controls.Add(this.BuyCart);
            this.Controls.Add(this.ShopingCartList);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemsListBoxLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Click += new System.EventHandler(this.Shop_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemsListBoxLable;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Button BuyCart;
        private System.Windows.Forms.ListBox ShopingCartList;
        private System.Windows.Forms.Label ShopingCartLabel;
        public System.Windows.Forms.ListBox ItemListBox;
    }
}

