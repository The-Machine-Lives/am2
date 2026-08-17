using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000060")]
	public sealed class PropertySheetFactory
	{
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Shader, PropertySheet> m_Sheets;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1229FCC", Offset = "0x1229FCC", VA = "0x1229FCC")]
		public PropertySheetFactory()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x122A040", Offset = "0x122A040", VA = "0x122A040")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x81C4E0", Offset = "0x81C4E0")]
		public PropertySheet Get(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x122A138", Offset = "0x122A138", VA = "0x122A138")]
		public PropertySheet Get(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x122A39C", Offset = "0x122A39C", VA = "0x122A39C")]
		public void Release()
		{
		}
	}
}
