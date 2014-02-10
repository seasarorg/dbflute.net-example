using System;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.ExBhv;
using Seasar.Framework.Container.Factory;
using Seasar.Framework.Container;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.AllCommon.CBean;
using System.Data;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity.Customize;
using MbUnit.Framework;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Exp;

namespace DfExample.DBFlute.AllCommon.JavaLike
{
    [MbUnit.Framework.TestFixture]
    public class JavaCollectionTest : PlainTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        [MbUnit.Framework.Test]
        public void HashMap_BasicMethod_and_NonGenericHadling() {
            // ## Arrange ##
            Map<String, String> genericMap = new HashMap<String, String>();
            genericMap.put("aaa", "bbb");
            Object obj = genericMap;

            // ## Act ##
            NgMap nonGenericMap = obj as NgMap;

            // ## Assert ##
            String value = (String)nonGenericMap.getAsNg("aaa");
            Log("map.get(\"aaa\") --> " + value);
            Assert.AreEqual("bbb", value);
        }

        [MbUnit.Framework.Test]
        public void LinkedHashMap_BasicMethod_and_NonGenericHadling() {
            // ## Arrange ##
            Map<String, String> genericMap = new LinkedHashMap<String, String>();
            genericMap.put("aaa", "bbb");
            Object obj = genericMap;

            // ## Act ##
            NgMap nonGenericMap = obj as NgMap;

            // ## Assert ##
            String value = (String)nonGenericMap.getAsNg("aaa");
            Log("map.get(\"aaa\") --> " + value);
            Assert.AreEqual("bbb", value);
        }

        [MbUnit.Framework.Test]
        public void HashMap_Override_if_the_same_key_contains() {
            // ## Arrange ##
            Map<String, String> map = new HashMap<String, String>();
            map.put("aaa", "bbb");
            map.put("aaa", "ccc");

            // ## Act ##
            map.put("aaa", "ccc");

            // ## Assert ##
            String value = map.get("aaa");
            Log("map.get(\"aaa\") --> " + value);
            Assert.AreEqual("ccc", value);
        }

        [MbUnit.Framework.Test]
        public void LinkedHashMap_SavedSequence() {
            // ## Arrange ##
            Map<String, String> map = new LinkedHashMap<String, String>();

            // ## Act ##
            map.put("aaa1", "bbb1");
            map.put("aaa2", "bbb2");
            map.put("aaa3", "bbb3");

            // ## Assert ##
            int count = 0;
            Assert.IsTrue(map.size() == 3);
            foreach(String key in map.keySet()) {
                Log("count[" + count + "] --> " + key + ":" + map.get(key));
                if (count == 0) {
                    Assert.AreEqual("aaa1", key);
                } else if (count == 1) {
                    Assert.AreEqual("aaa2", key);
                } else if (count == 2) {
                    Assert.AreEqual("aaa3", key);
                }
                ++count;
            }
        }

        [MbUnit.Framework.Test]
        public void LinkedHashMap_SavedSequence_with_Override() {
            // ## Arrange ##
            Map<String, String> map = new LinkedHashMap<String, String>();

            // ## Act ##
            map.put("aaa1", "bbb1");
            map.put("aaa2", "bbb2");
            map.put("aaa3", "bbb3");
            map.put("aaa2", "bbb4");

            // ## Assert ##
            int count = 0;
            Assert.IsTrue(map.size() == 3);
            foreach (String key in map.keySet()) {
                Log("count[" + count + "] --> " + key + ":" + map.get(key));
                if (count == 0) {
                    Assert.AreEqual("aaa1", key);
                } else if (count == 1) {
                    Assert.AreEqual("aaa2", key);
                    Assert.AreEqual("bbb4", map.get(key));
                } else if (count == 2) {
                    Assert.AreEqual("aaa3", key);
                }
                ++count;
            }
        }
    }
}
