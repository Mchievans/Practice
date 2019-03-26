using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace YoutubeAlarmClockforPI
{
    public partial class Form1 : Form
    {
        bool alarmed = false; // this boolean will check if the alarm has gone off.

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clocktimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clocktimer1
            // 
            this.clocktimer1.Enabled = true;
            this.clocktimer1.Interval = 1000;
            this.clocktimer1.Tick += new System.EventHandler(this.updateTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(151)))), ((int)(((byte)(127)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 561);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock - Emani Sunday";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(151)))), ((int)(((byte)(127)))));
            this.Load += new System.EventHandler(this.loadForm);
            this.ResumeLayout(false);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private IContainer components;
        private Timer clocktimer1;

        private void loadForm(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile("clock.ttf");

            label1.Font = new Font(pfc.Families[0], 32, FontStyle.Bold);
            label2.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            label3.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            label4.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);

            label1.ForeColor = System.Drawing.Color.FromArgb(25, 151, 127);
            label2.ForeColor = System.Drawing.Color.FromArgb(25, 151, 127);
            label3.ForeColor = System.Drawing.Color.FromArgb(25, 151, 127);
            label4.ForeColor = System.Drawing.Color.FromArgb(25, 151, 127);

            //label1.BackColor = System.Drawing.Color.GhostWhite;
            //label2.BackColor = System.Drawing.Color.GhostWhite;
            //label3.BackColor = System.Drawing.Color.GhostWhite;
            //label4.BackColor = System.Drawing.Color.GhostWhite;

            dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(25, 151, 127);
        }

        private void updateTimer(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToString("dddd");
            label3.Text = DateTime.Now.ToString("MMM dd yyyy");

            DateTime Current = DateTime.Now;

            DateTime UserTime = dateTimePicker1.Value;

            if (Current.Day == UserTime.Day && Current.Month == UserTime.Month
                && Current.Hour == UserTime.Hour && Current.Minute == UserTime.Minute && alarmed)
            {
                webBrowser1.Navigate(youtubelink.Text);

                alarmed = false;
            }

        }

        private void timerChanged(object sender, EventArgs e)
        {
            alarmed = true; 
        }
    }
}
