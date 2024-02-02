// Header ...
typedef struct {
	SAFshorttextType TaxAccountingBasis;
	SAFmiddle2textType TaxEntity;
} Header;

// Account ...
typedef struct {
	SAFmiddle2textType AccountID;
	SAFlongtextType AccountDescription;
	SAFmiddle1textType TaxpayerAccountID;
	SAFmiddle1textType GroupingCategory;
	SAFmiddle1textType GroupingCode;
	SAFshorttextType AccountType;
	char AccountCreationDate;
	SAFmonetaryType OpeningDebitBalance;
	SAFmonetaryType OpeningCreditBalance;
	SAFmonetaryType ClosingDebitBalance;
	SAFmonetaryType ClosingCreditBalance;
} Account;

// GeneralLedgerAccounts ...
typedef struct {
	Account Account[];
} GeneralLedgerAccounts;

// TaxonomyElement ...
typedef struct {
	SAFlongtextType TaxonomyCode;
	SAFlongtextType TaxonomyClusterID;
	SAFlongtextType TaxonomyClusterContextID;
	SAFmiddle2textType AccountID;
} TaxonomyElement;

// Taxonomy ...
typedef struct {
	SAFlongtextType TaxonomyReference;
	TaxonomyElement TaxonomyElement[];
} Taxonomy;

// Taxonomies ...
typedef struct {
	Taxonomy Taxonomy[];
} Taxonomies;

// Customer ...
typedef struct {
	CompanyStructure CompanyStructure;
	SAFmiddle1textType CustomerID;
	SAFcodeType SelfBillingIndicator;
	SAFmiddle2textType AccountID;
	SAFmonetaryType OpeningDebitBalance;
	SAFmonetaryType OpeningCreditBalance;
	SAFmonetaryType ClosingDebitBalance;
	SAFmonetaryType ClosingCreditBalance;
} Customer;

// Customers ...
typedef struct {
	Customer Customer[];
} Customers;

// Supplier ...
typedef struct {
	CompanyStructure CompanyStructure;
	SAFmiddle1textType SupplierID;
	SAFcodeType SelfBillingIndicator;
	SAFmiddle2textType AccountID;
	SAFmonetaryType OpeningDebitBalance;
	SAFmonetaryType OpeningCreditBalance;
	SAFmonetaryType ClosingDebitBalance;
	SAFmonetaryType ClosingCreditBalance;
} Supplier;

// Suppliers ...
typedef struct {
	Supplier Supplier[];
} Suppliers;

// TaxCodeDetails ...
typedef struct {
	SAFcodeType TaxCode;
	char EffectiveDate;
	char ExpirationDate;
	SAFlongtextType Description;
	float TaxPercentage;
	AmountStructure FlatTaxRate;
	SAFBaseRate BaseRate[];
	ISOCountryCode Country;
	SAFcodeType Region;
} TaxCodeDetails;

// TaxTableEntry ...
typedef struct {
	SAFcodeType TaxType;
	SAFlongtextType Description;
	TaxCodeDetails TaxCodeDetails[];
} TaxTableEntry;

// TaxTable ...
typedef struct {
	TaxTableEntry TaxTableEntry[];
} TaxTable;

// UOMTableEntry ...
typedef struct {
	SAFcodeType UnitOfMeasure;
	SAFlongtextType Description;
} UOMTableEntry;

// UOMTable ...
typedef struct {
	UOMTableEntry UOMTableEntry[];
} UOMTable;

// AnalysisTypeTableEntry ...
typedef struct {
	SAFcodeType AnalysisType;
	SAFlongtextType AnalysisTypeDescription;
	SAFmiddle1textType AnalysisID;
	SAFlongtextType AnalysisIDDescription;
} AnalysisTypeTableEntry;

// AnalysisTypeTable ...
typedef struct {
	AnalysisTypeTableEntry AnalysisTypeTableEntry[];
} AnalysisTypeTable;

// MovementTypeTableEntry ...
typedef struct {
	SAFcodeType MovementType;
	SAFlongtextType Description;
} MovementTypeTableEntry;

