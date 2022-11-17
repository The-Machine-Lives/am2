using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057B")]
	public abstract class CasualViewBase : MonoBehaviour
	{
		[Token(Token = "0x200085B")]
		protected enum ViewState
		{
			[Token(Token = "0x40023FB")]
			Inactive = 0,
			[Token(Token = "0x40023FC")]
			Showing = 1,
			[Token(Token = "0x40023FD")]
			Visible = 2,
			[Token(Token = "0x40023FE")]
			Hiding = 3
		}

		[Token(Token = "0x200085C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821568", Offset = "0x821568")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x40023FF")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewBase _003C_003E4__this;

			[Token(Token = "0x4002400")]
			[FieldOffset(Offset = "0x18")]
			public Action onShowComplete;

			[Token(Token = "0x600338F")]
			[Address(RVA = "0xAE545C", Offset = "0xAE545C", VA = "0xAE545C")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6003390")]
			[Address(RVA = "0xAE6244", Offset = "0xAE6244", VA = "0xAE6244")]
			internal void _003COnShow_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200085D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821578", Offset = "0x821578")]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			[Token(Token = "0x4002401")]
			[FieldOffset(Offset = "0x10")]
			public int hideRequestCounter;

			[Token(Token = "0x4002402")]
			[FieldOffset(Offset = "0x18")]
			public CasualViewBase _003C_003E4__this;

			[Token(Token = "0x4002403")]
			[FieldOffset(Offset = "0x20")]
			public Action onHideComplete;

			[Token(Token = "0x6003391")]
			[Address(RVA = "0xAE5B10", Offset = "0xAE5B10", VA = "0xAE5B10")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6003392")]
			[Address(RVA = "0xAE627C", Offset = "0xAE627C", VA = "0xAE627C")]
			internal void _003COnHideStart_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200085E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821588", Offset = "0x821588")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x4002404")]
			[FieldOffset(Offset = "0x10")]
			public CasualViewBase _003C_003E4__this;

			[Token(Token = "0x4002405")]
			[FieldOffset(Offset = "0x18")]
			public Action onHideComplete;

			[Token(Token = "0x6003393")]
			[Address(RVA = "0xAE5F60", Offset = "0xAE5F60", VA = "0xAE5F60")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6003394")]
			[Address(RVA = "0xAE62CC", Offset = "0xAE62CC", VA = "0xAE62CC")]
			internal void _003COnHide_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x18")]
		public GameObject transitionTarget;

		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x20")]
		public Transform StartPosition;

		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x28")]
		public Transform HidePosition;

		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_startScale;

		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x34")]
		public float ShowAnimationDuration;

		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x38")]
		public float HideAnimationDuration;

		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x3C")]
		public float OnShowDelay;

		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x40")]
		public float OnHideDelay;

		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x44")]
		public UkenAnimEaseType ShowAnimationEaseType;

		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x48")]
		public UkenAnimEaseType HideAnimationEaseType;

		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x50")]
		public List<CasualViewItem> m_childItems;

		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x58")]
		public bool destroyOnHideFinish;

		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x60")]
		protected UkenAnimTransform m_currentStartTransform;

		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x68")]
		protected UkenAnimTransform m_currentStartScale;

		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x70")]
		protected ViewState m_currentState;

		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x74")]
		private bool bStartedFromShow;

		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x75")]
		private bool bInitialized;

		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x78")]
		protected Vector2 VisiblePosition;

		[Token(Token = "0x1700075C")]
		protected UkenAnim ukenAnim
		{
			[Token(Token = "0x6002A03")]
			[Address(RVA = "0xAE4B80", Offset = "0xAE4B80", VA = "0xAE4B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A04")]
		[Address(RVA = "0xAE4C20", Offset = "0xAE4C20", VA = "0xAE4C20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6002A05")]
		[Address(RVA = "0xAE4CDC", Offset = "0xAE4CDC", VA = "0xAE4CDC")]
		protected void Initialize()
		{
		}

		[Token(Token = "0x6002A06")]
		[Address(RVA = "0xAE4FC4", Offset = "0xAE4FC4", VA = "0xAE4FC4", Slot = "5")]
		protected virtual void OnInitialized()
		{
		}

		[Token(Token = "0x6002A07")]
		[Address(RVA = "0xAE4FC8", Offset = "0xAE4FC8", VA = "0xAE4FC8")]
		public void Show()
		{
		}

		[Token(Token = "0x6002A08")]
		[Address(RVA = "0xAE4FD0", Offset = "0xAE4FD0", VA = "0xAE4FD0")]
		public void Show(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A09")]
		[Address(RVA = "0xAE50A8", Offset = "0xAE50A8", VA = "0xAE50A8", Slot = "6")]
		protected virtual void OnShowStart(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0xAE50B4", Offset = "0xAE50B4", VA = "0xAE50B4", Slot = "7")]
		protected virtual void OnShow(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0xAE56F0", Offset = "0xAE56F0", VA = "0xAE56F0", Slot = "8")]
		protected virtual void OnShowFinished(Action onShowComplete)
		{
		}

		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0xAE58A4", Offset = "0xAE58A4", VA = "0xAE58A4")]
		public void Hide()
		{
		}

		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0xAE58CC", Offset = "0xAE58CC", VA = "0xAE58CC")]
		public void Hide(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0xAE58F0", Offset = "0xAE58F0", VA = "0xAE58F0", Slot = "9")]
		protected virtual void OnHideStart(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0xAE5B18", Offset = "0xAE5B18", VA = "0xAE5B18", Slot = "10")]
		protected virtual void OnHide(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A10")]
		[Address(RVA = "0xAE5F74", Offset = "0xAE5F74", VA = "0xAE5F74", Slot = "11")]
		protected virtual void OnHideFinished(Action onHideComplete)
		{
		}

		[Token(Token = "0x6002A11")]
		[Address(RVA = "0xAE618C", Offset = "0xAE618C", VA = "0xAE618C")]
		protected CasualViewBase()
		{
		}
	}
}
