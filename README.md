# SecSearch

VB.NET WinForms scanner that walks a path for `*.doc` files, opens Word, reads section headers, and classifies documents from Restricted through Top Secret. A matching Windows service stub (`Service1`) sits in the same Visual Studio 2003 solution. Sample Word documents and GIF icons at the repo root are dummy header markings for the demo, not real classified material. Alert email From/To and SMTP host in `Personal/frmMain.vb` were replaced with `example@example.com` and `smtp.example.com`.

**Source last updated:** 2005-09-12  
**Language:** VB.NET  
**Target:** Visual Studio 2003 (solution format 8.00)  
**Output:** WinExe + Windows service stub

## How to open

Open `SecSearch.sln` in Visual Studio.

## License

MIT License. Copyright (c) 2026 VaderConsulting. See `LICENSE`.
