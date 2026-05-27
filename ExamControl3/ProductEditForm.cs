using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamControl3
{
    public partial class ProductEditForm : Form
    {


        int productId = 0;

        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(int prodId)
        {
            InitializeComponent();
            productId = prodId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
