using entitati;

namespace app1 {
    public class ServiciiItemContainer : ItemContainer {
        public ServiciiItemContainer() : base() { }

        public override void AddItem(ProdusAbstract item) {
            if (item is Serviciu obj) {
                base.AddItem(obj);
            }
            else {
                throw new ArgumentException("Invalid object type.");
            }
        }

        public void AddItem(Serviciu item) => base.AddItem(item);

        public void Add(Serviciu item) => base.Add(item);

        public override bool RemoveItem(ProdusAbstract item) {
            if (item is Serviciu obj) {
                return base.RemoveItem(obj);
            }
            else {
                return false;
            }
        }

        public void RemoveItem(Serviciu item) => base.RemoveItem(item);

        public void Remove(Serviciu item) => base.Remove(item);

        public override bool Contains(ProdusAbstract item) {
            if (item is Serviciu obj) {
                return base.Contains(obj);
            }
            else {
                return false;
            }
        }

        public bool Contains(Serviciu item) => base.Contains(item);
    }
}
