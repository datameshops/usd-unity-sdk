//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdShadeConnectableAPI : UsdSchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdShadeConnectableAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdShadeConnectableAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeConnectableAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdShadeConnectableAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdShadeConnectableAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdShadeConnectableAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdShadeConnectableAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeConnectableAPI() : this(UsdCsPINVOKE.new_UsdShadeConnectableAPI__SWIG_1(), true) {
  }

  public UsdShadeConnectableAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdShadeConnectableAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdShadeConnectableAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdShadeConnectableAPI ret = new UsdShadeConnectableAPI(UsdCsPINVOKE.UsdShadeConnectableAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeConnectableAPI(UsdShadeShader shader) : this(UsdCsPINVOKE.new_UsdShadeConnectableAPI__SWIG_3(UsdShadeShader.getCPtr(shader)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeConnectableAPI(UsdShadeNodeGraph nodeGraph) : this(UsdCsPINVOKE.new_UsdShadeConnectableAPI__SWIG_4(UsdShadeNodeGraph.getCPtr(nodeGraph)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsShader() {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_IsShader(swigCPtr);
    return ret;
  }

  public bool IsNodeGraph() {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_IsNodeGraph(swigCPtr);
    return ret;
  }

  public static bool CanConnect(UsdShadeInput input, UsdAttribute source) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_0(UsdShadeInput.getCPtr(input), UsdAttribute.getCPtr(source));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeInput input, UsdShadeInput sourceInput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_1(UsdShadeInput.getCPtr(input), UsdShadeInput.getCPtr(sourceInput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeInput input, UsdShadeOutput sourceOutput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_2(UsdShadeInput.getCPtr(input), UsdShadeOutput.getCPtr(sourceOutput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeOutput output, UsdAttribute source) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_3(UsdShadeOutput.getCPtr(output), UsdAttribute.getCPtr(source));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeOutput output) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_4(UsdShadeOutput.getCPtr(output));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeOutput output, UsdShadeInput sourceInput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_5(UsdShadeOutput.getCPtr(output), UsdShadeInput.getCPtr(sourceInput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanConnect(UsdShadeOutput output, UsdShadeOutput sourceOutput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_6(UsdShadeOutput.getCPtr(output), UsdShadeOutput.getCPtr(sourceOutput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_0(UsdProperty.getCPtr(shadingProp), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_1(UsdProperty.getCPtr(shadingProp), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, UsdShadeConnectableAPI source, TfToken sourceName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_2(UsdProperty.getCPtr(shadingProp), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_3(UsdShadeInput.getCPtr(input), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_4(UsdShadeInput.getCPtr(input), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_5(UsdShadeInput.getCPtr(input), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_6(UsdShadeOutput.getCPtr(output), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_7(UsdShadeOutput.getCPtr(output), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_8(UsdShadeOutput.getCPtr(output), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, SdfPath sourcePath) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_9(UsdProperty.getCPtr(shadingProp), SdfPath.getCPtr(sourcePath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, SdfPath sourcePath) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_10(UsdShadeInput.getCPtr(input), SdfPath.getCPtr(sourcePath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, SdfPath sourcePath) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_11(UsdShadeOutput.getCPtr(output), SdfPath.getCPtr(sourcePath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, UsdShadeInput sourceInput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_12(UsdProperty.getCPtr(shadingProp), UsdShadeInput.getCPtr(sourceInput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, UsdShadeInput sourceInput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_13(UsdShadeInput.getCPtr(input), UsdShadeInput.getCPtr(sourceInput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, UsdShadeInput sourceInput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_14(UsdShadeOutput.getCPtr(output), UsdShadeInput.getCPtr(sourceInput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdProperty shadingProp, UsdShadeOutput sourceOutput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_15(UsdProperty.getCPtr(shadingProp), UsdShadeOutput.getCPtr(sourceOutput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeInput input, UsdShadeOutput sourceOutput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_16(UsdShadeInput.getCPtr(input), UsdShadeOutput.getCPtr(sourceOutput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ConnectToSource(UsdShadeOutput output, UsdShadeOutput sourceOutput) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_17(UsdShadeOutput.getCPtr(output), UsdShadeOutput.getCPtr(sourceOutput));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetConnectedSource(UsdProperty shadingProp, UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_0(UsdProperty.getCPtr(shadingProp), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetConnectedSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_1(UsdShadeInput.getCPtr(input), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetConnectedSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_2(UsdShadeOutput.getCPtr(output), UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetRawConnectedSourcePaths(UsdProperty shadingProp, SdfPathVector sourcePaths) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_0(UsdProperty.getCPtr(shadingProp), SdfPathVector.getCPtr(sourcePaths));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetRawConnectedSourcePaths(UsdShadeInput input, SdfPathVector sourcePaths) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_1(UsdShadeInput.getCPtr(input), SdfPathVector.getCPtr(sourcePaths));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetRawConnectedSourcePaths(UsdShadeOutput output, SdfPathVector sourcePaths) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_2(UsdShadeOutput.getCPtr(output), SdfPathVector.getCPtr(sourcePaths));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool HasConnectedSource(UsdProperty shadingProp) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_0(UsdProperty.getCPtr(shadingProp));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool HasConnectedSource(UsdShadeInput input) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_1(UsdShadeInput.getCPtr(input));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool HasConnectedSource(UsdShadeOutput output) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_2(UsdShadeOutput.getCPtr(output));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsSourceConnectionFromBaseMaterial(UsdProperty shadingProp) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_0(UsdProperty.getCPtr(shadingProp));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsSourceConnectionFromBaseMaterial(UsdShadeInput input) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_1(UsdShadeInput.getCPtr(input));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsSourceConnectionFromBaseMaterial(UsdShadeOutput output) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_2(UsdShadeOutput.getCPtr(output));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DisconnectSource(UsdProperty shadingProp) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_0(UsdProperty.getCPtr(shadingProp));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DisconnectSource(UsdShadeInput input) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_1(UsdShadeInput.getCPtr(input));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool DisconnectSource(UsdShadeOutput output) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_2(UsdShadeOutput.getCPtr(output));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ClearSource(UsdProperty shadingProp) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_0(UsdProperty.getCPtr(shadingProp));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ClearSource(UsdShadeInput input) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_1(UsdShadeInput.getCPtr(input));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ClearSource(UsdShadeOutput output) {
    bool ret = UsdCsPINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_2(UsdShadeOutput.getCPtr(output));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeOutput ret = new UsdShadeOutput(UsdCsPINVOKE.UsdShadeConnectableAPI_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeOutput GetOutput(TfToken name) {
    UsdShadeOutput ret = new UsdShadeOutput(UsdCsPINVOKE.UsdShadeConnectableAPI_GetOutput(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_UsdShadeOutput_t GetOutputs() {
    SWIGTYPE_p_std__vectorT_UsdShadeOutput_t ret = new SWIGTYPE_p_std__vectorT_UsdShadeOutput_t(UsdCsPINVOKE.UsdShadeConnectableAPI_GetOutputs(swigCPtr), true);
    return ret;
  }

  public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeInput ret = new UsdShadeInput(UsdCsPINVOKE.UsdShadeConnectableAPI_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeInput GetInput(TfToken name) {
    UsdShadeInput ret = new UsdShadeInput(UsdCsPINVOKE.UsdShadeConnectableAPI_GetInput(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_UsdShadeInput_t GetInputs() {
    SWIGTYPE_p_std__vectorT_UsdShadeInput_t ret = new SWIGTYPE_p_std__vectorT_UsdShadeInput_t(UsdCsPINVOKE.UsdShadeConnectableAPI_GetInputs(swigCPtr), true);
    return ret;
  }

  public static readonly bool IsConcrete = UsdCsPINVOKE.UsdShadeConnectableAPI_IsConcrete_get();
  public static readonly bool IsTyped = UsdCsPINVOKE.UsdShadeConnectableAPI_IsTyped_get();
}

}