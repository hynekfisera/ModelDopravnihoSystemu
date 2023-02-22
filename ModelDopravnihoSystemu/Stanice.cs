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
    public partial class Stanice : UserControl
    {
        public int Id { get; set; }
        public int VyzvednutiCount { get; set; }
        public List<int> Odvezeni = new List<int>();
        public Stanice()
        {
            InitializeComponent();
        }

        private void btnInformace_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.ShowDialog();
        }
    }
}
