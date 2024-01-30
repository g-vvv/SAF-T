package schema

import (
	"time"
)

// Header ...
type Header struct {
	TaxAccountingBasis *SAFshortTextType   `xml:"TaxAccountingBasis"`
	TaxEntity          *SAFmiddle2TextType `xml:"TaxEntity"`
	*HeaderStructure
}

// Account ...
type Account struct {
	AccountID            *SAFmiddle2TextType `xml:"AccountID"`
	AccountDescription   *SAFlongTextType    `xml:"AccountDescription"`
	TaxpayerAccountID    *SAFmiddle1TextType `xml:"TaxpayerAccountID"`
	GroupingCategory     *SAFmiddle1TextType `xml:"GroupingCategory"`
	GroupingCode         *SAFmiddle1TextType `xml:"GroupingCode"`
	AccountType          *SAFshortTextType   `xml:"AccountType"`
	AccountCreationDate  string              `xml:"AccountCreationDate"`
	OpeningDebitBalance  *SAFmonetaryType    `xml:"OpeningDebitBalance"`
	OpeningCreditBalance *SAFmonetaryType    `xml:"OpeningCreditBalance"`
	ClosingDebitBalance  *SAFmonetaryType    `xml:"ClosingDebitBalance"`
	ClosingCreditBalance *SAFmonetaryType    `xml:"ClosingCreditBalance"`
}

// GeneralLedgerAccounts ...
type GeneralLedgerAccounts struct {
	Account []*Account `xml:"Account"`
}

// TaxonomyElement ...
type TaxonomyElement struct {
	TaxonomyCode             *SAFlongTextType    `xml:"TaxonomyCode"`
	TaxonomyClusterID        *SAFlongTextType    `xml:"TaxonomyClusterID"`
	TaxonomyClusterContextID *SAFlongTextType    `xml:"TaxonomyClusterContextID"`
	AccountID                *SAFmiddle2TextType `xml:"AccountID"`
}

// Taxonomy ...
type Taxonomy struct {
	TaxonomyReference *SAFlongTextType   `xml:"TaxonomyReference"`
	TaxonomyElement   []*TaxonomyElement `xml:"TaxonomyElement"`
}

// Taxonomies ...
type Taxonomies struct {
	Taxonomy []*Taxonomy `xml:"Taxonomy"`
}

// Customer ...
type Customer struct {
	CompanyStructure     *CompanyStructure   `xml:"CompanyStructure"`
	CustomerID           *SAFmiddle1TextType `xml:"CustomerID"`
	SelfBillingIndicator *SAFcodeType        `xml:"SelfBillingIndicator"`
	AccountID            *SAFmiddle2TextType `xml:"AccountID"`
	OpeningDebitBalance  *SAFmonetaryType    `xml:"OpeningDebitBalance"`
	OpeningCreditBalance *SAFmonetaryType    `xml:"OpeningCreditBalance"`
	ClosingDebitBalance  *SAFmonetaryType    `xml:"ClosingDebitBalance"`
	ClosingCreditBalance *SAFmonetaryType    `xml:"ClosingCreditBalance"`
}

// Customers ...
type Customers struct {
	Customer []*Customer `xml:"Customer"`
}

// Supplier ...
type Supplier struct {
	CompanyStructure     *CompanyStructure   `xml:"CompanyStructure"`
	SupplierID           *SAFmiddle1TextType `xml:"SupplierID"`
	SelfBillingIndicator *SAFcodeType        `xml:"SelfBillingIndicator"`
	AccountID            *SAFmiddle2TextType `xml:"AccountID"`
	OpeningDebitBalance  *SAFmonetaryType    `xml:"OpeningDebitBalance"`
	OpeningCreditBalance *SAFmonetaryType    `xml:"OpeningCreditBalance"`
	ClosingDebitBalance  *SAFmonetaryType    `xml:"ClosingDebitBalance"`
	ClosingCreditBalance *SAFmonetaryType    `xml:"ClosingCreditBalance"`
}

// Suppliers ...
type Suppliers struct {
	Supplier []*Supplier `xml:"Supplier"`
}

// TaxCodeDetails ...
type TaxCodeDetails struct {
	TaxCode        *SAFcodeType     `xml:"TaxCode"`
	EffectiveDate  string           `xml:"EffectiveDate"`
	ExpirationDate string           `xml:"ExpirationDate"`
	Description    *SAFlongTextType `xml:"Description"`
	TaxPercentage  float64          `xml:"TaxPercentage"`
	FlatTaxRate    *AmountStructure `xml:"FlatTaxRate"`
	BaseRate       []*SAFbaseRate   `xml:"BaseRate"`
	Country        *ISOCountryCode  `xml:"Country"`
	Region         *SAFcodeType     `xml:"Region"`
}

// TaxTableEntry ...
type TaxTableEntry struct {
	TaxType        *SAFcodeType      `xml:"TaxType"`
	Description    *SAFlongTextType  `xml:"Description"`
	TaxCodeDetails []*TaxCodeDetails `xml:"TaxCodeDetails"`
}

// TaxTable ...
type TaxTable struct {
	TaxTableEntry []*TaxTableEntry `xml:"TaxTableEntry"`
}

// UOMTableEntry ...
type UOMTableEntry struct {
	UnitOfMeasure *SAFcodeType     `xml:"UnitOfMeasure"`
	Description   *SAFlongTextType `xml:"Description"`
}

// UOMTable ...
type UOMTable struct {
	UOMTableEntry []*UOMTableEntry `xml:"UOMTableEntry"`
}

// AnalysisTypeTableEntry ...
type AnalysisTypeTableEntry struct {
	AnalysisType            *SAFcodeType        `xml:"AnalysisType"`
	AnalysisTypeDescription *SAFlongTextType    `xml:"AnalysisTypeDescription"`
	AnalysisID              *SAFmiddle1TextType `xml:"AnalysisID"`
	AnalysisIDDescription   *SAFlongTextType    `xml:"AnalysisIDDescription"`
}

