using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000036")]
	public class UserState
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814D78", Offset = "0x814D78")]
		[SerializeField]
		private Guid session_id;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814DB0", Offset = "0x814DB0")]
		private int level;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814DE8", Offset = "0x814DE8")]
		private long xp;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814E20", Offset = "0x814E20")]
		private long soft_currency;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814E58", Offset = "0x814E58")]
		[SerializeField]
		private long hard_currency;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814E90", Offset = "0x814E90")]
		[SerializeField]
		private long lives;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814EC8", Offset = "0x814EC8")]
		private Dictionary<string, object> context;

		[Token(Token = "0x1700005A")]
		[JsonIgnore]
		public Guid SessionId
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x16DA528", Offset = "0x16DA528", VA = "0x16DA528")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x16DA534", Offset = "0x16DA534", VA = "0x16DA534")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		[JsonIgnore]
		public int Level
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x16D76DC", Offset = "0x16D76DC", VA = "0x16D76DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x16DA53C", Offset = "0x16DA53C", VA = "0x16DA53C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		[JsonIgnore]
		public long Xp
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x16D77E4", Offset = "0x16D77E4", VA = "0x16D77E4")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x16DA544", Offset = "0x16DA544", VA = "0x16DA544")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		[JsonIgnore]
		public long SoftCurrency
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x16D775C", Offset = "0x16D775C", VA = "0x16D775C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x16DA54C", Offset = "0x16DA54C", VA = "0x16DA54C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[JsonIgnore]
		public long HardCurrency
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x16D77DC", Offset = "0x16D77DC", VA = "0x16D77DC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x16DA554", Offset = "0x16DA554", VA = "0x16DA554")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		[JsonIgnore]
		public long Lives
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x16DA55C", Offset = "0x16DA55C", VA = "0x16DA55C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x16DA564", Offset = "0x16DA564", VA = "0x16DA564")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		[JsonIgnore]
		public Dictionary<string, object> Context
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x16DA56C", Offset = "0x16DA56C", VA = "0x16DA56C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x16DA574", Offset = "0x16DA574", VA = "0x16DA574")]
			set
			{
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x16D6128", Offset = "0x16D6128", VA = "0x16D6128")]
		public UserState(Guid sessionId)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x16D6160", Offset = "0x16D6160", VA = "0x16D6160")]
		public UserState SetLevel(int level)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x16D6168", Offset = "0x16D6168", VA = "0x16D6168")]
		public UserState SetXP(long xp)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x16D6170", Offset = "0x16D6170", VA = "0x16D6170")]
		public UserState SetSoftCurrency(long softCurrency)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x16D6178", Offset = "0x16D6178", VA = "0x16D6178")]
		public UserState SetHardCurrency(long hardCurrency)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x16D6180", Offset = "0x16D6180", VA = "0x16D6180")]
		public UserState SetLives(long lives)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x16D6188", Offset = "0x16D6188", VA = "0x16D6188")]
		public UserState SetContext(Dictionary<string, object> context)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x16DA57C", Offset = "0x16DA57C", VA = "0x16DA57C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
