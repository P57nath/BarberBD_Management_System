namespace BarberBD
{
    partial class NewAddCatagory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCatagory = new System.Windows.Forms.DataGridView();
            this.txtCatagoryID = new System.Windows.Forms.TextBox();
            this.lblCatagoryID = new System.Windows.Forms.Label();
            this.txtCatagoryName = new System.Windows.Forms.TextBox();
            this.lblCatagoryName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatagory
            // 
            this.dgvCatagory.AllowUserToAddRows = false;
            this.dgvCatagory.AllowUserToDeleteRows = false;
            this.dgvCatagory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.dgvCatagory.Location = new System.Drawing.Point(0, 277);
            this.dgvCatagory.Name = "dgvCatagory";
            this.dgvCatagory.ReadOnly = true;
            this.dgvCatagory.RowHeadersWidth = 51;
            this.dgvCatagory.RowTemplate.Height = 24;
            this.dgvCatagory.Size = new System.Drawing.Size(932, 319);
            this.dgvCatagory.TabIndex = 0;
            this.dgvCatagory.DoubleClick += new System.EventHandler(this.dgvCatagory_DoubleClick);
            // 
            // txtCatagoryID
            // 
            this.txtCatagoryID.Location = new System.Drawing.Point(490, 86);
            this.txtCatagoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatagoryID.Name = "txtCatagoryID";
            this.txtCatagoryID.ReadOnly = true;
            this.txtCatagoryID.Size = new System.Drawing.Size(177, 22);
            this.txtCatagoryID.TabIndex = 32;
            // 
            // lblCatagoryID
            // 
            this.lblCatagoryID.AutoSize = true;
            this.lblCatagoryID.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryID.Location = new System.Drawing.Point(322, 86);
            this.lblCatagoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatagoryID.Name = "lblCatagoryID";
            this.lblCatagoryID.Size = new System.Drawing.Size(104, 20);
            this.lblCatagoryID.TabIndex = 31;
            this.lblCatagoryID.Text = "Catagory ID";
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.Location = new System.Drawing.Point(490, 144);
            this.txtCatagoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.Size = new System.Drawing.Size(177, 22);
            this.txtCatagoryName.TabIndex = 34;
            // 
            // lblCatagoryName
            // 
            this.lblCatagoryName.AutoSize = true;
            this.lblCatagoryName.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryName.Location = new System.Drawing.Point(322, 144);
            this.lblCatagoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatagoryName.Name = "lblCatagoryName";
            this.lblCatagoryName.Size = new System.Drawing.Size(129, 20);
            this.lblCatagoryName.TabIndex = 33;
            this.lblCatagoryName.Text = "Catagory Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::BarberBD.Properties.Resources.icons8_add_22__2_;
            this.btnAdd.Location = new System.Drawing.Point(86, 216);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 40);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::BarberBD.Properties.Resources.icons8_update_22__1_;
            this.btnUpdate.Location = new System.Drawing.Point(299, 216);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 40);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::BarberBD.Properties.Resources.icons8_minus_221;
            this.btnClear.Location = new System.Drawing.Point(732, 216);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 40);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::BarberBD.Properties.Resources.icons8_category_22;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Catagory Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::BarberBD.Properties.Resources.icons8_delete_22;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(519, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 40);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(710, 141);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // NewAddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCatagoryName);
            this.Controls.Add(this.lblCatagoryName);
            this.Controls.Add(this.txtCatagoryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCatagoryID);
            this.Controls.Add(this.dgvCatagory);
            this.Name = "NewAddCatagory";
            this.Size = new System.Drawing.Size(932, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCatagory;
        private System.Windows.Forms.TextBox txtCatagoryID;
        private System.Windows.Forms.Label lblCatagoryID;
        private System.Windows.Forms.TextBox txtCatagoryName;
        private System.Windows.Forms.Label lblCatagoryName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}
