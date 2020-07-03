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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rdx,rsi
       shl       rdx,1
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       lea       rdx,[rsi+rsi]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rdx,rsi
       shl       rdx,1
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       lea       rdx,[rsi+rsi]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rdx,rsi
       shl       rdx,1
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       lea       rdx,[rsi+rsi]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rdx,rsi
       shl       rdx,1
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       lea       rdx,[rsi+rsi]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.Nullable`1[[System.UInt64, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,1
       mov       edx,[rax+8]
       cmp       edx,0
       jbe       short M00_L01
       lea       r8,[rax+10]
       mov       [r8],cl
       xor       ecx,ecx
       mov       [r8+8],rcx
       mov       ecx,1
       cmp       edx,1
       jbe       short M00_L01
       lea       rdx,[rax+20]
       mov       [rdx],cl
       mov       qword ptr [rdx+8],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rax
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 118
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       jl        short M01_L01
       mov       rdx,rdi
       mov       ecx,[rsi+8]
       movsxd    rcx,ecx
       cmp       rdx,rcx
       jae       short M01_L03
       shl       rdx,4
       lea       rbp,[rsi+rdx+10]
       mov       rdx,rbp
       movzx     r14d,byte ptr [rdx]
       mov       rax,[rdx+8]
       test      r14b,r14b
       jne       short M01_L00
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       mov       r14,rax
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rbx
       mov       r8,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemorization(UInt64, System.Nullable`1<UInt64>[])
       add       rax,r14
       mov       r14d,1
       mov       [rbp],r14b
       mov       [rbp+8],rax
M01_L00:
       test      r14b,r14b
       je        short M01_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 146
```

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

