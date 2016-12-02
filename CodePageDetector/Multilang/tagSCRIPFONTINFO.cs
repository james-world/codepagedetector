using System.Runtime.InteropServices;

namespace CodePageDetector.Multilang
{
    [StructLayout(LayoutKind.Sequential, Pack=8)]
    public struct tagSCRIPFONTINFO
    {
        public long scripts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
        public ushort[] wszFont;
    }
}