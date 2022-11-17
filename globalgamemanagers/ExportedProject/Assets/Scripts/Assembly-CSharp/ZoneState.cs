using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;

[Token(Token = "0x2000092")]
public class ZoneState
{
	[Token(Token = "0x200060E")]
	public struct ReportInfo
	{
		[Token(Token = "0x4001D82")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F30", Offset = "0x832F30")]
		private string _003Cmessage_003Ek__BackingField;

		[Token(Token = "0x4001D83")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F40", Offset = "0x832F40")]
		private int _003CreportIndex_003Ek__BackingField;

		[Token(Token = "0x170007DB")]
		public string message
		{
			[Token(Token = "0x6002CD7")]
			[Address(RVA = "0x89C024", Offset = "0x89C024", VA = "0x89C024")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFCC", Offset = "0x83AFCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD8")]
			[Address(RVA = "0x89C02C", Offset = "0x89C02C", VA = "0x89C02C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFDC", Offset = "0x83AFDC")]
			set
			{
			}
		}

		[Token(Token = "0x170007DC")]
		public int reportIndex
		{
			[Token(Token = "0x6002CD9")]
			[Address(RVA = "0x89C034", Offset = "0x89C034", VA = "0x89C034")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFEC", Offset = "0x83AFEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002CDA")]
			[Address(RVA = "0x89C03C", Offset = "0x89C03C", VA = "0x89C03C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFFC", Offset = "0x83AFFC")]
			set
			{
			}
		}

		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x89C044", Offset = "0x89C044", VA = "0x89C044")]
		public ReportInfo(string inMessage, int inEncounterIndex)
		{
		}
	}

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821E98", Offset = "0x821E98")]
	private Zone _003CcurrentZone_003Ek__BackingField;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EA8", Offset = "0x821EA8")]
	private double _003CstartTime_003Ek__BackingField;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EB8", Offset = "0x821EB8")]
	private long _003CplayerHealth_003Ek__BackingField;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EC8", Offset = "0x821EC8")]
	private long _003CplayerMaxHealth_003Ek__BackingField;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821ED8", Offset = "0x821ED8")]
	private List<Ability> _003CabilityLoadout_003Ek__BackingField;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EE8", Offset = "0x821EE8")]
	private Dictionary<string, long> _003CabilityAmmo_003Ek__BackingField;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821EF8", Offset = "0x821EF8")]
	private Dictionary<string, long> _003CoriginalAmmoCounts_003Ek__BackingField;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F08", Offset = "0x821F08")]
	private Dictionary<string, long> _003CspentAmmo_003Ek__BackingField;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F18", Offset = "0x821F18")]
	private List<ReportInfo> _003Creports_003Ek__BackingField;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F28", Offset = "0x821F28")]
	private Dictionary<string, long> _003Crewards_003Ek__BackingField;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F38", Offset = "0x821F38")]
	private int _003CcurrentStepIndex_003Ek__BackingField;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821F48", Offset = "0x821F48")]
	private bool _003CrunFinalized_003Ek__BackingField;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x68")]
	private int m_currentReportIndex;

	[Token(Token = "0x1700004E")]
	public Zone currentZone
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xAB9904", Offset = "0xAB9904", VA = "0xAB9904")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B5C", Offset = "0x833B5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xABBF08", Offset = "0xABBF08", VA = "0xABBF08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B6C", Offset = "0x833B6C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public double startTime
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xABBF10", Offset = "0xABBF10", VA = "0xABBF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B7C", Offset = "0x833B7C")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xABBF18", Offset = "0xABBF18", VA = "0xABBF18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B8C", Offset = "0x833B8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public long playerHealth
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xABBF20", Offset = "0xABBF20", VA = "0xABBF20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B9C", Offset = "0x833B9C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xABBF28", Offset = "0xABBF28", VA = "0xABBF28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BAC", Offset = "0x833BAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public long playerMaxHealth
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xABBF30", Offset = "0xABBF30", VA = "0xABBF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BBC", Offset = "0x833BBC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xABBF38", Offset = "0xABBF38", VA = "0xABBF38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BCC", Offset = "0x833BCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public List<Ability> abilityLoadout
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xABBF40", Offset = "0xABBF40", VA = "0xABBF40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BDC", Offset = "0x833BDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xABBF48", Offset = "0xABBF48", VA = "0xABBF48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BEC", Offset = "0x833BEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public Dictionary<string, long> abilityAmmo
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xABBF50", Offset = "0xABBF50", VA = "0xABBF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833BFC", Offset = "0x833BFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xABBF58", Offset = "0xABBF58", VA = "0xABBF58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C0C", Offset = "0x833C0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public Dictionary<string, long> originalAmmoCounts
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xABBF60", Offset = "0xABBF60", VA = "0xABBF60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C1C", Offset = "0x833C1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xABBF68", Offset = "0xABBF68", VA = "0xABBF68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C2C", Offset = "0x833C2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public Dictionary<string, long> spentAmmo
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xABBF70", Offset = "0xABBF70", VA = "0xABBF70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C3C", Offset = "0x833C3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xABBF78", Offset = "0xABBF78", VA = "0xABBF78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C4C", Offset = "0x833C4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public List<ReportInfo> reports
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xABBF80", Offset = "0xABBF80", VA = "0xABBF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C5C", Offset = "0x833C5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xABBF88", Offset = "0xABBF88", VA = "0xABBF88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C6C", Offset = "0x833C6C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public Dictionary<string, long> rewards
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xABBF90", Offset = "0xABBF90", VA = "0xABBF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C7C", Offset = "0x833C7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xABBF98", Offset = "0xABBF98", VA = "0xABBF98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C8C", Offset = "0x833C8C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public int currentStepIndex
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xABBFA0", Offset = "0xABBFA0", VA = "0xABBFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833C9C", Offset = "0x833C9C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xABBFA8", Offset = "0xABBFA8", VA = "0xABBFA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CAC", Offset = "0x833CAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public bool runFinalized
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xABBFB0", Offset = "0xABBFB0", VA = "0xABBFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CBC", Offset = "0x833CBC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xABBFB8", Offset = "0xABBFB8", VA = "0xABBFB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CCC", Offset = "0x833CCC")]
		set
		{
		}
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xABBFC4", Offset = "0xABBFC4", VA = "0xABBFC4")]
	public ZoneState(Zone inCurrentZone, UkenTimeController timeController, LoadoutController loadoutController, InventoryController inventoryController)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xABC438", Offset = "0xABC438", VA = "0xABC438")]
	public void AddRewards(Dictionary<string, int> transaction)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xABC5A4", Offset = "0xABC5A4", VA = "0xABC5A4")]
	public void AddReward(string itemRef, long quantity)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xABC6A0", Offset = "0xABC6A0", VA = "0xABC6A0")]
	public void IncrementReportIndex()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xABC6B0", Offset = "0xABC6B0", VA = "0xABC6B0")]
	public void AddReport(string reportString)
	{
	}
}
