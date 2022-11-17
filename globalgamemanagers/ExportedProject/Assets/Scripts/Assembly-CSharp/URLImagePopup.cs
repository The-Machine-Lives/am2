using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Web;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A4")]
public class URLImagePopup : PopupView
{
	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Image m_image;

	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float fadeInLength;

	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Action m_closeCallback;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private UkenImageCacher m_webImage;

	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string URLImagePopupPrefab;

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0xA149F8", Offset = "0xA149F8", VA = "0xA149F8")]
	public static URLImagePopup Create(CasualViewController controller, Transform parent, string url, [Optional] Action closeCallback, bool manualShow = false)
	{
		return null;
	}

	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0xA14B40", Offset = "0xA14B40", VA = "0xA14B40")]
	public void Setup(string url, Action closeCallback)
	{
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0xA14CBC", Offset = "0xA14CBC", VA = "0xA14CBC", Slot = "12")]
	public override void ClosePopup()
	{
	}

	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0xA14CE8", Offset = "0xA14CE8", VA = "0xA14CE8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0xA14D18", Offset = "0xA14D18", VA = "0xA14D18")]
	public URLImagePopup()
	{
	}

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0xA14D84", Offset = "0xA14D84", VA = "0xA14D84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834828", Offset = "0x834828")]
	private void _003CSetup_003Eb__6_0(bool success, Sprite sprite)
	{
	}
}
