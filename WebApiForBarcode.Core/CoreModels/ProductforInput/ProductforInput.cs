namespace WebApiforBarcode.Core.CoreModels.ProductforInput;
    public class ProductforInput {
        public ProductforInput(int barcodeIdInput, int bookNumber, string wareHouseEntry, string customerName, string productType, int productCount, int productWeight, string wareHouseLocation, int requiredCount, int count, int barcodeNo, int readedBarcode) {
            BarcodeIdInput = barcodeIdInput;
            WareHouseEntry = wareHouseEntry;
            BookNumber = bookNumber;
            CustomerName = customerName;
            ProductType = productType;
            ProductCount = productCount;
            ProductWeight = productWeight;
            WareHouseLocation = wareHouseLocation;
            RequiredCount = requiredCount;
            Count = count;
            BarcodeNo = barcodeNo;
            ReadedBarcode = readedBarcode;
        }

        public int BarcodeIdInput { get; private set; }
        public int BookNumber { get; private set; }
        public string WareHouseEntry { get; private set; }
        public string CustomerName { get; private set; }
        public string ProductType { get; private set; }
        public int ProductCount { get; private set; }
        public int ProductWeight { get; private set; }
        public string WareHouseLocation { get; private set; }
        public int RequiredCount { get; private set; }
        public int Count { get; private set; }
        public int BarcodeNo { get; private set; }
        public int ReadedBarcode { get; private set; }

        public void UpdateProductInput(int bookNumber, string customerName, string productType, int productCount, string wareHouseLocation, int requiredCount, int count, int readedBarcode) {
            BookNumber = bookNumber;
            CustomerName = customerName;
            ProductType = productType;
            ProductCount = productCount;
            WareHouseLocation = wareHouseLocation;
            RequiredCount = requiredCount;
            Count = count;
            ReadedBarcode = readedBarcode;
        }
        public void DeleteAsking(int barcodeIdInput) {
            BarcodeIdInput = barcodeIdInput;
        }
    }