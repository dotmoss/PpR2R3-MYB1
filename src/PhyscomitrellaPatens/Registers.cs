namespace PhyscomitrellaPatens.Registers;

public interface IRegisterOrdinal
{
    int RegisterOrdinal { get; }
}

public interface ISegmentOrdinal
{
    int SegmentOrdinal { get; }
}

public interface IRegister;
public interface IGeneralPurposeRegister : IRegister, IRegisterOrdinal;
public interface ISegmentRegister : IRegister, ISegmentOrdinal;
public interface IStatusRegister : IRegister;
public interface IInstructionPointer : IRegister;
public interface ISimdRegister : IRegister, IRegisterOrdinal;
public interface IFpuRegister : IRegister;
public interface IRegisterFlag;

public interface IX8Register : IRegister;
public interface IX16Register : IRegister;
public interface IX32Register : IRegister;
public interface IX64Register : IRegister;
public interface IX80Register : IRegister;
public interface IX128Register : IRegister;
public interface IX256Register : IRegister;
public interface IX512Register : IRegister;

public interface IGeneralPurpose8Register : IX8Register, IGeneralPurposeRegister;
public interface IGeneralPurpose16Register : IX16Register, IGeneralPurposeRegister;
public interface IGeneralPurpose32Register : IX32Register, IGeneralPurposeRegister;
public interface IGeneralPurpose64Register : IX64Register, IGeneralPurposeRegister;

public interface IByteRegister : IX8Register, IRegisterOrdinal;
public interface ILowByteRegister : IByteRegister;
public interface IHighByteRegister : IByteRegister;
public interface ILegacyByteRegister : IByteRegister;
public interface IExtendedByteRegister : ILowByteRegister;
public interface ILowLegacyByteRegister : ILegacyByteRegister, ILowByteRegister;

public interface ISimd64Register : IX64Register, ISimdRegister;
public interface ISimd128Register : IX128Register, ISimdRegister;
public interface ISimd256Register : IX256Register, ISimdRegister;
public interface ISimd512Register : IX512Register, ISimdRegister;

public interface IFpu80Register : IX80Register, IFpuRegister;

public interface ISegmentRegisterSource : ISegmentRegister;
public interface ISegmentRegisterDestination : ISegmentRegister;
public interface IPopSegmentRegisterDestination : ISegmentRegister;

public interface IInstructionPointer16 : IX16Register, IInstructionPointer;
public interface IInstructionPointer32 : IX32Register, IInstructionPointer;
public interface IInstructionPointer64 : IX64Register, IInstructionPointer;

public interface IStatusRegister16 : IX16Register, IStatusRegister;
public interface IStatusRegister32 : IX32Register, IStatusRegister;
public interface IStatusRegister64 : IX64Register, IStatusRegister;

public interface IShiftCountRegister : IX8Register;
public interface IPortRegister : IX16Register;

public struct RAX : IGeneralPurpose64Register { public int RegisterOrdinal => 0; }
public struct EAX : IGeneralPurpose32Register { public int RegisterOrdinal => 0; }
public struct AX : IGeneralPurpose16Register { public int RegisterOrdinal => 0; }
public struct AL : IGeneralPurpose8Register, ILowByteRegister, ILowLegacyByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 0; }
public struct AH : IGeneralPurpose8Register, IHighByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 0; }

public struct RCX : IGeneralPurpose64Register { public int RegisterOrdinal => 1; }
public struct ECX : IGeneralPurpose32Register { public int RegisterOrdinal => 1; }
public struct CX : IGeneralPurpose16Register { public int RegisterOrdinal => 1; }
public struct CL : IGeneralPurpose8Register, ILowByteRegister, ILowLegacyByteRegister, ILegacyByteRegister, IByteRegister, IShiftCountRegister { public int RegisterOrdinal => 1; }
public struct CH : IGeneralPurpose8Register, IHighByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 1; }

public struct RDX : IGeneralPurpose64Register, IPortRegister { public int RegisterOrdinal => 2; }
public struct EDX : IGeneralPurpose32Register { public int RegisterOrdinal => 2; }
public struct DX : IGeneralPurpose16Register, IPortRegister { public int RegisterOrdinal => 2; }
public struct DL : IGeneralPurpose8Register, ILowByteRegister, ILowLegacyByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 2; }
public struct DH : IGeneralPurpose8Register, IHighByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 2; }

public struct RBX : IGeneralPurpose64Register { public int RegisterOrdinal => 3; }
public struct EBX : IGeneralPurpose32Register { public int RegisterOrdinal => 3; }
public struct BX : IGeneralPurpose16Register { public int RegisterOrdinal => 3; }
public struct BL : IGeneralPurpose8Register, ILowByteRegister, ILowLegacyByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 3; }
public struct BH : IGeneralPurpose8Register, IHighByteRegister, ILegacyByteRegister, IByteRegister { public int RegisterOrdinal => 3; }

public struct RSP : IGeneralPurpose64Register { public int RegisterOrdinal => 4; }
public struct ESP : IGeneralPurpose32Register { public int RegisterOrdinal => 4; }
public struct SP : IGeneralPurpose16Register { public int RegisterOrdinal => 4; }
public struct SPL : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 4; }

