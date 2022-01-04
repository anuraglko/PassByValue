using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace PassByValue
{
    public partial class Org : Form
    {
        public Org()
        {
            InitializeComponent();
             o = new Organization();
        }
        public Organization o { get; set; }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 100; i++)
            {
                o.Employees.Add(new Employee
                {
                    Name = "A" + i,
                    ID=i
                });
                         


            }
            o.Employees.ForEach(emp => checkedListBox1.Items.Add(emp.Name,true));
           
        }

        private void button2_Click(object sender, EventArgs e)


        {


            checkedListBox1.CheckedItems.Cast<Object>().ToList().ForEach(e =>

           {
               var emps = o.Employees.FirstOrDefault(emp => emp.Name == Convert.ToString(e));
              checkedListBox2.Items.Add(emps.Name);
           });

         
        }
       //public async Task MoveItemasync()
       // {
       //     await 

       // }
    }
}
