using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000067")]
public class QAConsoleCall : MonoBehaviour
{
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x18")]
	private Queue<string> cmdRequests;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8218A8", Offset = "0x8218A8")]
	private static QAConsoleCall _003CInstance_003Ek__BackingField;

	[Token(Token = "0x1700000B")]
	public static QAConsoleCall Instance
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9E6900", Offset = "0x9E6900", VA = "0x9E6900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83376C", Offset = "0x83376C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x9E6950", Offset = "0x9E6950", VA = "0x9E6950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83377C", Offset = "0x83377C")]
		private set
		{
		}
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x9E69A4", Offset = "0x9E69A4", VA = "0x9E69A4")]
	public void RequestCmd(string id)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x9E6A20", Offset = "0x9E6A20", VA = "0x9E6A20")]
	public void FetchId(string id)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x9E6C14", Offset = "0x9E6C14", VA = "0x9E6C14")]
	public void Awake()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x9E6C68", Offset = "0x9E6C68", VA = "0x9E6C68")]
	public void Update()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x9E6D04", Offset = "0x9E6D04", VA = "0x9E6D04")]
	public QAConsoleCall()
	{
	}
}
