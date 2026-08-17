using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000063")]
	public sealed class Spline
	{
		[Token(Token = "0x4000233")]
		public const int k_Precision = 128;

		[Token(Token = "0x4000234")]
		public const float k_Step = 1f / 128f;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x30")]
		private int frameCount;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x38")]
		public float[] cachedData;

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1233224", Offset = "0x1233224", VA = "0x1233224")]
		public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x12332D0", Offset = "0x12332D0", VA = "0x12332D0")]
		public void Cache(int frame)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x123358C", Offset = "0x123358C", VA = "0x123358C")]
		public float Evaluate(float t, int length)
		{
			return default(float);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1233600", Offset = "0x1233600", VA = "0x1233600")]
		public float Evaluate(float t)
		{
			return default(float);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1233650", Offset = "0x1233650", VA = "0x1233650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
