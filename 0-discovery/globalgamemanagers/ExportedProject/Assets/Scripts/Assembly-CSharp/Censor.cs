using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E3")]
public class Censor : MonoBehaviour
{
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x18")]
	private IList<string> CensoredWords;

	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x20")]
	private IList<string> OKWords;

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0xA47E64", Offset = "0xA47E64", VA = "0xA47E64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0xA4803C", Offset = "0xA4803C", VA = "0xA4803C")]
	public string CensorText(string text)
	{
		return null;
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0xA4807C", Offset = "0xA4807C", VA = "0xA4807C")]
	private string checkThisText(string text)
	{
		return null;
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0xA48CC4", Offset = "0xA48CC4", VA = "0xA48CC4")]
	private string checkNumbers(string input)
	{
		return null;
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0xA48CEC", Offset = "0xA48CEC", VA = "0xA48CEC")]
	private string checkForInterspersedNumbers(string input)
	{
		return null;
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0xA4891C", Offset = "0xA4891C", VA = "0xA4891C")]
	private string checkForLeet(string input)
	{
		return null;
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0xA48DB4", Offset = "0xA48DB4", VA = "0xA48DB4")]
	private string checkForReverses(string input)
	{
		return null;
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0xA48E08", Offset = "0xA48E08", VA = "0xA48E08")]
	private string Reverse(string s)
	{
		return null;
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0xA48E54", Offset = "0xA48E54", VA = "0xA48E54")]
	public Censor()
	{
	}
}
