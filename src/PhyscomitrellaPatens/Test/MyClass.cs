using static PhyscomitrellaPatens.IReadyToRunType;

namespace PhyscomitrellaPatens.Test;

internal class MyClass : IReadyToRunType
{
    public static void MyMethod(int value1, int value2)
    {
        mov(r14, rax);
        mov(rax, rax);
    }
}