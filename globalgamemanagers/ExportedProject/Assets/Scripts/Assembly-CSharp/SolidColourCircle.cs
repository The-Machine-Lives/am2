using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200015A")]
[ExecuteInEditMode]
public class SolidColourCircle : Graphic
{
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x7C")]
	public int m_sides;

	[Token(Token = "0x6000981")]
	[Address(RVA = "0xA03840", Offset = "0xA03840", VA = "0xA03840")]
	private float DegreeToRadian(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0xA03850", Offset = "0xA03850", VA = "0xA03850", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0xA03DA4", Offset = "0xA03DA4", VA = "0xA03DA4")]
	public SolidColourCircle()
	{
	}
}