// AnalysisTypeTable ...
type AnalysisTypeTable struct {
	AnalysisTypeTableEntry []*AnalysisTypeTableEntry `xml:"AnalysisTypeTableEntry"`
}

// MovementTypeTableEntry ...
type MovementTypeTableEntry struct {
	MovementType *SAFcodeType     `xml:"MovementType"`
	Description  *SAFlongTextType `xml:"Description"`
}

// MovementTypeTable ...
type MovementTypeTable struct {
	MovementTypeTableEntry []*MovementTypeTableEntry `xml:"MovementTypeTableEntry"`
}

// Tax ...
type Tax struct {
	TaxType *SAFcodeType `xml:"TaxType"`
	TaxCode *SAFcodeType `xml:"TaxCode"`
}

// Product ...
type Product struct {
	ProductCode                  *SAFmiddle2TextType `xml:"ProductCode"`
	GoodsServicesID              *SAFcodeType        `xml:"GoodsServicesID"`
	ProductGroup                 *SAFmiddle2TextType `xml:"ProductGroup"`
	Description                  *SAFlongTextType    `xml:"Description"`
	ProductCommodityCode         *SAFmiddle1TextType `xml:"ProductCommodityCode"`
	ProductNumberCode            *SAFmiddle2TextType `xml:"ProductNumberCode"`
	ValuationMethod              *SAFcodeType        `xml:"ValuationMethod"`
	UOMBase                      *SAFcodeType        `xml:"UOMBase"`
	UOMStandard                  *SAFcodeType        `xml:"UOMStandard"`
	UOMToUOMBaseConversionFactor float64             `xml:"UOMToUOMBaseConversionFactor"`
	Tax                          []*Tax              `xml:"Tax"`
}

// Products ...
type Products struct {
	Product []*Product `xml:"Product"`
}

// StockCharacteristics ...
type StockCharacteristics struct {
	StockCharacteristic      *SAFshortTextType   `xml:"StockCharacteristic"`
	StockCharacteristicValue *SAFmiddle1TextType `xml:"StockCharacteristicValue"`
}

// PhysicalStockEntry ...
type PhysicalStockEntry struct {
	WarehouseID                  *SAFmiddle1TextType   `xml:"WarehouseID"`
	LocationID                   *SAFshortTextType     `xml:"LocationID"`
	ProductCode                  *SAFmiddle2TextType   `xml:"ProductCode"`
	StockAccountNo               *SAFmiddle2TextType   `xml:"StockAccountNo"`
	ProductType                  *SAFshortTextType     `xml:"ProductType"`
	ProductStatus                *SAFshortTextType     `xml:"ProductStatus"`
	StockAccountCommodityCode    *SAFmiddle1TextType   `xml:"StockAccountCommodityCode"`
	OwnerID                      *SAFmiddle1TextType   `xml:"OwnerID"`
	UOMPhysicalStock             *SAFcodeType          `xml:"UOMPhysicalStock"`
	UOMToUOMBaseConversionFactor float64               `xml:"UOMToUOMBaseConversionFactor"`
	UnitPrice                    *SAFmonetaryType      `xml:"UnitPrice"`
	OpeningStockQuantity         *SAFquantityType      `xml:"OpeningStockQuantity"`
	OpeningStockValue            *SAFmonetaryType      `xml:"OpeningStockValue"`
	ClosingStockQuantity         *SAFquantityType      `xml:"ClosingStockQuantity"`
	ClosingStockValue            *SAFmonetaryType      `xml:"ClosingStockValue"`
	StockCharacteristics         *StockCharacteristics `xml:"StockCharacteristics"`
}

// PhysicalStock ...
type PhysicalStock struct {
	PhysicalStockEntry []*PhysicalStockEntry `xml:"PhysicalStockEntry"`
}

// Owner ...
type Owner struct {
	CompanyStructure *CompanyStructure   `xml:"CompanyStructure"`
	OwnerID          *SAFmiddle1TextType `xml:"OwnerID"`
	AccountID        *SAFmiddle2TextType `xml:"AccountID"`
}

// Owners ...
type Owners struct {
	Owner []*Owner `xml:"Owner"`
}

// AssetSupplier ...
type AssetSupplier struct {
	SupplierName  *SAFmiddle2TextType `xml:"SupplierName"`
	SupplierID    *SAFmiddle1TextType `xml:"SupplierID"`
	PostalAddress *AddressStructure   `xml:"PostalAddress"`
}

// ExtraordinaryDepreciationForPeriod ...
type ExtraordinaryDepreciationForPeriod struct {
	ExtraordinaryDepreciationMethod          *SAFmiddle1TextType `xml:"ExtraordinaryDepreciationMethod"`
	ExtraordinaryDepreciationAmountForPeriod *SAFmonetaryType    `xml:"ExtraordinaryDepreciationAmountForPeriod"`
}

// ExtraordinaryDepreciationsForPeriod ...
type ExtraordinaryDepreciationsForPeriod struct {
	ExtraordinaryDepreciationForPeriod []*ExtraordinaryDepreciationForPeriod `xml:"ExtraordinaryDepreciationForPeriod"`
}

