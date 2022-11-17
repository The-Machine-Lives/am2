using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000466")]
	public class BaseEntity<T> : IBaseEntity where T : BaseEntityDocument
	{
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x0")]
		public T document;

		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x0")]
		public List<RDAltValue> alt_values;

		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<VersionPlatform, Version> m_minimumVersions;

		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<VersionPlatform, Version> m_maximumVersions;

		[Token(Token = "0x60020C2")]
		public BaseEntityDocument GetDocument()
		{
			return null;
		}

		[Token(Token = "0x60020C3")]
		public bool IsEnabled(VersionPlatform platform, Version currentVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60020C4")]
		public BaseEntity()
		{
		}
	}
}
