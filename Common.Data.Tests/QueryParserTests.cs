using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nettolicious.Common.Data;
using Nettolicious.Common.Logging;
using System.Collections.Generic;

namespace Nettolicious.Common.Data.Tests
{
  [TestClass]
  public class QueryParserTests
  {
    private readonly IQueryParser mQueryParser = new QueryParser(new NullLogger());

    [TestMethod]
    public void ParseFilterLongTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("jobid", "1");
      p.Add("result", "failure");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [JobId] = @JobId AND [Result] = @Result", result.QueryParameters.Predicate);
      Assert.IsNotNull(result.QueryParameters.Parameters);
      string[] names = new string[2];
      int i = 0;
      foreach (var _name in result.QueryParameters.Parameters.ParameterNames) {
        names[i] = _name;
        i++;
      }
      Assert.AreEqual("JobId", names[0]); //Dapper doesn't return the @ symbol in the name
      long value1 = result.QueryParameters.Parameters.Get<long>(names[0]);
      Assert.AreEqual(1, value1);
      Assert.AreEqual("Result", names[1]);
      string value2 = result.QueryParameters.Parameters.Get<string>(names[1]);
      Assert.AreEqual("failure", value2);
      Assert.IsNull(result.QueryParameters.Sort);
    }

    [TestMethod]
    public void ParseFilterNullableIntTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("records", "9155");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [Records] = @Records", result.QueryParameters.Predicate);
      Assert.IsNotNull(result.QueryParameters.Parameters);
      string name = "";
      foreach (var _name in result.QueryParameters.Parameters.ParameterNames) {
        name = _name;
        break;
      }
      Assert.AreEqual("Records", name); //Dapper doesn't return the @ symbol in the name
      int value = result.QueryParameters.Parameters.Get<int>(name);
      Assert.AreEqual(9155, value);
      Assert.IsNull(result.QueryParameters.Sort);
    }

    [TestMethod]
    public void ParseFilterDateTimeOffsetTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("started", "2017-08-17 13:01:45.0000000 -04:00");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [Started] = @Started", result.QueryParameters.Predicate);
      Assert.IsNotNull(result.QueryParameters.Parameters);
      string name = "";
      foreach (var _name in result.QueryParameters.Parameters.ParameterNames) {
        name = _name;
        break;
      }
      Assert.AreEqual("Started", name); //Dapper doesn't return the @ symbol in the name
      DateTimeOffset value = result.QueryParameters.Parameters.Get<DateTimeOffset>(name);
      Assert.AreEqual(DateTimeOffset.Parse("2017-08-17 13:01:45.0000000 -04:00"), value);
      Assert.IsNull(result.QueryParameters.Sort);
    }

    [TestMethod]
    public void ParseFilterStringTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("result", "Success");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [Result] = @Result", result.QueryParameters.Predicate);
      Assert.IsNotNull(result.QueryParameters.Parameters);
      string name = "";
      foreach (var _name in result.QueryParameters.Parameters.ParameterNames) {
        name = _name;
        break;
      }
      Assert.AreEqual("Result", name); //Dapper doesn't return the @ symbol in the name
      string value = result.QueryParameters.Parameters.Get<string>(name);
      Assert.AreEqual("Success", value);
      Assert.IsNull(result.QueryParameters.Sort);
    }

    [TestMethod]
    public void SortWithDescendingTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("sort", "result,-syslastmodified");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("ORDER BY [Result],[SysLastModified] DESC", result.QueryParameters.Sort);
      Assert.IsNull(result.QueryParameters.Predicate);
      Assert.IsNull(result.QueryParameters.Parameters);
    }

    [TestMethod]
    public void SkipTakeTest()
    {
      //Arrange
      var p = new Dictionary<string, string>();
      p.Add("jobid", "17");
      p.Add("result", "failure");
      p.Add("take", "10");
      p.Add("skip", "10");
      p.Add("sort", "-started,-ended");

      //Act
      var result = mQueryParser.Parse<JobLog>(p);

      //Assert
      Assert.IsNotNull(result);
      Assert.IsTrue(result.Ok);
      Assert.IsNull(result.Error);
      Assert.AreEqual(10, result.QueryParameters.Skip);
      Assert.AreEqual(10, result.QueryParameters.Take);
      Assert.AreEqual("WHERE 1 = 1 AND [JobId] = @JobId AND [Result] = @Result", result.QueryParameters.Predicate);
      Assert.AreEqual("ORDER BY [Started] DESC,[Ended] DESC", result.QueryParameters.Sort);
      string[] names = new string[2];
      int i = 0;
      foreach (var _name in result.QueryParameters.Parameters.ParameterNames) {
        names[i] = _name;
        i++;
      }
      Assert.AreEqual("JobId", names[0]); //Dapper doesn't return the @ symbol in the name
      long value1 = result.QueryParameters.Parameters.Get<long>(names[0]);
      Assert.AreEqual(17, value1);
      Assert.AreEqual("Result", names[1]);
      string value2 = result.QueryParameters.Parameters.Get<string>(names[1]);
      Assert.AreEqual("failure", value2);
    }

    [TestMethod]
    public void SkipAndTakeMutuallyDependentTest()
    {
      //Arrange
      var p1 = new Dictionary<string, string>();
      p1.Add("take", "10");
      var p2 = new Dictionary<string, string>();
      p2.Add("skip", "10");

      //Act
      var result1 = mQueryParser.Parse<JobLog>(p1);
      var result2 = mQueryParser.Parse<JobLog>(p2);

      //Assert
      Assert.IsNotNull(result1);
      Assert.IsFalse(result1.Ok);
      Assert.IsNotNull(result1.Error);
      Assert.IsNotNull(result2);
      Assert.IsFalse(result2.Ok);
      Assert.IsNotNull(result2.Error);
    }
  }

}
