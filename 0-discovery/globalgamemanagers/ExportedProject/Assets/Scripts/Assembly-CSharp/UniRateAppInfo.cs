using Il2CppDummyDll;

[Token(Token = "0x20001E1")]
public class UniRateAppInfo
{
	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x10")]
	public bool validAppInfo;

	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x18")]
	public string bundleId;

	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x20")]
	public int appStoreGenreID;

	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x24")]
	public int appID;

	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x28")]
	public string version;

	[Token(Token = "0x4000B1A")]
	private const string kAppInfoResultsKey = "results";

	[Token(Token = "0x4000B1B")]
	private const string kAppInfoBundleIdKey = "bundleId";

	[Token(Token = "0x4000B1C")]
	private const string kAppInfoGenreIdKey = "primaryGenreId";

	[Token(Token = "0x4000B1D")]
	private const string kAppInfoAppIdKey = "trackId";

	[Token(Token = "0x4000B1E")]
	private const string kAppInfoVersion = "version";

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0xAA357C", Offset = "0xAA357C", VA = "0xAA357C")]
	public UniRateAppInfo(string jsonResponse)
	{
	}
}