// Valuation ...
type Valuation struct {
	AssetValuationType                  *SAFshortTextType                    `xml:"AssetValuationType"`
	ValuationClass                      *SAFshortTextType                    `xml:"ValuationClass"`
	AcquisitionAndProductionCostsBegin  *SAFmonetaryType                     `xml:"AcquisitionAndProductionCostsBegin"`
	AcquisitionAndProductionCostsEnd    *SAFmonetaryType                     `xml:"AcquisitionAndProductionCostsEnd"`
	InvestmentSupport                   *SAFmonetaryType                     `xml:"InvestmentSupport"`
	AssetLifeYear                       float64                              `xml:"AssetLifeYear"`
	AssetLifeMonth                      float64                              `xml:"AssetLifeMonth"`
	AssetAddition                       *SAFmonetaryType                     `xml:"AssetAddition"`
	Transfers                           *SAFmonetaryType                     `xml:"Transfers"`
	AssetDisposal                       *SAFmonetaryType                     `xml:"AssetDisposal"`
	BookValueBegin                      *SAFmonetaryType                     `xml:"BookValueBegin"`
	DepreciationMethod                  *SAFmiddle1TextType                  `xml:"DepreciationMethod"`
	DepreciationPercentage              float64                              `xml:"DepreciationPercentage"`
	DepreciationForPeriod               *SAFmonetaryType                     `xml:"DepreciationForPeriod"`
	AppreciationForPeriod               *SAFmonetaryType                     `xml:"AppreciationForPeriod"`
	ExtraordinaryDepreciationsForPeriod *ExtraordinaryDepreciationsForPeriod `xml:"ExtraordinaryDepreciationsForPeriod"`
	AccumulatedDepreciation             *SAFmonetaryType                     `xml:"AccumulatedDepreciation"`
	BookValueEnd                        *SAFmonetaryType                     `xml:"BookValueEnd"`
}

// Valuations ...
type Valuations struct {
	Valuation []*Valuation `xml:"Valuation"`
}

// Asset ...
type Asset struct {
	AssetID           *SAFmiddle1TextType `xml:"AssetID"`
	AccountID         *SAFmiddle2TextType `xml:"AccountID"`
	Description       *SAFlongTextType    `xml:"Description"`
	AssetSupplier     []*AssetSupplier    `xml:"AssetSupplier"`
	PurchaseOrderDate string              `xml:"PurchaseOrderDate"`
	DateOfAcquisition string              `xml:"DateOfAcquisition"`
	StartUpDate       string              `xml:"StartUpDate"`
	Valuations        *Valuations         `xml:"Valuations"`
}

// Assets ...
type Assets struct {
	Asset []*Asset `xml:"Asset"`
}

// MasterFiles ...
type MasterFiles struct {
	GeneralLedgerAccounts *GeneralLedgerAccounts `xml:"GeneralLedgerAccounts"`
	Taxonomies            *Taxonomies            `xml:"Taxonomies"`
	Customers             *Customers             `xml:"Customers"`
	Suppliers             *Suppliers             `xml:"Suppliers"`
	TaxTable              *TaxTable              `xml:"TaxTable"`
	UOMTable              *UOMTable              `xml:"UOMTable"`
	AnalysisTypeTable     *AnalysisTypeTable     `xml:"AnalysisTypeTable"`
	MovementTypeTable     *MovementTypeTable     `xml:"MovementTypeTable"`
	Products              *Products              `xml:"Products"`
	PhysicalStock         *PhysicalStock         `xml:"PhysicalStock"`
	Owners                *Owners                `xml:"Owners"`
	Assets                *Assets                `xml:"Assets"`
}

// ReportLineValues ...
type ReportLineValues struct {
	DebitOpeningBalance  *SAFmonetaryType `xml:"DebitOpeningBalance"`
	CreditOpeningBalance *SAFmonetaryType `xml:"CreditOpeningBalance"`
	DebitTurnover        *SAFmonetaryType `xml:"DebitTurnover"`
	CreditTurnover       *SAFmonetaryType `xml:"CreditTurnover"`
	DebitClosingBalance  *SAFmonetaryType `xml:"DebitClosingBalance"`
	CreditClosingBalance *SAFmonetaryType `xml:"CreditClosingBalance"`
}

// ReportLine ...
type ReportLine struct {
	LineNo                 *SAFmiddle2TextType `xml:"LineNo"`
	AccountID              *SAFmiddle2TextType `xml:"AccountID"`
	CorrespondingAccountID *SAFmiddle2TextType `xml:"CorrespondingAccountID"`
	Period                 int                 `xml:"Period"`
	PeriodYear             int                 `xml:"PeriodYear"`
	ReportLineValues       []*ReportLineValues `xml:"ReportLineValues"`
}

// CorrespondingAccountsReportTotals ...
type CorrespondingAccountsReportTotals struct {
	TotalDebitOpeningBalance  *SAFmonetaryType `xml:"TotalDebitOpeningBalance"`
	TotalCreditOpeningBalance *SAFmonetaryType `xml:"TotalCreditOpeningBalance"`
	TotalDebit                *SAFmonetaryType `xml:"TotalDebit"`
	TotalCredit               *SAFmonetaryType `xml:"TotalCredit"`
	TotalDebitClosingBalance  *SAFmonetaryType `xml:"TotalDebitClosingBalance"`
	TotalCreditClosingBalance *SAFmonetaryType `xml:"TotalCreditClosingBalance"`
	ReportLine                []*ReportLine    `xml:"ReportLine"`
}

// CorrespondingAccountsReport ...
type CorrespondingAccountsReport struct {
	CorrespondingAccountsReportTotals *CorrespondingAccountsReportTotals `xml:"CorrespondingAccountsReportTotals"`
}

// TransactionLine ...
type TransactionLine struct {
	RecordID          *SAFshortTextType          `xml:"RecordID"`
	AccountID         *SAFmiddle2TextType        `xml:"AccountID"`
	TaxpayerAccountID *SAFmiddle1TextType        `xml:"TaxpayerAccountID"`
	Analysis          []*AnalysisStructure       `xml:"Analysis"`
	ValueDate         string                     `xml:"ValueDate"`
	SourceDocumentID  *SAFmiddle1TextType        `xml:"SourceDocumentID"`
	CustomerID        *SAFmiddle1TextType        `xml:"CustomerID"`
	SupplierID        *SAFmiddle1TextType        `xml:"SupplierID"`
	Description       *SAFlongTextType           `xml:"Description"`
	DebitAmount       *AmountStructure           `xml:"DebitAmount"`
	CreditAmount      *AmountStructure           `xml:"CreditAmount"`
	TaxInformation    []*TaxInformationStructure `xml:"TaxInformation"`
}

