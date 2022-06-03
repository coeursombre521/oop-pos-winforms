using entitati;

namespace app1 {
    public class ProduseItemContainer : ItemContainer {
        public ProduseItemContainer() : base() { }

        public override void AddItem(ProdusAbstract item) {
            if (item is Produs obj) {
                base.AddItem(obj);
            }
            else {
                throw new ArgumentException("Invalid object type.");
            }
        }

        public void AddItem(Produs item) => base.AddItem(item);

        public void Add(Produs item) => base.Add(item);

        public override bool RemoveItem(ProdusAbstract item) {
            if (item is Produs obj) {
                return base.RemoveItem(obj);
            }
            else {
                return false;
            }
        }

        public void RemoveItem(Produs item) => base.RemoveItem(item);

        public void Remove(Produs item) => base.Remove(item);

        public override bool Contains(ProdusAbstract item) {
            if (item is Produs obj) {
                return base.Contains(obj);
            }
            else {
                return false;
            }
        }

        public bool Contains(Produs item) => base.Contains(item);
    }
}