public struct RBP : IGeneralPurpose64Register { public int RegisterOrdinal => 5; }
public struct EBP : IGeneralPurpose32Register { public int RegisterOrdinal => 5; }
public struct BP : IGeneralPurpose16Register { public int RegisterOrdinal => 5; }
public struct BPL : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 5; }

public struct RSI : IGeneralPurpose64Register { public int RegisterOrdinal => 6; }
public struct ESI : IGeneralPurpose32Register { public int RegisterOrdinal => 6; }
public struct SI : IGeneralPurpose16Register { public int RegisterOrdinal => 6; }
public struct SIL : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 6; }

public struct RDI : IGeneralPurpose64Register { public int RegisterOrdinal => 7; }
public struct EDI : IGeneralPurpose32Register { public int RegisterOrdinal => 7; }
public struct DI : IGeneralPurpose16Register { public int RegisterOrdinal => 7; }
public struct DIL : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 7; }

public struct R8 : IGeneralPurpose64Register { public int RegisterOrdinal => 8; }
public struct R8D : IGeneralPurpose32Register { public int RegisterOrdinal => 8; }
public struct R8W : IGeneralPurpose16Register { public int RegisterOrdinal => 8; }
public struct R8B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 8; }

public struct R9 : IGeneralPurpose64Register { public int RegisterOrdinal => 9; }
public struct R9D : IGeneralPurpose32Register { public int RegisterOrdinal => 9; }
public struct R9W : IGeneralPurpose16Register { public int RegisterOrdinal => 9; }
public struct R9B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 9; }

public struct R10 : IGeneralPurpose64Register { public int RegisterOrdinal => 10; }
public struct R10D : IGeneralPurpose32Register { public int RegisterOrdinal => 10; }
public struct R10W : IGeneralPurpose16Register { public int RegisterOrdinal => 10; }
public struct R10B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 10; }

public struct R11 : IGeneralPurpose64Register { public int RegisterOrdinal => 11; }
public struct R11D : IGeneralPurpose32Register { public int RegisterOrdinal => 11; }
public struct R11W : IGeneralPurpose16Register { public int RegisterOrdinal => 11; }
public struct R11B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 11; }

public struct R12 : IGeneralPurpose64Register { public int RegisterOrdinal => 12; }
public struct R12D : IGeneralPurpose32Register { public int RegisterOrdinal => 12; }
public struct R12W : IGeneralPurpose16Register { public int RegisterOrdinal => 12; }
public struct R12B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 12; }

public struct R13 : IGeneralPurpose64Register { public int RegisterOrdinal => 13; }
public struct R13D : IGeneralPurpose32Register { public int RegisterOrdinal => 13; }
public struct R13W : IGeneralPurpose16Register { public int RegisterOrdinal => 13; }
public struct R13B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 13; }

public struct R14 : IGeneralPurpose64Register { public int RegisterOrdinal => 14; }
public struct R14D : IGeneralPurpose32Register { public int RegisterOrdinal => 14; }
public struct R14W : IGeneralPurpose16Register { public int RegisterOrdinal => 14; }
public struct R14B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 14; }

public struct R15 : IGeneralPurpose64Register { public int RegisterOrdinal => 15; }
public struct R15D : IGeneralPurpose32Register { public int RegisterOrdinal => 15; }
public struct R15W : IGeneralPurpose16Register { public int RegisterOrdinal => 15; }
public struct R15B : IGeneralPurpose8Register, ILowByteRegister, IExtendedByteRegister, IByteRegister { public int RegisterOrdinal => 15; }

public struct ZMM0 : ISimd512Register { public int RegisterOrdinal => 0; }
public struct ZMM1 : ISimd512Register { public int RegisterOrdinal => 1; }
public struct ZMM2 : ISimd512Register { public int RegisterOrdinal => 2; }
public struct ZMM3 : ISimd512Register { public int RegisterOrdinal => 3; }
public struct ZMM4 : ISimd512Register { public int RegisterOrdinal => 4; }
public struct ZMM5 : ISimd512Register { public int RegisterOrdinal => 5; }
public struct ZMM6 : ISimd512Register { public int RegisterOrdinal => 6; }
public struct ZMM7 : ISimd512Register { public int RegisterOrdinal => 7; }
public struct ZMM8 : ISimd512Register { public int RegisterOrdinal => 8; }
public struct ZMM9 : ISimd512Register { public int RegisterOrdinal => 9; }
public struct ZMM10 : ISimd512Register { public int RegisterOrdinal => 10; }
public struct ZMM11 : ISimd512Register { public int RegisterOrdinal => 11; }
public struct ZMM12 : ISimd512Register { public int RegisterOrdinal => 12; }
public struct ZMM13 : ISimd512Register { public int RegisterOrdinal => 13; }
public struct ZMM14 : ISimd512Register { public int RegisterOrdinal => 14; }
public struct ZMM15 : ISimd512Register { public int RegisterOrdinal => 15; }

