using System.Windows.Forms;

namespace MainForm.CS
{
    partial class Assignment4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment4));

            this.btnDeal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.imgCards = new System.Windows.Forms.ImageList(this.components);

            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();

            this.chkKeep1 = new System.Windows.Forms.CheckBox();
            this.chkKeep2 = new System.Windows.Forms.CheckBox();
            this.chkKeep3 = new System.Windows.Forms.CheckBox();
            this.chkKeep4 = new System.Windows.Forms.CheckBox();
            this.chkKeep5 = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();

            this.SuspendLayout();

            // 
            // Buttons
            // 
            this.btnDeal.Location = new System.Drawing.Point(50, 20);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 30);
            this.btnDeal.Text = "&Deal";
            this.btnDeal.UseVisualStyleBackColor = true;

            this.btnSave.Location = new System.Drawing.Point(600, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Text = "&Save Hand";
            this.btnSave.UseVisualStyleBackColor = true;

            this.btnLoad.Location = new System.Drawing.Point(700, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 30);
            this.btnLoad.Text = "&Load Hand";
            this.btnLoad.UseVisualStyleBackColor = true;

            // 
            // ImageList
            // 
            this.imgCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCards.ImageStream")));
            this.imgCards.TransparentColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < 52; i++)
            {
                this.imgCards.Images.SetKeyName(i, $"p{i}.png");
            }

            // 
            // PictureBoxes
            // 
            PictureBox[] pics = { picCard1, picCard2, picCard3, picCard4, picCard5 };
            int startX = 20, startY = 70, cardWidth = 140, cardHeight = 191, spacing = 10;

            for (int i = 0; i < pics.Length; i++)
            {
                pics[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pics[i].Location = new System.Drawing.Point(startX + i * (cardWidth + spacing), startY);
                pics[i].Size = new System.Drawing.Size(cardWidth, cardHeight);
                pics[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pics[i].TabStop = false;
            }

            // 
            // CheckBoxes
            // 
            CheckBox[] checks = { chkKeep1, chkKeep2, chkKeep3, chkKeep4, chkKeep5 };
            int checkY = startY - 25;
            for (int i = 0; i < checks.Length; i++)
            {
                checks[i].AutoSize = true;
                checks[i].Location = new System.Drawing.Point(startX + i * (cardWidth + spacing) + 40, checkY);
                checks[i].Text = $"&Keep {i + 1}";
                checks[i].UseVisualStyleBackColor = true;
            }

            // 
            // Assignment4 Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { btnDeal, btnSave, btnLoad });
            this.Controls.AddRange(pics);
            this.Controls.AddRange(checks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Assignment4";
            this.Text = "Poker Hand Simulator";
            this.Load += new System.EventHandler(this.Assignment4_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ImageList imgCards;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.PictureBox picCard5;
        private System.Windows.Forms.CheckBox chkKeep1;
        private System.Windows.Forms.CheckBox chkKeep2;
        private System.Windows.Forms.CheckBox chkKeep3;
        private System.Windows.Forms.CheckBox chkKeep4;
        private System.Windows.Forms.CheckBox chkKeep5;
    }
}
