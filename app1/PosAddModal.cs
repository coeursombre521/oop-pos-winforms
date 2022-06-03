using entitati;

namespace app1 {
    public partial class PosAddModal : Form {
        decimal pretFieldValue = 0.01M;

        public PosAddModal() {
            InitializeComponent();
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
                    psList.Items.Add(lvItem);
                }
            }
        }

        private void cancel_CloseModal(object sender, EventArgs e) {
            Close();
            Dispose();
        }

        private void autoIncCheck1_CheckedChanged(object sender, EventArgs e) {
            id1.Enabled = !autoIncCheck1.Checked;
            if (autoIncCheck1.Checked) {
                id1.Value = ItemMgr.PrMgr.LowestAvailableId();
            }
        }

        private void autoIncCheck2_CheckedChanged(object sender, EventArgs e) {
            id2.Enabled = !autoIncCheck2.Checked;
            if (autoIncCheck2.Checked) {
                id2.Value = ItemMgr.SeMgr.LowestAvailableId();
            }
        }

        private void autoIncCheck3_CheckedChanged(object sender, EventArgs e) {
            id3.Enabled = !autoIncCheck3.Checked;
            if (autoIncCheck3.Checked) {
                id3.Value = ItemMgr.PaMgr.LowestAvailableId();
            }
        }

        private void PosAddModal_Load(object sender, EventArgs e) {
            id1.Enabled = !autoIncCheck1.Checked;
            id2.Enabled = !autoIncCheck2.Checked;
            id3.Enabled = !autoIncCheck3.Checked;
            if (autoIncCheck1.Checked) {
                id1.Value = ItemMgr.PrMgr.LowestAvailableId();
            }
            if (autoIncCheck2.Checked) {
                id2.Value = ItemMgr.SeMgr.LowestAvailableId();
            }
            if (autoIncCheck3.Checked) {
                id3.Value = ItemMgr.PaMgr.LowestAvailableId();
            }
            PsPachetUpdateList();
            this.AcceptButton = addButton1;
            this.CancelButton = cancelButton1;
        }

        private void addButton1_Click(object sender, EventArgs e) {
            Produs tmp = new();
            bool ret = false;

            try {
                tmp.Id = (Int32)id1.Value;
                tmp.Nume = nume1.Text;
                tmp.CodIntern = codIntern1.Text;
                tmp.Pret = (Double)pret1.Value;
                tmp.Producator = producator1.Text;
                tmp.Categorie = categorie1.Text;
                ret = ItemMgr.PrMgr.TryDuplicateItemOrId(tmp);
                ItemMgr.PrMgr.AddItem(tmp);
            }
            catch (EmptyFieldsException) {
                statusLabel1.Text = "Unul sau mai multe câmpuri sunt goale.";
                statusLabel1.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateIDException) {
                statusLabel1.Text = "ID-ul furnizat există deja.";
                statusLabel1.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateItemException) {
                statusLabel1.Text = "Produsul deja există.";
                statusLabel1.ForeColor = Color.OrangeRed;
                return;
            }
            finally {
                if (ret) {
                    statusLabel1.Text = "Produs adăugat cu succes.";
                    statusLabel1.ForeColor = Color.DodgerBlue;
                    id1.Value = (Decimal)ItemMgr.PrMgr.LowestAvailableId();
                }
            }
        }

        private void addButton2_Click(object sender, EventArgs e) {
            Serviciu tmp = new();
            bool ret = false;

            try {
                tmp.Id = (Int32)id2.Value;
                tmp.Nume = nume2.Text;
                tmp.CodIntern = codIntern2.Text;
                tmp.Pret = (Double)pret2.Value;
                ret = ItemMgr.SeMgr.TryDuplicateItemOrId(tmp);
                ItemMgr.SeMgr.AddItem(tmp);
            }
            catch (InvalidValuesException) {
                statusLabel2.Text = "Valori invalide.";
                statusLabel2.ForeColor = Color.OrangeRed;
                return;
            }
            catch (EmptyFieldsException) {
                statusLabel2.Text = "Unul sau mai multe câmpuri sunt goale.";
                statusLabel2.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateIDException) {
                statusLabel2.Text = "ID-ul furnizat există deja.";
                statusLabel2.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateItemException) {
                statusLabel2.Text = "Serviciul deja există.";
                statusLabel2.ForeColor = Color.OrangeRed;
                return;
            }
            finally {
                if (ret) {
                    statusLabel2.Text = "Serviciu adăugat cu succes.";
                    statusLabel2.ForeColor = Color.DodgerBlue;
                    id2.Value = (Decimal)ItemMgr.SeMgr.LowestAvailableId();
                }
            }
        }

        private void addButton3_Click(object sender, EventArgs e) {
            Pachet tmp = new();
            bool ret = false;

            try {
                tmp.Id = (Int32)id3.Value;
                tmp.Nume = nume3.Text;
                tmp.CodIntern = codIntern3.Text;
                tmp.Pret = (Double)pret3.Value;
                tmp.MaxProduse = (Int32)maxProduse3.Value;
                tmp.MaxServicii = (Int32)maxServicii3.Value;
                ret = ItemMgr.PaMgr.TryDuplicateItemOrId(tmp);

                foreach (ListViewItem i in psList.CheckedItems) {
                    if (i.Tag is Produs p && p.CanBeAddedToPackage(tmp)) {
                        tmp.AddToPackage(p);
                    }
                    if (i.Tag is Serviciu s && s.CanBeAddedToPackage(tmp)) {
                        tmp.AddToPackage(s);
                    }
                }

                ItemMgr.PaMgr.AddItem(tmp);
            }
            catch (InvalidValuesException) {
                statusLabel3.Text = "Valori invalide.";
                statusLabel3.ForeColor = Color.OrangeRed;
                return;
            }
            catch (EmptyFieldsException) {
                statusLabel3.Text = "Unul sau mai multe câmpuri sunt goale.";
                statusLabel3.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateIDException) {
                statusLabel3.Text = "ID-ul furnizat există deja.";
                statusLabel3.ForeColor = Color.OrangeRed;
                return;
            }
            catch (DuplicateItemException) {
                statusLabel3.Text = "Pachetul deja există.";
                statusLabel3.ForeColor = Color.OrangeRed;
                return;
            }
            catch (PackageConstraintException) {
                statusLabel3.Text = "Sunt elemente ce nu pot fi adăugate în pachet.";
                statusLabel3.ForeColor = Color.OrangeRed;
                return;
            }
            finally {
                if (ret) {
                    statusLabel3.Text = "Pachet adăugat cu succes.";
                    statusLabel3.ForeColor = Color.DodgerBlue;
                    id3.Value = (Decimal)ItemMgr.PaMgr.LowestAvailableId();
                }
            }
        }

        private void produsPage_Enter(object sender, EventArgs e) {
            id1.Value = (Decimal)ItemMgr.PrMgr.LowestAvailableId();
            statusLabel2.Text = " ";
            statusLabel3.Text = " ";
            this.AcceptButton = addButton1;
            this.CancelButton = cancelButton1;
        }

        private void serviciuPage_Enter(object sender, EventArgs e) {
            id2.Value = (Decimal)ItemMgr.SeMgr.LowestAvailableId();
            statusLabel1.Text = " ";
            statusLabel3.Text = " ";
            this.AcceptButton = addButton2;
            this.CancelButton = cancelButton2;
        }

        private void pachetPage_Enter(object sender, EventArgs e) {
            id3.Value = (Decimal)ItemMgr.PaMgr.LowestAvailableId();
            statusLabel1.Text = " ";
            statusLabel2.Text = " ";
            PsPachetUpdateList();
            this.AcceptButton = addButton3;
            this.CancelButton = cancelButton3;
        }

        private void psList_ItemChecked(object sender, ItemCheckedEventArgs e) {
            pretFieldValue = 0.0M;
            foreach (ListViewItem i in psList.CheckedItems) {
                if (i.Tag is ProdusAbstract p) {
                    pretFieldValue += (decimal)p.Pret;
                }
            }
            pret3.Value = (pretFieldValue > pret3.Minimum) ? pretFieldValue : pret3.Minimum;
        }
    }
}
