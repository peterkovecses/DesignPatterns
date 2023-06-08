namespace Creational.Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _lazy =
            new(() => new Singleton());

        public static Singleton Instance { get { return _lazy.Value; } }

        private Singleton() { }
    }
}
