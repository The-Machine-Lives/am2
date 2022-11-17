using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000058")]
	public sealed class PostProcessResources : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public sealed class Shaders
		{
			[Token(Token = "0x40002BC")]
			[FieldOffset(Offset = "0x10")]
			public Shader bloom;

			[Token(Token = "0x40002BD")]
			[FieldOffset(Offset = "0x18")]
			public Shader copy;

			[Token(Token = "0x40002BE")]
			[FieldOffset(Offset = "0x20")]
			public Shader copyStd;

			[Token(Token = "0x40002BF")]
			[FieldOffset(Offset = "0x28")]
			public Shader copyStdFromTexArray;

			[Token(Token = "0x40002C0")]
			[FieldOffset(Offset = "0x30")]
			public Shader copyStdFromDoubleWide;

			[Token(Token = "0x40002C1")]
			[FieldOffset(Offset = "0x38")]
			public Shader discardAlpha;

			[Token(Token = "0x40002C2")]
			[FieldOffset(Offset = "0x40")]
			public Shader depthOfField;

			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x48")]
			public Shader finalPass;

			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x50")]
			public Shader grainBaker;

			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x58")]
			public Shader motionBlur;

			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x60")]
			public Shader temporalAntialiasing;

			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x68")]
			public Shader subpixelMorphologicalAntialiasing;

			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x70")]
			public Shader texture2dLerp;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x78")]
			public Shader uber;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x80")]
			public Shader lut2DBaker;

			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x88")]
			public Shader lightMeter;

			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x90")]
			public Shader gammaHistogram;

			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x98")]
			public Shader waveform;

			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0xA0")]
			public Shader vectorscope;

			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0xA8")]
			public Shader debugOverlays;

			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0xB0")]
			public Shader deferredFog;

			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0xB8")]
			public Shader scalableAO;

			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0xC0")]
			public Shader multiScaleAO;

			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0xC8")]
			public Shader screenSpaceReflections;

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x12291FC", Offset = "0x12291FC", VA = "0x12291FC")]
			public Shaders Clone()
			{
				return null;
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x12292B4", Offset = "0x12292B4", VA = "0x12292B4")]
			public Shaders()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public sealed class ComputeShaders
		{
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x10")]
			public ComputeShader autoExposure;

			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x18")]
			public ComputeShader exposureHistogram;

			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x20")]
			public ComputeShader lut3DBaker;

			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0x28")]
			public ComputeShader texture3dLerp;

			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x30")]
			public ComputeShader gammaHistogram;

			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x38")]
			public ComputeShader waveform;

			[Token(Token = "0x40002DA")]
			[FieldOffset(Offset = "0x40")]
			public ComputeShader vectorscope;

			[Token(Token = "0x40002DB")]
			[FieldOffset(Offset = "0x48")]
			public ComputeShader multiScaleAODownsample1;

			[Token(Token = "0x40002DC")]
			[FieldOffset(Offset = "0x50")]
			public ComputeShader multiScaleAODownsample2;

			[Token(Token = "0x40002DD")]
			[FieldOffset(Offset = "0x58")]
			public ComputeShader multiScaleAORender;

			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x60")]
			public ComputeShader multiScaleAOUpsample;

			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x68")]
			public ComputeShader gaussianDownsample;

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1229134", Offset = "0x1229134", VA = "0x1229134")]
			public ComputeShaders Clone()
			{
				return null;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x12291EC", Offset = "0x12291EC", VA = "0x12291EC")]
			public ComputeShaders()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public sealed class SMAALuts
		{
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D area;

			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D search;

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x12291F4", Offset = "0x12291F4", VA = "0x12291F4")]
			public SMAALuts()
			{
			}
		}

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D[] blueNoise64;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D[] blueNoise256;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x28")]
		public SMAALuts smaaLuts;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x30")]
		public Shaders shaders;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x38")]
		public ComputeShaders computeShaders;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x122912C", Offset = "0x122912C", VA = "0x122912C")]
		public PostProcessResources()
		{
		}
	}
}
