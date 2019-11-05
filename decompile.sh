#!/bin/bash

./build.sh
ilspycmd bin/Debug/netcoreapp2.1/FSharpLambda.dll > decom.txt
ilspycmd -il bin/Debug/netcoreapp2.1/FSharpLambda.dll > decom-il.txt