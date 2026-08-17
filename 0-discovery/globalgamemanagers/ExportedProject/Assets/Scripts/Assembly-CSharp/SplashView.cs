using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001CF")]
public class SplashView : CasualView
{
	[Token(Token = "0x4000A9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image LoadingBar;

	[Token(Token = "0x4000AA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject LoaderView;

	[Token(Token = "0x4000AA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AM2Text LoadingText;

	[Token(Token = "0x4000AA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool m_loadImmediately;

	[Token(Token = "0x4000AA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	private bool m_initiatedLoad;

	[Token(Token = "0x4000AA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	private bool bLoadingPackageStage;

	[Token(Token = "0x4000AA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
	private bool m_transitionStarted;

	[Token(Token = "0x4000AA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private SplashViewController m_SplashViewController;

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0xA07094", Offset = "0xA07094", VA = "0xA07094", Slot = "7")]
	protected override void OnShow(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0xA07168", Offset = "0xA07168", VA = "0xA07168")]
	public void SetLoaderViewState(bool showLoaderView)
	{
	}

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0xA071B8", Offset = "0xA071B8", VA = "0xA071B8")]
	public void OnLoadingChanged(bool isLoading)
	{
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0xA071C0", Offset = "0xA071C0", VA = "0xA071C0")]
	public void ReportLoading(float percent, bool isPackageStage, float animSpeed = 0.15f)
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0xA0749C", Offset = "0xA0749C", VA = "0xA0749C")]
	public void OnLoadFinished([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0xA0751C", Offset = "0xA0751C", VA = "0xA0751C")]
	private void LaunchGame()
	{
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0xA07520", Offset = "0xA07520", VA = "0xA07520")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0xA07698", Offset = "0xA07698", VA = "0xA07698")]
	public SplashView()
	{
	}
}
