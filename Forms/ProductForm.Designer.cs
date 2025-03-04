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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxProductDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.panelCatagory = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCatagory);
            this.panel1.Controls.Add(this.richTextBoxProductDescription);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.labelStock);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelProductDescription);
            this.panel1.Controls.Add(this.labelProductName);
            this.panel1.Controls.Add(this.labelAddProduct);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 449);
            this.panel1.TabIndex = 0;
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
            this.labelStock.Location = new System.Drawing.Point(23, 377);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 325);
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
            this.labelAddProduct.Location = new System.Drawing.Point(23, 17);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(66, 13);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            // 
            // panelCatagory
            // 
            this.panelCatagory.AutoScroll = true;
            this.panelCatagory.Location = new System.Drawing.Point(21, 186);
            this.panelCatagory.Name = "panelCatagory";
            this.panelCatagory.Size = new System.Drawing.Size(221, 127);
            this.panelCatagory.TabIndex = 9;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 476);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.RichTextBox richTextBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Panel panelCatagory;
    }
}

