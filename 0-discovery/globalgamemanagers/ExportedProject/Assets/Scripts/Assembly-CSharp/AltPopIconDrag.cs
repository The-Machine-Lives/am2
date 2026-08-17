using Il2CppDummyDll;
using UnityEngine.EventSystems;

[Token(Token = "0x2000064")]
public class AltPopIconDrag : EventTrigger
{
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x28")]
	private bool dragging;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x30")]
	private bool pressed;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xAD4178", Offset = "0xAD4178", VA = "0xAD4178")]
	public void Update()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xAD42A4", Offset = "0xAD42A4", VA = "0xAD42A4", Slot = "25")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xAD42B0", Offset = "0xAD42B0", VA = "0xAD42B0", Slot = "26")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xAD42C0", Offset = "0xAD42C0", VA = "0xAD42C0")]
	public AltPopIconDrag()
	{
	}
}
