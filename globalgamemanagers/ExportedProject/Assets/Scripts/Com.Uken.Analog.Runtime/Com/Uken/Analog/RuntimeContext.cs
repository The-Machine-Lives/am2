using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000050")]
	public class RuntimeContext
	{
		[Token(Token = "0x400012B")]
		public const string LIVES = "lives";

		[Token(Token = "0x400012C")]
		public const string HARD_CURRENCY = "hard_currency";

		[Token(Token = "0x400012D")]
		public const string LEVEL = "level";

		[Token(Token = "0x400012E")]
		public const string SOFT_CURRENCY = "soft_currency";

		[Token(Token = "0x400012F")]
		public const string USER_ID = "user_id";

		[Token(Token = "0x4000130")]
		public const string XP = "xp";

		[Token(Token = "0x4000131")]
		public const string ADID = "adid";

		[Token(Token = "0x4000132")]
		public const string THIRD_PARTY = "third_party";

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		private readonly AnalogDeviceId analogDeviceId;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8154B0", Offset = "0x8154B0")]
		private App.GameName _003CGame_003Ek__BackingField;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8154C0", Offset = "0x8154C0")]
		private App.EnvironmentName _003CEnvironment_003Ek__BackingField;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8154D0", Offset = "0x8154D0")]
		private string _003CSchemaVersion_003Ek__BackingField;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8154E0", Offset = "0x8154E0")]
		private Guid _003CSessionId_003Ek__BackingField;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8154F0", Offset = "0x8154F0")]
		private string _003CAppVersion_003Ek__BackingField;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815500", Offset = "0x815500")]
		private PlatformName _003CPlatform_003Ek__BackingField;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815510", Offset = "0x815510")]
		private string _003CUserAgent_003Ek__BackingField;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815520", Offset = "0x815520")]
		private string _003CDeviceId_003Ek__BackingField;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815530", Offset = "0x815530")]
		private string _003CLocaleIdentifier_003Ek__BackingField;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815540", Offset = "0x815540")]
		private Dictionary<string, object> _003CContext_003Ek__BackingField;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815550", Offset = "0x815550")]
		private string _003CAdid_003Ek__BackingField;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815560", Offset = "0x815560")]
		private string _003CIdfa_003Ek__BackingField;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815570", Offset = "0x815570")]
		private string _003CIfv_003Ek__BackingField;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815580", Offset = "0x815580")]
		private string _003CAndroidId_003Ek__BackingField;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815590", Offset = "0x815590")]
		private ThirdParty _003CThirdParty_003Ek__BackingField;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155A0", Offset = "0x8155A0")]
		private string _003CUserId_003Ek__BackingField;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155B0", Offset = "0x8155B0")]
		private int _003CLevel_003Ek__BackingField;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155C0", Offset = "0x8155C0")]
		private long _003CXp_003Ek__BackingField;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155D0", Offset = "0x8155D0")]
		private long _003CSoftCurrency_003Ek__BackingField;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155E0", Offset = "0x8155E0")]
		private long _003CHardCurrency_003Ek__BackingField;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8155F0", Offset = "0x8155F0")]
		private long _003CLives_003Ek__BackingField;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815600", Offset = "0x815600")]
		private bool _003CIsOnline_003Ek__BackingField;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815610", Offset = "0x815610")]
		private Dictionary<string, string> _003CAbTests_003Ek__BackingField;

		[Token(Token = "0x1700007D")]
		public App.GameName Game
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x16D61C4", Offset = "0x16D61C4", VA = "0x16D61C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815864", Offset = "0x815864")]
			get
			{
				return default(App.GameName);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x16DA2C0", Offset = "0x16DA2C0", VA = "0x16DA2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815874", Offset = "0x815874")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public App.EnvironmentName Environment
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x16D61CC", Offset = "0x16D61CC", VA = "0x16D61CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815884", Offset = "0x815884")]
			get
			{
				return default(App.EnvironmentName);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x16DA2D0", Offset = "0x16DA2D0", VA = "0x16DA2D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815894", Offset = "0x815894")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public string SchemaVersion
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x16D6120", Offset = "0x16D6120", VA = "0x16D6120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158A4", Offset = "0x8158A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x16DA2D8", Offset = "0x16DA2D8", VA = "0x16DA2D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158B4", Offset = "0x8158B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Guid SessionId
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x16D0210", Offset = "0x16D0210", VA = "0x16D0210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158C4", Offset = "0x8158C4")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x16DA374", Offset = "0x16DA374", VA = "0x16DA374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158D4", Offset = "0x8158D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public string AppVersion
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x16D61D4", Offset = "0x16D61D4", VA = "0x16D61D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158E4", Offset = "0x8158E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x16DA2E0", Offset = "0x16DA2E0", VA = "0x16DA2E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8158F4", Offset = "0x8158F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public PlatformName Platform
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x16D61DC", Offset = "0x16D61DC", VA = "0x16D61DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815904", Offset = "0x815904")]
			get
			{
				return default(PlatformName);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x16DA290", Offset = "0x16DA290", VA = "0x16DA290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815914", Offset = "0x815914")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public string UserAgent
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x16D61E4", Offset = "0x16D61E4", VA = "0x16D61E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815924", Offset = "0x815924")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x16DA2E8", Offset = "0x16DA2E8", VA = "0x16DA2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815934", Offset = "0x815934")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public string DeviceId
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x16D61EC", Offset = "0x16D61EC", VA = "0x16D61EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815944", Offset = "0x815944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x16DA2F0", Offset = "0x16DA2F0", VA = "0x16DA2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815954", Offset = "0x815954")]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public string LocaleIdentifier
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x16D4CE0", Offset = "0x16D4CE0", VA = "0x16D4CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815964", Offset = "0x815964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x16DA2B8", Offset = "0x16DA2B8", VA = "0x16DA2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815974", Offset = "0x815974")]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public virtual Dictionary<string, object> Context
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x16DA37C", Offset = "0x16DA37C", VA = "0x16DA37C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815984", Offset = "0x815984")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x16DA384", Offset = "0x16DA384", VA = "0x16DA384", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815994", Offset = "0x815994")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public virtual string Adid
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x16DA38C", Offset = "0x16DA38C", VA = "0x16DA38C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159A4", Offset = "0x8159A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x16DA298", Offset = "0x16DA298", VA = "0x16DA298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159B4", Offset = "0x8159B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public virtual string Idfa
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x16DA394", Offset = "0x16DA394", VA = "0x16DA394", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159C4", Offset = "0x8159C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x16DA2A0", Offset = "0x16DA2A0", VA = "0x16DA2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159D4", Offset = "0x8159D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public virtual string Ifv
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x16DA39C", Offset = "0x16DA39C", VA = "0x16DA39C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159E4", Offset = "0x8159E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x16DA2A8", Offset = "0x16DA2A8", VA = "0x16DA2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8159F4", Offset = "0x8159F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public virtual string AndroidId
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x16DA3A4", Offset = "0x16DA3A4", VA = "0x16DA3A4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A04", Offset = "0x815A04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x16DA2B0", Offset = "0x16DA2B0", VA = "0x16DA2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A14", Offset = "0x815A14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public virtual ThirdParty ThirdParty
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x16DA3AC", Offset = "0x16DA3AC", VA = "0x16DA3AC", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A24", Offset = "0x815A24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x16DA2C8", Offset = "0x16DA2C8", VA = "0x16DA2C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A34", Offset = "0x815A34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public virtual string UserId
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x16DA3B4", Offset = "0x16DA3B4", VA = "0x16DA3B4", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A44", Offset = "0x815A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x16DA3BC", Offset = "0x16DA3BC", VA = "0x16DA3BC", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A54", Offset = "0x815A54")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual int Level
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x16DA3C4", Offset = "0x16DA3C4", VA = "0x16DA3C4", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A64", Offset = "0x815A64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x16DA3CC", Offset = "0x16DA3CC", VA = "0x16DA3CC", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A74", Offset = "0x815A74")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual long Xp
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x16DA3D4", Offset = "0x16DA3D4", VA = "0x16DA3D4", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A84", Offset = "0x815A84")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x16DA3DC", Offset = "0x16DA3DC", VA = "0x16DA3DC", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815A94", Offset = "0x815A94")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual long SoftCurrency
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x16DA3E4", Offset = "0x16DA3E4", VA = "0x16DA3E4", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AA4", Offset = "0x815AA4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x16DA3EC", Offset = "0x16DA3EC", VA = "0x16DA3EC", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AB4", Offset = "0x815AB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public virtual long HardCurrency
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x16DA3F4", Offset = "0x16DA3F4", VA = "0x16DA3F4", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AC4", Offset = "0x815AC4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x16DA3FC", Offset = "0x16DA3FC", VA = "0x16DA3FC", Slot = "20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AD4", Offset = "0x815AD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public virtual long Lives
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x16DA404", Offset = "0x16DA404", VA = "0x16DA404", Slot = "21")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AE4", Offset = "0x815AE4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x16DA40C", Offset = "0x16DA40C", VA = "0x16DA40C", Slot = "22")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815AF4", Offset = "0x815AF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public virtual bool IsOnline
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x16DA414", Offset = "0x16DA414", VA = "0x16DA414", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B04", Offset = "0x815B04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x16DA41C", Offset = "0x16DA41C", VA = "0x16DA41C", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B14", Offset = "0x815B14")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public virtual Dictionary<string, string> AbTests
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x16DA428", Offset = "0x16DA428", VA = "0x16DA428", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B24", Offset = "0x815B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x16DA430", Offset = "0x16DA430", VA = "0x16DA430", Slot = "26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815B34", Offset = "0x815B34")]
			set
			{
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x16D129C", Offset = "0x16D129C", VA = "0x16D129C")]
		public RuntimeContext(App.GameName game, App.EnvironmentName environment, string userId, string appVersion, int level, long xp, long softCurrency, long hardCurrency, long lives, string userAgent, string localeIdentifier, string adid, string idfa, string ifv, string androidId, ThirdParty thirdParty, Dictionary<string, string> abTests)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x16DA438", Offset = "0x16DA438", VA = "0x16DA438")]
		public void SetContext(string key, object value)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x16D0E54", Offset = "0x16D0E54", VA = "0x16D0E54")]
		public void SetAdid(string adid)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x16D0E5C", Offset = "0x16D0E5C", VA = "0x16D0E5C")]
		public void SetThirdParty(ThirdParty thirdParty)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x16DA2F8", Offset = "0x16DA2F8", VA = "0x16DA2F8")]
		public void SetNewSessionId()
		{
		}
	}
}
