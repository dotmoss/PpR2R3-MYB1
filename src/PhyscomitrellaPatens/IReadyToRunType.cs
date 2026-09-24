using PhyscomitrellaPatens.Registers;

namespace PhyscomitrellaPatens;

public unsafe interface IReadyToRunType
{
    private protected static RAX rax; private protected static EAX eax; private protected static AX ax; private protected static AL al; private protected static AH ah;
    private protected static RBX rbx; private protected static EBX ebx; private protected static BX bx; private protected static BL bl; private protected static BH bh;
    private protected static RCX rcx; private protected static ECX ecx; private protected static CX cx; private protected static CL cl; private protected static CH ch;
    private protected static RDX rdx; private protected static EDX edx; private protected static DX dx; private protected static DL dl; private protected static DH dh;

    private protected static RBP rbp; private protected static EBP ebp; private protected static BP bp; private protected static BPL bpl;
    private protected static RSP rsp; private protected static ESP esp; private protected static SP sp; private protected static SPL spl;
    private protected static RSI rsi; private protected static ESI esi; private protected static SI si; private protected static SIL sil;
    private protected static RDI rdi; private protected static EDI edi; private protected static DI di; private protected static DIL dil;

    private protected static R8 r8; private protected static R8D r8d; private protected static R8W r8w; private protected static R8B r8b;
    private protected static R9 r9; private protected static R9D r9d; private protected static R9W r9w; private protected static R9B r9b;
    private protected static R10 r10; private protected static R10D r10d; private protected static R10W r10w; private protected static R10B r10b;
    private protected static R11 r11; private protected static R11D r11d; private protected static R11W r11w; private protected static R11B r11b;
    private protected static R12 r12; private protected static R12D r12d; private protected static R12W r12w; private protected static R12B r12b;
    private protected static R13 r13; private protected static R13D r13d; private protected static R13W r13w; private protected static R13B r13b;
    private protected static R14 r14; private protected static R14D r14d; private protected static R14W r14w; private protected static R14B r14b;
    private protected static R15 r15; private protected static R15D r15d; private protected static R15W r15w; private protected static R15B r15b;

    private protected static CS cs;
    private protected static DS ds;
    private protected static SS ss;
    private protected static ES es;
    private protected static FS fs;
    private protected static GS gs;

    private protected static RIP rip; private protected static EIP eip; private protected static IP ip;

    private protected static RFLAGS rflags; private protected static EFLAGS eflags; private protected static FLAGS flags;

    private protected static CarryFlag carryFlag;
    private protected static ParityFlag parityFlag;
    private protected static AuxiliaryFlag auxiliaryFlag;
    private protected static ZeroFlag zeroFlag;
    private protected static SignFlag signFlag;
    private protected static TrapFlag trapFlag;
    private protected static InterruptFlag interruptFlag;
    private protected static DirectionFlag directionFlag;
    private protected static OverflowFlag overflowFlag;

    private protected static ST0 st0;
    private protected static ST1 st1;
    private protected static ST2 st2;
    private protected static ST3 st3;
    private protected static ST4 st4;
    private protected static ST5 st5;
    private protected static ST6 st6;
    private protected static ST7 st7;

    private protected static MM0 mm0;
    private protected static MM1 mm1;
    private protected static MM2 mm2;
    private protected static MM3 mm3;
    private protected static MM4 mm4;
    private protected static MM5 mm5;
    private protected static MM6 mm6;
    private protected static MM7 mm7;

