using entitati;

namespace app1 {
    internal static class ItemMgr {
        public static ItemContainer Mgr { get; private set; } = new();
        public static ProduseItemContainer PrMgr { get; private set; } = new();
        public static ServiciiItemContainer SeMgr { get; private set; } = new();
        public static PacheteItemContainer PaMgr { get; private set; } = new();
    }
}
