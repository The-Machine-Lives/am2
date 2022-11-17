using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.NativeHelpers
{
	[Token(Token = "0x2000003")]
	public interface INative
	{
		[Token(Token = "0x17000004")]
		string Platform
		{
			[Token(Token = "0x6000008")]
			get;
		}

		[Token(Token = "0x17000005")]
		string SystemName
		{
			[Token(Token = "0x6000009")]
			get;
		}

		[Token(Token = "0x17000006")]
		string SystemVersion
		{
			[Token(Token = "0x600000A")]
			get;
		}

		[Token(Token = "0x17000007")]
		string DeviceMachineType
		{
			[Token(Token = "0x600000B")]
			get;
		}

		[Token(Token = "0x17000008")]
		string JailBroken
		{
			[Token(Token = "0x600000C")]
			get;
		}

		[Token(Token = "0x17000009")]
		string LocaleIdentifier
		{
			[Token(Token = "0x600000D")]
			get;
		}

		[Token(Token = "0x1700000A")]
		string LocaleTimeZone
		{
			[Token(Token = "0x600000E")]
			get;
		}

		[Token(Token = "0x1700000B")]
		string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x600000F")]
			get;
		}

		[Token(Token = "0x1700000C")]
		string Manufacturer
		{
			[Token(Token = "0x6000010")]
			get;
		}

		[Token(Token = "0x1700000D")]
		Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000011")]
			get;
		}

		[Token(Token = "0x6000012")]
		void FetchAsyncIndentifiersIfNecessary(Action<Dictionary<string, object>> onIdentifiersFetched);
	}
}
