using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x2000580")]
	public class PopupView : CasualViewBase
	{
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x80")]
		protected bool m_allowBackButtonDismiss;

		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x88")]
		protected CasualViewController m_controller;

		[Token(Token = "0x6002A34")]
		[Address(RVA = "0xAE7964", Offset = "0xAE7964", VA = "0xAE7964")]
		protected static PopupView Create(string prefabPath, Transform parentContainer, bool allowBackButtonDismiss, CasualViewController controller)
		{
			return null;
		}

		[Token(Token = "0x6002A35")]
		[Address(RVA = "0xAE7B3C", Offset = "0xAE7B3C", VA = "0xAE7B3C")]
		protected static PopupView Create(PopupView popupPrefab, Transform parentContainer, bool allowBackButtonDismiss, CasualViewController controller)
		{
			return null;
		}

		[Token(Token = "0x6002A36")]
		[Address(RVA = "0xAE7BF8", Offset = "0xAE7BF8", VA = "0xAE7BF8")]
		protected void Initialize(bool allowBackButtonDismiss, CasualViewController controller)
		{
		}

		[Token(Token = "0x6002A37")]
		[Address(RVA = "0xAE7C34", Offset = "0xAE7C34", VA = "0xAE7C34", Slot = "10")]
		protected override void OnHide(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A38")]
		[Address(RVA = "0xAE7CFC", Offset = "0xAE7CFC", VA = "0xAE7CFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002A39")]
		[Address(RVA = "0xAE7D00", Offset = "0xAE7D00", VA = "0xAE7D00", Slot = "7")]
		protected override void OnShow(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0xAE7DD0", Offset = "0xAE7DD0", VA = "0xAE7DD0", Slot = "11")]
		protected override void OnHideFinished(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0xAE7EE0", Offset = "0xAE7EE0", VA = "0xAE7EE0", Slot = "12")]
		public virtual void ClosePopup()
		{
		}

		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0xAE7D2C", Offset = "0xAE7D2C", VA = "0xAE7D2C")]
		private void RegisterPopup()
		{
		}

		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0xAE7C60", Offset = "0xAE7C60", VA = "0xAE7C60")]
		private void DeregisterPopup()
		{
		}

		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0xAE7F08", Offset = "0xAE7F08", VA = "0xAE7F08")]
		public PopupView()
		{
		}
	}
}
