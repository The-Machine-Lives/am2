using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000100")]
public class VanityTitleView : MonoBehaviour, IColorable
{
	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0xAB8B54", Offset = "0xAB8B54", VA = "0xAB8B54")]
	public void Initialize(string localizedTitle, [Optional] Color color)
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0xAB8C40", Offset = "0xAB8C40", VA = "0xAB8C40")]
	public void SetTitle(string localizedTitle)
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0xAB8BD8", Offset = "0xAB8BD8", VA = "0xAB8BD8", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xAB8C88", Offset = "0xAB8C88", VA = "0xAB8C88")]
	public void SetTextAnchor(TextAnchor textAnchor)
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xAB8CC0", Offset = "0xAB8CC0", VA = "0xAB8CC0")]
	public VanityTitleView()
	{
	}
}
