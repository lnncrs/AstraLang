#!/bin/bash

Url='https://www.antlr.org/download/antlr-4.13.0-complete.jar'
FileName=$(basename "$Url")
OutputFolder="$PWD/bin"
OutputFile="$OutputFolder/$FileName"

if [ ! -d "$OutputFolder" ]; then
    mkdir -p "$OutputFolder"
fi

curl -o "$OutputFile" "$Url"
