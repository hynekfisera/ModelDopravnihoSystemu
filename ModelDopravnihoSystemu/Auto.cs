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
        public Stanice Stanice = new Stanice();
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
    }
}
