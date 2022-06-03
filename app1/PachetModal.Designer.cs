namespace app1 {
    partial class PachetModal {
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
            this.psList = new System.Windows.Forms.ListView();
            this.idPsColumn = new System.Windows.Forms.ColumnHeader();
            this.typePsColumn = new System.Windows.Forms.ColumnHeader();
            this.numePsColumn = new System.Windows.Forms.ColumnHeader();
            this.psLabel = new System.Windows.Forms.Label();
            this.pachetTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nume1 = new System.Windows.Forms.TextBox();
            this.codIntern1 = new System.Windows.Forms.TextBox();
            this.pret1 = new System.Windows.Forms.NumericUpDown();
            this.maxProduse1 = new System.Windows.Forms.NumericUpDown();
            this.maxServicii1 = new System.Windows.Forms.NumericUpDown();
            this.numeLabel1 = new System.Windows.Forms.Label();
            this.codInternLabel1 = new System.Windows.Forms.Label();
            this.pretLabel1 = new System.Windows.Forms.Label();
            this.maxProduseLabel1 = new System.Windows.Forms.Label();
            this.maxServiciiLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.pachetTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pret1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProduse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxServicii1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // psList
            // 
            this.psList.CheckBoxes = true;
            this.psList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPsColumn,
            this.typePsColumn,
            this.numePsColumn});
            this.psList.Dock = System.Windows.Forms.DockStyle.Top;
            this.psList.Location = new System.Drawing.Point(8, 177);
            this.psList.Name = "psList";
            this.psList.Size = new System.Drawing.Size(288, 100);
            this.psList.TabIndex = 13;
            this.psList.UseCompatibleStateImageBehavior = false;
            this.psList.View = System.Windows.Forms.View.Details;
            this.psList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.psList_ItemChecked);
            // 
            // idPsColumn
            // 
            this.idPsColumn.Text = "ID";
            // 
            // typePsColumn
            // 
            this.typePsColumn.Text = "Tip";
            // 
            // numePsColumn
            // 
            this.numePsColumn.Text = "Nume";
            this.numePsColumn.Width = 120;
            // 
            // psLabel
            // 
            this.psLabel.AutoSize = true;
            this.psLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.psLabel.ForeColor = System.Drawing.Color.Black;
            this.psLabel.Location = new System.Drawing.Point(8, 148);
            this.psLabel.Margin = new System.Windows.Forms.Padding(0);
            this.psLabel.Name = "psLabel";
            this.psLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.psLabel.Size = new System.Drawing.Size(140, 29);
            this.psLabel.TabIndex = 12;
            this.psLabel.Text = "Listă de produse și servicii";
            // 
            // pachetTableLayout
            // 
            this.pachetTableLayout.ColumnCount = 2;
            this.pachetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4682F));
            this.pachetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.5318F));
            this.pachetTableLayout.Controls.Add(this.nume1, 1, 0);
            this.pachetTableLayout.Controls.Add(this.codIntern1, 1, 1);
            this.pachetTableLayout.Controls.Add(this.pret1, 1, 2);
            this.pachetTableLayout.Controls.Add(this.maxProduse1, 1, 3);
            this.pachetTableLayout.Controls.Add(this.maxServicii1, 1, 4);
            this.pachetTableLayout.Controls.Add(this.numeLabel1, 0, 0);
            this.pachetTableLayout.Controls.Add(this.codInternLabel1, 0, 1);
            this.pachetTableLayout.Controls.Add(this.pretLabel1, 0, 2);
            this.pachetTableLayout.Controls.Add(this.maxProduseLabel1, 0, 3);
            this.pachetTableLayout.Controls.Add(this.maxServiciiLabel1, 0, 4);
            this.pachetTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pachetTableLayout.Location = new System.Drawing.Point(8, 8);
            this.pachetTableLayout.Name = "pachetTableLayout";
            this.pachetTableLayout.RowCount = 5;
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pachetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pachetTableLayout.Size = new System.Drawing.Size(288, 140);
            this.pachetTableLayout.TabIndex = 11;
            // 
            // nume1
            // 
            this.nume1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nume1.Location = new System.Drawing.Point(87, 3);
            this.nume1.Name = "nume1";
            this.nume1.Size = new System.Drawing.Size(198, 22);
            this.nume1.TabIndex = 7;
            // 
            // codIntern1
            // 
            this.codIntern1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codIntern1.Location = new System.Drawing.Point(87, 31);
            this.codIntern1.Name = "codIntern1";
            this.codIntern1.Size = new System.Drawing.Size(198, 22);
            this.codIntern1.TabIndex = 8;
            // 
            // pret1
            // 
            this.pret1.DecimalPlaces = 2;
            this.pret1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pret1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pret1.Location = new System.Drawing.Point(87, 59);
            this.pret1.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.pret1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pret1.Name = "pret1";
            this.pret1.Size = new System.Drawing.Size(198, 22);
            this.pret1.TabIndex = 10;
            this.pret1.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // maxProduse1
            // 
            this.maxProduse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxProduse1.Location = new System.Drawing.Point(87, 87);
            this.maxProduse1.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.maxProduse1.Name = "maxProduse1";
            this.maxProduse1.Size = new System.Drawing.Size(198, 22);
            this.maxProduse1.TabIndex = 11;
            // 
            // maxServicii1
            // 
            this.maxServicii1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxServicii1.Location = new System.Drawing.Point(87, 115);
            this.maxServicii1.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.maxServicii1.Name = "maxServicii1";
            this.maxServicii1.Size = new System.Drawing.Size(198, 22);
            this.maxServicii1.TabIndex = 12;
            // 
            // numeLabel1
            // 
            this.numeLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numeLabel1.AutoSize = true;
            this.numeLabel1.Location = new System.Drawing.Point(3, 7);
            this.numeLabel1.Name = "numeLabel1";
            this.numeLabel1.Size = new System.Drawing.Size(37, 13);
            this.numeLabel1.TabIndex = 1;
            this.numeLabel1.Text = "Nume";
            // 
            // codInternLabel1
            // 
            this.codInternLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codInternLabel1.AutoSize = true;
            this.codInternLabel1.Location = new System.Drawing.Point(3, 35);
            this.codInternLabel1.Name = "codInternLabel1";
            this.codInternLabel1.Size = new System.Drawing.Size(62, 13);
            this.codInternLabel1.TabIndex = 2;
            this.codInternLabel1.Text = "Cod intern";
            // 
            // pretLabel1
            // 
            this.pretLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pretLabel1.AutoSize = true;
            this.pretLabel1.Location = new System.Drawing.Point(3, 63);
            this.pretLabel1.Name = "pretLabel1";
            this.pretLabel1.Size = new System.Drawing.Size(27, 13);
            this.pretLabel1.TabIndex = 3;
            this.pretLabel1.Text = "Preț";
            // 
            // maxProduseLabel1
            // 
            this.maxProduseLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxProduseLabel1.AutoSize = true;
            this.maxProduseLabel1.Location = new System.Drawing.Point(3, 91);
            this.maxProduseLabel1.Name = "maxProduseLabel1";
            this.maxProduseLabel1.Size = new System.Drawing.Size(77, 13);
            this.maxProduseLabel1.TabIndex = 4;
            this.maxProduseLabel1.Text = "Max. produse";
            // 
            // maxServiciiLabel1
            // 
            this.maxServiciiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxServiciiLabel1.AutoSize = true;
            this.maxServiciiLabel1.Location = new System.Drawing.Point(3, 119);
            this.maxServiciiLabel1.Name = "maxServiciiLabel1";
            this.maxServiciiLabel1.Size = new System.Drawing.Size(68, 13);
            this.maxServiciiLabel1.TabIndex = 5;
            this.maxServiciiLabel1.Text = "Max. servicii";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 277);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 36);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.Location = new System.Drawing.Point(0, 6);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 30);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Anulare";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_CloseModal);
            // 
            // applyButton
            // 
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.applyButton.Location = new System.Drawing.Point(97, 6);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(92, 30);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Aplicare";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Tomato;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(193, 6);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PachetModal
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 323);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.psList);
            this.Controls.Add(this.psLabel);
            this.Controls.Add(this.pachetTableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PachetModal";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editare pachet";
            this.Load += new System.EventHandler(this.PachetModal_Load);
            this.pachetTableLayout.ResumeLayout(false);
            this.pachetTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pret1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProduse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxServicii1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView psList;
        private ColumnHeader idPsColumn;
        private ColumnHeader typePsColumn;
        private ColumnHeader numePsColumn;
        private Label psLabel;
        private TableLayoutPanel pachetTableLayout;
        private TextBox codIntern1;
        private Label numeLabel1;
        private Label codInternLabel1;
        private Label pretLabel1;
        private Label maxProduseLabel1;
        private TextBox nume1;
        private NumericUpDown pret1;
        private NumericUpDown maxProduse1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelButton;
        private Button applyButton;
        private Button okButton;
        private NumericUpDown maxServicii1;
        private Label maxServiciiLabel1;
    }
}