## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.Foreach()
       mov     rax,qword ptr [rcx+8]
       xor     edx,edx
       xor     ecx,ecx
       mov     r8d,dword ptr [rax+8]
       test    r8d,r8d
       jle     M00_L01
M00_L00:
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     edx,r9d
       inc     ecx
       cmp     r8d,ecx
       jg      M00_L00
M00_L01:
       mov     eax,edx
; Total bytes of code 38
```

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ForSimple()
       xor     eax,eax
       xor     edx,edx
       mov     rcx,qword ptr [rcx+8]
       cmp     dword ptr [rcx+8],0
       jle     M00_L01
M00_L00:
       mov     r8,rcx
       cmp     edx,dword ptr [r8+8]
       jae     00007ffd`aca29853
       movsxd  r9,edx
       movzx   r8d,byte ptr [r8+r9+10h]
       add     eax,r8d
       inc     edx
       cmp     dword ptr [rcx+8],edx
       jg      M00_L00
M00_L01:
       add     rsp,28h
; Total bytes of code 46
```

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ForLocalCached()
       mov     rax,qword ptr [rcx+8]
       xor     edx,edx
       xor     ecx,ecx
       mov     r8d,dword ptr [rax+8]
       test    r8d,r8d
       jle     M00_L01
M00_L00:
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     edx,r9d
       inc     ecx
       cmp     r8d,ecx
       jg      M00_L00
M00_L01:
       mov     eax,edx
; Total bytes of code 38
```

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ListForeachSimple()
       xor     esi,esi
       mov     rcx,qword ptr [rcx+10h]
       mov     eax,dword ptr [rcx]
       mov     eax,dword ptr [rcx+14h]
       xor     edx,edx
       mov     qword ptr [rsp+28h],rcx
       xor     ecx,ecx
       mov     dword ptr [rsp+30h],ecx
       mov     dword ptr [rsp+34h],eax
       mov     byte ptr [rsp+38h],dl
       lea     rcx,[rsp+28h]
       call    System.Collections.Generic.List`1+Enumerator[[System.Byte, System.Private.CoreLib]].MoveNext()
       test    eax,eax
       je      M00_L01
M00_L00:
       mov     ecx,dword ptr [rsp+38h]
       movzx   ecx,cl
       add     esi,ecx
       lea     rcx,[rsp+28h]
       call    System.Collections.Generic.List`1+Enumerator[[System.Byte, System.Private.CoreLib]].MoveNext()
       test    eax,eax
       jne     M00_L00
M00_L01:
       mov     eax,esi
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.Byte, System.Private.CoreLib]].MoveNext()
       mov     rcx,qword ptr [rbp+10h]
       mov     rcx,qword ptr [rcx]
       mov     qword ptr [rbp-18h],rcx
       mov     rcx,qword ptr [rbp+10h]
       mov     ecx,dword ptr [rcx+0Ch]
       mov     rax,qword ptr [rbp-18h]
       cmp     ecx,dword ptr [rax+14h]
       jne     M01_L00
       mov     rcx,qword ptr [rbp+10h]
       mov     ecx,dword ptr [rcx+8]
       mov     rax,qword ptr [rbp-18h]
       cmp     ecx,dword ptr [rax+10h]
       jae     M01_L00
       mov     rcx,qword ptr [rbp-18h]
       mov     rsi,qword ptr [rcx+8]
       mov     rcx,qword ptr [rbp+10h]
       mov     ecx,dword ptr [rcx+8]
       cmp     ecx,dword ptr [rsi+8]
       jae     M01_L01
       mov     eax,ecx
       imul    rax,rax,28h
       lea     rsi,[rsi+rax+10h]
       mov     rdi,qword ptr [rbp+10h]
       add     rdi,10h
       call    coreclr!coreclr_shutdown_2+0xd1f0
       mov     ecx,4
       rep     movs qword ptr [rdi],qword ptr [rsi]
       mov     rax,qword ptr [rbp+10h]
       inc     dword ptr [rax+8]
       mov     eax,1
       lea     rsp,[rbp-10h]
       pop     rsi
       pop     rdi
       pop     rbp
       ret
