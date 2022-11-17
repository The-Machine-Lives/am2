using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x200013D")]
public class AutoScroller
{
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x10")]
	private UkenAnimFloat m_autoScrollAnim;

	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform m_scrollContent;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_originalPosition;

	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824D94", Offset = "0x824D94")]
	private float _003Cduration_003Ek__BackingField;

	[Token(Token = "0x17000107")]
	public float duration
	{
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xA3B92C", Offset = "0xA3B92C", VA = "0xA3B92C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834498", Offset = "0x834498")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xA3B934", Offset = "0xA3B934", VA = "0xA3B934")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8344A8", Offset = "0x8344A8")]
		set
		{
		}
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0xA3B42C", Offset = "0xA3B42C", VA = "0xA3B42C")]
	public void AutoScrollContentTo(RectTransform toTransform, RectTransform scrollContent, BIScrollPanel scrollView)
	{
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0xA3B93C", Offset = "0xA3B93C", VA = "0xA3B93C")]
	private void OnUpdateAutoScrollX(float newXLocation)
	{
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0xA3BA08", Offset = "0xA3BA08", VA = "0xA3BA08")]
	private void OnUpdateAutoScrollY(float newYLocation)
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0xA3B918", Offset = "0xA3B918", VA = "0xA3B918")]
	public AutoScroller()
	{
	}
}
