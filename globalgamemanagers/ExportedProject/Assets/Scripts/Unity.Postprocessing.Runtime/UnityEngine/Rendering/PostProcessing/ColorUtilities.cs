using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200005A")]
	public static class ColorUtilities
	{
		[Token(Token = "0x400018B")]
		private const float logC_cut = 0.011361f;

		[Token(Token = "0x400018C")]
		private const float logC_a = 5.555556f;

		[Token(Token = "0x400018D")]
		private const float logC_b = 0.047996f;

		[Token(Token = "0x400018E")]
		private const float logC_c = 0.244161f;

		[Token(Token = "0x400018F")]
		private const float logC_d = 0.386036f;

		[Token(Token = "0x4000190")]
		private const float logC_e = 5.301883f;

		[Token(Token = "0x4000191")]
		private const float logC_f = 0.092819f;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD7DDAC", Offset = "0xD7DDAC", VA = "0xD7DDAC")]
		public static float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD7DDD8", Offset = "0xD7DDD8", VA = "0xD7DDD8")]
		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD7C628", Offset = "0xD7C628", VA = "0xD7C628")]
		public static Vector3 ComputeColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD7C71C", Offset = "0xD7C71C", VA = "0xD7C71C")]
		public static Vector3 ColorToLift(Vector4 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD7C88C", Offset = "0xD7C88C", VA = "0xD7C88C")]
		public static Vector3 ColorToInverseGamma(Vector4 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD7C7D0", Offset = "0xD7C7D0", VA = "0xD7C7D0")]
		public static Vector3 ColorToGain(Vector4 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD7DE98", Offset = "0xD7DE98", VA = "0xD7DE98")]
		public static float LogCToLinear(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD7DF60", Offset = "0xD7DF60", VA = "0xD7DF60")]
		public static float LinearToLogC(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD7E024", Offset = "0xD7E024", VA = "0xD7E024")]
		public static uint ToHex(Color c)
		{
			return default(uint);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD7E05C", Offset = "0xD7E05C", VA = "0xD7E05C")]
		public static Color ToRGBA(uint hex)
		{
			return default(Color);
		}
	}
}
