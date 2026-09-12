<p align="center">
  <img src="Source/IdleMasterExtended/logo1.ico" width="80" alt="Idle Master Extended Logo" />
  <h1 align="center">Idle Master Extended</h1>
  <p align="center">
    <strong>Fast, automated Steam Trading Card drops — without downloading or launching games.</strong>
  </p>
  <p align="center">
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Maintainer-Benzir_Ahammed_Shawon-blue.svg?style=flat-square" alt="Maintainer"></a>
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Website-ibenzir.me-informational.svg?style=flat-square" alt="Website"></a>
    <img src="https://img.shields.io/badge/.NET_Framework-v4.8-512BD4.svg?style=flat-square" alt=".NET Framework 4.8">
    <img src="https://img.shields.io/badge/Platform-Windows-0078D6.svg?style=flat-square" alt="Platform: Windows">
    <a href="LICENSE"><img src="https://img.shields.io/badge/License-GPL--2.0-green.svg?style=flat-square" alt="License: GPL-2.0"></a>
  </p>
</p>

---

## 📌 About This Project

**Idle Master Extended** is a lightweight Windows utility that automates the collection of [Steam Trading Cards](https://steamcommunity.com/tradingcards/).

Instead of downloading gigabytes of game assets and running resource-heavy game executables, Idle Master Extended communicates directly with the running Steam client via the `Steamworks API` to simulate playing games with remaining card drops.

This repository is a revitalized and actively maintained edition curated by **[Benzir Ahammed Shawon](https://ibenzir.me)**, featuring modernized build toolchains, compiler compatibility enhancements, and improved documentation.

---

## ✨ Features

- ⚡ **Zero Installation Idling**: Simulates game execution via a lightweight stub (`steam-idle.exe`) without needing game files installed.
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

## 🛠️ Building from Source

This project includes custom compiler adapters and a built-in assembly linker shim (`buildtools/al.exe`), allowing it to build immediately on any Windows installation without needing the heavy Windows SDK.

### Build with MSBuild (Command Line)

Run from PowerShell or Command Prompt:

```powershell
# 1. Build the lightweight game idler stub
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "steam-idle Source\steam-idle.sln" /p:Configuration=Release

# 2. Build the main application (with built-in AL shim)
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "Source\IdleMasterExtended.sln" /p:Configuration=Release /p:AlToolPath="$(Get-Location)\buildtools\"
```

The compiled binaries will be output to:
`Source\IdleMasterExtended\bin\Release\`

---

## 🔒 Security & Privacy FAQ

- **Is Idle Master Extended safe? Can I get VAC banned?**  
  Idle Master Extended uses `Steamworks.NET` to register simulated playtime. It does not inject memory or modify game binaries. However, as a precaution, it is strongly recommended not to idle VAC-secured games (such as CS2 or TF2) while connected to VAC servers, or you can simply add them to the built-in Blacklist.
- **Where are credentials stored?**  
  Your session cookies (`sessionid`, `steamLoginSecure`) are stored locally on your machine in standard Windows user settings `%LOCALAPPDATA%`. No account credentials or passwords are ever transmitted to any third party.

---

## 👤 Maintainer & Credentials

- **Current Maintainer**: **Benzir Ahammed Shawon**
- **Personal Website / Portfolio**: [https://ibenzir.me](https://ibenzir.me)
- **Email**: `benzir1116@gmail.com`

---

## 📜 Credits & License

- **Idle Master** was originally created by **[jshackles](https://github.com/jshackles)**, based on code by **Stumpokapow**.
- **Idle Master Extended** was formerly maintained by **[JonasNilson](https://github.com/JonasNilson)** (archived 2023).
- Built with:
  - [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) and [CSteamworks](https://github.com/rlabrecque/CSteamworks) by Riley Labrecque.
  - [HtmlAgilityPack](https://html-agility-pack.net/) for robust HTML parsing.
  - [Open Iconic](https://github.com/iconic/open-iconic) icon suite.

This project is licensed under the **[GNU General Public License v2.0 (GPL-2.0)](LICENSE)**. All existing copyright notices, open-source licenses, and historical attributions are maintained in full accordance with the GNU General Public License.
