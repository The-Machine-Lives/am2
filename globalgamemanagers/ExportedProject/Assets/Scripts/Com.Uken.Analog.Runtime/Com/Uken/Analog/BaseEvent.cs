using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public abstract class BaseEvent
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814828", Offset = "0x814828")]
		[SerializeField]
		private DateTime event_time;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814860", Offset = "0x814860")]
		[SerializeField]
		private string schema_version;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814898", Offset = "0x814898")]
		[SerializeField]
		private LogValidation log_validation;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8148D0", Offset = "0x8148D0")]
		[SerializeField]
		private Guid event_id;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814908", Offset = "0x814908")]
		[SerializeField]
		private string log_source;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814940", Offset = "0x814940")]
		private App app;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814978", Offset = "0x814978")]
		private ThirdParty third_party;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8149B0", Offset = "0x8149B0")]
		private Device device;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8149E8", Offset = "0x8149E8")]
		private User user;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814A20", Offset = "0x814A20")]
		private bool offline;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814A58", Offset = "0x814A58")]
		private EventInfo event_info;

		[Token(Token = "0x1700003E")]
		[JsonIgnore]
		public string Type
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x16D5FB4", Offset = "0x16D5FB4", VA = "0x16D5FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		[JsonIgnore]
		public string Name
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x16D6020", Offset = "0x16D6020", VA = "0x16D6020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		[JsonIgnore]
		public DateTime EventTime
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x16D608C", Offset = "0x16D608C", VA = "0x16D608C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x16CFBA0", Offset = "0x16CFBA0", VA = "0x16CFBA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		[JsonIgnore]
		public string SchemaVersion
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x16D6094", Offset = "0x16D6094", VA = "0x16D6094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x16D609C", Offset = "0x16D609C", VA = "0x16D609C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		[JsonIgnore]
		public LogValidation LogValidation
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x16D60A4", Offset = "0x16D60A4", VA = "0x16D60A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x16D60AC", Offset = "0x16D60AC", VA = "0x16D60AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		[JsonIgnore]
		public Guid EventId
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x16D60B4", Offset = "0x16D60B4", VA = "0x16D60B4")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x16D60C0", Offset = "0x16D60C0", VA = "0x16D60C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		[JsonIgnore]
		public string LogSource
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x16D60C8", Offset = "0x16D60C8", VA = "0x16D60C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x16D60D0", Offset = "0x16D60D0", VA = "0x16D60D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		[JsonIgnore]
		public App App
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x16D60D8", Offset = "0x16D60D8", VA = "0x16D60D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x16D60E0", Offset = "0x16D60E0", VA = "0x16D60E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[JsonIgnore]
		public ThirdParty ThirdParty
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x16D3B94", Offset = "0x16D3B94", VA = "0x16D3B94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x16D3B9C", Offset = "0x16D3B9C", VA = "0x16D3B9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		[JsonIgnore]
		public Device Device
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x16D60E8", Offset = "0x16D60E8", VA = "0x16D60E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x16D60F0", Offset = "0x16D60F0", VA = "0x16D60F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		[JsonIgnore]
		public User User
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x16D60F8", Offset = "0x16D60F8", VA = "0x16D60F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x16D6100", Offset = "0x16D6100", VA = "0x16D6100")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		[JsonIgnore]
		public bool Offline
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x16D6108", Offset = "0x16D6108", VA = "0x16D6108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x16D6110", Offset = "0x16D6110", VA = "0x16D6110")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		[JsonIgnore]
		public EventInfo EventInfo
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x16CDA00", Offset = "0x16CDA00", VA = "0x16CDA00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x16CD9F8", Offset = "0x16CD9F8", VA = "0x16CD9F8")]
			set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x16D611C", Offset = "0x16D611C", VA = "0x16D611C", Slot = "4")]
		public virtual void ApplyCustomData(RuntimeContext runtimeContext)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x16CFBA8", Offset = "0x16CFBA8", VA = "0x16CFBA8")]
		public void Apply(RuntimeContext runtimeContext)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x16CFEB0", Offset = "0x16CFEB0", VA = "0x16CFEB0")]
		public bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		public abstract bool ValidateChild();

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x16D644C", Offset = "0x16D644C", VA = "0x16D644C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x16D649C", Offset = "0x16D649C", VA = "0x16D649C")]
		public BaseEvent AddEventData(string key, object value)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x16D6548", Offset = "0x16D6548", VA = "0x16D6548")]
		public object GetEventData(string key)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x16D65B0", Offset = "0x16D65B0", VA = "0x16D65B0")]
		public string GetDebugEventData()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x16D6600", Offset = "0x16D6600", VA = "0x16D6600")]
		public string GetDebugUserData()
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x16CD7BC", Offset = "0x16CD7BC", VA = "0x16CD7BC")]
		protected BaseEvent()
		{
		}
	}
}