// MovementTypeTable ...
typedef struct {
	MovementTypeTableEntry MovementTypeTableEntry[];
} MovementTypeTable;

// Tax ...
typedef struct {
	SAFcodeType TaxType;
	SAFcodeType TaxCode;
} Tax;

// Product ...
typedef struct {
	SAFmiddle2textType ProductCode;
	SAFcodeType GoodsServicesID;
	SAFmiddle2textType ProductGroup;
	SAFlongtextType Description;
	SAFmiddle1textType ProductCommodityCode;
	SAFmiddle2textType ProductNumberCode;
	SAFcodeType ValuationMethod;
	SAFcodeType UOMBase;
	SAFcodeType UOMStandard;
	float UOMToUOMBaseConversionFactor;
	Tax Tax[];
} Product;

// Products ...
typedef struct {
	Product Product[];
} Products;

// StockCharacteristics ...
typedef struct {
	SAFshorttextType StockCharacteristic;
	SAFmiddle1textType StockCharacteristicValue;
} StockCharacteristics;

// PhysicalStockEntry ...
typedef struct {
	SAFmiddle1textType WarehouseID;
	SAFshorttextType LocationID;
	SAFmiddle2textType ProductCode;
	SAFmiddle2textType StockAccountNo;
	SAFshorttextType ProductType;
	SAFshorttextType ProductStatus;
	SAFmiddle1textType StockAccountCommodityCode;
	SAFmiddle1textType OwnerID;
	SAFcodeType UOMPhysicalStock;
	float UOMToUOMBaseConversionFactor;
	SAFmonetaryType UnitPrice;
	SAFquantityType OpeningStockQuantity;
	SAFmonetaryType OpeningStockValue;
	SAFquantityType ClosingStockQuantity;
	SAFmonetaryType ClosingStockValue;
	StockCharacteristics StockCharacteristics;
} PhysicalStockEntry;

// PhysicalStock ...
typedef struct {
	PhysicalStockEntry PhysicalStockEntry[];
} PhysicalStock;

// Owner ...
typedef struct {
	CompanyStructure CompanyStructure;
	SAFmiddle1textType OwnerID;
	SAFmiddle2textType AccountID;
} Owner;

// Owners ...
typedef struct {
	Owner Owner[];
} Owners;

// AssetSupplier ...
typedef struct {
	SAFmiddle2textType SupplierName;
	SAFmiddle1textType SupplierID;
	AddressStructure PostalAddress;
} AssetSupplier;

// ExtraordinaryDepreciationForPeriod ...
typedef struct {
	SAFmiddle1textType ExtraordinaryDepreciationMethod;
	SAFmonetaryType ExtraordinaryDepreciationAmountForPeriod;
} ExtraordinaryDepreciationForPeriod;

// ExtraordinaryDepreciationsForPeriod ...
typedef struct {
	ExtraordinaryDepreciationForPeriod ExtraordinaryDepreciationForPeriod[];
} ExtraordinaryDepreciationsForPeriod;

// Valuation ...
typedef struct {
	SAFshorttextType AssetValuationType;
	SAFshorttextType ValuationClass;
	SAFmonetaryType AcquisitionAndProductionCostsBegin;
	SAFmonetaryType AcquisitionAndProductionCostsEnd;
	SAFmonetaryType InvestmentSupport;
	float AssetLifeYear;
	float AssetLifeMonth;
	SAFmonetaryType AssetAddition;
	SAFmonetaryType Transfers;
	SAFmonetaryType AssetDisposal;
	SAFmonetaryType BookValueBegin;
	SAFmiddle1textType DepreciationMethod;
	float DepreciationPercentage;
	SAFmonetaryType DepreciationForPeriod;
	SAFmonetaryType AppreciationForPeriod;
	ExtraordinaryDepreciationsForPeriod ExtraordinaryDepreciationsForPeriod;
	SAFmonetaryType AccumulatedDepreciation;
	SAFmonetaryType BookValueEnd;
} Valuation;

// Valuations ...
typedef struct {
	Valuation Valuation[];
} Valuations;

