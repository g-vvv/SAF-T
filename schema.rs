#[macro_use]
extern crate serde_derive;
extern crate serde;
extern crate serde_xml_rs;

use serde_xml_rs::from_reader;


// Header ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Header {
	#[serde(rename = "TaxAccountingBasis")]
	pub tax_accounting_basis: SAFshorttextType,
	#[serde(rename = "TaxEntity")]
	pub tax_entity: SAFmiddle2textType,
	#[serde(flatten)]
	pub header_structure: HeaderStructure,
}


// Account ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Account {
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "AccountDescription")]
	pub account_description: SAFlongtextType,
	#[serde(rename = "TaxpayerAccountID")]
	pub taxpayer_account_id: SAFmiddle1textType,
	#[serde(rename = "GroupingCategory")]
	pub grouping_category: SAFmiddle1textType,
	#[serde(rename = "GroupingCode")]
	pub grouping_code: SAFmiddle1textType,
	#[serde(rename = "AccountType")]
	pub account_type: SAFshorttextType,
	#[serde(rename = "AccountCreationDate")]
	pub account_creation_date: u8,
	#[serde(rename = "OpeningDebitBalance")]
	pub opening_debit_balance: SAFmonetaryType,
	#[serde(rename = "OpeningCreditBalance")]
	pub opening_credit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingDebitBalance")]
	pub closing_debit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingCreditBalance")]
	pub closing_credit_balance: SAFmonetaryType,
}


// GeneralLedgerAccounts ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct GeneralLedgerAccounts {
	#[serde(rename = "Account")]
	pub account: Vec<Account>,
}


// TaxonomyElement ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxonomyElement {
	#[serde(rename = "TaxonomyCode")]
	pub taxonomy_code: SAFlongtextType,
	#[serde(rename = "TaxonomyClusterID")]
	pub taxonomy_cluster_id: SAFlongtextType,
	#[serde(rename = "TaxonomyClusterContextID")]
	pub taxonomy_cluster_context_id: SAFlongtextType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
}


// Taxonomy ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Taxonomy {
	#[serde(rename = "TaxonomyReference")]
	pub taxonomy_reference: SAFlongtextType,
	#[serde(rename = "TaxonomyElement")]
	pub taxonomy_element: Vec<TaxonomyElement>,
}


// Taxonomies ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Taxonomies {
	#[serde(rename = "Taxonomy")]
	pub taxonomy: Vec<Taxonomy>,
}


// Customer ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Customer {
	#[serde(rename = "CompanyStructure")]
	pub company_structure: CompanyStructure,
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "SelfBillingIndicator")]
	pub self_billing_indicator: SAFcodeType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "OpeningDebitBalance")]
	pub opening_debit_balance: SAFmonetaryType,
	#[serde(rename = "OpeningCreditBalance")]
	pub opening_credit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingDebitBalance")]
	pub closing_debit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingCreditBalance")]
	pub closing_credit_balance: SAFmonetaryType,
}


// Customers ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Customers {
	#[serde(rename = "Customer")]
	pub customer: Vec<Customer>,
}


// Supplier ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Supplier {
	#[serde(rename = "CompanyStructure")]
	pub company_structure: CompanyStructure,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "SelfBillingIndicator")]
	pub self_billing_indicator: SAFcodeType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "OpeningDebitBalance")]
	pub opening_debit_balance: SAFmonetaryType,
	#[serde(rename = "OpeningCreditBalance")]
	pub opening_credit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingDebitBalance")]
	pub closing_debit_balance: SAFmonetaryType,
	#[serde(rename = "ClosingCreditBalance")]
	pub closing_credit_balance: SAFmonetaryType,
}


// Suppliers ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Suppliers {
	#[serde(rename = "Supplier")]
	pub supplier: Vec<Supplier>,
}


// TaxCodeDetails ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxCodeDetails {
	#[serde(rename = "TaxCode")]
	pub tax_code: SAFcodeType,
	#[serde(rename = "EffectiveDate")]
	pub effective_date: u8,
	#[serde(rename = "ExpirationDate")]
	pub expiration_date: u8,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "TaxPercentage")]
	pub tax_percentage: f64,
	#[serde(rename = "FlatTaxRate")]
	pub flat_tax_rate: AmountStructure,
	#[serde(rename = "BaseRate")]
	pub base_rate: Vec<SAFBaseRate>,
	#[serde(rename = "Country")]
	pub country: ISOCountryCode,
	#[serde(rename = "Region")]
	pub region: SAFcodeType,
}


// TaxTableEntry ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxTableEntry {
	#[serde(rename = "TaxType")]
	pub tax_type: SAFcodeType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "TaxCodeDetails")]
	pub tax_code_details: Vec<TaxCodeDetails>,
}


// TaxTable ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxTable {
	#[serde(rename = "TaxTableEntry")]
	pub tax_table_entry: Vec<TaxTableEntry>,
}


// UOMTableEntry ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct UOMTableEntry {
	#[serde(rename = "UnitOfMeasure")]
	pub unit_of_measure: SAFcodeType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
}


// UOMTable ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct UOMTable {
	#[serde(rename = "UOMTableEntry")]
	pub uom_table_entry: Vec<UOMTableEntry>,
}


// AnalysisTypeTableEntry ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AnalysisTypeTableEntry {
	#[serde(rename = "AnalysisType")]
	pub analysis_type: SAFcodeType,
	#[serde(rename = "AnalysisTypeDescription")]
	pub analysis_type_description: SAFlongtextType,
	#[serde(rename = "AnalysisID")]
	pub analysis_id: SAFmiddle1textType,
	#[serde(rename = "AnalysisIDDescription")]
	pub analysis_id_description: SAFlongtextType,
}


// AnalysisTypeTable ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AnalysisTypeTable {
	#[serde(rename = "AnalysisTypeTableEntry")]
	pub analysis_type_table_entry: Vec<AnalysisTypeTableEntry>,
}


// MovementTypeTableEntry ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct MovementTypeTableEntry {
	#[serde(rename = "MovementType")]
	pub movement_type: SAFcodeType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
}


// MovementTypeTable ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct MovementTypeTable {
	#[serde(rename = "MovementTypeTableEntry")]
	pub movement_type_table_entry: Vec<MovementTypeTableEntry>,
}


