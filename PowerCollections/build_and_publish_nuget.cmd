dotnet pack
cd PowerCollections/bin/Debug
dotnet nuget push "*.nupkg" -k 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 -s https://nuget.pkg.github.com/VSynV/index.json --skip-duplicate
pause