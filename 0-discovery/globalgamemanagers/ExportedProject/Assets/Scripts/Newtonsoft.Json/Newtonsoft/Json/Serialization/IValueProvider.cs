using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000097")]
	[Preserve]
	public interface IValueProvider
	{
		[Token(Token = "0x600041E")]
		void SetValue(object target, object value);

		[Token(Token = "0x600041F")]
		object GetValue(object target);
	}
}
