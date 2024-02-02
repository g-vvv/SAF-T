package bg.saft.schema;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.bind.annotation.XmlValue;

// Header ...
public class Header extends HeaderStructure  {
	@XmlElement(required = true, name = "TaxAccountingBasis")
	protected SAFshorttextType TaxAccountingBasis;
	@XmlElement(required = true, name = "TaxEntity")
	protected SAFmiddle2textType TaxEntity;
}

// Account ...
public class Account {
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "AccountDescription")
	protected SAFlongtextType AccountDescription;
	@XmlElement(required = true, name = "TaxpayerAccountID")
	protected SAFmiddle1textType TaxpayerAccountID;
	@XmlElement(required = true, name = "GroupingCategory")
	protected SAFmiddle1textType GroupingCategory;
	@XmlElement(required = true, name = "GroupingCode")
	protected SAFmiddle1textType GroupingCode;
	@XmlElement(required = true, name = "AccountType")
	protected SAFshorttextType AccountType;
	@XmlElement(required = true, name = "AccountCreationDate")
	protected String AccountCreationDate;
	@XmlElement(required = true, name = "OpeningDebitBalance")
	protected SAFmonetaryType OpeningDebitBalance;
	@XmlElement(required = true, name = "OpeningCreditBalance")
	protected SAFmonetaryType OpeningCreditBalance;
	@XmlElement(required = true, name = "ClosingDebitBalance")
	protected SAFmonetaryType ClosingDebitBalance;
	@XmlElement(required = true, name = "ClosingCreditBalance")
	protected SAFmonetaryType ClosingCreditBalance;
}

// GeneralLedgerAccounts ...
public class GeneralLedgerAccounts {
	@XmlElement(required = true, name = "Account")
	protected List<Account> Account;
}

// TaxonomyElement ...
public class TaxonomyElement {
	@XmlElement(required = true, name = "TaxonomyCode")
	protected SAFlongtextType TaxonomyCode;
	@XmlElement(required = true, name = "TaxonomyClusterID")
	protected SAFlongtextType TaxonomyClusterID;
	@XmlElement(required = true, name = "TaxonomyClusterContextID")
	protected SAFlongtextType TaxonomyClusterContextID;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
}

// Taxonomy ...
public class Taxonomy {
	@XmlElement(required = true, name = "TaxonomyReference")
	protected SAFlongtextType TaxonomyReference;
	@XmlElement(required = true, name = "TaxonomyElement")
	protected List<TaxonomyElement> TaxonomyElement;
}

// Taxonomies ...
public class Taxonomies {
	@XmlElement(required = true, name = "Taxonomy")
	protected List<Taxonomy> Taxonomy;
}

// Customer ...
public class Customer {
	@XmlElement(required = true, name = "CompanyStructure")
	protected CompanyStructure CompanyStructure;
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "SelfBillingIndicator")
	protected SAFcodeType SelfBillingIndicator;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "OpeningDebitBalance")
	protected SAFmonetaryType OpeningDebitBalance;
	@XmlElement(required = true, name = "OpeningCreditBalance")
	protected SAFmonetaryType OpeningCreditBalance;
	@XmlElement(required = true, name = "ClosingDebitBalance")
	protected SAFmonetaryType ClosingDebitBalance;
	@XmlElement(required = true, name = "ClosingCreditBalance")
	protected SAFmonetaryType ClosingCreditBalance;
}

// Customers ...
public class Customers {
	@XmlElement(required = true, name = "Customer")
	protected List<Customer> Customer;
}

// Supplier ...
public class Supplier {
	@XmlElement(required = true, name = "CompanyStructure")
	protected CompanyStructure CompanyStructure;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "SelfBillingIndicator")
	protected SAFcodeType SelfBillingIndicator;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "OpeningDebitBalance")
	protected SAFmonetaryType OpeningDebitBalance;
	@XmlElement(required = true, name = "OpeningCreditBalance")
	protected SAFmonetaryType OpeningCreditBalance;
	@XmlElement(required = true, name = "ClosingDebitBalance")
	protected SAFmonetaryType ClosingDebitBalance;
	@XmlElement(required = true, name = "ClosingCreditBalance")
	protected SAFmonetaryType ClosingCreditBalance;
}

// Suppliers ...
public class Suppliers {
	@XmlElement(required = true, name = "Supplier")
	protected List<Supplier> Supplier;
}

// TaxCodeDetails ...
public class TaxCodeDetails {
	@XmlElement(required = true, name = "TaxCode")
	protected SAFcodeType TaxCode;
	@XmlElement(required = true, name = "EffectiveDate")
	protected String EffectiveDate;
	@XmlElement(required = true, name = "ExpirationDate")
	protected String ExpirationDate;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "TaxPercentage")
	protected Float TaxPercentage;
	@XmlElement(required = true, name = "FlatTaxRate")
	protected AmountStructure FlatTaxRate;
	@XmlElement(required = true, name = "BaseRate")
	protected List<SAFBaseRate> BaseRate;
	@XmlElement(required = true, name = "Country")
	protected ISOCountryCode Country;
	@XmlElement(required = true, name = "Region")
	protected SAFcodeType Region;
}

// TaxTableEntry ...
public class TaxTableEntry {
	@XmlElement(required = true, name = "TaxType")
	protected SAFcodeType TaxType;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "TaxCodeDetails")
	protected List<TaxCodeDetails> TaxCodeDetails;
}

// TaxTable ...
public class TaxTable {
	@XmlElement(required = true, name = "TaxTableEntry")
	protected List<TaxTableEntry> TaxTableEntry;
}

// UOMTableEntry ...
public class UOMTableEntry {
	@XmlElement(required = true, name = "UnitOfMeasure")
	protected SAFcodeType UnitOfMeasure;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
}

// UOMTable ...
public class UOMTable {
	@XmlElement(required = true, name = "UOMTableEntry")
	protected List<UOMTableEntry> UOMTableEntry;
}

// AnalysisTypeTableEntry ...
public class AnalysisTypeTableEntry {
	@XmlElement(required = true, name = "AnalysisType")
	protected SAFcodeType AnalysisType;
	@XmlElement(required = true, name = "AnalysisTypeDescription")
	protected SAFlongtextType AnalysisTypeDescription;
	@XmlElement(required = true, name = "AnalysisID")
	protected SAFmiddle1textType AnalysisID;
	@XmlElement(required = true, name = "AnalysisIDDescription")
	protected SAFlongtextType AnalysisIDDescription;
}

// AnalysisTypeTable ...
public class AnalysisTypeTable {
	@XmlElement(required = true, name = "AnalysisTypeTableEntry")
	protected List<AnalysisTypeTableEntry> AnalysisTypeTableEntry;
}

// MovementTypeTableEntry ...
public class MovementTypeTableEntry {
	@XmlElement(required = true, name = "MovementType")
	protected SAFcodeType MovementType;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
}

// MovementTypeTable ...
public class MovementTypeTable {
	@XmlElement(required = true, name = "MovementTypeTableEntry")
	protected List<MovementTypeTableEntry> MovementTypeTableEntry;
}

