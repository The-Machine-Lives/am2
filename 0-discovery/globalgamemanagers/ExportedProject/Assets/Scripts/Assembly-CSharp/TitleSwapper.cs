using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000FF")]
public class TitleSwapper : ColoredPrefabSwapper<VanityTitleView>
{
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823B74", Offset = "0x823B74")]
	private Dye _003CcurrentDye_003Ek__BackingField;

	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextAnchor m_textAnchor;

	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x58")]
	private string m_localizedTitle;

	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x60")]
	private BadgeItem m_currentBadgeItem;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x68")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x170000E2")]
	public Dye currentDye
	{
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xA14708", Offset = "0xA14708", VA = "0xA14708")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834050", Offset = "0x834050")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xA14710", Offset = "0xA14710", VA = "0xA14710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834060", Offset = "0x834060")]
		private set
		{
		}
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xA14718", Offset = "0xA14718", VA = "0xA14718")]
	public void Initialize(Dye dye, string localizedTitle)
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xA14844", Offset = "0xA14844", VA = "0xA14844", Slot = "5")]
	public override void OnCurrentPrefabInstantiated()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xA1489C", Offset = "0xA1489C", VA = "0xA1489C")]
	public void SetTitle(string localizedTitle)
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0xA148A4", Offset = "0xA148A4", VA = "0xA148A4")]
	public void UpdateWithDye(Dye dye)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xA147DC", Offset = "0xA147DC", VA = "0xA147DC")]
	private void RefreshTitle()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0xA14990", Offset = "0xA14990", VA = "0xA14990")]
	public TitleSwapper()
	{
	}
}
