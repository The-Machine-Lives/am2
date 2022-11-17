using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001A3")]
public class OkPopup : PopupView
{
	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AM2Text m_message;

	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform m_container;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject m_okButton;

	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AM2Text m_okButtonText;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AM2Text m_cancelButtonText;

	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject m_cancelButton;

	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82550C", Offset = "0x82550C")]
	private GameObject _003Ccontent_003Ek__BackingField;

	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected Action m_okCallback;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected Action m_cancelCallback;

	[Token(Token = "0x17000163")]
	public GameObject content
	{
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x99E560", Offset = "0x99E560", VA = "0x99E560")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834808", Offset = "0x834808")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x99E568", Offset = "0x99E568", VA = "0x99E568")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834818", Offset = "0x834818")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x990C64", Offset = "0x990C64", VA = "0x990C64")]
	public static OkPopup CreateWithOk(CasualViewController controller, Transform parent, string message, GameObject contentPrefab, [Optional] Action okCallback, string okText = "OK", [Optional] Transform inStartHidePosition, string prefabString = "OkPopupTemplate", bool allowBackButtonDismiss = false)
	{
		return null;
	}

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x9902A8", Offset = "0x9902A8", VA = "0x9902A8")]
	public static OkPopup CreateWithOkCancel(CasualViewController controller, Transform parent, string message, GameObject contentPrefab, [Optional] Action okCallback, [Optional] Action cancelCallback, string okText = "OK", string prefabString = "OkPopupTemplate", string cancelText = "Cancel", bool allowBackButtonDismiss = false)
	{
		return null;
	}

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x99DCF8", Offset = "0x99DCF8", VA = "0x99DCF8")]
	public void Setup(string message, GameObject contentPrefab, Action okCallback, Action cancelCallback)
	{
	}

	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x99E570", Offset = "0x99E570", VA = "0x99E570", Slot = "13")]
	public virtual void OnOkButtonPressed()
	{
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x99E57C", Offset = "0x99E57C", VA = "0x99E57C", Slot = "14")]
	public virtual void OnCancelButtonPressed()
	{
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x99E588", Offset = "0x99E588", VA = "0x99E588", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x99DED8", Offset = "0x99DED8", VA = "0x99DED8")]
	public OkPopup()
	{
	}
}
