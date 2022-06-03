using System.IO;

namespace app1 {
    public partial class PosMainForm : Form {
        public PosMainForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
            Dispose();
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            if (addOption.Checked) {
                PosAddModal modal1 = new();
                modal1.ShowDialog();
            }

            if (viewEditOption.Checked) {
                PosItemListModal modal2 = new();
                modal2.ShowDialog();
            }

            if (importOption.Checked) {
                if (xmlOpenFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        ItemMgr.Mgr.LoadFromXML(xmlOpenFileDialog.FileName);
                    }
                    catch (IOException) {
                        MessageBox.Show("Eroare la deserializare", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (saveOption.Checked) {
                if (xmlSaveFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        ItemMgr.Mgr.SaveToXML(xmlSaveFileDialog.FileName);
                    }
                    catch (IOException) {
                        MessageBox.Show("Eroare la serializare", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
