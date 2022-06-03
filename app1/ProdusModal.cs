using entitati;

namespace app1 {
    public partial class ProdusModal : Form {
        private Produs currentElement;

        public ProdusModal(Produs currentElement) {
            InitializeComponent();
            this.currentElement = currentElement;
        }

        private void cancel_CloseModal(object sender, EventArgs e) {
            Close();
            Dispose();
        }

        private void ProdusModal_Load(object sender, EventArgs e) {
            nume1.Text = currentElement.Nume;
            codIntern1.Text = currentElement.CodIntern;
            pret1.Value = (Decimal)currentElement.Pret;
            producator1.Text = currentElement.Producator;
            categorie1.Text = currentElement.Categorie;
        }

        private bool UpdateElement() {
            bool ret = true;
            try {
                currentElement.Nume = nume1.Text;
                currentElement.CodIntern = codIntern1.Text;
                currentElement.Pret = (Double)pret1.Value;
                currentElement.Producator = producator1.Text;
                currentElement.Categorie = categorie1.Text;
            }
            catch (EmptyFieldsException) {
                MessageBox.Show("Unul sau mai multe câmpuri sunt goale.", "Eroare la actualizare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            catch (InvalidValuesException) {
                MessageBox.Show("Valori invalide.", "Eroare la actualizare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void applyButton_Click(object sender, EventArgs e) {
            bool ret = UpdateElement();
            if (ret) {
                MessageBox.Show("Produs actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            bool ret = UpdateElement();
            if (ret) {
                MessageBox.Show("Produs actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
            Dispose();
        }
    }
}