// Asset ...
typedef struct {
	SAFmiddle1textType AssetID;
	SAFmiddle2textType AccountID;
	SAFlongtextType Description;
	AssetSupplier AssetSupplier[];
	char PurchaseOrderDate;
	char DateOfAcquisition;
	char StartUpDate;
	Valuations Valuations;
} Asset;

// Assets ...
typedef struct {
	Asset Asset[];
} Assets;

// MasterFiles ...
typedef struct {
	GeneralLedgerAccounts GeneralLedgerAccounts;
	Taxonomies Taxonomies;
	Customers Customers;
	Suppliers Suppliers;
	TaxTable TaxTable;
	UOMTable UOMTable;
	AnalysisTypeTable AnalysisTypeTable;
	MovementTypeTable MovementTypeTable;
	Products Products;
	PhysicalStock PhysicalStock;
	Owners Owners;
	Assets Assets;
} MasterFiles;

// ReportLineValues ...
typedef struct {
	SAFmonetaryType DebitOpeningBalance;
	SAFmonetaryType CreditOpeningBalance;
	SAFmonetaryType DebitTurnover;
	SAFmonetaryType CreditTurnover;
	SAFmonetaryType DebitClosingBalance;
	SAFmonetaryType CreditClosingBalance;
} ReportLineValues;

// ReportLine ...
typedef struct {
	SAFmiddle2textType LineNo;
	SAFmiddle2textType AccountID;
	SAFmiddle2textType CorrespondingAccountID;
	int Period;
	int PeriodYear;
	ReportLineValues ReportLineValues[];
} ReportLine;

// CorrespondingAccountsReportTotals ...
typedef struct {
	SAFmonetaryType TotalDebitOpeningBalance;
	SAFmonetaryType TotalCreditOpeningBalance;
	SAFmonetaryType TotalDebit;
	SAFmonetaryType TotalCredit;
	SAFmonetaryType TotalDebitClosingBalance;
	SAFmonetaryType TotalCreditClosingBalance;
	ReportLine ReportLine[];
} CorrespondingAccountsReportTotals;

// CorrespondingAccountsReport ...
typedef struct {
	CorrespondingAccountsReportTotals CorrespondingAccountsReportTotals;
} CorrespondingAccountsReport;

// TransactionLine ...
typedef struct {
	SAFshorttextType RecordID;
	SAFmiddle2textType AccountID;
	SAFmiddle1textType TaxpayerAccountID;
	AnalysisStructure Analysis[];
	char ValueDate;
	SAFmiddle1textType SourceDocumentID;
	SAFmiddle1textType CustomerID;
	SAFmiddle1textType SupplierID;
	SAFlongtextType Description;
	AmountStructure DebitAmount;
	AmountStructure CreditAmount;
	TaxInformationStructure TaxInformation[];
} TransactionLine;

// Transaction ...
typedef struct {
	SAFmiddle2textType TransactionID;
	int Period;
	int PeriodYear;
	char TransactionDate;
	SAFmiddle1textType SourceID;
	SAFshorttextType TransactionType;
	SAFlongtextType Description;
	SAFmiddle1textType BatchID;
	char SystemEntryDate;
	char GLPostingDate;
	SAFmiddle1textType CustomerID;
	SAFmiddle1textType SupplierID;
	SAFshorttextType SystemID;
	TransactionLine TransactionLine[];
} Transaction;

// Journal ...
typedef struct {
	SAFshorttextType JournalID;
	SAFlongtextType Description;
	SAFcodeType Type;
	Transaction Transaction[];
} Journal;

// GeneralLedgerEntries ...
typedef struct {
	int NumberOfEntries;
	SAFmonetaryType TotalDebit;
	SAFmonetaryType TotalCredit;
	Journal Journal[];
} GeneralLedgerEntries;

// SalesInvoices ...
typedef struct {
	int NumberOfEntries;
	SAFmonetaryType TotalDebit;
	SAFmonetaryType TotalCredit;
	InvoiceStructure Invoice[];
} SalesInvoices;

