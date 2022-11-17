using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A4")]
	[Preserve]
	public interface IReferenceResolver
	{
		[Token(Token = "0x60004B8")]
		object ResolveReference(object context, string reference);

		[Token(Token = "0x60004B9")]
		string GetReference(object context, object value);

		[Token(Token = "0x60004BA")]
		bool IsReferenced(object context, object value);

		[Token(Token = "0x60004BB")]
		void AddReference(object context, string reference, object value);
	}
}
