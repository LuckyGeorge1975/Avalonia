//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia.Browser
{
    public partial class AvaloniaView : Avalonia.Input.TextInput.ITextInputMethodImpl
    {
        public AvaloniaView(System.Runtime.InteropServices.JavaScript.JSObject host) { }
        public AvaloniaView(string divId) { }
        public Avalonia.Controls.Control? Content { get { throw null; } set { } }
        public bool IsComposing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.Reset() { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetClient(Avalonia.Input.TextInput.ITextInputMethodClient? client) { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetCursorRect(Avalonia.Rect rect) { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetOptions(Avalonia.Input.TextInput.TextInputOptions options) { }
        public bool OnDragEvent(System.Runtime.InteropServices.JavaScript.JSObject args) { throw null; }
    }
    public static partial class BrowserAppBuilder
    {
        public static System.Threading.Tasks.Task SetupBrowserAppAsync(this Avalonia.AppBuilder builder, Avalonia.Browser.BrowserPlatformOptions? options = null) { throw null; }
        public static System.Threading.Tasks.Task StartBrowserAppAsync(this Avalonia.AppBuilder builder, string mainDivId, Avalonia.Browser.BrowserPlatformOptions? options = null) { throw null; }
        public static Avalonia.AppBuilder UseBrowser(this Avalonia.AppBuilder builder) { throw null; }
    }
    public partial class BrowserPlatformOptions
    {
        public BrowserPlatformOptions() { }
        public string? AvaloniaServiceWorkerScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Func<string, string>? FrameworkAssetPathResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool PreferFileDialogPolyfill { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool RegisterAvaloniaServiceWorker { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    public partial class JSObjectControlHandle : Avalonia.Controls.Platform.INativeControlHostDestroyableControlHandle, Avalonia.Platform.IPlatformHandle
    {
        public JSObjectControlHandle(System.Runtime.InteropServices.JavaScript.JSObject reference) { }
        public System.IntPtr Handle { get { throw null; } }
        public string? HandleDescriptor { get { throw null; } }
        public System.Runtime.InteropServices.JavaScript.JSObject Object { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public void Destroy() { }
    }
}