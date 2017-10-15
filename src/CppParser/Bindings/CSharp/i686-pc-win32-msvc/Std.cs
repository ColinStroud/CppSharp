// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
    namespace CharTraits
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }

    public unsafe partial class CharTraits<_Elem> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits<_Elem>>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.CharTraits<_Elem> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_Elem>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.CharTraits<_Elem> __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new global::Std.CharTraits<_Elem>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.CharTraits<_Elem> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
    namespace CompressedPair
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.StringVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_PreprocessedEntity___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Declaration___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_BlockContentComment___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Template___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_TypedefDecl___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_TypeAlias___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Variable___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Friend___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1_____N_CppSharp_N_CppParser_N_AST_S_Declaration__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_CppSharp_N_CppParser_N_AST_S_Declaration__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1 _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_CppSharp_N_CppParser_N_AST_S_Declaration__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S2__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.TreeVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_BaseClassSpecifier___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Field___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Parameter___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_FunctionTemplateSpecialization___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_TemplateArgument___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Method___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_AccessSpecifierDecl___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_VTableComponent___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_VFTableInfo___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_LayoutField___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_LayoutBase___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Class___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Function___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Enumeration_S_Item___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Enumeration___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Namespace___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_ClassTemplateSpecialization___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_Expression___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_VarTemplateSpecialization___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_MacroDefinition___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_TranslationUnit___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_InlineContentComment___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_BlockCommandComment_S_Argument___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator__i___N_std_S__Vector_val____N_std_S__Simple_types__i_Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_VerbatimBlockLineComment___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_InlineCommandComment_S_Argument___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_N_AST_S_HTMLStartTagComment_S_Attribute___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }

        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internalc__N_std_S__Compressed_pair____N_std_S_allocator____N_CppSharp_N_CppParser_S_ParserDiagnostic___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1
        {
            [FieldOffset(0)]
            internal global::Std.VectorVal.__Internal _Myval2;
        }
    }

    public unsafe partial class CompressedPair<_Ty1, _Ty2, _0>
    {
    }
}

namespace Std
{
    namespace Allocator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0?$allocator@D@std@@QAE@XZ")]
            internal static extern global::System.IntPtr ctorc__N_std_S_allocator__C(global::System.IntPtr instance);
        }
    }

    public unsafe partial class Allocator<_Ty> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator<_Ty>>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator<_Ty> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Ty>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator<_Ty> __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new global::Std.Allocator<_Ty>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Allocator()
        {
            var ___Ty = typeof(_Ty);
            if (___Ty.IsAssignableFrom(typeof(sbyte)))
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.Allocator.__Internal.ctorc__N_std_S_allocator__C((__Instance + __PointerAdjustment));
                return;
            }
            throw new ArgumentOutOfRangeException("_Ty", string.Join(", ", new[] { typeof(_Ty).FullName }), "global::Std.Allocator<_Ty> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte>.");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.Allocator<_Ty> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }
}

