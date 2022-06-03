using System.ComponentModel;
using entitati;

namespace app1 {
    public partial class PosItemListModal : Form {
        public PosItemListModal() {
            InitializeComponent();
        }

        private void UpdateItemsInList() {
            itemsList.Items.Clear();
            foreach (var i in ItemMgr.Mgr.ItemsList) {
                ListViewItem lvItem = new(i.Id.ToString()) { Tag = i };
                lvItem.SubItems.Add(i.GetType().Name);
                lvItem.SubItems.Add(i.Nume);
                lvItem.SubItems.Add(i.CodIntern);
                lvItem.SubItems.Add(i.Pret.ToString());
                itemsList.Items.Add(lvItem);
            }
        }

        private void PosItemListModal_Load(object sender, EventArgs e) {
            UpdateItemsInList();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem i in itemsList.CheckedItems) {
                if (i.Tag is ProdusAbstract p) {
                    ItemMgr.Mgr.RemoveItemWithId(p.Id);
                }
            }
            UpdateItemsInList();
        }

        private void editButton_Click(object sender, EventArgs e) {

            if (itemsList.SelectedItems.Count == 0) {
                MessageBox.Show("Selectați un element.", "Element neselectat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (itemsList.SelectedItems.Count == 1) {
                ListViewItem selItem = itemsList.SelectedItems[0];
                if (selItem.Tag is Produs pr) {
                    ProdusModal prm = new(pr);
                    prm.ShowDialog();
                }
                if (selItem.Tag is Serviciu se) {
                    ServiciuModal sem = new(se);
                    sem.ShowDialog();
                }
                if (selItem.Tag is Pachet pa) {
                    PachetModal pam = new(pa);
                    pam.ShowDialog();
                }
                UpdateItemsInList();
            }
            else {
                MessageBox.Show("Selectați doar un singur element pentru editare.", "Multiple elemente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
            Dispose();
        }
    }
}
