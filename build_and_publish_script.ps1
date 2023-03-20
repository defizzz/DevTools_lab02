dotnet pack PowerCollections\PowerCollections.csproj -c Release

$files = Get-ChildItem PowerCollections\bin\Release\*.nupkg | Sort-Object LastWriteTime
$package = $files[-1].fullname

dotnet nuget push $package --api-key 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 --source "github_defizzz" --skip-duplicate