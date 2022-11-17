using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x200009C")]
public class AM2Environment : CasualEnvironment
{
	[Serializable]
	[Token(Token = "0x2000611")]
	public class DebugABTest
	{
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x10")]
		public string testName;

		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x18")]
		public string groupName;

		[Token(Token = "0x6002CE0")]
		[Address(RVA = "0x979BF8", Offset = "0x979BF8", VA = "0x979BF8")]
		public DebugABTest()
		{
		}
	}

	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x12D")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x822304", Offset = "0x822304")]
	public bool DebugEnableInventoryCrashOnMissingMinimalDetails;

	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x12E")]
	public bool DebugBanImmune;

	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x130")]
	public List<DebugABTest> DebugABTests;

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x979B84", Offset = "0x979B84", VA = "0x979B84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x979B88", Offset = "0x979B88", VA = "0x979B88")]
	public AM2Environment()
	{
	}
}
