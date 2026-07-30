using static PhyscomitrellaPatens.IReadyToRunType;

namespace PhyscomitrellaPatens.Test;

internal class MyClass : IReadyToRunType
{
    public static void MyMethod(int value1, int value2)
    {
        MethodBody(() =>
        {
            mov(rax, rcx);
        });
    }
}