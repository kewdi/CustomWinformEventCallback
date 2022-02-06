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
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        public class ItemDeletedEventArgs : EventArgs
        {
            //information to pass back about the item that gets deleted
            public string name;
            public int number;
            public ItemDeletedEventArgs(string a_name, int a_number)
            {
                name = a_name;
                number = a_number;
            }
        }
        public delegate void ItemDeletedEvent(object sender, ItemDeletedEventArgs args);
        public ItemDeletedEvent OnItemDeleted;

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new { name = "ditto", num = 8 };

            ItemDeletedEventArgs item_info = 
                new ItemDeletedEventArgs(item.name, item.num);

            OnItemDeleted.Invoke(sender, item_info);
        }
    }
}
