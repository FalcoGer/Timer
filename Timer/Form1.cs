using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private bool running = false;
        private TimeSpan remainingTime = TimeSpan.FromTicks(0);
        private bool alarm = false;

        private DateTime lastTimerTick = DateTime.Now;

        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private bool playerPlaying = false;

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = @".\alarm.wav";
        }

        private void Btn_startpause_Click(object sender, EventArgs e)
        {
            alarm = false;
            if (running)
            {
                running = false;
                btn_startpause.Text = "Resume";
            }
            else
            {
                btn_startpause.Text = "Pause";
                if (remainingTime.Ticks > 0)
                {
                    // continue
                    running = true;
                }
                else
                {
                    // no time left, start anew
                    if (rb_at.Checked)
                    {
                        DateTime targetTime = DateTime.MinValue;
                        if (DateTime.TryParseExact(
                            DateTime.Now.ToString("dd.MM.yyyy") + " " + tb_at.Text,
                            "dd.MM.yyyy HH:mm:ss",
                            System.Globalization.CultureInfo.InvariantCulture, 
                            System.Globalization.DateTimeStyles.None, 
                            out targetTime))
                        {
                            tb_at.BackColor = default;
                            if (targetTime < DateTime.Now)
                            {
                                targetTime = targetTime.AddDays(1);
                            }
                            remainingTime = targetTime - DateTime.Now;
                            running = true;
                        }
                        else
                        {
                            tb_at.BackColor = System.Drawing.Color.Pink;
                        }
                    }
                    else if (rb_in.Checked)
                    {
                        int h, m, s;
                        bool ok = int.TryParse(tb_h.Text, out h);
                        if (ok)
                        {
                            tb_h.BackColor = default;
                            ok = int.TryParse(tb_m.Text, out m);
                            if (ok)
                            {
                                tb_m.BackColor = default;
                                ok = int.TryParse(tb_s.Text, out s);
                                if (ok)
                                {
                                    tb_s.BackColor = default;
                                    remainingTime = new TimeSpan(hours: h, minutes: m, seconds: s);
                                    running = true;
                                }
                                else
                                {
                                    tb_s.BackColor = System.Drawing.Color.Pink;
                                }
                            }
                            else
                            {
                                tb_m.BackColor = System.Drawing.Color.Pink;
                            }
                        }
                        else
                        {
                            tb_h.BackColor = System.Drawing.Color.Pink;
                        }
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            running = false;
            alarm = false;
            remainingTime = TimeSpan.FromTicks(0);
            btn_startpause.Text = "Start";
        }

        private void Timer_100ms_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                remainingTime -= DateTime.Now - lastTimerTick;
                if (remainingTime.Ticks <= 0)
                {
                    running = false;
                    alarm = true;
                    btn_startpause.Text = "Start";
                    remainingTime = TimeSpan.FromTicks(0);
                }
            }

            lbl_remainingTime.Text = remainingTime.ToString();

            if (alarm)
            {
                lbl_remainingTime.BackColor = System.Drawing.Color.Red;
                if (!playerPlaying)
                {
                    player.PlayLooping();
                    playerPlaying = true;
                }
            }
            else
            {
                if (playerPlaying)
                {
                    player.Stop();
                    playerPlaying = false;
                }
                lbl_remainingTime.BackColor = default;
            }

            lastTimerTick = DateTime.Now;
        }

        private void Tb_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar < '0') || (e.KeyChar > '9'))
            {
                e.Handled = true; // stop this
            }
        }

        private void Tb_at_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                (tb_at.Text.Cast<char>().Where(x => x == ':' ).Count() >= 2) && e.KeyChar == ':' // only allow ':' x2
                || (e.KeyChar != ':' && ((e.KeyChar >= 32 && e.KeyChar < '0') || (e.KeyChar > '9')))
                )
            {
                e.Handled = true;
            }
        }
    }
}
