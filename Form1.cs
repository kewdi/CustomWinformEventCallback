using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace item_deletion_example
{
    public partial class Form1 : Form
    {
        public Form1()=> InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();

            child.OnItemDeleted += OnItemDeleted;

            //or could also do lamda expression:
            //child.OnItemDeleted += (obj, args) =>
            //{
            //    
            //};
        }

        private void OnItemDeleted(object sender, Form2.ItemDeletedEventArgs args)
        {
            string deleted_item_name = args.name;
            int deleted_item_num = args.number;

            //...

        }

    }
}
