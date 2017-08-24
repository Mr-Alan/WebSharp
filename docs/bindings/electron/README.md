# Electron Bindings

## Guide

- :running: - Bindings exist but may be missing some functionality.
- :muscle: - All known functionality bound.  _Experimental_ is not counted.
- :exclamation: - No bindings.

### Modules for the Main Process:

* [app](api/app.md) :running:
* [autoUpdater](api/auto-updater.md) :exclamation:
* [BrowserWindow](api/browser-window.md) :muscle:
* [contentTracing](api/content-tracing.md) :exclamation:
* [download-item](api/download-item.md) :muscle:
* [dialog](api/dialog.md) :muscle:
* [globalShortcut](api/global-shortcut.md) :muscle:
* [ipcMain](api/ipc-main.md) :muscle:
* [Menu](api/menu.md) :muscle:
* [MenuItem](api/menu-item.md) :muscle:
* [net](api/net.md) :exclamation:
* [powerMonitor](api/power-monitor.md) :muscle:
* [powerSaveBlocker](api/power-save-blocker.md) :muscle:
* [protocol](api/protocol.md) :exclamation:
* [session](api/session.md) :running:
* [systemPreferences](api/system-preferences.md) :exclamation:
* [Tray](api/tray.md) :muscle:
* [webContents](api/web-contents.md) :running:
* [webRequest](api/web-request.md) :muscle:

### Modules for the Renderer Process (Web Page):

* [desktopCapturer](api/desktop-capturer.md)  :muscle:
* [ipcRenderer](api/ipc-renderer.md) :muscle:
* [remote](api/remote.md) :running:
* [webFrame](api/web-frame.md) :exclamation:

### Modules for Both Processes:

* [clipboard](api/clipboard.md) :muscle:
* [crashReporter](api/crash-reporter.md) :muscle:
* [nativeImage](api/native-image.md) :muscle:
* [screen](api/screen.md) :muscle:
* [shell](api/shell.md) :muscle:
