
namespace ObjectCollisionGame
{
    partial class ObjectCollidingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dragon2 = new System.Windows.Forms.PictureBox();
            this.Dragon3 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.Killer = new System.Windows.Forms.PictureBox();
            this.Dragon1 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dragon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Killer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dragon2
            // 
            this.Dragon2.BackColor = System.Drawing.Color.Transparent;
            this.Dragon2.Image = global::ObjectCollisionGame.Properties.Resources.enemy_adobespark;
            this.Dragon2.Location = new System.Drawing.Point(367, 40);
            this.Dragon2.Name = "Dragon2";
            this.Dragon2.Size = new System.Drawing.Size(100, 88);
            this.Dragon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon2.TabIndex = 6;
            this.Dragon2.TabStop = false;
            // 
            // Dragon3
            // 
            this.Dragon3.BackColor = System.Drawing.Color.Transparent;
            this.Dragon3.Image = global::ObjectCollisionGame.Properties.Resources.enemy_adobespark;
            this.Dragon3.Location = new System.Drawing.Point(683, 40);
            this.Dragon3.Name = "Dragon3";
            this.Dragon3.Size = new System.Drawing.Size(100, 88);
            this.Dragon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon3.TabIndex = 5;
            this.Dragon3.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::ObjectCollisionGame.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(436, 416);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(31, 61);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 4;
            this.bullet.TabStop = false;
            // 
            // Killer
            // 
            this.Killer.BackColor = System.Drawing.Color.Transparent;
            this.Killer.Image = global::ObjectCollisionGame.Properties.Resources.killer_removebg_preview_adobespark;
            this.Killer.Location = new System.Drawing.Point(367, 483);
            this.Killer.Name = "Killer";
            this.Killer.Size = new System.Drawing.Size(113, 139);
            this.Killer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Killer.TabIndex = 1;
            this.Killer.TabStop = false;
            // 
            // Dragon1
            // 
            this.Dragon1.BackColor = System.Drawing.Color.Transparent;
            this.Dragon1.Image = global::ObjectCollisionGame.Properties.Resources.enemy_adobespark;
            this.Dragon1.Location = new System.Drawing.Point(53, 40);
            this.Dragon1.Name = "Dragon1";
            this.Dragon1.Size = new System.Drawing.Size(100, 88);
            this.Dragon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon1.TabIndex = 0;
            this.Dragon1.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(195, 212);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(447, 118);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // ObjectCollidingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ObjectCollisionGame.Properties.Resources.backgroundgame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 624);
            this.Controls.Add(this.Dragon2);
            this.Controls.Add(this.Dragon3);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.Killer);
            this.Controls.Add(this.Dragon1);
            this.Controls.Add(this.txtScore);
            this.Name = "ObjectCollidingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Colliding Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Dragon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Killer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dragon1;
        private System.Windows.Forms.PictureBox Killer;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox Dragon3;
        private System.Windows.Forms.PictureBox Dragon2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

