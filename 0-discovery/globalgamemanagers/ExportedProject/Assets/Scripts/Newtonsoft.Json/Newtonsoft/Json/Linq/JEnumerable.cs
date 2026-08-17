using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CE")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80F050", Offset = "0x80F050")]
	[Preserve]
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable where T : JToken
	{
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly JEnumerable<T> Empty;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;

		[Token(Token = "0x600060A")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		[Token(Token = "0x600060B")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		public bool Equals(JEnumerable<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