    private protected static ZMM0 zmm0; private protected static YMM0 ymm0; private protected static XMM0 xmm0;
    private protected static ZMM1 zmm1; private protected static YMM1 ymm1; private protected static XMM1 xmm1;
    private protected static ZMM2 zmm2; private protected static YMM2 ymm2; private protected static XMM2 xmm2;
    private protected static ZMM3 zmm3; private protected static YMM3 ymm3; private protected static XMM3 xmm3;
    private protected static ZMM4 zmm4; private protected static YMM4 ymm4; private protected static XMM4 xmm4;
    private protected static ZMM5 zmm5; private protected static YMM5 ymm5; private protected static XMM5 xmm5;
    private protected static ZMM6 zmm6; private protected static YMM6 ymm6; private protected static XMM6 xmm6;
    private protected static ZMM7 zmm7; private protected static YMM7 ymm7; private protected static XMM7 xmm7;
    private protected static ZMM8 zmm8; private protected static YMM8 ymm8; private protected static XMM8 xmm8;
    private protected static ZMM9 zmm9; private protected static YMM9 ymm9; private protected static XMM9 xmm9;
    private protected static ZMM10 zmm10; private protected static YMM10 ymm10; private protected static XMM10 xmm10;
    private protected static ZMM11 zmm11; private protected static YMM11 ymm11; private protected static XMM11 xmm11;
    private protected static ZMM12 zmm12; private protected static YMM12 ymm12; private protected static XMM12 xmm12;
    private protected static ZMM13 zmm13; private protected static YMM13 ymm13; private protected static XMM13 xmm13;
    private protected static ZMM14 zmm14; private protected static YMM14 ymm14; private protected static XMM14 xmm14;
    private protected static ZMM15 zmm15; private protected static YMM15 ymm15; private protected static XMM15 xmm15;

    static void* buffer;
    static nuint offset;

    static void Insert(Action code) { }

    #region mov
    private static unsafe void Emit(byte b)
    {
        *((byte*)buffer + offset) = b; offset++;
    }

    private static unsafe void Emit32(int v)
    {
        *(int*)((byte*)buffer + offset) = v; offset += 4;
    }

