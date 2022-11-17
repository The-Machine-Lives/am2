using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000027")]
	[Preserve]
	internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xD826F4", Offset = "0xD826F4", VA = "0xD826F4", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xD82AF4", Offset = "0xD82AF4", VA = "0xD82AF4")]
		public LensDistortionRenderer()
		{
		}
	}
}
