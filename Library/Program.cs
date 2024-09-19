using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NativeAotTest;

public sealed partial class Interop
{
    [LibraryImport("nativeaottest")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void hello_world();
}
