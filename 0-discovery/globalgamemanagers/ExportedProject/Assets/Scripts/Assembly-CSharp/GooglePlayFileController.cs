using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

[Token(Token = "0x20000BC")]
public class GooglePlayFileController : UkenController
{
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x18")]
	private GooglePlayDataStore data;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x20")]
	public string dataType;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x9D7E74", Offset = "0x9D7E74", VA = "0x9D7E74")]
	public GooglePlayFileController()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x9D7EEC", Offset = "0x9D7EEC", VA = "0x9D7EEC", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x9D7F94", Offset = "0x9D7F94", VA = "0x9D7F94")]
	public void SetIsLoggedIn(bool loggedIn)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x9D8378", Offset = "0x9D8378", VA = "0x9D8378")]
	public bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x9D83A4", Offset = "0x9D83A4", VA = "0x9D83A4")]
	public void SetHasSeenAutoSignin()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x9D83DC", Offset = "0x9D83DC", VA = "0x9D83DC")]
	public double GetTimeFirstSeen()
	{
		return default(double);
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x9D8408", Offset = "0x9D8408", VA = "0x9D8408")]
	public void SetTimeSeen()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x9D8480", Offset = "0x9D8480", VA = "0x9D8480")]
	public void ResetTriedSetAgeStates()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x9D84C8", Offset = "0x9D84C8", VA = "0x9D84C8")]
	public void IncrementTriedSetAge()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x9D8584", Offset = "0x9D8584", VA = "0x9D8584")]
	public bool HasSeenAgeGateOnce()
	{
		return default(bool);
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x9D85DC", Offset = "0x9D85DC", VA = "0x9D85DC")]
	public bool HasSeenAgeGateTwice()
	{
		return default(bool);
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x9D8634", Offset = "0x9D8634", VA = "0x9D8634")]
	public bool HasConfirmedOver18()
	{
		return default(bool);
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x9D8660", Offset = "0x9D8660", VA = "0x9D8660")]
	public void SetIsOver18()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x9D8698", Offset = "0x9D8698", VA = "0x9D8698")]
	public bool HasSeenAutoLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x9D7F14", Offset = "0x9D7F14", VA = "0x9D7F14")]
	private void ReadStatusFromFile()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x9D87F4", Offset = "0x9D87F4", VA = "0x9D87F4")]
	private string FilePath()
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x9D86C4", Offset = "0x9D86C4", VA = "0x9D86C4")]
	private GooglePlayDataStore ReadSavedData()
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x9D8C30", Offset = "0x9D8C30", VA = "0x9D8C30")]
	public void DEFAULT_FILE()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x9D7FD8", Offset = "0x9D7FD8", VA = "0x9D7FD8")]
	private void SaveToFile()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x9D8874", Offset = "0x9D8874", VA = "0x9D8874")]
	private GooglePlayDataStore ParseData(Dictionary<string, object> node)
	{
		return null;
	}
}
