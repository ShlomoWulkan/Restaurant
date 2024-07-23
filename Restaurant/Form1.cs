using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        ConnectToXML XMLConnection = new ConnectToXML();
        List<List<string>> myOrders = new List<List<string>>();
        List<string> myDishe = new List<string>();

        public Form1()
        {
            InitializeComponent();
            GetXMLDishes();
        }

        private void GetXMLDishes()
        {
            foreach (string item in XMLConnection.GetXMLData()) 
            {
                lstFood.Items.Add(item);
            }
        }

        private void btnInsertToList_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string disheType = cmbDisheType.Text;
            string disheName = cmbDisheName.Text;
            if (name == "" || disheType == "" || disheName == "")
            {
                MessageBox.Show("אנא מלאו את כל הנתונים");
            } else {
                myDishe.AddRange(new List<string>() { name, disheType, disheName});
                myOrders.Add(myDishe);
                string order = $"{disheName}-{disheType}-{name}";
                lstFood.Items.Add(order);
            }
        }

        public void GetDishes()
        {
            switch (cmbDisheType.Text)
            {
                case "ראשונות":
                    cmbDisheName.Items.Clear();
                    cmbDisheName.Items.Add("דגים");
                    cmbDisheName.Items.Add("לחם הבית");
                    cmbDisheName.Items.Add("סלט יווני");
                    break;

                case "עיקריות":
                    cmbDisheName.Items.Clear();
                    cmbDisheName.Items.Add("מרק");
                    cmbDisheName.Items.Add("עוף");
                    cmbDisheName.Items.Add("בשר");
                    break;

                case "תוספות":
                    cmbDisheName.Items.Clear();
                    cmbDisheName.Items.Add("אורז");
                    cmbDisheName.Items.Add("פתיתים");
                    cmbDisheName.Items.Add("פירה");
                    break;

                case "אחרונות":
                    cmbDisheName.Items.Clear();
                    cmbDisheName.Items.Add("סופלה");
                    cmbDisheName.Items.Add("גלידה");
                    cmbDisheName.Items.Add("בונבונירה");
                    break;
            }
        }

        private void cmbDisheType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDisheName.Text = "";
            GetDishes();
        }

        private void btnInsertToXml_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("?האם אתה בטוח רוצה לשמור", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                XMLConnection.CreateXMLData(myOrders);
                MessageBox.Show("ההזמנה נשמרה בהצלחה");
            }
        }
    }
}
