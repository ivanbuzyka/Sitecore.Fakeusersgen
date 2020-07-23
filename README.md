# Sitecore.Fakeusersgen
App for Generating CSV contact lists for Sitecore EXM (Email Experience Manager)

## Quick start
- Build the project using VS Code
- Run fakeusersgen.exe with 1 parameter (which is csv file name). CSV file will be created in the same folder as fakeusersgen.exe

Example:
```fakeusersgen.exe 50users.csv```

## Limitations
- Currently it is hardcoded to generate csv file with 50 contacts.
- Email addresses are not logically bound to First and Last Names. It can be improved later.
