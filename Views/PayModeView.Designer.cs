namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            textBox3 = new TextBox();
            TxtPayModeObservation = new Label();
            textBox2 = new TextBox();
            TxtPayModeName = new Label();
            textBox1 = new TextBox();
            TxtPayModeId = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
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
            panel2.Size = new Size(800, 119);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy1;
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
            label1.Location = new Point(171, 43);
            label1.Name = "label1";
            label1.Size = new Size(202, 50);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 331);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 298);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List ";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(656, 235);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(116, 42);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(656, 179);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 46);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(656, 122);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(116, 48);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(656, 68);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(116, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(11, 68);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(634, 210);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(609, 20);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(37, 40);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "\r\n";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(11, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(592, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(textBox3);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(textBox2);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(textBox1);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 298);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(131, 221);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(87, 59);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "button2";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(16, 221);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(87, 59);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "button1";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 158);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Pay Mode Observation";
            textBox3.Size = new Size(278, 49);
            textBox3.TabIndex = 5;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.AutoSize = true;
            TxtPayModeObservation.Location = new Point(15, 137);
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(158, 20);
            TxtPayModeObservation.TabIndex = 4;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 95);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Pay Mode Name";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.AutoSize = true;
            TxtPayModeName.Location = new Point(15, 74);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(118, 20);
            TxtPayModeName.TabIndex = 2;
            TxtPayModeName.Text = "Pay Mode Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 1;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(11, 9);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(91, 27);
            TxtPayModeId.TabIndex = 0;
            TxtPayModeId.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private DataGridView DgPayMode;
        private Button button4;
        private Button button3;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView dataGridView1;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPagePayModeDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeId;
        private Panel panel2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label TxtPayModeName;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label TxtPayModeObservation;
        private Button button2;
        private Button button1;
    }
}