public struct YMM0 : ISimd256Register { public int RegisterOrdinal => 0; }
public struct YMM1 : ISimd256Register { public int RegisterOrdinal => 1; }
public struct YMM2 : ISimd256Register { public int RegisterOrdinal => 2; }
public struct YMM3 : ISimd256Register { public int RegisterOrdinal => 3; }
public struct YMM4 : ISimd256Register { public int RegisterOrdinal => 4; }
public struct YMM5 : ISimd256Register { public int RegisterOrdinal => 5; }
public struct YMM6 : ISimd256Register { public int RegisterOrdinal => 6; }
public struct YMM7 : ISimd256Register { public int RegisterOrdinal => 7; }
public struct YMM8 : ISimd256Register { public int RegisterOrdinal => 8; }
public struct YMM9 : ISimd256Register { public int RegisterOrdinal => 9; }
public struct YMM10 : ISimd256Register { public int RegisterOrdinal => 10; }
public struct YMM11 : ISimd256Register { public int RegisterOrdinal => 11; }
public struct YMM12 : ISimd256Register { public int RegisterOrdinal => 12; }
public struct YMM13 : ISimd256Register { public int RegisterOrdinal => 13; }
public struct YMM14 : ISimd256Register { public int RegisterOrdinal => 14; }
public struct YMM15 : ISimd256Register { public int RegisterOrdinal => 15; }

public struct XMM0 : ISimd128Register { public int RegisterOrdinal => 0; }
public struct XMM1 : ISimd128Register { public int RegisterOrdinal => 1; }
public struct XMM2 : ISimd128Register { public int RegisterOrdinal => 2; }
public struct XMM3 : ISimd128Register { public int RegisterOrdinal => 3; }
public struct XMM4 : ISimd128Register { public int RegisterOrdinal => 4; }
public struct XMM5 : ISimd128Register { public int RegisterOrdinal => 5; }
public struct XMM6 : ISimd128Register { public int RegisterOrdinal => 6; }
public struct XMM7 : ISimd128Register { public int RegisterOrdinal => 7; }
public struct XMM8 : ISimd128Register { public int RegisterOrdinal => 8; }
public struct XMM9 : ISimd128Register { public int RegisterOrdinal => 9; }
public struct XMM10 : ISimd128Register { public int RegisterOrdinal => 10; }
public struct XMM11 : ISimd128Register { public int RegisterOrdinal => 11; }
public struct XMM12 : ISimd128Register { public int RegisterOrdinal => 12; }
public struct XMM13 : ISimd128Register { public int RegisterOrdinal => 13; }
public struct XMM14 : ISimd128Register { public int RegisterOrdinal => 14; }
public struct XMM15 : ISimd128Register { public int RegisterOrdinal => 15; }

public struct ES : ISegmentRegisterSource, ISegmentRegisterDestination { public int SegmentOrdinal => 0; }
public struct CS : ISegmentRegisterSource { public int SegmentOrdinal => 1; }
public struct SS : ISegmentRegisterSource, ISegmentRegisterDestination { public int SegmentOrdinal => 2; }
public struct DS : ISegmentRegisterSource, ISegmentRegisterDestination { public int SegmentOrdinal => 3; }
public struct FS : ISegmentRegisterSource, ISegmentRegisterDestination, IPopSegmentRegisterDestination { public int SegmentOrdinal => 4; }
public struct GS : ISegmentRegisterSource, ISegmentRegisterDestination, IPopSegmentRegisterDestination { public int SegmentOrdinal => 5; }

public struct RIP : IInstructionPointer64;
public struct EIP : IInstructionPointer32;
public struct IP : IInstructionPointer16;

public struct RFLAGS : IStatusRegister64;
public struct EFLAGS : IStatusRegister32;
public struct FLAGS : IStatusRegister16;

public struct CarryFlag : IRegisterFlag;
public struct ParityFlag : IRegisterFlag;
public struct AuxiliaryFlag : IRegisterFlag;
public struct ZeroFlag : IRegisterFlag;
public struct SignFlag : IRegisterFlag;
public struct TrapFlag : IRegisterFlag;
public struct InterruptFlag : IRegisterFlag;
public struct DirectionFlag : IRegisterFlag;
public struct OverflowFlag : IRegisterFlag;

public struct ST0 : IFpu80Register;
public struct ST1 : IFpu80Register;
public struct ST2 : IFpu80Register;
public struct ST3 : IFpu80Register;
public struct ST4 : IFpu80Register;
public struct ST5 : IFpu80Register;
public struct ST6 : IFpu80Register;
public struct ST7 : IFpu80Register;

public struct MM0 : ISimd64Register { public int RegisterOrdinal => 0; }
public struct MM1 : ISimd64Register { public int RegisterOrdinal => 1; }
public struct MM2 : ISimd64Register { public int RegisterOrdinal => 2; }
public struct MM3 : ISimd64Register { public int RegisterOrdinal => 3; }
public struct MM4 : ISimd64Register { public int RegisterOrdinal => 4; }
public struct MM5 : ISimd64Register { public int RegisterOrdinal => 5; }
public struct MM6 : ISimd64Register { public int RegisterOrdinal => 6; }
public struct MM7 : ISimd64Register { public int RegisterOrdinal => 7; }