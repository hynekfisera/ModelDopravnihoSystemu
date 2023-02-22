using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelDopravnihoSystemu
{
    public partial class Form2 : Form
    {
        public Stanice stanice { get; set; }
        public Form2(Stanice stanice)
        {
            InitializeComponent();
            this.stanice = stanice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stanice.VyzvednutiCount > 0)
            {
                stanice.VyzvednutiCount--;
                MessageBox.Show("Balík byl vyzvednut");
            }
            else
            {
                MessageBox.Show("Na stanici není žádný balík k vyzvednutí");

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(stanice);
            form.ShowDialog();
            this.Close();
        }
    }
}