// Transaction ...
type Transaction struct {
	TransactionID   *SAFmiddle2TextType `xml:"TransactionID"`
	Period          int                 `xml:"Period"`
	PeriodYear      int                 `xml:"PeriodYear"`
	TransactionDate string              `xml:"TransactionDate"`
	SourceID        *SAFmiddle1TextType `xml:"SourceID"`
	TransactionType *SAFshortTextType   `xml:"TransactionType"`
	Description     *SAFlongTextType    `xml:"Description"`
	BatchID         *SAFmiddle1TextType `xml:"BatchID"`
	SystemEntryDate string              `xml:"SystemEntryDate"`
	GLPostingDate   string              `xml:"GLPostingDate"`
	CustomerID      *SAFmiddle1TextType `xml:"CustomerID"`
	SupplierID      *SAFmiddle1TextType `xml:"SupplierID"`
	SystemID        *SAFshortTextType   `xml:"SystemID"`
	TransactionLine []*TransactionLine  `xml:"TransactionLine"`
}

// Journal ...
type Journal struct {
	JournalID   *SAFshortTextType `xml:"JournalID"`
	Description *SAFlongTextType  `xml:"Description"`
	Type        *SAFcodeType      `xml:"Type"`
	Transaction []*Transaction    `xml:"Transaction"`
}

// GeneralLedgerEntries ...
type GeneralLedgerEntries struct {
	NumberOfEntries int              `xml:"NumberOfEntries"`
	TotalDebit      *SAFmonetaryType `xml:"TotalDebit"`
	TotalCredit     *SAFmonetaryType `xml:"TotalCredit"`
	Journal         []*Journal       `xml:"Journal"`
}

// SalesInvoices ...
type SalesInvoices struct {
	NumberOfEntries int                 `xml:"NumberOfEntries"`
	TotalDebit      *SAFmonetaryType    `xml:"TotalDebit"`
	TotalCredit     *SAFmonetaryType    `xml:"TotalCredit"`
	Invoice         []*InvoiceStructure `xml:"Invoice"`
}

// PurchaseInvoices ...
type PurchaseInvoices struct {
	NumberOfEntries int                 `xml:"NumberOfEntries"`
	TotalDebit      *SAFmonetaryType    `xml:"TotalDebit"`
	TotalCredit     *SAFmonetaryType    `xml:"TotalCredit"`
	Invoice         []*InvoiceStructure `xml:"Invoice"`
}

// PaymentLine ...
type PaymentLine struct {
	LineNumber           *SAFshortTextType          `xml:"LineNumber"`
	SourceDocumentID     *SAFmiddle1TextType        `xml:"SourceDocumentID"`
	AccountID            *SAFmiddle2TextType        `xml:"AccountID"`
	Analysis             []*AnalysisStructure       `xml:"Analysis"`
	CustomerID           *SAFmiddle1TextType        `xml:"CustomerID"`
	SupplierID           *SAFmiddle1TextType        `xml:"SupplierID"`
	TaxPointDate         string                     `xml:"TaxPointDate"`
	Description          *SAFlongTextType           `xml:"Description"`
	DebitCreditIndicator *SAFcodeType               `xml:"DebitCreditIndicator"`
	PaymentLineAmount    *AmountStructure           `xml:"PaymentLineAmount"`
	TaxInformation       []*TaxInformationStructure `xml:"TaxInformation"`
}

// PaymentSettlement ...
type PaymentSettlement struct {
	SettlementDiscount *SAFmiddle1TextType `xml:"SettlementDiscount"`
	SettlementAmount   *AmountStructure    `xml:"SettlementAmount"`
	SettlementDate     string              `xml:"SettlementDate"`
	PaymentMechanism   *SAFcodeType        `xml:"PaymentMechanism"`
}

// PaymentDocumentTotals ...
type PaymentDocumentTotals struct {
	TaxInformationTotals []*TaxInformationStructure `xml:"TaxInformationTotals"`
	NetTotal             *SAFmonetaryType           `xml:"NetTotal"`
	GrossTotal           *SAFmonetaryType           `xml:"GrossTotal"`
}

// Payment ...
type Payment struct {
	PaymentRefNo          *SAFmiddle1TextType    `xml:"PaymentRefNo"`
	Period                int                    `xml:"Period"`
	PeriodYear            int                    `xml:"PeriodYear"`
	TransactionID         *SAFmiddle2TextType    `xml:"TransactionID"`
	TransactionDate       string                 `xml:"TransactionDate"`
	PaymentMethod         *SAFshortTextType      `xml:"PaymentMethod"`
	Description           *SAFlongTextType       `xml:"Description"`
	BatchID               *SAFmiddle1TextType    `xml:"BatchID"`
	SystemID              *SAFmiddle1TextType    `xml:"SystemID"`
	SourceID              *SAFmiddle1TextType    `xml:"SourceID"`
	PaymentLine           []*PaymentLine         `xml:"PaymentLine"`
	PaymentSettlement     *PaymentSettlement     `xml:"PaymentSettlement"`
	PaymentDocumentTotals *PaymentDocumentTotals `xml:"PaymentDocumentTotals"`
}

// Payments ...
type Payments struct {
	NumberOfEntries int              `xml:"NumberOfEntries"`
	TotalDebit      *SAFmonetaryType `xml:"TotalDebit"`
	TotalCredit     *SAFmonetaryType `xml:"TotalCredit"`
	Payment         []*Payment       `xml:"Payment"`
}

// DocumentReference ...
type DocumentReference struct {
	DocumentType   *SAFshortTextType   `xml:"DocumentType"`
	DocumentNumber *SAFmiddle1TextType `xml:"DocumentNumber"`
	DocumentLine   *SAFshortTextType   `xml:"DocumentLine"`
}