// Tax ...
public class Tax {
	@XmlElement(required = true, name = "TaxType")
	protected SAFcodeType TaxType;
	@XmlElement(required = true, name = "TaxCode")
	protected SAFcodeType TaxCode;
}

// Product ...
public class Product {
	@XmlElement(required = true, name = "ProductCode")
	protected SAFmiddle2textType ProductCode;
	@XmlElement(required = true, name = "GoodsServicesID")
	protected SAFcodeType GoodsServicesID;
	@XmlElement(required = true, name = "ProductGroup")
	protected SAFmiddle2textType ProductGroup;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "ProductCommodityCode")
	protected SAFmiddle1textType ProductCommodityCode;
	@XmlElement(required = true, name = "ProductNumberCode")
	protected SAFmiddle2textType ProductNumberCode;
	@XmlElement(required = true, name = "ValuationMethod")
	protected SAFcodeType ValuationMethod;
	@XmlElement(required = true, name = "UOMBase")
	protected SAFcodeType UOMBase;
	@XmlElement(required = true, name = "UOMStandard")
	protected SAFcodeType UOMStandard;
	@XmlElement(required = true, name = "UOMToUOMBaseConversionFactor")
	protected Float UOMToUOMBaseConversionFactor;
	@XmlElement(required = true, name = "Tax")
	protected List<Tax> Tax;
}

// Products ...
public class Products {
	@XmlElement(required = true, name = "Product")
	protected List<Product> Product;
}

// StockCharacteristics ...
public class StockCharacteristics {
	@XmlElement(required = true, name = "StockCharacteristic")
	protected SAFshorttextType StockCharacteristic;
	@XmlElement(required = true, name = "StockCharacteristicValue")
	protected SAFmiddle1textType StockCharacteristicValue;
}

// PhysicalStockEntry ...
public class PhysicalStockEntry {
	@XmlElement(required = true, name = "WarehouseID")
	protected SAFmiddle1textType WarehouseID;
	@XmlElement(required = true, name = "LocationID")
	protected SAFshorttextType LocationID;
	@XmlElement(required = true, name = "ProductCode")
	protected SAFmiddle2textType ProductCode;
	@XmlElement(required = true, name = "StockAccountNo")
	protected SAFmiddle2textType StockAccountNo;
	@XmlElement(required = true, name = "ProductType")
	protected SAFshorttextType ProductType;
	@XmlElement(required = true, name = "ProductStatus")
	protected SAFshorttextType ProductStatus;
	@XmlElement(required = true, name = "StockAccountCommodityCode")
	protected SAFmiddle1textType StockAccountCommodityCode;
	@XmlElement(required = true, name = "OwnerID")
	protected SAFmiddle1textType OwnerID;
	@XmlElement(required = true, name = "UOMPhysicalStock")
	protected SAFcodeType UOMPhysicalStock;
	@XmlElement(required = true, name = "UOMToUOMBaseConversionFactor")
	protected Float UOMToUOMBaseConversionFactor;
	@XmlElement(required = true, name = "UnitPrice")
	protected SAFmonetaryType UnitPrice;
	@XmlElement(required = true, name = "OpeningStockQuantity")
	protected SAFquantityType OpeningStockQuantity;
	@XmlElement(required = true, name = "OpeningStockValue")
	protected SAFmonetaryType OpeningStockValue;
	@XmlElement(required = true, name = "ClosingStockQuantity")
	protected SAFquantityType ClosingStockQuantity;
	@XmlElement(required = true, name = "ClosingStockValue")
	protected SAFmonetaryType ClosingStockValue;
	@XmlElement(required = true, name = "StockCharacteristics")
	protected StockCharacteristics StockCharacteristics;
}

// PhysicalStock ...
public class PhysicalStock {
	@XmlElement(required = true, name = "PhysicalStockEntry")
	protected List<PhysicalStockEntry> PhysicalStockEntry;
}

// Owner ...
public class Owner {
	@XmlElement(required = true, name = "CompanyStructure")
	protected CompanyStructure CompanyStructure;
	@XmlElement(required = true, name = "OwnerID")
	protected SAFmiddle1textType OwnerID;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
}

// Owners ...
public class Owners {
	@XmlElement(required = true, name = "Owner")
	protected List<Owner> Owner;
}

// AssetSupplier ...
public class AssetSupplier {
	@XmlElement(required = true, name = "SupplierName")
	protected SAFmiddle2textType SupplierName;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "PostalAddress")
	protected AddressStructure PostalAddress;
}

// ExtraordinaryDepreciationForPeriod ...
public class ExtraordinaryDepreciationForPeriod {
	@XmlElement(required = true, name = "ExtraordinaryDepreciationMethod")
	protected SAFmiddle1textType ExtraordinaryDepreciationMethod;
	@XmlElement(required = true, name = "ExtraordinaryDepreciationAmountForPeriod")
	protected SAFmonetaryType ExtraordinaryDepreciationAmountForPeriod;
}

// ExtraordinaryDepreciationsForPeriod ...
public class ExtraordinaryDepreciationsForPeriod {
	@XmlElement(required = true, name = "ExtraordinaryDepreciationForPeriod")
	protected List<ExtraordinaryDepreciationForPeriod> ExtraordinaryDepreciationForPeriod;
}

// Valuation ...
public class Valuation {
	@XmlElement(required = true, name = "AssetValuationType")
	protected SAFshorttextType AssetValuationType;
	@XmlElement(required = true, name = "ValuationClass")
	protected SAFshorttextType ValuationClass;
	@XmlElement(required = true, name = "AcquisitionAndProductionCostsBegin")
	protected SAFmonetaryType AcquisitionAndProductionCostsBegin;
	@XmlElement(required = true, name = "AcquisitionAndProductionCostsEnd")
	protected SAFmonetaryType AcquisitionAndProductionCostsEnd;
	@XmlElement(required = true, name = "InvestmentSupport")
	protected SAFmonetaryType InvestmentSupport;
	@XmlElement(required = true, name = "AssetLifeYear")
	protected Float AssetLifeYear;
	@XmlElement(required = true, name = "AssetLifeMonth")
	protected Float AssetLifeMonth;
	@XmlElement(required = true, name = "AssetAddition")
	protected SAFmonetaryType AssetAddition;
	@XmlElement(required = true, name = "Transfers")
	protected SAFmonetaryType Transfers;
	@XmlElement(required = true, name = "AssetDisposal")
	protected SAFmonetaryType AssetDisposal;
	@XmlElement(required = true, name = "BookValueBegin")
	protected SAFmonetaryType BookValueBegin;
	@XmlElement(required = true, name = "DepreciationMethod")
	protected SAFmiddle1textType DepreciationMethod;
	@XmlElement(required = true, name = "DepreciationPercentage")
	protected Float DepreciationPercentage;
	@XmlElement(required = true, name = "DepreciationForPeriod")
	protected SAFmonetaryType DepreciationForPeriod;
	@XmlElement(required = true, name = "AppreciationForPeriod")
	protected SAFmonetaryType AppreciationForPeriod;
	@XmlElement(required = true, name = "ExtraordinaryDepreciationsForPeriod")
	protected ExtraordinaryDepreciationsForPeriod ExtraordinaryDepreciationsForPeriod;
	@XmlElement(required = true, name = "AccumulatedDepreciation")
	protected SAFmonetaryType AccumulatedDepreciation;
	@XmlElement(required = true, name = "BookValueEnd")
	protected SAFmonetaryType BookValueEnd;
}

