using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000158")]
public static class AM2PaletteManager
{
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x0")]
	private static AM2PaletteDatabase m_paletteDatabase;

	[Token(Token = "0x4000875")]
	public const string c_settingsColorPlayerPrefs = "uken_local_settings_color";

	[Token(Token = "0x6000975")]
	[Address(RVA = "0xAC3BF0", Offset = "0xAC3BF0", VA = "0xAC3BF0")]
	public static Color GetColor(AM2PaletteDatabase.AM2ColorPalettes color)
	{
		return default(Color);
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0xAC3DEC", Offset = "0xAC3DEC", VA = "0xAC3DEC")]
	public static Color GetColorForSettings(int index)
	{
		return default(Color);
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0xAC3EA8", Offset = "0xAC3EA8", VA = "0xAC3EA8")]
	private static string GetDatabaseName(int index)
	{
		return null;
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0xAC3F18", Offset = "0xAC3F18", VA = "0xAC3F18")]
	public static AM2FontPaletteDefinition GetFontDefinition(AM2PaletteDatabase.AM2FontPalettes font)
	{
		return null;
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0xAC4018", Offset = "0xAC4018", VA = "0xAC4018")]
	public static AM2ImagePaletteDefinition GetImageDefinition(AM2PaletteDatabase.AM2ImagePalettes image)
	{
		return null;
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0xAC4118", Offset = "0xAC4118", VA = "0xAC4118")]
	public static void SetColorIndex(int colorIndex)
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0xAC4174", Offset = "0xAC4174", VA = "0xAC4174")]
	public static int GetColorIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0xAC3CF0", Offset = "0xAC3CF0", VA = "0xAC3CF0")]
	private static void SetColorDatabase()
	{
	}
}
