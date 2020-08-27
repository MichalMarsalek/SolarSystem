using System;
using System.Drawing;

namespace Sluneční_soustava
{
    class Teleso
    {
        public string nazev;
        public TimeSpan dobaObehu;
        public double polomerObehu;
        public Bitmap obrazek;
        public Teleso[] obihaci;
        public Teleso rodic;
        public double x;
        public double y;
        public Teleso(string nazev, Bitmap obrazek, double dobaObehuDny, double polomerObehu, Teleso rodic)
        {
            this.nazev = nazev;
            this.obrazek = obrazek;
            this.dobaObehu = TimeSpan.FromDays(dobaObehuDny);
            this.polomerObehu = polomerObehu;
            this.rodic = rodic;
        }
        public Teleso(string nazev, Bitmap obrazek)
        {
            this.nazev = nazev;
            this.obrazek = obrazek;
            this.x = 0.5;
            this.y = 0.5;
        }
        public Teleso Obihac(string nazev)
        {
            foreach (Teleso obihac in this.obihaci)
            {
                if (obihac.nazev == nazev) return obihac;                
            }
            return null;
        }
        public void Vykresli(Scena scena)
        {
            Graphics grafika = Graphics.FromImage(scena.obrazek);
            if (this.polomerObehu == 0)//hvězda
            {
                grafika.DrawImage(this.obrazek, new Point((int)(this.x * scena.velikost - (double)this.obrazek.Height / 2), (int)(this.y * scena.velikost - (double)this.obrazek.Width / 2)));
                foreach (Teleso obihac in this.obihaci)
                {
                    obihac.Vykresli(scena);
                }
                if (scena.kreslitPopisky)
                {
                    grafika.DrawString(this.nazev, new Font("serif", 8), Brushes.Black, new Point((int)(this.x * scena.velikost) - 20, (int)(this.y * scena.velikost-6)));
                }
            }
            else
            {
                if (scena.kreslitTrajektorie)
                {
                    double levyHorniRohX = this.rodic.x - this.polomerObehu;
                    double levyHorniRohY = this.rodic.y - this.polomerObehu;
                    grafika.DrawEllipse(new Pen(Color.FromArgb(30, 255, 255, 255)), (int)(levyHorniRohX * scena.velikost), (int)(levyHorniRohY * scena.velikost), (int)(this.polomerObehu * 2 * scena.velikost), (int)(this.polomerObehu * 2 * scena.velikost));
                }
                double uhel = -(Scena.PodelTimeSpan(scena.cas, this.dobaObehu) - (int)Scena.PodelTimeSpan(scena.cas, this.dobaObehu)) * 2 * Math.PI;
                this.x = rodic.x + Math.Sin(uhel) * this.polomerObehu;
                this.y = rodic.y - Math.Cos(uhel) * this.polomerObehu;
                grafika.DrawImage(this.obrazek, new Point((int)(this.x * scena.velikost - (double)this.obrazek.Width / 2), (int)(this.y * scena.velikost - (double)this.obrazek.Height / 2)));
                if (scena.kreslitPopisky && !(scena.kreslitMesice && this.rodic==scena.slunce))
                {
                    double posun = this.nazev.Length * 5 / 2.0;
                    
                    //Popisky měsíců vždy pod měsícem
                    //grafika.DrawString(this.nazev, new Font("serif", 7), Brushes.White, new Point((int)(this.x * scena.velikost - posun), (int)(this.y * scena.velikost + this.obrazek.Height / 2 + 2)));
                    
                    //popisky měsíců se otáčí kolem měsíce
                    if (this.rodic == scena.slunce)
                        grafika.DrawString(this.nazev, new Font("serif", 7), Brushes.White, new Point((int)(this.x * scena.velikost - posun), (int)(this.y * scena.velikost + this.obrazek.Height / 2 + 2)));
                    else
                    {
                        double x = this.x + Math.Sin(uhel) * this.polomerObehu * 1.1;
                        double y = this.y - Math.Cos(uhel) * this.polomerObehu * 1.1;
                        grafika.DrawString(this.nazev, new Font("serif", 7), Brushes.White, new Point((int)(x * scena.velikost - posun), (int)(y * scena.velikost - 5)));
                    }
                    

                }
                if (scena.kreslitMesice && this.obihaci != null)
                {
                    foreach (Teleso obihac in this.obihaci)
                    {
                        obihac.Vykresli(scena);
                    }

                }
            }
            grafika.Dispose();
        }
    }
}
