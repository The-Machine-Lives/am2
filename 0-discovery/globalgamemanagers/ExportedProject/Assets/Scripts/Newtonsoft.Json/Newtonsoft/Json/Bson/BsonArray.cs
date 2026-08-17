using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200011E")]
	[Preserve]
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonToken> _children;

		[Token(Token = "0x170001CC")]
		public override BsonType Type
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xD35290", Offset = "0xD35290", VA = "0xD35290", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xD35204", Offset = "0xD35204", VA = "0xD35204")]
		public void Add(BsonToken token)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xD35298", Offset = "0xD35298", VA = "0xD35298", Slot = "5")]
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xD3532C", Offset = "0xD3532C", VA = "0xD3532C", Slot = "6")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xD35330", Offset = "0xD35330", VA = "0xD35330")]
		public BsonArray()
		{
		}
	}
}
