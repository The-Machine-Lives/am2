using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000F0")]
public class AutoScrollableView : MonoBehaviour
{
	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected BIScrollPanel m_scrollView;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected RectTransform m_scrollContent;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x28")]
	protected AutoScroller m_autoScroller;

	[Token(Token = "0x600066C")]
	[Address(RVA = "0xA3B344", Offset = "0xA3B344", VA = "0xA3B344")]
	public void OnClickSelectItem(RectTransform clickedTransform)
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0xA3B8A4", Offset = "0xA3B8A4", VA = "0xA3B8A4")]
	public AutoScrollableView()
	{
	}
}
