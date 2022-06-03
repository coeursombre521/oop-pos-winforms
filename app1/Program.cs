using entitati;

namespace app1 {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new PosMainForm());
        }
    }
}