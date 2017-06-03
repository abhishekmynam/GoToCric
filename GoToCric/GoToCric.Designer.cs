namespace GoToCric
{
    partial class Form1
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
            this.TopMost = true;
            this.BtsMan1 = new System.Windows.Forms.Label();
            this.BtsMan2 = new System.Windows.Forms.Label();
            this.Bowl1 = new System.Windows.Forms.Label();
            this.Bowl2 = new System.Windows.Forms.Label();
            this.Overs = new System.Windows.Forms.Label();
            this.Runrate = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.Label();
            this.ReqRate = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.btScr1 = new System.Windows.Forms.Label();
            this.btScr2 = new System.Windows.Forms.Label();
            this.overScr = new System.Windows.Forms.Label();
            this.RateScr = new System.Windows.Forms.Label();
            this.ReqScr = new System.Windows.Forms.Label();
            this.TargetScr = new System.Windows.Forms.Label();
            this.bowScr1 = new System.Windows.Forms.Label();
            this.bowScr2 = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.URL.Text = URI;
            // 
            // BtsMan1
            // 
            this.BtsMan1.AutoSize = true;
            this.BtsMan1.Location = new System.Drawing.Point(12, 58);
            this.BtsMan1.Name = "BtsMan1";
            this.BtsMan1.Size = new System.Drawing.Size(0, 13);
            this.BtsMan1.TabIndex = 0;
            this.BtsMan1.Text = scoreObj.btsMan1;
            // 
            // BtsMan2
            // 
            this.BtsMan2.AutoSize = true;
            this.BtsMan2.Location = new System.Drawing.Point(12, 82);
            this.BtsMan2.Name = "BtsMan2";
            this.BtsMan2.Size = new System.Drawing.Size(0, 13);
            this.BtsMan2.TabIndex = 1;
            this.BtsMan2.Text = scoreObj.btsMan2;
            // 
            // Bowl1
            // 
            this.Bowl1.AutoSize = true;
            this.Bowl1.Location = new System.Drawing.Point(12, 200);
            this.Bowl1.Name = "Bowl1";
            this.Bowl1.Size = new System.Drawing.Size(0, 13);
            this.Bowl1.TabIndex = 2;
            this.Bowl1.Text = scoreObj.bowl1;
            // 
            // Bowl2
            // 
            this.Bowl2.AutoSize = true;
            this.Bowl2.Location = new System.Drawing.Point(12, 227);
            this.Bowl2.Name = "Bowl2";
            this.Bowl2.Size = new System.Drawing.Size(0, 13);
            this.Bowl2.TabIndex = 3;
            this.Bowl2.Text = scoreObj.bowl2;
            // 
            // Overs
            // 
            //this.Overs.AutoSize = true;
            //this.Overs.Location = new System.Drawing.Point(12, 113);
            //this.Overs.Name = "Overs";
            //this.Overs.Size = new System.Drawing.Size(35, 13);
            //this.Overs.TabIndex = 4;
            //this.Overs.Text = "Overs";
            // 
            // Runrate
            // 
            this.Runrate.AutoSize = true;
            this.Runrate.Location = new System.Drawing.Point(12, 135);
            this.Runrate.Name = "Runrate";
            this.Runrate.Size = new System.Drawing.Size(48, 13);
            this.Runrate.TabIndex = 5;
            this.Runrate.Text = "Run rate";
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(12, 158);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(38, 13);
            this.Target.TabIndex = 6;
            this.Target.Text = "Target";
            // 
            // ReqRate
            // 
            this.ReqRate.AutoSize = true;
            this.ReqRate.Location = new System.Drawing.Point(12, 113);
            this.ReqRate.Name = "ReqRate";
            this.ReqRate.Size = new System.Drawing.Size(125, 13);
            this.ReqRate.TabIndex = 7;
            this.ReqRate.Text = "Required Rate";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(15, 263);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(208, 20);
            this.URL.TabIndex = 8;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(232, 263);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(62, 23);
            this.GoBtn.TabIndex = 9;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // btScr1
            // 
            this.btScr1.AutoSize = true;
            this.btScr1.Location = new System.Drawing.Point(125, 58);
            this.btScr1.Name = "btScr1";
            this.btScr1.Size = new System.Drawing.Size(0, 13);
            this.btScr1.TabIndex = 10;
            this.btScr1.Text = scoreObj.btsMan1Scr;
            // 
            // btScr2
            // 
            this.btScr2.AutoSize = true;
            this.btScr2.Location = new System.Drawing.Point(125, 82);
            this.btScr2.Name = "btScr2";
            this.btScr2.Size = new System.Drawing.Size(0, 13);
            this.btScr2.TabIndex = 11;
            this.btScr2.Text = scoreObj.btsMan2Scr;
            // 
            // overScr
            // 
            //this.overScr.AutoSize = true;
            //this.overScr.Location = new System.Drawing.Point(67, 113);
            //this.overScr.Name = "overScr";
            //this.overScr.Size = new System.Drawing.Size(0, 13);
            //this.overScr.TabIndex = 12;
            //this.overScr.Text = scoreObj.overs;
            // 
            // RateScr
            // 
            this.RateScr.AutoSize = true;
            this.RateScr.Location = new System.Drawing.Point(125, 135);
            this.RateScr.Name = "RateScr";
            this.RateScr.Size = new System.Drawing.Size(0, 13);
            this.RateScr.TabIndex = 13;
            this.RateScr.Text = scoreObj.runRate;
            // 
            // ReqScr
            // 
            this.ReqScr.AutoSize = true;
            this.ReqScr.Location = new System.Drawing.Point(125, 113);
            this.ReqScr.Name = "ReqScr";
            this.ReqScr.Size = new System.Drawing.Size(0, 13);
            this.ReqScr.TabIndex = 14;
            this.ReqScr.Text = scoreObj.reqRate;
            // 
            // TargetScr
            // 
            this.TargetScr.AutoSize = true;
            this.TargetScr.Location = new System.Drawing.Point(125, 158);
            this.TargetScr.Name = "TargetScr";
            this.TargetScr.Size = new System.Drawing.Size(0, 13);
            this.TargetScr.TabIndex = 15;
            this.TargetScr.Text = scoreObj.target;
            // 
            // bowScr1
            // 
            this.bowScr1.AutoSize = true;
            this.bowScr1.Location = new System.Drawing.Point(125, 200);
            this.bowScr1.Name = "bowScr1";
            this.bowScr1.Size = new System.Drawing.Size(0, 13);
            this.bowScr1.TabIndex = 16;
            this.bowScr1.Text = scoreObj.bowl1Scr;
            // 
            // bowScr2
            // 
            this.bowScr2.AutoSize = true;
            this.bowScr2.Location = new System.Drawing.Point(125, 227);
            this.bowScr2.Name = "bowScr2";
            this.bowScr2.Size = new System.Drawing.Size(0, 13);
            this.bowScr2.TabIndex = 17;
            this.bowScr2.Text = scoreObj.bowl2Scr;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(12, 32);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(0, 13);
            this.Summary.TabIndex = 18;
            this.Summary.Text = scoreObj.fullSummary;
            this.Summary.Refresh();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 295);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.bowScr2);
            this.Controls.Add(this.bowScr1);
            this.Controls.Add(this.TargetScr);
            this.Controls.Add(this.ReqScr);
            this.Controls.Add(this.RateScr);
            this.Controls.Add(this.overScr);
            this.Controls.Add(this.btScr2);
            this.Controls.Add(this.btScr1);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.ReqRate);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Runrate);
            this.Controls.Add(this.Overs);
            this.Controls.Add(this.Bowl2);
            this.Controls.Add(this.Bowl1);
            this.Controls.Add(this.BtsMan2);
            this.Controls.Add(this.BtsMan1);
            this.Text = scoreObj.game;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtsMan1;
        private System.Windows.Forms.Label BtsMan2;
        private System.Windows.Forms.Label Bowl1;
        private System.Windows.Forms.Label Bowl2;
        private System.Windows.Forms.Label Overs;
        private System.Windows.Forms.Label Runrate;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Label ReqRate;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label btScr1;
        private System.Windows.Forms.Label btScr2;
        private System.Windows.Forms.Label overScr;
        private System.Windows.Forms.Label RateScr;
        private System.Windows.Forms.Label ReqScr;
        private System.Windows.Forms.Label TargetScr;
        private System.Windows.Forms.Label bowScr1;
        private System.Windows.Forms.Label bowScr2;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Label Game;
    }
}

