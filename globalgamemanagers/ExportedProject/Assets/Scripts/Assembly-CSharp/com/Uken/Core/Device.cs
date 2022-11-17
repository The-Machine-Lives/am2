using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Core
{
	[Token(Token = "0x2000234")]
	public class Device
	{
		[Token(Token = "0x4000C92")]
		public const string ADID_KEY = "adid";

		[Token(Token = "0x4000C93")]
		public const string IDFA_KEY = "idfa";

		[Token(Token = "0x4000C94")]
		public const string IFV_KEY = "ifv";

		[Token(Token = "0x4000C95")]
		public const string ANDROID_ID_KEY = "android_id";

		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826744", Offset = "0x826744")]
		private INative _003CNative_003Ek__BackingField;

		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826754", Offset = "0x826754")]
		private string _003CUserAgent_003Ek__BackingField;

		[Token(Token = "0x17000221")]
		public INative Native
		{
			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0xA51EE8", Offset = "0xA51EE8", VA = "0xA51EE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835B54", Offset = "0x835B54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0xA51EE0", Offset = "0xA51EE0", VA = "0xA51EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835B64", Offset = "0x835B64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public string UserAgent
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0xA51EF8", Offset = "0xA51EF8", VA = "0xA51EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835B74", Offset = "0x835B74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0xA51EF0", Offset = "0xA51EF0", VA = "0xA51EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835B84", Offset = "0x835B84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0xA51F00", Offset = "0xA51F00", VA = "0xA51F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0xA51280", Offset = "0xA51280", VA = "0xA51280")]
		public Device()
		{
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0xA51FB8", Offset = "0xA51FB8", VA = "0xA51FB8")]
		public void FetchAsyncIndentifiersIfNecessary(Action<Dictionary<string, object>> onIdentifiersFetched)
		{
		}
	}
}
