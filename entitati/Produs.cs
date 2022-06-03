using System.ComponentModel;

namespace entitati {
    [Serializable]
    [DefaultPropertyAttribute("Nume")]
    public class Produs : ProdusAbstract {
        private String? producator;
        private String? categorie;

        public Produs() : base() {
            this.producator = "";
            this.categorie = "";
        }

        public Produs(Int32 id, String? nume, String? codIntern, String? producator, Double pret, String? categorie) : base(id, nume, codIntern, pret) {
            this.producator = producator!;
            this.categorie = categorie!;
        }

        public override bool Equals(object? obj) {
            return obj is Produs produs &&
                   base.Equals(produs) &&
                   producator == produs.producator;
        }

        public override int GetHashCode() {
            return HashCode.Combine(base.GetHashCode(), producator);
        }

        public override string Descriere() {
            return $"Produsul [{Id}]: {Nume}, cod intern: [{CodIntern}], " +
                   $"producător: [{Producator}], preț: [{Pret} lei], categorie: [{Categorie}]";
        }

        public override string AltaDescriere() {
            return "Produsul " + base.AltaDescriere() + " producător: [" + Producator + "] categorie: [" + Categorie + "]";
        }

        public override bool CanBeAddedToPackage(Pachet pachet)
        => pachet.OfTypeCount<Produs>() < pachet.MaxProduse || pachet.MaxProduse == 0;

        #region IValidateProperty fields
        public override event BeforePropertyValidationEventHandler? BeforePropertyValidation;
        public override event AfterPropertyValidationEventHandler? AfterPropertyValidation;
        #endregion

        [CategoryAttribute("Detalii"), DescriptionAttribute("Producătorul unui produs.")]
        public String? Producator { 
            get => producator!; 
            set {
                bool validateProducator(string? value) {
                    if (String.IsNullOrEmpty(value!) || String.IsNullOrWhiteSpace(value!)) {
                        throw new EmptyFieldsException("Empty string.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateProducator!, AfterPropertyValidation!, ref producator, value, this, () => Producator);
            } 
        }
        [CategoryAttribute("Detalii"), DescriptionAttribute("Categoria unui produs.")]
        public String? Categorie { 
            get => categorie!; 
            set {
                bool validateCategorie(string? value) {
                    if (String.IsNullOrEmpty(value!) || String.IsNullOrWhiteSpace(value!)) {
                        throw new EmptyFieldsException("Empty string.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateCategorie!, AfterPropertyValidation!, ref categorie, value, this, () => Categorie);
            } 
        }
    }
}