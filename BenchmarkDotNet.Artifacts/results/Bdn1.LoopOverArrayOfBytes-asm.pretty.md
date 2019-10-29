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
       jae     00007ff8`7d5f5794
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5c581f
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5c581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5c581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5c581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5c581f
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       mov     rcx,qword ptr [rbx]
       mov     eax,dword ptr [rbx+0Ch]
       cmp     eax,dword ptr [rcx+14h]
       jne     M01_L00
       mov     eax,dword ptr [rbx+8]
       cmp     eax,dword ptr [rcx+10h]
       jae     M01_L00
       lea     rdi,[rbx+10h]
       mov     rcx,qword ptr [rcx+8]
       cmp     eax,dword ptr [rcx+8]
       jae     M01_L01
       movsxd  rax,eax
       lea     rax,[rax+rax*4]
       lea     rsi,[rcx+rax*8+10h]
       call    coreclr!coreclr_shutdown_2+0xd1f0
       mov     ecx,4
       rep     movs qword ptr [rdi],qword ptr [rsi]
       inc     dword ptr [rbx+8]
       mov     eax,1
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M01_L00:
       mov     rcx,rbx
       mov     rax,7FF87D5C8548h
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       jmp     rax
M01_L01:
       call    coreclr!GetCLRRuntimeHost+0x73860
       int     3
       sbb     dword ptr [rdi],eax
       add     al,0
       ???
       xor     al,byte ptr [rbx]
       xor     byte ptr [rdx],al
       ???
       add     dword ptr [rax+40h],esi
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ah
       ???
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
; Total bytes of code 225
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
       jae     00007ff8`7d5f57a2
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
       jae     00007ff8`7d5b57a3
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
       jae     00007ff8`7d609313
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5e939e
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5e939e
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5e939e
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5e939e
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5e939e
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       add     byte ptr [rax],al
       and     byte ptr [rsi+7Dh],0F8h
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
; Total bytes of code 264
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
       jae     00007ff8`7d5f9321
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
       jae     00007ff8`7d5d9452
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
       jae     00007ff8`7d5d5794
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5f581f
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5f581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5f581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5f581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5f581f
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       mov     rcx,qword ptr [rbx]
       mov     eax,dword ptr [rbx+0Ch]
       cmp     eax,dword ptr [rcx+14h]
       jne     M01_L00
       mov     eax,dword ptr [rbx+8]
       cmp     eax,dword ptr [rcx+10h]
       jae     M01_L00
       lea     rdi,[rbx+10h]
       mov     rcx,qword ptr [rcx+8]
       cmp     eax,dword ptr [rcx+8]
       jae     M01_L01
       movsxd  rax,eax
       lea     rax,[rax+rax*4]
       lea     rsi,[rcx+rax*8+10h]
       call    coreclr!coreclr_shutdown_2+0xd1f0
       mov     ecx,4
       rep     movs qword ptr [rdi],qword ptr [rsi]
       inc     dword ptr [rbx+8]
       mov     eax,1
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M01_L00:
       mov     rcx,rbx
       mov     rax,7FF87D5F8548h
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       jmp     rax
M01_L01:
       call    coreclr!GetCLRRuntimeHost+0x73860
       int     3
       sbb     dword ptr [rdi],eax
       add     al,0
       ???
       xor     al,byte ptr [rbx]
       xor     byte ptr [rdx],al
       ???
       add     dword ptr [rax+40h],esi
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ah
       push    7FF87Dh
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
; Total bytes of code 230
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
       jae     00007ff8`7d5e57a2
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
       jae     00007ff8`7d5c57a3
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
       jae     00007ff8`7d5e9443
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5e94ce
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5e94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5e94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5e94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5e94ce
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
M01_L03:
       add     byte ptr [rax],al
       add     byte ptr [rax+7Fh],dh
       jge     M01_L03
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
; Total bytes of code 264
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
       jae     00007ff8`7d5f9321
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
       jae     00007ff8`7d5e9452
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
       jae     00007ff8`7d5b5794
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5d581f
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       mov     rcx,qword ptr [rbx]
       mov     eax,dword ptr [rbx+0Ch]
       cmp     eax,dword ptr [rcx+14h]
       jne     M01_L00
       mov     eax,dword ptr [rbx+8]
       cmp     eax,dword ptr [rcx+10h]
       jae     M01_L00
       lea     rdi,[rbx+10h]
       mov     rcx,qword ptr [rcx+8]
       cmp     eax,dword ptr [rcx+8]
       jae     M01_L01
       movsxd  rax,eax
       lea     rax,[rax+rax*4]
       lea     rsi,[rcx+rax*8+10h]
       call    coreclr!coreclr_shutdown_2+0xd1f0
       mov     ecx,4
       rep     movs qword ptr [rdi],qword ptr [rsi]
       inc     dword ptr [rbx+8]
       mov     eax,1
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M01_L00:
       mov     rcx,rbx
       mov     rax,7FF87D5D8548h
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       jmp     rax
M01_L01:
       call    coreclr!GetCLRRuntimeHost+0x73860
       int     3
       sbb     dword ptr [rdi],eax
       add     al,0
       ???
       xor     al,byte ptr [rbx]
       xor     byte ptr [rdx],al
       ???
       add     dword ptr [rax+40h],esi
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ah
       ???
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
; Total bytes of code 225
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
       jae     00007ff8`7d5d57a2
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
       jae     00007ff8`7d5b57a3
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
       jae     00007ff8`7d609443
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5f94ce
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5f94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5f94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5f94ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5f94ce
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
M01_L03:
       add     byte ptr [rax],al
       add     byte ptr [rax+7Fh],dh
       jge     M01_L03
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
; Total bytes of code 264
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
       jae     00007ff8`7d5f9321
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
       jae     00007ff8`7d5e9452
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
       jae     00007ff8`7d5e5794
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d5d581f
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d5d581f
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       mov     rcx,qword ptr [rbx]
       mov     eax,dword ptr [rbx+0Ch]
       cmp     eax,dword ptr [rcx+14h]
       jne     M01_L00
       mov     eax,dword ptr [rbx+8]
       cmp     eax,dword ptr [rcx+10h]
       jae     M01_L00
       lea     rdi,[rbx+10h]
       mov     rcx,qword ptr [rcx+8]
       cmp     eax,dword ptr [rcx+8]
       jae     M01_L01
       movsxd  rax,eax
       lea     rax,[rax+rax*4]
       lea     rsi,[rcx+rax*8+10h]
       call    coreclr!coreclr_shutdown_2+0xd1f0
       mov     ecx,4
       rep     movs qword ptr [rdi],qword ptr [rsi]
       inc     dword ptr [rbx+8]
       mov     eax,1
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M01_L00:
       mov     rcx,rbx
       mov     rax,7FF87D5E8548h
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       jmp     rax
M01_L01:
       call    coreclr!GetCLRRuntimeHost+0x73860
       int     3
       sbb     dword ptr [rdi],eax
       add     al,0
       ???
       xor     al,byte ptr [rbx]
       xor     byte ptr [rdx],al
       ???
       add     dword ptr [rax+40h],esi
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,ah
       ???
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
; Total bytes of code 225
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
       jae     00007ff8`7d5e57a2
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
       jae     00007ff8`7d5c57a3
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
       jae     00007ff8`7d5f9313
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
; Bdn1.LoopOverArrayOfBytes.ForLocalCachedUnrolled()
       mov     rax,qword ptr [rcx+8]
       mov     edx,dword ptr [rax+8]
       mov     ecx,edx
       sar     ecx,1Fh
       and     ecx,3
       add     ecx,edx
       sar     ecx,2
       xor     r8d,r8d
       xor     r9d,r9d
       xor     r10d,r10d
       test    ecx,ecx
       jle     M00_L01
