using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x200008B")]
public class TextSceneView : ActionSceneView
{
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private AM2Text m_text;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private float m_showFadeDuration;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private float m_hideFadeDuration;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0xC0")]
	private Color m_originalTextColor;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0xD0")]
	private Color m_fadedOutTextColor;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0xE0")]
	private ActionController m_actionController;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0xE8")]
	private TextSceneController m_sceneController;

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xA12E18", Offset = "0xA12E18", VA = "0xA12E18")]
	public void Initialize(TextSceneController sceneController, ZoneView zoneView)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xA13008", Offset = "0xA13008", VA = "0xA13008", Slot = "7")]
	protected override void OnShow(Action onShowComplete)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xA13284", Offset = "0xA13284", VA = "0xA13284", Slot = "10")]
	protected override void OnHide(Action onHideComplete)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xA13348", Offset = "0xA13348", VA = "0xA13348")]
	public TextSceneView()
	{
	}
}
