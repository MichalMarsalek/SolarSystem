using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sluneční_soustava
{
    public partial class Form1 : Form
    {
        Scena scena;
        int vyskaOkna;
        int sirkaOkna;
        Point poziceOkna;
        FormWindowState stavOkna;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scena = new Scena(pictureBoxScena);
            scena.velikost = Math.Min(pictureBoxScena.Width, pictureBoxScena.Height);
            timer.Start();
            this.WindowState = FormWindowState.Maximized;
        }
        private void panelScena_Paint(object sender, PaintEventArgs e)
        {
            scena.Vykresli();
        }

        private void checkBoxTrajektorie_CheckedChanged(object sender, EventArgs e)
        {
            scena.kreslitTrajektorie = checkBoxTrajektorie.Checked;
        }

        private void checkBoxPopisky_CheckedChanged(object sender, EventArgs e)
        {
            scena.kreslitPopisky = checkBoxPopisky.Checked;
        }

        private void checkBoxMesice_CheckedChanged(object sender, EventArgs e)
        {
            scena.kreslitMesice = checkBoxMesice.Checked;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonHodiny.Checked)
                    scena.cas += TimeSpan.FromHours((double)numericUpDownZrychleni.Value * timer.Interval / 1000);
                else if (radioButtonDny.Checked)
                    scena.cas += TimeSpan.FromDays((double)numericUpDownZrychleni.Value * timer.Interval / 1000);
                else
                    scena.cas += TimeSpan.FromDays((double)numericUpDownZrychleni.Value * timer.Interval / 1000 * 365.25);
                if (this.Visible && this.WindowState != FormWindowState.Minimized) scena.Vykresli();
            }
            catch (Exception exception)
            {
                if (exception is System.OverflowException)
                {
                    timer.Stop();
                    scena.konecSveta = true;
                    if (MessageBox.Show("Nastal konec světa!!!\n(přetečení hodnoty TimeSpanu)\n\nVytvořit nový svět?\n(restartovat?)", "Konec světa!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Application.Restart();
                    else
                        Application.Exit();
                }
            }
        }

        private void pictureBoxScena_Resize(object sender, EventArgs e)
        {
            if(scena!=null)
                scena.velikost = Math.Min(pictureBoxScena.Width, pictureBoxScena.Height);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F11:      checkBoxCelaObrazovka.Checked = !checkBoxCelaObrazovka.Checked;             break;
                case Keys.Escape:   checkBoxCelaObrazovka.Checked = false;                                      break;
                case Keys.T:        checkBoxTrajektorie.Checked   = !checkBoxTrajektorie.Checked;               break;
                case Keys.P:        checkBoxPopisky.Checked       = !checkBoxPopisky.Checked;                   break;
                case Keys.M:        checkBoxMesice.Checked        = !checkBoxMesice.Checked;                    break;
                case Keys.H:        radioButtonHodiny.Checked     = true;                                       break;
                case Keys.D:        radioButtonDny.Checked        = true;                                       break;
                case Keys.R:        radioButtonRoky.Checked       = true;                                       break;
                case Keys.Up:       numericUpDownZrychleni.Value++;                                             break;
                case Keys.Down:     numericUpDownZrychleni.Value=Math.Max(0, numericUpDownZrychleni.Value-1);   break;
                case Keys.Right:    numericUpDownZrychleni.Value+=10;                                           break;
                case Keys.Left:     numericUpDownZrychleni.Value=Math.Max(0, numericUpDownZrychleni.Value-10);  break;                
            }
            e.Handled = true;
        }
        private void pictureBoxScena_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                if (e.X <= panelOvladani.Width && e.Y <= panelOvladani.Height)
                {
                    panelOvladani.Visible = true;
                }
                else
                {
                    panelOvladani.Visible = false;
                }
            }
        }

        private void checkBoxCelaObrazovka_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCelaObrazovka.Checked)
            {
                poziceOkna = this.Location;
                stavOkna = this.WindowState;
                this.TopMost = true;
                this.WindowState = FormWindowState.Normal;
                sirkaOkna = this.Width;
                vyskaOkna = this.Height;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                pictureBoxScena.Location = new Point(0, 0);
                pictureBoxScena.Size = this.Size;
                panelOvladani.Visible = false;
            }
            else
            {
                this.TopMost = false;
                this.WindowState = stavOkna;
                this.Location = poziceOkna;
                this.Width = sirkaOkna;
                this.Height = vyskaOkna;
                pictureBoxScena.Location = new Point(13, 61);
                pictureBoxScena.Size = new Size(this.Size.Width - 26, this.Size.Height - 73);
                panelOvladani.Visible = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;

            }
        }
        
    }
}