// PurchaseInvoices ...
typedef struct {
	int NumberOfEntries;
	SAFmonetaryType TotalDebit;
	SAFmonetaryType TotalCredit;
	InvoiceStructure Invoice[];
} PurchaseInvoices;

// PaymentLine ...
typedef struct {
	SAFshorttextType LineNumber;
	SAFmiddle1textType SourceDocumentID;
	SAFmiddle2textType AccountID;
	AnalysisStructure Analysis[];
	SAFmiddle1textType CustomerID;
	SAFmiddle1textType SupplierID;
	char TaxPointDate;
	SAFlongtextType Description;
	SAFcodeType DebitCreditIndicator;
	AmountStructure PaymentLineAmount;
	TaxInformationStructure TaxInformation[];
} PaymentLine;

// PaymentSettlement ...
typedef struct {
	SAFmiddle1textType SettlementDiscount;
	AmountStructure SettlementAmount;
	char SettlementDate;
	SAFcodeType PaymentMechanism;
} PaymentSettlement;

// PaymentDocumentTotals ...
typedef struct {
	TaxInformationStructure TaxInformationTotals[];
	SAFmonetaryType NetTotal;
	SAFmonetaryType GrossTotal;
} PaymentDocumentTotals;

// Payment ...
typedef struct {
	SAFmiddle1textType PaymentRefNo;
	int Period;
	int PeriodYear;
	SAFmiddle2textType TransactionID;
	char TransactionDate;
	SAFshorttextType PaymentMethod;
	SAFlongtextType Description;
	SAFmiddle1textType BatchID;
	SAFmiddle1textType SystemID;
	SAFmiddle1textType SourceID;
	PaymentLine PaymentLine[];
	PaymentSettlement PaymentSettlement;
	PaymentDocumentTotals PaymentDocumentTotals;
} Payment;

// Payments ...
typedef struct {
	int NumberOfEntries;
	SAFmonetaryType TotalDebit;
	SAFmonetaryType TotalCredit;
	Payment Payment[];
} Payments;

// DocumentReference ...
typedef struct {
	SAFshorttextType DocumentType;
	SAFmiddle1textType DocumentNumber;
	SAFshorttextType DocumentLine;
} DocumentReference;

// StockMovementLine ...
typedef struct {
	SAFshorttextType LineNumber;
	SAFmiddle2textType AccountID;
	SAFmiddle2textType TransactionID;
	SAFmiddle1textType CustomerID;
	SAFmiddle1textType SupplierID;
	ShippingPointStructure ShipTo;
	ShippingPointStructure ShipFrom;
	SAFmiddle2textType ProductCode;
	SAFmiddle2textType StockAccountNo;
	SAFquantityType Quantity;
	SAFcodeType UnitOfMeasure;
	float UOMToUOMPhysicalStockConversionFactor;
	SAFmonetaryType BookValue;
	SAFcodeType MovementSubType;
	SAFlongtextType MovementComments;
	TaxInformationStructure TaxInformation[];
} StockMovementLine;

// StockMovement ...
typedef struct {
	SAFmiddle1textType MovementReference;
	char MovementDate;
	char MovementPostingDate;
	char MovementPostingTime;
	char TaxPointDate;
	SAFcodeType MovementType;
	SAFmiddle1textType SourceID;
	SAFmiddle1textType SystemID;
	DocumentReference DocumentReference;
	StockMovementLine StockMovementLine[];
} StockMovement;

// MovementOfGoods ...
typedef struct {
	int NumberOfMovementLines;
	SAFquantityType TotalQuantityReceived;
	SAFquantityType TotalQuantityIssued;
	StockMovement StockMovement[];
} MovementOfGoods;

// AssetTransactionValuation ...
typedef struct {
	SAFshorttextType AssetValuationType;
	SAFmonetaryType AcquisitionAndProductionCostsOnTransaction;
	SAFmonetaryType BookValueOnTransaction;
	SAFmonetaryType AssetTransactionAmount;
} AssetTransactionValuation;

// AssetTransactionValuations ...
typedef struct {
	AssetTransactionValuation AssetTransactionValuation[];
} AssetTransactionValuations;

// AssetTransaction ...
typedef struct {
	SAFmiddle2textType AssetTransactionID;
	SAFmiddle1textType AssetID;
	SAFcodeType AssetTransactionType;
	SAFlongtextType Description;
	char AssetTransactionDate;
	AssetSupplier AssetSupplier;
	SAFmiddle2textType TransactionID;
	AssetTransactionValuations AssetTransactionValuations;
} AssetTransaction;

// AssetTransactions ...
typedef struct {
	int NumberOfAssetTransactions;
	AssetTransaction AssetTransaction[];
} AssetTransactions;

// SourceDocuments ...
typedef struct {
	SalesInvoices SalesInvoices;
	PurchaseInvoices PurchaseInvoices;
	Payments Payments;
	MovementOfGoods MovementOfGoods;
	AssetTransactions AssetTransactions;
} SourceDocuments;

// AuditFile ...
typedef struct {
	Header Header;
	MasterFiles MasterFiles;
	CorrespondingAccountsReport CorrespondingAccountsReport;
	GeneralLedgerEntries GeneralLedgerEntries;
	SourceDocuments SourceDocuments;
} AuditFile;

typedef SAFcodeType DebitCreditIndicator;

// CustomerInfo ...
typedef struct {
	SAFmiddle1textType CustomerID;
	SAFmiddle2textType Name;
	AddressStructure BillingAddress;
} CustomerInfo;

// SupplierInfo ...
typedef struct {
	SAFmiddle1textType SupplierID;
	SAFmiddle2textType Name;
	AddressStructure BillingAddress;
} SupplierInfo;

// OrderReferences ...
typedef struct {
	SAFmiddle2textType OriginatingON;
	char OrderDate;
} OrderReferences;

// DeliveryPeriod ...
typedef struct {
	char FromDate;
	char ToDate;
} DeliveryPeriod;

// Delivery ...
typedef struct {
	SAFmiddle1textType MovementReference[];
	char DeliveryDate;
	DeliveryPeriod DeliveryPeriod;
} Delivery;

// CreditNote ...
typedef struct {
	SAFmiddle1textType Reference;
	SAFlongtextType Reason;
} CreditNote;

// References ...
typedef struct {
	CreditNote CreditNote;
} References;

// InvoiceLine ...
typedef struct {
	SAFshorttextType LineNumber;
	SAFmiddle2textType AccountID;
	AnalysisStructure Analysis[];
	OrderReferences OrderReferences[];
	ShippingPointStructure ShipTo;
	ShippingPointStructure ShipFrom;
	SAFcodeType GoodsServicesID;
	SAFmiddle2textType ProductCode;
	SAFlongtextType ProductDescription;
	Delivery Delivery;
	SAFquantityType Quantity;
	SAFcodeType InvoiceUOM;
	float UOMToUOMBaseConversionFactor;
	SAFmonetaryType UnitPrice;
	char TaxPointDate;
	References References;
	SAFlongtextType Description;
	AmountStructure InvoiceLineAmount;
	SAFcodeType DebitCreditIndicator;
	AmountStructure ShippingCostsAmount;
	TaxInformationStructure TaxInformation[];
} InvoiceLine;

// InvoiceSettlement ...
typedef struct {
	SAFmiddle1textType SettlementDiscount;
	AmountStructure SettlementAmount;
	char SettlementDate;
	SAFcodeType PaymentMechanism;
} InvoiceSettlement;

// InvoiceDocumentTotals ...
typedef struct {
	TaxInformationStructure TaxInformationTotals[];
	SAFmonetaryType ShippingCostsAmountTotal;
	SAFmonetaryType NetTotal;
	SAFmonetaryType GrossTotal;
} InvoiceDocumentTotals;

