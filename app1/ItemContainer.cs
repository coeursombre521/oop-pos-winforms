using entitati;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace app1 {
    public class ItemContainer : ICollection<ProdusAbstract>, IEnumerable<ProdusAbstract> {
        public static List<ProdusAbstract> items { get; private set; } = new();

        public ItemContainer() { }

        public virtual void AddItem(ProdusAbstract item) => items.Add(item);

        public void Add(ProdusAbstract item) => AddItem(item);

        public void AddItems(ProdusAbstract[] arr) { foreach (var i in arr) AddItem(i); }

        public virtual bool Contains(ProdusAbstract item) => items.Contains(item);

        public virtual bool RemoveItem(ProdusAbstract item) => items.Remove(item);

        public bool Remove(ProdusAbstract item) => RemoveItem(item);

        public bool RemoveItemWithId(Int32 id) => RemoveItem(items.Find(x => x.Id == id)!);

        public void CopyTo(ProdusAbstract[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public ProdusAbstract? GetItemById(Int32 id) => items.Find(x => x.Id == id);

        public bool ExistsWithId(Int32 id) => items.Exists(x => x.Id == id);

        public void Clear() => items.Clear();

        public void LoadFromXML(string filename) {
            Type[] types = GetDerivedTypes();
            XmlSerializer xs = new(typeof(List<ProdusAbstract>), types);
            FileStream fs = File.OpenRead(filename);
            items = (List<ProdusAbstract>)xs.Deserialize(fs)!;
            fs.Close();
        }

        public void SaveToXML(string filename) {
            Type[] types = GetDerivedTypes();
            XmlSerializer xs = new(typeof(List<ProdusAbstract>), types);
            using FileStream fs = File.Create(filename);
            using (var xmlWriter = XmlWriter.Create(fs, new XmlWriterSettings() {
                Indent = true,
                IndentChars = "    "
            })) {
                xs.Serialize(xmlWriter, items);
            }
            fs.Close();
        }

        public bool TryDuplicateItemOrId(ProdusAbstract item) {
            if (ExistsWithId(item.Id)) {
                throw new DuplicateIDException("ID already exists.");
            }
            if (Contains(item)) {
                throw new DuplicateItemException("Element already exists.");
            }
            return true;
        }

        public Int32 LowestAvailableId() {
            var maxObjectId = items.MaxBy(x => x.Id);
            var minObjectId = items.MinBy(x => x.Id);

            int maxId = (maxObjectId != null) ? maxObjectId.Id : 0;
            int minId = (minObjectId != null) ? minObjectId.Id : 0;

            var objectIds = items.Select(x => x.Id);
            var availIds = Enumerable.Range(minId, maxId + 2).Except(objectIds).Take(1).ToArray();

            return (availIds.Length != 0) ? availIds[0] : 0;
        }

        public IEnumerator<ProdusAbstract> GetEnumerator() {
            foreach (var i in items)
                yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            foreach (var i in items)
                yield return i;
        }

        private Type[] GetDerivedTypes() {
            var types =
                from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from type in assembly.GetTypes()
                where type.IsSubclassOf(typeof(ProdusAbstract)) && !type.IsAbstract
                select type;
            return types.ToArray();
        }

        public int Count { get => items.Count; }
        public bool IsReadOnly { get => false; }
        public List<ProdusAbstract> ItemsList { get => items; }
        public ProdusAbstract this[int idx] { get => items[idx]; set => items[idx] = value; }
    }
}
