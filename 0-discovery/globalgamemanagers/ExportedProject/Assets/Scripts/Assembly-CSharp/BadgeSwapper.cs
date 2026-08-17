using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x20000F5")]
public class BadgeSwapper : ColoredPrefabSwapper<BadgeView>
{
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823898", Offset = "0x823898")]
	private Dye _003CcurrentDye_003Ek__BackingField;

	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8238A8", Offset = "0x8238A8")]
	private Badge _003CcurrentBadge_003Ek__BackingField;

	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x58")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x170000DB")]
	public Dye currentDye
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0xA459F0", Offset = "0xA459F0", VA = "0xA459F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FB0", Offset = "0x833FB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000682")]
		[Address(RVA = "0xA459F8", Offset = "0xA459F8", VA = "0xA459F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FC0", Offset = "0x833FC0")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DC")]
	public Badge currentBadge
	{
		[Token(Token = "0x6000683")]
		[Address(RVA = "0xA450C4", Offset = "0xA450C4", VA = "0xA450C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FD0", Offset = "0x833FD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000684")]
		[Address(RVA = "0xA45A00", Offset = "0xA45A00", VA = "0xA45A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FE0", Offset = "0x833FE0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xA453FC", Offset = "0xA453FC", VA = "0xA453FC")]
	public void Initialize(BadgeItem badgeItem, AutoScrollableView parentView)
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xA45A08", Offset = "0xA45A08", VA = "0xA45A08")]
	public void Initialize(Badge badge, Dye dye, AutoScrollableView parentView)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0xA45B7C", Offset = "0xA45B7C", VA = "0xA45B7C")]
	public void UpdateWithBadge(Badge badge)
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0xA45BD0", Offset = "0xA45BD0", VA = "0xA45BD0")]
	private void RefreshBadge()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xA450CC", Offset = "0xA450CC", VA = "0xA450CC")]
	public void UpdateWithDye(Dye dye)
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xA45C7C", Offset = "0xA45C7C", VA = "0xA45C7C")]
	public BadgeSwapper()
	{
	}
}
