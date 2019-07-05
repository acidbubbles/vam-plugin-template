Param (
    [Parameter(Mandatory = $true)][string]$Version
)

New-Item -ItemType Directory -Force -Path ./publish | Out-Null

Get-ChildItem src/*.cs | ForEach-Object {
    $Code = Get-Content -Path $_ -Raw
    $Code = $Code -Replace "#define VAM_DIAGNOSTICS\r\n", ""
    $Code = $Code -Replace "(?ms)^\s*#if ?\(VAM_DIAGNOSTICS\).+?#endif", ""
    $Code = $Code -Replace "\r\n\r\n\r\n", "`r`n`r`n"
    $Code = $Code -Replace "0\.0\.0", "$Version"
    $Code | Set-Content -Path ./publish/$($_.Name)
}

Write-Host "Release available at ./publish"