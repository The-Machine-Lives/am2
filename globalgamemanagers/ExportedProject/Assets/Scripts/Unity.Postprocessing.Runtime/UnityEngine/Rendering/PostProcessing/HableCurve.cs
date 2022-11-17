using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200005B")]
	public class HableCurve
	{
		[Token(Token = "0x2000086")]
		private class Segment
		{
			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x10")]
			public float offsetX;

			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x14")]
			public float offsetY;

			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x18")]
			public float scaleX;

			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x1C")]
			public float scaleY;

			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x20")]
			public float lnA;

			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x24")]
			public float B;

			[Token(Token = "0x600023D")]
			[Address(RVA = "0xD8121C", Offset = "0xD8121C", VA = "0xD8121C")]
			public float Eval(float x)
			{
				return default(float);
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0xD81150", Offset = "0xD81150", VA = "0xD81150")]
			public Segment()
			{
			}
		}

		[Token(Token = "0x2000087")]
		private struct DirectParams
		{
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x0")]
			internal float x0;

			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x4")]
			internal float y0;

			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x8")]
			internal float x1;

			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0xC")]
			internal float y1;

			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x10")]
			internal float W;

			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x14")]
			internal float overshootX;

			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x18")]
			internal float overshootY;

			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x1C")]
			internal float gamma;
		}

		[Token(Token = "0x2000088")]
		public class Uniforms
		{
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x10")]
			private HableCurve parent;

			[Token(Token = "0x17000043")]
			public Vector4 curve
			{
				[Token(Token = "0x6000240")]
				[Address(RVA = "0xD7D264", Offset = "0xD7D264", VA = "0xD7D264")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000044")]
			public Vector4 toeSegmentA
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0xD7D308", Offset = "0xD7D308", VA = "0xD7D308")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000045")]
			public Vector4 toeSegmentB
			{
				[Token(Token = "0x6000242")]
				[Address(RVA = "0xD7D3E4", Offset = "0xD7D3E4", VA = "0xD7D3E4")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000046")]
			public Vector4 midSegmentA
			{
				[Token(Token = "0x6000243")]
				[Address(RVA = "0xD7D494", Offset = "0xD7D494", VA = "0xD7D494")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000047")]
			public Vector4 midSegmentB
			{
				[Token(Token = "0x6000244")]
				[Address(RVA = "0xD7D574", Offset = "0xD7D574", VA = "0xD7D574")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000048")]
			public Vector4 shoSegmentA
			{
				[Token(Token = "0x6000245")]
				[Address(RVA = "0xD7D628", Offset = "0xD7D628", VA = "0xD7D628")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x17000049")]
			public Vector4 shoSegmentB
			{
				[Token(Token = "0x6000246")]
				[Address(RVA = "0xD7D708", Offset = "0xD7D708", VA = "0xD7D708")]
				get
				{
					return default(Vector4);
				}
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0xD81158", Offset = "0xD81158", VA = "0xD81158")]
			internal Uniforms(HableCurve parent)
			{
			}
		}

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF04", Offset = "0x81BF04")]
		private float _003CwhitePoint_003Ek__BackingField;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF14", Offset = "0x81BF14")]
		private float _003CinverseWhitePoint_003Ek__BackingField;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF24", Offset = "0x81BF24")]
		private float _003Cx0_003Ek__BackingField;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BF34", Offset = "0x81BF34")]
		private float _003Cx1_003Ek__BackingField;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x20")]
		private readonly Segment[] m_Segments;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x28")]
		public readonly Uniforms uniforms;

		[Token(Token = "0x17000026")]
		public float whitePoint
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xD81110", Offset = "0xD81110", VA = "0xD81110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C400", Offset = "0x81C400")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xD81118", Offset = "0xD81118", VA = "0xD81118")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C410", Offset = "0x81C410")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public float inverseWhitePoint
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xD81120", Offset = "0xD81120", VA = "0xD81120")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C420", Offset = "0x81C420")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xD81128", Offset = "0xD81128", VA = "0xD81128")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C430", Offset = "0x81C430")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		internal float x0
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xD81130", Offset = "0xD81130", VA = "0xD81130")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C440", Offset = "0x81C440")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xD81138", Offset = "0xD81138", VA = "0xD81138")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C450", Offset = "0x81C450")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		internal float x1
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xD81140", Offset = "0xD81140", VA = "0xD81140")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C460", Offset = "0x81C460")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xD81148", Offset = "0xD81148", VA = "0xD81148")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C470", Offset = "0x81C470")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD7DC14", Offset = "0xD7DC14", VA = "0xD7DC14")]
		public HableCurve()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD81184", Offset = "0xD81184", VA = "0xD81184")]
		public float Eval(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD7D0A0", Offset = "0xD7D0A0", VA = "0xD7D0A0")]
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD812D4", Offset = "0xD812D4", VA = "0xD812D4")]
		private void InitSegments(DirectParams srcParams)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xD819FC", Offset = "0xD819FC", VA = "0xD819FC")]
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xD81938", Offset = "0xD81938", VA = "0xD81938")]
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xD81964", Offset = "0xD81964", VA = "0xD81964")]
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			return default(float);
		}
	}
}
