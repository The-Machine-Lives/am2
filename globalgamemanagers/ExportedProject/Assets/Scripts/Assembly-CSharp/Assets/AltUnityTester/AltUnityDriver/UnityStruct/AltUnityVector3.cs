using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityDriver.UnityStruct
{
	[Token(Token = "0x20005E0")]
	public struct AltUnityVector3
	{
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x89DFAC", Offset = "0x89DFAC", VA = "0x89DFAC")]
		public AltUnityVector3(float x, float y, float z)
		{
		}

		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x89DFB8", Offset = "0x89DFB8", VA = "0x89DFB8")]
		public AltUnityVector3(float x, float y)
		{
		}
	}
}