// Tax ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Tax {
	#[serde(rename = "TaxType")]
	pub tax_type: SAFcodeType,
	#[serde(rename = "TaxCode")]
	pub tax_code: SAFcodeType,
}


// Product ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Product {
	#[serde(rename = "ProductCode")]
	pub product_code: SAFmiddle2textType,
	#[serde(rename = "GoodsServicesID")]
	pub goods_services_id: SAFcodeType,
	#[serde(rename = "ProductGroup")]
	pub product_group: SAFmiddle2textType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "ProductCommodityCode")]
	pub product_commodity_code: SAFmiddle1textType,
	#[serde(rename = "ProductNumberCode")]
	pub product_number_code: SAFmiddle2textType,
	#[serde(rename = "ValuationMethod")]
	pub valuation_method: SAFcodeType,
	#[serde(rename = "UOMBase")]
	pub uom_base: SAFcodeType,
	#[serde(rename = "UOMStandard")]
	pub uom_standard: SAFcodeType,
	#[serde(rename = "UOMToUOMBaseConversionFactor")]
	pub uom_to_uom_base_conversion_factor: f64,
	#[serde(rename = "Tax")]
	pub tax: Vec<Tax>,
}


// Products ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Products {
	#[serde(rename = "Product")]
	pub product: Vec<Product>,
}


// StockCharacteristics ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct StockCharacteristics {
	#[serde(rename = "StockCharacteristic")]
	pub stock_characteristic: SAFshorttextType,
	#[serde(rename = "StockCharacteristicValue")]
	pub stock_characteristic_value: SAFmiddle1textType,
}


// PhysicalStockEntry ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PhysicalStockEntry {
	#[serde(rename = "WarehouseID")]
	pub warehouse_id: SAFmiddle1textType,
	#[serde(rename = "LocationID")]
	pub location_id: SAFshorttextType,
	#[serde(rename = "ProductCode")]
	pub product_code: SAFmiddle2textType,
	#[serde(rename = "StockAccountNo")]
	pub stock_account_no: SAFmiddle2textType,
	#[serde(rename = "ProductType")]
	pub product_type: SAFshorttextType,
	#[serde(rename = "ProductStatus")]
	pub product_status: SAFshorttextType,
	#[serde(rename = "StockAccountCommodityCode")]
	pub stock_account_commodity_code: SAFmiddle1textType,
	#[serde(rename = "OwnerID")]
	pub owner_id: SAFmiddle1textType,
	#[serde(rename = "UOMPhysicalStock")]
	pub uom_physical_stock: SAFcodeType,
	#[serde(rename = "UOMToUOMBaseConversionFactor")]
	pub uom_to_uom_base_conversion_factor: f64,
	#[serde(rename = "UnitPrice")]
	pub unit_price: SAFmonetaryType,
	#[serde(rename = "OpeningStockQuantity")]
	pub opening_stock_quantity: SAFquantityType,
	#[serde(rename = "OpeningStockValue")]
	pub opening_stock_value: SAFmonetaryType,
	#[serde(rename = "ClosingStockQuantity")]
	pub closing_stock_quantity: SAFquantityType,
	#[serde(rename = "ClosingStockValue")]
	pub closing_stock_value: SAFmonetaryType,
	#[serde(rename = "StockCharacteristics")]
	pub stock_characteristics: StockCharacteristics,
}


// PhysicalStock ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PhysicalStock {
	#[serde(rename = "PhysicalStockEntry")]
	pub physical_stock_entry: Vec<PhysicalStockEntry>,
}


// Owner ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Owner {
	#[serde(rename = "CompanyStructure")]
	pub company_structure: CompanyStructure,
	#[serde(rename = "OwnerID")]
	pub owner_id: SAFmiddle1textType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
}


// Owners ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Owners {
	#[serde(rename = "Owner")]
	pub owner: Vec<Owner>,
}


// AssetSupplier ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AssetSupplier {
	#[serde(rename = "SupplierName")]
	pub supplier_name: SAFmiddle2textType,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "PostalAddress")]
	pub postal_address: AddressStructure,
}


// ExtraordinaryDepreciationForPeriod ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ExtraordinaryDepreciationForPeriod {
	#[serde(rename = "ExtraordinaryDepreciationMethod")]
	pub extraordinary_depreciation_method: SAFmiddle1textType,
	#[serde(rename = "ExtraordinaryDepreciationAmountForPeriod")]
	pub extraordinary_depreciation_amount_for_period: SAFmonetaryType,
}


// ExtraordinaryDepreciationsForPeriod ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ExtraordinaryDepreciationsForPeriod {
	#[serde(rename = "ExtraordinaryDepreciationForPeriod")]
	pub extraordinary_depreciation_for_period: Vec<ExtraordinaryDepreciationForPeriod>,
}


// Valuation ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Valuation {
	#[serde(rename = "AssetValuationType")]
	pub asset_valuation_type: SAFshorttextType,
	#[serde(rename = "ValuationClass")]
	pub valuation_class: SAFshorttextType,
	#[serde(rename = "AcquisitionAndProductionCostsBegin")]
	pub acquisition_and_production_costs_begin: SAFmonetaryType,
	#[serde(rename = "AcquisitionAndProductionCostsEnd")]
	pub acquisition_and_production_costs_end: SAFmonetaryType,
	#[serde(rename = "InvestmentSupport")]
	pub investment_support: SAFmonetaryType,
	#[serde(rename = "AssetLifeYear")]
	pub asset_life_year: f64,
	#[serde(rename = "AssetLifeMonth")]
	pub asset_life_month: f64,
	#[serde(rename = "AssetAddition")]
	pub asset_addition: SAFmonetaryType,
	#[serde(rename = "Transfers")]
	pub transfers: SAFmonetaryType,
	#[serde(rename = "AssetDisposal")]
	pub asset_disposal: SAFmonetaryType,
	#[serde(rename = "BookValueBegin")]
	pub book_value_begin: SAFmonetaryType,
	#[serde(rename = "DepreciationMethod")]
	pub depreciation_method: SAFmiddle1textType,
	#[serde(rename = "DepreciationPercentage")]
	pub depreciation_percentage: f64,
	#[serde(rename = "DepreciationForPeriod")]
	pub depreciation_for_period: SAFmonetaryType,
	#[serde(rename = "AppreciationForPeriod")]
	pub appreciation_for_period: SAFmonetaryType,
	#[serde(rename = "ExtraordinaryDepreciationsForPeriod")]
	pub extraordinary_depreciations_for_period: ExtraordinaryDepreciationsForPeriod,
	#[serde(rename = "AccumulatedDepreciation")]
	pub accumulated_depreciation: SAFmonetaryType,
	#[serde(rename = "BookValueEnd")]
	pub book_value_end: SAFmonetaryType,
}