// StockMovementLine ...
type StockMovementLine struct {
	LineNumber                            *SAFshortTextType          `xml:"LineNumber"`
	AccountID                             *SAFmiddle2TextType        `xml:"AccountID"`
	TransactionID                         *SAFmiddle2TextType        `xml:"TransactionID"`
	CustomerID                            *SAFmiddle1TextType        `xml:"CustomerID"`
	SupplierID                            *SAFmiddle1TextType        `xml:"SupplierID"`
	ShipTo                                *ShippingPointStructure    `xml:"ShipTo"`
	ShipFrom                              *ShippingPointStructure    `xml:"ShipFrom"`
	ProductCode                           *SAFmiddle2TextType        `xml:"ProductCode"`
	StockAccountNo                        *SAFmiddle2TextType        `xml:"StockAccountNo"`
	Quantity                              *SAFquantityType           `xml:"Quantity"`
	UnitOfMeasure                         *SAFcodeType               `xml:"UnitOfMeasure"`
	UOMToUOMPhysicalStockConversionFactor float64                    `xml:"UOMToUOMPhysicalStockConversionFactor"`
	BookValue                             *SAFmonetaryType           `xml:"BookValue"`
	MovementSubType                       *SAFcodeType               `xml:"MovementSubType"`
	MovementComments                      *SAFlongTextType           `xml:"MovementComments"`
	TaxInformation                        []*TaxInformationStructure `xml:"TaxInformation"`
}

// StockMovement ...
type StockMovement struct {
	MovementReference   *SAFmiddle1TextType  `xml:"MovementReference"`
	MovementDate        string               `xml:"MovementDate"`
	MovementPostingDate string               `xml:"MovementPostingDate"`
	MovementPostingTime time.Time            `xml:"MovementPostingTime"`
	TaxPointDate        string               `xml:"TaxPointDate"`
	MovementType        *SAFcodeType         `xml:"MovementType"`
	SourceID            *SAFmiddle1TextType  `xml:"SourceID"`
	SystemID            *SAFmiddle1TextType  `xml:"SystemID"`
	DocumentReference   *DocumentReference   `xml:"DocumentReference"`
	StockMovementLine   []*StockMovementLine `xml:"StockMovementLine"`
}

// MovementOfGoods ...
type MovementOfGoods struct {
	NumberOfMovementLines int              `xml:"NumberOfMovementLines"`
	TotalQuantityReceived *SAFquantityType `xml:"TotalQuantityReceived"`
	TotalQuantityIssued   *SAFquantityType `xml:"TotalQuantityIssued"`
	StockMovement         []*StockMovement `xml:"StockMovement"`
}

// AssetTransactionValuation ...
type AssetTransactionValuation struct {
	AssetValuationType                         *SAFshortTextType `xml:"AssetValuationType"`
	AcquisitionAndProductionCostsOnTransaction *SAFmonetaryType  `xml:"AcquisitionAndProductionCostsOnTransaction"`
	BookValueOnTransaction                     *SAFmonetaryType  `xml:"BookValueOnTransaction"`
	AssetTransactionAmount                     *SAFmonetaryType  `xml:"AssetTransactionAmount"`
}

// AssetTransactionValuations ...
type AssetTransactionValuations struct {
	AssetTransactionValuation []*AssetTransactionValuation `xml:"AssetTransactionValuation"`
}

// AssetTransaction ...
type AssetTransaction struct {
	AssetTransactionID         *SAFmiddle2TextType         `xml:"AssetTransactionID"`
	AssetID                    *SAFmiddle1TextType         `xml:"AssetID"`
	AssetTransactionType       *SAFcodeType                `xml:"AssetTransactionType"`
	Description                *SAFlongTextType            `xml:"Description"`
	AssetTransactionDate       string                      `xml:"AssetTransactionDate"`
	AssetSupplier              *AssetSupplier              `xml:"AssetSupplier"`
	TransactionID              *SAFmiddle2TextType         `xml:"TransactionID"`
	AssetTransactionValuations *AssetTransactionValuations `xml:"AssetTransactionValuations"`
}

// AssetTransactions ...
type AssetTransactions struct {
	NumberOfAssetTransactions int                 `xml:"NumberOfAssetTransactions"`
	AssetTransaction          []*AssetTransaction `xml:"AssetTransaction"`
}

// SourceDocuments ...
type SourceDocuments struct {
	SalesInvoices     *SalesInvoices     `xml:"SalesInvoices"`
	PurchaseInvoices  *PurchaseInvoices  `xml:"PurchaseInvoices"`
	Payments          *Payments          `xml:"Payments"`
	MovementOfGoods   *MovementOfGoods   `xml:"MovementOfGoods"`
	AssetTransactions *AssetTransactions `xml:"AssetTransactions"`
}

// AuditFile ...
type AuditFile struct {
	Header                      *Header                      `xml:"Header"`
	MasterFiles                 *MasterFiles                 `xml:"MasterFiles"`
	CorrespondingAccountsReport *CorrespondingAccountsReport `xml:"CorrespondingAccountsReport"`
	GeneralLedgerEntries        *GeneralLedgerEntries        `xml:"GeneralLedgerEntries"`
	SourceDocuments             *SourceDocuments             `xml:"SourceDocuments"`
}

// DebitCreditIndicator is Net amount of related asset transaction in the header’s default currency, for instance the net sale revenue.
type DebitCreditIndicator *SAFcodeType

// CustomerInfo ...
type CustomerInfo struct {
	CustomerID     *SAFmiddle1TextType `xml:"CustomerID"`
	Name           *SAFmiddle2TextType `xml:"Name"`
	BillingAddress *AddressStructure   `xml:"BillingAddress"`
}

// SupplierInfo ...
type SupplierInfo struct {
	SupplierID     *SAFmiddle1TextType `xml:"SupplierID"`
	Name           *SAFmiddle2TextType `xml:"Name"`
	BillingAddress *AddressStructure   `xml:"BillingAddress"`
}

// OrderReferences ...
type OrderReferences struct {
	OriginatingON *SAFmiddle2TextType `xml:"OriginatingON"`
	OrderDate     string              `xml:"OrderDate"`
}

