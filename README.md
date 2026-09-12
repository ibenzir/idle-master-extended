<p align="center">
  <img src="src/IdleMasterExtended/icon.ico" width="80" alt="Idle Master Extended Logo" />
  <h1 align="center">Idle Master Extended</h1>
  <p align="center">
    <strong>Fast, automated Steam Trading Card drops — without downloading or launching games.</strong>
  </p>
  <p align="center">
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Maintainer-benzir-blue.svg?style=flat-square" alt="Maintainer"></a>
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Website-ibenzir.me-informational.svg?style=flat-square" alt="Website"></a>
    <a href="https://github.com/ibenzir/idle-master-extended/actions/workflows/build.yml"><img src="https://github.com/ibenzir/idle-master-extended/actions/workflows/build.yml/badge.svg" alt="Build Status"></a>
    <img src="https://img.shields.io/badge/.NET_Framework-v4.8-512BD4.svg?style=flat-square" alt=".NET Framework 4.8">
    <a href="https://github.com/ibenzir/idle-master-extended/releases/latest"><img src="https://img.shields.io/github/v/release/ibenzir/idle-master-extended?style=flat-square&color=blue" alt="Latest Release"></a>
    <a href="https://github.com/ibenzir/idle-master-extended/releases/latest"><img src="https://img.shields.io/badge/Download-.EXE_Package-success?style=flat-square&logo=windows" alt="Download .EXE Package"></a>
    <a href="LICENSE"><img src="https://img.shields.io/badge/License-GPL--2.0-green.svg?style=flat-square" alt="License: GPL-2.0"></a>
  </p>
</p>

---

## 📌 About This Project

