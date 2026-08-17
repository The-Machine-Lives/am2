using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000086")]
	[Preserve]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x10")]
		private int _referenceCount;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD10714", Offset = "0xD10714", VA = "0xD10714")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD108F0", Offset = "0xD108F0", VA = "0xD108F0", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD10974", Offset = "0xD10974", VA = "0xD10974", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD10A7C", Offset = "0xD10A7C", VA = "0xD10A7C", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD10AF8", Offset = "0xD10AF8", VA = "0xD10AF8", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD10B7C", Offset = "0xD10B7C", VA = "0xD10B7C")]
		public DefaultReferenceResolver()
		{
		}
	}
}
