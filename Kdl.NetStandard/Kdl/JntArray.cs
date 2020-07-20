//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Kdl {

public class JntArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JntArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JntArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JntArray() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          kdlPINVOKE.delete_JntArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public JntArray() : this(kdlPINVOKE.new_JntArray__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArray(uint size) : this(kdlPINVOKE.new_JntArray__SWIG_1(size), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArray(JntArray arg) : this(kdlPINVOKE.new_JntArray__SWIG_2(JntArray.getCPtr(arg)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(uint newSize) {
    kdlPINVOKE.JntArray_resize(swigCPtr, newSize);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get(uint i, uint j) {
    double ret = kdlPINVOKE.JntArray_get__SWIG_0(swigCPtr, i, j);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get(uint i) {
    double ret = kdlPINVOKE.JntArray_get__SWIG_1(swigCPtr, i);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double pointer(uint i, uint j) {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(kdlPINVOKE.JntArray_pointer__SWIG_0(swigCPtr, i, j), false);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double pointer(uint i) {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(kdlPINVOKE.JntArray_pointer__SWIG_1(swigCPtr, i), false);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint rows() {
    uint ret = kdlPINVOKE.JntArray_rows(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint columns() {
    uint ret = kdlPINVOKE.JntArray_columns(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}