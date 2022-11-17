using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityDriver.UnityStruct
{
	[Token(Token = "0x20005DC")]
	public struct AltUnityColor
	{
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0x8")]
		public float b;

		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0xC")]
		public float a;

		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x89DF84", Offset = "0x89DF84", VA = "0x89DF84")]
		public AltUnityColor(float r, float g, float b)
		{
		}

		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x89DF98", Offset = "0x89DF98", VA = "0x89DF98")]
		public AltUnityColor(float r, float g, float b, float a)
		{
		}
	}
}
