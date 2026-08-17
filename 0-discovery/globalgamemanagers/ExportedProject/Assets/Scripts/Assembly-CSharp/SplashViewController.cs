using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001D0")]
public class SplashViewController : BICasualViewController
{
	[Token(Token = "0x2000650")]
	public delegate bool BlockGameStartDelegate();

	[Serializable]
	[Token(Token = "0x2000651")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820558", Offset = "0x820558")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__13_1;

		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0xA084C4", Offset = "0xA084C4", VA = "0xA084C4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D70")]
		[Address(RVA = "0xA084CC", Offset = "0xA084CC", VA = "0xA084CC")]
		internal void _003CLoginViaNativeAuth_003Eb__13_1()
		{
		}
	}

	[Token(Token = "0x2000652")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820568", Offset = "0x820568")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x10")]
		public AM2Game game;

		[Token(Token = "0x6002D71")]
		[Address(RVA = "0xA08268", Offset = "0xA08268", VA = "0xA08268")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6002D72")]
		[Address(RVA = "0xA084D0", Offset = "0xA084D0", VA = "0xA084D0")]
		internal void _003CCheckForBlockGameStart_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x78")]
	public SplashView m_splashView;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825DCC", Offset = "0x825DCC")]
	private bool _003Cm_bIsLoading_003Ek__BackingField;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x81")]
	private bool m_bTransitionStarted;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x82")]
	private bool m_backgrounded;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x84")]
	private float m_timeSinceBackgrounded;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isOfflineAndBlocked;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x90")]
	private OkPopup m_forceClearUserPopup;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x98")]
	private AM2Game m_game;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0xA0")]
	private float waitForLoad;

	[Token(Token = "0x17000188")]
	public bool m_bIsLoading
	{
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0xA076A8", Offset = "0xA076A8", VA = "0xA076A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834AEC", Offset = "0x834AEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0xA076B0", Offset = "0xA076B0", VA = "0xA076B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834AFC", Offset = "0x834AFC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0xA076BC", Offset = "0xA076BC", VA = "0xA076BC", Slot = "4")]
	public override void Initialize(CasualSceneController parentController)
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0xA07770", Offset = "0xA07770", VA = "0xA07770")]
	public void LoginViaNativeAuth()
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0xA07568", Offset = "0xA07568", VA = "0xA07568")]
	public bool LoadGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0xA07B38", Offset = "0xA07B38", VA = "0xA07B38", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0xA07EF8", Offset = "0xA07EF8", VA = "0xA07EF8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0xA07D04", Offset = "0xA07D04", VA = "0xA07D04")]
	private void UpdateLoadingState()
	{
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0xA0818C", Offset = "0xA0818C", VA = "0xA0818C")]
	private void GoToConstruction()
	{
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0xA07958", Offset = "0xA07958", VA = "0xA07958")]
	public bool CheckForBlockGameStart()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0xA08270", Offset = "0xA08270", VA = "0xA08270")]
	public bool ShowForcedUpdates()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0xA07FFC", Offset = "0xA07FFC", VA = "0xA07FFC")]
	public bool ShowForceClearUser()
	{
		return default(bool);
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0xA08414", Offset = "0xA08414", VA = "0xA08414")]
	public SplashViewController()
	{
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0xA08424", Offset = "0xA08424", VA = "0xA08424")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B0C", Offset = "0x834B0C")]
	private void _003CLoginViaNativeAuth_003Eb__13_0(AuthenticationStatus authStatus)
	{
	}
}
