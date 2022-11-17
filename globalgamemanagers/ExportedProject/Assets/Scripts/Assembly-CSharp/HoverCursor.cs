using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000150")]
public class HoverCursor : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x986524", Offset = "0x986524", VA = "0x986524")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x986528", Offset = "0x986528", VA = "0x986528", Slot = "6")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000956")]
	[Address(RVA = "0x98652C", Offset = "0x98652C", VA = "0x98652C", Slot = "7")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x986530", Offset = "0x986530", VA = "0x986530")]
	public HoverCursor()
	{
	}
}
