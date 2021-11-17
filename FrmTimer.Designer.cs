namespace TimerUebungApp
{
    partial class FrmTimer
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
            this.components = new System.ComponentModel.Container();
            this.lblTimerAnzeige = new System.Windows.Forms.Label();
            this.btnTimerStartStopContinue = new System.Windows.Forms.Button();
            this.cmpTimer = new System.Windows.Forms.Timer(this.components);
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutues = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.numMinutues = new System.Windows.Forms.NumericUpDown();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutues)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimerAnzeige
            // 
            this.lblTimerAnzeige.AutoSize = true;
            this.lblTimerAnzeige.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimerAnzeige.Location = new System.Drawing.Point(172, 84);
            this.lblTimerAnzeige.Name = "lblTimerAnzeige";
            this.lblTimerAnzeige.Size = new System.Drawing.Size(399, 67);
            this.lblTimerAnzeige.TabIndex = 0;
            this.lblTimerAnzeige.Text = "00d:00h:00m:00s";
            this.lblTimerAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimerStartStopContinue
            // 
            this.btnTimerStartStopContinue.Location = new System.Drawing.Point(16, 79);
            this.btnTimerStartStopContinue.Name = "btnTimerStartStopContinue";
            this.btnTimerStartStopContinue.Size = new System.Drawing.Size(94, 29);
            this.btnTimerStartStopContinue.TabIndex = 1;
            this.btnTimerStartStopContinue.Text = "Start";
            this.btnTimerStartStopContinue.UseVisualStyleBackColor = true;
            this.btnTimerStartStopContinue.Click += new System.EventHandler(this.btnTimerStartStop_Click);
            // 
            // cmpTimer
            // 
            this.cmpTimer.Tick += new System.EventHandler(this.CmpTimer_Tick);
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(16, 34);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(50, 27);
            this.numHour.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(16, 11);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 20);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "h.";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutues
            // 
            this.lblMinutues.Location = new System.Drawing.Point(72, 11);
            this.lblMinutues.Name = "lblMinutues";
            this.lblMinutues.Size = new System.Drawing.Size(50, 20);
            this.lblMinutues.TabIndex = 5;
            this.lblMinutues.Text = "min.";
            this.lblMinutues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Location = new System.Drawing.Point(128, 11);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(50, 20);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "s.";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(128, 34);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(50, 27);
            this.numSeconds.TabIndex = 6;
            this.numSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numMinutues
            // 
            this.numMinutues.Location = new System.Drawing.Point(72, 34);
            this.numMinutues.Name = "numMinutues";
            this.numMinutues.Size = new System.Drawing.Size(50, 27);
            this.numMinutues.TabIndex = 4;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnReset);
            this.pnlControls.Controls.Add(this.lblHours);
            this.pnlControls.Controls.Add(this.lblSeconds);
            this.pnlControls.Controls.Add(this.btnTimerStartStopContinue);
            this.pnlControls.Controls.Add(this.numHour);
            this.pnlControls.Controls.Add(this.numMinutues);
            this.pnlControls.Controls.Add(this.lblMinutues);
            this.pnlControls.Controls.Add(this.numSeconds);
            this.pnlControls.Location = new System.Drawing.Point(212, 196);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(273, 133);
            this.pnlControls.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(128, 79);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblTimerAnzeige);
            this.Name = "FrmTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.FrmTimer_load);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutues)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimerAnzeige;
        private System.Windows.Forms.Button btnTimerStartStopContinue;
        private System.Windows.Forms.Timer cmpTimer;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutues;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.NumericUpDown numMinutues;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnReset;
    }
}
