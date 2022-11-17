using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DF")]
	public class CasualSceneState
	{
		[Token(Token = "0x400170F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_state;

		[Token(Token = "0x4001710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> m_stateData;

		[Token(Token = "0x6002581")]
		[Address(RVA = "0xA56C04", Offset = "0xA56C04", VA = "0xA56C04")]
		public CasualSceneState(int state, [Optional] Dictionary<string, object> stateData)
		{
		}
	}
}
