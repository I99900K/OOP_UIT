namespace Components
{
    partial class GameManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameManager));
            this.txtScore = new System.Windows.Forms.Label();
            this.txtRatio = new System.Windows.Forms.Label();
            this.txtRestart = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.catPic = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(51, 29);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 29);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // txtRatio
            // 
            this.txtRatio.AutoSize = true;
            this.txtRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatio.Location = new System.Drawing.Point(51, 72);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(157, 29);
            this.txtRatio.TabIndex = 1;
            this.txtRatio.Text = "Score Ratio:";
            // 
            // txtRestart
            // 
            this.txtRestart.AutoSize = true;
            this.txtRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestart.Location = new System.Drawing.Point(272, 29);
            this.txtRestart.Name = "txtRestart";
            this.txtRestart.Size = new System.Drawing.Size(254, 58);
            this.txtRestart.TabIndex = 2;
            this.txtRestart.Text = "[ Press R to Restart ]\r\n[ Press ESC to Quit ]";
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(646, 29);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(80, 29);
            this.txtState.TabIndex = 3;
            this.txtState.Text = "State:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // barrier2
            // 
            this.barrier2.Image = global::Components.Properties.Resources.obstacle_2;
            this.barrier2.Location = new System.Drawing.Point(707, 539);
            this.barrier2.Margin = new System.Windows.Forms.Padding(4);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(67, 62);
            this.barrier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier2.TabIndex = 8;
            this.barrier2.TabStop = false;
            this.barrier2.Tag = "barrier";
            // 
            // barrier1
            // 
            this.barrier1.Image = global::Components.Properties.Resources.obstacle_1;
            this.barrier1.Location = new System.Drawing.Point(456, 544);
            this.barrier1.Margin = new System.Windows.Forms.Padding(4);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(23, 46);
            this.barrier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.barrier1.TabIndex = 7;
            this.barrier1.TabStop = false;
            this.barrier1.Tag = "barrier";
            // 
            // catPic
            // 
            this.catPic.Image = global::Components.Properties.Resources.run;
            this.catPic.Location = new System.Drawing.Point(124, 520);
            this.catPic.Margin = new System.Windows.Forms.Padding(4);
            this.catPic.Name = "catPic";
            this.catPic.Size = new System.Drawing.Size(71, 75);
            this.catPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catPic.TabIndex = 6;
            this.catPic.TabStop = false;
            // 
            // floor
            // 
            this.floor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(0, 601);
            this.floor.Margin = new System.Windows.Forms.Padding(4);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(837, 39);
            this.floor.TabIndex = 5;
            this.floor.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // GameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barrier2);
            this.Controls.Add(this.barrier1);
            this.Controls.Add(this.catPic);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtRestart);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.txtScore);
            this.Name = "GameManager";
            this.Size = new System.Drawing.Size(840, 630);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtRatio;
        private System.Windows.Forms.Label txtRestart;
        private System.Windows.Forms.Label txtState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox catPic;
        private System.Windows.Forms.PictureBox barrier1;
        private System.Windows.Forms.PictureBox barrier2;
        private System.Windows.Forms.Timer gameTimer;
    }
}
