namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryView));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategory = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            Lbl1 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryDescription = new TextBox();
            Lbl3 = new Label();
            TxtCategoryName = new TextBox();
            Lbl2 = new Label();
            TxtCategoryId = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
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
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            label1.Size = new Size(213, 50);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 331);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnClose);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 29);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(792, 298);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(661, 239);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(116, 42);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(661, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 46);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(661, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(116, 48);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(661, 72);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(116, 45);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(16, 72);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 29;
            DgCategory.Size = new Size(634, 210);
            DgCategory.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(614, 24);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(37, 40);
            BtnSearch.TabIndex = 10;
            BtnSearch.Text = "\r\n";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(16, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(592, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 16);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(Lbl1);
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategoryDetail.Controls.Add(Lbl3);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(Lbl2);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(792, 298);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(16, 16);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(86, 20);
            Lbl1.TabIndex = 16;
            Lbl1.Text = "Category Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(131, 227);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(87, 59);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(16, 227);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(87, 59);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(16, 164);
            TxtCategoryDescription.Multiline = true;
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.PlaceholderText = "Category Description";
            TxtCategoryDescription.Size = new Size(278, 49);
            TxtCategoryDescription.TabIndex = 13;
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(15, 143);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(149, 20);
            Lbl3.TabIndex = 12;
            Lbl3.Text = "Category Description";
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(16, 101);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(278, 27);
            TxtCategoryName.TabIndex = 11;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(15, 80);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(113, 20);
            Lbl2.TabIndex = 10;
            Lbl2.Text = "Category Name";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(16, 39);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(202, 27);
            TxtCategoryId.TabIndex = 9;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Name = "CategoryView";
            Text = "CategoryView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private TabPage tabPageCategoryDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategory;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Label Lbl1;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoryDescription;
        private Label Lbl3;
        private TextBox TxtCategoryName;
        private Label Lbl2;
        private TextBox TxtCategoryId;
    }
}