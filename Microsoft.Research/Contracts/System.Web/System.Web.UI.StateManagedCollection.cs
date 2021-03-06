// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Web.UI.StateManagedCollection.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Web.UI
{
  abstract public partial class StateManagedCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, IStateManager
  {
    #region Methods and constructors
    public void Clear ()
    {
    }

    public void CopyTo (Array array, int index)
    {
    }

    protected virtual new Object CreateKnownType (int index)
    {
      return default(Object);
    }

    public System.Collections.IEnumerator GetEnumerator ()
    {
      return default(System.Collections.IEnumerator);
    }

    protected virtual new Type[] GetKnownTypes ()
    {
      return default(Type[]);
    }

    protected virtual new void OnClear ()
    {
    }

    protected virtual new void OnClearComplete ()
    {
    }

    protected virtual new void OnInsert (int index, Object value)
    {
    }

    protected virtual new void OnInsertComplete (int index, Object value)
    {
    }

    protected virtual new void OnRemove (int index, Object value)
    {
    }

    protected virtual new void OnRemoveComplete (int index, Object value)
    {
    }

    protected virtual new void OnValidate (Object value)
    {
    }

    public void SetDirty ()
    {
    }

    protected abstract void SetDirtyObject (Object o);

    protected StateManagedCollection ()
    {
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
    {
      return default(System.Collections.IEnumerator);
    }

    int System.Collections.IList.Add (Object value)
    {
      return default(int);
    }

    void System.Collections.IList.Clear ()
    {
    }

    bool System.Collections.IList.Contains (Object value)
    {
      return default(bool);
    }

    int System.Collections.IList.IndexOf (Object value)
    {
      return default(int);
    }

    void System.Collections.IList.Insert (int index, Object value)
    {
    }

    void System.Collections.IList.Remove (Object value)
    {
    }

    void System.Collections.IList.RemoveAt (int index)
    {
    }

    void System.Web.UI.IStateManager.LoadViewState (Object savedState)
    {
    }

    Object System.Web.UI.IStateManager.SaveViewState ()
    {
      return default(Object);
    }

    void System.Web.UI.IStateManager.TrackViewState ()
    {
    }
    #endregion

    #region Properties and indexers
    public int Count
    {
      get
      {
        return default(int);
      }
    }

    int System.Collections.ICollection.Count
    {
      get
      {
        return default(int);
      }
    }

    bool System.Collections.ICollection.IsSynchronized
    {
      get
      {
        return default(bool);
      }
    }

    Object System.Collections.ICollection.SyncRoot
    {
      get
      {
        return default(Object);
      }
    }

    bool System.Collections.IList.IsFixedSize
    {
      get
      {
        return default(bool);
      }
    }

    bool System.Collections.IList.IsReadOnly
    {
      get
      {
        return default(bool);
      }
    }

    Object System.Collections.IList.this [int index]
    {
      get
      {
        return default(Object);
      }
      set
      {
      }
    }

    bool System.Web.UI.IStateManager.IsTrackingViewState
    {
      get
      {
        return default(bool);
      }
    }
    #endregion
  }
}