// Valuations ...
public class Valuations {
	@XmlElement(required = true, name = "Valuation")
	protected List<Valuation> Valuation;
}

// Asset ...
public class Asset {
	@XmlElement(required = true, name = "AssetID")
	protected SAFmiddle1textType AssetID;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "AssetSupplier")
	protected List<AssetSupplier> AssetSupplier;
	@XmlElement(required = true, name = "PurchaseOrderDate")
	protected String PurchaseOrderDate;
	@XmlElement(required = true, name = "DateOfAcquisition")
	protected String DateOfAcquisition;
	@XmlElement(required = true, name = "StartUpDate")
	protected String StartUpDate;
	@XmlElement(required = true, name = "Valuations")
	protected Valuations Valuations;
}

// Assets ...
public class Assets {
	@XmlElement(required = true, name = "Asset")
	protected List<Asset> Asset;
}

// MasterFiles ...
public class MasterFiles {
	@XmlElement(required = true, name = "GeneralLedgerAccounts")
	protected GeneralLedgerAccounts GeneralLedgerAccounts;
	@XmlElement(required = true, name = "Taxonomies")
	protected Taxonomies Taxonomies;
	@XmlElement(required = true, name = "Customers")
	protected Customers Customers;
	@XmlElement(required = true, name = "Suppliers")
	protected Suppliers Suppliers;
	@XmlElement(required = true, name = "TaxTable")
	protected TaxTable TaxTable;
	@XmlElement(required = true, name = "UOMTable")
	protected UOMTable UOMTable;
	@XmlElement(required = true, name = "AnalysisTypeTable")
	protected AnalysisTypeTable AnalysisTypeTable;
	@XmlElement(required = true, name = "MovementTypeTable")
	protected MovementTypeTable MovementTypeTable;
	@XmlElement(required = true, name = "Products")
	protected Products Products;
	@XmlElement(required = true, name = "PhysicalStock")
	protected PhysicalStock PhysicalStock;
	@XmlElement(required = true, name = "Owners")
	protected Owners Owners;
	@XmlElement(required = true, name = "Assets")
	protected Assets Assets;
}

// ReportLineValues ...
public class ReportLineValues {
	@XmlElement(required = true, name = "DebitOpeningBalance")
	protected SAFmonetaryType DebitOpeningBalance;
	@XmlElement(required = true, name = "CreditOpeningBalance")
	protected SAFmonetaryType CreditOpeningBalance;
	@XmlElement(required = true, name = "DebitTurnover")
	protected SAFmonetaryType DebitTurnover;
	@XmlElement(required = true, name = "CreditTurnover")
	protected SAFmonetaryType CreditTurnover;
	@XmlElement(required = true, name = "DebitClosingBalance")
	protected SAFmonetaryType DebitClosingBalance;
	@XmlElement(required = true, name = "CreditClosingBalance")
	protected SAFmonetaryType CreditClosingBalance;
}

// ReportLine ...
public class ReportLine {
	@XmlElement(required = true, name = "LineNo")
	protected SAFmiddle2textType LineNo;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "CorrespondingAccountID")
	protected SAFmiddle2textType CorrespondingAccountID;
	@XmlElement(required = true, name = "Period")
	protected Integer Period;
	@XmlElement(required = true, name = "PeriodYear")
	protected Integer PeriodYear;
	@XmlElement(required = true, name = "ReportLineValues")
	protected List<ReportLineValues> ReportLineValues;
}

// CorrespondingAccountsReportTotals ...
public class CorrespondingAccountsReportTotals {
	@XmlElement(required = true, name = "TotalDebitOpeningBalance")
	protected SAFmonetaryType TotalDebitOpeningBalance;
	@XmlElement(required = true, name = "TotalCreditOpeningBalance")
	protected SAFmonetaryType TotalCreditOpeningBalance;
	@XmlElement(required = true, name = "TotalDebit")
	protected SAFmonetaryType TotalDebit;
	@XmlElement(required = true, name = "TotalCredit")
	protected SAFmonetaryType TotalCredit;
	@XmlElement(required = true, name = "TotalDebitClosingBalance")
	protected SAFmonetaryType TotalDebitClosingBalance;
	@XmlElement(required = true, name = "TotalCreditClosingBalance")
	protected SAFmonetaryType TotalCreditClosingBalance;
	@XmlElement(required = true, name = "ReportLine")
	protected List<ReportLine> ReportLine;
}

// CorrespondingAccountsReport ...
public class CorrespondingAccountsReport {
	@XmlElement(required = true, name = "CorrespondingAccountsReportTotals")
	protected CorrespondingAccountsReportTotals CorrespondingAccountsReportTotals;
}

// TransactionLine ...
public class TransactionLine {
	@XmlElement(required = true, name = "RecordID")
	protected SAFshorttextType RecordID;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "TaxpayerAccountID")
	protected SAFmiddle1textType TaxpayerAccountID;
	@XmlElement(required = true, name = "Analysis")
	protected List<AnalysisStructure> Analysis;
	@XmlElement(required = true, name = "ValueDate")
	protected String ValueDate;
	@XmlElement(required = true, name = "SourceDocumentID")
	protected SAFmiddle1textType SourceDocumentID;
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "DebitAmount")
	protected AmountStructure DebitAmount;
	@XmlElement(required = true, name = "CreditAmount")
	protected AmountStructure CreditAmount;
	@XmlElement(required = true, name = "TaxInformation")
	protected List<TaxInformationStructure> TaxInformation;
}

// Transaction ...
public class Transaction {
	@XmlElement(required = true, name = "TransactionID")
	protected SAFmiddle2textType TransactionID;
	@XmlElement(required = true, name = "Period")
	protected Integer Period;
	@XmlElement(required = true, name = "PeriodYear")
	protected Integer PeriodYear;
	@XmlElement(required = true, name = "TransactionDate")
	protected String TransactionDate;
	@XmlElement(required = true, name = "SourceID")
	protected SAFmiddle1textType SourceID;
	@XmlElement(required = true, name = "TransactionType")
	protected SAFshorttextType TransactionType;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "BatchID")
	protected SAFmiddle1textType BatchID;
	@XmlElement(required = true, name = "SystemEntryDate")
	protected String SystemEntryDate;
	@XmlElement(required = true, name = "GLPostingDate")
	protected String GLPostingDate;
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "SystemID")
	protected SAFshorttextType SystemID;
	@XmlElement(required = true, name = "TransactionLine")
	protected List<TransactionLine> TransactionLine;
}