    public static void mov(ILowByteRegister destination, ILowByteRegister source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        if (dst >= 4 || src >= 4)
            Emit((byte)(0x40 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x88);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(ILowLegacyByteRegister destination, IHighByteRegister source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x88);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IHighByteRegister destination, ILowLegacyByteRegister source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x88);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IHighByteRegister destination, IHighByteRegister source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x88);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IGeneralPurpose16Register destination, IGeneralPurpose16Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x66);
        if (dst >= 8 || src >= 8)
            Emit((byte)(0x40 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x89);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IGeneralPurpose32Register destination, IGeneralPurpose32Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        if (dst >= 8 || src >= 8)
            Emit((byte)(0x40 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x89);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IGeneralPurpose64Register destination, IGeneralPurpose64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit((byte)(0x48 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x89);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IGeneralPurpose16Register destination, ISegmentRegisterSource source)
    {
        var dst = destination.RegisterOrdinal;
        var seg = source.SegmentOrdinal;
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x8C);
        Emit((byte)(0xC0 | ((seg & 7) << 3) | (dst & 7)));
    }

    public static void mov(ISegmentRegisterDestination destination, IGeneralPurpose16Register source)
    {
        var seg = destination.SegmentOrdinal;
        var src = source.RegisterOrdinal;
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x8E);
        Emit((byte)(0xC0 | ((seg & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd64Register destination, ISimd64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x0F);
        Emit(0x6F);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd128Register destination, ISimd128Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        if (dst >= 8 || src >= 8)
            Emit((byte)(0x40 | ((dst >> 3) << 2) | (src >> 3)));
        Emit(0x0F);
        Emit(0x28);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd256Register destination, ISimd256Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0xC4);
        Emit((byte)(((~(dst >> 3) & 1) << 7) | (1 << 6) | ((~(src >> 3) & 1) << 5) | 0x01));
        Emit(0x7C);
        Emit(0x28);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd512Register destination, ISimd512Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x62);
        Emit((byte)(((~(dst >> 3) & 1) << 7) | (1 << 6) | ((~(src >> 3) & 1) << 5) | (1 << 4) | 0x01));
        Emit(0x7C);
        Emit(0x48);
        Emit(0x28);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd128Register destination, ISimd64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0xF3);
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x0F);
        Emit(0xD6);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd64Register destination, ISimd128Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0xF2);
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x0F);
        Emit(0xD6);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(ISimd128Register destination, IGeneralPurpose32Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x66);
        if (dst >= 8 || src >= 8)
            Emit((byte)(0x40 | ((dst >> 3) << 2) | (src >> 3)));
        Emit(0x0F);
        Emit(0x6E);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(IGeneralPurpose32Register destination, ISimd128Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x66);
        if (dst >= 8 || src >= 8)
            Emit((byte)(0x40 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x0F);
        Emit(0x7E);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(ISimd128Register destination, IGeneralPurpose64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x66);
        Emit((byte)(0x48 | ((dst >> 3) << 2) | (src >> 3)));
        Emit(0x0F);
        Emit(0x6E);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(IGeneralPurpose64Register destination, ISimd128Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit(0x66);
        Emit((byte)(0x48 | ((src >> 3) << 2) | (dst >> 3)));
        Emit(0x0F);
        Emit(0x7E);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(ISimd64Register destination, IGeneralPurpose32Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x0F);
        Emit(0x6E);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(IGeneralPurpose32Register destination, ISimd64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x0F);
        Emit(0x7E);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(ISimd64Register destination, IGeneralPurpose64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit((byte)(0x48 | (src >> 3)));
        Emit(0x0F);
        Emit(0x6E);
        Emit((byte)(0xC0 | ((dst & 7) << 3) | (src & 7)));
    }

    public static void mov(IGeneralPurpose64Register destination, ISimd64Register source)
    {
        var dst = destination.RegisterOrdinal;
        var src = source.RegisterOrdinal;
        Emit((byte)(0x48 | (dst >> 3)));
        Emit(0x0F);
        Emit(0x7E);
        Emit((byte)(0xC0 | ((src & 7) << 3) | (dst & 7)));
    }

    public static void mov(IByteRegister destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        bool high = destination is AH or BH or CH or DH;
        if (!high && dst >= 4) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x8A);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, IByteRegister source)
    {
        var src = source.RegisterOrdinal;
        bool high = source is AH or BH or CH or DH;
        if (!high && src >= 4) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x88);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(IGeneralPurpose16Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        Emit(0x66);
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x8B);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, IGeneralPurpose16Register source)
    {
        var src = source.RegisterOrdinal;
        Emit(0x66);
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x89);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(IGeneralPurpose32Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x8B);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, IGeneralPurpose32Register source)
    {
        var src = source.RegisterOrdinal;
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x89);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(IGeneralPurpose64Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        Emit((byte)(0x48 | (dst >> 3)));
        Emit(0x8B);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, IGeneralPurpose64Register source)
    {
        var src = source.RegisterOrdinal;
        Emit((byte)(0x48 | (src >> 3)));
        Emit(0x89);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(ISegmentRegisterDestination destination, nint source)
    {
        var seg = destination.SegmentOrdinal;
        Emit(0x8E);
        Emit((byte)(((seg & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, ISegmentRegisterSource source)
    {
        var seg = source.SegmentOrdinal;
        Emit(0x8C);
        Emit((byte)(((seg & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(ISimd64Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        Emit(0x0F);
        Emit(0x6F);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, ISimd64Register source)
    {
        var src = source.RegisterOrdinal;
        Emit(0x0F);
        Emit(0x7F);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(ISimd128Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        if (dst >= 8) Emit((byte)(0x40 | (dst >> 3)));
        Emit(0x0F);
        Emit(0x28);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, ISimd128Register source)
    {
        var src = source.RegisterOrdinal;
        if (src >= 8) Emit((byte)(0x40 | (src >> 3)));
        Emit(0x0F);
        Emit(0x29);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(ISimd256Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        Emit(0xC4);
        Emit((byte)(((~(dst >> 3) & 1) << 7) | (1 << 6) | (1 << 5) | 0x01));
        Emit(0x7C);
        Emit(0x28);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, ISimd256Register source)
    {
        var src = source.RegisterOrdinal;
        Emit(0xC4);
        Emit((byte)(((~(src >> 3) & 1) << 7) | (1 << 6) | (1 << 5) | 0x01));
        Emit(0x7C);
        Emit(0x29);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }

    public static void mov(ISimd512Register destination, nint source)
    {
        var dst = destination.RegisterOrdinal;
        Emit(0x62);
        Emit((byte)(((~(dst >> 3) & 1) << 7) | 0x71));
        Emit(0x7C);
        Emit(0x48);
        Emit(0x28);
        Emit((byte)(((dst & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)source);
    }

    public static void mov(nint destination, ISimd512Register source)
    {
        var src = source.RegisterOrdinal;
        Emit(0x62);
        Emit((byte)(((~(src >> 3) & 1) << 7) | 0x71));
        Emit(0x7C);
        Emit(0x48);
        Emit(0x29);
        Emit((byte)(((src & 7) << 3) | 0x04));
        Emit(0x25);
        Emit32((int)destination);
    }
    #endregion
}