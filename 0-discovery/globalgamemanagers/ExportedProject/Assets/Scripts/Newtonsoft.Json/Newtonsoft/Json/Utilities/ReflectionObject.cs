using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200004F")]
	[Preserve]
	internal class ReflectionObject
	{
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E644", Offset = "0x80E644")]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x10")]
			public Func<object> ctor;

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x176E490", Offset = "0x176E490", VA = "0x176E490")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x176ECB0", Offset = "0x176ECB0", VA = "0x176ECB0")]
			internal object _003CCreate_003Eb__0(object[] args)
			{
				return null;
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E654", Offset = "0x80E654")]
		private sealed class _003C_003Ec__DisplayClass13_1
		{
			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x176E904", Offset = "0x176E904", VA = "0x176E904")]
			public _003C_003Ec__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x176ED10", Offset = "0x176ED10", VA = "0x176ED10")]
			internal object _003CCreate_003Eb__1(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E664", Offset = "0x80E664")]
		private sealed class _003C_003Ec__DisplayClass13_2
		{
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x176E90C", Offset = "0x176E90C", VA = "0x176E90C")]
			public _003C_003Ec__DisplayClass13_2()
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x176ED9C", Offset = "0x176ED9C", VA = "0x176ED9C")]
			internal void _003CCreate_003Eb__2(object target, object arg)
			{
			}
		}

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F748", Offset = "0x80F748")]
		private ObjectConstructor<object> _003CCreator_003Ek__BackingField;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F758", Offset = "0x80F758")]
		private IDictionary<string, ReflectionMember> _003CMembers_003Ek__BackingField;

		[Token(Token = "0x1700005E")]
		public ObjectConstructor<object> Creator
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x176D7B0", Offset = "0x176D7B0", VA = "0x176D7B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8101D8", Offset = "0x8101D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x176D7B8", Offset = "0x176D7B8", VA = "0x176D7B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8101E8", Offset = "0x8101E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public IDictionary<string, ReflectionMember> Members
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x176D7C0", Offset = "0x176D7C0", VA = "0x176D7C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8101F8", Offset = "0x8101F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x176D7C8", Offset = "0x176D7C8", VA = "0x176D7C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810208", Offset = "0x810208")]
			private set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x176D7D0", Offset = "0x176D7D0", VA = "0x176D7D0")]
		public ReflectionObject()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x176D844", Offset = "0x176D844", VA = "0x176D844")]
		public object GetValue(object target, string member)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x176D940", Offset = "0x176D940", VA = "0x176D940")]
		public Type GetType(string member)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x176DA18", Offset = "0x176DA18", VA = "0x176DA18")]
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x176DA28", Offset = "0x176DA28", VA = "0x176DA28")]
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			return null;
		}
	}
}
