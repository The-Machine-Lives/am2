using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000209")]
public class CasualOffsetObject : MonoBehaviour
{
	[Token(Token = "0x200066A")]
	private enum AdjustmentMode
	{
		[Token(Token = "0x4001FA7")]
		None = 0,
		[Token(Token = "0x4001FA8")]
		iPhoneX = 1
	}

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform m_Rect;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_LocalPosition;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 m_AnchoredPosition;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 m_SizeDelta;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x40")]
	private CasualViewBase m_parent;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x48")]
	private AdjustmentMode m_adjustmentMode;

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0xA47C1C", Offset = "0xA47C1C", VA = "0xA47C1C")]
	public void Setup(CasualViewBase parent)
	{
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0xA47D4C", Offset = "0xA47D4C", VA = "0xA47D4C")]
	public void SetTargetParameters()
	{
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0xA47E1C", Offset = "0xA47E1C", VA = "0xA47E1C")]
	public CasualOffsetObject()
	{
	}
}
