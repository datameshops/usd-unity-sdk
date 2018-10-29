﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using pxr;
using UnityEngine;

namespace USD.NET.Unity {

  /// <summary>
  /// A collection of methods used for importing USD Xform data into Unity.
  /// </summary>
  public static class XformImporter {

    #region "Import API"

    /// <summary>
    /// Copies the transform value from USD to Unity, optionally changing handedness in the
    /// process.
    /// </summary>
    public static void BuildXform(XformableSample usdXf,
                                  GameObject go,
                                  SceneImportOptions options) {
      BuildXform(usdXf.transform, go, options);
    }

    public static void BuildXform(Matrix4x4 xf,
                                  GameObject go,
                                  SceneImportOptions options) {
      if (options.changeHandedness == BasisTransformation.SlowAndSafe) {
        xf = UnityTypeConverter.ChangeBasis(xf);
      }

      Vector3 localPos;
      Quaternion localRot;
      Vector3 localScale;

      if(!UnityTypeConverter.Decompose(xf, out localPos, out localRot, out localScale)) {
        Debug.LogError("Non-decomposable transform matrix for " + go.name);
        return;
      }

      go.transform.localPosition = localPos;
      go.transform.localScale = localScale;
      go.transform.localRotation = localRot;
    }

    /// <summary>
    /// Build the root of a scene under which more USD data will be imported. If the handedness
    /// is changed here, no subsequent changes are required below, however the root will contain
    /// a negative scale.
    /// </summary>
    public static void BuildSceneRoot(Scene scene, Transform root, SceneImportOptions options) {

      // Handle configurable up-axis (Y or Z).
      float invert = options.changeHandedness == BasisTransformation.FastAndDangerous ? -1 : 1;
      if (scene.UpAxis == Scene.UpAxes.Z) {
        root.transform.localRotation = Quaternion.AngleAxis(invert * 90, Vector3.right);
      }

      if (options.changeHandedness == BasisTransformation.FastAndDangerous) {
        // Convert from right-handed (USD) to left-handed (Unity).
        if (scene.UpAxis == Scene.UpAxes.Z) {
          root.localScale = new Vector3(1, -1, 1);
        } else {
          root.localScale = new Vector3(1, 1, -1);
        }
      }

      if (Mathf.Abs(options.scale - 1.0f) > 0.0001) {
        var ls = root.localScale;
        root.localScale = ls * options.scale;
      }
    }

    #endregion

    #region "Export API"

    public static void WriteSparseOverrides(Scene scene,
                                            PrimMap primMap,
                                            BasisTransformation changeHandedness,
                                            float tolerance = 0.0001f) {
      var oldMode = scene.WriteMode;
      scene.WriteMode = Scene.WriteModes.Over;

      try {
        foreach (var path in scene.Find<XformableSample>()) {
          GameObject go;
          if (!primMap.TryGetValue(path, out go)) {
            continue;
          }

          var tx = go.transform;
          var xfNew = XformSample.FromTransform(tx);
          var xfOld = new XformSample();

          scene.Read(path, xfOld);

          bool areClose = true;
          for (int i = 0; i < 16; i++) {
            if (Mathf.Abs(xfNew.transform[i] - xfOld.transform[i]) > tolerance) {
              areClose = false;
              break;
            }
          }

          if (areClose) {
            continue;
          }

          if (changeHandedness == BasisTransformation.SlowAndSafe) {
            xfNew.ConvertTransform();
          }

          scene.Write(path, xfNew);
        }
      } finally {
        scene.WriteMode = oldMode;
      }
    }

    #endregion
  }
}