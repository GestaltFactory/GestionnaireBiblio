using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionnaireBiblio.GUI;
using ClassLibraryBusinessRules;
using ClassLibraryIOdata;

namespace GestionnaireBiblio
{
    public partial class FormGestBiblio : Form
    {
        public FormGestBiblio()
        {
            InitializeComponent();
        }

        FrmHR cli = new FrmHR();
        FrmInventory inv = new FrmInventory();
        FrmAddProduct pro = new FrmAddProduct();

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to quit the library?", "Exit program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            cli.MdiParent = this;
            inv.Hide();
            pro.Hide();
            cli.Show();
            cli.Location = new Point(0, 0);
        }

        private void addAProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pro.MdiParent = this;
            inv.Hide();
            cli.Hide();
            pro.Show();
            pro.Location = new Point(0, 0);
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.MdiParent = this;
            pro.Hide();
            cli.Hide();
            inv.Show();
            inv.Location = new Point(0, 0);
        }
    }
}
