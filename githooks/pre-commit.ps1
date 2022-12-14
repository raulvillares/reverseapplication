if (dotnet test --filter FullyQualifiedName\~UnitTests | Out-String) {
  exit 0
} else {
  Write-Error "Tests failed. Push blocked."
  exit 1
}
