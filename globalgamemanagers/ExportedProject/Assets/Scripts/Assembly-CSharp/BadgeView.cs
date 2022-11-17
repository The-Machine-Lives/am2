using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F6")]
public class BadgeView : MonoBehaviour, IColorable
{
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image m_backgroundImage;

	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Image m_iconImage;

	[Token(Token = "0x600068B")]
	[Address(RVA = "0xA45CCC", Offset = "0xA45CCC", VA = "0xA45CCC", Slot = "5")]
	public virtual void SetSprite(Sprite sprite)
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xA45D8C", Offset = "0xA45D8C", VA = "0xA45D8C", Slot = "6")]
	public virtual void SetColor(Color color)
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0xA45DF4", Offset = "0xA45DF4", VA = "0xA45DF4")]
	public BadgeView()
	{
	}
}
