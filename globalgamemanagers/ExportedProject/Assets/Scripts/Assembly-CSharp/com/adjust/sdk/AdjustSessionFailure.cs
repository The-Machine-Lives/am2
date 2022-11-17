using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x200022F")]
	public class AdjustSessionFailure
	{
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826604", Offset = "0x826604")]
		private string _003CAdid_003Ek__BackingField;

		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826614", Offset = "0x826614")]
		private string _003CMessage_003Ek__BackingField;

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826624", Offset = "0x826624")]
		private string _003CTimestamp_003Ek__BackingField;

		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826634", Offset = "0x826634")]
		private bool _003CWillRetry_003Ek__BackingField;

		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826644", Offset = "0x826644")]
		private Dictionary<string, object> _003CJsonResponse_003Ek__BackingField;

		[Token(Token = "0x1700020D")]
		public string Adid
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x177AB0C", Offset = "0x177AB0C", VA = "0x177AB0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8358D4", Offset = "0x8358D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x1778258", Offset = "0x1778258", VA = "0x1778258")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8358E4", Offset = "0x8358E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public string Message
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x177AB14", Offset = "0x177AB14", VA = "0x177AB14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8358F4", Offset = "0x8358F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x1778260", Offset = "0x1778260", VA = "0x1778260")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835904", Offset = "0x835904")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public string Timestamp
		{
			[Token(Token = "0x6000F7E")]
			[Address(RVA = "0x177AB1C", Offset = "0x177AB1C", VA = "0x177AB1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835914", Offset = "0x835914")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x1778274", Offset = "0x1778274", VA = "0x1778274")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835924", Offset = "0x835924")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public bool WillRetry
		{
			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x177AB24", Offset = "0x177AB24", VA = "0x177AB24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835934", Offset = "0x835934")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F81")]
			[Address(RVA = "0x1778268", Offset = "0x1778268", VA = "0x1778268")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835944", Offset = "0x835944")]
			set
			{
			}
		}

		[Token(Token = "0x17000211")]
		public Dictionary<string, object> JsonResponse
		{
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x177AB2C", Offset = "0x177AB2C", VA = "0x177AB2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835954", Offset = "0x835954")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x177AB34", Offset = "0x177AB34", VA = "0x177AB34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835964", Offset = "0x835964")]
			set
			{
			}
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x1778250", Offset = "0x1778250", VA = "0x1778250")]
		public AdjustSessionFailure()
		{
		}

		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x177AB3C", Offset = "0x177AB3C", VA = "0x177AB3C")]
		public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap)
		{
		}

		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x177AD3C", Offset = "0x177AD3C", VA = "0x177AD3C")]
		public AdjustSessionFailure(string jsonString)
		{
		}

		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x177827C", Offset = "0x177827C", VA = "0x177827C")]
		public void BuildJsonResponseFromString(string jsonResponseString)
		{
		}

		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x177AF44", Offset = "0x177AF44", VA = "0x177AF44")]
		public string GetJsonResponse()
		{
			return null;
		}
	}
}
