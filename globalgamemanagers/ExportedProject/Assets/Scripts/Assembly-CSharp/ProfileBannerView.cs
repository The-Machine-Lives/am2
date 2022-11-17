using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A5")]
public class ProfileBannerView : BadgeView
{
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image[] m_bannerBits;

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x9E256C", Offset = "0x9E256C", VA = "0x9E256C", Slot = "6")]
	public override void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x9E2628", Offset = "0x9E2628", VA = "0x9E2628")]
	public ProfileBannerView()
	{
	}
}