**Idle Master Extended** is a lightweight Windows utility that automates the collection of [Steam Trading Cards](https://steamcommunity.com/tradingcards/).

Instead of downloading gigabytes of game assets and running resource-heavy game executables, Idle Master Extended communicates directly with the running Steam client via the `Steamworks API` to simulate playing games with remaining card drops.

This repository is an actively maintained edition curated by **[benzir](https://ibenzir.me)**, featuring modernized build toolchains, compiler compatibility enhancements, and improved documentation.

---

## ✨ Features

- ⚡ **Zero Installation Idling**: Simulates game execution seamlessly through an integrated background worker without needing game files installed.
- 🎯 **Smart Badge Detection**: Automatically parses your Steam badge page to identify which games have card drops remaining.
- 🔄 **Multiple Idling Strategies**:
  - **Sequential (One-by-One)**: Idles one game until all drops are exhausted before moving to the next.
  - **Simultaneous (Fast Mode)**: Idles games simultaneously up to the 2-hour threshold to unlock initial card drops rapidly.
  - **Prioritized**: Sort by highest number of remaining drops, card value, or badge status.
- 🛡️ **Whitelist & Blacklist Controls**: Protect games you prefer not to idle (e.g., VAC-secured titles or games where you track strict playtime).
- 🌙 **Modern Custom Theming**: Support for dark mode, custom color schemes, and high-contrast icons.
- 💤 **Power Management**: Prevents system sleep during active idling and can optionally shut down Windows when all card drops finish.
- 🌐 **Multilingual Support**: Fully localized with support for over 24 languages.

---

## 🚀 Getting Started

### Prerequisites

1. **Microsoft Windows** (Windows 10 / 11 recommended).
2. **Steam Desktop Client** installed, running, and logged into your account.
3. **[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)** runtime.

---

### Setup & Authentication

Idle Master Extended needs to read your badge data from Steam Community. Because Steam enforces modern session security, manual cookie authentication is the most reliable method:

1. Launch **Idle Master Extended**.
2. Go to **File** > **Settings** > **Lock Icon (Authentication Data)**.
3. Open your web browser (Chrome, Edge, Firefox, Brave) and navigate to [Steam Community](https://steamcommunity.com).
4. Make sure you are signed in, then press <kbd>F12</kbd> (or right-click > **Inspect**) to open Developer Tools.
5. Go to the **Application** (or **Storage** in Firefox) tab.
6. Expand **Cookies** on the left panel and select `https://steamcommunity.com`.
7. Locate and copy the following cookie values into Idle Master Extended:
   - `sessionid`: 24-character alphanumeric string.
   - `steamLoginSecure`: 64+ character token starting with your Steam ID.
   - `steamparental` *(optional)*: only if Family View is enabled on your account.
8. Click **Update**. The app will validate your session and begin scanning your badges!

---

## 🏗️ Architecture Overview

```
+-------------------------------------------------------------+
|                   Steam Desktop Client                      |
|                  (Must be open & running)                   |
+------------------------------+------------------------------+
                               |
                   Local Steamworks IPC
                               |
                               v
+------------------------------+------------------------------+
|                   Idle Master Extended                      |
|                                                             |
|  [frmMain] <-------- WebClient (Cookies) --------> Steam Web|
|  - Badge Scraping                                           |
|  - Queue Management                                         |
|  - Idling Coordinator                                       |
|                                                             |
|         | Spawns with AppId argument                        |
|         v                                                   |
|  [steam-idle.exe] (Lightweight stub)                        |
|  - Invokes SteamAPI.Init()                                  |
|  - Notifies Steam Client that AppId is active               |
+-------------------------------------------------------------+
```

---

## 📁 Repository Structure

```text
idle-master-extended/
├── .github/
│   ├── ISSUE_TEMPLATE/       # Bug report & feature request templates
│   └── workflows/            # GitHub Actions CI build & CodeQL pipelines
├── buildtools/               # Self-contained Assembly Linker (al.exe) compiler shim
├── Dependencies/             # Native & managed libraries (Steamworks.NET, steam_api64, HtmlAgilityPack)
├── src/
│   ├── IdleMasterExtended/   # Main Windows Forms application source & UI assets
│   │   ├── localization/     # 24 localized satellite resource translations
│   │   └── Properties/       # App manifests, branding & assembly info
│   └── steam-idle/           # Lightweight Steamworks app idler stub
├── IdleMasterExtended.sln    # Unified Visual Studio multi-project solution
├── LICENSE                   # GNU General Public License v2.0
└── README.md                 # Complete project documentation & guide
```

---

## 🛠️ Building from Source

This project includes custom compiler adapters and a built-in assembly linker shim (`buildtools/al.exe`), allowing it to compile immediately on standard Windows installations without requiring the full Windows SDK.

### Build with MSBuild (Command Line)

To compile both `steam-idle` and `IdleMasterExtended` in Release mode:

```powershell
# Run from repository root
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "IdleMasterExtended.sln" /p:Configuration=Release
```

Or simply with Visual Studio Developer Command Prompt:

```cmd
msbuild IdleMasterExtended.sln /p:Configuration=Release
```

The compiled binaries and all dependencies will be output to:
`src\IdleMasterExtended\bin\Release\`

---

## 🔒 Security, Privacy & Authentication FAQ

- **How does authentication work? Is this session hijacking?**  
  **No.** In cybersecurity and law, *session hijacking* refers to unauthorized interception or theft of another user's credentials without their consent. Idle Master Extended operates entirely on your personal computer: you manually supply your *own* active session cookies (`sessionid` and `steamLoginSecure`) to allow this open-source utility to read your personal badge progress.  
  - **100% Local Execution**: All HTTP requests are made directly between your computer and official Steam endpoints (`https://steamcommunity.com`) over encrypted TLS.
  - **Zero Telemetry / Zero Proxying**: Your cookies, credentials, Steam ID, and inventory data are **never** logged remotely, sent to the maintainer, or shared with third parties.
- **Can I revoke my session cookies at any time?**  
  **Yes, immediately.** Simply log out of Steam in your web browser, or navigate to Steam Guard Settings and click **"Deauthorize all other devices"**, or change your account password. This immediately invalidates all active session cookies on Valve's servers.
- **Is Idle Master Extended safe? Can I get VAC banned?**  
  Idle Master Extended uses the official `Steamworks API` (via `Steamworks.NET`) to notify the running Steam client that an AppID is open. It does **not** inject code or modify game binaries. However, as a precaution, **never idle VAC-secured games** (e.g., CS2, TF2, Rust) while actively connected to VAC servers. Use the built-in **Blacklist** to exclude any competitive or VAC-secured games.

---

## ⚖️ Legal Disclaimer & Terms of Use

> [!WARNING]
> **Valve Corporation & Steam Non-Affiliation**:  
> Idle Master Extended is an independent, open-source utility and is **not** affiliated with, authorized, maintained, sponsored, or endorsed by **Valve Corporation**, **Steam**, or any of their affiliates. Valve, Steam, and their respective logos and marks are trademarks and/or registered trademarks of Valve Corporation.
> 
> **Limitation of Liability**:  
> Use of this software is at your own sole risk and discretion. Interacting with Steam services via automated tools may be subject to the [Steam Subscriber Agreement (SSA)](https://store.steampowered.com/subscriber_agreement/). Under no circumstances shall the developer (**benzir**) or open-source contributors be held liable for any account restrictions, community bans, VAC flags, inventory loss, or damages resulting from the use of this software. For complete details, see [**LEGAL.md**](LEGAL.md).

> [!NOTE]
> **Windows SmartScreen Notice**:  
> If Windows displays *"Windows protected your PC"* on initial launch, click **More info** > **Run anyway**. As an independent open-source project distributed without an enterprise code-signing certificate, this is standard Windows behavior for newly downloaded binaries. An official open-source Terms of Use dialog will welcome you upon first launch.

## 👤 Maintainer & Credentials

- **Developer**: **Benzir Ahammed Shawon**
- **Personal Website / Portfolio**: [https://ibenzir.me](https://ibenzir.me)

---

## 📜 Credits & License

- Built with:
  - [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) and [CSteamworks](https://github.com/rlabrecque/CSteamworks) by Riley Labrecque.
  - [HtmlAgilityPack](https://html-agility-pack.net/) for robust HTML parsing.
  - [Open Iconic](https://github.com/iconic/open-iconic) icon suite.

This project is licensed under the **[GNU General Public License v2.0 (GPL-2.0)](LICENSE)**.