// Valuations ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Valuations {
	#[serde(rename = "Valuation")]
	pub valuation: Vec<Valuation>,
}


// Asset ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Asset {
	#[serde(rename = "AssetID")]
	pub asset_id: SAFmiddle1textType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "AssetSupplier")]
	pub asset_supplier: Vec<AssetSupplier>,
	#[serde(rename = "PurchaseOrderDate")]
	pub purchase_order_date: u8,
	#[serde(rename = "DateOfAcquisition")]
	pub date_of_acquisition: u8,
	#[serde(rename = "StartUpDate")]
	pub start_up_date: u8,
	#[serde(rename = "Valuations")]
	pub valuations: Valuations,
}


// Assets ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Assets {
	#[serde(rename = "Asset")]
	pub asset: Vec<Asset>,
}


// MasterFiles ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct MasterFiles {
	#[serde(rename = "GeneralLedgerAccounts")]
	pub general_ledger_accounts: GeneralLedgerAccounts,
	#[serde(rename = "Taxonomies")]
	pub taxonomies: Taxonomies,
	#[serde(rename = "Customers")]
	pub customers: Customers,
	#[serde(rename = "Suppliers")]
	pub suppliers: Suppliers,
	#[serde(rename = "TaxTable")]
	pub tax_table: TaxTable,
	#[serde(rename = "UOMTable")]
	pub uom_table: UOMTable,
	#[serde(rename = "AnalysisTypeTable")]
	pub analysis_type_table: AnalysisTypeTable,
	#[serde(rename = "MovementTypeTable")]
	pub movement_type_table: MovementTypeTable,
	#[serde(rename = "Products")]
	pub products: Products,
	#[serde(rename = "PhysicalStock")]
	pub physical_stock: PhysicalStock,
	#[serde(rename = "Owners")]
	pub owners: Owners,
	#[serde(rename = "Assets")]
	pub assets: Assets,
}


// ReportLineValues ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ReportLineValues {
	#[serde(rename = "DebitOpeningBalance")]
	pub debit_opening_balance: SAFmonetaryType,
	#[serde(rename = "CreditOpeningBalance")]
	pub credit_opening_balance: SAFmonetaryType,
	#[serde(rename = "DebitTurnover")]
	pub debit_turnover: SAFmonetaryType,
	#[serde(rename = "CreditTurnover")]
	pub credit_turnover: SAFmonetaryType,
	#[serde(rename = "DebitClosingBalance")]
	pub debit_closing_balance: SAFmonetaryType,
	#[serde(rename = "CreditClosingBalance")]
	pub credit_closing_balance: SAFmonetaryType,
}


// ReportLine ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ReportLine {
	#[serde(rename = "LineNo")]
	pub line_no: SAFmiddle2textType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "CorrespondingAccountID")]
	pub corresponding_account_id: SAFmiddle2textType,
	#[serde(rename = "Period")]
	pub period: u32,
	#[serde(rename = "PeriodYear")]
	pub period_year: u32,
	#[serde(rename = "ReportLineValues")]
	pub report_line_values: Vec<ReportLineValues>,
}


// CorrespondingAccountsReportTotals ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CorrespondingAccountsReportTotals {
	#[serde(rename = "TotalDebitOpeningBalance")]
	pub total_debit_opening_balance: SAFmonetaryType,
	#[serde(rename = "TotalCreditOpeningBalance")]
	pub total_credit_opening_balance: SAFmonetaryType,
	#[serde(rename = "TotalDebit")]
	pub total_debit: SAFmonetaryType,
	#[serde(rename = "TotalCredit")]
	pub total_credit: SAFmonetaryType,
	#[serde(rename = "TotalDebitClosingBalance")]
	pub total_debit_closing_balance: SAFmonetaryType,
	#[serde(rename = "TotalCreditClosingBalance")]
	pub total_credit_closing_balance: SAFmonetaryType,
	#[serde(rename = "ReportLine")]
	pub report_line: Vec<ReportLine>,
}


// CorrespondingAccountsReport ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CorrespondingAccountsReport {
	#[serde(rename = "CorrespondingAccountsReportTotals")]
	pub corresponding_accounts_report_totals: CorrespondingAccountsReportTotals,
}


// TransactionLine ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TransactionLine {
	#[serde(rename = "RecordID")]
	pub record_id: SAFshorttextType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "TaxpayerAccountID")]
	pub taxpayer_account_id: SAFmiddle1textType,
	#[serde(rename = "Analysis")]
	pub analysis: Vec<AnalysisStructure>,
	#[serde(rename = "ValueDate")]
	pub value_date: u8,
	#[serde(rename = "SourceDocumentID")]
	pub source_document_id: SAFmiddle1textType,
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "DebitAmount")]
	pub debit_amount: AmountStructure,
	#[serde(rename = "CreditAmount")]
	pub credit_amount: AmountStructure,
	#[serde(rename = "TaxInformation")]
	pub tax_information: Vec<TaxInformationStructure>,
}


// Transaction ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Transaction {
	#[serde(rename = "TransactionID")]
	pub transaction_id: SAFmiddle2textType,
	#[serde(rename = "Period")]
	pub period: u32,
	#[serde(rename = "PeriodYear")]
	pub period_year: u32,
	#[serde(rename = "TransactionDate")]
	pub transaction_date: u8,
	#[serde(rename = "SourceID")]
	pub source_id: SAFmiddle1textType,
	#[serde(rename = "TransactionType")]
	pub transaction_type: SAFshorttextType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "BatchID")]
	pub batch_id: SAFmiddle1textType,
	#[serde(rename = "SystemEntryDate")]
	pub system_entry_date: u8,
	#[serde(rename = "GLPostingDate")]
	pub gl_posting_date: u8,
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "SystemID")]
	pub system_id: SAFshorttextType,
	#[serde(rename = "TransactionLine")]
	pub transaction_line: Vec<TransactionLine>,
}


