using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001A2")]
public class OKPopupNotification
{
	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string OkPopupNotificationPrefab;

	[Token(Token = "0x40009CC")]
	public const float c_okPopupNotificationDuration = 3f;

	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x99E3E4", Offset = "0x99E3E4", VA = "0x99E3E4")]
	public static OkPopup CreateWithOk(CasualViewController controller, Transform parent, string message, GameObject contentPrefab, [Optional] Action okCallback, string okText = "OK")
	{
		return null;
	}

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x99E4FC", Offset = "0x99E4FC", VA = "0x99E4FC")]
	public OKPopupNotification()
	{
	}
}
