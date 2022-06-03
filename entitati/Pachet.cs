using System.ComponentModel;

namespace entitati {
    [Serializable]
    [DefaultPropertyAttribute("Nume")]
    public class Pachet : ProdusAbstract {
        private List<ProdusAbstract> elemPachet = new();
        private int maxProduse = 0;
        private int maxServicii = 0;

        public Pachet() : base() {}

        public Pachet(Int32 id, String? nume, String? codIntern, Double pret) : base(id, nume, codIntern, pret) {
            this.maxProduse = 0;
            this.maxServicii = 0;
        }

        public Pachet(Int32 id, String? nume, String? codIntern, Double pret, int maxProduse, int maxServicii) : base(id, nume, codIntern, pret) {
            this.maxProduse = maxProduse;
            this.maxServicii = maxServicii;
        }

        public void AddToPackage(IPackageable element) {
            if (element is ProdusAbstract @obj && @obj.CanBeAddedToPackage(this)) {
                if (elemPachet.Count == 0) Pret = 0.0;
                elemPachet!.Add(@obj);
                Pret += @obj.Pret;
            }
            else {
                throw new PackageConstraintException("Elementul nu poate fi adăugat în pachet.");
            }
        }

        public bool IsInPackage(IPackageable element) => elemPachet.Contains(element);

        public void ClearPackageElements() {
            elemPachet.Clear();
            Pret = 0.0;
        }

        public override string Descriere() {
            string fmt = $"Pachetul [{Id}]: {Nume}, cod intern: [{CodIntern}], preț: [{Pret} lei], conține:";
            foreach (ProdusAbstract i in elemPachet!) {
                fmt = fmt + "\n\t\t" + i.Descriere();
            }
            return fmt;
        }

        public override string AltaDescriere() {
            string fmt = $"Pachetul {base.AltaDescriere()},  conține:";
            foreach (ProdusAbstract i in elemPachet!) {
                fmt = fmt + "\n\t\t" + i.Descriere();
            }
            return fmt;
        }

        public void Sort() => elemPachet!.Sort();

        public override bool CanBeAddedToPackage(Pachet pachet) => false;

        public int OfTypeCount<T>() where T: ProdusAbstract, IPackageable => this.elemPachet!.OfType<T>().Count();

        #region IValidateProperty fields
        public override event BeforePropertyValidationEventHandler? BeforePropertyValidation;
        public override event AfterPropertyValidationEventHandler? AfterPropertyValidation;
        #endregion

        public List<ProdusAbstract> ElemPachet { get => elemPachet; }

        [CategoryAttribute("Detalii"), DescriptionAttribute("Numărul maxim de produse în pachet.")]
        public int MaxProduse { 
            get => maxProduse; 
            set {
                bool validateMaxProduse(int value) {
                    if (value < 0) {
                        throw new InvalidValuesException("Invalid value.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateMaxProduse!, AfterPropertyValidation!, ref maxProduse, value, this, () => MaxProduse);
            } 
        }
        [CategoryAttribute("Detalii"), DescriptionAttribute("Numărul maxim de servicii în pachet.")]
        public int MaxServicii { 
            get => this.maxServicii; 
            set {
                bool validateMaxServicii(int value) {
                    if (value < 0) {
                        throw new InvalidValuesException("Invalid value.");
                    }
                    return true;
                };
                PropertyValidation.RaiseEventsAndChangeIfValid(BeforePropertyValidation!, validateMaxServicii!, AfterPropertyValidation!, ref maxServicii, value, this, () => MaxServicii);
            } 
        }
    }
}