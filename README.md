## SharpHandle
### Description
A library for retrieving the handle of either a specific window, or just the currently focused window.

### How To Use
```csharp
// If you're getting the currently selected window handle.
IntPtr ForegroundWindow_Handle = HandleGetter.GetFocusedWindowHandle();

// If you're getting a specifiic window based on its title.
// Replace '<WindowTitle>' with the title of the window you're trying to get the handle of/from.
IntPtr SpecificWindow_Handle = HandleGetter.GetWindowHandle("<WindowTitle>");
```

### Download
[SharpHandle.dll](https://github.com/Lexz-08/SharpHandle/releases/download/sharphandle/SharpHandle.dll)
