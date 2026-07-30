namespace PhyscomitrellaPatens.Registers;

public interface X64Register; 
public interface X32Register; 
public interface X16Register; 
public interface X8Register;

public struct rax : X64Register; public struct eax : X32Register;  public struct ax : X16Register;   public struct al : X8Register;   public struct ah : X8Register;
public struct rbx : X64Register; public struct ebx : X32Register;  public struct bx : X16Register;   public struct bl : X8Register;   public struct bh : X8Register;
public struct rcx : X64Register; public struct ecx : X32Register;  public struct cx : X16Register;   public struct cl : X8Register;   public struct ch : X8Register;
public struct rdx : X64Register; public struct edx : X32Register;  public struct dx : X16Register;   public struct dl : X8Register;   public struct dh : X8Register;
public struct rbp : X64Register; public struct ebp : X32Register;  public struct bp : X16Register;   public struct bpl : X8Register;
public struct rsp : X64Register; public struct esp : X32Register;  public struct sp : X16Register;   public struct spl : X8Register;
public struct rsi : X64Register; public struct esi : X32Register;  public struct si : X16Register;   public struct sil : X8Register;
public struct rdi : X64Register; public struct edi : X32Register;  public struct di : X16Register;   public struct dil : X8Register;
public struct r8 : X64Register;  public struct r8d : X32Register;  public struct r8w : X16Register;  public struct r8b : X8Register;
public struct r9 : X64Register;  public struct r9d : X32Register;  public struct r9w : X16Register;  public struct r9b : X8Register;
public struct r10 : X64Register; public struct r10d : X32Register; public struct r10w : X16Register; public struct r10b : X8Register;
public struct r11 : X64Register; public struct r11d : X32Register; public struct r11w : X16Register; public struct r11b : X8Register;
public struct r12 : X64Register; public struct r12d : X32Register; public struct r12w : X16Register; public struct r12b : X8Register;
public struct r13 : X64Register; public struct r13d : X32Register; public struct r13w : X16Register; public struct r13b : X8Register;
public struct r14 : X64Register; public struct r14d : X32Register; public struct r14w : X16Register; public struct r14b : X8Register;
public struct r15 : X64Register; public struct r15d : X32Register; public struct r15w : X16Register; public struct r15b : X8Register;
public struct rip : X64Register; public struct ripd : X32Register; public struct ripw : X16Register; public struct ripb : X8Register;

interface RegisterFlag;
struct CarryFlag : RegisterFlag;
struct ParityFlag : RegisterFlag;
struct AuxiliaryFlag : RegisterFlag;
struct ZeroFlag : RegisterFlag;
struct SignFlag : RegisterFlag;
struct TrapFlag : RegisterFlag;
struct InterruptFlag : RegisterFlag;
struct DirectionFlag : RegisterFlag;
struct OverflowFlag : RegisterFlag;