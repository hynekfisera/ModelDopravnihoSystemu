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
    public partial class Form3 : Form
    {
        public Stanice stanice { get; set; }
        public Form3(Stanice stanice)
        {
            InitializeComponent();
            listBox1.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            this.stanice = stanice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stanice.Odvezeni.Add(Int32.Parse(listBox1.SelectedItem.ToString()));
            MessageBox.Show("Balík byl přidán k odvezení");
            this.Close();
        }
    }
}
