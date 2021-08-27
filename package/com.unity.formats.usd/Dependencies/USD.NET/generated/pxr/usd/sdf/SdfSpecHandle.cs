//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class SdfSpecHandle : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfSpecHandle(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfSpecHandle obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfSpecHandle()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_SdfSpecHandle(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfSpecHandle() : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_0(), true)
        {
        }

        public SdfSpecHandle(SdfSpec spec) : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_1(SdfSpec.getCPtr(spec)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfSpecHandle(SdfSpecHandle handle) : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_2(SdfSpecHandle.getCPtr(handle)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfSpecHandle(SdfRelationshipSpecHandle handle) : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_3(SdfRelationshipSpecHandle.getCPtr(handle)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfSpecHandle(SdfPrimSpecHandle handle) : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_4(SdfPrimSpecHandle.getCPtr(handle)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfSpecHandle(SdfAttributeSpecHandle handle) : this(UsdCsPINVOKE.new_SdfSpecHandle__SWIG_5(SdfAttributeSpecHandle.getCPtr(handle)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfSpec __deref__()
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.SdfSpecHandle___deref__(swigCPtr);
            SdfSpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfSpec(cPtr, false);
            return ret;
        }

        public SWIGTYPE_p_SdfSchemaBase GetSchema()
        {
            SWIGTYPE_p_SdfSchemaBase ret = new SWIGTYPE_p_SdfSchemaBase(UsdCsPINVOKE.SdfSpecHandle_GetSchema(swigCPtr), false);
            return ret;
        }

        public SdfSpecType GetSpecType()
        {
            SdfSpecType ret = (SdfSpecType)UsdCsPINVOKE.SdfSpecHandle_GetSpecType(swigCPtr);
            return ret;
        }

        public bool IsDormant()
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_IsDormant(swigCPtr);
            return ret;
        }

        public SdfLayerHandle GetLayer()
        {
            SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.SdfSpecHandle_GetLayer(swigCPtr), true);
            return ret;
        }

        public SdfPath GetPath()
        {
            SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfSpecHandle_GetPath(swigCPtr), true);
            return ret;
        }

        public bool PermissionToEdit()
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_PermissionToEdit(swigCPtr);
            return ret;
        }

        public TfTokenVector ListInfoKeys()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfSpecHandle_ListInfoKeys(swigCPtr), true);
            return ret;
        }

        public TfTokenVector GetMetaDataInfoKeys()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfSpecHandle_GetMetaDataInfoKeys(swigCPtr), true);
            return ret;
        }

        public TfToken GetMetaDataDisplayGroup(TfToken key)
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.SdfSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetInfo(TfToken key)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetInfo(TfToken key, VtValue value)
        {
            UsdCsPINVOKE.SdfSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
        {
            UsdCsPINVOKE.SdfSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool HasInfo(TfToken key)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void ClearInfo(TfToken key)
        {
            UsdCsPINVOKE.SdfSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public TfType GetTypeForInfo(TfToken key)
        {
            TfType ret = new TfType(UsdCsPINVOKE.SdfSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetFallbackForInfo(TfToken key)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool WriteToStream(SWIGTYPE_p_std__ostream arg0, uint indent)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_WriteToStream__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0), indent);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool WriteToStream(SWIGTYPE_p_std__ostream arg0)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_WriteToStream__SWIG_1(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool IsInert(bool ignoreChildren)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
            return ret;
        }

        public bool IsInert()
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_IsInert__SWIG_1(swigCPtr);
            return ret;
        }

        public TfTokenVector ListFields()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfSpecHandle_ListFields(swigCPtr), true);
            return ret;
        }

        public bool HasField(TfToken name)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VtValue GetField(TfToken name)
        {
            VtValue ret = new VtValue(UsdCsPINVOKE.SdfSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool SetField(TfToken name, VtValue value)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool ClearField(TfToken name)
        {
            bool ret = UsdCsPINVOKE.SdfSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }
}