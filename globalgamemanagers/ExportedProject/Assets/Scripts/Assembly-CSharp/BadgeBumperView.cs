using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F2")]
public class BadgeBumperView : MonoBehaviour, IColorable
{
	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image m_bumperImage;

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xA4492C", Offset = "0xA4492C", VA = "0xA4492C")]
	public void Initialize([Optional] Color color)
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0xA44994", Offset = "0xA44994", VA = "0xA44994", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0xA449FC", Offset = "0xA449FC", VA = "0xA449FC")]
	public BadgeBumperView()
	{
	}
}
