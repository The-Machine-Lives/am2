using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000144")]
public class BIColorPalletteDefinition
{
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x10")]
	public List<BIColorDatabase.BIColor> m_colors;

	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x18")]
	public BIColorPalletteDatabase.BIColorPallettes m_name;

	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x1C")]
	public BIColorPalletteDatabase.BIColorPalletteTypes m_type;

	[Token(Token = "0x6000919")]
	[Address(RVA = "0xA3F048", Offset = "0xA3F048", VA = "0xA3F048")]
	public List<Color> GetColors()
	{
		return null;
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0xA3F1D4", Offset = "0xA3F1D4", VA = "0xA3F1D4")]
	public BIColorPalletteDefinition()
	{
	}
}
