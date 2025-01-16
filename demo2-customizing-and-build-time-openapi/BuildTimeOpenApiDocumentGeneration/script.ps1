$ErrorActionPreference = "Stop"

dotnet build

cat bin/Debug/net9.0/BuildTimeOpenApiDocumentGeneration.json
