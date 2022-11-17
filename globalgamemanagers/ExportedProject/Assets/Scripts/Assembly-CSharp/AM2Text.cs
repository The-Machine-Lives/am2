using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x200013A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x81E75C", Offset = "0x81E75C")]
public class AM2Text : LocalizedText
{
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	protected bool useFontPalette;

	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0xE1")]
	[SerializeField]
	protected bool useColorPalette;

	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2FontPalettes fontPalette;

	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	protected AM2PaletteDatabase.AM2ColorPalettes fontColorPalette;

	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0xEC")]
	public bool isLocalized;

	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0xED")]
	public bool bounceTextOnUpdate;

	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0xEE")]
	private bool bDirtyText;

	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0xF0")]
	private UkenAnimChain chain;

	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0xF8")]
	private string oldTagString;

	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Attribute(Name = "TextAreaAttribute", RVA = "0x824D14", Offset = "0x824D14")]
	private string m_LocalizedTag;

	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824D4C", Offset = "0x824D4C")]
	public Vector2 textScaleFactor;

	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x110")]
	public float durationOfAnimIntro;

	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x114")]
	public UkenAnimEaseType easeOfAnimIntro;

	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x118")]
	public float durationOfAnimOutro;

	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x11C")]
	public UkenAnimEaseType easeOfAnimOutro;

	[Token(Token = "0x17000106")]
	public string localizedTag
	{
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xAC5510", Offset = "0xAC5510", VA = "0xAC5510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0xAC5518", Offset = "0xAC5518", VA = "0xAC5518", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0xAC55D0", Offset = "0xAC55D0", VA = "0xAC55D0")]
	public void EnableColorPalette()
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0xAC55E8", Offset = "0xAC55E8", VA = "0xAC55E8")]
	public void DisableColorPalette()
	{
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0xAC5540", Offset = "0xAC5540", VA = "0xAC5540")]
	public void ApplyPalette()
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0xAC55F0", Offset = "0xAC55F0", VA = "0xAC55F0")]
	public void ApplyColorPalette(AM2PaletteDatabase.AM2ColorPalettes inFontColorPalette)
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0xAC5624", Offset = "0xAC5624", VA = "0xAC5624", Slot = "83")]
	public virtual void SetText(string newLocalizationTag, bool bNeedsLocalization = true, bool bounceTextOnUpdate = false)
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0xAC5990", Offset = "0xAC5990", VA = "0xAC5990")]
	private void ApplyBounceAnimation()
	{
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0xAC5C80", Offset = "0xAC5C80", VA = "0xAC5C80")]
	private void FixBadAnimationCurves()
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0xAC56E0", Offset = "0xAC56E0", VA = "0xAC56E0")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0xAC5CAC", Offset = "0xAC5CAC", VA = "0xAC5CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0xAC5CBC", Offset = "0xAC5CBC", VA = "0xAC5CBC")]
	public AM2Text()
	{
	}
}
