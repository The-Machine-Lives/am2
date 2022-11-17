using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057C")]
	public class CasualViewController : MonoBehaviour
	{
		[Token(Token = "0x200085F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821598", Offset = "0x821598")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x4002406")]
			[FieldOffset(Offset = "0x10")]
			public CasualView nextView;

			[Token(Token = "0x4002407")]
			[FieldOffset(Offset = "0x18")]
			public CasualViewController _003C_003E4__this;

			[Token(Token = "0x6003395")]
			[Address(RVA = "0xAE6E64", Offset = "0xAE6E64", VA = "0xAE6E64")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6003396")]
			[Address(RVA = "0xAE7164", Offset = "0xAE7164", VA = "0xAE7164")]
			internal void _003CShowPrev_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8215A8", Offset = "0x8215A8")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4002408")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewController _003C_003E4__this;

			[Token(Token = "0x4002409")]
			[FieldOffset(Offset = "0x18")]
			public CasualView nextView;

			[Token(Token = "0x6003397")]
			[Address(RVA = "0xAE6FC0", Offset = "0xAE6FC0", VA = "0xAE6FC0")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6003398")]
			[Address(RVA = "0xAE7198", Offset = "0xAE7198", VA = "0xAE7198")]
			internal void _003CShowNext_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x18")]
		public Image previousSceneBackground;

		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x20")]
		public CasualView m_startingView;

		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x28")]
		public CasualSceneState m_sceneState;

		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x30")]
		public CasualViewMutex viewMutexHandler;

		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x832A68", Offset = "0x832A68")]
		protected CasualView m_activeView;

		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DeprecatedAttribute", RVA = "0x832AA0", Offset = "0x832AA0")]
		protected Queue<CasualView> m_queuedViews;

		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x48")]
		protected CasualSceneController m_sceneController;

		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x50")]
		protected List<CasualViewBase> m_currentDismissableViews;

		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_bInitialized;

		[Token(Token = "0x6002A12")]
		[Address(RVA = "0xAE6304", Offset = "0xAE6304", VA = "0xAE6304", Slot = "4")]
		public virtual void Initialize(CasualSceneController parentController)
		{
		}

		[Token(Token = "0x6002A13")]
		[Address(RVA = "0xAE672C", Offset = "0xAE672C", VA = "0xAE672C")]
		public CasualGame Game()
		{
			return null;
		}

		[Token(Token = "0x6002A14")]
		[Address(RVA = "0xAE675C", Offset = "0xAE675C", VA = "0xAE675C")]
		public CasualSceneController GetSceneController()
		{
			return null;
		}

		[Token(Token = "0x6002A15")]
		[Address(RVA = "0xAE6764", Offset = "0xAE6764", VA = "0xAE6764")]
		public string GetViewPrefab()
		{
			return null;
		}

		[Token(Token = "0x6002A16")]
		[Address(RVA = "0xAE67E0", Offset = "0xAE67E0", VA = "0xAE67E0", Slot = "5")]
		public virtual bool HandleBackButtonPress()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A17")]
		[Address(RVA = "0xAE6A10", Offset = "0xAE6A10", VA = "0xAE6A10")]
		public Sprite GetActiveViewBackground()
		{
			return null;
		}

		[Token(Token = "0x6002A18")]
		[Address(RVA = "0xAE6B44", Offset = "0xAE6B44", VA = "0xAE6B44")]
		public void SetPreviousViewBackground(Sprite sprite)
		{
		}

		[Token(Token = "0x6002A19")]
		[Address(RVA = "0xAE6C84", Offset = "0xAE6C84", VA = "0xAE6C84")]
		public bool ShowPrev(bool hideCurrent = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0xAE63C8", Offset = "0xAE63C8", VA = "0xAE63C8")]
		public void ShowNext(bool hideCurrent = true)
		{
		}

		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0xAE6FC8", Offset = "0xAE6FC8", VA = "0xAE6FC8")]
		public void RegisterDismissableView(CasualViewBase view)
		{
		}

		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0xAE69A0", Offset = "0xAE69A0", VA = "0xAE69A0")]
		public void DeregisterDismissableView(CasualViewBase view)
		{
		}

		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0xAE6E6C", Offset = "0xAE6E6C", VA = "0xAE6E6C")]
		private void ActivateView(CasualView nextView, bool setPrevious = true)
		{
		}

		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0xAE7038", Offset = "0xAE7038", VA = "0xAE7038")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0xAE703C", Offset = "0xAE703C", VA = "0xAE703C")]
		public void LoadView(CasualView view)
		{
		}

		[Token(Token = "0x6002A20")]
		[Address(RVA = "0xAE70AC", Offset = "0xAE70AC", VA = "0xAE70AC")]
		public CasualViewController()
		{
		}
	}
}
