namespace RevitLookup.Snoop.Forms
{
    partial class SearchBy
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
            this.m_cbSearchByVariant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbSearchValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_bnFindAndSnoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_cbSearchByVariant
            // 
            this.m_cbSearchByVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbSearchByVariant.FormattingEnabled = true;
            this.m_cbSearchByVariant.Items.AddRange(new object[] {
            "ElementId",
            "UniqId"});
            this.m_cbSearchByVariant.Location = new System.Drawing.Point(167, 16);
            this.m_cbSearchByVariant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_cbSearchByVariant.Name = "m_cbSearchByVariant";
            this.m_cbSearchByVariant.Size = new System.Drawing.Size(266, 25);
            this.m_cbSearchByVariant.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by:";
            // 
            // m_tbSearchValue
            // 
            this.m_tbSearchValue.Location = new System.Drawing.Point(167, 51);
            this.m_tbSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_tbSearchValue.Name = "m_tbSearchValue";
            this.m_tbSearchValue.Size = new System.Drawing.Size(266, 23);
            this.m_tbSearchValue.TabIndex = 2;
            this.m_tbSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_tbSearchValue_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value to search for:";
            // 
            // m_bnFindAndSnoop
            // 
            this.m_bnFindAndSnoop.Location = new System.Drawing.Point(167, 98);
            this.m_bnFindAndSnoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_bnFindAndSnoop.Name = "m_bnFindAndSnoop";
            this.m_bnFindAndSnoop.Size = new System.Drawing.Size(117, 30);
            this.m_bnFindAndSnoop.TabIndex = 4;
            this.m_bnFindAndSnoop.Text = "Find and snoop";
            this.m_bnFindAndSnoop.UseVisualStyleBackColor = true;
            this.m_bnFindAndSnoop.Click += new System.EventHandler(this.m_bnFindAndSnoop_Click);
            // 
            // SearchBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 144);
            this.Controls.Add(this.m_bnFindAndSnoop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_tbSearchValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_cbSearchByVariant);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SearchBy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBy";
            this.Load += new System.EventHandler(this.SearchBy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBy_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbSearchByVariant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_bnFindAndSnoop;
    }
}