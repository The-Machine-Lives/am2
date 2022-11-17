using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Audio;

[Token(Token = "0x20000B8")]
public class BISoundBankData : UkenSoundBankData
{
	[Token(Token = "0x600047B")]
	[Address(RVA = "0xA438B0", Offset = "0xA438B0", VA = "0xA438B0", Slot = "4")]
	public override Dictionary<string, List<string>> GetSoundBankInfo()
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xA4395C", Offset = "0xA4395C", VA = "0xA4395C")]
	public BISoundBankData()
	{
	}
}