M01_L00:
       mov     rcx,qword ptr [rbp+10h]
       call    System.Collections.Generic.List`1+Enumerator[[BenchmarkDotNet.Reports.Measurement, BenchmarkDotNet]].MoveNextRare()
       nop
       lea     rsp,[rbp-10h]
       pop     rsi
       pop     rdi
       pop     rbp
       ret
M01_L01:
       call    coreclr!GetCLRRuntimeHost+0x73860
       int     3
       add     byte ptr [rax],al
       add     byte ptr [rcx],bl
       ???
       add     al,0
       ???
       push    rdx
       add     esp,dword ptr [rax+2]
       jo      M01_L02
       push    rax
M01_L02:
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],ch
       ???
       lods    dword ptr [rsi]
       sub     rsp,28h
       nop
       mov     rax,qword ptr [rcx]
       mov     edx,dword ptr [rcx+0Ch]
       cmp     edx,dword ptr [rax+14h]
       jne     System_Private_CoreLib+0x64ed69
       mov     edx,dword ptr [rcx+8]
       cmp     edx,dword ptr [rax+10h]
       jae     System_Private_CoreLib+0x64ed69
       mov     rax,qword ptr [rax+8]
       cmp     edx,dword ptr [rax+8]
       jae     System_Private_CoreLib+0x64ed91
       movsxd  rdx,edx
       movzx   eax,byte ptr [rax+rdx+10h]
       mov     byte ptr [rcx+10h],al
       inc     dword ptr [rcx+8]
       mov     eax,1
       add     rsp,28h
       ret
       mov     eax,dword ptr [rcx+0Ch]
       mov     rdx,qword ptr [rcx]
       cmp     eax,dword ptr [rdx+14h]
       jne     System_Private_CoreLib+0x64ed8a
       mov     rax,qword ptr [rcx]
       mov     eax,dword ptr [rax+10h]
       inc     eax
       mov     dword ptr [rcx+8],eax
       mov     byte ptr [rcx+10h],0
       xor     eax,eax
       add     rsp,28h
       ret
       call    qword ptr [System_Private_CoreLib+0x172a0
       int     3
; Total bytes of code 262
```
**Abstract method**
System.IDisposable.Dispose()

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ListForSimple()
       xor     eax,eax
       xor     edx,edx
       jmp     M00_L01
M00_L00:
       mov     r8,qword ptr [rcx+10h]
       cmp     edx,dword ptr [r8+10h]
       jae     M00_L02
       mov     r8,qword ptr [r8+8]
       cmp     edx,dword ptr [r8+8]
       jae     00007ffd`aca59731
       movsxd  r9,edx
       movzx   r8d,byte ptr [r8+r9+10h]
       add     eax,r8d
       inc     edx
M00_L01:
       mov     r8,qword ptr [rcx+10h]
       cmp     edx,dword ptr [r8+10h]
       jl      M00_L00
       add     rsp,28h
       ret
M00_L02:
       call    System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int     3
; Total bytes of code 61
```
**Method got most probably inlined**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ListForToArray()
       xor     edx,edx
       xor     ecx,ecx
       mov     r8d,dword ptr [rax+8]
       test    r8d,r8d
       jle     M00_L01
M00_L00:
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     edx,r9d
       inc     ecx
       cmp     r8d,ecx
       jg      M00_L00
M00_L01:
       mov     eax,edx
; Total bytes of code 34
```

## .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```assembly
; Bdn1.LoopOverArrayOfBytes.ListForLocalCached()
       mov     rdx,qword ptr [rcx+10h]
       xor     eax,eax
       xor     ecx,ecx
       mov     r8d,dword ptr [rdx+10h]
       test    r8d,r8d
       jle     M00_L01
M00_L00:
       cmp     ecx,r8d
       jae     M00_L02
       mov     r9,qword ptr [rdx+8]
       cmp     ecx,dword ptr [r9+8]
       jae     00007ffd`aca49732
       movsxd  r10,ecx
       movzx   r9d,byte ptr [r9+r10+10h]
       add     eax,r9d
       inc     ecx
       cmp     ecx,r8d
       jl      M00_L00
M00_L01:
       add     rsp,28h
       ret
M00_L02:
       call    System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int     3
; Total bytes of code 62
```
**Method got most probably inlined**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

