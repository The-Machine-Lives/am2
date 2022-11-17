using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000141")]
public class BIColorDatabase : ScriptableObject
{
	[Token(Token = "0x2000639")]
	public enum BIColor
	{
		[Token(Token = "0x4001E7E")]
		None = 0,
		[Token(Token = "0x4001E7F")]
		InfinityButtonBlue_Base = 1,
		[Token(Token = "0x4001E80")]
		InfinityButtonBlue_Secondary = 2,
		[Token(Token = "0x4001E81")]
		InfinityButtonBlue_Highlight = 3,
		[Token(Token = "0x4001E82")]
		InfinityButtonBlue_Lowlight = 4,
		[Token(Token = "0x4001E83")]
		InfinityButtonBlue_Gradient = 5,
		[Token(Token = "0x4001E84")]
		InfinityButtonBlue_Shadow = 6,
		[Token(Token = "0x4001E85")]
		InfinityButtonRed_Base = 7,
		[Token(Token = "0x4001E86")]
		InfinityButtonRed_Secondary = 8,
		[Token(Token = "0x4001E87")]
		InfinityButtonRed_Highlight = 9,
		[Token(Token = "0x4001E88")]
		InfinityButtonRed_Lowlight = 10,
		[Token(Token = "0x4001E89")]
		InfinityButtonRed_Gradient = 11,
		[Token(Token = "0x4001E8A")]
		InfinityButtonRed_Shadow = 12,
		[Token(Token = "0x4001E8B")]
		InfinityButtonGreen_Base = 13,
		[Token(Token = "0x4001E8C")]
		InfinityButtonGreen_Secondary = 14,
		[Token(Token = "0x4001E8D")]
		InfinityButtonGreen_Highlight = 15,
		[Token(Token = "0x4001E8E")]
		InfinityButtonGreen_Lowlight = 16,
		[Token(Token = "0x4001E8F")]
		InfinityButtonGreen_Gradient = 17,
		[Token(Token = "0x4001E90")]
		InfinityButtonGreen_Shadow = 18,
		[Token(Token = "0x4001E91")]
		InfinityButtonYellow_Base = 19,
		[Token(Token = "0x4001E92")]
		InfinityButtonYellow_Secondary = 20,
		[Token(Token = "0x4001E93")]
		InfinityButtonYellow_Highlight = 21,
		[Token(Token = "0x4001E94")]
		InfinityButtonYellow_Lowlight = 22,
		[Token(Token = "0x4001E95")]
		InfinityButtonYellow_Gradient = 23,
		[Token(Token = "0x4001E96")]
		InfinityButtonYellow_Shadow = 24,
		[Token(Token = "0x4001E97")]
		InfinityButtonDarkBlue_Base = 25,
		[Token(Token = "0x4001E98")]
		InfinityButtonDarkBlue_Secondary = 26,
		[Token(Token = "0x4001E99")]
		InfinityButtonDarkBlue_Highlight = 27,
		[Token(Token = "0x4001E9A")]
		InfinityButtonDarkBlue_Lowlight = 28,
		[Token(Token = "0x4001E9B")]
		InfinityButtonDarkBlue_Gradient = 29,
		[Token(Token = "0x4001E9C")]
		InfinityButtonDarkBlue_Shadow = 30,
		[Token(Token = "0x4001E9D")]
		InfinityRarityCommon_Base = 31,
		[Token(Token = "0x4001E9E")]
		InfinityRarityCommon_Secondary = 32,
		[Token(Token = "0x4001E9F")]
		InfinityRarityCommon_Highlight = 33,
		[Token(Token = "0x4001EA0")]
		InfinityRarityCommon_Lowlight = 34,
		[Token(Token = "0x4001EA1")]
		InfinityRarityCommon_Gradient = 35,
		[Token(Token = "0x4001EA2")]
		InfinityRarityCommon_Shadow = 36,
		[Token(Token = "0x4001EA3")]
		InfinityRarityUncommon_Base = 37,
		[Token(Token = "0x4001EA4")]
		InfinityRarityUncommon_Secondary = 38,
		[Token(Token = "0x4001EA5")]
		InfinityRarityUncommon_Highlight = 39,
		[Token(Token = "0x4001EA6")]
		InfinityRarityUncommon_Lowlight = 40,
		[Token(Token = "0x4001EA7")]
		InfinityRarityUncommon_Gradient = 41,
		[Token(Token = "0x4001EA8")]
		InfinityRarityUncommon_Shadow = 42,
		[Token(Token = "0x4001EA9")]
		InfinityRarityRare_Base = 43,
		[Token(Token = "0x4001EAA")]
		InfinityRarityRare_Secondary = 44,
		[Token(Token = "0x4001EAB")]
		InfinityRarityRare_Highlight = 45,
		[Token(Token = "0x4001EAC")]
		InfinityRarityRare_Lowlight = 46,
		[Token(Token = "0x4001EAD")]
		InfinityRarityRare_Gradient = 47,
		[Token(Token = "0x4001EAE")]
		InfinityRarityRare_Shadow = 48,
		[Token(Token = "0x4001EAF")]
		InfinityRarityEpic_Base = 49,
		[Token(Token = "0x4001EB0")]
		InfinityRarityEpic_Secondary = 50,
		[Token(Token = "0x4001EB1")]
		InfinityRarityEpic_Highlight = 51,
		[Token(Token = "0x4001EB2")]
		InfinityRarityEpic_Lowlight = 52,
		[Token(Token = "0x4001EB3")]
		InfinityRarityEpic_Gradient = 53,
		[Token(Token = "0x4001EB4")]
		InfinityRarityEpic_Shadow = 54,
		[Token(Token = "0x4001EB5")]
		InfinityRarityLegendary_Base = 55,
		[Token(Token = "0x4001EB6")]
		InfinityRarityLegendary_Secondary = 56,
		[Token(Token = "0x4001EB7")]
		InfinityRarityLegendary_Highlight = 57,
		[Token(Token = "0x4001EB8")]
		InfinityRarityLegendary_Lowlight = 58,
		[Token(Token = "0x4001EB9")]
		InfinityRarityLegendary_Gradient = 59,
		[Token(Token = "0x4001EBA")]
		InfinityRarityLegendary_Shadow = 60,
		[Token(Token = "0x4001EBB")]
		InfinityRarityMaster_Base = 61,
		[Token(Token = "0x4001EBC")]
		InfinityRarityMaster_Secondary = 62,
		[Token(Token = "0x4001EBD")]
		InfinityRarityMaster_Highlight = 63,
		[Token(Token = "0x4001EBE")]
		InfinityRarityMaster_Lowlight = 64,
		[Token(Token = "0x4001EBF")]
		InfinityRarityMaster_Gradient = 65,
		[Token(Token = "0x4001EC0")]
		InfinityRarityMaster_Shadow = 66,
		[Token(Token = "0x4001EC1")]
		InfinityButtonGray_Base = 67,
		[Token(Token = "0x4001EC2")]
		InfinityButtonGray_Secondary = 68,
		[Token(Token = "0x4001EC3")]
		InfinityButtonGray_Highlight = 69,
		[Token(Token = "0x4001EC4")]
		InfinityButtonGray_Lowlight = 70,
		[Token(Token = "0x4001EC5")]
		InfinityButtonGray_Gradient = 71,
		[Token(Token = "0x4001EC6")]
		InfinityButtonGray_Shadow = 72
	}

	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<Color> m_ColorList;

	[Token(Token = "0x17000108")]
	public static int ColorCount
	{
		[Token(Token = "0x6000915")]
		[Address(RVA = "0xA3ECC0", Offset = "0xA3ECC0", VA = "0xA3ECC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000916")]
	[Address(RVA = "0xA3EDEC", Offset = "0xA3EDEC", VA = "0xA3EDEC")]
	public BIColorDatabase()
	{
	}
}
