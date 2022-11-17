using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DC")]
public class UniRateGUIScript : MonoBehaviour
{
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x18")]
	private string bundleIDString;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x20")]
	private string appIDString;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x28")]
	private string appNameString;

	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x30")]
	private string appVersionString;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x38")]
	private string usesUntilPromptString;

	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x40")]
	private string usedString;

	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x48")]
	private string eventsUntilPromptString;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x50")]
	private string eventsHappenedString;

	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x58")]
	private string daysUntilPromptString;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x60")]
	private string daysUsedString;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x68")]
	private string usesPerWeekToPromptString;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x70")]
	private string usesPerWeekString;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x78")]
	private string remindString;

	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0xAA6598", Offset = "0xAA6598", VA = "0xAA6598")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0xAA6E1C", Offset = "0xAA6E1C", VA = "0xAA6E1C")]
	public UniRateGUIScript()
	{
	}
}
