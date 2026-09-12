# Legal Notice, Security Warning & Disclaimer of Liability

**Please read this document carefully before downloading, compiling, or using Idle Master Extended.**

---

## 1. Non-Affiliation & Trademark Notice

- **Idle Master Extended** is an independent, open-source utility created and maintained for educational, personal efficiency, and interoperability purposes.
- **Valve Corporation**, **Steam**, the Steam logo, the Valve logo, and all associated logos, marks, trade dress, and game titles are trademarks and/or registered trademarks of **Valve Corporation** in the United States and other countries.
- **Idle Master Extended** and its maintainer (**BENZIR**) and open-source contributors are **NOT** affiliated with, authorized by, sponsored by, maintained by, or endorsed by Valve Corporation or any of its subsidiaries or affiliates.

---

## 2. Terms of Service & Steam Subscriber Agreement (SSA)

- Automated or scripted interactions with the Steam network and Steam Community may be subject to the terms and restrictions set forth in the [Steam Subscriber Agreement (SSA)](https://store.steampowered.com/subscriber_agreement/) and Valve's [Online Conduct Guidelines](https://store.steampowered.com/online_conduct/).
- While Idle Master Extended coordinates with the running Steam desktop client to simulate game execution and inspects badge drop counters, Valve Corporation reserves the right to manage access to its services.
- The use of third-party tools to interact with Steam services is conducted **strictly at your own risk and discretion**.
- You alone are responsible for reviewing and complying with all applicable agreements, community rules, and local laws.

---

## 3. Session Authentication & Security Advisory

### How Authentication Works
To read badge progression, game lists, and remaining card drops, Idle Master Extended requires authenticated read access to your personal Steam badge pages (`https://steamcommunity.com/my/badges/`). Because Steam enforces session protection on badge pages, the application accepts user-supplied session cookies (`sessionid` and `steamLoginSecure`).

### Clarification on Session Security & Hijacking Concerns
- **No Unauthorized Interception**: In cybersecurity and legal terminology, *session hijacking* refers to an unauthorized third-party stealing, intercepting, or sniffing an unwitting victim's tokens. Idle Master Extended **does not** intercept network traffic, tamper with your web browser, or access credentials without your explicit action.
- **Self-Supplied Local Authentication**: You manually copy and provide your own session cookies on your own personal computer into a local, open-source application.
- **100% Local Client Execution**: The software operates entirely on your local machine. It communicates **exclusively and directly** with official Steam servers (`steamcommunity.com` via encrypted HTTPS) and your local running Steam client via official Steamworks IPC.
- **Zero Telemetry / No Remote Transmission**: Under no circumstances are your cookies, passwords, Steam ID, trade information, or personal data ever logged remotely, forwarded, proxied, or transmitted to the maintainer or any third-party server. The full source code is public and auditable.

### Security Best Practices for Users
1. **Never Share Session Cookies**: Your session tokens provide active web access to your Steam Community profile. Never paste or share these values on untrusted websites or with third parties.
2. **Instant Session Revocation**: You can immediately invalidate any session cookies used by Idle Master Extended at any time by:
   - Logging out of Steam in your web browser, OR
   - Visiting Steam Guard settings and selecting **"Deauthorize all other devices"**, OR
   - Changing your Steam account password.  
   Any of these actions immediately revokes all active session tokens on Valve's authentication servers.

---

## 4. Anti-Cheat & VAC (Valve Anti-Cheat) Policy

- Idle Master Extended uses the official `Steamworks API` (via `Steamworks.NET`) to notify the running Steam client that an AppID is active.
- Idle Master Extended **does NOT** inject code into game processes, modify game binaries, hook memory, or tamper with anti-cheat software.
- **Important Safety Warning**: You should **NEVER idle VAC-secured games** (e.g., *Counter-Strike 2*, *Team Fortress 2*, *Rust*, *Dota 2*) while actively connected to VAC-secured game servers.
- Use the built-in **Blacklist** feature in Idle Master Extended to exclude any VAC-protected games, multiplayer games, or titles where you track strict playtime metrics.

---

## 5. Disclaimer of Warranty & Limitation of Liability

**THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS, MAINTAINERS, AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, TITLE, AND NON-INFRINGEMENT ARE DISCLAIMED.**

**IN NO EVENT SHALL BENZIR, ITS AUTHORS, MAINTAINERS, OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, TRADING CARDS, INVENTORY ITEMS, REVENUE, OR PROFITS; ACCOUNT SUSPENSIONS, COMMUNITY BANS, VAC BANS, TRADE RESTRICTIONS, OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.**

BY DOWNLOADING, COMPILING, OR USING THIS SOFTWARE, YOU EXPLICITLY ACKNOWLEDGE AND AGREE TO THESE TERMS AND ASSUME FULL RESPONSIBILITY FOR YOUR STEAM ACCOUNT.
