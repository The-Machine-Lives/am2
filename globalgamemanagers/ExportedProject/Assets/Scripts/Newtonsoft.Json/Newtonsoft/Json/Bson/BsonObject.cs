using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200011D")]
	[Preserve]
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonProperty> _children;

		[Token(Token = "0x170001CB")]
		public override BsonType Type
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xD3782C", Offset = "0xD3782C", VA = "0xD3782C", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xD376CC", Offset = "0xD376CC", VA = "0xD376CC")]
		public void Add(string name, BsonToken token)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xD372D0", Offset = "0xD372D0", VA = "0xD372D0", Slot = "5")]
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xD37834", Offset = "0xD37834", VA = "0xD37834", Slot = "6")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xD37838", Offset = "0xD37838", VA = "0xD37838")]
		public BsonObject()
		{
		}
	}
}
