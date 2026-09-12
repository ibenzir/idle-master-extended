<p align="center">
  <img src="src/SteamTradeCardDropper/icon.ico" width="80" alt="Steam Trade Card Dropper Logo" />
  <h1 align="center">Steam Trade Card Dropper</h1>
  <p align="center">
    <strong>Fast, automated Steam Trading Card drops — without downloading or launching games.</strong>
  </p>
  <p align="center">
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Author-benzir-blue.svg?style=flat-square" alt="Author"></a>
    <a href="https://ibenzir.me"><img src="https://img.shields.io/badge/Website-ibenzir.me-informational.svg?style=flat-square" alt="Website"></a>
    <a href="https://github.com/ibenzir/steam-trade-card-dropper/actions/workflows/build.yml"><img src="https://github.com/ibenzir/steam-trade-card-dropper/actions/workflows/build.yml/badge.svg" alt="Build Status"></a>
    <img src="https://img.shields.io/badge/.NET_Framework-v4.8-512BD4.svg?style=flat-square" alt=".NET Framework 4.8">
    <a href="https://github.com/ibenzir/steam-trade-card-dropper/releases/latest"><img src="https://img.shields.io/github/v/release/ibenzir/steam-trade-card-dropper?style=flat-square&color=blue" alt="Latest Release"></a>
    <a href="https://github.com/ibenzir/steam-trade-card-dropper/releases/latest"><img src="https://img.shields.io/badge/Download-.EXE_Package-success?style=flat-square&logo=windows" alt="Download .EXE Package"></a>
    <a href="LICENSE"><img src="https://img.shields.io/badge/License-GPL--2.0-green.svg?style=flat-square" alt="License: GPL-2.0"></a>
  </p>
</p>

---

## 📌 About This Project

