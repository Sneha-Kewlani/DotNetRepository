using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int rollNo = int.Parse(rollNoTextbox.Text);
            string name = nameTextbox.Text;
            int marks = int.Parse(marksTextbox.Text);

            using (var db = new StudentFormDBEntities())
            {
                var studentdb = new StudentFormTable()
                {
                    StudentID = rollNo,
                    Name = name,
                    Marks = marks,
                };

                db.StudentFormTables.Add(studentdb);
                db.SaveChanges();

                rollNoTextbox.Clear();
                nameTextbox.Clear();
                marksTextbox.Clear();
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            using (var db = new StudentFormDBEntities())
            {
                var query = from b in db.StudentFormTables select b;

                DataTable dt = new DataTable();

                dt.Columns.Add("Roll_No", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Marks", typeof(int));

                foreach (StudentFormTable item in query)
                {
                    dt.Rows.Add(item.StudentID, item.Name, item.Marks);
                }
                dataGridView1.DataSource = dt;
            }
        }
    }
}
