using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014E")]
public class GradientEffect : BaseMeshEffect
{
	[Token(Token = "0x2000640")]
	public enum GradientOrientations
	{
		[Token(Token = "0x4001EE2")]
		Horizontal = 0,
		[Token(Token = "0x4001EE3")]
		Vertical = 1
	}

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x20")]
	public Color m_ColorOne;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x30")]
	public Color m_ColorTwo;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x40")]
	public bool isText;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x41")]
	public bool useObjectSpace;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x44")]
	public GradientOrientations m_Orientation;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x48")]
	private int vertNum;

	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x4C")]
	private UIVertex c;

	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x98")]
	private List<UIVertex> vertStream;

	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0xA0")]
	private int[] m_TextTop;

	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0xA8")]
	private int[] m_ImageLeft;

	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0xB0")]
	private int[] m_ImageTop;

	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0xB8")]
	private int[] m_use;

	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0xC0")]
	private float minAxis;

	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0xC4")]
	private float maxAxis;

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x984F04", Offset = "0x984F04", VA = "0x984F04", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x985620", Offset = "0x985620", VA = "0x985620")]
	public GradientEffect()
	{
	}
}
