using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductForm : System.Windows.Forms.Form
    {
        public ProductForm()
        {
            InitializeComponent();
            LoadCatagoryCheckBoxes();
        }

        private void LoadCatagoryCheckBoxes()
        {
            // later fetch the catagories from the database
            List<string> items = new List<string>
            {
                "Main Course",
                "Salad",
                "Soups",
                "Combo Meals",
                "Sides",
                "Pasta"
            };

            GroupBox groupBox = new GroupBox
            {
                Text = "Catagory",
                Location = new System.Drawing.Point(0, 0),
                AutoSize = true
            };

            int yPosition = groupBox.Location.Y + this.labelPrice.Height + 10;

            foreach (string item in items)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = item,
                    Location = new System.Drawing.Point(10, yPosition),
                    AutoSize = true
                };

                groupBox.Controls.Add(checkBox);
                yPosition += 20;    

            }

           
            // Add the groupBox to the panel
            this.panelCatagory.Controls.Add(groupBox);
        }

        private void buttonImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageUplaodDialog = new OpenFileDialog();
            imageUplaodDialog.Filter = "Image Files|*jpg;*.jpeg;*.png;*.bmp;*.gif";
            imageUplaodDialog.Title = "Select Product Image";

            if (imageUplaodDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxProductImage.Image = new Bitmap(imageUplaodDialog.FileName);
            }
        }


      private void radioButtonActiveInactive_Click(object sender, EventArgs e)
        {
            if (radioButtonActiveInactive.Checked)
            {
                radioButtonActiveInactive.Checked = false;
                radioButtonActiveInactive.Text = "Inactive";
            }
            else
            {
                radioButtonActiveInactive.Checked = true;
                radioButtonActiveInactive.Text = "Active"; ;
            }
        }

    
    }
}
