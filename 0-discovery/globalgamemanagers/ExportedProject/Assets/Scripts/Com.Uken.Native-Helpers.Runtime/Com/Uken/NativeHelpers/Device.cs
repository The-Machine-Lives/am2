using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.NativeHelpers
{
	[Token(Token = "0x2000002")]
	public class Device
	{
		[Token(Token = "0x4000001")]
		public const string ADID_KEY = "adid";

		[Token(Token = "0x4000002")]
		public const string IDFA_KEY = "idfa";

		[Token(Token = "0x4000003")]
		public const string IFV_KEY = "ifv";

		[Token(Token = "0x4000004")]
		public const string ANDROID_ID_KEY = "android_id";

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCA0", Offset = "0x80CCA0")]
		private INative _003CNative_003Ek__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCB0", Offset = "0x80CCB0")]
		private string _003CUserAgent_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public INative Native
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x181826C", Offset = "0x181826C", VA = "0x181826C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCC0", Offset = "0x80CCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x1818264", Offset = "0x1818264", VA = "0x1818264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCD0", Offset = "0x80CCD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string UserAgent
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x181827C", Offset = "0x181827C", VA = "0x181827C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCE0", Offset = "0x80CCE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1818274", Offset = "0x1818274", VA = "0x1818274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CCF0", Offset = "0x80CCF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1818284", Offset = "0x1818284", VA = "0x1818284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x18175D4", Offset = "0x18175D4", VA = "0x18175D4")]
		public Device()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x181833C", Offset = "0x181833C", VA = "0x181833C")]
		public void FetchAsyncIndentifiersIfNecessary(Action<Dictionary<string, object>> onIdentifiersFetched)
		{
		}
	}
}
