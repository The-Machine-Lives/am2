using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000397")]
	public class LTOGroups : RuntimeData<RDLTOGroups>
	{
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82CE64", Offset = "0x82CE64")]
		private List<StoreItem> _003CgroupedStoreItems_003Ek__BackingField;

		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82CE74", Offset = "0x82CE74")]
		private UserSegment _003CuserSegment_003Ek__BackingField;

		[Token(Token = "0x17000515")]
		public List<StoreItem> groupedStoreItems
		{
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x9B5864", Offset = "0x9B5864", VA = "0x9B5864")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838540", Offset = "0x838540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x9B586C", Offset = "0x9B586C", VA = "0x9B586C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838550", Offset = "0x838550")]
			private set
			{
			}
		}

		[Token(Token = "0x17000516")]
		public UserSegment userSegment
		{
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x9B5874", Offset = "0x9B5874", VA = "0x9B5874")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838560", Offset = "0x838560")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x9B587C", Offset = "0x9B587C", VA = "0x9B587C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838570", Offset = "0x838570")]
			private set
			{
			}
		}

		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x9B5884", Offset = "0x9B5884", VA = "0x9B5884")]
		public LTOGroups()
		{
		}

		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x9B58FC", Offset = "0x9B58FC", VA = "0x9B58FC", Slot = "4")]
		public override void Initialize(RDLTOGroups referenceData)
		{
		}

		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x9B5C2C", Offset = "0x9B5C2C", VA = "0x9B5C2C")]
		public bool HasMetGroupRequirements(UserProfiler userProfiler)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x9B5C78", Offset = "0x9B5C78", VA = "0x9B5C78")]
		public bool HasMetUserSegmentRequirements(UserProfiler userProfiler)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x9B5C94", Offset = "0x9B5C94", VA = "0x9B5C94")]
		public bool HasAnyStoreItemBeenSeenOrInCooldown()
		{
			return default(bool);
		}
	}
}
