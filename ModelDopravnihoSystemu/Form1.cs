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
    public partial class Form1 : Form
    {
        public List<Stanice> stanice = new List<Stanice>();
        public List<Auto> auta = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            StaniceInit();
            AutaInit();
        }
        private void StaniceInit()
        {
            stanice.Add(stanice1);
            stanice.Add(stanice2);
            stanice.Add(stanice3);
            stanice.Add(stanice4);
            stanice.Add(stanice5);
            stanice.Add(stanice6);
            stanice.Add(stanice7);
            stanice.Add(stanice8);
        }
        private void AutaInit()
        {
            auta.Add(auto1);
            auta.Add(auto2);
            auta.Add(auto3);
            auta.Add(auto4);
            auta.Add(auto5);
            auta.Add(auto6);
            auta.Add(auto7);
            auta.Add(auto8);
            for (int i = 0; i < auta.Count; i++)
            {
                auta[i].Stanice = stanice[i];
                auta[i].Start = auta[i].Location;
                auta[i].CentralniDispecink = centralniDispecink1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stanice.Count != 0)
            {
                for (int i = 0; i < stanice.Count; i++)
                {
                    stanice[i].Id = i + 1;
                    stanice[i].labelStaniceId.Text = "Stanice " + stanice[i].Id;
                    stanice[i].labelStaniceVyzvednuti.Text = "K vyzvednutí: " + stanice[i].VyzvednutiCount;
                    stanice[i].labelStaniceOdvezeni.Text = "K odvezení: " + stanice[i].Odvezeni.Count;
                }
            }
            for (int i = 0; i < auta.Count; i++)
            {
                var auto = auta[i];
                var rozdilx = Math.Abs((auto.jedeDoStanice ? auto.Start.X : auto.CentralniDispecink.Location.X) - auto.Location.X);
                var rozdily = Math.Abs((auto.jedeDoStanice ? auto.Start.Y : auto.CentralniDispecink.Location.Y) - auto.Location.Y);
                if (!(rozdilx <= 1 && rozdily <= 1))
                {
                    auto.Location = rozdilx >= rozdily ? auto.GetPointFromY() : auto.GetPointFromX();
                }
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            foreach (var auto in auta)
            {
                auto.jedeDoStanice = !auto.jedeDoStanice;
            }
        }
    }
}
