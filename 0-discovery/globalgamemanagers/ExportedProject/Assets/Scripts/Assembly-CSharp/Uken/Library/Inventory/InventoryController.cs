using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Library.Inventory.InventoryInternal;
using Uken.Library.Network;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x200045A")]
	public class InventoryController : UkenController, ITraitInterface
	{
		[Token(Token = "0x2000804")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x2000805")]
		public class InventoryCatalog
		{
			[Token(Token = "0x4002326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, Item> itemDefinitions;

			[Token(Token = "0x60032C0")]
			[Address(RVA = "0xBA4E28", Offset = "0xBA4E28", VA = "0xBA4E28")]
			public InventoryCatalog()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000806")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211F8", Offset = "0x8211F8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<bool> _003C_003E9__84_0;

			[Token(Token = "0x60032C2")]
			[Address(RVA = "0xBA4444", Offset = "0xBA4444", VA = "0xBA4444")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60032C3")]
			[Address(RVA = "0xBA444C", Offset = "0xBA444C", VA = "0xBA444C")]
			internal void _003CPostLoadContent_003Eb__84_0(bool success)
			{
			}
		}

		[Token(Token = "0x2000807")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821208", Offset = "0x821208")]
		private sealed class _003C_003Ec__DisplayClass110_0
		{
			[Token(Token = "0x4002329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x400232A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x400232B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> _003C_003E9__1;

			[Token(Token = "0x60032C4")]
			[Address(RVA = "0xB9E7D0", Offset = "0xB9E7D0", VA = "0xB9E7D0")]
			public _003C_003Ec__DisplayClass110_0()
			{
			}

			[Token(Token = "0x60032C5")]
			[Address(RVA = "0xBA4538", Offset = "0xBA4538", VA = "0xBA4538")]
			internal void _003CQueryInventoryToken_003Eb__0(string tokenResult)
			{
			}

			[Token(Token = "0x60032C6")]
			[Address(RVA = "0xBA46A0", Offset = "0xBA46A0", VA = "0xBA46A0")]
			internal void _003CQueryInventoryToken_003Eb__1(string newToken)
			{
			}
		}

		[Token(Token = "0x2000808")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821218", Offset = "0x821218")]
		private sealed class _003C_003Ec__DisplayClass111_0
		{
			[Token(Token = "0x400232C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x400232D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x60032C7")]
			[Address(RVA = "0xB9E9A8", Offset = "0xB9E9A8", VA = "0xB9E9A8")]
			public _003C_003Ec__DisplayClass111_0()
			{
			}

			[Token(Token = "0x60032C8")]
			[Address(RVA = "0xBA473C", Offset = "0xBA473C", VA = "0xBA473C")]
			internal void _003CQueryInventory_003Eb__0(WebResponse response, WebRequest reqObject)
			{
			}
		}

		[Token(Token = "0x2000809")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821228", Offset = "0x821228")]
		private sealed class _003C_003Ec__DisplayClass112_0
		{
			[Token(Token = "0x400232E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x400232F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x60032C9")]
			[Address(RVA = "0xB9EE38", Offset = "0xB9EE38", VA = "0xB9EE38")]
			public _003C_003Ec__DisplayClass112_0()
			{
			}

			[Token(Token = "0x60032CA")]
			[Address(RVA = "0xBA47D0", Offset = "0xBA47D0", VA = "0xBA47D0")]
			internal void _003CQueryRevision_003Eb__0(WebResponse response, WebRequest sourceRequest)
			{
			}
		}

		[Token(Token = "0x200080A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821238", Offset = "0x821238")]
		private sealed class _003C_003Ec__DisplayClass114_0
		{
			[Token(Token = "0x4002330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x4002331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<string> onTokenFetchComplete;

			[Token(Token = "0x60032CB")]
			[Address(RVA = "0xB9F2DC", Offset = "0xB9F2DC", VA = "0xB9F2DC")]
			public _003C_003Ec__DisplayClass114_0()
			{
			}

			[Token(Token = "0x60032CC")]
			[Address(RVA = "0xBA4860", Offset = "0xBA4860", VA = "0xBA4860")]
			internal void _003CGetToken_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x200080B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821248", Offset = "0x821248")]
		private sealed class _003C_003Ec__DisplayClass115_0
		{
			[Token(Token = "0x4002332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x4002333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<string> onTokenCreateComplete;

			[Token(Token = "0x60032CD")]
			[Address(RVA = "0xB9F410", Offset = "0xB9F410", VA = "0xB9F410")]
			public _003C_003Ec__DisplayClass115_0()
			{
			}

			[Token(Token = "0x60032CE")]
			[Address(RVA = "0xBA4A00", Offset = "0xBA4A00", VA = "0xBA4A00")]
			internal void _003CCreateToken_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x200080C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821258", Offset = "0x821258")]
		private sealed class _003C_003Ec__DisplayClass128_0
		{
			[Token(Token = "0x4002334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BaseInventoryItem item;

			[Token(Token = "0x4002335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x60032CF")]
			[Address(RVA = "0xBA07A4", Offset = "0xBA07A4", VA = "0xBA07A4")]
			public _003C_003Ec__DisplayClass128_0()
			{
			}

			[Token(Token = "0x60032D0")]
			[Address(RVA = "0xBA4BA0", Offset = "0xBA4BA0", VA = "0xBA4BA0")]
			internal bool _003CDeleteItem_003Eb__0()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200080D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821268", Offset = "0x821268")]
		private sealed class _003C_003Ec__DisplayClass129_0
		{
			[Token(Token = "0x4002336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<string> itemTypesNotToDelete;

			[Token(Token = "0x60032D1")]
			[Address(RVA = "0xBA0B44", Offset = "0xBA0B44", VA = "0xBA0B44")]
			public _003C_003Ec__DisplayClass129_0()
			{
			}
		}

		[Token(Token = "0x200080E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821278", Offset = "0x821278")]
		private sealed class _003C_003Ec__DisplayClass129_1
		{
			[Token(Token = "0x4002337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string itemType;

			[Token(Token = "0x4002338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass129_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60032D2")]
			[Address(RVA = "0xBA0B4C", Offset = "0xBA0B4C", VA = "0xBA0B4C")]
			public _003C_003Ec__DisplayClass129_1()
			{
			}

			[Token(Token = "0x60032D3")]
			[Address(RVA = "0xBA4C60", Offset = "0xBA4C60", VA = "0xBA4C60")]
			internal bool _003CDeleteAllItems_003Eb__0()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200080F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821288", Offset = "0x821288")]
		private sealed class _003C_003Ec__DisplayClass144_0
		{
			[Token(Token = "0x4002339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> onInventorySent;

			[Token(Token = "0x400233A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InventoryController _003C_003E4__this;

			[Token(Token = "0x60032D4")]
			[Address(RVA = "0xBA1E10", Offset = "0xBA1E10", VA = "0xBA1E10")]
			public _003C_003Ec__DisplayClass144_0()
			{
			}

			[Token(Token = "0x60032D5")]
			[Address(RVA = "0xBA4CE4", Offset = "0xBA4CE4", VA = "0xBA4CE4")]
			internal void _003CSendInventory_003Eb__0(WebResponse response, WebRequest reqObject)
			{
			}
		}

		[Token(Token = "0x4001413")]
		public const int c_maxSyncDelayInSeconds = 180;

		[Token(Token = "0x4001414")]
		protected const float c_minTimeInSecondsToSendAfterNetworkReconnect = 3.5f;

		[Token(Token = "0x4001415")]
		private const string c_timeSinceFirstChangeKey = "inv_first_change_time";

		[Token(Token = "0x4001416")]
		public const string c_invalidToken = "default";

		[Token(Token = "0x4001417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string inventoryFileName;

		[Token(Token = "0x4001418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string unitTestInventoryFileName;

		[Token(Token = "0x4001419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string defaultInventoryFilePath;

		[Token(Token = "0x400141A")]
		public const string c_nullItemType = "na";

		[Token(Token = "0x400141B")]
		public const string c_equipmentModelReference = "equipment_model";

		[Token(Token = "0x400141C")]
		protected const long DefaultUserLevel = 1L;

		[Token(Token = "0x400141D")]
		private const int c_maxDeletesPerServerRequest = 50;

		[Token(Token = "0x400141E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> deleteWhitelist;

		[Token(Token = "0x400141F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected float m_saveToDiskInterval;

		[Token(Token = "0x4001420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected int m_syncDelayInSeconds;

		[Token(Token = "0x4001421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E5F8", Offset = "0x82E5F8")]
		private bool _003Cm_bOffline_003Ek__BackingField;

		[Token(Token = "0x4001422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E608", Offset = "0x82E608")]
		private bool _003Cm_bInventoryFailure_003Ek__BackingField;

		[Token(Token = "0x4001423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected HashSet<string> m_logEventNameBlackList;

		[Token(Token = "0x4001424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Dictionary<string, BaseInventoryItem> m_InventoryData;

		[Token(Token = "0x4001425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, BaseInventoryItem> m_Dirty;

		[Token(Token = "0x4001426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, BaseInventoryItem> m_InFlight;

		[Token(Token = "0x4001427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, InventoryRevision> m_UnprocessedRevisions;

		[Token(Token = "0x4001428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<string> m_ConsumedRevisions;

		[Token(Token = "0x4001429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<string> m_InFlightConsumedRevisions;

		[Token(Token = "0x400142A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected float m_timeSinceLastChange;

		[Token(Token = "0x400142B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected float m_timeSinceFirstChange;

		[Token(Token = "0x400142C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected float m_timeSinceLastSave;

		[Token(Token = "0x400142D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E618", Offset = "0x82E618")]
		private string _003CInventoryToken_003Ek__BackingField;

		[Token(Token = "0x400142E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E628", Offset = "0x82E628")]
		private string _003CServerToken_003Ek__BackingField;

		[Token(Token = "0x400142F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E638", Offset = "0x82E638")]
		private bool _003CbInitialized_003Ek__BackingField;

		[Token(Token = "0x4001430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E648", Offset = "0x82E648")]
		private bool _003CbLoaded_003Ek__BackingField;

		[Token(Token = "0x4001431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E658", Offset = "0x82E658")]
		private string _003Cm_softCurrencyName_003Ek__BackingField;

		[Token(Token = "0x4001432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E668", Offset = "0x82E668")]
		private string _003Cm_hardCurrencyName_003Ek__BackingField;

		[Token(Token = "0x4001433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E678", Offset = "0x82E678")]
		private bool _003CusingDefaultInventory_003Ek__BackingField;

		[Token(Token = "0x4001434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected GetUserIDFunc m_GetUserID;

		[Token(Token = "0x4001435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Action<WebRequest> m_webInterface;

		[Token(Token = "0x4001436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected List<string> m_criticalItems;

		[Token(Token = "0x4001437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<IInventoryProgressTracker> m_progressTrackers;

		[Token(Token = "0x4001438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Dictionary<string, ItemMinimalDetails> m_itemsDetails;

		[Token(Token = "0x4001439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected HashSet<string> m_equipmentModels;

		[Token(Token = "0x400143A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected ItemReferenceIndex m_itemRefsByItemType;

		[Token(Token = "0x400143B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected Dictionary<string, ITraitAppender> m_traitAppenders;

		[Token(Token = "0x400143C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E688", Offset = "0x82E688")]
		private bool _003CenforceStrictTyping_003Ek__BackingField;

		[Token(Token = "0x400143D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected InventoryApiClient m_apiClient;

		[Token(Token = "0x400143E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected InventoryApiConfig m_apiConfig;

		[Token(Token = "0x400143F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected UkenAuth m_authenticator;

		[Token(Token = "0x4001440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected INetworkStatus m_networkStatus;

		[Token(Token = "0x4001441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool newDelete;

		[Token(Token = "0x4001442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly HashSet<string> itemsToDelete;

		[Token(Token = "0x4001443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected bool m_crashWhenNotReadyForUse;

		[Token(Token = "0x4001444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected string m_QueryURL;

		[Token(Token = "0x4001445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected string m_TokenURL;

		[Token(Token = "0x4001446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected string m_RevisionURL;

		[Token(Token = "0x170005B5")]
		public bool m_bOffline
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0xB9B818", Offset = "0xB9B818", VA = "0xB9B818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391A4", Offset = "0x8391A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0xB9B820", Offset = "0xB9B820", VA = "0xB9B820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391B4", Offset = "0x8391B4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005B6")]
		public bool m_bInventoryFailure
		{
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0xB9B82C", Offset = "0xB9B82C", VA = "0xB9B82C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391C4", Offset = "0x8391C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002000")]
			[Address(RVA = "0xB9B834", Offset = "0xB9B834", VA = "0xB9B834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391D4", Offset = "0x8391D4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005B7")]
		public float timeSinceFirstChange
		{
			[Token(Token = "0x6002001")]
			[Address(RVA = "0xB9B840", Offset = "0xB9B840", VA = "0xB9B840")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170005B8")]
		public string InventoryToken
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0xB9B848", Offset = "0xB9B848", VA = "0xB9B848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391E4", Offset = "0x8391E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002003")]
			[Address(RVA = "0xB9B850", Offset = "0xB9B850", VA = "0xB9B850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8391F4", Offset = "0x8391F4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005B9")]
		public string ServerToken
		{
			[Token(Token = "0x6002004")]
			[Address(RVA = "0xB9B858", Offset = "0xB9B858", VA = "0xB9B858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839204", Offset = "0x839204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002005")]
			[Address(RVA = "0xB9B860", Offset = "0xB9B860", VA = "0xB9B860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839214", Offset = "0x839214")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005BA")]
		public bool bInitialized
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0xB9B868", Offset = "0xB9B868", VA = "0xB9B868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839224", Offset = "0x839224")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0xB9B870", Offset = "0xB9B870", VA = "0xB9B870")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839234", Offset = "0x839234")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005BB")]
		public bool bLoaded
		{
			[Token(Token = "0x6002008")]
			[Address(RVA = "0xB9B87C", Offset = "0xB9B87C", VA = "0xB9B87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839244", Offset = "0x839244")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002009")]
			[Address(RVA = "0xB9B884", Offset = "0xB9B884", VA = "0xB9B884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839254", Offset = "0x839254")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005BC")]
		public string m_softCurrencyName
		{
			[Token(Token = "0x600200A")]
			[Address(RVA = "0xB9B890", Offset = "0xB9B890", VA = "0xB9B890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839264", Offset = "0x839264")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200B")]
			[Address(RVA = "0xB9B898", Offset = "0xB9B898", VA = "0xB9B898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839274", Offset = "0x839274")]
			private set
			{
			}
		}

		[Token(Token = "0x170005BD")]
		public string m_hardCurrencyName
		{
			[Token(Token = "0x600200C")]
			[Address(RVA = "0xB9B8A0", Offset = "0xB9B8A0", VA = "0xB9B8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839284", Offset = "0x839284")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200D")]
			[Address(RVA = "0xB9B8A8", Offset = "0xB9B8A8", VA = "0xB9B8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839294", Offset = "0x839294")]
			private set
			{
			}
		}

		[Token(Token = "0x170005BE")]
		public bool usingDefaultInventory
		{
			[Token(Token = "0x600200E")]
			[Address(RVA = "0xB9B8B0", Offset = "0xB9B8B0", VA = "0xB9B8B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392A4", Offset = "0x8392A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200F")]
			[Address(RVA = "0xB9B8B8", Offset = "0xB9B8B8", VA = "0xB9B8B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392B4", Offset = "0x8392B4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005BF")]
		public bool enforceStrictTyping
		{
			[Token(Token = "0x6002010")]
			[Address(RVA = "0xB9B8C4", Offset = "0xB9B8C4", VA = "0xB9B8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392C4", Offset = "0x8392C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002011")]
			[Address(RVA = "0xB9B8CC", Offset = "0xB9B8CC", VA = "0xB9B8CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392D4", Offset = "0x8392D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6002012")]
		[Address(RVA = "0xB9B8D8", Offset = "0xB9B8D8", VA = "0xB9B8D8")]
		public InventoryController(string softCurrencyName, string hardCurrencyName, GetUserIDFunc userIDFunc, Action<WebRequest> webInterface, bool inEnforceStrictTyping, UkenAuth authenticator, INetworkStatus networkStatus, bool enableCrashOnMinimalDetailsNotReady)
		{
		}

		[Token(Token = "0x6002013")]
		[Address(RVA = "0xB9BCBC", Offset = "0xB9BCBC", VA = "0xB9BCBC", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002014")]
		[Address(RVA = "0xB9C9F0", Offset = "0xB9C9F0", VA = "0xB9C9F0")]
		public void AddBlackListedLogEventName(string eventName)
		{
		}

		[Token(Token = "0x6002015")]
		[Address(RVA = "0xB9CA60", Offset = "0xB9CA60", VA = "0xB9CA60")]
		public void RegisterCriticalItems(List<string> criticalItems)
		{
		}

		[Token(Token = "0x6002016")]
		[Address(RVA = "0xB9CAD8", Offset = "0xB9CAD8", VA = "0xB9CAD8")]
		public IEnumerable<InventoryRevision> GetUnProcessedRevisions()
		{
			return null;
		}

		[Token(Token = "0x6002017")]
		[Address(RVA = "0xB9CB38", Offset = "0xB9CB38", VA = "0xB9CB38")]
		public void RegisterEquipmentModel(string itemType, IItemModelIndexer itemModel, ITraitAppender traitAppender)
		{
		}

		[Token(Token = "0x6002018")]
		[Address(RVA = "0xB9CC1C", Offset = "0xB9CC1C", VA = "0xB9CC1C")]
		public void RegisterModel(IItemModelIndexer itemModel)
		{
		}

		[Token(Token = "0x6002019")]
		[Address(RVA = "0xB9CE04", Offset = "0xB9CE04", VA = "0xB9CE04")]
		public void RegisterItem(string itemReference, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x600201A")]
		[Address(RVA = "0xB9D19C", Offset = "0xB9D19C", VA = "0xB9D19C")]
		public bool IsTokenValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600201B")]
		[Address(RVA = "0xB9D1AC", Offset = "0xB9D1AC", VA = "0xB9D1AC", Slot = "15")]
		public virtual bool IsReadyForUse()
		{
			return default(bool);
		}

		[Token(Token = "0x600201C")]
		[Address(RVA = "0xB9D60C", Offset = "0xB9D60C", VA = "0xB9D60C")]
		public string GetUserID()
		{
			return null;
		}

		[Token(Token = "0x600201D")]
		[Address(RVA = "0xB9D638", Offset = "0xB9D638", VA = "0xB9D638", Slot = "16")]
		public virtual long GetUserLevel()
		{
			return default(long);
		}

		[Token(Token = "0x600201E")]
		[Address(RVA = "0xB9D640", Offset = "0xB9D640", VA = "0xB9D640")]
		public PlayerDataItem GetPlayerData()
		{
			return null;
		}

		[Token(Token = "0x600201F")]
		[Address(RVA = "0xB9DA88", Offset = "0xB9DA88", VA = "0xB9DA88", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002020")]
		[Address(RVA = "0xB9DAF0", Offset = "0xB9DAF0", VA = "0xB9DAF0", Slot = "17")]
		public virtual void SetServerToken(string serverToken)
		{
		}

		[Token(Token = "0x6002021")]
		[Address(RVA = "0xB9DAF8", Offset = "0xB9DAF8", VA = "0xB9DAF8", Slot = "18")]
		public virtual void SetBaseURL(string baseURL)
		{
		}

		[Token(Token = "0x6002022")]
		[Address(RVA = "0xB9DBB4", Offset = "0xB9DBB4", VA = "0xB9DBB4")]
		public bool itemIsDirty(string itemRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6002023")]
		[Address(RVA = "0xB9DC44", Offset = "0xB9DC44", VA = "0xB9DC44", Slot = "19")]
		protected virtual bool Save()
		{
			return default(bool);
		}

		[Token(Token = "0x6002024")]
		[Address(RVA = "0xB9DEDC", Offset = "0xB9DEDC", VA = "0xB9DEDC", Slot = "20")]
		public virtual Dictionary<string, object> GetSaveStorageDict()
		{
			return null;
		}

		[Token(Token = "0x6002025")]
		[Address(RVA = "0xB9E1E8", Offset = "0xB9E1E8", VA = "0xB9E1E8")]
		public void UpdateDefaultInventory()
		{
		}

		[Token(Token = "0x6002026")]
		[Address(RVA = "0xB9E2B4", Offset = "0xB9E2B4", VA = "0xB9E2B4", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002027")]
		[Address(RVA = "0xB9E534", Offset = "0xB9E534", VA = "0xB9E534", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002028")]
		[Address(RVA = "0xB9E5A0", Offset = "0xB9E5A0", VA = "0xB9E5A0")]
		public void RegisterProgressTracker(IInventoryProgressTracker progressTracker)
		{
		}

		[Token(Token = "0x6002029")]
		[Address(RVA = "0xB9E610", Offset = "0xB9E610", VA = "0xB9E610", Slot = "21")]
		public virtual string GetDefaultInventory()
		{
			return null;
		}

		[Token(Token = "0x600202A")]
		[Address(RVA = "0xB9E6F8", Offset = "0xB9E6F8", VA = "0xB9E6F8", Slot = "22")]
		public virtual void QueryInventoryToken(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x600202B")]
		[Address(RVA = "0xB9E7D8", Offset = "0xB9E7D8", VA = "0xB9E7D8", Slot = "23")]
		public virtual void QueryInventory(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x600202C")]
		[Address(RVA = "0xB9EC9C", Offset = "0xB9EC9C", VA = "0xB9EC9C", Slot = "24")]
		protected virtual void QueryRevision(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x600202D")]
		[Address(RVA = "0xB9EE40", Offset = "0xB9EE40", VA = "0xB9EE40")]
		protected void OnRevisionQueryComplete(WebResponse response, WebRequest sourceRequest)
		{
		}

		[Token(Token = "0x600202E")]
		[Address(RVA = "0xB9F1B4", Offset = "0xB9F1B4", VA = "0xB9F1B4", Slot = "25")]
		protected virtual void GetToken(Action<string> onTokenFetchComplete)
		{
		}

		[Token(Token = "0x600202F")]
		[Address(RVA = "0xB9F2E4", Offset = "0xB9F2E4", VA = "0xB9F2E4")]
		private void CreateToken(Action<string> onTokenCreateComplete)
		{
		}

		[Token(Token = "0x6002030")]
		[Address(RVA = "0xB9C864", Offset = "0xB9C864", VA = "0xB9C864")]
		protected void MarkAllDirty()
		{
		}

		[Token(Token = "0x6002031")]
		[Address(RVA = "0xB9E9B0", Offset = "0xB9E9B0", VA = "0xB9E9B0")]
		private void OnQueryComplete(bool success, string jsonText, Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002032")]
		public T FindOrCreateItem<T>(string reference) where T : Item, new()
		{
			return null;
		}

		[Token(Token = "0x6002033")]
		public T GetItemIfHasItem<T>(string reference) where T : Item, new()
		{
			return null;
		}

		[Token(Token = "0x6002034")]
		[Address(RVA = "0xB9F638", Offset = "0xB9F638", VA = "0xB9F638")]
		public bool HasItem(string reference)
		{
			return default(bool);
		}

		[Token(Token = "0x6002035")]
		[Address(RVA = "0xB9F6A8", Offset = "0xB9F6A8", VA = "0xB9F6A8")]
		public bool ClearItem(string itemRef, string event_name, string source_sink)
		{
			return default(bool);
		}

		[Token(Token = "0x6002036")]
		[Address(RVA = "0xB9F7D8", Offset = "0xB9F7D8", VA = "0xB9F7D8")]
		protected bool SetItem(string reference, long quantity, string event_name, string source_sink)
		{
			return default(bool);
		}

		[Token(Token = "0x6002037")]
		[Address(RVA = "0xB9F8C0", Offset = "0xB9F8C0", VA = "0xB9F8C0")]
		private bool updateBaseInventoryItem(BaseInventoryItem inventoryBaseInventoryItem, long quantity, string event_name, string source_sink)
		{
			return default(bool);
		}

		[Token(Token = "0x6002038")]
		[Address(RVA = "0xB9C590", Offset = "0xB9C590", VA = "0xB9C590")]
		public long QuantityOfItem(string reference)
		{
			return default(long);
		}

		[Token(Token = "0x6002039")]
		[Address(RVA = "0xB9FCC8", Offset = "0xB9FCC8", VA = "0xB9FCC8")]
		public void ConsumeRevision(string revisionID)
		{
		}

		[Token(Token = "0x600203A")]
		[Address(RVA = "0xB9FDE4", Offset = "0xB9FDE4", VA = "0xB9FDE4", Slot = "26")]
		public virtual bool Transaction(string reference, long delta, string event_name, string source_sink)
		{
			return default(bool);
		}

		[Token(Token = "0x600203B")]
		[Address(RVA = "0xBA046C", Offset = "0xBA046C", VA = "0xBA046C", Slot = "27")]
		public virtual void Transaction(Dictionary<string, long> deltas, string event_name, string source_sink)
		{
		}

		[Token(Token = "0x600203C")]
		[Address(RVA = "0xBA05FC", Offset = "0xBA05FC", VA = "0xBA05FC", Slot = "28")]
		public virtual bool DeleteItem(string reference, string event_name, string source_sink, [Optional] Func<bool> deleteItemTypeCondition)
		{
			return default(bool);
		}

		[Token(Token = "0x600203D")]
		[Address(RVA = "0xBA07AC", Offset = "0xBA07AC", VA = "0xBA07AC")]
		public bool DeleteAllItems(HashSet<string> itemsToNotDelete, HashSet<string> itemTypesNotToDelete, string event_name, string source_sink)
		{
			return default(bool);
		}

		[Token(Token = "0x600203E")]
		[Address(RVA = "0xB9C6BC", Offset = "0xB9C6BC", VA = "0xB9C6BC")]
		public ItemMinimalDetails GetItemDetails(string reference)
		{
			return null;
		}

		[Token(Token = "0x600203F")]
		[Address(RVA = "0xBA0B90", Offset = "0xBA0B90", VA = "0xBA0B90")]
		private ItemMinimalDetails GetRegisteredItemDetails(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002040")]
		[Address(RVA = "0xBA0C18", Offset = "0xBA0C18", VA = "0xBA0C18")]
		private ItemMinimalDetails GetEquipmentItemDetails(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002041")]
		[Address(RVA = "0xBA0CE8", Offset = "0xBA0CE8", VA = "0xBA0CE8")]
		protected string GetEquipmentModelRefFromItem(string itemRef)
		{
			return null;
		}

		[Token(Token = "0x6002042")]
		[Address(RVA = "0xB9D7E8", Offset = "0xB9D7E8", VA = "0xB9D7E8")]
		protected bool CreateItem(string reference, bool markAsDirty = true, [Optional] string itemModelReference)
		{
			return default(bool);
		}

		[Token(Token = "0x6002043")]
		[Address(RVA = "0xBA024C", Offset = "0xBA024C", VA = "0xBA024C")]
		protected void AddTraitsToNewItem(string itemModelReference, string reference)
		{
		}

		[Token(Token = "0x6002044")]
		[Address(RVA = "0xBA017C", Offset = "0xBA017C", VA = "0xBA017C")]
		protected string GenerateReferenceForItemCreation(string reference, long delta)
		{
			return null;
		}

		[Token(Token = "0x6002045")]
		[Address(RVA = "0xBA113C", Offset = "0xBA113C", VA = "0xBA113C")]
		protected bool IsItemARegisteredEquipmentType(string reference)
		{
			return default(bool);
		}

		[Token(Token = "0x6002046")]
		[Address(RVA = "0xBA1174", Offset = "0xBA1174", VA = "0xBA1174")]
		protected bool IsEquipmentType(string itemType)
		{
			return default(bool);
		}

		[Token(Token = "0x6002047")]
		[Address(RVA = "0xBA11E4", Offset = "0xBA11E4", VA = "0xBA11E4")]
		public HashSet<string> GetAllItemRefsOfType(string itemType)
		{
			return null;
		}

		[Token(Token = "0x6002048")]
		public List<T> GetAllExistingItemsOfType<T>(string itemType) where T : Item, new()
		{
			return null;
		}

		[Token(Token = "0x6002049")]
		[Address(RVA = "0xBA12D8", Offset = "0xBA12D8", VA = "0xBA12D8", Slot = "29")]
		public virtual void OnInventoryFailure(string reason)
		{
		}

		[Token(Token = "0x600204A")]
		[Address(RVA = "0xBA12DC", Offset = "0xBA12DC", VA = "0xBA12DC", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600204B")]
		[Address(RVA = "0xBA0FD0", Offset = "0xBA0FD0", VA = "0xBA0FD0")]
		protected void storeInventoryItem(BaseInventoryItem item, bool markAsDirty = true)
		{
		}

		[Token(Token = "0x600204C")]
		[Address(RVA = "0xBA14E4", Offset = "0xBA14E4", VA = "0xBA14E4", Slot = "30")]
		public virtual void SendInventory([Optional] Action<bool> onInventorySent)
		{
		}

		[Token(Token = "0x600204D")]
		[Address(RVA = "0xBA1E18", Offset = "0xBA1E18", VA = "0xBA1E18", Slot = "31")]
		public virtual void SendDeletedItems()
		{
		}

		[Token(Token = "0x600204E")]
		[Address(RVA = "0xBA1F7C", Offset = "0xBA1F7C", VA = "0xBA1F7C")]
		private HashSet<string> GetDeletedItems()
		{
			return null;
		}

		[Token(Token = "0x600204F")]
		[Address(RVA = "0xBA225C", Offset = "0xBA225C", VA = "0xBA225C", Slot = "32")]
		protected virtual void SendInventoryRequest(WebRequest request)
		{
		}

		[Token(Token = "0x6002050")]
		[Address(RVA = "0xBA22CC", Offset = "0xBA22CC", VA = "0xBA22CC", Slot = "33")]
		protected virtual void OnSendComplete(bool success, string jsonText)
		{
		}

		[Token(Token = "0x6002051")]
		[Address(RVA = "0xBA2AE8", Offset = "0xBA2AE8", VA = "0xBA2AE8", Slot = "34")]
		protected virtual void OnDeleteComplete(bool success, string jsonText)
		{
		}

		[Token(Token = "0x6002052")]
		[Address(RVA = "0xBA2600", Offset = "0xBA2600", VA = "0xBA2600")]
		private void MergeInFlightToDirty()
		{
		}

		[Token(Token = "0x6002053")]
		[Address(RVA = "0xBA2E5C", Offset = "0xBA2E5C", VA = "0xBA2E5C")]
		public string GetFileName(string userID)
		{
			return null;
		}

		[Token(Token = "0x6002054")]
		[Address(RVA = "0xB9DE50", Offset = "0xB9DE50", VA = "0xB9DE50")]
		public string GetFilePath(string userID)
		{
			return null;
		}

		[Token(Token = "0x6002055")]
		[Address(RVA = "0xBA2EDC", Offset = "0xBA2EDC", VA = "0xBA2EDC", Slot = "35")]
		protected virtual void parseJson(string json, bool fromServer)
		{
		}

		[Token(Token = "0x6002056")]
		[Address(RVA = "0xBA0378", Offset = "0xBA0378", VA = "0xBA0378")]
		private void AddItemToIndexes(BaseInventoryItem item)
		{
		}

		[Token(Token = "0x6002057")]
		[Address(RVA = "0xBA3D24", Offset = "0xBA3D24", VA = "0xBA3D24")]
		private BaseInventoryItem GetBaseItemFromReference(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002058")]
		[Address(RVA = "0xBA3E18", Offset = "0xBA3E18", VA = "0xBA3E18")]
		public bool SetItemTrait(string reference, string traitKey, string traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6002059")]
		[Address(RVA = "0xBA3E58", Offset = "0xBA3E58", VA = "0xBA3E58")]
		public bool SetItemTrait(string reference, string traitKey, int traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205A")]
		[Address(RVA = "0xBA3EA4", Offset = "0xBA3EA4", VA = "0xBA3EA4")]
		public bool SetItemTrait(string reference, string traitKey, long traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205B")]
		[Address(RVA = "0xBA3EF0", Offset = "0xBA3EF0", VA = "0xBA3EF0")]
		public bool SetItemTrait(string reference, string traitKey, bool traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205C")]
		[Address(RVA = "0xBA3F3C", Offset = "0xBA3F3C", VA = "0xBA3F3C")]
		public bool SetItemTrait(string reference, string traitKey, double traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205D")]
		[Address(RVA = "0xB9C780", Offset = "0xB9C780", VA = "0xB9C780", Slot = "10")]
		public bool SetItemTrait(BaseInventoryItem item, string traitKey, string traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205E")]
		[Address(RVA = "0xBA3F88", Offset = "0xBA3F88", VA = "0xBA3F88", Slot = "36")]
		public virtual bool SetItemTrait(BaseInventoryItem item, string traitKey, int traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600205F")]
		[Address(RVA = "0xBA406C", Offset = "0xBA406C", VA = "0xBA406C", Slot = "37")]
		public virtual bool SetItemTrait(BaseInventoryItem item, string traitKey, long traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6002060")]
		[Address(RVA = "0xBA4154", Offset = "0xBA4154", VA = "0xBA4154", Slot = "38")]
		public virtual bool SetItemTrait(BaseInventoryItem item, string traitKey, bool traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6002061")]
		[Address(RVA = "0xBA423C", Offset = "0xBA423C", VA = "0xBA423C", Slot = "39")]
		public virtual bool SetItemTrait(BaseInventoryItem item, string traitKey, double traitValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6002062")]
		[Address(RVA = "0xB9F560", Offset = "0xB9F560", VA = "0xB9F560")]
		protected void MarkItemDirty(BaseInventoryItem item)
		{
		}

		[Token(Token = "0x6002063")]
		[Address(RVA = "0xBA4324", Offset = "0xBA4324", VA = "0xBA4324", Slot = "40")]
		protected virtual void LogTransaction(BaseInventoryItem item, long delta, string eventName, string sourceSink)
		{
		}

		[Token(Token = "0x6002065")]
		[Address(RVA = "0xBA43B0", Offset = "0xBA43B0", VA = "0xBA43B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392E4", Offset = "0x8392E4")]
		private void _003CSendDeletedItems_003Eb__145_0(Dictionary<string, string> header, string s)
		{
		}

		[Token(Token = "0x6002066")]
		[Address(RVA = "0xBA43C4", Offset = "0xBA43C4", VA = "0xBA43C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392F4", Offset = "0x8392F4")]
		private void _003CSendDeletedItems_003Eb__145_1(Dictionary<string, string> header, long code, string s)
		{
		}
	}
}
