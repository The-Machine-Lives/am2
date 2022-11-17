using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200013B")]
public class AM2TextWithHyperlink : AM2Text, IPointerClickHandler, IEventSystemHandler
{
	[Serializable]
	[Token(Token = "0x2000638")]
	private class HrefInfo
	{
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x10")]
		public int startVertIndex;

		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x14")]
		public int endVertIndex;

		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<Rect> boxes;

		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0xAC86E0", Offset = "0xAC86E0", VA = "0xAC86E0")]
		public HrefInfo()
		{
		}
	}

	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Regex s_HrefRegex;

	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private string hyperlinkColor;

	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x128")]
	private readonly List<HrefInfo> m_HrefInfos;

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0xAC8178", Offset = "0xAC8178", VA = "0xAC8178", Slot = "83")]
	public override void SetText(string newLocalizationTag, bool bNeedsLocalization = true, bool bounceTextOnUpdate = false)
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0xAC8750", Offset = "0xAC8750", VA = "0xAC8750", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0xAC8C4C", Offset = "0xAC8C4C", VA = "0xAC8C4C", Slot = "84")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0xAC8EC0", Offset = "0xAC8EC0", VA = "0xAC8EC0")]
	public AM2TextWithHyperlink()
	{
	}
}
