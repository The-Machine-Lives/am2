using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000467")]
	public interface IBaseEntity
	{
		[Token(Token = "0x60020C5")]
		BaseEntityDocument GetDocument();

		[Token(Token = "0x60020C6")]
		bool IsEnabled(VersionPlatform platform, Version currentVersion);
	}
}
