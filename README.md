# F# Lambda

This is a test Lambda with F#.

Run `build.sh` or `decompile.sh` then upload the resulting .zip file to Lambda. Test with any event.

The handler will be `FSharpLambda::HelloApp.Hello::handler`

## Notes

You can remove the top level namespace if you wish. If you decompile the F#, you will see it no longer has a top-level namespace. The new handler path is `FSharpLambda::Hello::handler`.
