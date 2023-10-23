namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            tabPageProviderDetail = new TabPage();
            DgProvider = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            Lbl1 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProviderObservation = new TextBox();
            Lbl3 = new Label();
            TxtProviderName = new TextBox();
            Lbl2 = new Label();
            TxtProviderId = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            tabPageProviderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 119);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(19, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(163, 33);
            label1.Name = "label1";
            label1.Size = new Size(194, 50);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 314);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Location = new Point(4, 29);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(797, 281);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(Lbl1);
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderObservation);
            tabPageProviderDetail.Controls.Add(Lbl3);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(Lbl2);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Location = new Point(4, 29);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(797, 281);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(7, 67);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowHeadersWidth = 51;
            DgProvider.RowTemplate.Height = 29;
            DgProvider.Size = new Size(634, 206);
            DgProvider.TabIndex = 14;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(7, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(592, 27);
            TxtSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 12;
            label2.Text = "Search Provider";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(657, 226);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(116, 42);
            BtnClose.TabIndex = 20;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(657, 172);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 46);
            BtnDelete.TabIndex = 19;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(657, 118);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(116, 48);
            BtnEdit.TabIndex = 18;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(657, 67);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(116, 45);
            BtnNew.TabIndex = 17;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(605, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(37, 40);
            BtnSearch.TabIndex = 16;
            BtnSearch.Text = "\r\n";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(8, 5);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(81, 20);
            Lbl1.TabIndex = 24;
            Lbl1.Text = "Provider Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(123, 216);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(87, 59);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(8, 216);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(87, 59);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(8, 153);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Provider Observation";
            TxtProviderObservation.Size = new Size(278, 49);
            TxtProviderObservation.TabIndex = 21;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(7, 132);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(148, 20);
            Lbl3.TabIndex = 20;
            Lbl3.Text = "Provider Observation";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(8, 90);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider Name";
            TxtProviderName.Size = new Size(278, 27);
            TxtProviderName.TabIndex = 19;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(7, 69);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(108, 20);
            Lbl2.TabIndex = 18;
            Lbl2.Text = "Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(8, 28);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(202, 27);
            TxtProviderId.TabIndex = 17;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 433);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Name = "ProviderView";
            Text = "ProviderView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private DataGridView DgProvider;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private Label Lbl1;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProviderObservation;
        private Label Lbl3;
        private TextBox TxtProviderName;
        private Label Lbl2;
        private TextBox TxtProviderId;
    }
}