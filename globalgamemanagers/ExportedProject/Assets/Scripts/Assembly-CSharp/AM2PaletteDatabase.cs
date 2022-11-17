using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000154")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x81E808", Offset = "0x81E808")]
public class AM2PaletteDatabase : ScriptableObject
{
	[Token(Token = "0x2000641")]
	public enum AM2ColorPalettes
	{
		[Token(Token = "0x4001EE5")]
		Button1Enabled = 0,
		[Token(Token = "0x4001EE6")]
		Button1Disabled = 1,
		[Token(Token = "0x4001EE7")]
		Button2Enabled = 2,
		[Token(Token = "0x4001EE8")]
		Button2Disabled = 3,
		[Token(Token = "0x4001EE9")]
		Panel1 = 4,
		[Token(Token = "0x4001EEA")]
		Panel2 = 5,
		[Token(Token = "0x4001EEB")]
		Panel3 = 6,
		[Token(Token = "0x4001EEC")]
		PopupPanel = 7,
		[Token(Token = "0x4001EED")]
		Background1 = 8,
		[Token(Token = "0x4001EEE")]
		LabelTextMain = 9,
		[Token(Token = "0x4001EEF")]
		ButtonText1Enabled = 10,
		[Token(Token = "0x4001EF0")]
		ButtonText1Disabled = 11,
		[Token(Token = "0x4001EF1")]
		ButtonText2Enabled = 12,
		[Token(Token = "0x4001EF2")]
		ButtonText2Disabled = 13,
		[Token(Token = "0x4001EF3")]
		ProgressBarBack = 14,
		[Token(Token = "0x4001EF4")]
		ProgressBarFill = 15,
		[Token(Token = "0x4001EF5")]
		LabelTextSecondary = 16,
		[Token(Token = "0x4001EF6")]
		NotificationIcon1 = 17,
		[Token(Token = "0x4001EF7")]
		ProgressBarLabel = 18,
		[Token(Token = "0x4001EF8")]
		SliderBarBackground = 19,
		[Token(Token = "0x4001EF9")]
		SliderBarFill = 20,
		[Token(Token = "0x4001EFA")]
		ButtonIcon = 21,
		[Token(Token = "0x4001EFB")]
		PowerPanel = 22,
		[Token(Token = "0x4001EFC")]
		NotificationIcon2 = 23,
		[Token(Token = "0x4001EFD")]
		PowerAccelerationBar = 24,
		[Token(Token = "0x4001EFE")]
		SpeedBoostLabel = 25,
		[Token(Token = "0x4001EFF")]
		HighlightedStoryLog = 26,
		[Token(Token = "0x4001F00")]
		ButtonBackground = 27,
		[Token(Token = "0x4001F01")]
		BoosterButtonEnabled = 28,
		[Token(Token = "0x4001F02")]
		BoosterButtonDisabled = 29,
		[Token(Token = "0x4001F03")]
		UpgradableProgressing = 30,
		[Token(Token = "0x4001F04")]
		PowerButton = 31,
		[Token(Token = "0x4001F05")]
		DropdownBorder = 32,
		[Token(Token = "0x4001F06")]
		BackgroundOverlay = 33,
		[Token(Token = "0x4001F07")]
		EquippedEquipmentBorder = 34,
		[Token(Token = "0x4001F08")]
		NewText = 35,
		[Token(Token = "0x4001F09")]
		EquipmentSelected = 36,
		[Token(Token = "0x4001F0A")]
		GoodButton = 37,
		[Token(Token = "0x4001F0B")]
		BadButton = 38,
		[Token(Token = "0x4001F0C")]
		ChannelingAbilityBorder = 39,
		[Token(Token = "0x4001F0D")]
		StoryLog = 40,
		[Token(Token = "0x4001F0E")]
		CastingBarFill = 41,
		[Token(Token = "0x4001F0F")]
		CastingBarBack = 42,
		[Token(Token = "0x4001F10")]
		ProgressBarFill2 = 43,
		[Token(Token = "0x4001F11")]
		PaletteCount = 44
	}

	[Token(Token = "0x2000642")]
	public enum AM2FontPalettes
	{
		[Token(Token = "0x4001F13")]
		Title = 0,
		[Token(Token = "0x4001F14")]
		Medium = 1,
		[Token(Token = "0x4001F15")]
		Small = 2,
		[Token(Token = "0x4001F16")]
		Tiny = 3,
		[Token(Token = "0x4001F17")]
		MediumButton = 4,
		[Token(Token = "0x4001F18")]
		Log = 5,
		[Token(Token = "0x4001F19")]
		HitEffect = 6,
		[Token(Token = "0x4001F1A")]
		PaletteCount = 7
	}

	[Token(Token = "0x2000643")]
	public enum AM2ImagePalettes
	{
		[Token(Token = "0x4001F1C")]
		Button1 = 0,
		[Token(Token = "0x4001F1D")]
		Button2 = 1,
		[Token(Token = "0x4001F1E")]
		Panel1 = 2,
		[Token(Token = "0x4001F1F")]
		Panel2 = 3,
		[Token(Token = "0x4001F20")]
		RecipePanel = 4,
		[Token(Token = "0x4001F21")]
		PowerRecipePanel = 5,
		[Token(Token = "0x4001F22")]
		Background1 = 6,
		[Token(Token = "0x4001F23")]
		ProgressBarBack = 7,
		[Token(Token = "0x4001F24")]
		ProgressBarFill = 8,
		[Token(Token = "0x4001F25")]
		NotificationIcon1 = 9,
		[Token(Token = "0x4001F26")]
		SliderBarBackground = 10,
		[Token(Token = "0x4001F27")]
		EnemyPanel = 11,
		[Token(Token = "0x4001F28")]
		PlayerPanel = 12,
		[Token(Token = "0x4001F29")]
		AbilitySlotBG = 13,
		[Token(Token = "0x4001F2A")]
		LabelPanel1 = 14,
		[Token(Token = "0x4001F2B")]
		CloseButton = 15,
		[Token(Token = "0x4001F2C")]
		DropdownButtonBG = 16,
		[Token(Token = "0x4001F2D")]
		DropdownButtonIcon = 17,
		[Token(Token = "0x4001F2E")]
		AbilityButton = 18,
		[Token(Token = "0x4001F2F")]
		SubstanceViewPanel = 19,
		[Token(Token = "0x4001F30")]
		PopupPanel = 20,
		[Token(Token = "0x4001F31")]
		SliderToggleButton = 21,
		[Token(Token = "0x4001F32")]
		closeIcon = 22,
		[Token(Token = "0x4001F33")]
		InfoTextButton = 23,
		[Token(Token = "0x4001F34")]
		PaletteCount = 24
	}

	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<AM2ColorPaletteDefinition> colorPalettes;

	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<AM2FontPaletteDefinition> fontPalettes;

	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<AM2ImagePaletteDefinition> imagePalettes;

	[Token(Token = "0x6000971")]
	[Address(RVA = "0xAC3BE8", Offset = "0xAC3BE8", VA = "0xAC3BE8")]
	public AM2PaletteDatabase()
	{
	}
}
