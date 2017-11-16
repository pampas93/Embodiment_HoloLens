//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class SyncListener : Listener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SyncListener(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.SyncListener_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SyncListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SyncListener() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_SyncListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void OnSyncChangesBegin() {
    if (SwigDerivedClassHasMethod("OnSyncChangesBegin", swigMethodTypes0)) SharingClientPINVOKE.SyncListener_OnSyncChangesBeginSwigExplicitSyncListener(swigCPtr); else SharingClientPINVOKE.SyncListener_OnSyncChangesBegin(swigCPtr);
  }

  public virtual void OnSyncChangesEnd() {
    if (SwigDerivedClassHasMethod("OnSyncChangesEnd", swigMethodTypes1)) SharingClientPINVOKE.SyncListener_OnSyncChangesEndSwigExplicitSyncListener(swigCPtr); else SharingClientPINVOKE.SyncListener_OnSyncChangesEnd(swigCPtr);
  }

  public SyncListener() : this(SharingClientPINVOKE.new_SyncListener(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnSyncChangesBegin", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateSyncListener_0(SwigDirectorOnSyncChangesBegin);
    if (SwigDerivedClassHasMethod("OnSyncChangesEnd", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateSyncListener_1(SwigDirectorOnSyncChangesEnd);
    SharingClientPINVOKE.SyncListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(SyncListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnSyncChangesBegin() {
    OnSyncChangesBegin();
  }

  private void SwigDirectorOnSyncChangesEnd() {
    OnSyncChangesEnd();
  }

  public delegate void SwigDelegateSyncListener_0();
  public delegate void SwigDelegateSyncListener_1();

  private SwigDelegateSyncListener_0 swigDelegate0;
  private SwigDelegateSyncListener_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
}

}