// Journal ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Journal {
	#[serde(rename = "JournalID")]
	pub journal_id: SAFshorttextType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "Type")]
	pub type_attr: SAFcodeType,
	#[serde(rename = "Transaction")]
	pub transaction: Vec<Transaction>,
}


// GeneralLedgerEntries ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct GeneralLedgerEntries {
	#[serde(rename = "NumberOfEntries")]
	pub number_of_entries: u32,
	#[serde(rename = "TotalDebit")]
	pub total_debit: SAFmonetaryType,
	#[serde(rename = "TotalCredit")]
	pub total_credit: SAFmonetaryType,
	#[serde(rename = "Journal")]
	pub journal: Vec<Journal>,
}


// SalesInvoices ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct SalesInvoices {
	#[serde(rename = "NumberOfEntries")]
	pub number_of_entries: u32,
	#[serde(rename = "TotalDebit")]
	pub total_debit: SAFmonetaryType,
	#[serde(rename = "TotalCredit")]
	pub total_credit: SAFmonetaryType,
	#[serde(rename = "Invoice")]
	pub invoice: Vec<InvoiceStructure>,
}


// PurchaseInvoices ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PurchaseInvoices {
	#[serde(rename = "NumberOfEntries")]
	pub number_of_entries: u32,
	#[serde(rename = "TotalDebit")]
	pub total_debit: SAFmonetaryType,
	#[serde(rename = "TotalCredit")]
	pub total_credit: SAFmonetaryType,
	#[serde(rename = "Invoice")]
	pub invoice: Vec<InvoiceStructure>,
}


// PaymentLine ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PaymentLine {
	#[serde(rename = "LineNumber")]
	pub line_number: SAFshorttextType,
	#[serde(rename = "SourceDocumentID")]
	pub source_document_id: SAFmiddle1textType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "Analysis")]
	pub analysis: Vec<AnalysisStructure>,
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "TaxPointDate")]
	pub tax_point_date: u8,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "DebitCreditIndicator")]
	pub debit_credit_indicator: SAFcodeType,
	#[serde(rename = "PaymentLineAmount")]
	pub payment_line_amount: AmountStructure,
	#[serde(rename = "TaxInformation")]
	pub tax_information: Vec<TaxInformationStructure>,
}


// PaymentSettlement ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PaymentSettlement {
	#[serde(rename = "SettlementDiscount")]
	pub settlement_discount: SAFmiddle1textType,
	#[serde(rename = "SettlementAmount")]
	pub settlement_amount: AmountStructure,
	#[serde(rename = "SettlementDate")]
	pub settlement_date: u8,
	#[serde(rename = "PaymentMechanism")]
	pub payment_mechanism: SAFcodeType,
}


// PaymentDocumentTotals ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PaymentDocumentTotals {
	#[serde(rename = "TaxInformationTotals")]
	pub tax_information_totals: Vec<TaxInformationStructure>,
	#[serde(rename = "NetTotal")]
	pub net_total: SAFmonetaryType,
	#[serde(rename = "GrossTotal")]
	pub gross_total: SAFmonetaryType,
}


// Payment ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Payment {
	#[serde(rename = "PaymentRefNo")]
	pub payment_ref_no: SAFmiddle1textType,
	#[serde(rename = "Period")]
	pub period: u32,
	#[serde(rename = "PeriodYear")]
	pub period_year: u32,
	#[serde(rename = "TransactionID")]
	pub transaction_id: SAFmiddle2textType,
	#[serde(rename = "TransactionDate")]
	pub transaction_date: u8,
	#[serde(rename = "PaymentMethod")]
	pub payment_method: SAFshorttextType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "BatchID")]
	pub batch_id: SAFmiddle1textType,
	#[serde(rename = "SystemID")]
	pub system_id: SAFmiddle1textType,
	#[serde(rename = "SourceID")]
	pub source_id: SAFmiddle1textType,
	#[serde(rename = "PaymentLine")]
	pub payment_line: Vec<PaymentLine>,
	#[serde(rename = "PaymentSettlement")]
	pub payment_settlement: PaymentSettlement,
	#[serde(rename = "PaymentDocumentTotals")]
	pub payment_document_totals: PaymentDocumentTotals,
}


// Payments ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Payments {
	#[serde(rename = "NumberOfEntries")]
	pub number_of_entries: u32,
	#[serde(rename = "TotalDebit")]
	pub total_debit: SAFmonetaryType,
	#[serde(rename = "TotalCredit")]
	pub total_credit: SAFmonetaryType,
	#[serde(rename = "Payment")]
	pub payment: Vec<Payment>,
}


// DocumentReference ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct DocumentReference {
	#[serde(rename = "DocumentType")]
	pub document_type: SAFshorttextType,
	#[serde(rename = "DocumentNumber")]
	pub document_number: SAFmiddle1textType,
	#[serde(rename = "DocumentLine")]
	pub document_line: SAFshorttextType,
}


// StockMovementLine ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct StockMovementLine {
	#[serde(rename = "LineNumber")]
	pub line_number: SAFshorttextType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "TransactionID")]
	pub transaction_id: SAFmiddle2textType,
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "ShipTo")]
	pub ship_to: ShippingPointStructure,
	#[serde(rename = "ShipFrom")]
	pub ship_from: ShippingPointStructure,
	#[serde(rename = "ProductCode")]
	pub product_code: SAFmiddle2textType,
	#[serde(rename = "StockAccountNo")]
	pub stock_account_no: SAFmiddle2textType,
	#[serde(rename = "Quantity")]
	pub quantity: SAFquantityType,
	#[serde(rename = "UnitOfMeasure")]
	pub unit_of_measure: SAFcodeType,
	#[serde(rename = "UOMToUOMPhysicalStockConversionFactor")]
	pub uom_to_uom_physical_stock_conversion_factor: f64,
	#[serde(rename = "BookValue")]
	pub book_value: SAFmonetaryType,
	#[serde(rename = "MovementSubType")]
	pub movement_sub_type: SAFcodeType,
	#[serde(rename = "MovementComments")]
	pub movement_comments: SAFlongtextType,
	#[serde(rename = "TaxInformation")]
	pub tax_information: Vec<TaxInformationStructure>,
}


