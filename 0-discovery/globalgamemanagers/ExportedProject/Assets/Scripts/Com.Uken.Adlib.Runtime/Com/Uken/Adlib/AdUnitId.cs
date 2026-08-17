using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000008")]
	public class AdUnitId
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8138F8", Offset = "0x8138F8")]
		private string _003CAndroid_003Ek__BackingField;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813908", Offset = "0x813908")]
		private string _003CIOS_003Ek__BackingField;

		[Token(Token = "0x17000008")]
		public string Android
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x17D35D8", Offset = "0x17D35D8", VA = "0x17D35D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813958", Offset = "0x813958")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x17D35C8", Offset = "0x17D35C8", VA = "0x17D35C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813968", Offset = "0x813968")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string IOS
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x17D35E0", Offset = "0x17D35E0", VA = "0x17D35E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813978", Offset = "0x813978")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17D35D0", Offset = "0x17D35D0", VA = "0x17D35D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x813988", Offset = "0x813988")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public string Id
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x17D353C", Offset = "0x17D353C", VA = "0x17D353C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17D3590", Offset = "0x17D3590", VA = "0x17D3590")]
		public AdUnitId([Optional] string android, [Optional] string ios)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17D35E8", Offset = "0x17D35E8", VA = "0x17D35E8")]
		public bool HasAdUnitId(string adUnitId)
		{
			return default(bool);
		}
	}
}
