using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AE")]
	public class Tab : RuntimeData<RDTab>
	{
		[Token(Token = "0x1700054F")]
		public string readableName
		{
			[Token(Token = "0x6001C7C")]
			[Address(RVA = "0x971018", Offset = "0x971018", VA = "0x971018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000550")]
		public string shortName
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x971044", Offset = "0x971044", VA = "0x971044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000551")]
		public BISoundEvents.EventKey ambientSoundOverride
		{
			[Token(Token = "0x6001C7E")]
			[Address(RVA = "0x971070", Offset = "0x971070", VA = "0x971070")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x17000552")]
		public BISoundEvents.EventKey onClickSoundOverride
		{
			[Token(Token = "0x6001C7F")]
			[Address(RVA = "0x97109C", Offset = "0x97109C", VA = "0x97109C")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x9710C8", Offset = "0x9710C8", VA = "0x9710C8")]
		public Tab()
		{
		}

		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x971118", Offset = "0x971118", VA = "0x971118")]
		public Tab(RDTab inRDTab, string inRedableName, string inShortName)
		{
		}
	}
}
