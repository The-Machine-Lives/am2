using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C2")]
	internal static class Status
	{
		[Token(Token = "0x200076C")]
		internal enum ResponseStatus
		{
			[Token(Token = "0x4002167")]
			VALID = 1,
			[Token(Token = "0x4002168")]
			VALID_BUT_STALE = 2,
			[Token(Token = "0x4002169")]
			ERROR_LICENSE_CHECK_FAILED = -1,
			[Token(Token = "0x400216A")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400216B")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400216C")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x400216D")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200076D")]
		internal enum FlushStatus
		{
			[Token(Token = "0x400216F")]
			FLUSHED = 4,
			[Token(Token = "0x4002170")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002171")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002172")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002173")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200076E")]
		internal enum AuthStatus
		{
			[Token(Token = "0x4002175")]
			VALID = 1,
			[Token(Token = "0x4002176")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002177")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002178")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002179")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200076F")]
		internal enum UIStatus
		{
			[Token(Token = "0x400217B")]
			VALID = 1,
			[Token(Token = "0x400217C")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400217D")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400217E")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x400217F")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x4002180")]
			ERROR_CANCELED = -6,
			[Token(Token = "0x4002181")]
			ERROR_UI_BUSY = -12,
			[Token(Token = "0x4002182")]
			ERROR_LEFT_ROOM = -18
		}

		[Token(Token = "0x2000770")]
		internal enum MultiplayerStatus
		{
			[Token(Token = "0x4002184")]
			VALID = 1,
			[Token(Token = "0x4002185")]
			VALID_BUT_STALE = 2,
			[Token(Token = "0x4002186")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002187")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002188")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002189")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x400218A")]
			ERROR_MATCH_ALREADY_REMATCHED = -7,
			[Token(Token = "0x400218B")]
			ERROR_INACTIVE_MATCH = -8,
			[Token(Token = "0x400218C")]
			ERROR_INVALID_RESULTS = -9,
			[Token(Token = "0x400218D")]
			ERROR_INVALID_MATCH = -10,
			[Token(Token = "0x400218E")]
			ERROR_MATCH_OUT_OF_DATE = -11,
			[Token(Token = "0x400218F")]
			ERROR_REAL_TIME_ROOM_NOT_JOINED = -17
		}

		[Token(Token = "0x2000771")]
		internal enum CommonErrorStatus
		{
			[Token(Token = "0x4002191")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002192")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002193")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x2000772")]
		internal enum SnapshotOpenStatus
		{
			[Token(Token = "0x4002195")]
			VALID = 1,
			[Token(Token = "0x4002196")]
			VALID_WITH_CONFLICT = 3,
			[Token(Token = "0x4002197")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002198")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002199")]
			ERROR_TIMEOUT = -5
		}
	}
}
