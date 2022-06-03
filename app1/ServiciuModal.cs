using entitati;

namespace app1 {
    public partial class ServiciuModal : Form {
        Serviciu currentElement;

        public ServiciuModal(Serviciu currentElement) {
            InitializeComponent();
            this.currentElement = currentElement;
        }

        private void cancel_CloseModal(object sender, EventArgs e) {
            Close();
            Dispose();
        }

        private void ServiciuModal_Load(object sender, EventArgs e) {
            nume1.Text = currentElement.Nume;
            codIntern1.Text = currentElement.CodIntern;
            pret1.Value = (Decimal)currentElement.Pret;
        }

        private bool UpdateElement() {
            bool ret = true;
            try {
                currentElement.Nume = nume1.Text;
                currentElement.CodIntern = codIntern1.Text;
                currentElement.Pret = (Double)pret1.Value;
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
                MessageBox.Show("Serviciu actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            bool ret = UpdateElement();
            if (ret) {
                MessageBox.Show("Serviciu actualizat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
            Dispose();
        }
    }
}
