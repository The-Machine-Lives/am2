using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200012D")]
public class DictionaryHelper
{
	[Token(Token = "0x2000637")]
	public enum EDictAddType
	{
		[Token(Token = "0x4001E76")]
		Add = 0,
		[Token(Token = "0x4001E77")]
		Subtract = 1,
		[Token(Token = "0x4001E78")]
		Max = 2
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x9C17C0", Offset = "0x9C17C0", VA = "0x9C17C0")]
	public static void AddToDictionaryByAddition(Dictionary<string, long> destinationDict, Dictionary<string, long> sourceDict)
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x9C1BF4", Offset = "0x9C1BF4", VA = "0x9C1BF4")]
	public static void AddToDictionaryBySubtraction(Dictionary<string, long> destinationDict, Dictionary<string, long> sourceDict)
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x9C1BFC", Offset = "0x9C1BFC", VA = "0x9C1BFC")]
	public static void AddToDictionaryByMax(Dictionary<string, long> destinationDict, Dictionary<string, long> sourceDict)
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x9C17C8", Offset = "0x9C17C8", VA = "0x9C17C8")]
	public static void AddToDictionary(Dictionary<string, long> destinationDict, Dictionary<string, long> sourceDict, EDictAddType addType)
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x9C1C04", Offset = "0x9C1C04", VA = "0x9C1C04")]
	public DictionaryHelper()
	{
	}
}
