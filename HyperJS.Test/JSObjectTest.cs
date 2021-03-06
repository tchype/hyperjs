﻿using TonyHeupel.HyperJS;
using NUnit.Framework;
using System;
using System.Dynamic;

namespace TonyHeupel.HyperJS.UnitTest
{
    
    
    /// <summary>
    /// Tests for JSObject, which is the base class for 
    /// the dynamic objects for HyperJS/JS.cs
    ///</summary>
    [TestFixture()]
    public class JSObjectTest
    {
        /// <summary>
        ///A test for JSObject Constructor
        ///</summary>
        [Test()]
        public void JSObjectConstructorTest()
        {
            var target = new JSObject();
			Assert.IsInstanceOfType(typeof(HyperCore.HyperHypo), target);
        }

        [Test]
        public void JSObjectMissingMembersAreUndefined()
        {
            dynamic foo = JS.cs.NewObject();
            Assert.AreSame(JS.undefined, foo.bar);
        }

        [Test]
        public void FeatureDetectionWorks_KindOf()
        {
            dynamic foo = JS.cs.NewObject();
            if (JS.cs.Boolean(foo.bar as object)) 
            {
                Assert.Fail("bar should not be defined yet");
            }

            foo.bar = new Func<string>(() => "this is bar");
            if (JS.cs.Boolean(foo.bar as object)) //Had to use the Boolean function explicitely...if only EVERYTHING was a JSObject...someday...
            {
                Assert.AreEqual("this is bar", foo.bar());
            }
            else
            {
                Assert.Fail("bar should be defined now");
            }
        }
    }
}
