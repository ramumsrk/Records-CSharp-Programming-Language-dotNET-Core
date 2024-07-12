namespace ProductRecordTests;

public class ProductRecordTests
{
  [Fact]
  protected void ProuctRecord_OnSuccess_GetCorrectProperties()
  {
			// Arrange
			ProductRecord.ProductRecord firstProductRecord = new ProductRecord.ProductRecord()
			{
				ProductId = 1,
				ProductName = "Phone",
				ProductPrice = 500.00M,
			};
			// Act
			var actualProductId = 1;
			var actualProductName = "Phone";
			var actualProductPrice = 500.0M;
			// Assert
			Assert.Equal(
				firstProductRecord.ProductId,
				actualProductId
			);
			Assert.Equal(
				firstProductRecord.ProductName,
				actualProductName
			);
			Assert.Equal(
				firstProductRecord.ProductPrice,
				actualProductPrice
			);						
		return;
  }
}