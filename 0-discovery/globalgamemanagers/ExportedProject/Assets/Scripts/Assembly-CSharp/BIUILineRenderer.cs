using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000152")]
public class BIUILineRenderer : MaskableGraphic, ILayoutElement
{
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824E0C", Offset = "0x824E0C")]
	public float m_LineWidth;

	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0xB4")]
	public float m_LineSegments;

	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824E44", Offset = "0x824E44")]
	public RectTransform[] m_LinePositions;

	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824E7C", Offset = "0x824E7C")]
	public bool m_SnapTogetherControlPoints;

	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x824EB4", Offset = "0x824EB4")]
	public Gradient m_Gradient;

	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0xD0")]
	public bool m_UseGradient;

	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0xD8")]
	public AnimationCurve m_SizeCurve;

	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0xE0")]
	public bool m_UseSizeCurve;

	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0xE4")]
	[Attribute(Name = "RangeAttribute", RVA = "0x824EEC", Offset = "0x824EEC")]
	public float m_VisibleFraction;

	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3[] points;

	[Token(Token = "0x1700010A")]
	public virtual float minWidth
	{
		[Token(Token = "0x6000964")]
		[Address(RVA = "0xA44660", Offset = "0xA44660", VA = "0xA44660", Slot = "74")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700010B")]
	public virtual float preferredWidth
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0xA44668", Offset = "0xA44668", VA = "0xA44668", Slot = "75")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700010C")]
	public virtual float flexibleWidth
	{
		[Token(Token = "0x6000966")]
		[Address(RVA = "0xA44670", Offset = "0xA44670", VA = "0xA44670", Slot = "76")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700010D")]
	public virtual float minHeight
	{
		[Token(Token = "0x6000967")]
		[Address(RVA = "0xA44678", Offset = "0xA44678", VA = "0xA44678", Slot = "77")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700010E")]
	public virtual float preferredHeight
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0xA44680", Offset = "0xA44680", VA = "0xA44680", Slot = "78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700010F")]
	public virtual float flexibleHeight
	{
		[Token(Token = "0x6000969")]
		[Address(RVA = "0xA44688", Offset = "0xA44688", VA = "0xA44688", Slot = "79")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000110")]
	public virtual int layoutPriority
	{
		[Token(Token = "0x600096A")]
		[Address(RVA = "0xA44690", Offset = "0xA44690", VA = "0xA44690", Slot = "80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0xA43BE0", Offset = "0xA43BE0", VA = "0xA43BE0")]
	private bool IsControlPoint(int i)
	{
		return default(bool);
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0xA43C0C", Offset = "0xA43C0C", VA = "0xA43C0C")]
	public void AdjustedLine(int i)
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0xA43D78", Offset = "0xA43D78", VA = "0xA43D78", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0xA44658", Offset = "0xA44658", VA = "0xA44658", Slot = "72")]
	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0xA4465C", Offset = "0xA4465C", VA = "0xA4465C", Slot = "73")]
	public virtual void CalculateLayoutInputVertical()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0xA44698", Offset = "0xA44698", VA = "0xA44698")]
	public BIUILineRenderer()
	{
	}
}
