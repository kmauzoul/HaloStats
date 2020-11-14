
namespace HaloStatsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtGamertag = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PbSpartan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSpartan)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtGamertag
            // 
            this.TxtGamertag.Location = new System.Drawing.Point(36, 49);
            this.TxtGamertag.Name = "TxtGamertag";
            this.TxtGamertag.Size = new System.Drawing.Size(205, 27);
            this.TxtGamertag.TabIndex = 0;
            this.TxtGamertag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGamertag_KeyPress);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(259, 47);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(94, 29);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PbSpartan
            // 
            this.PbSpartan.Location = new System.Drawing.Point(36, 91);
            this.PbSpartan.Name = "PbSpartan";
            this.PbSpartan.Size = new System.Drawing.Size(205, 204);
            this.PbSpartan.TabIndex = 2;
            this.PbSpartan.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbSpartan);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.TxtGamertag);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbSpartan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGamertag;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.PictureBox PbSpartan;
    }
}

