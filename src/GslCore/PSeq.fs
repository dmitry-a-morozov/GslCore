module FSharp.Collections.ParallelSeq.PSeq

open System.Linq
open System

let inline private toP (s : seq<_>) = 
    match s with
    | null -> nullArg "s"
    | :? ParallelQuery<_> as p ->  p
    | _ -> s.AsParallel()

let map f s = ParallelEnumerable.Select(toP(s), new Func<_,_>(f)) 
let toArray s = ParallelEnumerable.ToArray(toP(s))
let withDegreeOfParallelism n s = toP(s).WithDegreeOfParallelism(n)