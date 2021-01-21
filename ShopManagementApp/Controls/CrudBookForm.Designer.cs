
namespace ShopManagementApp.Controls
{
    partial class CrudBookForm
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
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.dgw_Books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_CurrentId = new System.Windows.Forms.TextBox();
            this.txb_PriceUpdate = new System.Windows.Forms.TextBox();
            this.txb_NameUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Id
            // 
            this.txb_Id.Location = new System.Drawing.Point(109, 209);
            this.txb_Id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(139, 20);
            this.txb_Id.TabIndex = 0;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(109, 252);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(139, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(109, 294);
            this.txb_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(139, 20);
            this.txb_Price.TabIndex = 2;
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(23, 348);
            this.btn_GetAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(69, 24);
            this.btn_GetAll.TabIndex = 5;
            this.btn_GetAll.Text = "GetAll";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(209, 348);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(69, 24);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(367, 348);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(69, 24);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(282, 7);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 24);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Location = new System.Drawing.Point(115, 348);
            this.btn_GetById.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(69, 24);
            this.btn_GetById.TabIndex = 9;
            this.btn_GetById.Text = "GetById";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(21, 209);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 10;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(21, 252);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(21, 294);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 12;
            this.lbl_Price.Text = "Price";
            // 
            // dgw_Books
            // 
            this.dgw_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Books.Location = new System.Drawing.Point(282, 35);
            this.dgw_Books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_Books.Name = "dgw_Books";
            this.dgw_Books.RowHeadersWidth = 62;
            this.dgw_Books.RowTemplate.Height = 28;
            this.dgw_Books.Size = new System.Drawing.Size(393, 157);
            this.dgw_Books.TabIndex = 14;
            this.dgw_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Books_CellClick);
            this.dgw_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Books_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id";
            // 
            // txb_CurrentId
            // 
            this.txb_CurrentId.Location = new System.Drawing.Point(469, 214);
            this.txb_CurrentId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_CurrentId.Name = "txb_CurrentId";
            this.txb_CurrentId.Size = new System.Drawing.Size(139, 20);
            this.txb_CurrentId.TabIndex = 17;
            // 
            // txb_PriceUpdate
            // 
            this.txb_PriceUpdate.Location = new System.Drawing.Point(469, 295);
            this.txb_PriceUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_PriceUpdate.Name = "txb_PriceUpdate";
            this.txb_PriceUpdate.Size = new System.Drawing.Size(139, 20);
            this.txb_PriceUpdate.TabIndex = 16;
            // 
            // txb_NameUpdate
            // 
            this.txb_NameUpdate.Location = new System.Drawing.Point(469, 257);
            this.txb_NameUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_NameUpdate.Name = "txb_NameUpdate";
            this.txb_NameUpdate.Size = new System.Drawing.Size(139, 20);
            this.txb_NameUpdate.TabIndex = 15;
            // 
            // CrudBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 818);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_CurrentId);
            this.Controls.Add(this.txb_PriceUpdate);
            this.Controls.Add(this.txb_NameUpdate);
            this.Controls.Add(this.dgw_Books);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_Id);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrudBookForm";
            this.Text = "CrudBookForm";
            this.Load += new System.EventHandler(this.CrudBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.DataGridView dgw_Books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_CurrentId;
        private System.Windows.Forms.TextBox txb_PriceUpdate;
        private System.Windows.Forms.TextBox txb_NameUpdate;
    }
}