namespace Std
{
    public unsafe static partial class BasicStringExtensions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??0?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@QBDABV?$allocator@D@1@@Z")]
            internal static extern global::System.IntPtr BasicString(global::System.IntPtr instance, [MarshalAs(UnmanagedType.LPStr)] string _Ptr, global::System.IntPtr _Al);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?c_str@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBEPBDXZ")]
            internal static extern global::System.IntPtr CStr(global::System.IntPtr instance);
        }

        public static global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> BasicString(string _Ptr, global::Std.Allocator<sbyte> _Al)
        {
            if (ReferenceEquals(_Al, null))
                throw new global::System.ArgumentNullException("_Al", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = _Al.__Instance;
            var __ret = Marshal.AllocHGlobal(24);
            __Internal.BasicString(__ret, _Ptr, __arg1);
            global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>) global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.NativeToManagedMap[__ret];
            else __result0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
            return __result0;
        }

        public static string CStr(this global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>> @this)
        {
            var __arg0 = ReferenceEquals(@this, null) ? global::System.IntPtr.Zero : @this.__Instance;
            var __ret = __Internal.CStr(__arg0);
            return Marshal.PtrToStringAnsi(__ret);
        }
    }

    namespace BasicString
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator__C___N_std_S__String_val____N_std_S__Simple_types__C_Vb1 _Mypair;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="??1?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QAE@XZ")]
            internal static extern void dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                EntryPoint="?c_str@?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@QBEPBDXZ")]
            internal static extern global::System.IntPtr CStrc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C(global::System.IntPtr instance);
        }
    }

    public unsafe partial class BasicString<_Elem, _Traits, _Alloc> : IDisposable
    {
        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString<_Elem, _Traits, _Alloc>>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.BasicString<_Elem, _Traits, _Alloc> __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_Elem, _Traits, _Alloc>(native.ToPointer(), skipVTables);
        }

        internal static global::Std.BasicString<_Elem, _Traits, _Alloc> __CreateInstance(global::Std.BasicString.__Internal native, bool skipVTables = false)
        {
            return new global::Std.BasicString<_Elem, _Traits, _Alloc>(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.BasicString.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internal));
            *(global::Std.BasicString.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private BasicString(global::Std.BasicString.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.BasicString<_Elem, _Traits, _Alloc> __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
            {
                var ___Elem = typeof(_Elem);
                var ___Traits = typeof(_Traits);
                var ___Alloc = typeof(_Alloc);
                if (___Elem.IsAssignableFrom(typeof(sbyte)) && ___Traits.IsAssignableFrom(typeof(global::Std.CharTraits<sbyte>)) && ___Alloc.IsAssignableFrom(typeof(global::Std.Allocator<sbyte>)))
                {
                    global::Std.BasicString.__Internal.dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C((__Instance + __PointerAdjustment), 0);
                    return;
                }
                throw new ArgumentOutOfRangeException("_Elem, _Traits, _Alloc", string.Join(", ", new[] { typeof(_Elem).FullName, typeof(_Traits).FullName, typeof(_Alloc).FullName }), "global::Std.BasicString<_Elem, _Traits, _Alloc> maps a C++ template class and therefore it only supports a limited set of types and their subclasses: <sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.");
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }

    namespace StringVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.StringVal.Bxty.__Internal _Bx;

            [FieldOffset(16)]
            internal uint _Mysize;

            [FieldOffset(20)]
            internal uint _Myres;
        }


        public unsafe partial struct Bxty
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal fixed sbyte _Buf[16];

                [FieldOffset(0)]
                internal global::System.IntPtr _Ptr;

                [FieldOffset(0)]
                internal fixed sbyte _Alias[16];
            }
        }
    }

    public unsafe partial class StringVal<_Val_types>
    {
    }
}

namespace Std
{
    namespace Vector
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_allocator_____N_CppSharp_N_CppParser_N_AST_S_PreprocessedEntity___N_std_S__Vector_val____N_std_S__Simple_types__S1__Vb1 _Mypair;
        }
    }

    public unsafe partial class Vector<_Ty, _Alloc>
    {
    }

    namespace VectorVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _Myfirst;

            [FieldOffset(4)]
            internal global::System.IntPtr _Mylast;

            [FieldOffset(8)]
            internal global::System.IntPtr _Myend;
        }
    }

    public unsafe partial class VectorVal<_Val_types>
    {
    }
}

namespace Std
{
    namespace TreeVal
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _Myhead;

            [FieldOffset(4)]
            internal uint _Mysize;
        }
    }

    public unsafe partial class TreeVal<_Val_types>
    {
    }
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.CompressedPair.__Internalc__N_std_S__Compressed_pair____N_std_S_less____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_std_S__Compressed_pair____N_std_S_allocator____N_std_S__Tree_node____N_std_S_pair__1S1_____N_CppSharp_N_CppParser_N_AST_S_Declaration__v___N_std_S__Tree_val____N_std_S__Tree_simple_types__S7__Vb1_Vb1 _Mypair;
        }
    }

    public unsafe partial class Map<_Kty, _Ty, _Pr, _Alloc>
    {
    }
}
