using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000047")]
	public sealed class SplineParameter : ParameterOverride<Spline>
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x123368C", Offset = "0x123368C", VA = "0x123368C", Slot = "6")]
		protected internal override void OnEnable()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x12336A0", Offset = "0x12336A0", VA = "0x12336A0", Slot = "8")]
		internal override void SetValue(ParameterOverride parameter)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x123372C", Offset = "0x123372C", VA = "0x123372C", Slot = "9")]
		public override void Interp(Spline from, Spline to, float t)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x12338C8", Offset = "0x12338C8", VA = "0x12338C8")]
		public SplineParameter()
		{
		}
	}
}
