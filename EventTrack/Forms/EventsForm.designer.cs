namespace RevitLookup.EventTrack.Forms
{
    partial class EventsForm {
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
            if (disposing && (components != null)) {
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
            this.m_grpAppEvents = new System.Windows.Forms.GroupBox();
            this.m_cbAppEventsOn = new System.Windows.Forms.CheckBox();
            this.m_bnOk = new System.Windows.Forms.Button();
            this.m_tabCtrl = new System.Windows.Forms.TabControl();
            this.m_tabPageSys = new System.Windows.Forms.TabPage();
            this.m_grpDocEvents = new System.Windows.Forms.GroupBox();
            this.m_cbDocEventsOn = new System.Windows.Forms.CheckBox();
            this.m_bnCancel = new System.Windows.Forms.Button();
            this.m_grpAppEvents.SuspendLayout();
            this.m_tabCtrl.SuspendLayout();
            this.m_tabPageSys.SuspendLayout();
            this.m_grpDocEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grpAppEvents
            // 
            this.m_grpAppEvents.Controls.Add(this.m_cbAppEventsOn);
            this.m_grpAppEvents.Location = new System.Drawing.Point(7, 8);
            this.m_grpAppEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_grpAppEvents.Name = "m_grpAppEvents";
            this.m_grpAppEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_grpAppEvents.Size = new System.Drawing.Size(153, 62);
            this.m_grpAppEvents.TabIndex = 0;
            this.m_grpAppEvents.TabStop = false;
            this.m_grpAppEvents.Text = "Application Events";
            // 
            // m_cbAppEventsOn
            // 
            this.m_cbAppEventsOn.AutoSize = true;
            this.m_cbAppEventsOn.Location = new System.Drawing.Point(19, 26);
            this.m_cbAppEventsOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_cbAppEventsOn.Name = "m_cbAppEventsOn";
            this.m_cbAppEventsOn.Size = new System.Drawing.Size(44, 21);
            this.m_cbAppEventsOn.TabIndex = 1;
            this.m_cbAppEventsOn.Text = "On";
            this.m_cbAppEventsOn.UseVisualStyleBackColor = true;
            // 
            // m_bnOk
            // 
            this.m_bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_bnOk.Location = new System.Drawing.Point(134, 269);
            this.m_bnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_bnOk.Name = "m_bnOk";
            this.m_bnOk.Size = new System.Drawing.Size(87, 30);
            this.m_bnOk.TabIndex = 5;
            this.m_bnOk.Text = "OK";
            this.m_bnOk.UseVisualStyleBackColor = true;
            this.m_bnOk.Click += new System.EventHandler(this.event_OnBnOkClick);
            // 
            // m_tabCtrl
            // 
            this.m_tabCtrl.Controls.Add(this.m_tabPageSys);
            this.m_tabCtrl.Location = new System.Drawing.Point(14, 16);
            this.m_tabCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tabCtrl.Name = "m_tabCtrl";
            this.m_tabCtrl.SelectedIndex = 0;
            this.m_tabCtrl.Size = new System.Drawing.Size(426, 246);
            this.m_tabCtrl.TabIndex = 6;
            // 
            // m_tabPageSys
            // 
            this.m_tabPageSys.Controls.Add(this.m_grpDocEvents);
            this.m_tabPageSys.Controls.Add(this.m_grpAppEvents);
            this.m_tabPageSys.Location = new System.Drawing.Point(4, 26);
            this.m_tabPageSys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tabPageSys.Name = "m_tabPageSys";
            this.m_tabPageSys.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tabPageSys.Size = new System.Drawing.Size(418, 216);
            this.m_tabPageSys.TabIndex = 0;
            this.m_tabPageSys.Text = "System";
            this.m_tabPageSys.UseVisualStyleBackColor = true;
            // 
            // m_grpDocEvents
            // 
            this.m_grpDocEvents.Controls.Add(this.m_cbDocEventsOn);
            this.m_grpDocEvents.Location = new System.Drawing.Point(7, 113);
            this.m_grpDocEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_grpDocEvents.Name = "m_grpDocEvents";
            this.m_grpDocEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_grpDocEvents.Size = new System.Drawing.Size(153, 62);
            this.m_grpDocEvents.TabIndex = 1;
            this.m_grpDocEvents.TabStop = false;
            this.m_grpDocEvents.Text = "Document Events";
            // 
            // m_cbDocEventsOn
            // 
            this.m_cbDocEventsOn.AutoSize = true;
            this.m_cbDocEventsOn.Location = new System.Drawing.Point(19, 26);
            this.m_cbDocEventsOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_cbDocEventsOn.Name = "m_cbDocEventsOn";
            this.m_cbDocEventsOn.Size = new System.Drawing.Size(44, 21);
            this.m_cbDocEventsOn.TabIndex = 1;
            this.m_cbDocEventsOn.Text = "On";
            this.m_cbDocEventsOn.UseVisualStyleBackColor = true;
            // 
            // m_bnCancel
            // 
            this.m_bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_bnCancel.Location = new System.Drawing.Point(231, 269);
            this.m_bnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_bnCancel.Name = "m_bnCancel";
            this.m_bnCancel.Size = new System.Drawing.Size(87, 30);
            this.m_bnCancel.TabIndex = 7;
            this.m_bnCancel.Text = "Cancel";
            this.m_bnCancel.UseVisualStyleBackColor = true;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_bnCancel;
            this.ClientSize = new System.Drawing.Size(454, 314);
            this.Controls.Add(this.m_bnCancel);
            this.Controls.Add(this.m_tabCtrl);
            this.Controls.Add(this.m_bnOk);
            this.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.m_grpAppEvents.ResumeLayout(false);
            this.m_grpAppEvents.PerformLayout();
            this.m_tabCtrl.ResumeLayout(false);
            this.m_tabPageSys.ResumeLayout(false);
            this.m_grpDocEvents.ResumeLayout(false);
            this.m_grpDocEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox m_grpAppEvents;
        private System.Windows.Forms.CheckBox m_cbAppEventsOn;
        private System.Windows.Forms.Button m_bnOk;
        private System.Windows.Forms.TabControl m_tabCtrl;
        private System.Windows.Forms.TabPage m_tabPageSys;
        private System.Windows.Forms.Button m_bnCancel;
        private System.Windows.Forms.GroupBox m_grpDocEvents;
        private System.Windows.Forms.CheckBox m_cbDocEventsOn;
    }
}