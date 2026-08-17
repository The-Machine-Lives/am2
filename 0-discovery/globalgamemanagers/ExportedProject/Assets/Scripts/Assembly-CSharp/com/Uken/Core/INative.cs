using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Core
{
	[Token(Token = "0x2000235")]
	public interface INative
	{
		[Token(Token = "0x17000224")]
		string Platform
		{
			[Token(Token = "0x6000FC4")]
			get;
		}

		[Token(Token = "0x17000225")]
		string SystemName
		{
			[Token(Token = "0x6000FC5")]
			get;
		}

		[Token(Token = "0x17000226")]
		string SystemVersion
		{
			[Token(Token = "0x6000FC6")]
			get;
		}

		[Token(Token = "0x17000227")]
		string DeviceMachineType
		{
			[Token(Token = "0x6000FC7")]
			get;
		}

		[Token(Token = "0x17000228")]
		string JailBroken
		{
			[Token(Token = "0x6000FC8")]
			get;
		}

		[Token(Token = "0x17000229")]
		string LocaleIdentifier
		{
			[Token(Token = "0x6000FC9")]
			get;
		}

		[Token(Token = "0x1700022A")]
		string LocaleTimeZone
		{
			[Token(Token = "0x6000FCA")]
			get;
		}

		[Token(Token = "0x1700022B")]
		string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x6000FCB")]
			get;
		}

		[Token(Token = "0x1700022C")]
		string Manufacturer
		{
			[Token(Token = "0x6000FCC")]
			get;
		}

		[Token(Token = "0x1700022D")]
		Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000FCD")]
			get;
		}

		[Token(Token = "0x6000FCE")]
		void FetchAsyncIndentifiersIfNecessary(Action<Dictionary<string, object>> onIdentifiersFetched);
	}
}
