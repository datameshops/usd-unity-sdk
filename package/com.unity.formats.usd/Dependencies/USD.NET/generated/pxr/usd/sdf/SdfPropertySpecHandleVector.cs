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
    public class SdfPropertySpecHandleVector : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<SdfPropertySpecHandle>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal SdfPropertySpecHandleVector(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfPropertySpecHandleVector obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~SdfPropertySpecHandleVector()
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
                        UsdCsPINVOKE.delete_SdfPropertySpecHandleVector(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SdfPropertySpecHandleVector(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (SdfPropertySpecHandle element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public SdfPropertySpecHandle this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(SdfPropertySpecHandle[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(SdfPropertySpecHandle[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, SdfPropertySpecHandle[] array, int arrayIndex, int count)
        {
            if (array == null)
                throw new global::System.ArgumentNullException("array");
            if (index < 0)
                throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
            if (arrayIndex < 0)
                throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
            if (count < 0)
                throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
            if (array.Rank > 1)
                throw new global::System.ArgumentException("Multi dimensional array.", "array");
            if (index + count > this.Count || arrayIndex + count > array.Length)
                throw new global::System.ArgumentException("Number of elements to copy is too large.");
            for (int i = 0; i < count; i++)
                array.SetValue(getitemcopy(index + i), arrayIndex + i);
        }

        global::System.Collections.Generic.IEnumerator<SdfPropertySpecHandle> global::System.Collections.Generic.IEnumerable<SdfPropertySpecHandle>.GetEnumerator()
        {
            return new SdfPropertySpecHandleVectorEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new SdfPropertySpecHandleVectorEnumerator(this);
        }

        public SdfPropertySpecHandleVectorEnumerator GetEnumerator()
        {
            return new SdfPropertySpecHandleVectorEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class SdfPropertySpecHandleVectorEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<SdfPropertySpecHandle>
        {
            private SdfPropertySpecHandleVector collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public SdfPropertySpecHandleVectorEnumerator(SdfPropertySpecHandleVector collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public SdfPropertySpecHandle Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (SdfPropertySpecHandle)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex + 1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    currentObject = collectionRef[currentIndex];
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }

        public void Clear()
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_Clear(swigCPtr);
        }

        public void Add(SdfPropertySpecHandle x)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_Add(swigCPtr, SdfPropertySpecHandle.getCPtr(x));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = UsdCsPINVOKE.SdfPropertySpecHandleVector_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = UsdCsPINVOKE.SdfPropertySpecHandleVector_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_reserve(swigCPtr, n);
        }

        public SdfPropertySpecHandleVector() : this(UsdCsPINVOKE.new_SdfPropertySpecHandleVector__SWIG_0(), true)
        {
        }

        public SdfPropertySpecHandleVector(SdfPropertySpecHandleVector other) : this(UsdCsPINVOKE.new_SdfPropertySpecHandleVector__SWIG_1(SdfPropertySpecHandleVector.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfPropertySpecHandleVector(int capacity) : this(UsdCsPINVOKE.new_SdfPropertySpecHandleVector__SWIG_2(capacity), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        private SdfPropertySpecHandle getitemcopy(int index)
        {
            SdfPropertySpecHandle ret = new SdfPropertySpecHandle(UsdCsPINVOKE.SdfPropertySpecHandleVector_getitemcopy(swigCPtr, index), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private SdfPropertySpecHandle getitem(int index)
        {
            SdfPropertySpecHandle ret = new SdfPropertySpecHandle(UsdCsPINVOKE.SdfPropertySpecHandleVector_getitem(swigCPtr, index), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, SdfPropertySpecHandle val)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_setitem(swigCPtr, index, SdfPropertySpecHandle.getCPtr(val));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(SdfPropertySpecHandleVector values)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_AddRange(swigCPtr, SdfPropertySpecHandleVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public SdfPropertySpecHandleVector GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.SdfPropertySpecHandleVector_GetRange(swigCPtr, index, count);
            SdfPropertySpecHandleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPropertySpecHandleVector(cPtr, true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, SdfPropertySpecHandle x)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_Insert(swigCPtr, index, SdfPropertySpecHandle.getCPtr(x));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, SdfPropertySpecHandleVector values)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_InsertRange(swigCPtr, index, SdfPropertySpecHandleVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_RemoveAt(swigCPtr, index);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_RemoveRange(swigCPtr, index, count);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static SdfPropertySpecHandleVector Repeat(SdfPropertySpecHandle value, int count)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.SdfPropertySpecHandleVector_Repeat(SdfPropertySpecHandle.getCPtr(value), count);
            SdfPropertySpecHandleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPropertySpecHandleVector(cPtr, true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, SdfPropertySpecHandleVector values)
        {
            UsdCsPINVOKE.SdfPropertySpecHandleVector_SetRange(swigCPtr, index, SdfPropertySpecHandleVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}