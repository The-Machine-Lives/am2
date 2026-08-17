using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;
using Uken.Library.Web;

[Token(Token = "0x200019C")]
public class UpdatesController : DepotController
{
	[Token(Token = "0x200064B")]
	public class ForcedLogoutRequest
	{
		[Token(Token = "0x4001F49")]
		[FieldOffset(Offset = "0x10")]
		public string Message;

		[Token(Token = "0x6002D61")]
		[Address(RVA = "0xAB4EA8", Offset = "0xAB4EA8", VA = "0xAB4EA8")]
		public ForcedLogoutRequest(string message)
		{
		}
	}

	[Token(Token = "0x200064C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x820538", Offset = "0x820538")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x4001F4A")]
		[FieldOffset(Offset = "0x10")]
		public IAM2Game game;

		[Token(Token = "0x6002D62")]
		[Address(RVA = "0xAB4ED4", Offset = "0xAB4ED4", VA = "0xAB4ED4")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6002D63")]
		[Address(RVA = "0xAB519C", Offset = "0xAB519C", VA = "0xAB519C")]
		internal void _003CShowForcedLogoutMessage_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40009B2")]
	public const string c_forceClearInventoryKey = "forceClearInventory";

	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8254AC", Offset = "0x8254AC")]
	private string _003Cm_forceUpdateVersion_003Ek__BackingField;

	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8254BC", Offset = "0x8254BC")]
	private string _003Cm_forceUpdateUrl_003Ek__BackingField;

	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8254CC", Offset = "0x8254CC")]
	private bool _003Cm_forceUpdateAvailable_003Ek__BackingField;

	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x31")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8254DC", Offset = "0x8254DC")]
	private bool _003CshouldForceClearInventory_003Ek__BackingField;

	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x32")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8254EC", Offset = "0x8254EC")]
	private bool _003CpreviousVersionWasBeta_003Ek__BackingField;

	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x33")]
	public bool m_mutexViolationDetected;

	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x38")]
	private ForcedLogoutRequest pendingLogoutRequest;

	[Token(Token = "0x40009BA")]
	private const string m_forceUpdateHeaderName = "Uken-Force-Update";

	[Token(Token = "0x40009BB")]
	private const string m_deviceMutexHeaderName = "Uken-Device-Mutex";

	[Token(Token = "0x40009BC")]
	private const string m_oldInventoryMessage = "We need to collect your most recent save data.\nPlease reload the game.";

	[Token(Token = "0x40009BD")]
	private const string m_deviceMutexMessage = "You have signed in on another device. Please sign in again if you wish to continue playing on this device.";

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x0")]
	private static string m_contentUpdateMessage;

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x40")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x1700015E")]
	public string m_forceUpdateVersion
	{
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xAB4660", Offset = "0xAB4660", VA = "0xAB4660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834768", Offset = "0x834768")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xAB4668", Offset = "0xAB4668", VA = "0xAB4668")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834778", Offset = "0x834778")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015F")]
	public string m_forceUpdateUrl
	{
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0xAB4670", Offset = "0xAB4670", VA = "0xAB4670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834788", Offset = "0x834788")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xAB4678", Offset = "0xAB4678", VA = "0xAB4678")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834798", Offset = "0x834798")]
		private set
		{
		}
	}

	[Token(Token = "0x17000160")]
	public bool m_forceUpdateAvailable
	{
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0xAB4680", Offset = "0xAB4680", VA = "0xAB4680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347A8", Offset = "0x8347A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0xAB4688", Offset = "0xAB4688", VA = "0xAB4688")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347B8", Offset = "0x8347B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000161")]
	public bool shouldForceClearInventory
	{
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xAB4694", Offset = "0xAB4694", VA = "0xAB4694")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347C8", Offset = "0x8347C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xAB469C", Offset = "0xAB469C", VA = "0xAB469C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347D8", Offset = "0x8347D8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000162")]
	public bool previousVersionWasBeta
	{
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xAB46A8", Offset = "0xAB46A8", VA = "0xAB46A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347E8", Offset = "0x8347E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xAB46B0", Offset = "0xAB46B0", VA = "0xAB46B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8347F8", Offset = "0x8347F8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B23")]
	[Address(RVA = "0xAB46BC", Offset = "0xAB46BC", VA = "0xAB46BC")]
	public UpdatesController(CasualDataStoreController dataController, InventoryController inventoryController)
	{
	}

	[Token(Token = "0x6000B24")]
	[Address(RVA = "0xAB46E8", Offset = "0xAB46E8", VA = "0xAB46E8")]
	public void RecordPreviouslyLoadedVersion()
	{
	}

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0xAB4744", Offset = "0xAB4744", VA = "0xAB4744", Slot = "6")]
	public override bool PostLoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B26")]
	[Address(RVA = "0xAB49C8", Offset = "0xAB49C8", VA = "0xAB49C8", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0xAB4AA0", Offset = "0xAB4AA0", VA = "0xAB4AA0")]
	public void ShowSignInMessage()
	{
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0xAB4D98", Offset = "0xAB4D98", VA = "0xAB4D98")]
	public void ShowMutexViolationMessage()
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0xAB4DE8", Offset = "0xAB4DE8", VA = "0xAB4DE8")]
	public void ShowInventoryViolationMessage()
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0xAB4E38", Offset = "0xAB4E38", VA = "0xAB4E38")]
	public void ShowForcedLogoutMessage()
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0xAB4B10", Offset = "0xAB4B10", VA = "0xAB4B10")]
	private void ShowForcedLogoutMessage(string message)
	{
	}

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0xAB4EDC", Offset = "0xAB4EDC", VA = "0xAB4EDC", Slot = "7")]
	public override void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0xAB4F1C", Offset = "0xAB4F1C", VA = "0xAB4F1C")]
	private void HandleRequest(UkenRequest request)
	{
	}
}
