namespace HelloApp
module Hello =

    open System
    open System.IO

    let handler (stream: Stream): Stream =
        printfn "Hello World from F# Lambda!"
        let memoryStream = new MemoryStream()
        let resp = new StreamWriter(memoryStream)
        resp.Write("Hello World from F# Lambda!")
        resp.Flush()
        memoryStream.Seek(0L, SeekOrigin.Begin) |> ignore
        memoryStream :> Stream