using System.Runtime.InteropServices;

namespace CodePageDetector.Multilang
{
    [StructLayout(LayoutKind.Sequential, Pack=2)]
    public struct tagUNICODERANGE
    {
        public ushort wcFrom;
        public ushort wcTo;
    }
}
