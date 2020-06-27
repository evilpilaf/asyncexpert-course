## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdx,[rsi+8]
       test      rdi,rdi
       jl        short M00_L01
       mov       rbx,rdi
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       mov       rbp,rbx
       shl       rbp,4
       lea       rdx,[rdx+rbp+10]
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M00_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       add       rax,r14
       mov       r14d,1
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       movsxd    rcx,ecx
       cmp       rbx,rcx
       jae       short M00_L03
       lea       rdx,[rdx+rbp+10]
       mov       [rdx],r14b
       mov       [rdx+8],rax
M00_L00:
       test      r14b,r14b
       je        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       test      rdx,rdx
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       cmp       rdx,1
       je        short M00_L01
       cmp       rdx,2
       jne       short M00_L02
M00_L01:
       mov       eax,1
       ret
M00_L02:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,2
       cmp       rdx,2
       jbe       short M00_L04
M00_L03:
       lea       r8,[rax+rcx]
       mov       rax,rcx
       mov       rcx,r8
       inc       r9
       cmp       r9,rdx
       jb        short M00_L03
M00_L04:
       mov       rax,r8
       ret
; Total bytes of code 70
```

