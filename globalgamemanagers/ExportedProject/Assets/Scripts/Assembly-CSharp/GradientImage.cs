using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014F")]
public class GradientImage : MaskableGraphic
{
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0xB0")]
	public Color32 BottomLeft;

	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0xB4")]
	public Color32 TopLeft;

	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0xB8")]
	public Color32 BottomRight;

	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0xBC")]
	public Color32 TopRight;

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x9857C8", Offset = "0x9857C8", VA = "0x9857C8", Slot = "43")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83452C", Offset = "0x83452C")]
	protected override void OnPopulateMesh(Mesh m)
	{
	}

	[Token(Token = "0x6000951")]
	[Address(RVA = "0x985B08", Offset = "0x985B08", VA = "0x985B08")]
	private Vector4 GetDrawingDimensions()
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x985BCC", Offset = "0x985BCC", VA = "0x985BCC")]
	public void UpdateGradient()
	{
	}

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x985BDC", Offset = "0x985BDC", VA = "0x985BDC")]
	public GradientImage()
	{
	}
}
