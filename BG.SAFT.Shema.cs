
namespace BG.SAFT.Shema
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceNo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string InvoiceNo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CustomerInfo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureCustomerInfo CustomerInfo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SupplierInfo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureSupplierInfo SupplierInfo { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("BranchStoreNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BranchStoreNumber { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Period { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodYear { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime InvoiceDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string InvoiceType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipTo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipTo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipFrom", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipFrom { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PaymentTerms { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("SelfBillingIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SelfBillingIndicator { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceID { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("GLPostingDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime GLPostingDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool GLPostingDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> GLPostingDate
        {
            get
            {
                if (this.GLPostingDateValueSpecified)
                {
                    return this.GLPostingDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.GLPostingDateValue = value.GetValueOrDefault();
                this.GLPostingDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("BatchID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BatchID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SystemID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SystemID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiptNumbers", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ReceiptNumbers { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLine> _invoiceLine;
        
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLine> InvoiceLine
        {
            get
            {
                return this._invoiceLine;
            }
            private set
            {
                this._invoiceLine = value;
            }
        }
        
        public InvoiceStructure()
        {
            this._invoiceLine = new System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLine>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("InvoiceSettlement", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceSettlement InvoiceSettlement { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDocumentTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceDocumentTotals InvoiceDocumentTotals { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureCustomerInfo", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureCustomerInfo
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BillingAddress", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructure BillingAddress { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AddressStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddressStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("StreetName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string StreetName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("Number", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Number { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAddressDetail", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AdditionalAddressDetail { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("Building", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Building { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("City", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string City { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("PostalCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PostalCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Region { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Country", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Country { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AddressType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructureAddressType AddressTypeValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AddressTypeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<AddressStructureAddressType> AddressType
        {
            get
            {
                if (this.AddressTypeValueSpecified)
                {
                    return this.AddressTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AddressTypeValue = value.GetValueOrDefault();
                this.AddressTypeValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AddressStructureAddressType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum AddressStructureAddressType
    {
        
        StreetAddress,
        
        PostalAddress,
        
        BillingAddress,
        
        ShipToAddress,
        
        ShipFromAddress,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureSupplierInfo", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureSupplierInfo
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BillingAddress", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructure BillingAddress { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ShippingPointStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ShippingPointStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("DeliveryID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DeliveryID { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeliveryDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime DeliveryDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DeliveryDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> DeliveryDate
        {
            get
            {
                if (this.DeliveryDateValueSpecified)
                {
                    return this.DeliveryDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DeliveryDateValue = value.GetValueOrDefault();
                this.DeliveryDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("WarehouseID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string WarehouseID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LocationID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LocationID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("UCR", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UCR { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Address", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructure Address { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLine
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LineNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LineNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AnalysisStructure> _analysis;
        
        [System.Xml.Serialization.XmlElementAttribute("Analysis", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AnalysisStructure> Analysis
        {
            get
            {
                return this._analysis;
            }
            private set
            {
                this._analysis = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisSpecified
        {
            get
            {
                return (this.Analysis.Count != 0);
            }
        }
        
        public InvoiceStructureInvoiceLine()
        {
            this._analysis = new System.Collections.ObjectModel.Collection<AnalysisStructure>();
            this._orderReferences = new System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLineOrderReferences>();
            this._taxInformation = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLineOrderReferences> _orderReferences;
        
        [System.Xml.Serialization.XmlElementAttribute("OrderReferences", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<InvoiceStructureInvoiceLineOrderReferences> OrderReferences
        {
            get
            {
                return this._orderReferences;
            }
            private set
            {
                this._orderReferences = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderReferencesSpecified
        {
            get
            {
                return (this.OrderReferences.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipTo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipTo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipFrom", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipFrom { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("GoodsServicesID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GoodsServicesID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("ProductDescription", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductDescription { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceLineDelivery Delivery { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal Quantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceUOM", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string InvoiceUOM { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UOMToUOMBaseConversionFactor", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UOMToUOMBaseConversionFactorValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UOMToUOMBaseConversionFactorValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> UOMToUOMBaseConversionFactor
        {
            get
            {
                if (this.UOMToUOMBaseConversionFactorValueSpecified)
                {
                    return this.UOMToUOMBaseConversionFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UOMToUOMBaseConversionFactorValue = value.GetValueOrDefault();
                this.UOMToUOMBaseConversionFactorValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UnitPrice", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UnitPrice { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxPointDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TaxPointDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("References", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceLineReferences References { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLineAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure InvoiceLineAmount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DebitCreditIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceLineDebitCreditIndicator DebitCreditIndicator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShippingCostsAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure ShippingCostsAmount { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformation;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformation
        {
            get
            {
                return this._taxInformation;
            }
            private set
            {
                this._taxInformation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AnalysisStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AnalysisStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AnalysisAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure AnalysisAmount { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AmountStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AmountStructure
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal Amount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CurrencyCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CurrencyCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CurrencyAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal CurrencyAmount { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ExchangeRateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ExchangeRateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                if (this.ExchangeRateValueSpecified)
                {
                    return this.ExchangeRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExchangeRateValue = value.GetValueOrDefault();
                this.ExchangeRateValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineOrderReferences", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLineOrderReferences
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("OriginatingON", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OriginatingON { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OrderDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime OrderDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OrderDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> OrderDate
        {
            get
            {
                if (this.OrderDateValueSpecified)
                {
                    return this.OrderDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OrderDateValue = value.GetValueOrDefault();
                this.OrderDateValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineDelivery", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLineDelivery
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _movementReference;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("MovementReference", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<string> MovementReference
        {
            get
            {
                return this._movementReference;
            }
            private set
            {
                this._movementReference = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MovementReferenceSpecified
        {
            get
            {
                return (this.MovementReference.Count != 0);
            }
        }
        
        public InvoiceStructureInvoiceLineDelivery()
        {
            this._movementReference = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeliveryDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime DeliveryDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DeliveryDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> DeliveryDate
        {
            get
            {
                if (this.DeliveryDateValueSpecified)
                {
                    return this.DeliveryDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DeliveryDateValue = value.GetValueOrDefault();
                this.DeliveryDateValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceLineDeliveryDeliveryPeriod DeliveryPeriod { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineDeliveryDeliveryPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLineDeliveryDeliveryPeriod
    {
        
        [System.Xml.Serialization.XmlElementAttribute("FromDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime FromDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ToDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime ToDate { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineReferences", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLineReferences
    {
        
        [System.Xml.Serialization.XmlElementAttribute("CreditNote", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public InvoiceStructureInvoiceLineReferencesCreditNote CreditNote { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineReferencesCreditNote", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceLineReferencesCreditNote
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("Reference", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Reference { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Reason", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Reason { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceLineDebitCreditIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum InvoiceStructureInvoiceLineDebitCreditIndicator
    {
        
        D,
        
        C,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TaxInformationStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TaxInformationStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxCode { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxPercentage", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TaxPercentageValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxPercentageValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TaxPercentage
        {
            get
            {
                if (this.TaxPercentageValueSpecified)
                {
                    return this.TaxPercentageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxPercentageValue = value.GetValueOrDefault();
                this.TaxPercentageValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxBase", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TaxBaseValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxBaseValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TaxBase
        {
            get
            {
                if (this.TaxBaseValueSpecified)
                {
                    return this.TaxBaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxBaseValue = value.GetValueOrDefault();
                this.TaxBaseValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TaxBaseDescription", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxBaseDescription { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure TaxAmount { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TaxExemptionReason", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxExemptionReason { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxDeclarationPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxDeclarationPeriod { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceSettlement", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceSettlement
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SettlementDiscount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SettlementDiscount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SettlementAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure SettlementAmount { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SettlementDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime SettlementDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SettlementDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> SettlementDate
        {
            get
            {
                if (this.SettlementDateValueSpecified)
                {
                    return this.SettlementDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SettlementDateValue = value.GetValueOrDefault();
                this.SettlementDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentMechanism", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PaymentMechanism { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InvoiceStructureInvoiceDocumentTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InvoiceStructureInvoiceDocumentTotals
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformationTotals;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformationTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformationTotals
        {
            get
            {
                return this._taxInformationTotals;
            }
            private set
            {
                this._taxInformationTotals = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxInformationTotalsSpecified
        {
            get
            {
                return (this.TaxInformationTotals.Count != 0);
            }
        }
        
        public InvoiceStructureInvoiceDocumentTotals()
        {
            this._taxInformationTotals = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ShippingCostsAmountTotal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ShippingCostsAmountTotalValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShippingCostsAmountTotalValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ShippingCostsAmountTotal
        {
            get
            {
                if (this.ShippingCostsAmountTotalValueSpecified)
                {
                    return this.ShippingCostsAmountTotalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShippingCostsAmountTotalValue = value.GetValueOrDefault();
                this.ShippingCostsAmountTotalValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NetTotal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal NetTotal { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("GrossTotal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal GrossTotal { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OwnershipStructure
    {
        
        [System.Xml.Serialization.XmlElementAttribute("IsPartOfGroup", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructureIsPartOfGroup IsPartOfGroup { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerNameCyrillic", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerNameCyrillic { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerNameLatin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerNameLatin { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerUIC", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerUIC { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerEGN", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerEGN { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("GroupIdentification", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructureGroupIdentification GroupIdentification { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DirectOwnerIdentification", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructureDirectOwnerIdentification DirectOwnerIdentification { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerIdentificationBG", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructureUltimateOwnerIdentificationBG UltimateOwnerIdentificationBG { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerIdentificationForeign", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructureUltimateOwnerIdentificationForeign UltimateOwnerIdentificationForeign { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructureIsPartOfGroup", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum OwnershipStructureIsPartOfGroup
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("Yes - HQ of local")]
        Yes_HQ_Of_Local,
        
        [System.Xml.Serialization.XmlEnumAttribute("Yes - HQ of multinational")]
        Yes_HQ_Of_Multinational,
        
        [System.Xml.Serialization.XmlEnumAttribute("Yes - part of local")]
        Yes_Part_Of_Local,
        
        [System.Xml.Serialization.XmlEnumAttribute("Yes - part of multinational")]
        Yes_Part_Of_Multinational,
        
        No,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructureGroupIdentification", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OwnershipStructureGroupIdentification
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("GroupNameCyrillic", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GroupNameCyrillic { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("GroupNameLatin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GroupNameLatin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Country", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Country { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructureDirectOwnerIdentification", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OwnershipStructureDirectOwnerIdentification
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("OwnerNameCyrillic", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerNameCyrillic { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("LegalFormCyrillic", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LegalFormCyrillic { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("OwnerNameLatin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerNameLatin { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("LegalFormLatin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LegalFormLatin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OwnerCountry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerCountry { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("OwnerUIC", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerUIC { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OwnershipPercentage", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OwnershipPercentageValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OwnershipPercentageValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OwnershipPercentage
        {
            get
            {
                if (this.OwnershipPercentageValueSpecified)
                {
                    return this.OwnershipPercentageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OwnershipPercentageValue = value.GetValueOrDefault();
                this.OwnershipPercentageValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructureUltimateOwnerIdentificationBG", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OwnershipStructureUltimateOwnerIdentificationBG
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerNameCyrillicBG", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerNameCyrillicBG { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerUICBG", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerUICBG { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerEGNBG", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerEGNBG { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OwnershipStructureUltimateOwnerIdentificationForeign", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OwnershipStructureUltimateOwnerIdentificationForeign
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerNameCyrillicForeign", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerNameCyrillicForeign { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("UltimateOwnerNameLatinForeign", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UltimateOwnerNameLatinForeign { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CountryForeign", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CountryForeign { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BankAccountStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BankAccountStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("IBANNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string IBANNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("BankAccountNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BankAccountNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("BankAccountName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BankAccountName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("SortCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SortCode { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CompanyHeaderStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CompanyHeaderStructure : CompanyStructure
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CompanyStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompanyHeaderStructure))]
    public partial class CompanyStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string RegistrationNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Name { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("NameLatin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NameLatin { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AddressStructure> _address;
        
        [System.Xml.Serialization.XmlElementAttribute("Address", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AddressStructure> Address
        {
            get
            {
                return this._address;
            }
            private set
            {
                this._address = value;
            }
        }
        
        public CompanyStructure()
        {
            this._address = new System.Collections.ObjectModel.Collection<AddressStructure>();
            this._contact = new System.Collections.ObjectModel.Collection<ContactInformationStructure>();
            this._taxRegistration = new System.Collections.ObjectModel.Collection<TaxIDStructure>();
            this._bankAccount = new System.Collections.ObjectModel.Collection<BankAccountStructure>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ContactInformationStructure> _contact;
        
        [System.Xml.Serialization.XmlElementAttribute("Contact", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<ContactInformationStructure> Contact
        {
            get
            {
                return this._contact;
            }
            private set
            {
                this._contact = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContactSpecified
        {
            get
            {
                return (this.Contact.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxIDStructure> _taxRegistration;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxRegistration", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxIDStructure> TaxRegistration
        {
            get
            {
                return this._taxRegistration;
            }
            private set
            {
                this._taxRegistration = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRegistrationSpecified
        {
            get
            {
                return (this.TaxRegistration.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BankAccountStructure> _bankAccount;
        
        [System.Xml.Serialization.XmlElementAttribute("BankAccount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<BankAccountStructure> BankAccount
        {
            get
            {
                return this._bankAccount;
            }
            private set
            {
                this._bankAccount = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BankAccountSpecified
        {
            get
            {
                return (this.BankAccount.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RelatedParty", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public object RelatedParty { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RelatedPartyStartDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime RelatedPartyStartDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RelatedPartyStartDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> RelatedPartyStartDate
        {
            get
            {
                if (this.RelatedPartyStartDateValueSpecified)
                {
                    return this.RelatedPartyStartDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RelatedPartyStartDateValue = value.GetValueOrDefault();
                this.RelatedPartyStartDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RelatedPartyEndDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime RelatedPartyEndDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RelatedPartyEndDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> RelatedPartyEndDate
        {
            get
            {
                if (this.RelatedPartyEndDateValueSpecified)
                {
                    return this.RelatedPartyEndDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RelatedPartyEndDateValue = value.GetValueOrDefault();
                this.RelatedPartyEndDateValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ContactInformationStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactHeaderStructure))]
    public partial class ContactInformationStructure
    {
        
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public PersonNameStructure ContactPerson { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("Telephone", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Telephone { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("Fax", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Fax { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("Email", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Email { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Website", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Website { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PersonNameStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PersonNameStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("Title", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Title { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("FirstName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string FirstName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("Initials", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Initials { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LastNamePrefix", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LastNamePrefix { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("LastName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LastName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("BirthName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BirthName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("Salutation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Salutation { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _otherTitles;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("OtherTitles", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<string> OtherTitles
        {
            get
            {
                return this._otherTitles;
            }
            private set
            {
                this._otherTitles = value;
            }
        }
        
        public PersonNameStructure()
        {
            this._otherTitles = new System.Collections.ObjectModel.Collection<string>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TaxIDStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TaxIDStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxRegistrationNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxRegistrationNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxNumber { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxAuthority", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public TaxIDStructureTaxAuthority TaxAuthorityValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxAuthorityValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<TaxIDStructureTaxAuthority> TaxAuthority
        {
            get
            {
                if (this.TaxAuthorityValueSpecified)
                {
                    return this.TaxAuthorityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxAuthorityValue = value.GetValueOrDefault();
                this.TaxAuthorityValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxVerificationDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TaxVerificationDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxVerificationDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> TaxVerificationDate
        {
            get
            {
                if (this.TaxVerificationDateValueSpecified)
                {
                    return this.TaxVerificationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxVerificationDateValue = value.GetValueOrDefault();
                this.TaxVerificationDateValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TaxIDStructureTaxAuthority", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum TaxIDStructureTaxAuthority
    {
        
        NRA,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ContactHeaderStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ContactHeaderStructure : ContactInformationStructure
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("HeaderStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuditFileHeader))]
    public partial class HeaderStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("AuditFileVersion", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AuditFileVersion { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AuditFileCountry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AuditFileCountry { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("AuditFileRegion", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AuditFileRegion { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AuditFileDateCreated", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime AuditFileDateCreated { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareCompanyName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SoftwareCompanyName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SoftwareID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareVersion", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SoftwareVersion { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Company", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public CompanyHeaderStructure Company { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Ownership", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public OwnershipStructure Ownership { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DefaultCurrencyCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DefaultCurrencyCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SelectionCriteria", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public SelectionCriteriaStructure SelectionCriteria { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("HeaderComment", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string HeaderComment { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("SegmentIndex", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SegmentIndex { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TotalSegmentsInsequence", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TotalSegmentsInsequence { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SelectionCriteriaStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectionCriteriaStructure
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxReportingJurisdiction", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxReportingJurisdiction { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("CompanyEntity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CompanyEntity { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SelectionStartDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime SelectionStartDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SelectionStartDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> SelectionStartDate
        {
            get
            {
                if (this.SelectionStartDateValueSpecified)
                {
                    return this.SelectionStartDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SelectionStartDateValue = value.GetValueOrDefault();
                this.SelectionStartDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SelectionEndDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime SelectionEndDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SelectionEndDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> SelectionEndDate
        {
            get
            {
                if (this.SelectionEndDateValueSpecified)
                {
                    return this.SelectionEndDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SelectionEndDateValue = value.GetValueOrDefault();
                this.SelectionEndDateValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodStart", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodStart { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodStartYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodStartYear { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodEnd", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodEnd { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodEndYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodEndYear { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DocumentType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _otherCriteria;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("OtherCriteria", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<string> OtherCriteria
        {
            get
            {
                return this._otherCriteria;
            }
            private set
            {
                this._otherCriteria = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherCriteriaSpecified
        {
            get
            {
                return (this.OtherCriteria.Count != 0);
            }
        }
        
        public SelectionCriteriaStructure()
        {
            this._otherCriteria = new System.Collections.ObjectModel.Collection<string>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFile", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AuditFile", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public partial class AuditFile
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Header", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileHeader Header { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("MasterFiles", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileMasterFiles MasterFiles { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CorrespondingAccountsReport", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileCorrespondingAccountsReport CorrespondingAccountsReport { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("GeneralLedgerEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileGeneralLedgerEntries GeneralLedgerEntries { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SourceDocuments", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocuments SourceDocuments { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileHeader", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileHeader : HeaderStructure
    {
        
        [System.Xml.Serialization.XmlElementAttribute("TaxAccountingBasis", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileHeaderTaxAccountingBasis TaxAccountingBasis { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TaxEntity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxEntity { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileHeaderTaxAccountingBasis", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum AuditFileHeaderTaxAccountingBasis
    {
        
        A,
        
        P,
        
        BANK,
        
        INSURANCE,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFiles", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFiles
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount> _generalLedgerAccounts;
        
        [System.Xml.Serialization.XmlArrayAttribute("GeneralLedgerAccounts", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Account", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount> GeneralLedgerAccounts
        {
            get
            {
                return this._generalLedgerAccounts;
            }
            private set
            {
                this._generalLedgerAccounts = value;
            }
        }
        
        public AuditFileMasterFiles()
        {
            this._generalLedgerAccounts = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount>();
            this._taxonomies = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy>();
            this._customers = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer>();
            this._suppliers = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier>();
            this._taxTable = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry>();
            this._uOMTable = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry>();
            this._analysisTypeTable = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry>();
            this._movementTypeTable = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry>();
            this._products = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct>();
            this._physicalStock = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry>();
            this._owners = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner>();
            this._assets = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy> _taxonomies;
        
        [System.Xml.Serialization.XmlArrayAttribute("Taxonomies", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Taxonomy", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy> Taxonomies
        {
            get
            {
                return this._taxonomies;
            }
            private set
            {
                this._taxonomies = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxonomiesSpecified
        {
            get
            {
                return (this.Taxonomies.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer> _customers;
        
        [System.Xml.Serialization.XmlArrayAttribute("Customers", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Customer", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer> Customers
        {
            get
            {
                return this._customers;
            }
            private set
            {
                this._customers = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier> _suppliers;
        
        [System.Xml.Serialization.XmlArrayAttribute("Suppliers", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Supplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier> Suppliers
        {
            get
            {
                return this._suppliers;
            }
            private set
            {
                this._suppliers = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry> _taxTable;
        
        [System.Xml.Serialization.XmlArrayAttribute("TaxTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry> TaxTable
        {
            get
            {
                return this._taxTable;
            }
            private set
            {
                this._taxTable = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry> _uOMTable;
        
        [System.Xml.Serialization.XmlArrayAttribute("UOMTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UOMTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry> UOMTable
        {
            get
            {
                return this._uOMTable;
            }
            private set
            {
                this._uOMTable = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry> _analysisTypeTable;
        
        [System.Xml.Serialization.XmlArrayAttribute("AnalysisTypeTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AnalysisTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry> AnalysisTypeTable
        {
            get
            {
                return this._analysisTypeTable;
            }
            private set
            {
                this._analysisTypeTable = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisTypeTableSpecified
        {
            get
            {
                return (this.AnalysisTypeTable.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry> _movementTypeTable;
        
        [System.Xml.Serialization.XmlArrayAttribute("MovementTypeTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("MovementTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry> MovementTypeTable
        {
            get
            {
                return this._movementTypeTable;
            }
            private set
            {
                this._movementTypeTable = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct> _products;
        
        [System.Xml.Serialization.XmlArrayAttribute("Products", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Product", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct> Products
        {
            get
            {
                return this._products;
            }
            private set
            {
                this._products = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry> _physicalStock;
        
        [System.Xml.Serialization.XmlArrayAttribute("PhysicalStock", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("PhysicalStockEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry> PhysicalStock
        {
            get
            {
                return this._physicalStock;
            }
            private set
            {
                this._physicalStock = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhysicalStockSpecified
        {
            get
            {
                return (this.PhysicalStock.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner> _owners;
        
        [System.Xml.Serialization.XmlArrayAttribute("Owners", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Owner", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner> Owners
        {
            get
            {
                return this._owners;
            }
            private set
            {
                this._owners = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset> _assets;
        
        [System.Xml.Serialization.XmlArrayAttribute("Assets", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Asset", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset> Assets
        {
            get
            {
                return this._assets;
            }
            private set
            {
                this._assets = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesGeneralLedgerAccounts", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesGeneralLedgerAccounts
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount> _account;
        
        [System.Xml.Serialization.XmlElementAttribute("Account", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount> Account
        {
            get
            {
                return this._account;
            }
            private set
            {
                this._account = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountSpecified
        {
            get
            {
                return (this.Account.Count != 0);
            }
        }
        
        public AuditFileMasterFilesGeneralLedgerAccounts()
        {
            this._account = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesGeneralLedgerAccountsAccount>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesGeneralLedgerAccountsAccount", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesGeneralLedgerAccountsAccount
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("AccountDescription", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountDescription { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxpayerAccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxpayerAccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("GroupingCategory", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GroupingCategory { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("GroupingCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GroupingCode { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AccountType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileMasterFilesGeneralLedgerAccountsAccountAccountType AccountType { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountCreationDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime AccountCreationDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AccountCreationDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> AccountCreationDate
        {
            get
            {
                if (this.AccountCreationDateValueSpecified)
                {
                    return this.AccountCreationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AccountCreationDateValue = value.GetValueOrDefault();
                this.AccountCreationDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningDebitBalance
        {
            get
            {
                if (this.OpeningDebitBalanceValueSpecified)
                {
                    return this.OpeningDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningDebitBalanceValue = value.GetValueOrDefault();
                this.OpeningDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningCreditBalance
        {
            get
            {
                if (this.OpeningCreditBalanceValueSpecified)
                {
                    return this.OpeningCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningCreditBalanceValue = value.GetValueOrDefault();
                this.OpeningCreditBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingDebitBalance
        {
            get
            {
                if (this.ClosingDebitBalanceValueSpecified)
                {
                    return this.ClosingDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingDebitBalanceValue = value.GetValueOrDefault();
                this.ClosingDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingCreditBalance
        {
            get
            {
                if (this.ClosingCreditBalanceValueSpecified)
                {
                    return this.ClosingCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingCreditBalanceValue = value.GetValueOrDefault();
                this.ClosingCreditBalanceValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesGeneralLedgerAccountsAccountAccountType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum AuditFileMasterFilesGeneralLedgerAccountsAccountAccountType
    {
        
        Active,
        
        Pasive,
        
        Bifunctional,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxonomies", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxonomies
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy> _taxonomy;
        
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy> Taxonomy
        {
            get
            {
                return this._taxonomy;
            }
            private set
            {
                this._taxonomy = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxonomySpecified
        {
            get
            {
                return (this.Taxonomy.Count != 0);
            }
        }
        
        public AuditFileMasterFilesTaxonomies()
        {
            this._taxonomy = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomy>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxonomiesTaxonomy", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxonomiesTaxonomy
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("TaxonomyReference", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxonomyReference { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomyTaxonomyElement> _taxonomyElement;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxonomyElement", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomyTaxonomyElement> TaxonomyElement
        {
            get
            {
                return this._taxonomyElement;
            }
            private set
            {
                this._taxonomyElement = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxonomyElementSpecified
        {
            get
            {
                return (this.TaxonomyElement.Count != 0);
            }
        }
        
        public AuditFileMasterFilesTaxonomiesTaxonomy()
        {
            this._taxonomyElement = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxonomiesTaxonomyTaxonomyElement>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxonomiesTaxonomyTaxonomyElement", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxonomiesTaxonomyTaxonomyElement
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("TaxonomyCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxonomyCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("TaxonomyClusterID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxonomyClusterID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("TaxonomyClusterContextID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxonomyClusterContextID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesCustomers", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesCustomers
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer> _customer;
        
        [System.Xml.Serialization.XmlElementAttribute("Customer", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer> Customer
        {
            get
            {
                return this._customer;
            }
            private set
            {
                this._customer = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerSpecified
        {
            get
            {
                return (this.Customer.Count != 0);
            }
        }
        
        public AuditFileMasterFilesCustomers()
        {
            this._customer = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesCustomersCustomer>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesCustomersCustomer", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesCustomersCustomer
    {
        
        [System.Xml.Serialization.XmlElementAttribute("CompanyStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public CompanyStructure CompanyStructure { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("SelfBillingIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SelfBillingIndicator { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningDebitBalance
        {
            get
            {
                if (this.OpeningDebitBalanceValueSpecified)
                {
                    return this.OpeningDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningDebitBalanceValue = value.GetValueOrDefault();
                this.OpeningDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningCreditBalance
        {
            get
            {
                if (this.OpeningCreditBalanceValueSpecified)
                {
                    return this.OpeningCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningCreditBalanceValue = value.GetValueOrDefault();
                this.OpeningCreditBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingDebitBalance
        {
            get
            {
                if (this.ClosingDebitBalanceValueSpecified)
                {
                    return this.ClosingDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingDebitBalanceValue = value.GetValueOrDefault();
                this.ClosingDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingCreditBalance
        {
            get
            {
                if (this.ClosingCreditBalanceValueSpecified)
                {
                    return this.ClosingCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingCreditBalanceValue = value.GetValueOrDefault();
                this.ClosingCreditBalanceValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesSuppliers", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesSuppliers
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier> _supplier;
        
        [System.Xml.Serialization.XmlElementAttribute("Supplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier> Supplier
        {
            get
            {
                return this._supplier;
            }
            private set
            {
                this._supplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupplierSpecified
        {
            get
            {
                return (this.Supplier.Count != 0);
            }
        }
        
        public AuditFileMasterFilesSuppliers()
        {
            this._supplier = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesSuppliersSupplier>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesSuppliersSupplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesSuppliersSupplier
    {
        
        [System.Xml.Serialization.XmlElementAttribute("CompanyStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public CompanyStructure CompanyStructure { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("SelfBillingIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SelfBillingIndicator { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningDebitBalance
        {
            get
            {
                if (this.OpeningDebitBalanceValueSpecified)
                {
                    return this.OpeningDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningDebitBalanceValue = value.GetValueOrDefault();
                this.OpeningDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OpeningCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OpeningCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> OpeningCreditBalance
        {
            get
            {
                if (this.OpeningCreditBalanceValueSpecified)
                {
                    return this.OpeningCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OpeningCreditBalanceValue = value.GetValueOrDefault();
                this.OpeningCreditBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingDebitBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingDebitBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingDebitBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingDebitBalance
        {
            get
            {
                if (this.ClosingDebitBalanceValueSpecified)
                {
                    return this.ClosingDebitBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingDebitBalanceValue = value.GetValueOrDefault();
                this.ClosingDebitBalanceValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ClosingCreditBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingCreditBalanceValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ClosingCreditBalanceValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ClosingCreditBalance
        {
            get
            {
                if (this.ClosingCreditBalanceValueSpecified)
                {
                    return this.ClosingCreditBalanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ClosingCreditBalanceValue = value.GetValueOrDefault();
                this.ClosingCreditBalanceValueSpecified = value.HasValue;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxTable
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry> _taxTableEntry;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry> TaxTableEntry
        {
            get
            {
                return this._taxTableEntry;
            }
            private set
            {
                this._taxTableEntry = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxTableEntrySpecified
        {
            get
            {
                return (this.TaxTableEntry.Count != 0);
            }
        }
        
        public AuditFileMasterFilesTaxTable()
        {
            this._taxTableEntry = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntry>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxTableTaxTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxTableTaxTableEntry
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails> _taxCodeDetails;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxCodeDetails", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails> TaxCodeDetails
        {
            get
            {
                return this._taxCodeDetails;
            }
            private set
            {
                this._taxCodeDetails = value;
            }
        }
        
        public AuditFileMasterFilesTaxTableTaxTableEntry()
        {
            this._taxCodeDetails = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxCode { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime EffectiveDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EffectiveDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> EffectiveDate
        {
            get
            {
                if (this.EffectiveDateValueSpecified)
                {
                    return this.EffectiveDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EffectiveDateValue = value.GetValueOrDefault();
                this.EffectiveDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ExpirationDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime ExpirationDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ExpirationDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> ExpirationDate
        {
            get
            {
                if (this.ExpirationDateValueSpecified)
                {
                    return this.ExpirationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationDateValue = value.GetValueOrDefault();
                this.ExpirationDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxPercentage", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TaxPercentageValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxPercentageValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TaxPercentage
        {
            get
            {
                if (this.TaxPercentageValueSpecified)
                {
                    return this.TaxPercentageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxPercentageValue = value.GetValueOrDefault();
                this.TaxPercentageValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FlatTaxRate", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure FlatTaxRate { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<decimal> _baseRate;
        
        [System.Xml.Serialization.XmlElementAttribute("BaseRate", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<decimal> BaseRate
        {
            get
            {
                return this._baseRate;
            }
            private set
            {
                this._baseRate = value;
            }
        }
        
        public AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails()
        {
            this._baseRate = new System.Collections.ObjectModel.Collection<decimal>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Country", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Country { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("Region", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Region { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesUOMTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesUOMTable
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry> _uOMTableEntry;
        
        [System.Xml.Serialization.XmlElementAttribute("UOMTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry> UOMTableEntry
        {
            get
            {
                return this._uOMTableEntry;
            }
            private set
            {
                this._uOMTableEntry = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UOMTableEntrySpecified
        {
            get
            {
                return (this.UOMTableEntry.Count != 0);
            }
        }
        
        public AuditFileMasterFilesUOMTable()
        {
            this._uOMTableEntry = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesUOMTableUOMTableEntry>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesUOMTableUOMTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesUOMTableUOMTableEntry
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UnitOfMeasure { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAnalysisTypeTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAnalysisTypeTable
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry> _analysisTypeTableEntry;
        
        [System.Xml.Serialization.XmlElementAttribute("AnalysisTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry> AnalysisTypeTableEntry
        {
            get
            {
                return this._analysisTypeTableEntry;
            }
            private set
            {
                this._analysisTypeTableEntry = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisTypeTableEntrySpecified
        {
            get
            {
                return (this.AnalysisTypeTableEntry.Count != 0);
            }
        }
        
        public AuditFileMasterFilesAnalysisTypeTable()
        {
            this._analysisTypeTableEntry = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAnalysisTypeTableAnalysisTypeTableEntry
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisTypeDescription", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisTypeDescription { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("AnalysisIDDescription", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AnalysisIDDescription { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesMovementTypeTable", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesMovementTypeTable
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry> _movementTypeTableEntry;
        
        [System.Xml.Serialization.XmlElementAttribute("MovementTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry> MovementTypeTableEntry
        {
            get
            {
                return this._movementTypeTableEntry;
            }
            private set
            {
                this._movementTypeTableEntry = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MovementTypeTableEntrySpecified
        {
            get
            {
                return (this.MovementTypeTableEntry.Count != 0);
            }
        }
        
        public AuditFileMasterFilesMovementTypeTable()
        {
            this._movementTypeTableEntry = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesMovementTypeTableMovementTypeTableEntry
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("MovementType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string MovementType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesProducts", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesProducts
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct> _product;
        
        [System.Xml.Serialization.XmlElementAttribute("Product", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct> Product
        {
            get
            {
                return this._product;
            }
            private set
            {
                this._product = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductSpecified
        {
            get
            {
                return (this.Product.Count != 0);
            }
        }
        
        public AuditFileMasterFilesProducts()
        {
            this._product = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProduct>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesProductsProduct", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesProductsProduct
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("GoodsServicesID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string GoodsServicesID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductGroup", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductGroup { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("ProductCommodityCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductCommodityCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductNumberCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductNumberCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("ValuationMethod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ValuationMethod { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("UOMBase", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UOMBase { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("UOMStandard", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UOMStandard { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UOMToUOMBaseConversionFactor", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UOMToUOMBaseConversionFactor { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProductTax> _tax;
        
        [System.Xml.Serialization.XmlElementAttribute("Tax", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProductTax> Tax
        {
            get
            {
                return this._tax;
            }
            private set
            {
                this._tax = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxSpecified
        {
            get
            {
                return (this.Tax.Count != 0);
            }
        }
        
        public AuditFileMasterFilesProductsProduct()
        {
            this._tax = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesProductsProductTax>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesProductsProductTax", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesProductsProductTax
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("TaxCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxCode { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesPhysicalStock", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesPhysicalStock
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry> _physicalStockEntry;
        
        [System.Xml.Serialization.XmlElementAttribute("PhysicalStockEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry> PhysicalStockEntry
        {
            get
            {
                return this._physicalStockEntry;
            }
            private set
            {
                this._physicalStockEntry = value;
            }
        }
        
        public AuditFileMasterFilesPhysicalStock()
        {
            this._physicalStockEntry = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesPhysicalStockPhysicalStockEntry>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesPhysicalStockPhysicalStockEntry", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesPhysicalStockPhysicalStockEntry
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("WarehouseID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string WarehouseID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LocationID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LocationID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("StockAccountNo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string StockAccountNo { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("ProductType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("ProductStatus", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductStatus { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("StockAccountCommodityCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string StockAccountCommodityCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("OwnerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("UOMPhysicalStock", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UOMPhysicalStock { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UOMToUOMBaseConversionFactor", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UOMToUOMBaseConversionFactor { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UnitPrice", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UnitPrice { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OpeningStockQuantity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningStockQuantity { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("OpeningStockValue", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal OpeningStockValue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClosingStockQuantity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingStockQuantity { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ClosingStockValue", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ClosingStockValue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("StockCharacteristics", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileMasterFilesPhysicalStockPhysicalStockEntryStockCharacteristics StockCharacteristics { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesPhysicalStockPhysicalStockEntryStockCharacteristics", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesPhysicalStockPhysicalStockEntryStockCharacteristics
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _stockCharacteristic;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("StockCharacteristic", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<string> StockCharacteristic
        {
            get
            {
                return this._stockCharacteristic;
            }
            private set
            {
                this._stockCharacteristic = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockCharacteristicSpecified
        {
            get
            {
                return (this.StockCharacteristic.Count != 0);
            }
        }
        
        public AuditFileMasterFilesPhysicalStockPhysicalStockEntryStockCharacteristics()
        {
            this._stockCharacteristic = new System.Collections.ObjectModel.Collection<string>();
            this._stockCharacteristicValue = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _stockCharacteristicValue;
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("StockCharacteristicValue", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<string> StockCharacteristicValue
        {
            get
            {
                return this._stockCharacteristicValue;
            }
            private set
            {
                this._stockCharacteristicValue = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesOwners", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesOwners
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner> _owner;
        
        [System.Xml.Serialization.XmlElementAttribute("Owner", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner> Owner
        {
            get
            {
                return this._owner;
            }
            private set
            {
                this._owner = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OwnerSpecified
        {
            get
            {
                return (this.Owner.Count != 0);
            }
        }
        
        public AuditFileMasterFilesOwners()
        {
            this._owner = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesOwnersOwner>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesOwnersOwner", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesOwnersOwner
    {
        
        [System.Xml.Serialization.XmlElementAttribute("CompanyStructure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public CompanyStructure CompanyStructure { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("OwnerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string OwnerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssets", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssets
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset> _asset;
        
        [System.Xml.Serialization.XmlElementAttribute("Asset", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset> Asset
        {
            get
            {
                return this._asset;
            }
            private set
            {
                this._asset = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssetSpecified
        {
            get
            {
                return (this.Asset.Count != 0);
            }
        }
        
        public AuditFileMasterFilesAssets()
        {
            this._asset = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAsset>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAsset", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAsset
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("AssetID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AssetID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetAssetSupplier> _assetSupplier;
        
        [System.Xml.Serialization.XmlElementAttribute("AssetSupplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetAssetSupplier> AssetSupplier
        {
            get
            {
                return this._assetSupplier;
            }
            private set
            {
                this._assetSupplier = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssetSupplierSpecified
        {
            get
            {
                return (this.AssetSupplier.Count != 0);
            }
        }
        
        public AuditFileMasterFilesAssetsAsset()
        {
            this._assetSupplier = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetAssetSupplier>();
            this._valuations = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation>();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("PurchaseOrderDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime PurchaseOrderDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PurchaseOrderDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> PurchaseOrderDate
        {
            get
            {
                if (this.PurchaseOrderDateValueSpecified)
                {
                    return this.PurchaseOrderDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PurchaseOrderDateValue = value.GetValueOrDefault();
                this.PurchaseOrderDateValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DateOfAcquisition", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime DateOfAcquisition { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("StartUpDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime StartUpDate { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation> _valuations;
        
        [System.Xml.Serialization.XmlArrayAttribute("Valuations", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Valuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation> Valuations
        {
            get
            {
                return this._valuations;
            }
            private set
            {
                this._valuations = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetAssetSupplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAssetAssetSupplier
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PostalAddress", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructure PostalAddress { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetValuations", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAssetValuations
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation> _valuation;
        
        [System.Xml.Serialization.XmlElementAttribute("Valuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation> Valuation
        {
            get
            {
                return this._valuation;
            }
            private set
            {
                this._valuation = value;
            }
        }
        
        public AuditFileMasterFilesAssetsAssetValuations()
        {
            this._valuation = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuation>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetValuationsValuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAssetValuationsValuation
    {
        
        [System.Xml.Serialization.XmlElementAttribute("AssetValuationType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileMasterFilesAssetsAssetValuationsValuationAssetValuationType AssetValuationType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("ValuationClass", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ValuationClass { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AcquisitionAndProductionCostsBegin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AcquisitionAndProductionCostsBegin { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AcquisitionAndProductionCostsEnd", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AcquisitionAndProductionCostsEnd { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("InvestmentSupport", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal InvestmentSupport { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AssetLifeYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AssetLifeYearValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AssetLifeYearValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> AssetLifeYear
        {
            get
            {
                if (this.AssetLifeYearValueSpecified)
                {
                    return this.AssetLifeYearValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AssetLifeYearValue = value.GetValueOrDefault();
                this.AssetLifeYearValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AssetLifeMonth", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AssetLifeMonthValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool AssetLifeMonthValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> AssetLifeMonth
        {
            get
            {
                if (this.AssetLifeMonthValueSpecified)
                {
                    return this.AssetLifeMonthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AssetLifeMonthValue = value.GetValueOrDefault();
                this.AssetLifeMonthValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetAddition", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AssetAddition { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Transfers", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal Transfers { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetDisposal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AssetDisposal { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BookValueBegin", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal BookValueBegin { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("DepreciationMethod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DepreciationMethod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DepreciationPercentage", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal DepreciationPercentage { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DepreciationForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal DepreciationForPeriod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AppreciationForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AppreciationForPeriod { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod> _extraordinaryDepreciationsForPeriod;
        
        [System.Xml.Serialization.XmlArrayAttribute("ExtraordinaryDepreciationsForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtraordinaryDepreciationForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod> ExtraordinaryDepreciationsForPeriod
        {
            get
            {
                return this._extraordinaryDepreciationsForPeriod;
            }
            private set
            {
                this._extraordinaryDepreciationsForPeriod = value;
            }
        }
        
        public AuditFileMasterFilesAssetsAssetValuationsValuation()
        {
            this._extraordinaryDepreciationsForPeriod = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AccumulatedDepreciation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AccumulatedDepreciation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BookValueEnd", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal BookValueEnd { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetValuationsValuationAssetValuationType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum AuditFileMasterFilesAssetsAssetValuationsValuationAssetValuationType
    {
        
        SAP,
        
        DAP,
        
        OTHER,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPe" +
        "riod", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriod
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod> _extraordinaryDepreciationForPeriod;
        
        [System.Xml.Serialization.XmlElementAttribute("ExtraordinaryDepreciationForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod> ExtraordinaryDepreciationForPeriod
        {
            get
            {
                return this._extraordinaryDepreciationForPeriod;
            }
            private set
            {
                this._extraordinaryDepreciationForPeriod = value;
            }
        }
        
        public AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriod()
        {
            this._extraordinaryDepreciationForPeriod = new System.Collections.ObjectModel.Collection<AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPe" +
        "riodExtraordinaryDepreciationForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileMasterFilesAssetsAssetValuationsValuationExtraordinaryDepreciationsForPeriodExtraordinaryDepreciationForPeriod
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("ExtraordinaryDepreciationMethod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ExtraordinaryDepreciationMethod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ExtraordinaryDepreciationAmountForPeriod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal ExtraordinaryDepreciationAmountForPeriod { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileCorrespondingAccountsReport", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileCorrespondingAccountsReport
    {
        
        [System.Xml.Serialization.XmlElementAttribute("CorrespondingAccountsReportTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotals CorrespondingAccountsReportTotals { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotals
    {
        
        [System.Xml.Serialization.XmlElementAttribute("TotalDebitOpeningBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitOpeningBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalCreditOpeningBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditOpeningBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalDebit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalCredit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCredit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalDebitClosingBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitClosingBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TotalCreditClosingBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditClosingBalance { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine> _reportLine;
        
        [System.Xml.Serialization.XmlElementAttribute("ReportLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine> ReportLine
        {
            get
            {
                return this._reportLine;
            }
            private set
            {
                this._reportLine = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportLineSpecified
        {
            get
            {
                return (this.ReportLine.Count != 0);
            }
        }
        
        public AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotals()
        {
            this._reportLine = new System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("LineNo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LineNo { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("CorrespondingAccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CorrespondingAccountID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Period { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodYear { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLineReportLineValues> _reportLineValues;
        
        [System.Xml.Serialization.XmlElementAttribute("ReportLineValues", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLineReportLineValues> ReportLineValues
        {
            get
            {
                return this._reportLineValues;
            }
            private set
            {
                this._reportLineValues = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportLineValuesSpecified
        {
            get
            {
                return (this.ReportLineValues.Count != 0);
            }
        }
        
        public AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLine()
        {
            this._reportLineValues = new System.Collections.ObjectModel.Collection<AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLineReportLineValues>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLineRe" +
        "portLineValues", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileCorrespondingAccountsReportCorrespondingAccountsReportTotalsReportLineReportLineValues
    {
        
        [System.Xml.Serialization.XmlElementAttribute("DebitOpeningBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal DebitOpeningBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CreditOpeningBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal CreditOpeningBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DebitTurnover", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal DebitTurnover { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CreditTurnover", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal CreditTurnover { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DebitClosingBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal DebitClosingBalance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CreditClosingBalance", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal CreditClosingBalance { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileGeneralLedgerEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileGeneralLedgerEntries
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfEntries { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalDebit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalDebitValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalDebit
        {
            get
            {
                if (this.TotalDebitValueSpecified)
                {
                    return this.TotalDebitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalDebitValue = value.GetValueOrDefault();
                this.TotalDebitValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCredit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalCreditValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalCredit
        {
            get
            {
                if (this.TotalCreditValueSpecified)
                {
                    return this.TotalCreditValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalCreditValue = value.GetValueOrDefault();
                this.TotalCreditValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournal> _journal;
        
        [System.Xml.Serialization.XmlElementAttribute("Journal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournal> Journal
        {
            get
            {
                return this._journal;
            }
            private set
            {
                this._journal = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool JournalSpecified
        {
            get
            {
                return (this.Journal.Count != 0);
            }
        }
        
        public AuditFileGeneralLedgerEntries()
        {
            this._journal = new System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournal>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileGeneralLedgerEntriesJournal", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileGeneralLedgerEntriesJournal
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("JournalID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string JournalID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("Type", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Type { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransaction> _transaction;
        
        [System.Xml.Serialization.XmlElementAttribute("Transaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransaction> Transaction
        {
            get
            {
                return this._transaction;
            }
            private set
            {
                this._transaction = value;
            }
        }
        
        public AuditFileGeneralLedgerEntriesJournal()
        {
            this._transaction = new System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransaction>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileGeneralLedgerEntriesJournalTransaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileGeneralLedgerEntriesJournalTransaction
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Period { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodYear { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TransactionDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TransactionDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("BatchID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BatchID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SystemEntryDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime SystemEntryDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("GLPostingDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime GLPostingDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("SystemID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SystemID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine> _transactionLine;
        
        [System.Xml.Serialization.XmlElementAttribute("TransactionLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine> TransactionLine
        {
            get
            {
                return this._transactionLine;
            }
            private set
            {
                this._transactionLine = value;
            }
        }
        
        public AuditFileGeneralLedgerEntriesJournalTransaction()
        {
            this._transactionLine = new System.Collections.ObjectModel.Collection<AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("RecordID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string RecordID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("TaxpayerAccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TaxpayerAccountID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AnalysisStructure> _analysis;
        
        [System.Xml.Serialization.XmlElementAttribute("Analysis", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AnalysisStructure> Analysis
        {
            get
            {
                return this._analysis;
            }
            private set
            {
                this._analysis = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisSpecified
        {
            get
            {
                return (this.Analysis.Count != 0);
            }
        }
        
        public AuditFileGeneralLedgerEntriesJournalTransactionTransactionLine()
        {
            this._analysis = new System.Collections.ObjectModel.Collection<AnalysisStructure>();
            this._taxInformation = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ValueDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime ValueDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ValueDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> ValueDate
        {
            get
            {
                if (this.ValueDateValueSpecified)
                {
                    return this.ValueDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ValueDateValue = value.GetValueOrDefault();
                this.ValueDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceDocumentID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceDocumentID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DebitAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure DebitAmount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("CreditAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure CreditAmount { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformation;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformation
        {
            get
            {
                return this._taxInformation;
            }
            private set
            {
                this._taxInformation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocuments", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocuments
    {
        
        [System.Xml.Serialization.XmlElementAttribute("SalesInvoices", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsSalesInvoices SalesInvoices { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PurchaseInvoices", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsPurchaseInvoices PurchaseInvoices { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Payments", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsPayments Payments { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("MovementOfGoods", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsMovementOfGoods MovementOfGoods { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactions", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsAssetTransactions AssetTransactions { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsSalesInvoices", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsSalesInvoices
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfEntries { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalDebit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalDebitValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalDebit
        {
            get
            {
                if (this.TotalDebitValueSpecified)
                {
                    return this.TotalDebitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalDebitValue = value.GetValueOrDefault();
                this.TotalDebitValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCredit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalCreditValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalCredit
        {
            get
            {
                if (this.TotalCreditValueSpecified)
                {
                    return this.TotalCreditValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalCreditValue = value.GetValueOrDefault();
                this.TotalCreditValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceStructure> _invoice;
        
        [System.Xml.Serialization.XmlElementAttribute("Invoice", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<InvoiceStructure> Invoice
        {
            get
            {
                return this._invoice;
            }
            private set
            {
                this._invoice = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceSpecified
        {
            get
            {
                return (this.Invoice.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsSalesInvoices()
        {
            this._invoice = new System.Collections.ObjectModel.Collection<InvoiceStructure>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPurchaseInvoices", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPurchaseInvoices
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfEntries { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalDebit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalDebitValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalDebit
        {
            get
            {
                if (this.TotalDebitValueSpecified)
                {
                    return this.TotalDebitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalDebitValue = value.GetValueOrDefault();
                this.TotalDebitValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCredit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalCreditValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalCredit
        {
            get
            {
                if (this.TotalCreditValueSpecified)
                {
                    return this.TotalCreditValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalCreditValue = value.GetValueOrDefault();
                this.TotalCreditValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<InvoiceStructure> _invoice;
        
        [System.Xml.Serialization.XmlElementAttribute("Invoice", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<InvoiceStructure> Invoice
        {
            get
            {
                return this._invoice;
            }
            private set
            {
                this._invoice = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceSpecified
        {
            get
            {
                return (this.Invoice.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsPurchaseInvoices()
        {
            this._invoice = new System.Collections.ObjectModel.Collection<InvoiceStructure>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPayments", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPayments
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfEntries", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfEntries { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalDebit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalDebitValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalDebitValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalDebit
        {
            get
            {
                if (this.TotalDebitValueSpecified)
                {
                    return this.TotalDebitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalDebitValue = value.GetValueOrDefault();
                this.TotalDebitValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCredit", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalCreditValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalCreditValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalCredit
        {
            get
            {
                if (this.TotalCreditValueSpecified)
                {
                    return this.TotalCreditValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalCreditValue = value.GetValueOrDefault();
                this.TotalCreditValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPayment> _payment;
        
        [System.Xml.Serialization.XmlElementAttribute("Payment", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPayment> Payment
        {
            get
            {
                return this._payment;
            }
            private set
            {
                this._payment = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentSpecified
        {
            get
            {
                return (this.Payment.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsPayments()
        {
            this._payment = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPayment>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPaymentsPayment", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPaymentsPayment
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentRefNo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PaymentRefNo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Period { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PeriodYear", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PeriodYear { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("TransactionDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TransactionDate { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentMethod", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PaymentMethod { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("BatchID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string BatchID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SystemID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SystemID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPaymentPaymentLine> _paymentLine;
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPaymentPaymentLine> PaymentLine
        {
            get
            {
                return this._paymentLine;
            }
            private set
            {
                this._paymentLine = value;
            }
        }
        
        public AuditFileSourceDocumentsPaymentsPayment()
        {
            this._paymentLine = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsPaymentsPaymentPaymentLine>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentSettlement", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsPaymentsPaymentPaymentSettlement PaymentSettlement { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentDocumentTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsPaymentsPaymentPaymentDocumentTotals PaymentDocumentTotals { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPaymentsPaymentPaymentLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentPaymentLine
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LineNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LineNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceDocumentID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceDocumentID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AnalysisStructure> _analysis;
        
        [System.Xml.Serialization.XmlElementAttribute("Analysis", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AnalysisStructure> Analysis
        {
            get
            {
                return this._analysis;
            }
            private set
            {
                this._analysis = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisSpecified
        {
            get
            {
                return (this.Analysis.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsPaymentsPaymentPaymentLine()
        {
            this._analysis = new System.Collections.ObjectModel.Collection<AnalysisStructure>();
            this._taxInformation = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxPointDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TaxPointDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxPointDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> TaxPointDate
        {
            get
            {
                if (this.TaxPointDateValueSpecified)
                {
                    return this.TaxPointDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxPointDateValue = value.GetValueOrDefault();
                this.TaxPointDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DebitCreditIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsPaymentsPaymentPaymentLineDebitCreditIndicator DebitCreditIndicator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentLineAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure PaymentLineAmount { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformation;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformation
        {
            get
            {
                return this._taxInformation;
            }
            private set
            {
                this._taxInformation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPaymentsPaymentPaymentLineDebitCreditIndicator", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
    public enum AuditFileSourceDocumentsPaymentsPaymentPaymentLineDebitCreditIndicator
    {
        
        D,
        
        C,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPaymentsPaymentPaymentSettlement", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentPaymentSettlement
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SettlementDiscount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SettlementDiscount { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("SettlementAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AmountStructure SettlementAmount { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SettlementDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime SettlementDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SettlementDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> SettlementDate
        {
            get
            {
                if (this.SettlementDateValueSpecified)
                {
                    return this.SettlementDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SettlementDateValue = value.GetValueOrDefault();
                this.SettlementDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentMechanism", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string PaymentMechanism { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsPaymentsPaymentPaymentDocumentTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentPaymentDocumentTotals
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformationTotals;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformationTotals", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformationTotals
        {
            get
            {
                return this._taxInformationTotals;
            }
            private set
            {
                this._taxInformationTotals = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxInformationTotalsSpecified
        {
            get
            {
                return (this.TaxInformationTotals.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsPaymentsPaymentPaymentDocumentTotals()
        {
            this._taxInformationTotals = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("NetTotal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal NetTotalValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool NetTotalValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> NetTotal
        {
            get
            {
                if (this.NetTotalValueSpecified)
                {
                    return this.NetTotalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NetTotalValue = value.GetValueOrDefault();
                this.NetTotalValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("GrossTotal", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal GrossTotal { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsMovementOfGoods", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsMovementOfGoods
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfMovementLines", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfMovementLines { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalQuantityReceived", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalQuantityReceivedValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalQuantityReceivedValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalQuantityReceived
        {
            get
            {
                if (this.TotalQuantityReceivedValueSpecified)
                {
                    return this.TotalQuantityReceivedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalQuantityReceivedValue = value.GetValueOrDefault();
                this.TotalQuantityReceivedValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalQuantityIssued", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal TotalQuantityIssuedValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalQuantityIssuedValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TotalQuantityIssued
        {
            get
            {
                if (this.TotalQuantityIssuedValueSpecified)
                {
                    return this.TotalQuantityIssuedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalQuantityIssuedValue = value.GetValueOrDefault();
                this.TotalQuantityIssuedValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovement> _stockMovement;
        
        [System.Xml.Serialization.XmlElementAttribute("StockMovement", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovement> StockMovement
        {
            get
            {
                return this._stockMovement;
            }
            private set
            {
                this._stockMovement = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockMovementSpecified
        {
            get
            {
                return (this.StockMovement.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsMovementOfGoods()
        {
            this._stockMovement = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovement>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsMovementOfGoodsStockMovement", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsMovementOfGoodsStockMovement
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("MovementReference", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string MovementReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("MovementDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime MovementDate { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("MovementPostingDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime MovementPostingDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MovementPostingDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> MovementPostingDate
        {
            get
            {
                if (this.MovementPostingDateValueSpecified)
                {
                    return this.MovementPostingDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MovementPostingDateValue = value.GetValueOrDefault();
                this.MovementPostingDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("MovementPostingTime", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="time")]
        public System.DateTime MovementPostingTimeValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MovementPostingTimeValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> MovementPostingTime
        {
            get
            {
                if (this.MovementPostingTimeValueSpecified)
                {
                    return this.MovementPostingTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MovementPostingTimeValue = value.GetValueOrDefault();
                this.MovementPostingTimeValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TaxPointDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime TaxPointDateValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TaxPointDateValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> TaxPointDate
        {
            get
            {
                if (this.TaxPointDateValueSpecified)
                {
                    return this.TaxPointDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TaxPointDateValue = value.GetValueOrDefault();
                this.TaxPointDateValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("MovementType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string MovementType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SourceID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SourceID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SystemID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SystemID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsMovementOfGoodsStockMovementDocumentReference DocumentReference { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine> _stockMovementLine;
        
        [System.Xml.Serialization.XmlElementAttribute("StockMovementLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine> StockMovementLine
        {
            get
            {
                return this._stockMovementLine;
            }
            private set
            {
                this._stockMovementLine = value;
            }
        }
        
        public AuditFileSourceDocumentsMovementOfGoodsStockMovement()
        {
            this._stockMovementLine = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsMovementOfGoodsStockMovementDocumentReference", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsMovementOfGoodsStockMovementDocumentReference
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DocumentType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DocumentNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string DocumentLine { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("LineNumber", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string LineNumber { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AccountID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string CustomerID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipTo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipTo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ShipFrom", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public ShippingPointStructure ShipFrom { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("ProductCode", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string ProductCode { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("StockAccountNo", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string StockAccountNo { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal Quantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string UnitOfMeasure { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("UOMToUOMPhysicalStockConversionFactor", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal UOMToUOMPhysicalStockConversionFactor { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("BookValue", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal BookValueValue { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BookValueValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> BookValue
        {
            get
            {
                if (this.BookValueValueSpecified)
                {
                    return this.BookValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BookValueValue = value.GetValueOrDefault();
                this.BookValueValueSpecified = value.HasValue;
            }
        }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("MovementSubType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string MovementSubType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("MovementComments", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string MovementComments { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxInformationStructure> _taxInformation;
        
        [System.Xml.Serialization.XmlElementAttribute("TaxInformation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<TaxInformationStructure> TaxInformation
        {
            get
            {
                return this._taxInformation;
            }
            private set
            {
                this._taxInformation = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxInformationSpecified
        {
            get
            {
                return (this.TaxInformation.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsMovementOfGoodsStockMovementStockMovementLine()
        {
            this._taxInformation = new System.Collections.ObjectModel.Collection<TaxInformationStructure>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsAssetTransactions", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsAssetTransactions
    {
        
        [System.Xml.Serialization.XmlElementAttribute("NumberOfAssetTransactions", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string NumberOfAssetTransactions { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransaction> _assetTransaction;
        
        [System.Xml.Serialization.XmlElementAttribute("AssetTransaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransaction> AssetTransaction
        {
            get
            {
                return this._assetTransaction;
            }
            private set
            {
                this._assetTransaction = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssetTransactionSpecified
        {
            get
            {
                return (this.AssetTransaction.Count != 0);
            }
        }
        
        public AuditFileSourceDocumentsAssetTransactions()
        {
            this._assetTransaction = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransaction>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsAssetTransactionsAssetTransaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsAssetTransactionsAssetTransaction
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AssetTransactionID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("AssetID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AssetID { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(9)]
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactionType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AssetTransactionType { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(256)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string Description { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactionDate", Namespace="mf:nra:dgti:dxxxx:declaration:v1", DataType="date")]
        public System.DateTime AssetTransactionDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetSupplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetSupplier AssetSupplier { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("TransactionID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string TransactionID { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation> _assetTransactionValuations;
        
        [System.Xml.Serialization.XmlArrayAttribute("AssetTransactionValuations", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AssetTransactionValuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation> AssetTransactionValuations
        {
            get
            {
                return this._assetTransactionValuations;
            }
            private set
            {
                this._assetTransactionValuations = value;
            }
        }
        
        public AuditFileSourceDocumentsAssetTransactionsAssetTransaction()
        {
            this._assetTransactionValuations = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetSupplier", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetSupplier
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierName", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierName { get; set; }
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string SupplierID { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("PostalAddress", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public AddressStructure PostalAddress { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuatio" +
        "ns", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuations
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation> _assetTransactionValuation;
        
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactionValuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation> AssetTransactionValuation
        {
            get
            {
                return this._assetTransactionValuation;
            }
            private set
            {
                this._assetTransactionValuation = value;
            }
        }
        
        public AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuations()
        {
            this._assetTransactionValuation = new System.Collections.ObjectModel.Collection<AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation>();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuatio" +
        "nsAssetTransactionValuation", Namespace="mf:nra:dgti:dxxxx:declaration:v1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditFileSourceDocumentsAssetTransactionsAssetTransactionAssetTransactionValuationsAssetTransactionValuation
    {
        
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("AssetValuationType", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public string AssetValuationType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AcquisitionAndProductionCostsOnTransaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AcquisitionAndProductionCostsOnTransaction { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("BookValueOnTransaction", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal BookValueOnTransaction { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("AssetTransactionAmount", Namespace="mf:nra:dgti:dxxxx:declaration:v1")]
        public decimal AssetTransactionAmount { get; set; }
    }
}
 
