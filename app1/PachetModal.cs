using entitati;

namespace app1 {
    public partial class PachetModal : Form {
        private Pachet currentElement;
        decimal pretFieldValue = 0.01M;

        public PachetModal(Pachet currentElement) {
            InitializeComponent();
            this.currentElement = currentElement;
        }

        private void PsPachetUpdateList() {
            psList.Items.Clear();
            foreach (var i in ItemMgr.Mgr.ItemsList) {
                ListViewItem? lvItem = null;
                if (i is Produs p) {
                    lvItem = new(p.Id.ToString()) { Tag = p };
                    lvItem.SubItems.Add(p.GetType().Name);
                    lvItem.SubItems.Add(p.Nume);
                }
                if (i is Serviciu s) {
                    lvItem = new(s.Id.ToString()) { Tag = s };
                    lvItem.SubItems.Add(s.GetType().Name);
                    lvItem.SubItems.Add(s.Nume);
                }
                if (lvItem != null) {
                    if (currentElement.IsInPackage(i)) {
                        lvItem.Checked = true;
                    }
                    psList.Items.Add(lvItem);
                }
            }

            pretFieldValue = 0.0M;
            foreach (ListViewItem i in psList.CheckedItems) {
                if (i.Tag is ProdusAbstract p) {
                    pretFieldValue += (decimal)p.Pret;
                }
            }
            pret1.Value = (pretFieldValue > pret1.Minimum) ? pretFieldValue : pret1.Minimum;
        }

        private void cancel_CloseModal(object sender, EventArgs e) {
            Close();
            Dispose();
        }

        private void PachetModal_Load(object sender, EventArgs e) {
            nume1.Text = currentElement.Nume;
            codIntern1.Text = currentElement.CodIntern;
            pret1.Value = (Decimal)currentElement.Pret;
            maxProduse1.Value = (Int32)currentElement.MaxProduse;
            maxServicii1.Value = (Int32)currentElement.MaxServicii;
            PsPachetUpdateList();
        }

        private bool UpdateElement() {
            bool ret = true;
            try {
                currentElement.Nume = nume1.Text;
                currentElement.CodIntern = codIntern1.Text;
                currentElement.Pret = (Double)pret1.Value;
                currentElement.MaxProduse = (Int32)maxProduse1.Value;
                currentElement.MaxServicii = (Int32)maxServicii1.Value;

                currentElement.ClearPackageElements();
                foreach (ListViewItem i in psList.CheckedItems) {
                    if (i.Tag is Produs p && p.CanBeAddedToPackage(currentElement)) {
                        currentElement.AddToPackage(p);
                    }
                    if (i.Tag is Serviciu s && s.CanBeAddedToPackage(currentElement)) {
                        currentElement.AddToPackage(s);
                    }
                }

            }
            catch (EmptyFieldsException) {
                MessageBox.Show("Unul sau mai multe câmpuri sunt goale.", "Eroare la actualizare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            catch (InvalidValuesException) {
                MessageBox.Show("Valori invalide.", "Eroare la actualizare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            catch (PackageConstraintException) {
                MessageBox.Show("Sunt elemente ce nu pot fi adăugate în pachet.", "Eroare la actualizare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void applyButton_Click(object sender, EventArgs e) {
            bool ret = UpdateElement();
            if (ret) {
                MessageBox.Show("Pachet actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            bool ret = UpdateElement();
            if (ret) {
                MessageBox.Show("Pachet actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
            Dispose();
        }

        private void psList_ItemChecked(object sender, ItemCheckedEventArgs e) {
            pretFieldValue = 0.0M;
            foreach (ListViewItem i in psList.CheckedItems) {
                if (i.Tag is ProdusAbstract p) {
                    pretFieldValue += (decimal)p.Pret;
                }
            }
            pret1.Value = (pretFieldValue > pret1.Minimum) ? pretFieldValue : pret1.Minimum;
        }
    }
}
