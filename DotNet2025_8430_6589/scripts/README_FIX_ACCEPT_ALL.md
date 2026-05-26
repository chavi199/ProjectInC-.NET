Steps to fix "Accept All" unclickable / build errors:

1. Run the helper script to ensure UI files are writable:
   - Open PowerShell in repository root.
   - Execute: .\scripts\fix_file_permissions.ps1

2. In Visual Studio:
   - Close modal dialogs.
   - Reload the solution (right-click solution -> Reload).
   - Clean solution, then Rebuild.

3. If build still fails:
   - Inspect build errors. The most common causes are:
     a) Broken .resx files (fixed by replacing with valid XML in UI/*.resx).
     b) Designer.cs with stray characters (open file and ensure file begins with 'namespace UI').
     c) Missing event handlers referenced in Designer.cs (implement them in the corresponding .cs file).
   - Fix the remaining errors, then Rebuild.

4. If the merge/accept dialog is still disabled:
   - Use command-line git to complete the merge:
     git add -A
     git commit -m "Resolve merge and fix UI resx/designer issues"
   - Then reopen IDE.

Notes:
- The script only removes read-only flags and unblocks files. It does not modify code.
- After these steps, the 'Invalid Resx file. Root element is missing' errors should be resolved.