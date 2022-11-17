using System;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000147")]
public class BIFadeViewItem : CasualViewItem
{
	[Token(Token = "0x200063C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8204C8", Offset = "0x8204C8")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x10")]
		public BIFadeViewItem _003C_003E4__this;

		[Token(Token = "0x4001EDB")]
		[FieldOffset(Offset = "0x18")]
		public Action onShowComplete;

		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0xA3F8A0", Offset = "0xA3F8A0", VA = "0xA3F8A0")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0xA3FC08", Offset = "0xA3FC08", VA = "0xA3FC08")]
		internal void _003COnShow_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200063D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8204D8", Offset = "0x8204D8")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4001EDC")]
		[FieldOffset(Offset = "0x10")]
		public BIFadeViewItem _003C_003E4__this;

		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x18")]
		public Action onHideComplete;

		[Token(Token = "0x6002D40")]
		[Address(RVA = "0xA3FA94", Offset = "0xA3FA94", VA = "0xA3FA94")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6002D41")]
		[Address(RVA = "0xA3FC78", Offset = "0xA3FC78", VA = "0xA3FC78")]
		internal void _003COnHide_003Eb__0()
		{
		}
	}

	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x90")]
	public CanvasGroup m_FadeGroup;

	[Token(Token = "0x6000923")]
	[Address(RVA = "0xA3F708", Offset = "0xA3F708", VA = "0xA3F708", Slot = "7")]
	protected override void OnShow(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0xA3F8A8", Offset = "0xA3F8A8", VA = "0xA3F8A8", Slot = "10")]
	protected override void OnHide(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0xA3FA9C", Offset = "0xA3FA9C", VA = "0xA3FA9C")]
	private void UpdateAlpha(float _n)
	{
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0xA3FB4C", Offset = "0xA3FB4C", VA = "0xA3FB4C")]
	private void UpdateAlphaDown(float _n)
	{
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0xA3FC00", Offset = "0xA3FC00", VA = "0xA3FC00")]
	public BIFadeViewItem()
	{
	}
}