// Journal ...
public class Journal {
	@XmlElement(required = true, name = "JournalID")
	protected SAFshorttextType JournalID;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "Type")
	protected SAFcodeType Type;
	@XmlElement(required = true, name = "Transaction")
	protected List<Transaction> Transaction;
}

// GeneralLedgerEntries ...
public class GeneralLedgerEntries {
	@XmlElement(required = true, name = "NumberOfEntries")
	protected Integer NumberOfEntries;
	@XmlElement(required = true, name = "TotalDebit")
	protected SAFmonetaryType TotalDebit;
	@XmlElement(required = true, name = "TotalCredit")
	protected SAFmonetaryType TotalCredit;
	@XmlElement(required = true, name = "Journal")
	protected List<Journal> Journal;
}

// SalesInvoices ...
public class SalesInvoices {
	@XmlElement(required = true, name = "NumberOfEntries")
	protected Integer NumberOfEntries;
	@XmlElement(required = true, name = "TotalDebit")
	protected SAFmonetaryType TotalDebit;
	@XmlElement(required = true, name = "TotalCredit")
	protected SAFmonetaryType TotalCredit;
	@XmlElement(required = true, name = "Invoice")
	protected List<InvoiceStructure> Invoice;
}

// PurchaseInvoices ...
public class PurchaseInvoices {
	@XmlElement(required = true, name = "NumberOfEntries")
	protected Integer NumberOfEntries;
	@XmlElement(required = true, name = "TotalDebit")
	protected SAFmonetaryType TotalDebit;
	@XmlElement(required = true, name = "TotalCredit")
	protected SAFmonetaryType TotalCredit;
	@XmlElement(required = true, name = "Invoice")
	protected List<InvoiceStructure> Invoice;
}

// PaymentLine ...
public class PaymentLine {
	@XmlElement(required = true, name = "LineNumber")
	protected SAFshorttextType LineNumber;
	@XmlElement(required = true, name = "SourceDocumentID")
	protected SAFmiddle1textType SourceDocumentID;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "Analysis")
	protected List<AnalysisStructure> Analysis;
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "TaxPointDate")
	protected String TaxPointDate;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "DebitCreditIndicator")
	protected SAFcodeType DebitCreditIndicator;
	@XmlElement(required = true, name = "PaymentLineAmount")
	protected AmountStructure PaymentLineAmount;
	@XmlElement(required = true, name = "TaxInformation")
	protected List<TaxInformationStructure> TaxInformation;
}

// PaymentSettlement ...
public class PaymentSettlement {
	@XmlElement(required = true, name = "SettlementDiscount")
	protected SAFmiddle1textType SettlementDiscount;
	@XmlElement(required = true, name = "SettlementAmount")
	protected AmountStructure SettlementAmount;
	@XmlElement(required = true, name = "SettlementDate")
	protected String SettlementDate;
	@XmlElement(required = true, name = "PaymentMechanism")
	protected SAFcodeType PaymentMechanism;
}

// PaymentDocumentTotals ...
public class PaymentDocumentTotals {
	@XmlElement(required = true, name = "TaxInformationTotals")
	protected List<TaxInformationStructure> TaxInformationTotals;
	@XmlElement(required = true, name = "NetTotal")
	protected SAFmonetaryType NetTotal;
	@XmlElement(required = true, name = "GrossTotal")
	protected SAFmonetaryType GrossTotal;
}

// Payment ...
public class Payment {
	@XmlElement(required = true, name = "PaymentRefNo")
	protected SAFmiddle1textType PaymentRefNo;
	@XmlElement(required = true, name = "Period")
	protected Integer Period;
	@XmlElement(required = true, name = "PeriodYear")
	protected Integer PeriodYear;
	@XmlElement(required = true, name = "TransactionID")
	protected SAFmiddle2textType TransactionID;
	@XmlElement(required = true, name = "TransactionDate")
	protected String TransactionDate;
	@XmlElement(required = true, name = "PaymentMethod")
	protected SAFshorttextType PaymentMethod;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "BatchID")
	protected SAFmiddle1textType BatchID;
	@XmlElement(required = true, name = "SystemID")
	protected SAFmiddle1textType SystemID;
	@XmlElement(required = true, name = "SourceID")
	protected SAFmiddle1textType SourceID;
	@XmlElement(required = true, name = "PaymentLine")
	protected List<PaymentLine> PaymentLine;
	@XmlElement(required = true, name = "PaymentSettlement")
	protected PaymentSettlement PaymentSettlement;
	@XmlElement(required = true, name = "PaymentDocumentTotals")
	protected PaymentDocumentTotals PaymentDocumentTotals;
}

// Payments ...
public class Payments {
	@XmlElement(required = true, name = "NumberOfEntries")
	protected Integer NumberOfEntries;
	@XmlElement(required = true, name = "TotalDebit")
	protected SAFmonetaryType TotalDebit;
	@XmlElement(required = true, name = "TotalCredit")
	protected SAFmonetaryType TotalCredit;
	@XmlElement(required = true, name = "Payment")
	protected List<Payment> Payment;
}

// DocumentReference ...
public class DocumentReference {
	@XmlElement(required = true, name = "DocumentType")
	protected SAFshorttextType DocumentType;
	@XmlElement(required = true, name = "DocumentNumber")
	protected SAFmiddle1textType DocumentNumber;
	@XmlElement(required = true, name = "DocumentLine")
	protected SAFshorttextType DocumentLine;
}

// StockMovementLine ...
public class StockMovementLine {
	@XmlElement(required = true, name = "LineNumber")
	protected SAFshorttextType LineNumber;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "TransactionID")
	protected SAFmiddle2textType TransactionID;
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "ShipTo")
	protected ShippingPointStructure ShipTo;
	@XmlElement(required = true, name = "ShipFrom")
	protected ShippingPointStructure ShipFrom;
	@XmlElement(required = true, name = "ProductCode")
	protected SAFmiddle2textType ProductCode;
	@XmlElement(required = true, name = "StockAccountNo")
	protected SAFmiddle2textType StockAccountNo;
	@XmlElement(required = true, name = "Quantity")
	protected SAFquantityType Quantity;
	@XmlElement(required = true, name = "UnitOfMeasure")
	protected SAFcodeType UnitOfMeasure;
	@XmlElement(required = true, name = "UOMToUOMPhysicalStockConversionFactor")
	protected Float UOMToUOMPhysicalStockConversionFactor;
	@XmlElement(required = true, name = "BookValue")
	protected SAFmonetaryType BookValue;
	@XmlElement(required = true, name = "MovementSubType")
	protected SAFcodeType MovementSubType;
	@XmlElement(required = true, name = "MovementComments")
	protected SAFlongtextType MovementComments;
	@XmlElement(required = true, name = "TaxInformation")
	protected List<TaxInformationStructure> TaxInformation;
}

