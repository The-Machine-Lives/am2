using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200005F")]
	public sealed class PropertySheet
	{
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF54", Offset = "0x81BF54")]
		private MaterialPropertyBlock _003Cproperties_003Ek__BackingField;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF64", Offset = "0x81BF64")]
		private Material _003Cmaterial_003Ek__BackingField;

		[Token(Token = "0x1700002B")]
		public MaterialPropertyBlock properties
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1229E1C", Offset = "0x1229E1C", VA = "0x1229E1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C4A0", Offset = "0x81C4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1229E24", Offset = "0x1229E24", VA = "0x1229E24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C4B0", Offset = "0x81C4B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		internal Material material
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1229E2C", Offset = "0x1229E2C", VA = "0x1229E2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C4C0", Offset = "0x81C4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1229E34", Offset = "0x1229E34", VA = "0x1229E34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C4D0", Offset = "0x81C4D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1229E3C", Offset = "0x1229E3C", VA = "0x1229E3C")]
		internal PropertySheet(Material material)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1229EB8", Offset = "0x1229EB8", VA = "0x1229EB8")]
		public void ClearKeywords()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1229EEC", Offset = "0x1229EEC", VA = "0x1229EEC")]
		public void EnableKeyword(string keyword)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1229F24", Offset = "0x1229F24", VA = "0x1229F24")]
		public void DisableKeyword(string keyword)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1229F5C", Offset = "0x1229F5C", VA = "0x1229F5C")]
		internal void Release()
		{
		}
	}
}
