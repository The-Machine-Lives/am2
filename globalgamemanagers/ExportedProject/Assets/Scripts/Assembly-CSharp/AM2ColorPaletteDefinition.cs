using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000155")]
public class AM2ColorPaletteDefinition
{
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x10")]
	public AM2PaletteDatabase.AM2ColorPalettes name;

	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x979B7C", Offset = "0x979B7C", VA = "0x979B7C")]
	public AM2ColorPaletteDefinition()
	{
	}
}
