using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057D")]
	public class CasualViewFadeItem : CasualViewItem
	{
		[Token(Token = "0x2000861")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215B8", Offset = "0x8215B8")]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			[Token(Token = "0x400240A")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewFadeItem _003C_003E4__this;

			[Token(Token = "0x400240B")]
			[FieldOffset(Offset = "0x18")]
			public Action onShowComplete;

			[Token(Token = "0x6003399")]
			[Address(RVA = "0xAE7384", Offset = "0xAE7384", VA = "0xAE7384")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600339A")]
			[Address(RVA = "0xAE77D8", Offset = "0xAE77D8", VA = "0xAE77D8")]
			internal void _003COnShow_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000862")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215C8", Offset = "0x8215C8")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x400240C")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewFadeItem _003C_003E4__this;

			[Token(Token = "0x400240D")]
			[FieldOffset(Offset = "0x18")]
			public Action onHideComplete;

			[Token(Token = "0x600339B")]
			[Address(RVA = "0xAE7664", Offset = "0xAE7664", VA = "0xAE7664")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600339C")]
			[Address(RVA = "0xAE7848", Offset = "0xAE7848", VA = "0xAE7848")]
			internal void _003COnHide_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x90")]
		public CanvasGroup m_FadeGroup;

		[Token(Token = "0x6002A21")]
		[Address(RVA = "0xAE71CC", Offset = "0xAE71CC", VA = "0xAE71CC", Slot = "7")]
		protected override void OnShow(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A22")]
		[Address(RVA = "0xAE7458", Offset = "0xAE7458", VA = "0xAE7458", Slot = "10")]
		protected override void OnHide(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A23")]
		[Address(RVA = "0xAE766C", Offset = "0xAE766C", VA = "0xAE766C")]
		private void UpdateAlpha(float _n)
		{
		}

		[Token(Token = "0x6002A24")]
		[Address(RVA = "0xAE771C", Offset = "0xAE771C", VA = "0xAE771C")]
		private void UpdateAlphaDown(float _n)
		{
		}

		[Token(Token = "0x6002A25")]
		[Address(RVA = "0xAE77D0", Offset = "0xAE77D0", VA = "0xAE77D0")]
		public CasualViewFadeItem()
		{
		}
	}
}
