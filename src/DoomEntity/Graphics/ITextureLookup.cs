using System.Collections.Generic;

namespace DoomNetFrameworkEngine.DoomEntity.Graphics
{
    public interface ITextureLookup : IReadOnlyList<Texture>
    {
        int GetNumber(string name);
        Texture this[string name] { get; }
        public int[] SwitchList { get; }
    }
}
