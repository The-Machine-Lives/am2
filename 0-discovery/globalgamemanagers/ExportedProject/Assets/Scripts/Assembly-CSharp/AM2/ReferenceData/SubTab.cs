using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AC")]
	public class SubTab : RuntimeData<RDSubTab>
	{
		[Token(Token = "0x1700054A")]
		public string readableName
		{
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x970DD8", Offset = "0x970DD8", VA = "0x970DD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054B")]
		public string shortName
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x970E04", Offset = "0x970E04", VA = "0x970E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054C")]
		public int priority
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x970E30", Offset = "0x970E30", VA = "0x970E30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700054D")]
		public string tag
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x970E5C", Offset = "0x970E5C", VA = "0x970E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054E")]
		public string loggingEventName
		{
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x970E88", Offset = "0x970E88", VA = "0x970E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x970EB4", Offset = "0x970EB4", VA = "0x970EB4")]
		public SubTab()
		{
		}

		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x970F04", Offset = "0x970F04", VA = "0x970F04")]
		public SubTab(RDSubTab inRDSubTab, string inRedableName, int inPriority)
		{
		}
	}
}
