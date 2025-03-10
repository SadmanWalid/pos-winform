using System;

namespace POS
{
    partial class ProductForm
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
            this.panelProductAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonActiveInactive = new System.Windows.Forms.RadioButton();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.buttonImageUpload = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.panelCatagory = new System.Windows.Forms.Panel();
            this.richTextBoxProductDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.panelProductList = new System.Windows.Forms.Panel();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelManageProducts = new System.Windows.Forms.Label();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.buttonSyncProduct = new System.Windows.Forms.Button();
            this.panelProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProductAdd
            // 
            this.panelProductAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProductAdd.Controls.Add(this.button1);
            this.panelProductAdd.Controls.Add(this.radioButtonActiveInactive);
            this.panelProductAdd.Controls.Add(this.pictureBoxProductImage);
            this.panelProductAdd.Controls.Add(this.buttonImageUpload);
            this.panelProductAdd.Controls.Add(this.textBoxStock);
            this.panelProductAdd.Controls.Add(this.textBoxPrice);
            this.panelProductAdd.Controls.Add(this.panelCatagory);
            this.panelProductAdd.Controls.Add(this.richTextBoxProductDescription);
            this.panelProductAdd.Controls.Add(this.textBoxProductName);
            this.panelProductAdd.Controls.Add(this.labelImage);
            this.panelProductAdd.Controls.Add(this.labelStock);
            this.panelProductAdd.Controls.Add(this.labelPrice);
            this.panelProductAdd.Controls.Add(this.labelProductDescription);
            this.panelProductAdd.Controls.Add(this.labelProductName);
            this.panelProductAdd.Controls.Add(this.labelAddProduct);
            this.panelProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProductAdd.Location = new System.Drawing.Point(14, 6);
            this.panelProductAdd.Name = "panelProductAdd";
            this.panelProductAdd.Size = new System.Drawing.Size(297, 575);
            this.panelProductAdd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create Product";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonActiveInactive
            // 
            this.radioButtonActiveInactive.AutoSize = true;
            this.radioButtonActiveInactive.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonActiveInactive.Checked = true;
            this.radioButtonActiveInactive.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonActiveInactive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonActiveInactive.Location = new System.Drawing.Point(26, 499);
            this.radioButtonActiveInactive.Name = "radioButtonActiveInactive";
            this.radioButtonActiveInactive.Size = new System.Drawing.Size(55, 17);
            this.radioButtonActiveInactive.TabIndex = 15;
            this.radioButtonActiveInactive.TabStop = true;
            this.radioButtonActiveInactive.Text = "Active";
            this.radioButtonActiveInactive.UseVisualStyleBackColor = false;
            this.radioButtonActiveInactive.Click += new System.EventHandler(this.radioButtonActiveInactive_Click);
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Location = new System.Drawing.Point(151, 419);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(98, 59);
            this.pictureBoxProductImage.TabIndex = 13;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // buttonImageUpload
            // 
            this.buttonImageUpload.Location = new System.Drawing.Point(21, 446);
            this.buttonImageUpload.Name = "buttonImageUpload";
            this.buttonImageUpload.Size = new System.Drawing.Size(124, 23);
            this.buttonImageUpload.TabIndex = 12;
            this.buttonImageUpload.Text = "Upload Product Image";
            this.buttonImageUpload.UseVisualStyleBackColor = true;
            this.buttonImageUpload.Click += new System.EventHandler(this.buttonImageUpload_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(21, 374);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(221, 20);
            this.textBoxStock.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(21, 334);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(221, 20);
            this.textBoxPrice.TabIndex = 10;
            // 
            // panelCatagory
            // 
            this.panelCatagory.AutoScroll = true;
            this.panelCatagory.Location = new System.Drawing.Point(21, 184);
            this.panelCatagory.Name = "panelCatagory";
            this.panelCatagory.Size = new System.Drawing.Size(221, 131);
            this.panelCatagory.TabIndex = 9;
            // 
            // richTextBoxProductDescription
            // 
            this.richTextBoxProductDescription.Location = new System.Drawing.Point(26, 116);
            this.richTextBoxProductDescription.Name = "richTextBoxProductDescription";
            this.richTextBoxProductDescription.Size = new System.Drawing.Size(208, 48);
            this.richTextBoxProductDescription.TabIndex = 8;
            this.richTextBoxProductDescription.Text = "";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(26, 65);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(208, 20);
            this.textBoxProductName.TabIndex = 7;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(23, 419);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(84, 13);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Image (Optional)";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(23, 358);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 318);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(23, 100);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(100, 13);
            this.labelProductDescription.TabIndex = 2;
            this.labelProductDescription.Text = "Product Description";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(23, 49);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(23, 17);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(97, 17);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            // 
            // panelProductList
            // 
            this.panelProductList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProductList.Controls.Add(this.buttonSyncProduct);
            this.panelProductList.Controls.Add(this.textBoxSearchProduct);
            this.panelProductList.Controls.Add(this.labelManageProducts);
            this.panelProductList.Controls.Add(this.dataGridViewProductList);
            this.panelProductList.Location = new System.Drawing.Point(326, 12);
            this.panelProductList.Name = "panelProductList";
            this.panelProductList.Size = new System.Drawing.Size(887, 620);
            this.panelProductList.TabIndex = 1;
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Image,
            this.ProductName,
            this.Price,
            this.Stock,
            this.Category,
            this.Status});
            this.dataGridViewProductList.Location = new System.Drawing.Point(3, 81);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.Size = new System.Drawing.Size(881, 284);
            this.dataGridViewProductList.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // labelManageProducts
            // 
            this.labelManageProducts.AutoSize = true;
            this.labelManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProducts.Location = new System.Drawing.Point(33, 40);
            this.labelManageProducts.Name = "labelManageProducts";
            this.labelManageProducts.Size = new System.Drawing.Size(134, 17);
            this.labelManageProducts.TabIndex = 1;
            this.labelManageProducts.Text = "Manage Products";
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearchProduct.Location = new System.Drawing.Point(516, 43);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(253, 20);
            this.textBoxSearchProduct.TabIndex = 2;
            this.textBoxSearchProduct.Text = "Search...";
            this.textBoxSearchProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchProduct_KeyUp);
            // 
            // buttonSyncProduct
            // 
            this.buttonSyncProduct.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSyncProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSyncProduct.Location = new System.Drawing.Point(775, 41);
            this.buttonSyncProduct.Name = "buttonSyncProduct";
            this.buttonSyncProduct.Size = new System.Drawing.Size(98, 23);
            this.buttonSyncProduct.TabIndex = 3;
            this.buttonSyncProduct.Text = "Sync Product";
            this.buttonSyncProduct.UseVisualStyleBackColor = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 644);
            this.Controls.Add(this.panelProductList);
            this.Controls.Add(this.panelProductAdd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ProductForm";
            this.Text = "Products";
            this.panelProductAdd.ResumeLayout(false);
            this.panelProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.panelProductList.ResumeLayout(false);
            this.panelProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panelProductAdd;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.RichTextBox richTextBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Panel panelCatagory;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonImageUpload;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.RadioButton radioButtonActiveInactive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelProductList;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Label labelManageProducts;
        private System.Windows.Forms.Button buttonSyncProduct;
    }
}

