// Array.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System {

    // NOTE: Keep in sync with ArrayList and List

    /// <summary>
    /// Equivalent to the Array type in Javascript.
    /// </summary>
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("Array")]
    public abstract class Array : IEnumerable {

        [ScriptField]
        public extern int Length { get; }

        [ScriptField]
        public extern object this[int index] { get; set; }

        public Array Concat(params object[] objects) {
            return null;
        }

        public bool Contains(object item) {
            return false;
        }

        public IEnumerator GetEnumerator() {
            return null;
        }

        public Array GetRange(int index) {
            return null;
        }

        public Array GetRange(int index, int count) {
            return null;
        }

        public int IndexOf(object item) {
            return 0;
        }

        public int IndexOf(object item, int startIndex) {
            return 0;
        }

        public string Join() {
            return null;
        }

        public string Join(string delimiter) {
            return null;
        }

        public int LastIndexOf(object item) {
            return 0;
        }

        public int LastIndexOf(object item, int fromIndex) {
            return 0;
        }


        [ScriptAlias("ss.array")]
        public static Array Parse(string s) {
            return null;
        }

        

        public void Reverse() {
        }

        public object Shift() {
            return null;
        }

        public Array Slice(int start) {
            return null;
        }

        public Array Slice(int start, int end) {
            return null;
        }

        

        public void Sort() {
        }


        public void Splice(int start, int deleteCount) {
        }

        public void Splice(int start, int deleteCount, params object[] itemsToInsert) {
        }

        [ScriptAlias("ss.array")]
        public static Array ToArray(object o) {
            return null;
        }

        public void Unshift(params object[] items) {
        }

        public static explicit operator ArrayList(Array array) {
            return null;
        }

        public static explicit operator List<object>(Array array) {
            return null;
        }
    }
}
