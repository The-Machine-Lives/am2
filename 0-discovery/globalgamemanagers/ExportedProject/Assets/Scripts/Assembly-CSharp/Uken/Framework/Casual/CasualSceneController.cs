using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DD")]
	public class CasualSceneController : MonoBehaviour
	{
		[Token(Token = "0x40016FB")]
		public const string c_paramPreviousSceneName = "prevSceneName";

		[Token(Token = "0x40016FC")]
		public const string c_paramPreviousSceneState = "prevSceneState";

		[Token(Token = "0x40016FD")]
		public const string c_paramCurrentSceneState = "sceneState";

		[Token(Token = "0x40016FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Canvas RootCanvas;

		[Token(Token = "0x40016FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool bPreventSleepOnScreen;

		[Token(Token = "0x4001700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool bScreenRespectsSafeArea;

		[Token(Token = "0x4001701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool bShowIphoneXSafeArea;

		[Token(Token = "0x4001702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CasualSceneBackgroundController m_Background;

		[Token(Token = "0x4001703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CasualViewController m_uiController;

		[Token(Token = "0x4001704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0DC", Offset = "0x82F0DC")]
		private CasualGame _003Cm_ActiveGame_003Ek__BackingField;

		[Token(Token = "0x4001705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_bInitialized;

		[Token(Token = "0x4001706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Dictionary<string, object> m_parameters;

		[Token(Token = "0x1700063C")]
		public CasualGame m_ActiveGame
		{
			[Token(Token = "0x6002559")]
			[Address(RVA = "0xA552C8", Offset = "0xA552C8", VA = "0xA552C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E5C", Offset = "0x839E5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600255A")]
			[Address(RVA = "0xA552D0", Offset = "0xA552D0", VA = "0xA552D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E6C", Offset = "0x839E6C")]
			private set
			{
			}
		}

		[Token(Token = "0x600255B")]
		[Address(RVA = "0xA552D8", Offset = "0xA552D8", VA = "0xA552D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600255C")]
		[Address(RVA = "0xA552DC", Offset = "0xA552DC", VA = "0xA552DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600255D")]
		[Address(RVA = "0xA552E0", Offset = "0xA552E0", VA = "0xA552E0", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x600255E")]
		[Address(RVA = "0xA555F4", Offset = "0xA555F4", VA = "0xA555F4", Slot = "5")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x600255F")]
		[Address(RVA = "0xA5571C", Offset = "0xA5571C", VA = "0xA5571C")]
		public Canvas GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6002560")]
		[Address(RVA = "0xA55A98", Offset = "0xA55A98", VA = "0xA55A98")]
		public CasualSceneState GetSceneState()
		{
			return null;
		}

		[Token(Token = "0x6002561")]
		[Address(RVA = "0xA55B68", Offset = "0xA55B68", VA = "0xA55B68", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6002562")]
		[Address(RVA = "0xA55B6C", Offset = "0xA55B6C", VA = "0xA55B6C")]
		public void SetActiveBackground(Sprite newBG)
		{
		}

		[Token(Token = "0x6002563")]
		[Address(RVA = "0xA55C44", Offset = "0xA55C44", VA = "0xA55C44")]
		public void DimActiveBG(Color color)
		{
		}

		[Token(Token = "0x6002564")]
		[Address(RVA = "0xA55D30", Offset = "0xA55D30", VA = "0xA55D30")]
		public void SetSceneParameters(Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6002565")]
		[Address(RVA = "0xA55D38", Offset = "0xA55D38", VA = "0xA55D38")]
		public void AnimateToActiveBackground(Sprite newBG, float duration = 0.3f)
		{
		}

		[Token(Token = "0x6002566")]
		[Address(RVA = "0xA55E24", Offset = "0xA55E24", VA = "0xA55E24")]
		public Sprite GetActiveBackground()
		{
			return null;
		}

		[Token(Token = "0x6002567")]
		[Address(RVA = "0xA55EF4", Offset = "0xA55EF4", VA = "0xA55EF4")]
		public void SetActiveGame(CasualGame game)
		{
		}

		[Token(Token = "0x6002568")]
		[Address(RVA = "0xA55EFC", Offset = "0xA55EFC", VA = "0xA55EFC", Slot = "7")]
		protected virtual bool Show()
		{
			return default(bool);
		}

		[Token(Token = "0x6002569")]
		[Address(RVA = "0xA55F04", Offset = "0xA55F04", VA = "0xA55F04", Slot = "8")]
		protected virtual bool Exit(bool bForced = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600256A")]
		[Address(RVA = "0xA55F0C", Offset = "0xA55F0C", VA = "0xA55F0C", Slot = "9")]
		protected virtual bool CanExit()
		{
			return default(bool);
		}

		[Token(Token = "0x600256B")]
		[Address(RVA = "0xA55F14", Offset = "0xA55F14", VA = "0xA55F14", Slot = "10")]
		public virtual void OnSceneLoaded()
		{
		}

		[Token(Token = "0x600256C")]
		[Address(RVA = "0xA55FC0", Offset = "0xA55FC0", VA = "0xA55FC0", Slot = "11")]
		public virtual void HandleBackButtonPress()
		{
		}

		[Token(Token = "0x600256D")]
		[Address(RVA = "0xA56104", Offset = "0xA56104", VA = "0xA56104")]
		public string GetPreviousSceneName()
		{
			return null;
		}

		[Token(Token = "0x600256E")]
		[Address(RVA = "0xA5615C", Offset = "0xA5615C", VA = "0xA5615C")]
		public bool GoToScene(string scene, [Optional] Sprite previousBackground, [Optional] Dictionary<string, object> parameters)
		{
			return default(bool);
		}

		[Token(Token = "0x600256F")]
		[Address(RVA = "0xA562A0", Offset = "0xA562A0", VA = "0xA562A0", Slot = "12")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6002570")]
		[Address(RVA = "0xA55354", Offset = "0xA55354", VA = "0xA55354")]
		private void AdjustUIToSafeArea()
		{
		}

		[Token(Token = "0x6002571")]
		[Address(RVA = "0xA56318", Offset = "0xA56318", VA = "0xA56318")]
		public CasualSceneController()
		{
		}
	}
}
