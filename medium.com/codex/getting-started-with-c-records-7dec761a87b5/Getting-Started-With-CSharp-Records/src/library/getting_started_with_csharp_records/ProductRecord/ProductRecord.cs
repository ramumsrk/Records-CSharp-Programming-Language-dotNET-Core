namespace ProductRecord;

/// <summary>
/// This is the classic form of defining a record class
/// </summary>
public record class ProductRecord
{
  private int _productId;
  private string _productName;
  private decimal _productPrice;
  public required int ProductId
  {
    get
    {
      return this._productId;
    }
    init
    {
      this._productId = value;
    }
  }
  public required string ProductName
  {
    get
    {
      return this._productName;
    }
    init
    {
      this._productName = value;
    }
  }
  public required decimal ProductPrice
  {
    get
    {
      return this._productPrice;
    }
    init
    {
      this._productPrice = value;
    }
  }
}