using HaloStats.Http;
using HaloStats.Library;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HaloStatsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void StartProgress()
        {
            Cursor.Current = Cursors.WaitCursor;
            TxtGamertag.Enabled = false;
            BtnLoad.Enabled = false;
        }

        private void StopProgress()
        {
            Cursor.Current = Cursors.Default;
            TxtGamertag.Enabled = true;
            BtnLoad.Enabled = true;
        }

        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            StartProgress();
            try
            {
                //sloppy testing here but...
                HttpREST rest = new HttpREST();
                //Get Spartan and Emblem...
                Image spartanImage = Image.FromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/spartan?size=128"));
                Image emblemImage = Image.FromStream(await rest.GetImage($"profile/h5/profiles/{TxtGamertag.Text}/emblem?size=128"));
                


                //Get player history
                var history = await rest.GetItem<PlayerMatchHistory>($"stats/h5/players/{TxtGamertag.Text}/matches?modes=Arena&start=0&count=10");


                StopProgress();
                PbSpartan.Image = spartanImage;
                PbEmblem.Image = emblemImage;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                StopProgress();
            }
        }

        private void TxtGamertag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BtnLoad.PerformClick();
        }

        private void TxtGamertag_TextChanged(object sender, EventArgs e)
        {
            BtnLoad.Enabled = !string.IsNullOrWhiteSpace(TxtGamertag.Text) ? true : false;
        }
    }
}
