using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000056")]
	[Preserve]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;

		[Token(Token = "0x6000231")]
		public BidirectionalDictionary()
		{
		}

		[Token(Token = "0x6000232")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		[Token(Token = "0x6000233")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		[Token(Token = "0x6000234")]
		public void Set(TFirst first, TSecond second)
		{
		}

		[Token(Token = "0x6000235")]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return default(bool);
		}
	}
}
