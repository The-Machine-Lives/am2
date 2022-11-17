using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000018")]
public class NativeAdClickHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1765354", Offset = "0x1765354", VA = "0x1765354", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1765358", Offset = "0x1765358", VA = "0x1765358")]
	public NativeAdClickHandler()
	{
	}
}
