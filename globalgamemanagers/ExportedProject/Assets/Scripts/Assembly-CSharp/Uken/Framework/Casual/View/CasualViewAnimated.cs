using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057A")]
	public class CasualViewAnimated : CasualViewItem
	{
		[Token(Token = "0x2000858")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821538", Offset = "0x821538")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x40023F3")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewAnimated _003C_003E4__this;

			[Token(Token = "0x40023F4")]
			[FieldOffset(Offset = "0x18")]
			public Action onShowComplete;

			[Token(Token = "0x6003389")]
			[Address(RVA = "0xAE4AA8", Offset = "0xAE4AA8", VA = "0xAE4AA8")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600338A")]
			[Address(RVA = "0xAE4AB0", Offset = "0xAE4AB0", VA = "0xAE4AB0")]
			internal void _003COnShow_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000859")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821548", Offset = "0x821548")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40023F5")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewAnimated _003C_003E4__this;

			[Token(Token = "0x40023F6")]
			[FieldOffset(Offset = "0x18")]
			public Action onHideComplete;

			[Token(Token = "0x600338B")]
			[Address(RVA = "0xAE4AE8", Offset = "0xAE4AE8", VA = "0xAE4AE8")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600338C")]
			[Address(RVA = "0xAE4AF0", Offset = "0xAE4AF0", VA = "0xAE4AF0")]
			internal void _003COnHide_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200085A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821558", Offset = "0x821558")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40023F7")]
			[FieldOffset(Offset = "0x10")]
			public int hideRequestCounter;

			[Token(Token = "0x40023F8")]
			[FieldOffset(Offset = "0x18")]
			public CasualViewAnimated _003C_003E4__this;

			[Token(Token = "0x40023F9")]
			[FieldOffset(Offset = "0x20")]
			public Action onHideComplete;

			[Token(Token = "0x600338D")]
			[Address(RVA = "0xAE4B28", Offset = "0xAE4B28", VA = "0xAE4B28")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600338E")]
			[Address(RVA = "0xAE4B30", Offset = "0xAE4B30", VA = "0xAE4B30")]
			internal void _003COnHideStart_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x90")]
		public Animator AnimationController;

		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x98")]
		private string AnimatorBool;

		[Token(Token = "0x60029FB")]
		[Address(RVA = "0xAA2720", Offset = "0xAA2720", VA = "0xAA2720", Slot = "12")]
		public override void Initialize(CasualViewBase parentView)
		{
		}

		[Token(Token = "0x60029FC")]
		[Address(RVA = "0xAA2728", Offset = "0xAA2728", VA = "0xAA2728", Slot = "7")]
		protected override void OnShow(Action onShowComplete)
		{
		}

		[Token(Token = "0x60029FD")]
		[Address(RVA = "0xAA28C0", Offset = "0xAA28C0", VA = "0xAA28C0", Slot = "6")]
		protected override void OnShowStart(Action onShowComplete)
		{
		}

		[Token(Token = "0x60029FE")]
		[Address(RVA = "0xAA28CC", Offset = "0xAA28CC", VA = "0xAA28CC", Slot = "10")]
		protected override void OnHide(Action onHideComplete)
		{
		}

		[Token(Token = "0x60029FF")]
		[Address(RVA = "0xAA2B1C", Offset = "0xAA2B1C", VA = "0xAA2B1C", Slot = "11")]
		protected override void OnHideFinished(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A00")]
		[Address(RVA = "0xAA2B88", Offset = "0xAA2B88", VA = "0xAA2B88", Slot = "9")]
		protected override void OnHideStart(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A01")]
		[Address(RVA = "0xAA2D90", Offset = "0xAA2D90", VA = "0xAA2D90", Slot = "8")]
		protected override void OnShowFinished(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A02")]
		[Address(RVA = "0xAA2F44", Offset = "0xAA2F44", VA = "0xAA2F44")]
		public CasualViewAnimated()
		{
		}
	}
}
