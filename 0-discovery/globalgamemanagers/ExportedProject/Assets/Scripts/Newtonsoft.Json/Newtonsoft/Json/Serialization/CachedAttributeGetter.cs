using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B3")]
	[Preserve]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;

		[Token(Token = "0x600056B")]
		public static T GetAttribute(object type)
		{
			return null;
		}
	}
}
