using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200005D")]
	internal sealed class LogHistogram
	{
		[Token(Token = "0x4000198")]
		public const int rangeMin = -9;

		[Token(Token = "0x4000199")]
		public const int rangeMax = 9;

		[Token(Token = "0x400019A")]
		private const int k_Bins = 128;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF44", Offset = "0x81BF44")]
		private ComputeBuffer _003Cdata_003Ek__BackingField;

		[Token(Token = "0x1700002A")]
		public ComputeBuffer data
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xD75978", Offset = "0xD75978", VA = "0xD75978")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C480", Offset = "0x81C480")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xD83280", Offset = "0xD83280", VA = "0xD83280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C490", Offset = "0x81C490")]
			private set
			{
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD83288", Offset = "0xD83288", VA = "0xD83288")]
		public void Generate(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD75980", Offset = "0xD75980", VA = "0xD75980")]
		public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD836AC", Offset = "0xD836AC", VA = "0xD836AC")]
		public void Release()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD836DC", Offset = "0xD836DC", VA = "0xD836DC")]
		public LogHistogram()
		{
		}
	}
}
