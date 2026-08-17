using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.Signals;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004FC")]
	public class GameTriggerSignal : Signal
	{
		[Token(Token = "0x4001786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameTriggerType m_triggerType;

		[Token(Token = "0x4001787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_key;

		[Token(Token = "0x4001788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_beforeValue;

		[Token(Token = "0x4001789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_afterValue;

		[Token(Token = "0x6002657")]
		[Address(RVA = "0xA68380", Offset = "0xA68380", VA = "0xA68380")]
		public GameTriggerSignal(GameTriggerType triggerType, [Optional] string key, float beforeValue = 0f, float afterValue = 0f)
		{
		}

		[Token(Token = "0x6002658")]
		[Address(RVA = "0xA683D0", Offset = "0xA683D0", VA = "0xA683D0")]
		public bool DidActivate(GameTriggerType testTriggerType, string testKey, float testThreshold)
		{
			return default(bool);
		}
	}
}
