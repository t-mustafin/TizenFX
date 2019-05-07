#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

/// <summary>Efl alpha animation class</summary>
[Efl.Canvas.AnimationAlpha.NativeMethods]
public class AnimationAlpha : Efl.Canvas.Animation, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(AnimationAlpha))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
        efl_canvas_animation_alpha_class_get();
    /// <summary>Initializes a new instance of the <see cref="AnimationAlpha"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public AnimationAlpha(Efl.Object parent= null
            ) : base(efl_canvas_animation_alpha_class_get(), typeof(AnimationAlpha), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="AnimationAlpha"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected AnimationAlpha(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="AnimationAlpha"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected AnimationAlpha(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
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

    /// <summary>Alpha property</summary>
    /// <param name="from_alpha">Alpha value when animation starts</param>
    /// <param name="to_alpha">Alpha value when animation ends</param>
    virtual public void GetAlpha(out double from_alpha, out double to_alpha) {
                                                         Efl.Canvas.AnimationAlpha.NativeMethods.efl_animation_alpha_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out from_alpha, out to_alpha);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Alpha property</summary>
    /// <param name="from_alpha">Alpha value when animation starts</param>
    /// <param name="to_alpha">Alpha value when animation ends</param>
    virtual public void SetAlpha(double from_alpha, double to_alpha) {
                                                         Efl.Canvas.AnimationAlpha.NativeMethods.efl_animation_alpha_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),from_alpha, to_alpha);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.AnimationAlpha.efl_canvas_animation_alpha_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Animation.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Evas);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_animation_alpha_get_static_delegate == null)
            {
                efl_animation_alpha_get_static_delegate = new efl_animation_alpha_get_delegate(alpha_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetAlpha") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_animation_alpha_get"), func = Marshal.GetFunctionPointerForDelegate(efl_animation_alpha_get_static_delegate) });
            }

            if (efl_animation_alpha_set_static_delegate == null)
            {
                efl_animation_alpha_set_static_delegate = new efl_animation_alpha_set_delegate(alpha_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetAlpha") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_animation_alpha_set"), func = Marshal.GetFunctionPointerForDelegate(efl_animation_alpha_set_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.AnimationAlpha.efl_canvas_animation_alpha_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate void efl_animation_alpha_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double from_alpha,  out double to_alpha);

        
        public delegate void efl_animation_alpha_get_api_delegate(System.IntPtr obj,  out double from_alpha,  out double to_alpha);

        public static Efl.Eo.FunctionWrapper<efl_animation_alpha_get_api_delegate> efl_animation_alpha_get_ptr = new Efl.Eo.FunctionWrapper<efl_animation_alpha_get_api_delegate>(Module, "efl_animation_alpha_get");

        private static void alpha_get(System.IntPtr obj, System.IntPtr pd, out double from_alpha, out double to_alpha)
        {
            Eina.Log.Debug("function efl_animation_alpha_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        from_alpha = default(double);        to_alpha = default(double);                            
                try
                {
                    ((AnimationAlpha)wrapper).GetAlpha(out from_alpha, out to_alpha);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_animation_alpha_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out from_alpha, out to_alpha);
            }
        }

        private static efl_animation_alpha_get_delegate efl_animation_alpha_get_static_delegate;

        
        private delegate void efl_animation_alpha_set_delegate(System.IntPtr obj, System.IntPtr pd,  double from_alpha,  double to_alpha);

        
        public delegate void efl_animation_alpha_set_api_delegate(System.IntPtr obj,  double from_alpha,  double to_alpha);

        public static Efl.Eo.FunctionWrapper<efl_animation_alpha_set_api_delegate> efl_animation_alpha_set_ptr = new Efl.Eo.FunctionWrapper<efl_animation_alpha_set_api_delegate>(Module, "efl_animation_alpha_set");

        private static void alpha_set(System.IntPtr obj, System.IntPtr pd, double from_alpha, double to_alpha)
        {
            Eina.Log.Debug("function efl_animation_alpha_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((AnimationAlpha)wrapper).SetAlpha(from_alpha, to_alpha);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_animation_alpha_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), from_alpha, to_alpha);
            }
        }

        private static efl_animation_alpha_set_delegate efl_animation_alpha_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