// InvoiceStructure ...
typedef struct {
	SAFmiddle2textType InvoiceNo;
	CustomerInfo CustomerInfo;
	SupplierInfo SupplierInfo;
	SAFmiddle2textType AccountID;
	SAFmiddle1textType BranchStoreNumber;
	int Period;
	int PeriodYear;
	char InvoiceDate;
	SAFcodeType InvoiceType;
	ShippingPointStructure ShipTo;
	ShippingPointStructure ShipFrom;
	SAFmiddle2textType PaymentTerms;
	SAFcodeType SelfBillingIndicator;
	SAFmiddle1textType SourceID;
	char GLPostingDate;
	SAFmiddle1textType BatchID;
	SAFmiddle1textType SystemID;
	SAFmiddle2textType TransactionID;
	SAFlongtextType ReceiptNumbers;
	InvoiceLine InvoiceLine[];
	InvoiceSettlement InvoiceSettlement;
	InvoiceDocumentTotals InvoiceDocumentTotals;
} InvoiceStructure;

// ShippingPointStructure ...
typedef struct {
	SAFmiddle1textType DeliveryID;
	char DeliveryDate;
	SAFmiddle1textType WarehouseID;
	SAFshorttextType LocationID;
	SAFmiddle1textType UCR;
	AddressStructure Address;
} ShippingPointStructure;

// AddressStructure ...
typedef struct {
	SAFmiddle2textType StreetName;
	SAFshorttextType Number;
	SAFmiddle2textType AdditionalAddressDetail;
	SAFmiddle1textType Building;
	SAFmiddle1textType City;
	SAFshorttextType PostalCode;
	SAFmiddle1textType Region;
	ISOCountryCode Country;
	char AddressType;
} AddressStructure;

// GroupIdentification ...
typedef struct {
	SAFmiddle2textType GroupNameCyrillic;
	SAFmiddle2textType GroupNameLatin;
	ISOCountryCode Country;
} GroupIdentification;

// DirectOwnerIdentification ...
typedef struct {
	SAFmiddle2textType OwnerNameCyrillic;
	SAFmiddle2textType LegalFormCyrillic;
	SAFmiddle2textType OwnerNameLatin;
	SAFmiddle2textType LegalFormLatin;
	ISOCountryCode OwnerCountry;
	SAFmiddle1textType OwnerUIC;
	float OwnershipPercentage;
} DirectOwnerIdentification;

// UltimateOwnerIdentificationBG ...
typedef struct {
	SAFmiddle2textType UltimateOwnerNameCyrillicBG;
	SAFmiddle1textType UltimateOwnerUICBG;
	SAFmiddle1textType UltimateOwnerEGNBG;
} UltimateOwnerIdentificationBG;

// UltimateOwnerIdentificationForeign ...
typedef struct {
	SAFmiddle2textType UltimateOwnerNameCyrillicForeign;
	SAFmiddle2textType UltimateOwnerNameLatinForeign;
	ISOCountryCode CountryForeign;
} UltimateOwnerIdentificationForeign;

// OwnershipStructure ...
typedef struct {
	SAFmiddle1textType IsPartOfGroup;
	SAFmiddle2textType UltimateOwnerNameCyrillic;
	SAFmiddle2textType UltimateOwnerNameLatin;
	SAFmiddle1textType UltimateOwnerUIC;
	SAFmiddle1textType UltimateOwnerEGN;
	GroupIdentification GroupIdentification;
	DirectOwnerIdentification DirectOwnerIdentification;
	UltimateOwnerIdentificationBG UltimateOwnerIdentificationBG;
	UltimateOwnerIdentificationForeign UltimateOwnerIdentificationForeign;
} OwnershipStructure;

// AmountStructure ...
typedef struct {
	SAFmonetaryType Amount;
	ISOCurrencyCode CurrencyCode;
	SAFmonetaryType CurrencyAmount;
	SAFexchangerateType ExchangeRate;
} AmountStructure;

// AnalysisStructure ...
typedef struct {
	SAFcodeType AnalysisType;
	SAFlongtextType AnalysisID;
	AmountStructure AnalysisAmount;
} AnalysisStructure;

// BankAccountStructure ...
typedef struct {
	SAFmiddle1textType IBANNumber;
	SAFmiddle1textType BankAccountNumber;
	SAFmiddle2textType BankAccountName;
	SAFshorttextType SortCode;
} BankAccountStructure;

