using System.ComponentModel;

namespace entitati {
    [Serializable]
    [DefaultPropertyAttribute("Nume")]
    public class Serviciu : ProdusAbstract {
        public Serviciu() : base() {}

        public Serviciu(Int32 id, String? nume, String? codIntern, Double pret) : base(id, nume, codIntern, pret) {}

        public override bool Equals(object? obj) {
            return obj is Serviciu serviciu &&
                   base.Equals(serviciu);
        }

        public override int GetHashCode() {
            return HashCode.Combine(base.GetHashCode());
        }

        public override string Descriere() {
            return $"Serviciul [{Id}]: {Nume}, cod intern: [{CodIntern}], preț: [{Pret} lei]";
        }

        public override string AltaDescriere() {
            return "Serviciul " + base.AltaDescriere();
        }

        public override bool CanBeAddedToPackage(Pachet pachet)
        => pachet.OfTypeCount<Serviciu>() < pachet.MaxServicii || pachet.MaxServicii == 0;
    }
}
