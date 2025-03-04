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
    public partial class ProductForm : Form
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
    }
}
