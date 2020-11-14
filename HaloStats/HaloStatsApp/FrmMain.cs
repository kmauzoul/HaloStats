using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                Http.HttpREST rest = new Http.HttpREST();
                PbSpartan.Image = Image.FromStream(await rest.GetSpartanImage($"profile/h5/profiles/{TxtGamertag.Text}/spartan?size=128"));
                StopProgress();
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
    }
}
