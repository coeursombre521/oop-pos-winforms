using entitati;

namespace app1 {
    public class PacheteItemContainer : ItemContainer {
        public PacheteItemContainer() : base() { }

        public override void AddItem(ProdusAbstract item) {
            if (item is Pachet obj) {
                base.AddItem(obj);
            }
            else {
                throw new ArgumentException("Invalid object type.");
            }
        }

        public void AddItem(Pachet item) => base.AddItem(item);

        public void Add(Pachet item) => base.Add(item);

        public override bool RemoveItem(ProdusAbstract item) {
            if (item is Pachet obj) {
                return base.RemoveItem(obj);
            }
            else {
                return false;
            }
        }

        public void RemoveItem(Pachet item) => base.RemoveItem(item);

        public void Remove(Pachet item) => base.Remove(item);

        public override bool Contains(ProdusAbstract item) {
            if (item is Pachet obj) {
                return base.Contains(obj);
            }
            else {
                return false;
            }
        }

        public bool Contains(Pachet item) => base.Contains(item);
    }
}
