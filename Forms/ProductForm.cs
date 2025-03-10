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
            LoadGridProductListActionButtons();

        }

        private void LoadGridProductListActionButtons()
        {
            // Create action buttons view, edit and delete
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
            {
                Name = "View",
                Text = "View",
                UseColumnTextForButtonValue = false,
                HeaderText = "View",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = false,
                HeaderText = "Edit",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = false,
                HeaderText = "Delete",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            dataGridViewProductList.Columns.Add(viewButton);
            dataGridViewProductList.Columns.Add(editButton);
            dataGridViewProductList.Columns.Add(deleteButton);
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
            if (radioButtonActiveInactive.Text == "Active")
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

        private void textBoxSearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = textBoxSearchProduct.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewProductList.Rows)
            {
                if (searchText.Length != 0)
                {
                    if (row.Cells["ProductName"].Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
               
            }
        }
    }
}
