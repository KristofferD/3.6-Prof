using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TimeTracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private readonly System.Windows.Forms.Timer researchTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer teachingTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer lunchTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer diodeTimer = new System.Windows.Forms.Timer();
        private DateTime currentTime = DateTime.Now;

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
            this.researchButton = new System.Windows.Forms.Button();
            this.teachingButton = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.researchTimer = new System.Windows.Forms.Timer(this.components);
            this.teachingTimer = new System.Windows.Forms.Timer(this.components);
            this.lunchTimer = new System.Windows.Forms.Timer(this.components);
            this.researchLabel = new System.Windows.Forms.Label();
            this.teachingLabel = new System.Windows.Forms.Label();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.diodeTimer = new System.Windows.Forms.Timer(this.components);
            this.diodeLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // researchButton
            this.researchButton.Location = new System.Drawing.Point(98, 122);
            this.researchButton.Name = "researchButton";
            this.researchButton.Size = new System.Drawing.Size(75, 23);
            this.researchButton.TabIndex = 0;
            this.researchButton.Text = "Research";
            this.researchButton.UseVisualStyleBackColor = true;
            this.researchButton.Click += new System.EventHandler(this.researchButton_Click);

            // teachingButton
            this.teachingButton.Location = new System.Drawing.Point(98, 162);
            this.teachingButton.Name = "teachingButton";
            this.teachingButton.Size = new System.Drawing.Size(75, 23);
            this.teachingButton.TabIndex = 1;
            this.teachingButton.Text = "Teaching";
            this.teachingButton.UseVisualStyleBackColor = true;
            this.teachingButton.Click += new System.EventHandler(this.teachingButton_Click);

            // lunchButton
            this.lunchButton.Location = new System.Drawing.Point(98, 201);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(75, 23);
            this.lunchButton.TabIndex = 2;
            this.lunchButton.Text = "Lunch";
            this.lunchButton.UseVisualStyleBackColor = true;
            this.lunchButton.Click += new System.EventHandler(this.lunchButton_Click);

            // researchTimer
            this.researchTimer.Interval = 1000;
            this.researchTimer.Tick += new System.EventHandler(this.researchTimer_Tick);

            // teachingTimer
            this.teachingTimer.Interval = 1000;
            this.teachingTimer.Tick += new System.EventHandler(this.teachingTimer_Tick);

            // lunchTimer
            this.lunchTimer.Interval = 1000;
            this.lunchTimer.Tick += new System.EventHandler(this.lunchTimer_Tick);

            // researchLabel
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(42, 48);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(89, 15);
            this.researchLabel.TabIndex = 1;
            this.researchLabel.Text = "Researching: Off";

            // teachingLabel
            // 
            this.teachingLabel.AutoSize = true;
            this.teachingLabel.Location = new System.Drawing.Point(42, 106);
            this.teachingLabel.Name = "teachingLabel";
            this.teachingLabel.Size = new System.Drawing.Size(80, 15);
            this.teachingLabel.TabIndex = 2;
            this.teachingLabel.Text = "Teaching: Off";

            // lunchLabel
            // 
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.Location = new System.Drawing.Point(42, 164);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(60, 15);
            this.lunchLabel.TabIndex = 3;
            this.lunchLabel.Text = "Lunch: Off";

            // diodeLabel
            // 
            this.diodeLabel.AutoSize = true;
            this.diodeLabel.Location = new System.Drawing.Point(505, 48);
            this.diodeLabel.Name = "diodeLabel";
            this.diodeLabel.Size = new System.Drawing.Size(112, 15);
            this.diodeLabel.TabIndex = 4;
            this.diodeLabel.Text = "Diode: Off (00:00:00)";

            // clockLabel
            //
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(94, 36);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(101, 31);
            this.clockLabel.TabIndex = 5;
            this.clockLabel.Text = "00:00:00";

            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.diodeLabel);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.teachingLabel);
            this.Controls.Add(this.researchLabel);
            this.Controls.Add(this.lunchButton);
            this.Controls.Add(this.teachingButton);
            this.Controls.Add(this.researchButton);
            this.Name = "MainForm";
            this.Text = "TimeTracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button researchButton;
        private System.Windows.Forms.Button teachingButton;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Timer researchTimer;
        private System.Windows.Forms.Timer teachingTimer;
        private System.Windows.Forms.Timer lunchTimer;
        private System.Windows.Forms.Label researchLabel;
        private System.Windows.Forms.Label teachingLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Timer diodeTimer;
        private System.Windows.Forms.Label diodeLabel;
        private System.Windows.Forms.Label clockLabel;
    }

}
