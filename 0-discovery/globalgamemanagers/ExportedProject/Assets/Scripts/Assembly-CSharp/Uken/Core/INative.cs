using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003C9")]
	public interface INative
	{
		[Token(Token = "0x1700056A")]
		string Platform
		{
			[Token(Token = "0x6001D43")]
			get;
		}

		[Token(Token = "0x1700056B")]
		string SystemName
		{
			[Token(Token = "0x6001D44")]
			get;
		}

		[Token(Token = "0x1700056C")]
		string SystemVersion
		{
			[Token(Token = "0x6001D45")]
			get;
		}

		[Token(Token = "0x1700056D")]
		string DeviceMachineType
		{
			[Token(Token = "0x6001D46")]
			get;
		}

		[Token(Token = "0x1700056E")]
		string JailBroken
		{
			[Token(Token = "0x6001D47")]
			get;
		}

		[Token(Token = "0x1700056F")]
		string LocaleIdentifier
		{
			[Token(Token = "0x6001D48")]
			get;
		}

		[Token(Token = "0x17000570")]
		string LocaleTimeZone
		{
			[Token(Token = "0x6001D49")]
			get;
		}

		[Token(Token = "0x17000571")]
		string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x6001D4A")]
			get;
		}

		[Token(Token = "0x17000572")]
		string Manufacturer
		{
			[Token(Token = "0x6001D4B")]
			get;
		}

		[Token(Token = "0x17000573")]
		Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6001D4C")]
			get;
		}
	}
}
