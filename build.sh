#!/bin/bash

set -uex

dotnet build
cd bin/Debug/netcoreapp2.1
zip Lambda.zip *
mv Lambda.zip ../../../
cd ../../../