namespace app1 {
    partial class ProdusModal {
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
            this.produsTabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.numeLabel1 = new System.Windows.Forms.Label();
            this.codInternLabel1 = new System.Windows.Forms.Label();
            this.pretLabel1 = new System.Windows.Forms.Label();
            this.producatorLabel1 = new System.Windows.Forms.Label();
            this.categorieLabel1 = new System.Windows.Forms.Label();
            this.nume1 = new System.Windows.Forms.TextBox();
            this.codIntern1 = new System.Windows.Forms.TextBox();
            this.pret1 = new System.Windows.Forms.NumericUpDown();
            this.producator1 = new System.Windows.Forms.TextBox();
            this.categorie1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.produsTabelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pret1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // produsTabelLayout
            // 
            this.produsTabelLayout.ColumnCount = 2;
            this.produsTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.05756F));
            this.produsTabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.94244F));
            this.produsTabelLayout.Controls.Add(this.numeLabel1, 0, 0);
            this.produsTabelLayout.Controls.Add(this.codInternLabel1, 0, 1);
            this.produsTabelLayout.Controls.Add(this.pretLabel1, 0, 2);
            this.produsTabelLayout.Controls.Add(this.producatorLabel1, 0, 3);
            this.produsTabelLayout.Controls.Add(this.categorieLabel1, 0, 4);
            this.produsTabelLayout.Controls.Add(this.nume1, 1, 0);
            this.produsTabelLayout.Controls.Add(this.codIntern1, 1, 1);
            this.produsTabelLayout.Controls.Add(this.pret1, 1, 2);
            this.produsTabelLayout.Controls.Add(this.producator1, 1, 3);
            this.produsTabelLayout.Controls.Add(this.categorie1, 1, 4);
            this.produsTabelLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.produsTabelLayout.Location = new System.Drawing.Point(8, 8);
            this.produsTabelLayout.Name = "produsTabelLayout";
            this.produsTabelLayout.RowCount = 5;
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.produsTabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.produsTabelLayout.Size = new System.Drawing.Size(268, 141);
            this.produsTabelLayout.TabIndex = 4;
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
            // producatorLabel1
            // 
            this.producatorLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.producatorLabel1.AutoSize = true;
            this.producatorLabel1.Location = new System.Drawing.Point(3, 91);
            this.producatorLabel1.Name = "producatorLabel1";
            this.producatorLabel1.Size = new System.Drawing.Size(64, 13);
            this.producatorLabel1.TabIndex = 4;
            this.producatorLabel1.Text = "Producător";
            // 
            // categorieLabel1
            // 
            this.categorieLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categorieLabel1.AutoSize = true;
            this.categorieLabel1.Location = new System.Drawing.Point(3, 120);
            this.categorieLabel1.Name = "categorieLabel1";
            this.categorieLabel1.Size = new System.Drawing.Size(57, 13);
            this.categorieLabel1.TabIndex = 5;
            this.categorieLabel1.Text = "Categorie";
            // 
            // nume1
            // 
            this.nume1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nume1.Location = new System.Drawing.Point(78, 3);
            this.nume1.Name = "nume1";
            this.nume1.Size = new System.Drawing.Size(187, 22);
            this.nume1.TabIndex = 7;
            // 
            // codIntern1
            // 
            this.codIntern1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codIntern1.Location = new System.Drawing.Point(78, 31);
            this.codIntern1.Name = "codIntern1";
            this.codIntern1.Size = new System.Drawing.Size(187, 22);
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
            this.pret1.Location = new System.Drawing.Point(78, 59);
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
            this.pret1.Size = new System.Drawing.Size(187, 22);
            this.pret1.TabIndex = 10;
            this.pret1.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // producator1
            // 
            this.producator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producator1.Location = new System.Drawing.Point(78, 87);
            this.producator1.Name = "producator1";
            this.producator1.Size = new System.Drawing.Size(187, 22);
            this.producator1.TabIndex = 11;
            // 
            // categorie1
            // 
            this.categorie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorie1.Location = new System.Drawing.Point(78, 115);
            this.categorie1.Name = "categorie1";
            this.categorie1.Size = new System.Drawing.Size(187, 22);
            this.categorie1.TabIndex = 12;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 36);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.cancelButton.Size = new System.Drawing.Size(87, 30);
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
            this.applyButton.Location = new System.Drawing.Point(91, 6);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(85, 30);
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
            this.okButton.Location = new System.Drawing.Point(180, 6);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ProdusModal
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.produsTabelLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdusModal";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editare produs";
            this.Load += new System.EventHandler(this.ProdusModal_Load);
            this.Click += new System.EventHandler(this.cancel_CloseModal);
            this.produsTabelLayout.ResumeLayout(false);
            this.produsTabelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pret1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel produsTabelLayout;
        private Label categorieLabel1;
        private Label numeLabel1;
        private Label codInternLabel1;
        private Label pretLabel1;
        private Label producatorLabel1;
        private NumericUpDown pret1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelButton;
        private Button applyButton;
        private Button okButton;
        private TextBox nume1;
        private TextBox codIntern1;
        private TextBox producator1;
        private TextBox categorie1;
    }
}