M00_L00:
       mov     r9d,r10d
       shl     r9d,2
       cmp     r9d,edx
       jae     00007ff8`7d6094ce
       movsxd  r11,r9d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r8d,r11d
       lea     r11d,[r9+1]
       cmp     r11d,edx
       jae     00007ff8`7d6094ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+2]
       cmp     r11d,edx
       jae     00007ff8`7d6094ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       lea     r11d,[r9+3]
       cmp     r11d,edx
       jae     00007ff8`7d6094ce
       movsxd  r11,r11d
       movzx   r11d,byte ptr [rax+r11+10h]
       add     r11d,r8d
       mov     r8d,r11d
       inc     r10d
       cmp     r10d,ecx
       jl      M00_L00
M00_L01:
       lea     ecx,[r9*4+4]
       cmp     edx,ecx
       jle     M00_L03
M00_L02:
       cmp     ecx,edx
       jae     00007ff8`7d6094ce
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rax+r9+10h]
       add     r9d,r8d
       mov     r8d,r9d
       inc     ecx
       cmp     edx,ecx
       jg      M00_L02
M00_L03:
       mov     eax,r8d
; Total bytes of code 181
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
       add     byte ptr [rax+7Fh],dh
       jge     00000000`0000d955
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
; Total bytes of code 264
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
       jae     00007ff8`7d619451
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
       jae     00007ff8`7d609452
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

