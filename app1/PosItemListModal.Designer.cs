using entitati;

namespace app1 {
    partial class PosItemListModal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.itemListTitleLabel = new System.Windows.Forms.Label();
            this.itemsList = new System.Windows.Forms.ListView();
            this.idColumn = new System.Windows.Forms.ColumnHeader();
            this.tipColumn = new System.Windows.Forms.ColumnHeader();
            this.numeColumn = new System.Windows.Forms.ColumnHeader();
            this.codInternColumn = new System.Windows.Forms.ColumnHeader();
            this.pretColumn = new System.Windows.Forms.ColumnHeader();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.buttonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListTitleLabel
            // 
            this.itemListTitleLabel.AutoSize = true;
            this.itemListTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemListTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemListTitleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.itemListTitleLabel.Location = new System.Drawing.Point(15, 15);
            this.itemListTitleLabel.Name = "itemListTitleLabel";
            this.itemListTitleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.itemListTitleLabel.Size = new System.Drawing.Size(131, 31);
            this.itemListTitleLabel.TabIndex = 3;
            this.itemListTitleLabel.Text = "Listă de elemente";
            // 
            // itemsList
            // 
            this.itemsList.CheckBoxes = true;
            this.itemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.tipColumn,
            this.numeColumn,
            this.codInternColumn,
            this.pretColumn});
            this.itemsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsList.FullRowSelect = true;
            this.itemsList.Location = new System.Drawing.Point(15, 46);
            this.itemsList.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(435, 174);
            this.itemsList.TabIndex = 8;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            this.itemsList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 70;
            // 
            // tipColumn
            // 
            this.tipColumn.Text = "Tip";
            this.tipColumn.Width = 80;
            // 
            // numeColumn
            // 
            this.numeColumn.Text = "Nume";
            this.numeColumn.Width = 100;
            // 
            // codInternColumn
            // 
            this.codInternColumn.Text = "Cod intern";
            this.codInternColumn.Width = 90;
            // 
            // pretColumn
            // 
            this.pretColumn.Text = "Preț";
            this.pretColumn.Width = 90;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Location = new System.Drawing.Point(150, 5);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 35);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Ștergere selectate";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Tomato;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(295, 5);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(140, 35);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Editare";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // buttonTableLayout
            // 
            this.buttonTableLayout.ColumnCount = 3;
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonTableLayout.Controls.Add(this.cancelButton, 0, 0);
            this.buttonTableLayout.Controls.Add(this.editButton, 2, 0);
            this.buttonTableLayout.Controls.Add(this.deleteButton, 1, 0);
            this.buttonTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTableLayout.Location = new System.Drawing.Point(15, 220);
            this.buttonTableLayout.Name = "buttonTableLayout";
            this.buttonTableLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonTableLayout.RowCount = 1;
            this.buttonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayout.Size = new System.Drawing.Size(435, 45);
            this.buttonTableLayout.TabIndex = 11;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.Location = new System.Drawing.Point(0, 5);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 35);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Anulare";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PosItemListModal
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(465, 280);
            this.Controls.Add(this.buttonTableLayout);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.itemListTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PosItemListModal";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare și editare elemente";
            this.Load += new System.EventHandler(this.PosItemListModal_Load);
            this.buttonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label itemListTitleLabel;
        private ListView itemsList;
        private ColumnHeader idColumn;
        private ColumnHeader tipColumn;
        private ColumnHeader numeColumn;
        private ColumnHeader codInternColumn;
        private ColumnHeader pretColumn;
        private Button deleteButton;
        private Button editButton;
        private TableLayoutPanel buttonTableLayout;
        private Button cancelButton;
    }
}