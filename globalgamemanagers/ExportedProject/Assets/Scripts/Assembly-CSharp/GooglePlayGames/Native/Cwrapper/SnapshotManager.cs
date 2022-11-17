using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002BD")]
	internal static class SnapshotManager
	{
		[Token(Token = "0x2000766")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000767")]
		internal delegate void OpenCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000768")]
		internal delegate void CommitCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000769")]
		internal delegate void ReadCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200076A")]
		internal delegate void SnapshotSelectUICallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x1326F0C", Offset = "0x1326F0C", VA = "0x1326F0C")]
		internal static extern void SnapshotManager_FetchAll(HandleRef self, Types.DataSource data_source, FetchAllCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x1326FD8", Offset = "0x1326FD8", VA = "0x1326FD8")]
		internal static extern void SnapshotManager_ShowSelectUIOperation(HandleRef self, bool allow_create, bool allow_delete, uint max_snapshots, string title, SnapshotSelectUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x13270E0", Offset = "0x13270E0", VA = "0x13270E0")]
		internal static extern void SnapshotManager_Read(HandleRef self, IntPtr snapshot_metadata, ReadCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x13271AC", Offset = "0x13271AC", VA = "0x13271AC")]
		internal static extern void SnapshotManager_Commit(HandleRef self, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, CommitCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x13272A4", Offset = "0x13272A4", VA = "0x13272A4")]
		internal static extern void SnapshotManager_Open(HandleRef self, Types.DataSource data_source, string file_name, Types.SnapshotConflictPolicy conflict_policy, OpenCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x132739C", Offset = "0x132739C", VA = "0x132739C")]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, OpenCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x1327494", Offset = "0x1327494", VA = "0x1327494")]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, OpenCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x13275B0", Offset = "0x13275B0", VA = "0x13275B0")]
		internal static extern void SnapshotManager_ResolveConflict(HandleRef self, string conflict_id, IntPtr snapshot_metadata, OpenCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x1327698", Offset = "0x1327698", VA = "0x1327698")]
		internal static extern void SnapshotManager_Delete(HandleRef self, IntPtr snapshot_metadata);

		[PreserveSig]
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x1327744", Offset = "0x1327744", VA = "0x1327744")]
		internal static extern void SnapshotManager_FetchAllResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x13277E0", Offset = "0x13277E0", VA = "0x13277E0")]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_FetchAllResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x132787C", Offset = "0x132787C", VA = "0x132787C")]
		internal static extern UIntPtr SnapshotManager_FetchAllResponse_GetData_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x1327918", Offset = "0x1327918", VA = "0x1327918")]
		internal static extern IntPtr SnapshotManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x13279C4", Offset = "0x13279C4", VA = "0x13279C4")]
		internal static extern void SnapshotManager_OpenResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x1327A60", Offset = "0x1327A60", VA = "0x1327A60")]
		internal static extern CommonErrorStatus.SnapshotOpenStatus SnapshotManager_OpenResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x1327AFC", Offset = "0x1327AFC", VA = "0x1327AFC")]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x1327B98", Offset = "0x1327B98", VA = "0x1327B98")]
		internal static extern UIntPtr SnapshotManager_OpenResponse_GetConflictId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x1327C54", Offset = "0x1327C54", VA = "0x1327C54")]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictOriginal(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x1327CF0", Offset = "0x1327CF0", VA = "0x1327CF0")]
		internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictUnmerged(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x1327D8C", Offset = "0x1327D8C", VA = "0x1327D8C")]
		internal static extern void SnapshotManager_CommitResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x1327E28", Offset = "0x1327E28", VA = "0x1327E28")]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_CommitResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x1327EC4", Offset = "0x1327EC4", VA = "0x1327EC4")]
		internal static extern IntPtr SnapshotManager_CommitResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x1327F60", Offset = "0x1327F60", VA = "0x1327F60")]
		internal static extern void SnapshotManager_ReadResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x1327FFC", Offset = "0x1327FFC", VA = "0x1327FFC")]
		internal static extern CommonErrorStatus.ResponseStatus SnapshotManager_ReadResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x1328098", Offset = "0x1328098", VA = "0x1328098")]
		internal static extern UIntPtr SnapshotManager_ReadResponse_GetData(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x1328154", Offset = "0x1328154", VA = "0x1328154")]
		internal static extern void SnapshotManager_SnapshotSelectUIResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x13281F0", Offset = "0x13281F0", VA = "0x13281F0")]
		internal static extern CommonErrorStatus.UIStatus SnapshotManager_SnapshotSelectUIResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x132828C", Offset = "0x132828C", VA = "0x132828C")]
		internal static extern IntPtr SnapshotManager_SnapshotSelectUIResponse_GetData(HandleRef self);
	}
}
