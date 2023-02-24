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
    public partial class Auto : UserControl
    {
        public List<int> Naklad = new List<int>();
        public bool jedeDoStanice = false;
        public bool NaStanici = true;
        public Stanice Stanice { get; set; }
        public Point Start { get; set; }
        public CentralniDispecink CentralniDispecink { get; set; }
        public int distance = 0;
        public Auto()
        {
            InitializeComponent();
        }
        private double TangensBody(Point a, Point b)
        {
            return (double)(b.Y - a.Y) / (b.X - a.X);
        }
        public Point GetPointFromY()
        {
            if (jedeDoStanice) { distance--; } else { distance++; }
            double tangens = TangensBody(Start, CentralniDispecink.Location);
            int multiplier = Start.Y < CentralniDispecink.Location.Y ? 1 : -1;
            double x = Start.X + (distance / tangens) * multiplier;
            return new Point((int)x, (Start.Y + distance * multiplier));
        }

        public Point GetPointFromX()
        {
            if (jedeDoStanice) { distance--; } else { distance++; }
            double tangens = TangensBody(Start, CentralniDispecink.Location);
            int multiplier = Start.X < CentralniDispecink.Location.X ? 1 : -1;
            double y = Start.Y + (tangens * distance) * multiplier;
            return new Point((Start.X + distance * multiplier), (int)y);
        }

        public void NalozStanice()
        {
            Naklad.AddRange(Stanice.Odvezeni);
            Stanice.Odvezeni.Clear();
            if (Naklad.Count > 1)
            {
                jedeDoStanice = false;
            }
        }

        public void VylozStanice()
        {
            Stanice.VyzvednutiCount += Naklad.Where(x => x == Stanice.Id).Count();
            Naklad.RemoveAll(x => x == Stanice.Id);
        }
        public void NalozDispecink()
        {
            Naklad.AddRange(CentralniDispecink.Baliky.Where(x => x == Stanice.Id));
            CentralniDispecink.Baliky.RemoveAll(x => x == Stanice.Id);
        }
        public void VylozDispecink()
        {
            CentralniDispecink.Baliky.AddRange(Naklad);
            Naklad.Clear();
        }
    }
}
