using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004CF")]
	public class CasualBootStrap : MonoBehaviour
	{
		[Token(Token = "0x2000830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821398", Offset = "0x821398")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4002389")]
			[FieldOffset(Offset = "0x10")]
			public CasualBootStrap _003C_003E4__this;

			[Token(Token = "0x400238A")]
			[FieldOffset(Offset = "0x18")]
			public Sprite bgSprite;

			[Token(Token = "0x600332B")]
			[Address(RVA = "0xA2AB9C", Offset = "0xA2AB9C", VA = "0xA2AB9C")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600332C")]
			[Address(RVA = "0xA2AD0C", Offset = "0xA2AD0C", VA = "0xA2AD0C")]
			internal void _003CLoginAndGoToSplashScreen_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001666")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameObject m_policyWindow;

		[Token(Token = "0x4001667")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected GameObject m_appleSignInWindow;

		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected AM2Button m_cancelNativeAuthButton;

		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected AM2Button m_acceptNativeAuthButton;

		[Token(Token = "0x400166A")]
		[FieldOffset(Offset = "0x38")]
		public CasualGame CoreGameModule;

		[Token(Token = "0x400166B")]
		[FieldOffset(Offset = "0x40")]
		public Image sceneBackground;

		[Token(Token = "0x400166C")]
		[FieldOffset(Offset = "0x48")]
		public string SplashScene;

		[Token(Token = "0x400166D")]
		[FieldOffset(Offset = "0x50")]
		public float StarupDelay;

		[Token(Token = "0x400166E")]
		[FieldOffset(Offset = "0x54")]
		public float WeirdBingoTimeout;

		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_bStartupComplete;

		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0x5C")]
		private float m_timeAlive;

		[Token(Token = "0x6002452")]
		[Address(RVA = "0xA2A6C4", Offset = "0xA2A6C4", VA = "0xA2A6C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6002453")]
		[Address(RVA = "0xA2A8B4", Offset = "0xA2A8B4", VA = "0xA2A8B4")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x6002454")]
		[Address(RVA = "0xA2A9C8", Offset = "0xA2A9C8", VA = "0xA2A9C8", Slot = "4")]
		protected virtual void SetOrientation()
		{
		}

		[Token(Token = "0x6002455")]
		[Address(RVA = "0xA2A9CC", Offset = "0xA2A9CC", VA = "0xA2A9CC", Slot = "5")]
		protected virtual void StartFramework()
		{
		}

		[Token(Token = "0x6002456")]
		[Address(RVA = "0xA2AA30", Offset = "0xA2AA30", VA = "0xA2AA30", Slot = "6")]
		protected virtual void InitiateGoToSplashScreenFlow()
		{
		}

		[Token(Token = "0x6002457")]
		[Address(RVA = "0xA2AB68", Offset = "0xA2AB68", VA = "0xA2AB68")]
		private void ShowAppleSignInPrompt()
		{
		}

		[Token(Token = "0x6002458")]
		[Address(RVA = "0xA2AA34", Offset = "0xA2AA34", VA = "0xA2AA34")]
		private void LoginAndGoToSplashScreen()
		{
		}

		[Token(Token = "0x6002459")]
		[Address(RVA = "0xA2ABA4", Offset = "0xA2ABA4", VA = "0xA2ABA4")]
		private void CancelNativeAuth()
		{
		}

		[Token(Token = "0x600245A")]
		[Address(RVA = "0xA2ABEC", Offset = "0xA2ABEC", VA = "0xA2ABEC")]
		private void AcceptNativeAuth()
		{
		}

		[Token(Token = "0x600245B")]
		[Address(RVA = "0xA2AC2C", Offset = "0xA2AC2C", VA = "0xA2AC2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600245C")]
		[Address(RVA = "0xA2ACF8", Offset = "0xA2ACF8", VA = "0xA2ACF8")]
		public CasualBootStrap()
		{
		}
	}
}
