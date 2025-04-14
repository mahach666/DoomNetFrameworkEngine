using System.Collections.Generic;

namespace DoomNetFrameworkEngine.DoomEntity.Graphics
{
    public interface IFlatLookup : IReadOnlyList<Flat>
    {
        int GetNumber(string name);
        public Flat this[string name] { get; }
        public int SkyFlatNumber { get; }
        public Flat SkyFlat { get; }
    }
}
