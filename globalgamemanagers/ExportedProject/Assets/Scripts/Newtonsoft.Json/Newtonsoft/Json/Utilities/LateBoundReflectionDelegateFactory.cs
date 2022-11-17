using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000045")]
	[Preserve]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5A4", Offset = "0x80E5A4")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x10")]
			public ConstructorInfo c;

			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x18")]
			public MethodBase method;

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x176C40C", Offset = "0x176C40C", VA = "0x176C40C")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x176C514", Offset = "0x176C514", VA = "0x176C514")]
			internal object _003CCreateParameterizedConstructor_003Eb__0(object[] a)
			{
				return null;
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x176C54C", Offset = "0x176C54C", VA = "0x176C54C")]
			internal object _003CCreateParameterizedConstructor_003Eb__1(object[] a)
			{
				return null;
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5B4", Offset = "0x80E5B4")]
		private sealed class _003C_003Ec__DisplayClass4_0<T>
		{
			[Token(Token = "0x4000171")]
			[FieldOffset(Offset = "0x0")]
			public ConstructorInfo c;

			[Token(Token = "0x4000172")]
			[FieldOffset(Offset = "0x0")]
			public MethodBase method;

			[Token(Token = "0x60001FE")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60001FF")]
			internal object _003CCreateMethodCall_003Eb__0(T o, object[] a)
			{
				return null;
			}

			[Token(Token = "0x6000200")]
			internal object _003CCreateMethodCall_003Eb__1(T o, object[] a)
			{
				return null;
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5C4", Offset = "0x80E5C4")]
		private sealed class _003C_003Ec__DisplayClass5_0<T>
		{
			[Token(Token = "0x4000173")]
			[FieldOffset(Offset = "0x0")]
			public Type type;

			[Token(Token = "0x4000174")]
			[FieldOffset(Offset = "0x0")]
			public ConstructorInfo constructorInfo;

			[Token(Token = "0x6000201")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000202")]
			internal T _003CCreateDefaultConstructor_003Eb__0()
			{
				return (T)null;
			}

			[Token(Token = "0x6000203")]
			internal T _003CCreateDefaultConstructor_003Eb__1()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5D4", Offset = "0x80E5D4")]
		private sealed class _003C_003Ec__DisplayClass6_0<T>
		{
			[Token(Token = "0x4000175")]
			[FieldOffset(Offset = "0x0")]
			public PropertyInfo propertyInfo;

			[Token(Token = "0x6000204")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000205")]
			internal object _003CCreateGet_003Eb__0(T o)
			{
				return null;
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5E4", Offset = "0x80E5E4")]
		private sealed class _003C_003Ec__DisplayClass7_0<T>
		{
			[Token(Token = "0x4000176")]
			[FieldOffset(Offset = "0x0")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x6000206")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000207")]
			internal object _003CCreateGet_003Eb__0(T o)
			{
				return null;
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E5F4", Offset = "0x80E5F4")]
		private sealed class _003C_003Ec__DisplayClass8_0<T>
		{
			[Token(Token = "0x4000177")]
			[FieldOffset(Offset = "0x0")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x6000208")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000209")]
			internal void _003CCreateSet_003Eb__0(T o, object v)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E604", Offset = "0x80E604")]
		private sealed class _003C_003Ec__DisplayClass9_0<T>
		{
			[Token(Token = "0x4000178")]
			[FieldOffset(Offset = "0x0")]
			public PropertyInfo propertyInfo;

			[Token(Token = "0x600020A")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600020B")]
			internal void _003CCreateSet_003Eb__0(T o, object v)
			{
			}
		}

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LateBoundReflectionDelegateFactory _instance;

		[Token(Token = "0x1700005A")]
		internal static ReflectionDelegateFactory Instance
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x176C238", Offset = "0x176C238", VA = "0x176C238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x176C2A0", Offset = "0x176C2A0", VA = "0x176C2A0", Slot = "5")]
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x176C4A0", Offset = "0x176C4A0", VA = "0x176C4A0")]
		public LateBoundReflectionDelegateFactory()
		{
		}
	}
}