// DeliveryPeriod ...
type DeliveryPeriod struct {
	FromDate string `xml:"FromDate"`
	ToDate   string `xml:"ToDate"`
}

// Delivery ...
type Delivery struct {
	MovementReference []*SAFmiddle1TextType `xml:"MovementReference"`
	DeliveryDate      string                `xml:"DeliveryDate"`
	DeliveryPeriod    *DeliveryPeriod       `xml:"DeliveryPeriod"`
}

// CreditNote ...
type CreditNote struct {
	Reference *SAFmiddle1TextType `xml:"Reference"`
	Reason    *SAFlongTextType    `xml:"Reason"`
}

// References ...
type References struct {
	CreditNote *CreditNote `xml:"CreditNote"`
}

// InvoiceLine ...
type InvoiceLine struct {
	LineNumber                   *SAFshortTextType          `xml:"LineNumber"`
	AccountID                    *SAFmiddle2TextType        `xml:"AccountID"`
	Analysis                     []*AnalysisStructure       `xml:"Analysis"`
	OrderReferences              []*OrderReferences         `xml:"OrderReferences"`
	ShipTo                       *ShippingPointStructure    `xml:"ShipTo"`
	ShipFrom                     *ShippingPointStructure    `xml:"ShipFrom"`
	GoodsServicesID              *SAFcodeType               `xml:"GoodsServicesID"`
	ProductCode                  *SAFmiddle2TextType        `xml:"ProductCode"`
	ProductDescription           *SAFlongTextType           `xml:"ProductDescription"`
	Delivery                     *Delivery                  `xml:"Delivery"`
	Quantity                     *SAFquantityType           `xml:"Quantity"`
	InvoiceUOM                   *SAFcodeType               `xml:"InvoiceUOM"`
	UOMToUOMBaseConversionFactor float64                    `xml:"UOMToUOMBaseConversionFactor"`
	UnitPrice                    *SAFmonetaryType           `xml:"UnitPrice"`
	TaxPointDate                 string                     `xml:"TaxPointDate"`
	References                   *References                `xml:"References"`
	Description                  *SAFlongTextType           `xml:"Description"`
	InvoiceLineAmount            *AmountStructure           `xml:"InvoiceLineAmount"`
	DebitCreditIndicator         *SAFcodeType               `xml:"DebitCreditIndicator"`
	ShippingCostsAmount          *AmountStructure           `xml:"ShippingCostsAmount"`
	TaxInformation               []*TaxInformationStructure `xml:"TaxInformation"`
}

// InvoiceSettlement ...
type InvoiceSettlement struct {
	SettlementDiscount *SAFmiddle1TextType `xml:"SettlementDiscount"`
	SettlementAmount   *AmountStructure    `xml:"SettlementAmount"`
	SettlementDate     string              `xml:"SettlementDate"`
	PaymentMechanism   *SAFcodeType        `xml:"PaymentMechanism"`
}

// InvoiceDocumentTotals ...
type InvoiceDocumentTotals struct {
	TaxInformationTotals     []*TaxInformationStructure `xml:"TaxInformationTotals"`
	ShippingCostsAmountTotal *SAFmonetaryType           `xml:"ShippingCostsAmountTotal"`
	NetTotal                 *SAFmonetaryType           `xml:"NetTotal"`
	GrossTotal               *SAFmonetaryType           `xml:"GrossTotal"`
}

// InvoiceStructure ...
type InvoiceStructure struct {
	InvoiceNo             *SAFmiddle2TextType     `xml:"InvoiceNo"`
	CustomerInfo          *CustomerInfo           `xml:"CustomerInfo"`
	SupplierInfo          *SupplierInfo           `xml:"SupplierInfo"`
	AccountID             *SAFmiddle2TextType     `xml:"AccountID"`
	BranchStoreNumber     *SAFmiddle1TextType     `xml:"BranchStoreNumber"`
	Period                int                     `xml:"Period"`
	PeriodYear            int                     `xml:"PeriodYear"`
	InvoiceDate           string                  `xml:"InvoiceDate"`
	InvoiceType           *SAFcodeType            `xml:"InvoiceType"`
	ShipTo                *ShippingPointStructure `xml:"ShipTo"`
	ShipFrom              *ShippingPointStructure `xml:"ShipFrom"`
	PaymentTerms          *SAFmiddle2TextType     `xml:"PaymentTerms"`
	SelfBillingIndicator  *SAFcodeType            `xml:"SelfBillingIndicator"`
	SourceID              *SAFmiddle1TextType     `xml:"SourceID"`
	GLPostingDate         string                  `xml:"GLPostingDate"`
	BatchID               *SAFmiddle1TextType     `xml:"BatchID"`
	SystemID              *SAFmiddle1TextType     `xml:"SystemID"`
	TransactionID         *SAFmiddle2TextType     `xml:"TransactionID"`
	ReceiptNumbers        *SAFlongTextType        `xml:"ReceiptNumbers"`
	InvoiceLine           []*InvoiceLine          `xml:"InvoiceLine"`
	InvoiceSettlement     *InvoiceSettlement      `xml:"InvoiceSettlement"`
	InvoiceDocumentTotals *InvoiceDocumentTotals  `xml:"InvoiceDocumentTotals"`
}

// ShippingPointStructure ...
type ShippingPointStructure struct {
	DeliveryID   *SAFmiddle1TextType `xml:"DeliveryID"`
	DeliveryDate string              `xml:"DeliveryDate"`
	WarehouseID  *SAFmiddle1TextType `xml:"WarehouseID"`
	LocationID   *SAFshortTextType   `xml:"LocationID"`
	UCR          *SAFmiddle1TextType `xml:"UCR"`
	Address      *AddressStructure   `xml:"Address"`
}