// StockMovement ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct StockMovement {
	#[serde(rename = "MovementReference")]
	pub movement_reference: SAFmiddle1textType,
	#[serde(rename = "MovementDate")]
	pub movement_date: u8,
	#[serde(rename = "MovementPostingDate")]
	pub movement_posting_date: u8,
	#[serde(rename = "MovementPostingTime")]
	pub movement_posting_time: String,
	#[serde(rename = "TaxPointDate")]
	pub tax_point_date: u8,
	#[serde(rename = "MovementType")]
	pub movement_type: SAFcodeType,
	#[serde(rename = "SourceID")]
	pub source_id: SAFmiddle1textType,
	#[serde(rename = "SystemID")]
	pub system_id: SAFmiddle1textType,
	#[serde(rename = "DocumentReference")]
	pub document_reference: DocumentReference,
	#[serde(rename = "StockMovementLine")]
	pub stock_movement_line: Vec<StockMovementLine>,
}


// MovementOfGoods ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct MovementOfGoods {
	#[serde(rename = "NumberOfMovementLines")]
	pub number_of_movement_lines: u32,
	#[serde(rename = "TotalQuantityReceived")]
	pub total_quantity_received: SAFquantityType,
	#[serde(rename = "TotalQuantityIssued")]
	pub total_quantity_issued: SAFquantityType,
	#[serde(rename = "StockMovement")]
	pub stock_movement: Vec<StockMovement>,
}


// AssetTransactionValuation ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AssetTransactionValuation {
	#[serde(rename = "AssetValuationType")]
	pub asset_valuation_type: SAFshorttextType,
	#[serde(rename = "AcquisitionAndProductionCostsOnTransaction")]
	pub acquisition_and_production_costs_on_transaction: SAFmonetaryType,
	#[serde(rename = "BookValueOnTransaction")]
	pub book_value_on_transaction: SAFmonetaryType,
	#[serde(rename = "AssetTransactionAmount")]
	pub asset_transaction_amount: SAFmonetaryType,
}


// AssetTransactionValuations ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AssetTransactionValuations {
	#[serde(rename = "AssetTransactionValuation")]
	pub asset_transaction_valuation: Vec<AssetTransactionValuation>,
}


// AssetTransaction ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AssetTransaction {
	#[serde(rename = "AssetTransactionID")]
	pub asset_transaction_id: SAFmiddle2textType,
	#[serde(rename = "AssetID")]
	pub asset_id: SAFmiddle1textType,
	#[serde(rename = "AssetTransactionType")]
	pub asset_transaction_type: SAFcodeType,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "AssetTransactionDate")]
	pub asset_transaction_date: u8,
	#[serde(rename = "AssetSupplier")]
	pub asset_supplier: AssetSupplier,
	#[serde(rename = "TransactionID")]
	pub transaction_id: SAFmiddle2textType,
	#[serde(rename = "AssetTransactionValuations")]
	pub asset_transaction_valuations: AssetTransactionValuations,
}


// AssetTransactions ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AssetTransactions {
	#[serde(rename = "NumberOfAssetTransactions")]
	pub number_of_asset_transactions: u32,
	#[serde(rename = "AssetTransaction")]
	pub asset_transaction: Vec<AssetTransaction>,
}


// SourceDocuments ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct SourceDocuments {
	#[serde(rename = "SalesInvoices")]
	pub sales_invoices: SalesInvoices,
	#[serde(rename = "PurchaseInvoices")]
	pub purchase_invoices: PurchaseInvoices,
	#[serde(rename = "Payments")]
	pub payments: Payments,
	#[serde(rename = "MovementOfGoods")]
	pub movement_of_goods: MovementOfGoods,
	#[serde(rename = "AssetTransactions")]
	pub asset_transactions: AssetTransactions,
}


// AuditFile ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AuditFile {
	#[serde(rename = "Header")]
	pub header: Header,
	#[serde(rename = "MasterFiles")]
	pub master_files: MasterFiles,
	#[serde(rename = "CorrespondingAccountsReport")]
	pub corresponding_accounts_report: CorrespondingAccountsReport,
	#[serde(rename = "GeneralLedgerEntries")]
	pub general_ledger_entries: GeneralLedgerEntries,
	#[serde(rename = "SourceDocuments")]
	pub source_documents: SourceDocuments,
}


// debit_credit_indicator is Net amount of related asset transaction in the header’s default currency, for instance the net sale revenue.
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct debit_credit_indicator {
	#[serde(rename = "DebitCreditIndicator")]
	pub debit_credit_indicator: SAFcodeType,
}


// CustomerInfo ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CustomerInfo {
	#[serde(rename = "CustomerID")]
	pub customer_id: SAFmiddle1textType,
	#[serde(rename = "Name")]
	pub name: SAFmiddle2textType,
	#[serde(rename = "BillingAddress")]
	pub billing_address: AddressStructure,
}


// SupplierInfo ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct SupplierInfo {
	#[serde(rename = "SupplierID")]
	pub supplier_id: SAFmiddle1textType,
	#[serde(rename = "Name")]
	pub name: SAFmiddle2textType,
	#[serde(rename = "BillingAddress")]
	pub billing_address: AddressStructure,
}


// OrderReferences ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct OrderReferences {
	#[serde(rename = "OriginatingON")]
	pub originating_on: SAFmiddle2textType,
	#[serde(rename = "OrderDate")]
	pub order_date: u8,
}


// DeliveryPeriod ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct DeliveryPeriod {
	#[serde(rename = "FromDate")]
	pub from_date: u8,
	#[serde(rename = "ToDate")]
	pub to_date: u8,
}


// Delivery ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Delivery {
	#[serde(rename = "MovementReference")]
	pub movement_reference: Vec<SAFmiddle1textType>,
	#[serde(rename = "DeliveryDate")]
	pub delivery_date: u8,
	#[serde(rename = "DeliveryPeriod")]
	pub delivery_period: DeliveryPeriod,
}


// CreditNote ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CreditNote {
	#[serde(rename = "Reference")]
	pub reference: SAFmiddle1textType,
	#[serde(rename = "Reason")]
	pub reason: SAFlongtextType,
}


// References ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct References {
	#[serde(rename = "CreditNote")]
	pub credit_note: CreditNote,
}


