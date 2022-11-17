using System;
using System.ComponentModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000B9")]
	[Preserve]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x17000100")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xFF37B4", Offset = "0xFF37B4", VA = "0xFF37B4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFF3824", Offset = "0xFF3824", VA = "0xFF3824", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000102")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFF382C", Offset = "0xFF382C", VA = "0xFF382C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		protected override int NameHashCode
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFF389C", Offset = "0xFF389C", VA = "0xFF389C", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFF2110", Offset = "0xFF2110", VA = "0xFF2110")]
		public JPropertyDescriptor(string name)
		{
		}
	}
}
