using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000143")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x81E798", Offset = "0x81E798")]
public class BIColorPalletteDatabase : ScriptableObject
{
	[Token(Token = "0x200063A")]
	public enum BIColorPallettes
	{
		[Token(Token = "0x4001EC8")]
		BIButton_Blue = 0,
		[Token(Token = "0x4001EC9")]
		BIButton_Red = 1,
		[Token(Token = "0x4001ECA")]
		BIButton_Green = 2,
		[Token(Token = "0x4001ECB")]
		BIButton_Yellow = 3,
		[Token(Token = "0x4001ECC")]
		BIButton_DarkBlue = 4,
		[Token(Token = "0x4001ECD")]
		MasteryRarity_Common = 5,
		[Token(Token = "0x4001ECE")]
		MasteryRarity_Uncommon = 6,
		[Token(Token = "0x4001ECF")]
		MasteryRarity_Rare = 7,
		[Token(Token = "0x4001ED0")]
		MasteryRarity_Epic = 8,
		[Token(Token = "0x4001ED1")]
		MasteryRarity_Legendary = 9,
		[Token(Token = "0x4001ED2")]
		MasteryRarity_Master = 10,
		[Token(Token = "0x4001ED3")]
		BIButton_Gray = 11,
		[Token(Token = "0x4001ED4")]
		PalletteCount = 12,
		[Token(Token = "0x4001ED5")]
		Null = 13
	}

	[Token(Token = "0x200063B")]
	public enum BIColorPalletteTypes
	{
		[Token(Token = "0x4001ED7")]
		BIButton = 0,
		[Token(Token = "0x4001ED8")]
		MasteryRarity = 1,
		[Token(Token = "0x4001ED9")]
		TypeCount = 2
	}

	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<BIColorPalletteDefinition> m_pallettes;

	[Token(Token = "0x6000918")]
	[Address(RVA = "0xA3F040", Offset = "0xA3F040", VA = "0xA3F040")]
	public BIColorPalletteDatabase()
	{
	}
}