// InvoiceLine ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct InvoiceLine {
	#[serde(rename = "LineNumber")]
	pub line_number: SAFshorttextType,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "Analysis")]
	pub analysis: Vec<AnalysisStructure>,
	#[serde(rename = "OrderReferences")]
	pub order_references: Vec<OrderReferences>,
	#[serde(rename = "ShipTo")]
	pub ship_to: ShippingPointStructure,
	#[serde(rename = "ShipFrom")]
	pub ship_from: ShippingPointStructure,
	#[serde(rename = "GoodsServicesID")]
	pub goods_services_id: SAFcodeType,
	#[serde(rename = "ProductCode")]
	pub product_code: SAFmiddle2textType,
	#[serde(rename = "ProductDescription")]
	pub product_description: SAFlongtextType,
	#[serde(rename = "Delivery")]
	pub delivery: Delivery,
	#[serde(rename = "Quantity")]
	pub quantity: SAFquantityType,
	#[serde(rename = "InvoiceUOM")]
	pub invoice_uom: SAFcodeType,
	#[serde(rename = "UOMToUOMBaseConversionFactor")]
	pub uom_to_uom_base_conversion_factor: f64,
	#[serde(rename = "UnitPrice")]
	pub unit_price: SAFmonetaryType,
	#[serde(rename = "TaxPointDate")]
	pub tax_point_date: u8,
	#[serde(rename = "References")]
	pub references: References,
	#[serde(rename = "Description")]
	pub description: SAFlongtextType,
	#[serde(rename = "InvoiceLineAmount")]
	pub invoice_line_amount: AmountStructure,
	#[serde(rename = "DebitCreditIndicator")]
	pub debit_credit_indicator: SAFcodeType,
	#[serde(rename = "ShippingCostsAmount")]
	pub shipping_costs_amount: AmountStructure,
	#[serde(rename = "TaxInformation")]
	pub tax_information: Vec<TaxInformationStructure>,
}


// InvoiceSettlement ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct InvoiceSettlement {
	#[serde(rename = "SettlementDiscount")]
	pub settlement_discount: SAFmiddle1textType,
	#[serde(rename = "SettlementAmount")]
	pub settlement_amount: AmountStructure,
	#[serde(rename = "SettlementDate")]
	pub settlement_date: u8,
	#[serde(rename = "PaymentMechanism")]
	pub payment_mechanism: SAFcodeType,
}


// InvoiceDocumentTotals ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct InvoiceDocumentTotals {
	#[serde(rename = "TaxInformationTotals")]
	pub tax_information_totals: Vec<TaxInformationStructure>,
	#[serde(rename = "ShippingCostsAmountTotal")]
	pub shipping_costs_amount_total: SAFmonetaryType,
	#[serde(rename = "NetTotal")]
	pub net_total: SAFmonetaryType,
	#[serde(rename = "GrossTotal")]
	pub gross_total: SAFmonetaryType,
}


// InvoiceStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct InvoiceStructure {
	#[serde(rename = "InvoiceNo")]
	pub invoice_no: SAFmiddle2textType,
	#[serde(rename = "CustomerInfo")]
	pub customer_info: CustomerInfo,
	#[serde(rename = "SupplierInfo")]
	pub supplier_info: SupplierInfo,
	#[serde(rename = "AccountID")]
	pub account_id: SAFmiddle2textType,
	#[serde(rename = "BranchStoreNumber")]
	pub branch_store_number: SAFmiddle1textType,
	#[serde(rename = "Period")]
	pub period: u32,
	#[serde(rename = "PeriodYear")]
	pub period_year: u32,
	#[serde(rename = "InvoiceDate")]
	pub invoice_date: u8,
	#[serde(rename = "InvoiceType")]
	pub invoice_type: SAFcodeType,
	#[serde(rename = "ShipTo")]
	pub ship_to: ShippingPointStructure,
	#[serde(rename = "ShipFrom")]
	pub ship_from: ShippingPointStructure,
	#[serde(rename = "PaymentTerms")]
	pub payment_terms: SAFmiddle2textType,
	#[serde(rename = "SelfBillingIndicator")]
	pub self_billing_indicator: SAFcodeType,
	#[serde(rename = "SourceID")]
	pub source_id: SAFmiddle1textType,
	#[serde(rename = "GLPostingDate")]
	pub gl_posting_date: u8,
	#[serde(rename = "BatchID")]
	pub batch_id: SAFmiddle1textType,
	#[serde(rename = "SystemID")]
	pub system_id: SAFmiddle1textType,
	#[serde(rename = "TransactionID")]
	pub transaction_id: SAFmiddle2textType,
	#[serde(rename = "ReceiptNumbers")]
	pub receipt_numbers: SAFlongtextType,
	#[serde(rename = "InvoiceLine")]
	pub invoice_line: Vec<InvoiceLine>,
	#[serde(rename = "InvoiceSettlement")]
	pub invoice_settlement: InvoiceSettlement,
	#[serde(rename = "InvoiceDocumentTotals")]
	pub invoice_document_totals: InvoiceDocumentTotals,
}


// ShippingPointStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ShippingPointStructure {
	#[serde(rename = "DeliveryID")]
	pub delivery_id: SAFmiddle1textType,
	#[serde(rename = "DeliveryDate")]
	pub delivery_date: u8,
	#[serde(rename = "WarehouseID")]
	pub warehouse_id: SAFmiddle1textType,
	#[serde(rename = "LocationID")]
	pub location_id: SAFshorttextType,
	#[serde(rename = "UCR")]
	pub ucr: SAFmiddle1textType,
	#[serde(rename = "Address")]
	pub address: AddressStructure,
}


// AddressStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AddressStructure {
	#[serde(rename = "StreetName")]
	pub street_name: SAFmiddle2textType,
	#[serde(rename = "Number")]
	pub number: SAFshorttextType,
	#[serde(rename = "AdditionalAddressDetail")]
	pub additional_address_detail: SAFmiddle2textType,
	#[serde(rename = "Building")]
	pub building: SAFmiddle1textType,
	#[serde(rename = "City")]
	pub city: SAFmiddle1textType,
	#[serde(rename = "PostalCode")]
	pub postal_code: SAFshorttextType,
	#[serde(rename = "Region")]
	pub region: SAFmiddle1textType,
	#[serde(rename = "Country")]
	pub country: ISOCountryCode,
	#[serde(rename = "AddressType")]
	pub address_type: String,
}


