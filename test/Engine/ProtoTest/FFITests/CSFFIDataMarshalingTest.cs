using System;
using NUnit.Framework;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using System.Collections;
namespace ProtoFFITests
{
    public class CSFFIDataMarshalingTest : FFITestSetup
    {
        [Test]
        public void TestDoubles()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 123454321.0, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestFloats()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "success", ExpectedValue = true, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestFloatOut()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "success", ExpectedValue = true, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestFloatsOutOfRangeWarning()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = null;
            Assert.IsTrue(ExecuteAndVerify(code, data) == 1);
        }

        [Test]
        [Category("Failure")]
        public void TestDecimals()
        {
            // Tracked in: http://adsk-oss.myjetbrains.com/youtrack/issue/MAGN-4392
            String code =
            @"
            ValidationData[] data = { new ValidationData { ValueName = "success", ExpectedValue = true, BlockIndex = 0 } };
            int nErrors = -1;
            ExecuteAndVerify(code, data, out nErrors);
            string err = "MAGN-4392: Test fails due to FFI function calls for Decimal not being resolved";
            Assert.IsTrue(nErrors == 0, err);
        }

        [Test]
        public void TestChar()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            int F = 'F';
            ValidationData[] data = { new ValidationData { ValueName = "F", ExpectedValue = F, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestCharOutOfRangeWarning()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = null;
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestByte()
        {
            String code =
            @"
            
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            int F = 'F';
            ValidationData[] data = { new ValidationData { ValueName = "F", ExpectedValue = F, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestByteOutOfRangeWarning()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = null;
            Assert.IsTrue(ExecuteAndVerify(code, data) == 1);
        }

        [Test]
        public void TestSByte()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            int F = 'F';
            ValidationData[] data = { new ValidationData { ValueName = "F", ExpectedValue = F, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestSByteOutOfRangeWarning()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = null;
            Assert.IsTrue(ExecuteAndVerify(code, data) == 1);
        }

        [Test]
        public void TestCombineByte()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 25700, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestShort()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 10000, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestUShort()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 10000, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestUInt()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 10000, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestULong()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 10000, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestNullForPrimitiveType() //Defect 1462014 
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "bytevalue", ExpectedValue = null, BlockIndex = 0 },
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestIEnumerable()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "prime", ExpectedValue = 13, BlockIndex = 0 },
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestIEnumerable2()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "num", ExpectedValue = 10, BlockIndex = 0 },
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestIEnumerable3()
        {
            String code =
            @"
            Type t = typeof (FFITarget.TestData); //"ProtoFFITests.TestData, ProtoTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "num", ExpectedValue = 10, BlockIndex = 0 },
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestIEnumerableNestedCollection()
        {
            String code =
            @"
            Type t = typeof(FFITarget.TestData); 
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "data", ExpectedValue = new List<object> { 2, 3, "DesignScript", new List<string> { "Dynamo", "Revit" }, new List<object> { true, new List<object> { 5.5, 10 } } }, BlockIndex = 0 },
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestIEnumerableWithArbitraryRankArray()
        {
            String code =
            @"
               data = TestData.GetNestedCollection();
               list = TestData.RemoveItemsAtIndices(data, {3,1});
               size = Count(Flatten(list));
            ";
            Type t = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "list", ExpectedValue = new List<object> { 2, "DesignScript", new List<object> { true, new List<object> { 5.5, 10 } } }, BlockIndex = 0 },
                                      new ValidationData { ValueName = "size", ExpectedValue = 5, BlockIndex = 0 },
                                    };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestMarshalingIEnumerableOfDummyPoint()
        {
            String code =
            @"
               points = DummyPoint.ByCoordinates(1..5, 0, 0);
               centroid = DummyPoint.Centroid(points);
               x = centroid.X;
            ";
            Type t = typeof(FFITarget.DummyPoint);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "x", ExpectedValue = 3.0, BlockIndex = 0 },
                                    };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestArrayPromotion()
        {
            String code =
            @"
               data = TestData.GetNestedCollection();
               list = TestData.RemoveItemsAtIndices(data, 2);
               size = Count(Flatten(list));
            ";
            Type t = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "list", ExpectedValue = new List<object> { 2, 3, new List<string> { "Dynamo", "Revit" }, new List<object> { true, new List<object> { 5.5, 10 } } }, BlockIndex = 0 },
                                      new ValidationData { ValueName = "size", ExpectedValue = 7, BlockIndex = 0 },
                                    };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void TestSingletonMarshaledAsIEnumerable()
        {
            String code =
            @"
               list = TestData.RemoveItemsAtIndices(3, 0);
               size = Count(list);
            ";
            Type t = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "list", ExpectedValue = new List<object>(), BlockIndex = 0 },
                                      new ValidationData { ValueName = "size", ExpectedValue = 0, BlockIndex = 0 },
                                    };
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_IEnumerable_Implicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 2, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_IEnumerable_Explicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 2, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Int_Implicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 1, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Int_Explicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 1, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Ulong_Implicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 1, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Ulong_Explicit_Cast()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 1, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Over_Internal_Classes()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 5, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Using_Implicit_Type_Cast_In_Method_Arguments()
        {
            string code =
                @" t = TestData.TestData();
            object[] b = new object[] { 1, 1, 1, 1, 1, 20, 1, 1, 1, 1, 1, 123, 5, 20.0, 5, 4, 1, 1, 1 };
            ValidationData[] data = { new ValidationData { ValueName = "t21", ExpectedValue = b, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DataMasrshalling_Using_Explicit_Type_Cast_In_Methods()
        {
            string code =
                @" t = TestData.TestData();
            object[] b = new object[] { 1.0, 1.0, 1.0, 1.0, 1.0, 20.0, 1.0, 1.0, 1.0, 1.0, 1.0, 123.0, 5.0, 20.0, 5.0, 4.0, 1.0, 1.0, 1.0 };
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = b, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_MethodOverloading_In_Csharp_Classes()
        {
            string code =
                @" t = MethodOverloadingClass.MethodOverloadingClass();
            ValidationData[] data = { new ValidationData { ValueName = "t2", ExpectedValue = 0, BlockIndex = 0 } };
            Type dummy = typeof (FFITarget.MethodOverloadingClass);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_Dictionary()
        {
            string code =
                @" t = TestData.TestData();
            ValidationData[] data = { new ValidationData { ValueName = "r1", ExpectedValue = 42, BlockIndex = 0 } };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_DefaultArgument()
        {
            string code =
                @" d = TestData.AddWithDefaultArgument(42);  
";
            ValidationData[] data = { new ValidationData { ValueName = "d", ExpectedValue = 142} };
            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_ArbitaryDimensionParameter()
        {
            string code =
@" 
d1 = TestData.GetDepth({1, 2, {3, 4}, {5, {6, {7}}}});  
d2 = TestData.SumList({1, 2, {3, 4}, {5, {6, {7}}}});  
";
            ValidationData[] data = 
            { 
                new ValidationData { ValueName = "d1", ExpectedValue = 4} ,
                new ValidationData { ValueName = "d2", ExpectedValue = 28} , 
            };




            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_ObjectAsArbiteraryDimensionArray()
        {
            string code = @"
                     a = 1..5;
                     l1 = TestData.AddItemToFront(10, a);
                     l2 = TestData.AddItemToFront(a, a);";
            ValidationData[] data = 
            { 
                new ValidationData { ValueName = "l1", ExpectedValue = new int[] {10, 1, 2, 3, 4, 5}} ,
                new ValidationData { ValueName = "l2", ExpectedValue = new Object[] {new int[]{1, 2, 3, 4, 5}, 1, 2, 3, 4, 5}} , 
            };

            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_MarshalingNullInCollection()
        {
            string code = @"
                     list = {1, null, ""test"", true, 3.5};
                     l1 = TestData.AddItemToFront(null, list);
                     l2 = TestData.AddItemToFront(list, list);";
            ValidationData[] data = 
            { 
                new ValidationData { ValueName = "l1", ExpectedValue = new object[] {null, 1, null, "test", true, 3.5}} ,
                new ValidationData { ValueName = "l2", ExpectedValue = new object[] {new object[]{1, null, "test", true, 3.5}, 1, null, "test", true, 3.5}} , 
            };

            Type dummy = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", dummy.AssemblyQualifiedName, code);
            ExecuteAndVerify(code, data);
        }

        [Test]
        public void Test_MarshlingFunctionPointer()
        {
            String code =
            @"
            Type t = typeof(FFITarget.TestData);
            code = string.Format("import(\"{0}\");\r\n{1}", t.AssemblyQualifiedName, code);
            ValidationData[] data = { new ValidationData { ValueName = "value", ExpectedValue = 42, BlockIndex = 0 } };
            ExecuteAndVerify(code, data);
        }
    }
}