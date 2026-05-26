# Ensure files in UI are writable and not corrupted by readonly attribute.
# Run from repository root.
$files = Get-ChildItem -Path .\UI -Recurse -Include *.resx,*.Designer.cs,*.cs -ErrorAction SilentlyContinue
foreach ($f in $files) {
    try {
        # remove readonly attribute
        if ($f.Attributes -band [System.IO.FileAttributes]::ReadOnly) {
            attrib -r $f.FullName
        }
        # try to unblock file
        if (Get-Command Unblock-File -ErrorAction SilentlyContinue) {
            Unblock-File -Path $f.FullName
        }
    } catch {
        Write-Host "Warning: cannot change attributes for $($f.FullName): $_"
    }
}
Write-Host "Permissions fixed (read-only removed where present)."
Write-Host "Next: open solution in Visual Studio and Rebuild. If merge UI shows 'Accept All' disabled, resolve remaining build errors first."