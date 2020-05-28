using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblWorm
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Bibliotheque_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public string Author
        {
            get { return textAuthor.Text; }
            set { textAuthor.Text = value; }
        }
        public string Title
        {
            get { return textName.Text; }
            set { textName.Text = value; }
        }
        public string PublishHouse
        {
            get { return textPublish.Text; }
            set { textPublish.Text = value; }
        }
        public int Page
        {
            get { return (int)numericPages.Value; }
            set { numericPages.Value = value; }
        }
        public int Year
        {
            get { return (int)numericYear.Value; }
            set { numericYear.Value = value; }
        }
        public int InvNumber
        {
            get { return (int)numericInventory.Value; }
            set { numericInventory.Value = value; }
        }
        public bool Existance
        {
            get { return checkAvailability.Checked; }
            set { checkAvailability.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return checkSort.Checked; }
            set { checkSort.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return checkReturn.Checked; }
            set { checkReturn.Checked = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericDuration.Value; }
            set { numericDuration.Value = value; }
        }
        List<Item> its = new List<Item>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book firstBook = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existance);
            if (ReturnTime)
            {
                firstBook.ReturnSrok();
                firstBook.PriceBook(PeriodUse);
                its.Add(firstBook);
            }

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existance = ReturnTime = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
            }

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
