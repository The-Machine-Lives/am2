using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;

[Token(Token = "0x20000BE")]
public class BICasualViewController : CasualViewController
{
	[Token(Token = "0x200061B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203A8", Offset = "0x8203A8")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x10")]
		public OkPopup waitOkPopup;

		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool, Stores.PurchaseResult> onComplete;

		[Token(Token = "0x4001E39")]
		[FieldOffset(Offset = "0x20")]
		public StoreItem storeItem;

		[Token(Token = "0x4001E3A")]
		[FieldOffset(Offset = "0x28")]
		public BICasualViewController _003C_003E4__this;

		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0xA3E1DC", Offset = "0xA3E1DC", VA = "0xA3E1DC")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0xA3EB10", Offset = "0xA3EB10", VA = "0xA3EB10")]
		internal void _003CStartPurchaseFlow_003Eb__0(bool success, Stores.PurchaseResult result)
		{
		}
	}

	[Token(Token = "0x200061C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8203B8", Offset = "0x8203B8")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4001E3B")]
		[FieldOffset(Offset = "0x10")]
		public Alert alert;

		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0xA3E8A4", Offset = "0xA3E8A4", VA = "0xA3E8A4")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0xA3EC6C", Offset = "0xA3EC6C", VA = "0xA3EC6C")]
		internal void _003CCheckEventTickets_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x60")]
	protected AM2Game m_am2Game;

	[Token(Token = "0x4000318")]
	private const string m_refreshPopupContentPath = "PopupContents/RefreshErrorContent";

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x68")]
	private Action m_offlineExitCallback;

	[Token(Token = "0x400031A")]
	private const float m_NETWORKCHECK = 1f;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x70")]
	private float m_offlineCounter;

	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x74")]
	private bool m_tracknetwork;

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xA3DB50", Offset = "0xA3DB50", VA = "0xA3DB50", Slot = "6")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xA3DCA4", Offset = "0xA3DCA4", VA = "0xA3DCA4")]
	public void SetActiveGame(CasualGame casualGame)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xA3DD34", Offset = "0xA3DD34", VA = "0xA3DD34")]
	protected void SetViewAsOnlineOnly(Action offlineExitCallback)
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xA3DD3C", Offset = "0xA3DD3C", VA = "0xA3DD3C")]
	public bool CheckGameStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xA3DF54", Offset = "0xA3DF54", VA = "0xA3DF54")]
	public void StartPurchaseFlow(StoreItem storeItem, Action<bool, Stores.PurchaseResult> onComplete, string eventName, string sourceSink)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xA3E1E4", Offset = "0xA3E1E4", VA = "0xA3E1E4")]
	public void ShowPurchaseResultPopup(bool success, Stores.PurchaseResult result)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0xA3E49C", Offset = "0xA3E49C", VA = "0xA3E49C")]
	public void CheckEventTickets()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0xA3E8AC", Offset = "0xA3E8AC", VA = "0xA3E8AC")]
	public static void OpenStoreApp()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xA3E8F8", Offset = "0xA3E8F8", VA = "0xA3E8F8", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xA3EB00", Offset = "0xA3EB00", VA = "0xA3EB00")]
	public BICasualViewController()
	{
	}
}