// GroupIdentification ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct GroupIdentification {
	#[serde(rename = "GroupNameCyrillic")]
	pub group_name_cyrillic: SAFmiddle2textType,
	#[serde(rename = "GroupNameLatin")]
	pub group_name_latin: SAFmiddle2textType,
	#[serde(rename = "Country")]
	pub country: ISOCountryCode,
}


// DirectOwnerIdentification ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct DirectOwnerIdentification {
	#[serde(rename = "OwnerNameCyrillic")]
	pub owner_name_cyrillic: SAFmiddle2textType,
	#[serde(rename = "LegalFormCyrillic")]
	pub legal_form_cyrillic: SAFmiddle2textType,
	#[serde(rename = "OwnerNameLatin")]
	pub owner_name_latin: SAFmiddle2textType,
	#[serde(rename = "LegalFormLatin")]
	pub legal_form_latin: SAFmiddle2textType,
	#[serde(rename = "OwnerCountry")]
	pub owner_country: ISOCountryCode,
	#[serde(rename = "OwnerUIC")]
	pub owner_uic: SAFmiddle1textType,
	#[serde(rename = "OwnershipPercentage")]
	pub ownership_percentage: f64,
}


// UltimateOwnerIdentificationBG ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct UltimateOwnerIdentificationBG {
	#[serde(rename = "UltimateOwnerNameCyrillicBG")]
	pub ultimate_owner_name_cyrillic_bg: SAFmiddle2textType,
	#[serde(rename = "UltimateOwnerUICBG")]
	pub ultimate_owner_uicbg: SAFmiddle1textType,
	#[serde(rename = "UltimateOwnerEGNBG")]
	pub ultimate_owner_egnbg: SAFmiddle1textType,
}


// UltimateOwnerIdentificationForeign ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct UltimateOwnerIdentificationForeign {
	#[serde(rename = "UltimateOwnerNameCyrillicForeign")]
	pub ultimate_owner_name_cyrillic_foreign: SAFmiddle2textType,
	#[serde(rename = "UltimateOwnerNameLatinForeign")]
	pub ultimate_owner_name_latin_foreign: SAFmiddle2textType,
	#[serde(rename = "CountryForeign")]
	pub country_foreign: ISOCountryCode,
}


// OwnershipStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct OwnershipStructure {
	#[serde(rename = "IsPartOfGroup")]
	pub is_part_of_group: SAFmiddle1textType,
	#[serde(rename = "UltimateOwnerNameCyrillic")]
	pub ultimate_owner_name_cyrillic: SAFmiddle2textType,
	#[serde(rename = "UltimateOwnerNameLatin")]
	pub ultimate_owner_name_latin: SAFmiddle2textType,
	#[serde(rename = "UltimateOwnerUIC")]
	pub ultimate_owner_uic: SAFmiddle1textType,
	#[serde(rename = "UltimateOwnerEGN")]
	pub ultimate_owner_egn: SAFmiddle1textType,
	#[serde(rename = "GroupIdentification")]
	pub group_identification: GroupIdentification,
	#[serde(rename = "DirectOwnerIdentification")]
	pub direct_owner_identification: DirectOwnerIdentification,
	#[serde(rename = "UltimateOwnerIdentificationBG")]
	pub ultimate_owner_identification_bg: UltimateOwnerIdentificationBG,
	#[serde(rename = "UltimateOwnerIdentificationForeign")]
	pub ultimate_owner_identification_foreign: UltimateOwnerIdentificationForeign,
}


// AmountStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AmountStructure {
	#[serde(rename = "Amount")]
	pub amount: SAFmonetaryType,
	#[serde(rename = "CurrencyCode")]
	pub currency_code: ISOCurrencyCode,
	#[serde(rename = "CurrencyAmount")]
	pub currency_amount: SAFmonetaryType,
	#[serde(rename = "ExchangeRate")]
	pub exchange_rate: SAFexchangerateType,
}


// AnalysisStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct AnalysisStructure {
	#[serde(rename = "AnalysisType")]
	pub analysis_type: SAFcodeType,
	#[serde(rename = "AnalysisID")]
	pub analysis_id: SAFlongtextType,
	#[serde(rename = "AnalysisAmount")]
	pub analysis_amount: AmountStructure,
}


// BankAccountStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct BankAccountStructure {
	#[serde(rename = "IBANNumber")]
	pub iban_number: SAFmiddle1textType,
	#[serde(rename = "BankAccountNumber")]
	pub bank_account_number: SAFmiddle1textType,
	#[serde(rename = "BankAccountName")]
	pub bank_account_name: SAFmiddle2textType,
	#[serde(rename = "SortCode")]
	pub sort_code: SAFshorttextType,
}


// CompanyHeaderStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CompanyHeaderStructure {
	#[serde(rename = "RegistrationNumber")]
	pub registration_number: SAFmiddle1textType,
	#[serde(rename = "Name")]
	pub name: SAFmiddle2textType,
	#[serde(rename = "NameLatin")]
	pub name_latin: SAFmiddle2textType,
	#[serde(rename = "Address")]
	pub address: Vec<AddressStructure>,
	#[serde(rename = "Contact")]
	pub contact: Vec<ContactInformationStructure>,
	#[serde(rename = "TaxRegistration")]
	pub tax_registration: Vec<TaxIDStructure>,
	#[serde(rename = "BankAccount")]
	pub bank_account: Vec<BankAccountStructure>,
	#[serde(rename = "RelatedParty")]
	pub related_party: SAFshorttextType,
	#[serde(rename = "RelatedPartyStartDate")]
	pub related_party_start_date: u8,
	#[serde(rename = "RelatedParty")]
	pub related_party: SAFshorttextType,
}


// CompanyStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct CompanyStructure {
	#[serde(rename = "RegistrationNumber")]
	pub registration_number: SAFmiddle1textType,
	#[serde(rename = "Name")]
	pub name: SAFmiddle2textType,
	#[serde(rename = "NameLatin")]
	pub name_latin: SAFmiddle2textType,
	#[serde(rename = "Address")]
	pub address: Vec<AddressStructure>,
	#[serde(rename = "Contact")]
	pub contact: Vec<ContactInformationStructure>,
	#[serde(rename = "TaxRegistration")]
	pub tax_registration: Vec<TaxIDStructure>,
	#[serde(rename = "BankAccount")]
	pub bank_account: Vec<BankAccountStructure>,
	#[serde(rename = "RelatedParty")]
	pub related_party: RelatedParty,
	#[serde(rename = "RelatedPartyStartDate")]
	pub related_party_start_date: u8,
	#[serde(rename = "RelatedPartyEndDate")]
	pub related_party_end_date: u8,
}


// ContactHeaderStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ContactHeaderStructure {
	#[serde(rename = "ContactPerson")]
	pub contact_person: PersonNameStructure,
	#[serde(rename = "Telephone")]
	pub telephone: SAFshorttextType,
	#[serde(rename = "Fax")]
	pub fax: SAFshorttextType,
	#[serde(rename = "Email")]
	pub email: SAFmiddle2textType,
	#[serde(rename = "RelatedParty")]
	pub related_party: RelatedParty,
}


// ContactInformationStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct ContactInformationStructure {
	#[serde(rename = "ContactPerson")]
	pub contact_person: PersonNameStructure,
	#[serde(rename = "Telephone")]
	pub telephone: SAFshorttextType,
	#[serde(rename = "Fax")]
	pub fax: SAFshorttextType,
	#[serde(rename = "Email")]
	pub email: SAFmiddle2textType,
	#[serde(rename = "Website")]
	pub website: String,
}


// HeaderStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct HeaderStructure {
	#[serde(rename = "AuditFileVersion")]
	pub audit_file_version: SAFcodeType,
	#[serde(rename = "AuditFileCountry")]
	pub audit_file_country: ISOCountryCode,
	#[serde(rename = "AuditFileRegion")]
	pub audit_file_region: SAFcodeType,
	#[serde(rename = "AuditFileDateCreated")]
	pub audit_file_date_created: u8,
	#[serde(rename = "SoftwareCompanyName")]
	pub software_company_name: SAFmiddle2textType,
	#[serde(rename = "SoftwareID")]
	pub software_id: SAFlongtextType,
	#[serde(rename = "SoftwareVersion")]
	pub software_version: SAFshorttextType,
	#[serde(rename = "Company")]
	pub company: CompanyHeaderStructure,
	#[serde(rename = "Ownership")]
	pub ownership: OwnershipStructure,
	#[serde(rename = "DefaultCurrencyCode")]
	pub default_currency_code: ISOCurrencyCode,
	#[serde(rename = "SelectionCriteria")]
	pub selection_criteria: SelectionCriteriaStructure,
	#[serde(rename = "HeaderComment")]
	pub header_comment: SAFlongtextType,
	#[serde(rename = "SegmentIndex")]
	pub segment_index: SAFcodeType,
	#[serde(rename = "TotalSegmentsInsequence")]
	pub total_segments_insequence: SAFcodeType,
}


// PersonNameStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct PersonNameStructure {
	#[serde(rename = "Title")]
	pub title: SAFcodeType,
	#[serde(rename = "FirstName")]
	pub first_name: SAFmiddle1textType,
	#[serde(rename = "Initials")]
	pub initials: SAFshorttextType,
	#[serde(rename = "LastNamePrefix")]
	pub last_name_prefix: SAFshorttextType,
	#[serde(rename = "LastName")]
	pub last_name: SAFmiddle2textType,
	#[serde(rename = "BirthName")]
	pub birth_name: SAFmiddle2textType,
	#[serde(rename = "Salutation")]
	pub salutation: SAFshorttextType,
	#[serde(rename = "OtherTitles")]
	pub other_titles: Vec<SAFshorttextType>,
}


// SelectionCriteriaStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct SelectionCriteriaStructure {
	#[serde(rename = "TaxReportingJurisdiction")]
	pub tax_reporting_jurisdiction: SAFmiddle1textType,
	#[serde(rename = "CompanyEntity")]
	pub company_entity: SAFmiddle2textType,
	#[serde(rename = "SelectionStartDate")]
	pub selection_start_date: u8,
	#[serde(rename = "SelectionEndDate")]
	pub selection_end_date: u8,
	#[serde(rename = "PeriodStart")]
	pub period_start: u32,
	#[serde(rename = "PeriodStartYear")]
	pub period_start_year: u32,
	#[serde(rename = "PeriodEnd")]
	pub period_end: u32,
	#[serde(rename = "PeriodEndYear")]
	pub period_end_year: u32,
	#[serde(rename = "DocumentType")]
	pub document_type: SAFlongtextType,
	#[serde(rename = "OtherCriteria")]
	pub other_criteria: Vec<SAFlongtextType>,
}


// TaxIDStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxIDStructure {
	#[serde(rename = "TaxRegistrationNumber")]
	pub tax_registration_number: SAFmiddle1textType,
	#[serde(rename = "TaxType")]
	pub tax_type: SAFcodeType,
	#[serde(rename = "TaxNumber")]
	pub tax_number: SAFmiddle1textType,
	#[serde(rename = "TaxAuthority")]
	pub tax_authority: SAFmiddle1textType,
	#[serde(rename = "TaxVerificationDate")]
	pub tax_verification_date: u8,
}


// TaxInformationStructure ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct TaxInformationStructure {
	#[serde(rename = "TaxType")]
	pub tax_type: SAFcodeType,
	#[serde(rename = "TaxCode")]
	pub tax_code: SAFcodeType,
	#[serde(rename = "TaxPercentage")]
	pub tax_percentage: f64,
	#[serde(rename = "TaxBase")]
	pub tax_base: f64,
	#[serde(rename = "TaxBaseDescription")]
	pub tax_base_description: SAFmiddle2textType,
	#[serde(rename = "TaxAmount")]
	pub tax_amount: AmountStructure,
	#[serde(rename = "TaxExemptionReason")]
	pub tax_exemption_reason: SAFmiddle2textType,
	#[serde(rename = "TaxDeclarationPeriod")]
	pub tax_declaration_period: SAFmiddle1textType,
}


// Date ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Date {
	#[serde(rename = "Date")]
	pub date: u8,
}


// Decimal ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Decimal {
	#[serde(rename = "Decimal")]
	pub decimal: f64,
}


// Time ...
#[derive(Debug, Deserialize, Serialize, PartialEq)]
pub struct Time {
	#[serde(rename = "Time")]
	pub time: String,
}
