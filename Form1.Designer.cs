namespace trogdorthebudginator
{
    partial class Form1
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
            itemsgrdview = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lstbxcategories = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lblexptcst = new Label();
            label4 = new Label();
            lblactualcost = new Label();
            ((System.ComponentModel.ISupportInitialize)itemsgrdview).BeginInit();
            SuspendLayout();
            // 
            // itemsgrdview
            // 
            itemsgrdview.AllowUserToAddRows = false;
            itemsgrdview.AllowUserToDeleteRows = false;
            itemsgrdview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsgrdview.Columns.AddRange(new DataGridViewColumn[] { Item, Cost });
            itemsgrdview.Location = new Point(12, 443);
            itemsgrdview.Name = "itemsgrdview";
            itemsgrdview.ReadOnly = true;
            itemsgrdview.RowHeadersWidth = 62;
            itemsgrdview.RowTemplate.Height = 33;
            itemsgrdview.Size = new Size(638, 405);
            itemsgrdview.TabIndex = 0;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 8;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 150;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 8;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 405);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 1;
            label1.Text = "Items:";
            // 
            // lstbxcategories
            // 
            lstbxcategories.FormattingEnabled = true;
            lstbxcategories.ItemHeight = 25;
            lstbxcategories.Location = new Point(12, 102);
            lstbxcategories.Name = "lstbxcategories";
            lstbxcategories.Size = new Size(360, 229);
            lstbxcategories.TabIndex = 2;
            lstbxcategories.SelectedIndexChanged += lstbxcategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 3;
            label2.Text = "BudgetItems:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 102);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 4;
            label3.Text = "Category Expected Cost:";
            // 
            // lblexptcst
            // 
            lblexptcst.AutoSize = true;
            lblexptcst.Location = new Point(495, 139);
            lblexptcst.Name = "lblexptcst";
            lblexptcst.Size = new Size(103, 25);
            lblexptcst.TabIndex = 5;
            lblexptcst.Text = "$$$expcost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(753, 102);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 6;
            label4.Text = "Category Actual Cost:";
            // 
            // lblactualcost
            // 
            lblactualcost.AutoSize = true;
            lblactualcost.Location = new Point(753, 139);
            lblactualcost.Name = "lblactualcost";
            lblactualcost.Size = new Size(121, 25);
            lblactualcost.TabIndex = 7;
            lblactualcost.Text = "$$$actualcost";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 933);
            Controls.Add(lblactualcost);
            Controls.Add(label4);
            Controls.Add(lblexptcst);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstbxcategories);
            Controls.Add(label1);
            Controls.Add(itemsgrdview);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)itemsgrdview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView itemsgrdview;
        private Label label1;
        private ListBox lstbxcategories;
        private Label label2;
        private Label label3;
        private Label lblexptcst;
        private Label label4;
        private Label lblactualcost;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Cost;
    }
}