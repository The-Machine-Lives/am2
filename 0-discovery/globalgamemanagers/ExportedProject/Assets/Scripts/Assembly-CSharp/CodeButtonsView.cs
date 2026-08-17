using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C2")]
public class CodeButtonsView : MonoBehaviour
{
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button zeroButton;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button oneButton;

	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Button twoButton;

	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Button threeButton;

	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x38")]
	private CodeButtonController m_codeButtonController;

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xA4BB40", Offset = "0xA4BB40", VA = "0xA4BB40")]
	private void Start()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xA4BE10", Offset = "0xA4BE10", VA = "0xA4BE10")]
	private void OnZeroPressed()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xA4BE4C", Offset = "0xA4BE4C", VA = "0xA4BE4C")]
	private void OnOnePressed()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xA4BE54", Offset = "0xA4BE54", VA = "0xA4BE54")]
	private void OnTwoPressed()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xA4BE5C", Offset = "0xA4BE5C", VA = "0xA4BE5C")]
	private void OnThreePressed()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xA4BE18", Offset = "0xA4BE18", VA = "0xA4BE18")]
	private void OnButtonPressed(ECodeButtonIndex direction)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0xA4BE64", Offset = "0xA4BE64", VA = "0xA4BE64")]
	public CodeButtonsView()
	{
	}
}
