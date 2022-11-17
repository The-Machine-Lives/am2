using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x818F8C", Offset = "0x818F8C")]
	public sealed class ColorGrading : PostProcessEffectSettings
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819FA8", Offset = "0x819FA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819FA8", Offset = "0x819FA8")]
		public GradingModeParameter gradingMode;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A008", Offset = "0x81A008")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A008", Offset = "0x81A008")]
		public TextureParameter externalLut;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A068", Offset = "0x81A068")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A068", Offset = "0x81A068")]
		public TonemapperParameter tonemapper;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A0C8", Offset = "0x81A0C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A0C8", Offset = "0x81A0C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A0C8", Offset = "0x81A0C8")]
		public FloatParameter toneCurveToeStrength;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A140", Offset = "0x81A140")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A140", Offset = "0x81A140")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A140", Offset = "0x81A140")]
		public FloatParameter toneCurveToeLength;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A1B8", Offset = "0x81A1B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A1B8", Offset = "0x81A1B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A1B8", Offset = "0x81A1B8")]
		public FloatParameter toneCurveShoulderStrength;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A230", Offset = "0x81A230")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x81A230", Offset = "0x81A230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A230", Offset = "0x81A230")]
		public FloatParameter toneCurveShoulderLength;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A2A4", Offset = "0x81A2A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A2A4", Offset = "0x81A2A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A2A4", Offset = "0x81A2A4")]
		public FloatParameter toneCurveShoulderAngle;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A31C", Offset = "0x81A31C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x81A31C", Offset = "0x81A31C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A31C", Offset = "0x81A31C")]
		public FloatParameter toneCurveGamma;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A394", Offset = "0x81A394")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A394", Offset = "0x81A394")]
		public TextureParameter ldrLut;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A3F4", Offset = "0x81A3F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A3F4", Offset = "0x81A3F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A3F4", Offset = "0x81A3F4")]
		public FloatParameter ldrLutContribution;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A46C", Offset = "0x81A46C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A46C", Offset = "0x81A46C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A46C", Offset = "0x81A46C")]
		public FloatParameter temperature;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A4EC", Offset = "0x81A4EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A4EC", Offset = "0x81A4EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A4EC", Offset = "0x81A4EC")]
		public FloatParameter tint;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A56C", Offset = "0x81A56C")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x81A56C", Offset = "0x81A56C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A56C", Offset = "0x81A56C")]
		public ColorParameter colorFilter;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A5E4", Offset = "0x81A5E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A5E4", Offset = "0x81A5E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A5E4", Offset = "0x81A5E4")]
		public FloatParameter hueShift;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A664", Offset = "0x81A664")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A664", Offset = "0x81A664")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A664", Offset = "0x81A664")]
		public FloatParameter saturation;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A6E4", Offset = "0x81A6E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A6E4", Offset = "0x81A6E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A6E4", Offset = "0x81A6E4")]
		public FloatParameter brightness;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A764", Offset = "0x81A764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A764", Offset = "0x81A764")]
		public FloatParameter postExposure;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A7C4", Offset = "0x81A7C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A7C4", Offset = "0x81A7C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A7C4", Offset = "0x81A7C4")]
		public FloatParameter contrast;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A844", Offset = "0x81A844")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A844", Offset = "0x81A844")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A844", Offset = "0x81A844")]
		public FloatParameter mixerRedOutRedIn;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A8C4", Offset = "0x81A8C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A8C4", Offset = "0x81A8C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A8C4", Offset = "0x81A8C4")]
		public FloatParameter mixerRedOutGreenIn;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A944", Offset = "0x81A944")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A944", Offset = "0x81A944")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A944", Offset = "0x81A944")]
		public FloatParameter mixerRedOutBlueIn;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81A9C4", Offset = "0x81A9C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81A9C4", Offset = "0x81A9C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81A9C4", Offset = "0x81A9C4")]
		public FloatParameter mixerGreenOutRedIn;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AA44", Offset = "0x81AA44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AA44", Offset = "0x81AA44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AA44", Offset = "0x81AA44")]
		public FloatParameter mixerGreenOutGreenIn;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AAC4", Offset = "0x81AAC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AAC4", Offset = "0x81AAC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AAC4", Offset = "0x81AAC4")]
		public FloatParameter mixerGreenOutBlueIn;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AB44", Offset = "0x81AB44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AB44", Offset = "0x81AB44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AB44", Offset = "0x81AB44")]
		public FloatParameter mixerBlueOutRedIn;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81ABC4", Offset = "0x81ABC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81ABC4", Offset = "0x81ABC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81ABC4", Offset = "0x81ABC4")]
		public FloatParameter mixerBlueOutGreenIn;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AC44", Offset = "0x81AC44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AC44", Offset = "0x81AC44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AC44", Offset = "0x81AC44")]
		public FloatParameter mixerBlueOutBlueIn;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81ACC4", Offset = "0x81ACC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81ACC4", Offset = "0x81ACC4")]
		[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x81ACC4", Offset = "0x81ACC4")]
		public Vector4Parameter lift;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AD38", Offset = "0x81AD38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AD38", Offset = "0x81AD38")]
		[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x81AD38", Offset = "0x81AD38")]
		public Vector4Parameter gamma;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81ADAC", Offset = "0x81ADAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81ADAC", Offset = "0x81ADAC")]
		[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x81ADAC", Offset = "0x81ADAC")]
		public Vector4Parameter gain;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x128")]
		public SplineParameter masterCurve;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x130")]
		public SplineParameter redCurve;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x138")]
		public SplineParameter greenCurve;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x140")]
		public SplineParameter blueCurve;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x148")]
		public SplineParameter hueVsHueCurve;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x150")]
		public SplineParameter hueVsSatCurve;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x158")]
		public SplineParameter satVsSatCurve;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x160")]
		public SplineParameter lumVsSatCurve;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xD779B0", Offset = "0xD779B0", VA = "0xD779B0", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xD77A24", Offset = "0xD77A24", VA = "0xD77A24")]
		public ColorGrading()
		{
		}
	}
}
