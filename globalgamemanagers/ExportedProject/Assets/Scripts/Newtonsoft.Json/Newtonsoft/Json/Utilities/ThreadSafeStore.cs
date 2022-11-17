using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000055")]
	[Preserve]
	internal class ThreadSafeStore<TKey, TValue>
	{
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _store;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;

		[Token(Token = "0x600022E")]
		[Preserve]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		[Token(Token = "0x600022F")]
		[Preserve]
		public TValue Get(TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6000230")]
		[Preserve]
		private TValue AddValue(TKey key)
		{
			return (TValue)null;
		}
	}
}
