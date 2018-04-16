using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nettolicious.Common.Data;
using Nettolicious.Common.Logging;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Nettolicious.Common.Data.Tests
{
  [TestClass]
  public class QueryParserExtTests
  {
    private readonly QueryParser mQueryParser = new QueryParser(new NullLogger());

    [TestMethod]
    public void GetProjections_outputstring_ValidProjectionFiledJoinedByCommaExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> fileds = new List<string>() { "Duration", "Records" };

      //Act
      var result = mQueryParser.GetProjections(properties, fileds);

      //Assert
      Assert.IsNotNull(result);
      string expectedresult = "[Duration],[Records]";
      Assert.AreEqual(expectedresult, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Provided Fileds Not Avaible in the Object Properties Records1")]
    public void GetProjections_NotAvailablefieldrequested_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> fileds = new List<string>() { "Duration", "Records1" };

      //Act
      var result = mQueryParser.GetProjections(properties, fileds);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "properties cannot be null or empty.")]
    public void GetProjections_NullProperties_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = null;
      List<string> fileds = new List<string>() { "Duration", "Records1" };

      //Act
      var result = mQueryParser.GetProjections(properties, fileds);

    }

    [TestMethod]
    public void GetProjections_NoInputFieldsSpecified_NullExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> fileds = new List<string>();
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetProjections(properties, fileds);

      //Assert
      Assert.IsNull(result);
    }

    [TestMethod]
    public void GetProjections_NullFieldsSpecified_NUllExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> fileds = null;
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetProjections(properties, fileds);

      //Assert
      Assert.IsNull(result);
    }

    [TestMethod]
    public void GetSelectionPredicate__NullSelectionSpecified_EmptyPredicateExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = null;
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    public void GetSelectionPredicate_EmptySelectionSpecified_EmptyPredicateExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>();
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException), "null operators specified")]
    public void GetSelectionPredicate_NullFilterOperatorSpecified_ArgumentNullExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = null,
            Value =  "1",
            Key =  "Records"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException), "null operators specified")]
    public void GetSelectionPredicate_EmptyFilterOperatorSpecified_ArgumentNullExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = "",
            Value =  "1",
            Key =  "Records"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Provided Filter Keys Not Avaible in the Object Properties pq")]
    public void GetSelectionPredicate_UnRecognisedFilterOperatorSpecified_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = "pq",
            Value =  "1",
            Key =  "Records"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Provided Filter Keys Not Avaible in the Object Properties pq,ct")]
    public void GetSelectionPredicate_MultipleUnRecognisedFilterOperatorSpecified_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = "pq",
            Value =  "1",
            Key =  "Records"
          },
          new Filter {
            FilterOperator = "ct",
            Value =  "1",
            Key =  "Records"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(string.Empty, result.predicate);
      Assert.IsNull(result.parameters);

    }

    [TestMethod]
    public void GetSelectionPredicate_OneFilterOperatorSpecified_ValidStringExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = "eq",
            Value =  "1",
            Key =  "Records"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [Records] = @Records", result.predicate);
      Assert.IsNotNull(result.parameters);
      Assert.AreEqual(1, result.parameters.Get<int>("Records"));

    }

    [TestMethod]
    public void GetSelectionPredicate_MultipleFilterOperatorSpecified_ValidStringExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<Filter> filters = new List<Filter>() {
           new Filter {
            FilterOperator = "eq",
            Value =  "1",
            Key =  "Records"
          },
          new Filter {
            FilterOperator = "gt",
            Value =  "1",
            Key =  "Duration"
          },
           new Filter {
            FilterOperator = "wc",
            Value =  "%Errror%",
            Key =  "Result"
          }
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetSelectionPredicate(properties, filters);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("WHERE 1 = 1 AND [Records] = @Records AND [Duration] > @Duration AND [Result] like @Result", result.predicate);
      Assert.IsNotNull(result.parameters);
      Assert.AreEqual(1,result.parameters.Get<int>("Records"));
      Assert.AreEqual(1,result.parameters.Get<int>("Duration"));
      Assert.AreEqual("%Errror%", result.parameters.Get<string>("Result"));
    }

    [TestMethod]
    public void GetOrderByQuery_NullSortfieldsSpecified_DefaultSortExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = null; 
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("ORDER BY [SysLastModified] DESC", result);
    }

    [TestMethod]
    public void GetOrderByQuery_NoSortfieldsSpecified_DefaultSortExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>();
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.IsNotNull(result);
      Assert.AreEqual("ORDER BY [SysLastModified] DESC", result);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "SortFields Not Valid recordg")]
    public void GetOrderByQuery_UnRecoginisedSortfieldsSpecified_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>() {
        "recordg"
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.AreEqual(string.Empty, result);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "SortFields Not Valid recordg,kpg")]
    public void GetOrderByQuery_MultipleUnRecoginisedSortfieldsSpecified_ArgumentExceptionExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>() {
        "recordg","kpg"
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.AreEqual(string.Empty, result);

    }

    [TestMethod]
    public void GetOrderByQuery_DescSortfieldsSpecified_DefaultSortExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>() {
        "-records"
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.AreEqual("ORDER BY [Records] DESC", result);

    }

    [TestMethod]
    public void GetOrderByQuery_MultipleSortfieldsSpecified_DefaultSortExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>() {
        "-records",
        "duration"
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.AreEqual("ORDER BY [Records] DESC, [Duration]", result );

    }


    [TestMethod]
    public void GetOrderByQuery_MultipleSortfieldsSpecified2_DefaultSortExpected()
    {
      //Arrange
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      List<string> sortfields = new List<string>() {
        "duration",
        "-records"        
      };
      var propertieslist = properties.Select(x => x.Name).ToList();

      //Act
      var result = mQueryParser.GetOrderByQuery(properties, sortfields);

      //Assert
      Assert.AreEqual("ORDER BY [Duration], [Records] DESC", result);

    }

    [TestMethod]
    public void GetSkipTakeQuery_NullTakePassed_EmptyStringExpected()
    {
      //Arrange 
      int? take = null;
      int? skip = 20;

      //Act
      var result = mQueryParser.GetSkipTakeQuery(skip, take);

      //Assert
      Assert.AreEqual(string.Empty, result);

    }

    [TestMethod]
    public void GetSkipTakeQuery_NullSkipPassed_EmptyStringExpected()
    {
      //Arrange 
      int? take = 20;
      int? skip = null;

      //Act
      var result = mQueryParser.GetSkipTakeQuery(skip, take);

      //Assert
      Assert.AreEqual(string.Empty, result);

    }

    [TestMethod]
    public void GetSkipTakeQuery_validSkipTakePassed_OFFSETQueryExpected()
    {
      //Arrange 
      int? take = 20;
      int? skip = 10;

      //Act
      var result = mQueryParser.GetSkipTakeQuery(skip, take);

      //Assert
      string SKIP_TAKE_FORMAT = "OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY";
      Assert.AreEqual(String.Format(SKIP_TAKE_FORMAT, skip, take), result);

    }

    [TestMethod]
    public void Parse_ValidQueryWithNoFileds_QueryparserResultExpected()
    {
      //Arrange
      var query = new Query {
        Skip = 1,
        Take = 10,
        Fields = null,
        Filters = new List<Filter> {
          new Filter {
            FilterOperator = "eq",
            Value =  "1",
            Key =  "Records"
          }
        }
      };

      //Act
      var result = mQueryParser.Parse<JobLog>(query);

      //Assert
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      var propertieslist = properties.Select(x => x.Name).ToList();

      var expectedPredicate = "WHERE 1 = 1 AND [Records] = @Records";
      var expectedOrderBy = "ORDER BY [SysLastModified] DESC";
      Assert.IsNotNull(result);
      Assert.AreEqual(expectedPredicate, result.Predicate);
      Assert.AreEqual(expectedOrderBy, result.Sort);
      Assert.IsNull(result.Projections);
    }


    [TestMethod]
    public void Parse_ValidQueryWithNoSkipTake_QueryparserResultExpected()
    {
      //Arrange
      var query = new Query {
        Fields = null,
        Filters = new List<Filter> {
          new Filter {
            FilterOperator = "eq",
            Value =  "1",
            Key =  "Records"
          }
        }
      };

      //Act
      var result = mQueryParser.Parse<JobLog>(query);

      //Assert
      List<PropertyInfo> properties = typeof(JobLog).GetProperties().ToList();
      var propertieslist = properties.Select(x => x.Name).ToList();

      var expectedPredicate = "WHERE 1 = 1 AND [Records] = @Records";
      var expectedOrderBy = "ORDER BY [SysLastModified] DESC";
      Assert.IsNotNull(result);
      Assert.AreEqual(expectedPredicate, result.Predicate);
      Assert.AreEqual(expectedOrderBy, result.Sort);
      Assert.IsNull(result.Skip);
      Assert.IsNull(result.Take);
    }

    [TestMethod]
    public void Parse_ValidQuery_QueryparserResultExpected()
    {
      //Arrange
      var query = new Query {
        Skip = 1,
        Take = 10,
        Fields = new List<string>() { "Duration", "Records" },
        Filters = new List<Filter> {
          new Filter {
            FilterOperator = "eq",
            Value =  "1",
            Key =  "Records"
          }
        }
      };

      //Act
      var result = mQueryParser.Parse<JobLog>(query);

      //Assert
      var expectedPredicate = "WHERE 1 = 1 AND [Records] = @Records";
      var expectedOrderBy = "ORDER BY [SysLastModified] DESC";
      var expectedprojections = "[Duration],[Records]";
      Assert.IsNotNull(result);
      Assert.AreEqual(expectedPredicate, result.Predicate);
      Assert.AreEqual(expectedOrderBy, result.Sort);
      Assert.AreEqual(expectedprojections,result.Projections);

    }
  }
}