// AddressStructure ...
type AddressStructure struct {
	StreetName              *SAFmiddle2TextType `xml:"StreetName"`
	Number                  *SAFshortTextType   `xml:"Number"`
	AdditionalAddressDetail *SAFmiddle2TextType `xml:"AdditionalAddressDetail"`
	Building                *SAFmiddle1TextType `xml:"Building"`
	City                    *SAFmiddle1TextType `xml:"City"`
	PostalCode              *SAFshortTextType   `xml:"PostalCode"`
	Region                  *SAFmiddle1TextType `xml:"Region"`
	Country                 *ISOCountryCode     `xml:"Country"`
	AddressType             string              `xml:"AddressType"`
}

// GroupIdentification ...
type GroupIdentification struct {
	GroupNameCyrillic *SAFmiddle2TextType `xml:"GroupNameCyrillic"`
	GroupNameLatin    *SAFmiddle2TextType `xml:"GroupNameLatin"`
	Country           *ISOCountryCode     `xml:"Country"`
}

// DirectOwnerIdentification ...
type DirectOwnerIdentification struct {
	OwnerNameCyrillic   *SAFmiddle2TextType `xml:"OwnerNameCyrillic"`
	LegalFormCyrillic   *SAFmiddle2TextType `xml:"LegalFormCyrillic"`
	OwnerNameLatin      *SAFmiddle2TextType `xml:"OwnerNameLatin"`
	LegalFormLatin      *SAFmiddle2TextType `xml:"LegalFormLatin"`
	OwnerCountry        *ISOCountryCode     `xml:"OwnerCountry"`
	OwnerUIC            *SAFmiddle1TextType `xml:"OwnerUIC"`
	OwnershipPercentage float64             `xml:"OwnershipPercentage"`
}

// UltimateOwnerIdentificationBG ...
type UltimateOwnerIdentificationBG struct {
	UltimateOwnerNameCyrillicBG *SAFmiddle2TextType `xml:"UltimateOwnerNameCyrillicBG"`
	UltimateOwnerUICBG          *SAFmiddle1TextType `xml:"UltimateOwnerUICBG"`
	UltimateOwnerEGNBG          *SAFmiddle1TextType `xml:"UltimateOwnerEGNBG"`
}

// UltimateOwnerIdentificationForeign ...
type UltimateOwnerIdentificationForeign struct {
	UltimateOwnerNameCyrillicForeign *SAFmiddle2TextType `xml:"UltimateOwnerNameCyrillicForeign"`
	UltimateOwnerNameLatinForeign    *SAFmiddle2TextType `xml:"UltimateOwnerNameLatinForeign"`
	CountryForeign                   *ISOCountryCode     `xml:"CountryForeign"`
}

// OwnershipStructure ...
type OwnershipStructure struct {
	IsPartOfGroup                      *SAFmiddle1TextType                 `xml:"IsPartOfGroup"`
	UltimateOwnerNameCyrillic          *SAFmiddle2TextType                 `xml:"UltimateOwnerNameCyrillic"`
	UltimateOwnerNameLatin             *SAFmiddle2TextType                 `xml:"UltimateOwnerNameLatin"`
	UltimateOwnerUIC                   *SAFmiddle1TextType                 `xml:"UltimateOwnerUIC"`
	UltimateOwnerEGN                   *SAFmiddle1TextType                 `xml:"UltimateOwnerEGN"`
	GroupIdentification                *GroupIdentification                `xml:"GroupIdentification"`
	DirectOwnerIdentification          *DirectOwnerIdentification          `xml:"DirectOwnerIdentification"`
	UltimateOwnerIdentificationBG      *UltimateOwnerIdentificationBG      `xml:"UltimateOwnerIdentificationBG"`
	UltimateOwnerIdentificationForeign *UltimateOwnerIdentificationForeign `xml:"UltimateOwnerIdentificationForeign"`
}

// AmountStructure ...
type AmountStructure struct {
	Amount         *SAFmonetaryType     `xml:"Amount"`
	CurrencyCode   *ISOCurrencyCode     `xml:"CurrencyCode"`
	CurrencyAmount *SAFmonetaryType     `xml:"CurrencyAmount"`
	ExchangeRate   *SAFexchangerateType `xml:"ExchangeRate"`
}

// AnalysisStructure ...
type AnalysisStructure struct {
	AnalysisType   *SAFcodeType     `xml:"AnalysisType"`
	AnalysisID     *SAFlongTextType `xml:"AnalysisID"`
	AnalysisAmount *AmountStructure `xml:"AnalysisAmount"`
}

// BankAccountStructure ...
type BankAccountStructure struct {
	IBANNumber        *SAFmiddle1TextType `xml:"IBANNumber"`
	BankAccountNumber *SAFmiddle1TextType `xml:"BankAccountNumber"`
	BankAccountName   *SAFmiddle2TextType `xml:"BankAccountName"`
	SortCode          *SAFshortTextType   `xml:"SortCode"`
}

// CompanyHeaderStructure ...
type CompanyHeaderStructure struct {
	RegistrationNumber    *SAFmiddle1TextType            `xml:"RegistrationNumber"`
	Name                  *SAFmiddle2TextType            `xml:"Name"`
	NameLatin             *SAFmiddle2TextType            `xml:"NameLatin"`
	Address               []*AddressStructure            `xml:"Address"`
	Contact               []*ContactInformationStructure `xml:"Contact"`
	TaxRegistration       []*TaxIDStructure              `xml:"TaxRegistration"`
	BankAccount           []*BankAccountStructure        `xml:"BankAccount"`
	RelatedParty          *SAFshortTextType              `xml:"RelatedParty"`
	RelatedPartyStartDate string                         `xml:"RelatedPartyStartDate"`
}

