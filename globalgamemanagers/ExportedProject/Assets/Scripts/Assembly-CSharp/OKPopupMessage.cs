using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001A1")]
public class OKPopupMessage
{
	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string OkPopupMessagePrefab;

	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x99E2BC", Offset = "0x99E2BC", VA = "0x99E2BC")]
	public static OkPopup CreateWithOk(CasualViewController controller, Transform parent, string message, GameObject contentPrefab, [Optional] Action okCallback, string okText = "OK")
	{
		return null;
	}

	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x99E380", Offset = "0x99E380", VA = "0x99E380")]
	public OKPopupMessage()
	{
	}
}
