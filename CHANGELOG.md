# Changelog

All notable changes to **Steam Trade Card Dropper** are documented here.  
Releases follow [Semantic Versioning](https://semver.org/).

---

## [v2.0.0] — 2026-09-13

### Added
- **System-Adaptive Theming** — the application now automatically inherits the Windows OS color mode (Dark / Light) across every screen: main dashboard, Settings, Whitelist, Blacklist, Statistics, About, and the Authentication dialog. No manual toggle exists or is needed; switching Windows between light and dark mode is reflected instantly.
- **Modern UI across all dialogs** — Settings, Whitelist, Blacklist, Statistics, About, and the Authentication screen were rebuilt with the same design language as the main dashboard: card-style panels, an accent header with an icon and subtitle, smooth typography, and proper light/dark color tokens.
- **ThemeManager** — a centralized, registry-based theme engine that provides consistent color tokens, font definitions, and control-styling helpers across all forms.
- **Pixelated icon fix** — navigation and dialog icons are now sourced at 2× resolution and selected per-theme (white variants for dark mode, standard for light mode).

### Changed
- All UI label text is now hardcoded in English directly in the application logic, replacing the previous resource-file approach for a simpler, more reliable codebase.
- The green "connected" status color is now derived programmatically from the active theme rather than being a stored user setting.
- The ListView background and foreground colors now use `ThemeManager` tokens for consistent dark/light rendering.

### Removed
- **Language selection system** — the entire multi-language localization infrastructure has been removed, including all satellite `.resx` files and the language selector in Settings. The application runs in English.
- **Manual dark mode toggle** — the "Dark Theme" checkbox in Settings has been removed. Theme is always inherited from the Windows OS setting.
- **Legacy manual theme color settings** — `customTheme`, `colorBgd`, `colorTxt`, `whiteIcons`, `colorBgdOriginal`, `colorTxtOriginal`, `colorSteamGreen`, and `language` settings have been fully purged from `Settings.Designer.cs`, `Settings.settings`, and `app.config`.

---

## [v1.11.0] — 2025-08-01

### Added
- Sidebar navigation with icon buttons for Dashboard, Settings, Whitelist, Blacklist, Statistics, EULA, About, and Exit.
- EULA acceptance screen on first launch.
- Empty state panel with contextual status messages when no games are idling.
- Dynamic version label in the sidebar bound to the compiled assembly version.
- Signed-in username display in the sidebar header.

### Changed
- Upgraded to .NET Framework 4.8.
- Refactored badge loading to fully async/await patterns.
- Improved badge page pagination handling for large game libraries.

### Fixed
- Progress bar maximum recalculation when card drops change mid-session.
- Cookie reset flow now correctly clears all stored session fields.

---

## [v1.10.x] — Legacy

Initial public release series. Core idling engine, one-by-one and fast-mode idling, badge scraping via HtmlAgilityPack, whitelist/blacklist management, and basic settings UI.
