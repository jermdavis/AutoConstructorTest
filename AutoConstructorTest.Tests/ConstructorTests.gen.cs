﻿// **
// ** Generated code - do not edit
// **
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AutoConstructorTest.Tests
{

	[TestClass]
	[TestCategory("AutoGenerated")]
	public class ValidClass1_GeneratedTests
	{

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass1_Constructor_2Params_s_IsNull_Throws()
		{
				System.String s = null;
				var i = 0;

				var sut = new AutoConstructorTest.Examples.ValidClass1(s, i);
		}

	}

	[TestClass]
	[TestCategory("AutoGenerated")]
	public class ValidClass2_GeneratedTests
	{

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass2_Constructor_2Params_s1_IsNull_Throws()
		{
				System.String s1 = null;
				var i = new Mock<AutoConstructorTest.Examples.ISomeInterface>().Object;

				var sut = new AutoConstructorTest.Examples.ValidClass2(s1, i);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass2_Constructor_2Params_i_IsNull_Throws()
		{
				var s1 = String.Empty;
				AutoConstructorTest.Examples.ISomeInterface i = null;

				var sut = new AutoConstructorTest.Examples.ValidClass2(s1, i);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass2_Constructor_3Params_s1_IsNull_Throws()
		{
				System.String s1 = null;
				var s2 = String.Empty;
				var i = new Mock<AutoConstructorTest.Examples.ISomeInterface>().Object;

				var sut = new AutoConstructorTest.Examples.ValidClass2(s1, s2, i);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass2_Constructor_3Params_s2_IsNull_Throws()
		{
				var s1 = String.Empty;
				System.String s2 = null;
				var i = new Mock<AutoConstructorTest.Examples.ISomeInterface>().Object;

				var sut = new AutoConstructorTest.Examples.ValidClass2(s1, s2, i);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidClass2_Constructor_3Params_i_IsNull_Throws()
		{
				var s1 = String.Empty;
				var s2 = String.Empty;
				AutoConstructorTest.Examples.ISomeInterface i = null;

				var sut = new AutoConstructorTest.Examples.ValidClass2(s1, s2, i);
		}

	}

	[TestClass]
	[TestCategory("AutoGenerated")]
	public class ParameterlessConstructor_GeneratedTests
	{

	}

}