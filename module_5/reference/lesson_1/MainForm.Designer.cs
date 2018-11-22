﻿namespace ml_csharp_lesson1
{
    partial class MainForm
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
            this.videoPlayer = new Accord.Controls.VideoSourcePlayer();
            this.edgeBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trafficSignBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSignBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Location = new System.Drawing.Point(10, 10);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(1097, 828);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.Text = "videoSourcePlayer1";
            this.videoPlayer.VideoSource = null;
            this.videoPlayer.NewFrame += new Accord.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoPlayer_NewFrame);
            // 
            // edgeBox
            // 
            this.edgeBox.BackColor = System.Drawing.Color.Black;
            this.edgeBox.Location = new System.Drawing.Point(10, 843);
            this.edgeBox.Name = "edgeBox";
            this.edgeBox.Size = new System.Drawing.Size(549, 345);
            this.edgeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edgeBox.TabIndex = 1;
            this.edgeBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Front Facing Camera - Raw Feed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 853);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edge Detection";
            // 
            // trafficSignBox
            // 
            this.trafficSignBox.BackColor = System.Drawing.Color.Black;
            this.trafficSignBox.Location = new System.Drawing.Point(559, 843);
            this.trafficSignBox.Name = "trafficSignBox";
            this.trafficSignBox.Size = new System.Drawing.Size(549, 345);
            this.trafficSignBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trafficSignBox.TabIndex = 5;
            this.trafficSignBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(572, 853);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Traffic Sign Detection";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1119, 1194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trafficSignBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edgeBox);
            this.Controls.Add(this.videoPlayer);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Machine Learning Advantage Course";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSignBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accord.Controls.VideoSourcePlayer videoPlayer;
        private System.Windows.Forms.PictureBox edgeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox trafficSignBox;
        private System.Windows.Forms.Label label3;
    }
}

