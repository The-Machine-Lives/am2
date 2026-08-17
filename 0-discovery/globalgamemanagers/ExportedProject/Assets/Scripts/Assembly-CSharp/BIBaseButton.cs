using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200013F")]
public class BIBaseButton : Button
{
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0xE0")]
	public bool PlaySound;

	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0xE4")]
	public BISoundEvents.EventKey soundEvent;

	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0xE8")]
	protected string cursorDir;

	[Token(Token = "0x6000904")]
	[Address(RVA = "0xA3C5D0", Offset = "0xA3C5D0", VA = "0xA3C5D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0xA3C688", Offset = "0xA3C688", VA = "0xA3C688", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0xA3C740", Offset = "0xA3C740", VA = "0xA3C740", Slot = "43")]
	public virtual void ClickButton()
	{
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0xA3C774", Offset = "0xA3C774", VA = "0xA3C774", Slot = "44")]
	public virtual void ButtonClicked()
	{
	}

	[Token(Token = "0x6000908")]
	[Address(RVA = "0xA3C784", Offset = "0xA3C784", VA = "0xA3C784", Slot = "45")]
	protected virtual void PlayButtonClickedSound()
	{
	}

	[Token(Token = "0x6000909")]
	[Address(RVA = "0xA3C8E8", Offset = "0xA3C8E8", VA = "0xA3C8E8", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0xA3C91C", Offset = "0xA3C91C", VA = "0xA3C91C", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0xA3C924", Offset = "0xA3C924", VA = "0xA3C924", Slot = "25")]
	protected override void InstantClearState()
	{
	}

	[Token(Token = "0x600090C")]
	[Address(RVA = "0xA3C92C", Offset = "0xA3C92C", VA = "0xA3C92C")]
	public BIBaseButton()
	{
	}
}
