﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TonyHeupel.HyperJS
{
    public static class JSExtensions
    {
        #region Global Functions

        // Global functions are implemented as instance methods so that:
        // 1) Extensions can be added on seemlessly to the global object
        //    through the JS.cs.<function> accessor
        // 2) The global object is a singleton anyway, so there's very
        //    little to gain.  Worst case, implement a private static
        //    method with a slightly different name and have the instance
        //    method call it.

        #region Global Objects

        public static dynamic Array(this JS js)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Boolean(value) function on the global object.
        /// It returns a Boolean converted from the value passed in. 
        /// 0, NaN, null, "", undefined, false and "false" are false.
        /// Everything else will return true.
        /// </summary>
        public static bool Boolean(this JS js, object value)
        {
            return ((dynamic)new JSBoolean(value)).valueOf();
        }

        public static dynamic NewBoolean(this JS js, dynamic value)
        {
            return new JSBoolean(value);
        }



        public static dynamic Date(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic Error(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic EvalError(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic Function(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic Number(this JS js)
        {
            throw new NotImplementedException();
        }

        #region JSObject
        public static dynamic Object(this JS js)
        {
            return JSObject(js, null);
        }

        public static dynamic JSObject(this JS js, JSObject self)
        {
            return new JSObject(self);
        }

        #endregion

        public static dynamic RangeError(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic ReferenceError(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic RegExp(this JS js)
        {
            throw new NotImplementedException();
        }

        public static string JSString(this JS js, dynamic value)
        {
            dynamic s = new JSString(value);
            return s.valueOf();
        }

        public static dynamic SyntaxError(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic TypeError(this JS js)
        {
            throw new NotImplementedException();
        }

        public static dynamic URIError(this JS js)
        {
            throw new NotImplementedException();
        }
        #endregion

        #endregion
    }
}
