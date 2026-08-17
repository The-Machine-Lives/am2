using Il2CppDummyDll;
using Uken.Library.Audio;

[Token(Token = "0x20000B9")]
public class BISoundData : UkenSoundData
{
	[Token(Token = "0x400030E")]
	public const string mc_sStageAssetSuffix = "_StageSoundData";

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xA43964", Offset = "0xA43964", VA = "0xA43964", Slot = "4")]
	public override void InitializeSoundBankData()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xA439C4", Offset = "0xA439C4", VA = "0xA439C4")]
	public BISoundData()
	{
	}
}
