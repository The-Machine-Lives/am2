using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000315")]
	public abstract class AbilityEffect<T> : RuntimeData<T>, IAbilityEffect, IReferenceable where T : RDAbilityEffect
	{
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826B6C", Offset = "0x826B6C")]
		private EAbilityEffectType _003CeffectType_003Ek__BackingField;

		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826B7C", Offset = "0x826B7C")]
		private string _003CcureTarget_003Ek__BackingField;

		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x0")]
		private RuntimeItemModelDataCache<Tag, RDTag> m_tagsCache;

		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x0")]
		private Localizations m_localizationController;

		[Token(Token = "0x170003A9")]
		public bool isChanneled
		{
			[Token(Token = "0x60018F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003AA")]
		public float channelTickIntervalInSeconds
		{
			[Token(Token = "0x60018F5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170003AB")]
		public EAbilityEffectType effectType
		{
			[Token(Token = "0x60018F6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379D0", Offset = "0x8379D0")]
			get
			{
				return default(EAbilityEffectType);
			}
			[Token(Token = "0x60018F7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379E0", Offset = "0x8379E0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170003AC")]
		public string cureTarget
		{
			[Token(Token = "0x60018F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379F0", Offset = "0x8379F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A00", Offset = "0x837A00")]
			protected set
			{
			}
		}

		[Token(Token = "0x170003AD")]
		public List<string> healthTypes
		{
			[Token(Token = "0x60018FA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60018FB")]
		public AbilityEffect()
		{
		}

		[Token(Token = "0x60018FC")]
		public virtual string GetSimpleDisplayText(long level)
		{
			return null;
		}

		[Token(Token = "0x60018FD")]
		protected virtual string CreateAbilityTraitTitle(string name, bool isSelf, bool isPassive)
		{
			return null;
		}

		[Token(Token = "0x60018FE")]
		public virtual List<AbilityTraitDisplay> GetDetailedDisplayText(long level, bool isSelf, bool isPassive)
		{
			return null;
		}
	}
}