// StockMovement ...
public class StockMovement {
	@XmlElement(required = true, name = "MovementReference")
	protected SAFmiddle1textType MovementReference;
	@XmlElement(required = true, name = "MovementDate")
	protected String MovementDate;
	@XmlElement(required = true, name = "MovementPostingDate")
	protected String MovementPostingDate;
	@XmlElement(required = true, name = "MovementPostingTime")
	protected String MovementPostingTime;
	@XmlElement(required = true, name = "TaxPointDate")
	protected String TaxPointDate;
	@XmlElement(required = true, name = "MovementType")
	protected SAFcodeType MovementType;
	@XmlElement(required = true, name = "SourceID")
	protected SAFmiddle1textType SourceID;
	@XmlElement(required = true, name = "SystemID")
	protected SAFmiddle1textType SystemID;
	@XmlElement(required = true, name = "DocumentReference")
	protected DocumentReference DocumentReference;
	@XmlElement(required = true, name = "StockMovementLine")
	protected List<StockMovementLine> StockMovementLine;
}

// MovementOfGoods ...
public class MovementOfGoods {
	@XmlElement(required = true, name = "NumberOfMovementLines")
	protected Integer NumberOfMovementLines;
	@XmlElement(required = true, name = "TotalQuantityReceived")
	protected SAFquantityType TotalQuantityReceived;
	@XmlElement(required = true, name = "TotalQuantityIssued")
	protected SAFquantityType TotalQuantityIssued;
	@XmlElement(required = true, name = "StockMovement")
	protected List<StockMovement> StockMovement;
}

// AssetTransactionValuation ...
public class AssetTransactionValuation {
	@XmlElement(required = true, name = "AssetValuationType")
	protected SAFshorttextType AssetValuationType;
	@XmlElement(required = true, name = "AcquisitionAndProductionCostsOnTransaction")
	protected SAFmonetaryType AcquisitionAndProductionCostsOnTransaction;
	@XmlElement(required = true, name = "BookValueOnTransaction")
	protected SAFmonetaryType BookValueOnTransaction;
	@XmlElement(required = true, name = "AssetTransactionAmount")
	protected SAFmonetaryType AssetTransactionAmount;
}

// AssetTransactionValuations ...
public class AssetTransactionValuations {
	@XmlElement(required = true, name = "AssetTransactionValuation")
	protected List<AssetTransactionValuation> AssetTransactionValuation;
}

// AssetTransaction ...
public class AssetTransaction {
	@XmlElement(required = true, name = "AssetTransactionID")
	protected SAFmiddle2textType AssetTransactionID;
	@XmlElement(required = true, name = "AssetID")
	protected SAFmiddle1textType AssetID;
	@XmlElement(required = true, name = "AssetTransactionType")
	protected SAFcodeType AssetTransactionType;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "AssetTransactionDate")
	protected String AssetTransactionDate;
	@XmlElement(required = true, name = "AssetSupplier")
	protected AssetSupplier AssetSupplier;
	@XmlElement(required = true, name = "TransactionID")
	protected SAFmiddle2textType TransactionID;
	@XmlElement(required = true, name = "AssetTransactionValuations")
	protected AssetTransactionValuations AssetTransactionValuations;
}

// AssetTransactions ...
public class AssetTransactions {
	@XmlElement(required = true, name = "NumberOfAssetTransactions")
	protected Integer NumberOfAssetTransactions;
	@XmlElement(required = true, name = "AssetTransaction")
	protected List<AssetTransaction> AssetTransaction;
}

// SourceDocuments ...
public class SourceDocuments {
	@XmlElement(required = true, name = "SalesInvoices")
	protected SalesInvoices SalesInvoices;
	@XmlElement(required = true, name = "PurchaseInvoices")
	protected PurchaseInvoices PurchaseInvoices;
	@XmlElement(required = true, name = "Payments")
	protected Payments Payments;
	@XmlElement(required = true, name = "MovementOfGoods")
	protected MovementOfGoods MovementOfGoods;
	@XmlElement(required = true, name = "AssetTransactions")
	protected AssetTransactions AssetTransactions;
}

// AuditFile ...
public class AuditFile {
	@XmlElement(required = true, name = "Header")
	protected Header Header;
	@XmlElement(required = true, name = "MasterFiles")
	protected MasterFiles MasterFiles;
	@XmlElement(required = true, name = "CorrespondingAccountsReport")
	protected CorrespondingAccountsReport CorrespondingAccountsReport;
	@XmlElement(required = true, name = "GeneralLedgerEntries")
	protected GeneralLedgerEntries GeneralLedgerEntries;
	@XmlElement(required = true, name = "SourceDocuments")
	protected SourceDocuments SourceDocuments;
}

@XmlAccessorType(XmlAccessType.FIELD)
@XmlElement(required = true, name = "DebitCreditIndicator")
public class DebitCreditIndicator {
	protected SAFcodeType DebitCreditIndicator;
}

// CustomerInfo ...
public class CustomerInfo {
	@XmlElement(required = true, name = "CustomerID")
	protected SAFmiddle1textType CustomerID;
	@XmlElement(required = true, name = "Name")
	protected SAFmiddle2textType Name;
	@XmlElement(required = true, name = "BillingAddress")
	protected AddressStructure BillingAddress;
}

// SupplierInfo ...
public class SupplierInfo {
	@XmlElement(required = true, name = "SupplierID")
	protected SAFmiddle1textType SupplierID;
	@XmlElement(required = true, name = "Name")
	protected SAFmiddle2textType Name;
	@XmlElement(required = true, name = "BillingAddress")
	protected AddressStructure BillingAddress;
}

// OrderReferences ...
public class OrderReferences {
	@XmlElement(required = true, name = "OriginatingON")
	protected SAFmiddle2textType OriginatingON;
	@XmlElement(required = true, name = "OrderDate")
	protected String OrderDate;
}

// DeliveryPeriod ...
public class DeliveryPeriod {
	@XmlElement(required = true, name = "FromDate")
	protected String FromDate;
	@XmlElement(required = true, name = "ToDate")
	protected String ToDate;
}

// Delivery ...
public class Delivery {
	@XmlElement(required = true, name = "MovementReference")
	protected List<SAFmiddle1textType> MovementReference;
	@XmlElement(required = true, name = "DeliveryDate")
	protected String DeliveryDate;
	@XmlElement(required = true, name = "DeliveryPeriod")
	protected DeliveryPeriod DeliveryPeriod;
}

// CreditNote ...
public class CreditNote {
	@XmlElement(required = true, name = "Reference")
	protected SAFmiddle1textType Reference;
	@XmlElement(required = true, name = "Reason")
	protected SAFlongtextType Reason;
}

// References ...
public class References {
	@XmlElement(required = true, name = "CreditNote")
	protected CreditNote CreditNote;
}

