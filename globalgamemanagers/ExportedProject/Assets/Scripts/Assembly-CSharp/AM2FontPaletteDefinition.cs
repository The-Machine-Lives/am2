using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000156")]
public class AM2FontPaletteDefinition
{
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x10")]
	public AM2PaletteDatabase.AM2FontPalettes name;

	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x14")]
	public int fontSize;

	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Font font;

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x979C00", Offset = "0x979C00", VA = "0x979C00")]
	public AM2FontPaletteDefinition()
	{
	}
}
