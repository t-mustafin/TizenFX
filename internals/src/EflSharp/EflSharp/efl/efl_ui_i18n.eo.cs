#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>A common Internationalization interface for UI objects.</summary>
[Efl.Ui.II18nConcrete.NativeMethods]
public interface II18n : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Whether this object should be mirrored.
/// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
/// <returns><c>true</c> for RTL, <c>false</c> for LTR (default).</returns>
bool GetMirrored();
    /// <summary>Whether this object should be mirrored.
/// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
/// <param name="rtl"><c>true</c> for RTL, <c>false</c> for LTR (default).</param>
void SetMirrored(bool rtl);
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
/// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
/// 
/// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
/// <returns>Whether the widget uses automatic mirroring</returns>
bool GetMirroredAutomatic();
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
/// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
/// 
/// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
/// <param name="automatic">Whether the widget uses automatic mirroring</param>
void SetMirroredAutomatic(bool automatic);
    /// <summary>Gets the language for this object.</summary>
/// <returns>The current language.</returns>
System.String GetLanguage();
    /// <summary>Sets the language for this object.</summary>
/// <param name="language">The current language.</param>
void SetLanguage(System.String language);
                            /// <summary>Whether this object should be mirrored.
/// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
/// <value><c>true</c> for RTL, <c>false</c> for LTR (default).</value>
    bool Mirrored {
        get ;
        set ;
    }
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
/// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
/// 
/// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
/// <value>Whether the widget uses automatic mirroring</value>
    bool MirroredAutomatic {
        get ;
        set ;
    }
    /// <summary>The (human) language for this object.</summary>
/// <value>The current language.</value>
    System.String Language {
        get ;
        set ;
    }
}
/// <summary>A common Internationalization interface for UI objects.</summary>
sealed public class II18nConcrete : 

