using PhyscomitrellaPatens.Registers;

namespace PhyscomitrellaPatens;

public interface IReadyToRunType
{
    private protected static rax rax; private protected static eax eax;   private protected static ax ax;     private protected static al al;     private protected static ah ah;
    private protected static rbx rbx; private protected static ebx ebx;   private protected static bx bx;     private protected static bl bl;     private protected static bh bh;
    private protected static rcx rcx; private protected static ecx ecx;   private protected static cx cx;     private protected static cl cl;     private protected static ch ch;
    private protected static rdx rdx; private protected static edx edx;   private protected static dx dx;     private protected static dl dl;     private protected static dh dh;
    private protected static rbp rbp; private protected static ebp ebp;   private protected static bp bp;     private protected static bpl bpl;
    private protected static rsp rsp; private protected static esp esp;   private protected static sp sp;     private protected static spl spl;
    private protected static rsi rsi; private protected static esi esi;   private protected static si si;     private protected static sil sil;
    private protected static rdi rdi; private protected static edi edi;   private protected static di di;     private protected static dil dil;
    private protected static rip rip; private protected static eip eip;   private protected static ip ip;
    private protected static r8 r8;   private protected static r8d r8d;   private protected static r8w r8w;   private protected static r8b r8b;
    private protected static r9 r9;   private protected static r9d r9d;   private protected static r9w r9w;   private protected static r9b r9b;
    private protected static r10 r10; private protected static r10d r10d; private protected static r10w r10w; private protected static r10b r10b;
    private protected static r11 r11; private protected static r11d r11d; private protected static r11w r11w; private protected static r11b r11b;
    private protected static r12 r12; private protected static r12d r12d; private protected static r12w r12w; private protected static r12b r12b;
    private protected static r13 r13; private protected static r13d r13d; private protected static r13w r13w; private protected static r13b r13b;
    private protected static r14 r14; private protected static r14d r14d; private protected static r14w r14w; private protected static r14b r14b;
    private protected static r15 r15; private protected static r15d r15d; private protected static r15w r15w; private protected static r15b r15b;

    static void MethodBody(Action code) { }

    static void Insert(Action code) { }

    static void mov(X64Register destination, X64Register source) { }
}