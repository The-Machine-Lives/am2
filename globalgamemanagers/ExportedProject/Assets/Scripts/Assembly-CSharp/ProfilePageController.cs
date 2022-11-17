using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;

[Token(Token = "0x20001A7")]
public class ProfilePageController : DepotController
{
	[Token(Token = "0x40009E0")]
	public const string c_profileItemRef = "profile";

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x20")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x28")]
	private Localizations m_localizationController;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x30")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x38")]
	private RuntimeItemModelDataCache<Dye, RDDye> m_dyesCache;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x40")]
	private RuntimeItemModelDataCache<Badge, RDBadge> m_badgesCache;

	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x48")]
	private RuntimeItemModelDataCache<Title, RDTitle> m_titlesCache;

	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x50")]
	private RuntimeDataCache<TitleConnector, RDTitleConnector> m_titleConnectorsCache;

	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x58")]
	protected UkenObservable<ProfileChangedMessage> m_profileChangedSignal;

	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x60")]
	private ProfileItem m_profileItem;

	[Token(Token = "0x17000168")]
	public ProfileItem profileItem
	{
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x9E38A4", Offset = "0x9E38A4", VA = "0x9E38A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x9E3920", Offset = "0x9E3920", VA = "0x9E3920")]
	public ProfilePageController(CasualDataStoreController dataController, AM2InventoryController inventoryController, Localizations localizationController, UIAlertController uiAlertController)
	{
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x9E39F8", Offset = "0x9E39F8", VA = "0x9E39F8", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x9E2D6C", Offset = "0x9E2D6C", VA = "0x9E2D6C")]
	public UkenUnsubscriber<ProfileChangedMessage> SubscribeToProfileChanges(IUkenObserver<ProfileChangedMessage> observer, bool signalOnSubscribe)
	{
		return null;
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x9E3F38", Offset = "0x9E3F38", VA = "0x9E3F38")]
	public void MarkProfileDirty()
	{
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x9E3F98", Offset = "0x9E3F98", VA = "0x9E3F98")]
	public BadgeItem GetActiveBadgeItem()
	{
		return null;
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x9E407C", Offset = "0x9E407C", VA = "0x9E407C")]
	public Badge GetDefaultBadge()
	{
		return null;
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x9E40CC", Offset = "0x9E40CC", VA = "0x9E40CC")]
	public Badge GetBadge(string badgeReference)
	{
		return null;
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x9E413C", Offset = "0x9E413C", VA = "0x9E413C")]
	public Badge GetActiveBadge()
	{
		return null;
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x9E41B0", Offset = "0x9E41B0", VA = "0x9E41B0")]
	public Dye GetActiveBadgeDye()
	{
		return null;
	}

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x9E41EC", Offset = "0x9E41EC", VA = "0x9E41EC")]
	public Dye GetBadgeDye(string badgeRef)
	{
		return null;
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x9E4240", Offset = "0x9E4240", VA = "0x9E4240")]
	public Dye GetBadgeDye(BadgeItem badgeItem)
	{
		return null;
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x9E42E0", Offset = "0x9E42E0", VA = "0x9E42E0")]
	public Dye GetActiveTitleDye()
	{
		return null;
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x9E4398", Offset = "0x9E4398", VA = "0x9E4398")]
	public Dye GetDye(string dyeRef)
	{
		return null;
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x9E4408", Offset = "0x9E4408", VA = "0x9E4408")]
	public string GetLocalizedFullTitle()
	{
		return null;
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x9E4458", Offset = "0x9E4458", VA = "0x9E4458")]
	public string GetLocalizedLeftTitle()
	{
		return null;
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x9E45AC", Offset = "0x9E45AC", VA = "0x9E45AC")]
	public string GetLocalizedRightTitle()
	{
		return null;
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x9E4494", Offset = "0x9E4494", VA = "0x9E4494")]
	public string GetLocalizedMiddleTitle()
	{
		return null;
	}

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x9E46CC", Offset = "0x9E46CC", VA = "0x9E46CC")]
	public void EquipBadge(string badgeRef)
	{
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x9E4754", Offset = "0x9E4754", VA = "0x9E4754")]
	public void EquipTitles(Title leftTitle, Title rightTitle, TitleConnector middleTitle)
	{
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x9E47F8", Offset = "0x9E47F8", VA = "0x9E47F8")]
	public void EquipLeftTitle(string titleRef)
	{
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x9E487C", Offset = "0x9E487C", VA = "0x9E487C")]
	public void EquipRightTitle(string titleRef)
	{
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x9E4900", Offset = "0x9E4900", VA = "0x9E4900")]
	public void EquipMiddleTitle(string titleRef)
	{
	}

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x9E4984", Offset = "0x9E4984", VA = "0x9E4984")]
	public void ApplyDyeToActiveBadge(string dyeRef)
	{
	}

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x9E49CC", Offset = "0x9E49CC", VA = "0x9E49CC")]
	public void ApplyDyeToBadge(string badgeRef, string dyeRef)
	{
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x9E4B60", Offset = "0x9E4B60", VA = "0x9E4B60")]
	public void ApplyDyeToTitle(string dyeRef)
	{
	}

	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x9E4C60", Offset = "0x9E4C60", VA = "0x9E4C60")]
	public void AwardBlankTitle()
	{
	}

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x9E4D28", Offset = "0x9E4D28", VA = "0x9E4D28")]
	public void AwardDefaultBadge()
	{
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x9E4DFC", Offset = "0x9E4DFC", VA = "0x9E4DFC")]
	public void AwardBetaItems()
	{
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x9E4F74", Offset = "0x9E4F74", VA = "0x9E4F74")]
	public Title GetTitle(string titleRef)
	{
		return null;
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x9E4FE4", Offset = "0x9E4FE4", VA = "0x9E4FE4")]
	public List<Title> GetAllOwnedTitles()
	{
		return null;
	}

	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x9E5074", Offset = "0x9E5074", VA = "0x9E5074")]
	public List<BadgeItem> GetAllOwnedBadgeItems()
	{
		return null;
	}

	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x9E5260", Offset = "0x9E5260", VA = "0x9E5260")]
	public List<Dye> GetAllOwnedDyes()
	{
		return null;
	}

	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x9E52F0", Offset = "0x9E52F0", VA = "0x9E52F0")]
	public List<TitleConnector> GetAllTitleConnectors()
	{
		return null;
	}

	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x9E400C", Offset = "0x9E400C", VA = "0x9E400C")]
	public BadgeItem GetBadgeItem(string badgeRef)
	{
		return null;
	}

	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x9E5350", Offset = "0x9E5350", VA = "0x9E5350", Slot = "7")]
	public override void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x9E4B04", Offset = "0x9E4B04", VA = "0x9E4B04")]
	private void SpendDye(string targetItemRef, string dyeRef, string logName)
	{
	}

	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x9E45E8", Offset = "0x9E45E8", VA = "0x9E45E8")]
	private string GetLocalizedTitle(string titleRef)
	{
		return null;
	}

	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x9E2C30", Offset = "0x9E2C30", VA = "0x9E2C30")]
	public ProfileChangedMessage GetProfileMessage()
	{
		return null;
	}
}