// InvoiceLine ...
public class InvoiceLine {
	@XmlElement(required = true, name = "LineNumber")
	protected SAFshorttextType LineNumber;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "Analysis")
	protected List<AnalysisStructure> Analysis;
	@XmlElement(required = true, name = "OrderReferences")
	protected List<OrderReferences> OrderReferences;
	@XmlElement(required = true, name = "ShipTo")
	protected ShippingPointStructure ShipTo;
	@XmlElement(required = true, name = "ShipFrom")
	protected ShippingPointStructure ShipFrom;
	@XmlElement(required = true, name = "GoodsServicesID")
	protected SAFcodeType GoodsServicesID;
	@XmlElement(required = true, name = "ProductCode")
	protected SAFmiddle2textType ProductCode;
	@XmlElement(required = true, name = "ProductDescription")
	protected SAFlongtextType ProductDescription;
	@XmlElement(required = true, name = "Delivery")
	protected Delivery Delivery;
	@XmlElement(required = true, name = "Quantity")
	protected SAFquantityType Quantity;
	@XmlElement(required = true, name = "InvoiceUOM")
	protected SAFcodeType InvoiceUOM;
	@XmlElement(required = true, name = "UOMToUOMBaseConversionFactor")
	protected Float UOMToUOMBaseConversionFactor;
	@XmlElement(required = true, name = "UnitPrice")
	protected SAFmonetaryType UnitPrice;
	@XmlElement(required = true, name = "TaxPointDate")
	protected String TaxPointDate;
	@XmlElement(required = true, name = "References")
	protected References References;
	@XmlElement(required = true, name = "Description")
	protected SAFlongtextType Description;
	@XmlElement(required = true, name = "InvoiceLineAmount")
	protected AmountStructure InvoiceLineAmount;
	@XmlElement(required = true, name = "DebitCreditIndicator")
	protected SAFcodeType DebitCreditIndicator;
	@XmlElement(required = true, name = "ShippingCostsAmount")
	protected AmountStructure ShippingCostsAmount;
	@XmlElement(required = true, name = "TaxInformation")
	protected List<TaxInformationStructure> TaxInformation;
}

// InvoiceSettlement ...
public class InvoiceSettlement {
	@XmlElement(required = true, name = "SettlementDiscount")
	protected SAFmiddle1textType SettlementDiscount;
	@XmlElement(required = true, name = "SettlementAmount")
	protected AmountStructure SettlementAmount;
	@XmlElement(required = true, name = "SettlementDate")
	protected String SettlementDate;
	@XmlElement(required = true, name = "PaymentMechanism")
	protected SAFcodeType PaymentMechanism;
}

// InvoiceDocumentTotals ...
public class InvoiceDocumentTotals {
	@XmlElement(required = true, name = "TaxInformationTotals")
	protected List<TaxInformationStructure> TaxInformationTotals;
	@XmlElement(required = true, name = "ShippingCostsAmountTotal")
	protected SAFmonetaryType ShippingCostsAmountTotal;
	@XmlElement(required = true, name = "NetTotal")
	protected SAFmonetaryType NetTotal;
	@XmlElement(required = true, name = "GrossTotal")
	protected SAFmonetaryType GrossTotal;
}

// InvoiceStructure ...
public class InvoiceStructure {
	@XmlElement(required = true, name = "InvoiceNo")
	protected SAFmiddle2textType InvoiceNo;
	@XmlElement(required = true, name = "CustomerInfo")
	protected CustomerInfo CustomerInfo;
	@XmlElement(required = true, name = "SupplierInfo")
	protected SupplierInfo SupplierInfo;
	@XmlElement(required = true, name = "AccountID")
	protected SAFmiddle2textType AccountID;
	@XmlElement(required = true, name = "BranchStoreNumber")
	protected SAFmiddle1textType BranchStoreNumber;
	@XmlElement(required = true, name = "Period")
	protected Integer Period;
	@XmlElement(required = true, name = "PeriodYear")
	protected Integer PeriodYear;
	@XmlElement(required = true, name = "InvoiceDate")
	protected String InvoiceDate;
	@XmlElement(required = true, name = "InvoiceType")
	protected SAFcodeType InvoiceType;
	@XmlElement(required = true, name = "ShipTo")
	protected ShippingPointStructure ShipTo;
	@XmlElement(required = true, name = "ShipFrom")
	protected ShippingPointStructure ShipFrom;
	@XmlElement(required = true, name = "PaymentTerms")
	protected SAFmiddle2textType PaymentTerms;
	@XmlElement(required = true, name = "SelfBillingIndicator")
	protected SAFcodeType SelfBillingIndicator;
	@XmlElement(required = true, name = "SourceID")
	protected SAFmiddle1textType SourceID;
	@XmlElement(required = true, name = "GLPostingDate")
	protected String GLPostingDate;
	@XmlElement(required = true, name = "BatchID")
	protected SAFmiddle1textType BatchID;
	@XmlElement(required = true, name = "SystemID")
	protected SAFmiddle1textType SystemID;
	@XmlElement(required = true, name = "TransactionID")
	protected SAFmiddle2textType TransactionID;
	@XmlElement(required = true, name = "ReceiptNumbers")
	protected SAFlongtextType ReceiptNumbers;
	@XmlElement(required = true, name = "InvoiceLine")
	protected List<InvoiceLine> InvoiceLine;
	@XmlElement(required = true, name = "InvoiceSettlement")
	protected InvoiceSettlement InvoiceSettlement;
	@XmlElement(required = true, name = "InvoiceDocumentTotals")
	protected InvoiceDocumentTotals InvoiceDocumentTotals;
}

// ShippingPointStructure ...
public class ShippingPointStructure {
	@XmlElement(required = true, name = "DeliveryID")
	protected SAFmiddle1textType DeliveryID;
	@XmlElement(required = true, name = "DeliveryDate")
	protected String DeliveryDate;
	@XmlElement(required = true, name = "WarehouseID")
	protected SAFmiddle1textType WarehouseID;
	@XmlElement(required = true, name = "LocationID")
	protected SAFshorttextType LocationID;
	@XmlElement(required = true, name = "UCR")
	protected SAFmiddle1textType UCR;
	@XmlElement(required = true, name = "Address")
	protected AddressStructure Address;
}

// AddressStructure ...
public class AddressStructure {
	@XmlElement(required = true, name = "StreetName")
	protected SAFmiddle2textType StreetName;
	@XmlElement(required = true, name = "Number")
	protected SAFshorttextType Number;
	@XmlElement(required = true, name = "AdditionalAddressDetail")
	protected SAFmiddle2textType AdditionalAddressDetail;
	@XmlElement(required = true, name = "Building")
	protected SAFmiddle1textType Building;
	@XmlElement(required = true, name = "City")
	protected SAFmiddle1textType City;
	@XmlElement(required = true, name = "PostalCode")
	protected SAFshorttextType PostalCode;
	@XmlElement(required = true, name = "Region")
	protected SAFmiddle1textType Region;
	@XmlElement(required = true, name = "Country")
	protected ISOCountryCode Country;
	@XmlElement(required = true, name = "AddressType")
	protected String AddressType;
}

