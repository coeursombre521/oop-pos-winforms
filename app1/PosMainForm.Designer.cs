namespace app1 {
    partial class PosMainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosMainForm));
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addOption = new System.Windows.Forms.RadioButton();
            this.addOptDesc = new System.Windows.Forms.Label();
            this.viewEditOption = new System.Windows.Forms.RadioButton();
            this.viewEditOptDesc = new System.Windows.Forms.Label();
            this.importOption = new System.Windows.Forms.RadioButton();
            this.importOptDesc = new System.Windows.Forms.Label();
            this.saveOption = new System.Windows.Forms.RadioButton();
            this.saveOptDesc = new System.Windows.Forms.Label();
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.xmlSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonsPanel.SuspendLayout();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 2;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Controls.Add(this.confirmButton, 1, 0);
            this.buttonsPanel.Controls.Add(this.cancelButton, 0, 0);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 506);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(17, 0, 17, 17);
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.buttonsPanel.Size = new System.Drawing.Size(384, 55);
            this.buttonsPanel.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Tomato;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(195, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(169, 32);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirmare";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.Location = new System.Drawing.Point(20, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(169, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Ieșire";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.mainTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Padding = new System.Windows.Forms.Padding(12);
            this.mainTitleLabel.Size = new System.Drawing.Size(310, 69);
            this.mainTitleLabel.TabIndex = 1;
            this.mainTitleLabel.Text = "Selectați o acțiune...";
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Controls.Add(this.addOption);
            this.mainFlowLayoutPanel.Controls.Add(this.addOptDesc);
            this.mainFlowLayoutPanel.Controls.Add(this.viewEditOption);
            this.mainFlowLayoutPanel.Controls.Add(this.viewEditOptDesc);
            this.mainFlowLayoutPanel.Controls.Add(this.importOption);
            this.mainFlowLayoutPanel.Controls.Add(this.importOptDesc);
            this.mainFlowLayoutPanel.Controls.Add(this.saveOption);
            this.mainFlowLayoutPanel.Controls.Add(this.saveOptDesc);
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(0, 69);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(17, 12, 17, 12);
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(384, 437);
            this.mainFlowLayoutPanel.TabIndex = 2;
            // 
            // addOption
            // 
            this.addOption.AutoSize = true;
            this.addOption.Checked = true;
            this.addOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOption.Location = new System.Drawing.Point(20, 15);
            this.addOption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.addOption.Name = "addOption";
            this.addOption.Size = new System.Drawing.Size(283, 24);
            this.addOption.TabIndex = 0;
            this.addOption.TabStop = true;
            this.addOption.Text = "Adăugați unul sau mai multe elemente";
            this.addOption.UseVisualStyleBackColor = true;
            // 
            // addOptDesc
            // 
            this.addOptDesc.AutoSize = true;
            this.addOptDesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addOptDesc.Location = new System.Drawing.Point(37, 51);
            this.addOptDesc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 12);
            this.addOptDesc.Name = "addOptDesc";
            this.addOptDesc.Size = new System.Drawing.Size(324, 52);
            this.addOptDesc.TabIndex = 1;
            this.addOptDesc.Text = resources.GetString("addOptDesc.Text");
            // 
            // viewEditOption
            // 
            this.viewEditOption.AutoSize = true;
            this.viewEditOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewEditOption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewEditOption.Location = new System.Drawing.Point(20, 118);
            this.viewEditOption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.viewEditOption.Name = "viewEditOption";
            this.viewEditOption.Size = new System.Drawing.Size(316, 24);
            this.viewEditOption.TabIndex = 2;
            this.viewEditOption.Text = "Vizualizați, modificați sau ștergeți elemente";
            this.viewEditOption.UseVisualStyleBackColor = true;
            // 
            // viewEditOptDesc
            // 
            this.viewEditOptDesc.AutoSize = true;
            this.viewEditOptDesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.viewEditOptDesc.Location = new System.Drawing.Point(37, 154);
            this.viewEditOptDesc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 12);
            this.viewEditOptDesc.Name = "viewEditOptDesc";
            this.viewEditOptDesc.Size = new System.Drawing.Size(321, 52);
            this.viewEditOptDesc.TabIndex = 3;
            this.viewEditOptDesc.Text = "Vizualizați elementele aflate în listă în acest moment, precum și stările acestor" +
    "a. După preferințe, modificați detaliile/conținutul acestor elemente sau ștergeț" +
    "i elementele nedorite.";
            // 
            // importOption
            // 
            this.importOption.AutoSize = true;
            this.importOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importOption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importOption.Location = new System.Drawing.Point(20, 221);
            this.importOption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.importOption.Name = "importOption";
            this.importOption.Size = new System.Drawing.Size(242, 24);
            this.importOption.TabIndex = 4;
            this.importOption.Text = "Încărcați elemente dintr-un fișier";
            this.importOption.UseVisualStyleBackColor = true;
            // 
            // importOptDesc
            // 
            this.importOptDesc.AutoSize = true;
            this.importOptDesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.importOptDesc.Location = new System.Drawing.Point(37, 257);
            this.importOptDesc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 12);
            this.importOptDesc.Name = "importOptDesc";
            this.importOptDesc.Size = new System.Drawing.Size(315, 26);
            this.importOptDesc.TabIndex = 5;
            this.importOptDesc.Text = "Specificați calea unui fișier XML pentru a încărca elementele din acesta. Lista e" +
    "xistentă va fi suprascrisă.";
            // 
            // saveOption
            // 
            this.saveOption.AutoSize = true;
            this.saveOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveOption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveOption.Location = new System.Drawing.Point(20, 298);
            this.saveOption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.saveOption.Name = "saveOption";
            this.saveOption.Size = new System.Drawing.Size(233, 24);
            this.saveOption.TabIndex = 6;
            this.saveOption.Text = "Salvați elementele într-un fișier";
            this.saveOption.UseVisualStyleBackColor = true;
            // 
            // saveOptDesc
            // 
            this.saveOptDesc.AutoSize = true;
            this.saveOptDesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.saveOptDesc.Location = new System.Drawing.Point(37, 334);
            this.saveOptDesc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 12);
            this.saveOptDesc.Name = "saveOptDesc";
            this.saveOptDesc.Size = new System.Drawing.Size(325, 39);
            this.saveOptDesc.TabIndex = 7;
            this.saveOptDesc.Text = "Specificați calea unui fișier XML pentru a salva elementele existente în acest mo" +
    "ment în acesta. Dacă fișierul specificat nu există, acesta se va crea.";
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.Filter = "Fișier XML (*.xml)|*.xml|Toate fișierele (*.*)|*.*";
            this.xmlOpenFileDialog.RestoreDirectory = true;
            this.xmlOpenFileDialog.Title = "Selectați un fișier XML ...";
            // 
            // xmlSaveFileDialog
            // 
            this.xmlSaveFileDialog.FileName = "POS.xml";
            this.xmlSaveFileDialog.Filter = "Fișier XML (*.xml)|*.xml|Toate fișierele (*.*)|*.*";
            this.xmlSaveFileDialog.RestoreDirectory = true;
            this.xmlSaveFileDialog.Title = "Salvați într-un fișier XML ...";
            // 
            // PosMainForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Controls.Add(this.mainTitleLabel);
            this.Controls.Add(this.buttonsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PosMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.buttonsPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel buttonsPanel;
        private Button confirmButton;
        private Button cancelButton;
        private Label mainTitleLabel;
        private FlowLayoutPanel mainFlowLayoutPanel;
        private RadioButton addOption;
        private Label addOptDesc;
        private RadioButton viewEditOption;
        private Label viewEditOptDesc;
        private RadioButton importOption;
        private Label importOptDesc;
        private RadioButton saveOption;
        private Label saveOptDesc;
        private OpenFileDialog xmlOpenFileDialog;
        private SaveFileDialog xmlSaveFileDialog;
    }
}