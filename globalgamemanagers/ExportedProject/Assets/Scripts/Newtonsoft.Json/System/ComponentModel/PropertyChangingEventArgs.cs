using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	[Token(Token = "0x2000009")]
	[Preserve]
	public class PropertyChangingEventArgs : EventArgs
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F588", Offset = "0x80F588")]
		private string _003CPropertyName_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public virtual string PropertyName
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1775088", Offset = "0x1775088", VA = "0x1775088", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE78", Offset = "0x80FE78")]
			set
			{
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1775000", Offset = "0x1775000", VA = "0x1775000")]
		public PropertyChangingEventArgs(string propertyName)
		{
		}
	}
}
