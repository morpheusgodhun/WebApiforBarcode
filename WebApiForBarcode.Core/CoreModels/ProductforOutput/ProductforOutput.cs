namespace WebApiforBarcode.Core.CoreModels.ProductforOutput;
public class ProductforOutput {
    public ProductforOutput(int barcodeId, int bookNumber, string customerName, string productType, int productCount, string wareHouseLocation, int requiredCount, int mainBarcodeNumber, int barcodeCount, bool isReaded) {
        BarcodeId = barcodeId;
        BookNumber = bookNumber;
        CustomerName = customerName;
        ProductType = productType;
        ProductCount = productCount;
        WareHouseLocation = wareHouseLocation;
        RequiredCount = requiredCount;
        MainBarcodeNumber = mainBarcodeNumber;
        BarcodeCount = barcodeCount;
        IsReaded = isReaded;
    }

    public int BarcodeId { get; private set; }
    public int BookNumber { get; private set; }
    public string CustomerName { get; private set; }
    public string ProductType { get; private set; }
    public int ProductCount { get; private set; }
    public string WareHouseLocation { get; private set; }
    public int RequiredCount { get; private set; }
    public int MainBarcodeNumber { get; private set; }
    public int BarcodeCount { get; private set; }
    public bool IsReaded { get; private set; }

    public void UpdateProductInput(int bookNumber, string customerName, string productType, int productCount, string wareHouseLocation, int requiredCount, int barcodeCount, bool isReaded) {
        BookNumber = bookNumber;
        CustomerName = customerName;
        ProductType = productType;
        ProductCount = productCount;
        WareHouseLocation = wareHouseLocation;
        RequiredCount = requiredCount;
        BarcodeCount = barcodeCount;
        IsReaded = isReaded;
    }
    public void DeleteAsking(int barcodeId) {
        BarcodeId = barcodeId;
    }
}