// CompanyStructure ...
type CompanyStructure struct {
	RegistrationNumber    *SAFmiddle1TextType            `xml:"RegistrationNumber"`
	Name                  *SAFmiddle2TextType            `xml:"Name"`
	NameLatin             *SAFmiddle2TextType            `xml:"NameLatin"`
	Address               []*AddressStructure            `xml:"Address"`
	Contact               []*ContactInformationStructure `xml:"Contact"`
	TaxRegistration       []*TaxIDStructure              `xml:"TaxRegistration"`
	BankAccount           []*BankAccountStructure        `xml:"BankAccount"`
	RelatedParty          *SAFshortTextType              `xml:"RelatedParty"`
	RelatedPartyStartDate string                         `xml:"RelatedPartyStartDate"`
	RelatedPartyEndDate   string                         `xml:"RelatedPartyEndDate"`
}

// ContactHeaderStructure ...
type ContactHeaderStructure struct {
	ContactPerson *PersonNameStructure `xml:"ContactPerson"`
	Telephone     *SAFshortTextType    `xml:"Telephone"`
	Fax           *SAFshortTextType    `xml:"Fax"`
	Email         *SAFmiddle2TextType  `xml:"Email"`
	RelatedParty  *SAFshortTextType    `xml:"RelatedParty"`
}

// ContactInformationStructure ...
type ContactInformationStructure struct {
	ContactPerson *PersonNameStructure `xml:"ContactPerson"`
	Telephone     *SAFshortTextType    `xml:"Telephone"`
	Fax           *SAFshortTextType    `xml:"Fax"`
	Email         *SAFmiddle2TextType  `xml:"Email"`
	Website       string               `xml:"Website"`
}

// HeaderStructure ...
type HeaderStructure struct {
	AuditFileVersion        *SAFcodeType                `xml:"AuditFileVersion"`
	AuditFileCountry        *ISOCountryCode             `xml:"AuditFileCountry"`
	AuditFileRegion         *SAFcodeType                `xml:"AuditFileRegion"`
	AuditFileDateCreated    string                      `xml:"AuditFileDateCreated"`
	SoftwareCompanyName     *SAFmiddle2TextType         `xml:"SoftwareCompanyName"`
	SoftwareID              *SAFlongTextType            `xml:"SoftwareID"`
	SoftwareVersion         *SAFshortTextType           `xml:"SoftwareVersion"`
	Company                 *CompanyHeaderStructure     `xml:"Company"`
	Ownership               *OwnershipStructure         `xml:"Ownership"`
	DefaultCurrencyCode     *ISOCurrencyCode            `xml:"DefaultCurrencyCode"`
	SelectionCriteria       *SelectionCriteriaStructure `xml:"SelectionCriteria"`
	HeaderComment           *SAFlongTextType            `xml:"HeaderComment"`
	SegmentIndex            *SAFcodeType                `xml:"SegmentIndex"`
	TotalSegmentsInsequence *SAFcodeType                `xml:"TotalSegmentsInsequence"`
}

// PersonNameStructure ...
type PersonNameStructure struct {
	Title          *SAFcodeType        `xml:"Title"`
	FirstName      *SAFmiddle1TextType `xml:"FirstName"`
	Initials       *SAFshortTextType   `xml:"Initials"`
	LastNamePrefix *SAFshortTextType   `xml:"LastNamePrefix"`
	LastName       *SAFmiddle2TextType `xml:"LastName"`
	BirthName      *SAFmiddle2TextType `xml:"BirthName"`
	Salutation     *SAFshortTextType   `xml:"Salutation"`
	OtherTitles    []*SAFshortTextType `xml:"OtherTitles"`
}

// SelectionCriteriaStructure ...
type SelectionCriteriaStructure struct {
	TaxReportingJurisdiction *SAFmiddle1TextType `xml:"TaxReportingJurisdiction"`
	CompanyEntity            *SAFmiddle2TextType `xml:"CompanyEntity"`
	SelectionStartDate       string              `xml:"SelectionStartDate"`
	SelectionEndDate         string              `xml:"SelectionEndDate"`
	PeriodStart              int                 `xml:"PeriodStart"`
	PeriodStartYear          int                 `xml:"PeriodStartYear"`
	PeriodEnd                int                 `xml:"PeriodEnd"`
	PeriodEndYear            int                 `xml:"PeriodEndYear"`
	DocumentType             *SAFlongTextType    `xml:"DocumentType"`
	OtherCriteria            []*SAFlongTextType  `xml:"OtherCriteria"`
}

// TaxIDStructure ...
type TaxIDStructure struct {
	TaxRegistrationNumber *SAFmiddle1TextType `xml:"TaxRegistrationNumber"`
	TaxType               *SAFcodeType        `xml:"TaxType"`
	TaxNumber             *SAFmiddle1TextType `xml:"TaxNumber"`
	TaxAuthority          *SAFmiddle1TextType `xml:"TaxAuthority"`
	TaxVerificationDate   string              `xml:"TaxVerificationDate"`
}

// TaxInformationStructure ...
type TaxInformationStructure struct {
	TaxType              *SAFcodeType        `xml:"TaxType"`
	TaxCode              *SAFcodeType        `xml:"TaxCode"`
	TaxPercentage        float64             `xml:"TaxPercentage"`
	TaxBase              float64             `xml:"TaxBase"`
	TaxBaseDescription   *SAFmiddle2TextType `xml:"TaxBaseDescription"`
	TaxAmount            *AmountStructure    `xml:"TaxAmount"`
	TaxExemptionReason   *SAFmiddle2TextType `xml:"TaxExemptionReason"`
	TaxDeclarationPeriod *SAFmiddle1TextType `xml:"TaxDeclarationPeriod"`
}

type SAFmonetaryType float64

type SAFexchangerateType float64

type SAFquantityType float64

type SAFweightType float64

type SAFbaseRate float64

// SAFcodeType - size 9
type SAFcodeType string

// SAFshortTextType - size 18
type SAFshortTextType string

// SAFmiddle1TextType - size 35
type SAFmiddle1TextType string

// SAFmiddle2TextType - size 70
type SAFmiddle2TextType string

// SAFlongTextType - size 256
type SAFlongTextType string

// ISOCountryCode - size 2
type ISOCountryCode string

// ISOCurrencyCode - size 3
type ISOCurrencyCode string