**Steam Trade Card Dropper** is a high-performance Windows desktop application engineered to streamline and automate the collection of [Steam Trading Cards](https://steamcommunity.com/tradingcards/).

Instead of downloading gigabytes of game assets or consuming hardware resources by launching full game clients, Steam Trade Card Dropper communicates directly and securely with your running local Steam desktop client via the official `Steamworks API`. By simulating active playtime through a lightweight, sandboxed background worker, it effortlessly unlocks eligible card drops while keeping resource usage close to zero.

Designed and built by **[benzir](https://ibenzir.me)**, the application features a modern, adaptive UI that responds to Windows system theming, robust cookie-based authentication, comprehensive badge scraping, and a clean, streamlined build pipeline.

---

## ✨ Features & Capabilities

- ⚡ **Zero-Resource Idling**: Simulates game presence through an isolated background worker — no game files, downloads, or disk space required.
- 🎯 **Smart Badge Detection**: Automatically parses your Steam Community badge progress to accurately identify all games with remaining card drops.
- 🔄 **Adaptive Idling Modes**:
  - **Sequential (One-by-One)**: Idles one game at a time until all drops are exhausted before moving to the next.
  - **Simultaneous (Fast Mode)**: Idles multiple games concurrently up to the 2-hour threshold to unlock initial drops rapidly.
  - **Prioritized Queuing**: Sort by remaining drops, card market value, or game library order.
- 🎨 **System-Adaptive Dynamic Theming**: Automatically inherits the Windows OS color mode (Dark or Light) across the entire application — dashboard, Settings, Whitelist, Blacklist, Statistics, About, and Authentication dialogs. No manual toggle required.
- 🛡️ **Whitelist & Blacklist Controls**: Protect specific games you prefer not to idle, such as VAC-secured titles or games where you track strict playtime.
- 🔐 **Privacy-First Local Operation**: Operates 100% locally with direct HTTPS requests to official Steam servers; zero telemetry and zero external server dependencies.
- 💤 **Power Management**: Prevents system sleep during active idling and can optionally shut down Windows when all card drops are complete.

---

## 🚀 Getting Started

### Prerequisites

1. **Microsoft Windows** (Windows 10 / 11 recommended).
2. **Steam Desktop Client** installed, running, and logged into your account.
3. **[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)** runtime.

---

### Setup & Authentication

Steam Trade Card Dropper needs to read your badge data from Steam Community. Because Steam enforces modern session security, manual cookie authentication is the most reliable method:

1. Launch **Steam Trade Card Dropper**.
2. Go to **File** > **Settings** > **Lock Icon (Authentication Data)**.
3. Open your web browser (Chrome, Edge, Firefox, Brave) and navigate to [Steam Community](https://steamcommunity.com).
4. Make sure you are signed in, then press <kbd>F12</kbd> (or right-click > **Inspect**) to open Developer Tools.
5. Go to the **Application** (or **Storage** in Firefox) tab.
6. Expand **Cookies** on the left panel and select `https://steamcommunity.com`.
7. Locate and copy the following cookie values into Steam Trade Card Dropper:
   - `sessionid`: 24-character alphanumeric string.
   - `steamLoginSecure`: 64+ character token starting with your Steam ID.
   - `steamparental` *(optional)*: only if Family View is enabled on your account.
8. Click **Update**. The app will validate your session and begin scanning your badges.

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
|                Steam Trade Card Dropper                     |
|                                                             |
|  [frmMain] <-------- WebClient (Cookies) -------> Steam Web |
|  - Badge Scraping                                           |
|  - Queue Management                                         |
|  - Idling Coordinator                                       |
|                                                             |
|         | Spawns with AppId argument (-idle=<appid>)        |
|         v                                                   |
|  [FormCardDropper worker] (Integrated subprocess)           |
|  - Invokes SteamAPI.Init()                                  |
|  - Notifies Steam Client that AppId is active               |
+-------------------------------------------------------------+
```

---

## 📁 Repository Structure

```text
steam-trade-card-dropper/
├── .github/
│   ├── ISSUE_TEMPLATE/           # Bug report & feature request templates
│   └── workflows/                # GitHub Actions CI build & CodeQL pipelines
├── buildtools/                   # Self-contained Assembly Linker (al.exe) compiler shim
├── dependencies/                 # Native & managed libraries (Steamworks.NET, steam_api64, HtmlAgilityPack)
├── src/
│   └── SteamTradeCardDropper/    # Application source, background worker & UI assets
│       └── Properties/           # App manifests, branding & assembly info
├── SteamTradeCardDropper.sln     # Unified Visual Studio solution
├── LEGAL.md                      # Comprehensive legal, safety & security notice
├── LICENSE                       # GNU General Public License v2.0
└── README.md                     # Complete project documentation & guide
```

---

## 🛠️ Building from Source

The project uses standard MSBuild targets for the .NET Framework 4.8 WinForms stack and compiles cleanly in Visual Studio 2019 or later. A custom post-build step automatically copies the required `steam_api64.dll` to the output directory.

### Build with MSBuild (Command Line)

```powershell
# Run from repository root
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "SteamTradeCardDropper.sln" /p:Configuration=Release
```

Or with the Visual Studio Developer Command Prompt:

```cmd
msbuild SteamTradeCardDropper.sln /p:Configuration=Release
```

The compiled binary and all dependencies will be output to:
`src\SteamTradeCardDropper\bin\Release\`

---

## 🔒 Security, Privacy & Authentication FAQ

- **How does authentication work? Is this session hijacking?**  
  **No.** In cybersecurity and law, *session hijacking* refers to unauthorized interception or theft of another user's credentials without their consent. Steam Trade Card Dropper operates entirely on your personal computer: you manually supply your *own* active session cookies (`sessionid` and `steamLoginSecure`) to allow this open-source utility to read your personal badge progress.  
  - **100% Local Execution**: All HTTP requests go directly between your computer and official Steam endpoints (`https://steamcommunity.com`) over encrypted TLS.
  - **Zero Telemetry / Zero Proxying**: Your cookies, credentials, Steam ID, and inventory data are **never** logged remotely, sent to the developer, or shared with third parties.
- **Can I revoke my session cookies at any time?**  
  **Yes, immediately.** Log out of Steam in your browser, visit Steam Guard Settings and click **"Deauthorize all other devices"**, or change your account password. Any of these actions immediately invalidates all active session cookies on Valve's servers.
- **Is Steam Trade Card Dropper safe? Can I get VAC banned?**  
  Steam Trade Card Dropper uses the official `Steamworks API` (via `Steamworks.NET`) to notify the running Steam client that an AppID is open. It does **not** inject code or modify game binaries. As a precaution, **never idle VAC-secured games** (e.g., CS2, TF2, Rust) while connected to VAC servers. Use the built-in **Blacklist** to exclude any competitive or VAC-secured titles.

---

## ⚖️ Legal Disclaimer & Terms of Use

> [!WARNING]
> **Valve Corporation & Steam Non-Affiliation**:  
> Steam Trade Card Dropper is an independent, open-source utility and is **not** affiliated with, authorized, maintained, sponsored, or endorsed by **Valve Corporation**, **Steam**, or any of their affiliates. Valve, Steam, and their respective logos and marks are trademarks and/or registered trademarks of Valve Corporation.
> 
> **Limitation of Liability**:  
> Use of this software is at your own sole risk and discretion. Interacting with Steam services via automated tools may be subject to the [Steam Subscriber Agreement (SSA)](https://store.steampowered.com/subscriber_agreement/). Under no circumstances shall the developer (**benzir**) or open-source contributors be held liable for any account restrictions, community bans, VAC flags, inventory loss, or damages resulting from the use of this software. For complete details, see [**LEGAL.md**](LEGAL.md).

> [!NOTE]
> **Windows SmartScreen Notice**:  
> If Windows displays *"Windows protected your PC"* on initial launch, click **More info** > **Run anyway**. As an independent open-source project distributed without an enterprise code-signing certificate, this is standard Windows behavior for newly downloaded binaries. An official open-source Terms of Use dialog will appear on first launch.

---

## 👤 Author & Developer

- **Developer**: **Benzir Ahammed Shawon**
- **Personal Website / Portfolio**: [https://ibenzir.me](https://ibenzir.me)

---

## 📜 Credits & License

- Built with:
  - [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) and [CSteamworks](https://github.com/rlabrecque/CSteamworks) by Riley Labrecque.
  - [HtmlAgilityPack](https://html-agility-pack.net/) for robust HTML parsing.
  - [Open Iconic](https://github.com/iconic/open-iconic) icon suite.

This project is licensed under the **[GNU General Public License v2.0 (GPL-2.0)](LICENSE)**.
