using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000145")]
public static class BIColorPalletteManager
{
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x0")]
	private static BIColorPalletteDatabase m_PalletteDatabase;

	[Token(Token = "0x600091B")]
	[Address(RVA = "0xA3F1DC", Offset = "0xA3F1DC", VA = "0xA3F1DC")]
	public static List<BIColorPalletteDatabase.BIColorPallettes> GetPalettesOfType(BIColorPalletteDatabase.BIColorPalletteTypes type)
	{
		return null;
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0xA3D5E4", Offset = "0xA3D5E4", VA = "0xA3D5E4")]
	public static List<Color> GetPalletteByName(BIColorPalletteDatabase.BIColorPallettes name)
	{
		return null;
	}
}
