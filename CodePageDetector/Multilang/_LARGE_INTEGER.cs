using System.Runtime.InteropServices;

namespace CodePageDetector.Multilang
{
    [StructLayout(LayoutKind.Sequential, Pack=8)]
    public struct _LARGE_INTEGER
    {
        public long QuadPart;
    }
}
