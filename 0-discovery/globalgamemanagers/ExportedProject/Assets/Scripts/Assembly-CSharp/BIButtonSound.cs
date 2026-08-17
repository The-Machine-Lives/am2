using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000B7")]
[Attribute(Name = "RequireComponent", RVA = "0x81E648", Offset = "0x81E648")]
public class BIButtonSound : MonoBehaviour
{
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x18")]
	public BISoundEvents.EventKey soundEvent;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x20")]
	private Button m_oButton;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xA3D80C", Offset = "0xA3D80C", VA = "0xA3D80C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xA3D934", Offset = "0xA3D934", VA = "0xA3D934")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xA3DA2C", Offset = "0xA3DA2C", VA = "0xA3DA2C")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xA3DB38", Offset = "0xA3DB38", VA = "0xA3DB38")]
	public BIButtonSound()
	{
	}
}
