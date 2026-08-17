using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

[Token(Token = "0x20001C5")]
public class GameSettings : DepotController
{
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x20")]
	private DepotEntity<RDGameSetting> m_GameSettings;

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x9D350C", Offset = "0x9D350C", VA = "0x9D350C")]
	public GameSettings(AM2DataStoreController controller)
	{
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x9D3514", Offset = "0x9D3514", VA = "0x9D3514", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x9D369C", Offset = "0x9D369C", VA = "0x9D369C")]
	public string GetString(string reference, string defaultValue = "")
	{
		return null;
	}

	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x9D374C", Offset = "0x9D374C", VA = "0x9D374C")]
	public int GetInt(string reference, int defaultValue)
	{
		return default(int);
	}

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x9D37D8", Offset = "0x9D37D8", VA = "0x9D37D8")]
	public float GetFloat(string reference, float defaultValue)
	{
		return default(float);
	}
}
