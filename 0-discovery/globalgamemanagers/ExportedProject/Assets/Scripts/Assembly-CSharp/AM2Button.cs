using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000134")]
public class AM2Button : BIBaseButton
{
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public bool useFontColorPalette;

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0xF1")]
	[SerializeField]
	public bool useImageColorPalette;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	public AM2PaletteDatabase.AM2ColorPalettes disabledTextColorPalette;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public AM2PaletteDatabase.AM2ColorPalettes enabledTextColorPalette;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	public AM2PaletteDatabase.AM2ColorPalettes disabledImageColorPalette;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public AM2PaletteDatabase.AM2ColorPalettes enabledImageColorPalette;

	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public AM2Text m_buttonText;

	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public Color m_disabledTextColor;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public Color m_enabledTextColor;

	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public AM2ButtonImage m_additionalImage;

	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x138")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824B4C", Offset = "0x824B4C")]
	private ButtonClickedEvent _003ConPointerDown_003Ek__BackingField;

	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824B5C", Offset = "0x824B5C")]
	private ButtonClickedEvent _003ConPointerUp_003Ek__BackingField;

	[Token(Token = "0x17000104")]
	public ButtonClickedEvent onPointerDown
	{
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x9795E0", Offset = "0x9795E0", VA = "0x9795E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834458", Offset = "0x834458")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x9795E8", Offset = "0x9795E8", VA = "0x9795E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834468", Offset = "0x834468")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000105")]
	public ButtonClickedEvent onPointerUp
	{
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x9795F0", Offset = "0x9795F0", VA = "0x9795F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834478", Offset = "0x834478")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x9795F8", Offset = "0x9795F8", VA = "0x9795F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834488", Offset = "0x834488")]
		protected set
		{
		}
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x979600", Offset = "0x979600", VA = "0x979600", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x9798C0", Offset = "0x9798C0", VA = "0x9798C0")]
	public void SetEnabledColorPalette(AM2PaletteDatabase.AM2ColorPalettes colorPalette, bool applyPalette)
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x979640", Offset = "0x979640", VA = "0x979640")]
	public void ApplyPalette()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x9797FC", Offset = "0x9797FC", VA = "0x9797FC")]
	public void SetInteractable(bool inInteractable)
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x979A48", Offset = "0x979A48", VA = "0x979A48", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x979A84", Offset = "0x979A84", VA = "0x979A84", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x9798D0", Offset = "0x9798D0", VA = "0x9798D0")]
	private void SetButtonTextColor()
	{
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x979514", Offset = "0x979514", VA = "0x979514")]
	public AM2Button()
	{
	}
}