// GroupIdentification ...
public class GroupIdentification {
	@XmlElement(required = true, name = "GroupNameCyrillic")
	protected SAFmiddle2textType GroupNameCyrillic;
	@XmlElement(required = true, name = "GroupNameLatin")
	protected SAFmiddle2textType GroupNameLatin;
	@XmlElement(required = true, name = "Country")
	protected ISOCountryCode Country;
}

// DirectOwnerIdentification ...
public class DirectOwnerIdentification {
	@XmlElement(required = true, name = "OwnerNameCyrillic")
	protected SAFmiddle2textType OwnerNameCyrillic;
	@XmlElement(required = true, name = "LegalFormCyrillic")
	protected SAFmiddle2textType LegalFormCyrillic;
	@XmlElement(required = true, name = "OwnerNameLatin")
	protected SAFmiddle2textType OwnerNameLatin;
	@XmlElement(required = true, name = "LegalFormLatin")
	protected SAFmiddle2textType LegalFormLatin;
	@XmlElement(required = true, name = "OwnerCountry")
	protected ISOCountryCode OwnerCountry;
	@XmlElement(required = true, name = "OwnerUIC")
	protected SAFmiddle1textType OwnerUIC;
	@XmlElement(required = true, name = "OwnershipPercentage")
	protected Float OwnershipPercentage;
}

// UltimateOwnerIdentificationBG ...
public class UltimateOwnerIdentificationBG {
	@XmlElement(required = true, name = "UltimateOwnerNameCyrillicBG")
	protected SAFmiddle2textType UltimateOwnerNameCyrillicBG;
	@XmlElement(required = true, name = "UltimateOwnerUICBG")
	protected SAFmiddle1textType UltimateOwnerUICBG;
	@XmlElement(required = true, name = "UltimateOwnerEGNBG")
	protected SAFmiddle1textType UltimateOwnerEGNBG;
}

// UltimateOwnerIdentificationForeign ...
public class UltimateOwnerIdentificationForeign {
	@XmlElement(required = true, name = "UltimateOwnerNameCyrillicForeign")
	protected SAFmiddle2textType UltimateOwnerNameCyrillicForeign;
	@XmlElement(required = true, name = "UltimateOwnerNameLatinForeign")
	protected SAFmiddle2textType UltimateOwnerNameLatinForeign;
	@XmlElement(required = true, name = "CountryForeign")
	protected ISOCountryCode CountryForeign;
}

// OwnershipStructure ...
public class OwnershipStructure {
	@XmlElement(required = true, name = "IsPartOfGroup")
	protected SAFmiddle1textType IsPartOfGroup;
	@XmlElement(required = true, name = "UltimateOwnerNameCyrillic")
	protected SAFmiddle2textType UltimateOwnerNameCyrillic;
	@XmlElement(required = true, name = "UltimateOwnerNameLatin")
	protected SAFmiddle2textType UltimateOwnerNameLatin;
	@XmlElement(required = true, name = "UltimateOwnerUIC")
	protected SAFmiddle1textType UltimateOwnerUIC;
	@XmlElement(required = true, name = "UltimateOwnerEGN")
	protected SAFmiddle1textType UltimateOwnerEGN;
	@XmlElement(required = true, name = "GroupIdentification")
	protected GroupIdentification GroupIdentification;
	@XmlElement(required = true, name = "DirectOwnerIdentification")
	protected DirectOwnerIdentification DirectOwnerIdentification;
	@XmlElement(required = true, name = "UltimateOwnerIdentificationBG")
	protected UltimateOwnerIdentificationBG UltimateOwnerIdentificationBG;
	@XmlElement(required = true, name = "UltimateOwnerIdentificationForeign")
	protected UltimateOwnerIdentificationForeign UltimateOwnerIdentificationForeign;
}

// AmountStructure ...
public class AmountStructure {
	@XmlElement(required = true, name = "Amount")
	protected SAFmonetaryType Amount;
	@XmlElement(required = true, name = "CurrencyCode")
	protected ISOCurrencyCode CurrencyCode;
	@XmlElement(required = true, name = "CurrencyAmount")
	protected SAFmonetaryType CurrencyAmount;
	@XmlElement(required = true, name = "ExchangeRate")
	protected SAFexchangerateType ExchangeRate;
}

// AnalysisStructure ...
public class AnalysisStructure {
	@XmlElement(required = true, name = "AnalysisType")
	protected SAFcodeType AnalysisType;
	@XmlElement(required = true, name = "AnalysisID")
	protected SAFlongtextType AnalysisID;
	@XmlElement(required = true, name = "AnalysisAmount")
	protected AmountStructure AnalysisAmount;
}

// BankAccountStructure ...
public class BankAccountStructure {
	@XmlElement(required = true, name = "IBANNumber")
	protected SAFmiddle1textType IBANNumber;
	@XmlElement(required = true, name = "BankAccountNumber")
	protected SAFmiddle1textType BankAccountNumber;
	@XmlElement(required = true, name = "BankAccountName")
	protected SAFmiddle2textType BankAccountName;
	@XmlElement(required = true, name = "SortCode")
	protected SAFshorttextType SortCode;
}

// CompanyHeaderStructure ...
public class CompanyHeaderStructure {
	@XmlElement(required = true, name = "RegistrationNumber")
	protected SAFmiddle1textType RegistrationNumber;
	@XmlElement(required = true, name = "Name")
	protected SAFmiddle2textType Name;
	@XmlElement(required = true, name = "NameLatin")
	protected SAFmiddle2textType NameLatin;
	@XmlElement(required = true, name = "Address")
	protected List<AddressStructure> Address;
	@XmlElement(required = true, name = "Contact")
	protected List<ContactInformationStructure> Contact;
	@XmlElement(required = true, name = "TaxRegistration")
	protected List<TaxIDStructure> TaxRegistration;
	@XmlElement(required = true, name = "BankAccount")
	protected List<BankAccountStructure> BankAccount;
	@XmlElement(required = true, name = "RelatedParty")
	protected SAFshorttextType RelatedParty;
	@XmlElement(required = true, name = "RelatedPartyStartDate")
	protected String RelatedPartyStartDate;
	@XmlElement(required = true, name = "RelatedParty")
	protected SAFshorttextType RelatedParty;
}

// CompanyStructure ...
public class CompanyStructure {
	@XmlElement(required = true, name = "RegistrationNumber")
	protected SAFmiddle1textType RegistrationNumber;
	@XmlElement(required = true, name = "Name")
	protected SAFmiddle2textType Name;
	@XmlElement(required = true, name = "NameLatin")
	protected SAFmiddle2textType NameLatin;
	@XmlElement(required = true, name = "Address")
	protected List<AddressStructure> Address;
	@XmlElement(required = true, name = "Contact")
	protected List<ContactInformationStructure> Contact;
	@XmlElement(required = true, name = "TaxRegistration")
	protected List<TaxIDStructure> TaxRegistration;
	@XmlElement(required = true, name = "BankAccount")
	protected List<BankAccountStructure> BankAccount;
	@XmlElement(required = true, name = "RelatedParty")
	protected RelatedParty RelatedParty;
	@XmlElement(required = true, name = "RelatedPartyStartDate")
	protected String RelatedPartyStartDate;
	@XmlElement(required = true, name = "RelatedPartyEndDate")
	protected String RelatedPartyEndDate;
}

