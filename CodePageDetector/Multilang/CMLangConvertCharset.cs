using System.Runtime.InteropServices;

namespace CodePageDetector.Multilang
{
    [ComImport, Guid("D66D6F98-CDAA-11D0-B822-00C04FC9B31F"), CoClass(typeof(CMLangConvertCharsetClass))]
    public interface CMLangConvertCharset : IMLangConvertCharset
    {
    }
}