II18n
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(II18nConcrete))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle
    {
        get { return handle; }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_ui_i18n_interface_get();
    /// <summary>Initializes a new instance of the <see cref="II18n"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private II18nConcrete(System.IntPtr raw)
    {
        handle = raw;
    }
    ///<summary>Destructor.</summary>
    ~II18nConcrete()
    {
        Dispose(false);
    }

    ///<summary>Releases the underlying native instance.</summary>
    private void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero)
        {
            IntPtr h = handle;
            handle = IntPtr.Zero;

            IntPtr gcHandlePtr = IntPtr.Zero;
            if (disposing)
            {
                Efl.Eo.Globals.efl_mono_native_dispose(h, gcHandlePtr);
            }
            else
            {
                Monitor.Enter(Efl.All.InitLock);
                if (Efl.All.MainLoopInitialized)
                {
                    Efl.Eo.Globals.efl_mono_thread_safe_native_dispose(h, gcHandlePtr);
                }

                Monitor.Exit(Efl.All.InitLock);
            }
        }

    }

    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    /// <summary>Whether this object should be mirrored.
    /// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
    /// <returns><c>true</c> for RTL, <c>false</c> for LTR (default).</returns>
    public bool GetMirrored() {
         var _ret_var = Efl.Ui.II18nConcrete.NativeMethods.efl_ui_mirrored_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Whether this object should be mirrored.
    /// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
    /// <param name="rtl"><c>true</c> for RTL, <c>false</c> for LTR (default).</param>
    public void SetMirrored(bool rtl) {
                                 Efl.Ui.II18nConcrete.NativeMethods.efl_ui_mirrored_set_ptr.Value.Delegate(this.NativeHandle,rtl);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
    /// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
    /// 
    /// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
    /// <returns>Whether the widget uses automatic mirroring</returns>
    public bool GetMirroredAutomatic() {
         var _ret_var = Efl.Ui.II18nConcrete.NativeMethods.efl_ui_mirrored_automatic_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
    /// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
    /// 
    /// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
    /// <param name="automatic">Whether the widget uses automatic mirroring</param>
    public void SetMirroredAutomatic(bool automatic) {
                                 Efl.Ui.II18nConcrete.NativeMethods.efl_ui_mirrored_automatic_set_ptr.Value.Delegate(this.NativeHandle,automatic);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Gets the language for this object.</summary>
    /// <returns>The current language.</returns>
    public System.String GetLanguage() {
         var _ret_var = Efl.Ui.II18nConcrete.NativeMethods.efl_ui_language_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Sets the language for this object.</summary>
    /// <param name="language">The current language.</param>
    public void SetLanguage(System.String language) {
                                 Efl.Ui.II18nConcrete.NativeMethods.efl_ui_language_set_ptr.Value.Delegate(this.NativeHandle,language);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Whether this object should be mirrored.
/// If mirrored, an object is in RTL (right to left) mode instead of LTR (left to right).</summary>
/// <value><c>true</c> for RTL, <c>false</c> for LTR (default).</value>
    public bool Mirrored {
        get { return GetMirrored(); }
        set { SetMirrored(value); }
    }
    /// <summary>Whether the property <see cref="Efl.Ui.II18n.Mirrored"/> should be set automatically.
/// If enabled, the system or application configuration will be used to set the value of <see cref="Efl.Ui.II18n.Mirrored"/>.
/// 
/// This property may be implemented by high-level widgets (in Efl.Ui) but not by low-level widgets (in <see cref="Efl.Canvas.IScene"/>) as the configuration should affect only high-level widgets.</summary>
/// <value>Whether the widget uses automatic mirroring</value>
    public bool MirroredAutomatic {
        get { return GetMirroredAutomatic(); }
        set { SetMirroredAutomatic(value); }
    }
    /// <summary>The (human) language for this object.</summary>
/// <value>The current language.</value>
    public System.String Language {
        get { return GetLanguage(); }
        set { SetLanguage(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.II18nConcrete.efl_ui_i18n_interface_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Efl);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_mirrored_get_static_delegate == null)
            {
                efl_ui_mirrored_get_static_delegate = new efl_ui_mirrored_get_delegate(mirrored_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetMirrored") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_mirrored_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_mirrored_get_static_delegate) });
            }

            if (efl_ui_mirrored_set_static_delegate == null)
            {
                efl_ui_mirrored_set_static_delegate = new efl_ui_mirrored_set_delegate(mirrored_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetMirrored") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_mirrored_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_mirrored_set_static_delegate) });
            }

            if (efl_ui_mirrored_automatic_get_static_delegate == null)
            {
                efl_ui_mirrored_automatic_get_static_delegate = new efl_ui_mirrored_automatic_get_delegate(mirrored_automatic_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetMirroredAutomatic") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_mirrored_automatic_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_mirrored_automatic_get_static_delegate) });
            }

            if (efl_ui_mirrored_automatic_set_static_delegate == null)
            {
                efl_ui_mirrored_automatic_set_static_delegate = new efl_ui_mirrored_automatic_set_delegate(mirrored_automatic_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetMirroredAutomatic") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_mirrored_automatic_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_mirrored_automatic_set_static_delegate) });
            }

            if (efl_ui_language_get_static_delegate == null)
            {
                efl_ui_language_get_static_delegate = new efl_ui_language_get_delegate(language_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLanguage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_language_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_language_get_static_delegate) });
            }

            if (efl_ui_language_set_static_delegate == null)
            {
                efl_ui_language_set_static_delegate = new efl_ui_language_set_delegate(language_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetLanguage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_language_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_language_set_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.II18nConcrete.efl_ui_i18n_interface_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_mirrored_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_mirrored_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_mirrored_get_api_delegate> efl_ui_mirrored_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_mirrored_get_api_delegate>(Module, "efl_ui_mirrored_get");

        private static bool mirrored_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_mirrored_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((II18n)wrapper).GetMirrored();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_mirrored_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_mirrored_get_delegate efl_ui_mirrored_get_static_delegate;

        
        private delegate void efl_ui_mirrored_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool rtl);

        
        public delegate void efl_ui_mirrored_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool rtl);

        public static Efl.Eo.FunctionWrapper<efl_ui_mirrored_set_api_delegate> efl_ui_mirrored_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_mirrored_set_api_delegate>(Module, "efl_ui_mirrored_set");

        private static void mirrored_set(System.IntPtr obj, System.IntPtr pd, bool rtl)
        {
            Eina.Log.Debug("function efl_ui_mirrored_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((II18n)wrapper).SetMirrored(rtl);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_mirrored_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), rtl);
            }
        }

        private static efl_ui_mirrored_set_delegate efl_ui_mirrored_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_mirrored_automatic_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_mirrored_automatic_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_mirrored_automatic_get_api_delegate> efl_ui_mirrored_automatic_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_mirrored_automatic_get_api_delegate>(Module, "efl_ui_mirrored_automatic_get");

        private static bool mirrored_automatic_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_mirrored_automatic_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((II18n)wrapper).GetMirroredAutomatic();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_mirrored_automatic_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_mirrored_automatic_get_delegate efl_ui_mirrored_automatic_get_static_delegate;

        
        private delegate void efl_ui_mirrored_automatic_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool automatic);

        
        public delegate void efl_ui_mirrored_automatic_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool automatic);

        public static Efl.Eo.FunctionWrapper<efl_ui_mirrored_automatic_set_api_delegate> efl_ui_mirrored_automatic_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_mirrored_automatic_set_api_delegate>(Module, "efl_ui_mirrored_automatic_set");

        private static void mirrored_automatic_set(System.IntPtr obj, System.IntPtr pd, bool automatic)
        {
            Eina.Log.Debug("function efl_ui_mirrored_automatic_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((II18n)wrapper).SetMirroredAutomatic(automatic);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_mirrored_automatic_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), automatic);
            }
        }

        private static efl_ui_mirrored_automatic_set_delegate efl_ui_mirrored_automatic_set_static_delegate;

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        private delegate System.String efl_ui_language_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        public delegate System.String efl_ui_language_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_language_get_api_delegate> efl_ui_language_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_language_get_api_delegate>(Module, "efl_ui_language_get");

        private static System.String language_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_language_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            System.String _ret_var = default(System.String);
                try
                {
                    _ret_var = ((II18n)wrapper).GetLanguage();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_language_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_language_get_delegate efl_ui_language_get_static_delegate;

        
        private delegate void efl_ui_language_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String language);

        
        public delegate void efl_ui_language_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String language);

        public static Efl.Eo.FunctionWrapper<efl_ui_language_set_api_delegate> efl_ui_language_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_language_set_api_delegate>(Module, "efl_ui_language_set");

        private static void language_set(System.IntPtr obj, System.IntPtr pd, System.String language)
        {
            Eina.Log.Debug("function efl_ui_language_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((II18n)wrapper).SetLanguage(language);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_language_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), language);
            }
        }

        private static efl_ui_language_set_delegate efl_ui_language_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

