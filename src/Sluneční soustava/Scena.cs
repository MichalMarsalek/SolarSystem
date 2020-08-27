using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sluneční_soustava
{
    class Scena
    {
        public TimeSpan cas;
        public bool kreslitTrajektorie;
        public bool kreslitPopisky;
        public bool kreslitMesice;
        public int velikost;
        public PictureBox pictureBox;
        public Bitmap obrazek;
        public bool konecSveta = false;
        public Teleso slunce = new Teleso("Slunce", Properties.Resources.slunce);
        public Scena(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.kreslitTrajektorie = true;
            Random nahoda = new Random();
            this.cas = TimeSpan.FromDays(365 * (100+nahoda.Next(101)));
            this.obrazek = new Bitmap(1, 1);
            slunce.obihaci = new Teleso[]{  new Teleso("Merkur",    Properties.Resources.merkur,     88, 0.08, slunce),
                                            new Teleso("Venuše",    Properties.Resources.venuse,     225, 0.12, slunce),
                                            new Teleso("Země",      Properties.Resources.zeme,       365, 0.16, slunce),
                                            new Teleso("Mars",      Properties.Resources.mars,       687, 0.20, slunce),
                                            new Teleso("Jupiter",   Properties.Resources.jupiter,    4332, 0.29, slunce),
                                            new Teleso("Saturn",    Properties.Resources.saturn,     10768, 0.33, slunce),
                                            new Teleso("Uran",      Properties.Resources.uran,       30685, 0.37, slunce),
                                            new Teleso("Neptun",    Properties.Resources.neptun,     60190, 0.41, slunce),
                                            new Teleso("Pluto",     Properties.Resources.pluto,      90739, 0.45, slunce),
                                            };
            slunce.Obihac("Země").obihaci = new Teleso[] { new Teleso("Měsíc", Properties.Resources.mesic, 28, 0.018, slunce.Obihac("Země")) };
            slunce.Obihac("Mars").obihaci = new Teleso[] { new Teleso("Phobos", Properties.Resources.mesic, 0.32, 0.014, slunce.Obihac("Mars")),
                                                           new Teleso("Deimos", Properties.Resources.mesic, 1.26, 0.021, slunce.Obihac("Mars")) };
            slunce.Obihac("Jupiter").obihaci = new Teleso[] {  new Teleso("Io", Properties.Resources.mesic,        1.77, 0.012, slunce.Obihac("Jupiter")),
                                                               new Teleso("Europa", Properties.Resources.mesic,    3.55, 0.017, slunce.Obihac("Jupiter")),
                                                               new Teleso("Ganymed", Properties.Resources.mesic,   7.15, 0.022, slunce.Obihac("Jupiter")),
                                                               new Teleso("Callisto", Properties.Resources.mesic,  16.69, 0.027, slunce.Obihac("Jupiter")) };
            slunce.Obihac("Saturn").obihaci = new Teleso[] { new Teleso("Rhea", Properties.Resources.mesicMaly,     4.52, 0.02, slunce.Obihac("Saturn")),
                                                             new Teleso("Titan", Properties.Resources.mesic,        16, 0.025, slunce.Obihac("Saturn")),
                                                             new Teleso("Iapetus", Properties.Resources.mesicMaly,  79, 0.03, slunce.Obihac("Saturn")) };
            slunce.Obihac("Uran").obihaci = new Teleso[] {  new Teleso("Ariel", Properties.Resources.mesicMaly,     2.52, 0.012, slunce.Obihac("Uran")),
                                                            new Teleso("Umbriel", Properties.Resources.mesicMaly,   4.14, 0.017, slunce.Obihac("Uran")),
                                                            new Teleso("Titania", Properties.Resources.mesic,        8.7, 0.022, slunce.Obihac("Uran")),
                                                            new Teleso("Oberon", Properties.Resources.mesic,        13.46, 0.027, slunce.Obihac("Uran"))};
            slunce.Obihac("Neptun").obihaci = new Teleso[] { new Teleso("Proteus", Properties.Resources.mesicMaly,  1.1, 0.012, slunce.Obihac("Neptun")),
                                                             new Teleso("Triton", Properties.Resources.mesic,       -5.9, 0.017, slunce.Obihac("Neptun")),
                                                             new Teleso("Nereida", Properties.Resources.mesicMaly,  360, 0.027, slunce.Obihac("Neptun"))};
            slunce.Obihac("Pluto").obihaci = new Teleso[] { new Teleso("Charon", Properties.Resources.mesic, 6.39,  0.025, slunce.Obihac("Pluto")) };
            
        }
        static public double PodelTimeSpan(TimeSpan a, TimeSpan b)
        {
            return a.TotalSeconds / b.TotalSeconds;
        }
        static public TimeSpan PodelTimeSpan(TimeSpan a, double b)
        {
            return TimeSpan.FromSeconds(a.TotalSeconds / b);
        }
        static public TimeSpan VynasobTimeSpan(TimeSpan a, double b)
        {
            return TimeSpan.FromSeconds(a.TotalSeconds * b);
        }
        
        public void Vykresli()
        {
            this.obrazek.Dispose();
            this.obrazek = new Bitmap(this.velikost, this.velikost);
            slunce.Vykresli(this);
            this.pictureBox.Image = this.obrazek;
        }
    }
}
