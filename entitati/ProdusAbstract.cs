using System.ComponentModel;

namespace entitati {
    [Serializable]
    [DefaultPropertyAttribute("Nume")]
    public abstract class ProdusAbstract : IComparable<ProdusAbstract>, IPackageable, IValidateProperty {
        private Int32 id;
        private String? nume;
        private String? codIntern;
        private Double pret;

        public ProdusAbstract() {
            this.id = 0;
            this.nume = "";
            this.codIntern = "";
            this.pret = 0.0;
        }

        protected ProdusAbstract(Int32 id, String? nume, String? codIntern, Double pret) {
            this.id = id;
            this.nume = nume!;
            this.codIntern = codIntern!;
            this.pret = pret;
        }

        public override bool Equals(object? obj) {
            return obj is ProdusAbstract @abstract &&
                   nume == @abstract.nume &&
                   codIntern == @abstract.codIntern;
        }

        public override int GetHashCode() {
            return HashCode.Combine(id, nume, codIntern);
        }

        public int CompareTo(ProdusAbstract? obj) {
            int ret;
            if (obj is ProdusAbstract @abstract) {
                ret = String.Compare(this.nume, @abstract.nume);
            }
            else {
                throw new ArgumentException("Obiectul nu face parte din clasa ProdusAbstract.");
            }
            return ret;
        }

        public abstract string Descriere();

        public virtual string AltaDescriere() {
            return $"[{Id}]: {Nume}, cod intern: [{CodIntern}], preț: [{Pret}]";
        }

        public abstract bool CanBeAddedToPackage(Pachet pachet);

        #region IValidateProperty fields
        public virtual event BeforePropertyValidationEventHandler? BeforePropertyValidation;
        public virtual event AfterPropertyValidationEventHandler? AfterPropertyValidation;
        #endregion

        [CategoryAttribute("Detalii"), DescriptionAttribute("Numărul de identificare al unui produs, serviciu sau pachet.")]
        public Int32 Id {
            get => id;
            set {
                bool validateId(int value) {
                    if (value < 0) {
                        throw new InvalidValuesException("Invalid ID.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateId!, AfterPropertyValidation!, ref id, value, this, () => Id);
            } 
        }
        [CategoryAttribute("Detalii"), DescriptionAttribute("Numele unui produs, serviciu sau pachet.")]
        public String? Nume { 
            get => nume!; 
            set {
                bool validateNume(string? value) {
                    if (String.IsNullOrEmpty(value!) || String.IsNullOrWhiteSpace(value!)) {
                        throw new EmptyFieldsException("Empty string.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateNume!, AfterPropertyValidation!, ref nume, value, this, () => Nume);
            } 
        }
        [CategoryAttribute("Detalii"), DescriptionAttribute("Codul intern al unui produs, serviciu sau pachet.")]
        public String? CodIntern { 
            get => codIntern!; 
            set {
                bool validateCodIntern(string? value) {
                    if (String.IsNullOrEmpty(value!) || String.IsNullOrWhiteSpace(value!)) {
                        throw new EmptyFieldsException("Empty string.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateCodIntern!, AfterPropertyValidation!, ref codIntern, value, this, () => CodIntern);
            } 
        }
        [CategoryAttribute("Detalii"), DescriptionAttribute("Prețul unui produs, serviciu sau pachet.")]
        public Double Pret { 
            get => pret; 
            set {
                bool validatePret(double value) {
                    if (value < 0) {
                        throw new InvalidValuesException("Invalid ID.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validatePret!, AfterPropertyValidation!, ref pret, value, this, () => Pret);
            } 
        }
    }
}