// CompanyHeaderStructure ...
typedef struct {
	SAFmiddle1textType RegistrationNumber;
	SAFmiddle2textType Name;
	SAFmiddle2textType NameLatin;
	AddressStructure Address[];
	ContactInformationStructure Contact[];
	TaxIDStructure TaxRegistration[];
	BankAccountStructure BankAccount[];
	SAFshorttextType RelatedParty;
	char RelatedPartyStartDate;
	SAFshorttextType RelatedParty;
} CompanyHeaderStructure;

// CompanyStructure ...
typedef struct {
	SAFmiddle1textType RegistrationNumber;
	SAFmiddle2textType Name;
	SAFmiddle2textType NameLatin;
	AddressStructure Address[];
	ContactInformationStructure Contact[];
	TaxIDStructure TaxRegistration[];
	BankAccountStructure BankAccount[];
	RelatedParty RelatedParty;
	char RelatedPartyStartDate;
	char RelatedPartyEndDate;
} CompanyStructure;

// ContactHeaderStructure ...
typedef struct {
	PersonNameStructure ContactPerson;
	SAFshorttextType Telephone;
	SAFshorttextType Fax;
	SAFmiddle2textType Email;
	RelatedParty RelatedParty;
} ContactHeaderStructure;

// ContactInformationStructure ...
typedef struct {
	PersonNameStructure ContactPerson;
	SAFshorttextType Telephone;
	SAFshorttextType Fax;
	SAFmiddle2textType Email;
	char Website;
} ContactInformationStructure;

// HeaderStructure ...
typedef struct {
	SAFcodeType AuditFileVersion;
	ISOCountryCode AuditFileCountry;
	SAFcodeType AuditFileRegion;
	char AuditFileDateCreated;
	SAFmiddle2textType SoftwareCompanyName;
	SAFlongtextType SoftwareID;
	SAFshorttextType SoftwareVersion;
	CompanyHeaderStructure Company;
	OwnershipStructure Ownership;
	ISOCurrencyCode DefaultCurrencyCode;
	SelectionCriteriaStructure SelectionCriteria;
	SAFlongtextType HeaderComment;
	SAFcodeType SegmentIndex;
	SAFcodeType TotalSegmentsInsequence;
} HeaderStructure;

// PersonNameStructure ...
typedef struct {
	SAFcodeType Title;
	SAFmiddle1textType FirstName;
	SAFshorttextType Initials;
	SAFshorttextType LastNamePrefix;
	SAFmiddle2textType LastName;
	SAFmiddle2textType BirthName;
	SAFshorttextType Salutation;
	SAFshorttextType OtherTitles[];
} PersonNameStructure;

// SelectionCriteriaStructure ...
typedef struct {
	SAFmiddle1textType TaxReportingJurisdiction;
	SAFmiddle2textType CompanyEntity;
	char SelectionStartDate;
	char SelectionEndDate;
	int PeriodStart;
	int PeriodStartYear;
	int PeriodEnd;
	int PeriodEndYear;
	SAFlongtextType DocumentType;
	SAFlongtextType OtherCriteria[];
} SelectionCriteriaStructure;

// TaxIDStructure ...
typedef struct {
	SAFmiddle1textType TaxRegistrationNumber;
	SAFcodeType TaxType;
	SAFmiddle1textType TaxNumber;
	SAFmiddle1textType TaxAuthority;
	char TaxVerificationDate;
} TaxIDStructure;

// TaxInformationStructure ...
typedef struct {
	SAFcodeType TaxType;
	SAFcodeType TaxCode;
	float TaxPercentage;
	float TaxBase;
	SAFmiddle2textType TaxBaseDescription;
	AmountStructure TaxAmount;
	SAFmiddle2textType TaxExemptionReason;
	SAFmiddle1textType TaxDeclarationPeriod;
} TaxInformationStructure;

// Date ...
typedef char Date;

// Decimal ...
typedef float Decimal;

// Time ...
typedef char Time;
