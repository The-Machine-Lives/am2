using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000151")]
public class HoverToggle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x18")]
	public GameObject toolTipObject;

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x986538", Offset = "0x986538", VA = "0x986538")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x98656C", Offset = "0x98656C", VA = "0x98656C")]
	private void Update()
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x9865BC", Offset = "0x9865BC", VA = "0x9865BC", Slot = "8")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x9865F0", Offset = "0x9865F0", VA = "0x9865F0", Slot = "9")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0x986624", Offset = "0x986624", VA = "0x986624", Slot = "10")]
	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x986658", Offset = "0x986658", VA = "0x986658", Slot = "11")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x98668C", Offset = "0x98668C", VA = "0x98668C")]
	public HoverToggle()
	{
	}
}
