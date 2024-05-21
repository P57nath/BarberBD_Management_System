namespace BarberBD
{
    partial class ServiceManagement
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
            this.components = new System.ComponentModel.Container();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.lblCatagoryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCatagoryID = new System.Windows.Forms.ComboBox();
            this.catagoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barBerBD_SQL_DataBase = new BarberBD.BarBerBD_SQL_DataBase();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.catagoryInfoTableAdapter = new BarberBD.BarBerBD_SQL_DataBaseTableAdapters.catagoryInfoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBerBD_SQL_DataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.dgvService.Location = new System.Drawing.Point(3, 280);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(946, 333);
            this.dgvService.TabIndex = 0;
            this.dgvService.DoubleClick += new System.EventHandler(this.dgvService_DoubleClick);
            // 
            // txtServiceID
            // 
            this.txtServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.Location = new System.Drawing.Point(516, 37);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(177, 22);
            this.txtServiceID.TabIndex = 32;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(353, 40);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(97, 19);
            this.lblServiceID.TabIndex = 31;
            this.lblServiceID.Text = "Service ID";
            this.lblServiceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(38, 234);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(177, 22);
            this.txtAutoSearch.TabIndex = 34;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // lblCatagoryName
            // 
            this.lblCatagoryName.AutoSize = true;
            this.lblCatagoryName.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryName.Location = new System.Drawing.Point(353, 79);
            this.lblCatagoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatagoryName.Name = "lblCatagoryName";
            this.lblCatagoryName.Size = new System.Drawing.Size(123, 19);
            this.lblCatagoryName.TabIndex = 33;
            this.lblCatagoryName.Text = "Service Name";
            this.lblCatagoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCatagoryName.Click += new System.EventHandler(this.lblCatagoryName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Catagory ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(516, 76);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(177, 22);
            this.txtServiceName.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(516, 116);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(177, 22);
            this.txtPrice.TabIndex = 34;
            // 
            // cmbCatagoryID
            // 
            this.cmbCatagoryID.DataSource = this.catagoryInfoBindingSource;
            this.cmbCatagoryID.DisplayMember = "CatagoryName";
            this.cmbCatagoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbCatagoryID.FormattingEnabled = true;
            this.cmbCatagoryID.Location = new System.Drawing.Point(516, 151);
            this.cmbCatagoryID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCatagoryID.Name = "cmbCatagoryID";
            this.cmbCatagoryID.Size = new System.Drawing.Size(177, 24);
            this.cmbCatagoryID.TabIndex = 41;
            this.cmbCatagoryID.ValueMember = "CatagoryID";
            // 
            // catagoryInfoBindingSource
            // 
            this.catagoryInfoBindingSource.DataMember = "catagoryInfo";
            this.catagoryInfoBindingSource.DataSource = this.barBerBD_SQL_DataBase;
            // 
            // barBerBD_SQL_DataBase
            // 
            this.barBerBD_SQL_DataBase.DataSetName = "BarBerBD_SQL_DataBase";
            this.barBerBD_SQL_DataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::BarberBD.Properties.Resources.icons8_delete_22;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(603, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 40);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::BarberBD.Properties.Resources.AddEntry;
            this.btnAdd.Location = new System.Drawing.Point(258, 220);
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
            this.btnUpdate.Location = new System.Drawing.Point(424, 220);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 40);
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
            this.btnClear.Location = new System.Drawing.Point(778, 220);
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
            // catagoryInfoTableAdapter
            // 
            this.catagoryInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::BarberBD.Properties.Resources.icons8_add_properties_22;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = " Service Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.cmbCatagoryID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCatagoryName);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.dgvService);
            this.Name = "ServiceManagement";
            this.Size = new System.Drawing.Size(952, 616);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBerBD_SQL_DataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblCatagoryName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCatagoryID;
        private System.Windows.Forms.BindingSource catagoryInfoBindingSource;
        private BarBerBD_SQL_DataBase barBerBD_SQL_DataBase;
        private BarBerBD_SQL_DataBaseTableAdapters.catagoryInfoTableAdapter catagoryInfoTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}
