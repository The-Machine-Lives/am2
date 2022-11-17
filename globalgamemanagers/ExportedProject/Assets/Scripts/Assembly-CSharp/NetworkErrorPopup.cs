using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001A0")]
public class NetworkErrorPopup : OkPopup
{
	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string NetworkErrorPopupPrefab;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject m_networkErrorContent;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool m_retryRequested;

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x99DADC", Offset = "0x99DADC", VA = "0x99DADC")]
	public static NetworkErrorPopup Create(CasualViewController controller, Transform parent, [Optional] Action okCallback, [Optional] GameObject contentPrefab, string message = "Network connection not found", string okText = "Retry")
	{
		return null;
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x99DDFC", Offset = "0x99DDFC", VA = "0x99DDFC", Slot = "13")]
	public override void OnOkButtonPressed()
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x99DEC4", Offset = "0x99DEC4", VA = "0x99DEC4", Slot = "12")]
	public override void ClosePopup()
	{
	}

	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x99DED0", Offset = "0x99DED0", VA = "0x99DED0")]
	public NetworkErrorPopup()
	{
	}
}
