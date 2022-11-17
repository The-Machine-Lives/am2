using Il2CppDummyDll;
using UnityEngine.UI;

[Token(Token = "0x2000140")]
public class BIButton : BIBaseButton
{
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824DA4", Offset = "0x824DA4")]
	public GradientImage m_gradient;

	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0xF8")]
	public Image m_background;

	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x100")]
	public Image m_tab;

	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x108")]
	public Image m_highlight;

	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x110")]
	public Image m_lowlight;

	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x118")]
	public Shadow m_shadow;

	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x120")]
	public AM2Text m_text;

	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x128")]
	public Image m_icon;

	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x130")]
	private BIColorPalletteDatabase.BIColorPallettes oldBackgroundColor;

	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x134")]
	public BIColorPalletteDatabase.BIColorPallettes backgroundColor;

	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x138")]
	private float colorMulti;

	[Token(Token = "0x600090D")]
	[Address(RVA = "0xA3C9E4", Offset = "0xA3C9E4", VA = "0xA3C9E4")]
	public void SetIcon(string _path)
	{
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0xA3CAAC", Offset = "0xA3CAAC", VA = "0xA3CAAC")]
	public void SetText(string _text, bool _localized = true)
	{
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0xA3CB70", Offset = "0xA3CB70", VA = "0xA3CB70", Slot = "46")]
	public virtual void SetState(bool active, BIColorPalletteDatabase.BIColorPallettes _color = BIColorPalletteDatabase.BIColorPallettes.BIButton_Blue)
	{
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0xA3D068", Offset = "0xA3D068", VA = "0xA3D068", Slot = "26")]
	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0xA3D5B8", Offset = "0xA3D5B8", VA = "0xA3D5B8", Slot = "25")]
	protected override void InstantClearState()
	{
	}

	[Token(Token = "0x6000912")]
	[Address(RVA = "0xA3D094", Offset = "0xA3D094", VA = "0xA3D094")]
	private void SetBackgroundColorState(float multi)
	{
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0xA3CBA4", Offset = "0xA3CBA4", VA = "0xA3CBA4")]
	public void SetBackgroundColor(BIColorPalletteDatabase.BIColorPallettes newBackgroundColor)
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0xA3D808", Offset = "0xA3D808", VA = "0xA3D808")]
	public BIButton()
	{
	}
}
