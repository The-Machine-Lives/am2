using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C8")]
	public class Device
	{
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E1F8", Offset = "0x82E1F8")]
		private INative _003CNative_003Ek__BackingField;

		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E208", Offset = "0x82E208")]
		private string _003CUserAgent_003Ek__BackingField;

		[Token(Token = "0x17000567")]
		public INative Native
		{
			[Token(Token = "0x6001D3E")]
			[Address(RVA = "0xA15D88", Offset = "0xA15D88", VA = "0xA15D88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8387F8", Offset = "0x8387F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0xA15D80", Offset = "0xA15D80", VA = "0xA15D80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838808", Offset = "0x838808")]
			private set
			{
			}
		}

		[Token(Token = "0x17000568")]
		public string UserAgent
		{
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0xA15D98", Offset = "0xA15D98", VA = "0xA15D98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838818", Offset = "0x838818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D41")]
			[Address(RVA = "0xA15D90", Offset = "0xA15D90", VA = "0xA15D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838828", Offset = "0x838828")]
			private set
			{
			}
		}

		[Token(Token = "0x17000569")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0xA15DA0", Offset = "0xA15DA0", VA = "0xA15DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0xA15120", Offset = "0xA15120", VA = "0xA15120")]
		public Device()
		{
		}
	}
}