// ContactHeaderStructure ...
public class ContactHeaderStructure {
	@XmlElement(required = true, name = "ContactPerson")
	protected PersonNameStructure ContactPerson;
	@XmlElement(required = true, name = "Telephone")
	protected SAFshorttextType Telephone;
	@XmlElement(required = true, name = "Fax")
	protected SAFshorttextType Fax;
	@XmlElement(required = true, name = "Email")
	protected SAFmiddle2textType Email;
	@XmlElement(required = true, name = "RelatedParty")
	protected RelatedParty RelatedParty;
}

// ContactInformationStructure ...
public class ContactInformationStructure {
	@XmlElement(required = true, name = "ContactPerson")
	protected PersonNameStructure ContactPerson;
	@XmlElement(required = true, name = "Telephone")
	protected SAFshorttextType Telephone;
	@XmlElement(required = true, name = "Fax")
	protected SAFshorttextType Fax;
	@XmlElement(required = true, name = "Email")
	protected SAFmiddle2textType Email;
	@XmlElement(required = true, name = "Website")
	protected QName Website;
}

// HeaderStructure ...
public class HeaderStructure {
	@XmlElement(required = true, name = "AuditFileVersion")
	protected SAFcodeType AuditFileVersion;
	@XmlElement(required = true, name = "AuditFileCountry")
	protected ISOCountryCode AuditFileCountry;
	@XmlElement(required = true, name = "AuditFileRegion")
	protected SAFcodeType AuditFileRegion;
	@XmlElement(required = true, name = "AuditFileDateCreated")
	protected String AuditFileDateCreated;
	@XmlElement(required = true, name = "SoftwareCompanyName")
	protected SAFmiddle2textType SoftwareCompanyName;
	@XmlElement(required = true, name = "SoftwareID")
	protected SAFlongtextType SoftwareID;
	@XmlElement(required = true, name = "SoftwareVersion")
	protected SAFshorttextType SoftwareVersion;
	@XmlElement(required = true, name = "Company")
	protected CompanyHeaderStructure Company;
	@XmlElement(required = true, name = "Ownership")
	protected OwnershipStructure Ownership;
	@XmlElement(required = true, name = "DefaultCurrencyCode")
	protected ISOCurrencyCode DefaultCurrencyCode;
	@XmlElement(required = true, name = "SelectionCriteria")
	protected SelectionCriteriaStructure SelectionCriteria;
	@XmlElement(required = true, name = "HeaderComment")
	protected SAFlongtextType HeaderComment;
	@XmlElement(required = true, name = "SegmentIndex")
	protected SAFcodeType SegmentIndex;
	@XmlElement(required = true, name = "TotalSegmentsInsequence")
	protected SAFcodeType TotalSegmentsInsequence;
}

// PersonNameStructure ...
public class PersonNameStructure {
	@XmlElement(required = true, name = "Title")
	protected SAFcodeType Title;
	@XmlElement(required = true, name = "FirstName")
	protected SAFmiddle1textType FirstName;
	@XmlElement(required = true, name = "Initials")
	protected SAFshorttextType Initials;
	@XmlElement(required = true, name = "LastNamePrefix")
	protected SAFshorttextType LastNamePrefix;
	@XmlElement(required = true, name = "LastName")
	protected SAFmiddle2textType LastName;
	@XmlElement(required = true, name = "BirthName")
	protected SAFmiddle2textType BirthName;
	@XmlElement(required = true, name = "Salutation")
	protected SAFshorttextType Salutation;
	@XmlElement(required = true, name = "OtherTitles")
	protected List<SAFshorttextType> OtherTitles;
}

// SelectionCriteriaStructure ...
public class SelectionCriteriaStructure {
	@XmlElement(required = true, name = "TaxReportingJurisdiction")
	protected SAFmiddle1textType TaxReportingJurisdiction;
	@XmlElement(required = true, name = "CompanyEntity")
	protected SAFmiddle2textType CompanyEntity;
	@XmlElement(required = true, name = "SelectionStartDate")
	protected String SelectionStartDate;
	@XmlElement(required = true, name = "SelectionEndDate")
	protected String SelectionEndDate;
	@XmlElement(required = true, name = "PeriodStart")
	protected Integer PeriodStart;
	@XmlElement(required = true, name = "PeriodStartYear")
	protected Integer PeriodStartYear;
	@XmlElement(required = true, name = "PeriodEnd")
	protected Integer PeriodEnd;
	@XmlElement(required = true, name = "PeriodEndYear")
	protected Integer PeriodEndYear;
	@XmlElement(required = true, name = "DocumentType")
	protected SAFlongtextType DocumentType;
	@XmlElement(required = true, name = "OtherCriteria")
	protected List<SAFlongtextType> OtherCriteria;
}

// TaxIDStructure ...
public class TaxIDStructure {
	@XmlElement(required = true, name = "TaxRegistrationNumber")
	protected SAFmiddle1textType TaxRegistrationNumber;
	@XmlElement(required = true, name = "TaxType")
	protected SAFcodeType TaxType;
	@XmlElement(required = true, name = "TaxNumber")
	protected SAFmiddle1textType TaxNumber;
	@XmlElement(required = true, name = "TaxAuthority")
	protected SAFmiddle1textType TaxAuthority;
	@XmlElement(required = true, name = "TaxVerificationDate")
	protected String TaxVerificationDate;
}

// TaxInformationStructure ...
public class TaxInformationStructure {
	@XmlElement(required = true, name = "TaxType")
	protected SAFcodeType TaxType;
	@XmlElement(required = true, name = "TaxCode")
	protected SAFcodeType TaxCode;
	@XmlElement(required = true, name = "TaxPercentage")
	protected Float TaxPercentage;
	@XmlElement(required = true, name = "TaxBase")
	protected Float TaxBase;
	@XmlElement(required = true, name = "TaxBaseDescription")
	protected SAFmiddle2textType TaxBaseDescription;
	@XmlElement(required = true, name = "TaxAmount")
	protected AmountStructure TaxAmount;
	@XmlElement(required = true, name = "TaxExemptionReason")
	protected SAFmiddle2textType TaxExemptionReason;
	@XmlElement(required = true, name = "TaxDeclarationPeriod")
	protected SAFmiddle1textType TaxDeclarationPeriod;
}

// Date ...
@XmlAccessorType(XmlAccessType.FIELD)
@XmlAttribute(required = true, name = "Date")
public class Date {
	protected String Date;
}

// Decimal ...
@XmlAccessorType(XmlAccessType.FIELD)
@XmlAttribute(required = true, name = "Decimal")
public class Decimal {
	protected Float Decimal;
}

// Time ...
@XmlAccessorType(XmlAccessType.FIELD)
@XmlAttribute(required = true, name = "Time")
public class Time {
	protected String Time;
}
