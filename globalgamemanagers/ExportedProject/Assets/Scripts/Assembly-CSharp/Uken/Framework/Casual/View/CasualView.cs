using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x2000579")]
	public class CasualView : CasualViewBase
	{
		[Token(Token = "0x4001A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AM2Button m_bgCloseButton;

		[Token(Token = "0x4001A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool m_playSoundOnClose;

		[Token(Token = "0x4001A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private BISoundEvents.EventKey m_closeSound;

		[Token(Token = "0x4001A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Text Title;

		[Token(Token = "0x4001A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Image Background;

		[Token(Token = "0x4001A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public CasualView m_nextView;

		[Token(Token = "0x4001A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public CasualOffsetObject m_offsetScript;

		[Token(Token = "0x4001A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832A38", Offset = "0x832A38")]
		private CasualView _003Cm_previousView_003Ek__BackingField;

		[Token(Token = "0x4001A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832A48", Offset = "0x832A48")]
		private CasualViewController _003Cm_parentController_003Ek__BackingField;

		[Token(Token = "0x1700075A")]
		public CasualView m_previousView
		{
			[Token(Token = "0x60029ED")]
			[Address(RVA = "0xAA2158", Offset = "0xAA2158", VA = "0xAA2158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5FC", Offset = "0x83A5FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029EE")]
			[Address(RVA = "0xAA2160", Offset = "0xAA2160", VA = "0xAA2160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A60C", Offset = "0x83A60C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700075B")]
		public CasualViewController m_parentController
		{
			[Token(Token = "0x60029EF")]
			[Address(RVA = "0xAA2168", Offset = "0xAA2168", VA = "0xAA2168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A61C", Offset = "0x83A61C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029F0")]
			[Address(RVA = "0xAA2170", Offset = "0xAA2170", VA = "0xAA2170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A62C", Offset = "0x83A62C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60029F1")]
		[Address(RVA = "0xAA2178", Offset = "0xAA2178", VA = "0xAA2178", Slot = "12")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60029F2")]
		[Address(RVA = "0xAA226C", Offset = "0xAA226C", VA = "0xAA226C", Slot = "13")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60029F3")]
		[Address(RVA = "0xAA23F8", Offset = "0xAA23F8", VA = "0xAA23F8")]
		public void Initialize(CasualViewController parentController, [Optional] CasualView previousView, bool setPreviousView = true)
		{
		}

		[Token(Token = "0x60029F4")]
		[Address(RVA = "0xAA24C0", Offset = "0xAA24C0", VA = "0xAA24C0", Slot = "9")]
		protected override void OnHideStart(Action onHideComplete)
		{
		}

		[Token(Token = "0x60029F5")]
		[Address(RVA = "0xAA25F8", Offset = "0xAA25F8", VA = "0xAA25F8", Slot = "11")]
		protected override void OnHideFinished(Action onHideComplete)
		{
		}

		[Token(Token = "0x60029F6")]
		[Address(RVA = "0xAA2358", Offset = "0xAA2358", VA = "0xAA2358")]
		private void DeregisterView()
		{
		}

		[Token(Token = "0x60029F7")]
		[Address(RVA = "0xAA26D0", Offset = "0xAA26D0", VA = "0xAA26D0", Slot = "14")]
		public virtual void OnCloseClicked()
		{
		}

		[Token(Token = "0x60029F8")]
		[Address(RVA = "0xAA26D8", Offset = "0xAA26D8", VA = "0xAA26D8", Slot = "8")]
		protected override void OnShowFinished(Action onShowComplete)
		{
		}

		[Token(Token = "0x60029F9")]
		[Address(RVA = "0xAA270C", Offset = "0xAA270C", VA = "0xAA270C", Slot = "15")]
		protected virtual void HandleSceneState()
		{
		}

		[Token(Token = "0x60029FA")]
		[Address(RVA = "0xAA2710", Offset = "0xAA2710", VA = "0xAA2710")]
		public CasualView()
		{
		}
	}
}
