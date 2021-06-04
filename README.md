# File Compare Demo
Set of projects showcasing how to compare files manually and in automated way.

Please see test-diff and git-diff directories for more details.

## git diff A B
Please see git-diff subdirectory

## Automated through xunit tests
Please see test-diff directory

# Prerequisites

## Git CLI
https://git-scm.com/downloads

## Dotnet Core SDK
https://dotnet.microsoft.com/download

## Git setup

git sidestep self signed certificate validation
```
git config --global http.sslVerify false
```

## Clone

Run command line or powershell as administrator
```
cd {your repo root}
Git clone https://github.com/potocnik/file-compare
```

## Build
```
cd test-diff
dotnet build
```

## Test
```
dotnet test
```

## Test continously
```
dotnet watch --project "Demo.Test.Integration\Demo.Test.Integration.csproj" test
```

