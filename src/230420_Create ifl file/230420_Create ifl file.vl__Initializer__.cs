extern alias e17;
extern alias e1;
extern alias e2;
extern alias e20;
extern alias e8;
extern alias e24;
extern alias e21;
extern alias e75;

using n8 = e1::VL.Core;
using n7 = e2::VL.AppServices.CompilerServices;
using n3 = global::__230420_Create_ifl_file_;
using n12 = e21::_VL_Skia_;
using n14 = global::System;
using n15 = e75::VL.App.WindowsForms;
using n6 = global::__230420_Create_ifl_file_.__auto;
using n2 = e2::VL.Core;
using n1 = e2::VL.Core.CompilerServices;
using n4 = e1::VL.Core.CompilerServices;
using n13 = e24::_VL_CoreLib_Windows_;
using n11 = e20::_VL_ImGui_Skia_;
using n10 = e17::_VL_ImGui_;
using n5 = e2::VL.Model;
using n9 = e8::_VL_CoreLib_;

[assembly: n1.CompilerVersionAttribute("2022.5.0-0763-ga6e3d8dd46")]
[assembly: n1.SymbolSourceReferenceAttribute("VL.CoreLib.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.ImGui.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.ImGui.Skia.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.Skia.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.CoreLib.Windows.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n4.AssemblyInitializerAttribute(typeof(n3.FsveJstIG5RP7BHGOYVEFDInitializer))]
[assembly: n1.TypeImportAttribute("FsveJstIG5RP7BHGOYVEFD", "Rs34wkHLV3PLtiy64jsjkt", "230420_Create ifl fileApplication", "Main", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, n5.KnownTypeStructure.None, typeof(n6._230420_Create_ifl_fileApplication_Rs34wkHLV3PLtiy64jsjkt), null, false, true)]
[assembly: n1.ProcessAttribute("Application", "", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, typeof(n6._230420_Create_ifl_fileApplication_Rs34wkHLV3PLtiy64jsjkt), false, "Create", "Update")]
[assembly: n7.AdaptiveImplementationsAttribute(typeof(n3.__AdaptiveImplementations__FsveJstIG5RP7BHGOYVEFD))]
namespace __230420_Create_ifl_file_
{
    public sealed class FsveJstIG5RP7BHGOYVEFDInitializer : n4.AssemblyInitializer<n3.FsveJstIG5RP7BHGOYVEFDInitializer>
    {
        protected override sealed void RegisterServices(n8.IVLFactory factory)
        {
            n9.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
            n10.HGwjAyY9WlcM6EHVoNooQRInitializer.Default.Init(factory);
            n11.TlT19thZkWBLG3AeB1o51bInitializer.Default.Init(factory);
            n12.M1XXME8bUtmNxzMxVHhNawInitializer.Default.Init(factory);
            n13.HylXxkKPeF0O6LWz4fSQKoInitializer.Default.Init(factory);
            if (factory.OnlyStaticServices)
                return;
        }
    }
}

internal sealed class Program
{
    [n14.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n15.WindowsFormsAppHost<n6._230420_Create_ifl_fileApplication_Rs34wkHLV3PLtiy64jsjkt>(c => n6._230420_Create_ifl_fileApplication_Rs34wkHLV3PLtiy64jsjkt.Create(c), s => ((n6._230420_Create_ifl_fileApplication_Rs34wkHLV3PLtiy64jsjkt)s).Update()))
            appHost.Run();
    }
}