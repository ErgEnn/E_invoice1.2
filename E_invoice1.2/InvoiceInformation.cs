using System;

namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public class InvoiceInformation {

		private InvoiceInformationType typeField;

		private string factorContractNumberField;

		private string contractNumberField;

		private string documentNameField;

		private string invoiceNumberField;

		private string invoiceContentCodeField;

		private string invoiceContentTextField;

		private string paymentReferenceNumberField;

		private string paymentMethodField;

		private System.DateTime invoiceDateField;

		private System.DateTime dueDateField;

		private bool dueDateFieldSpecified;

		private string paymentTermField;

		private decimal fineRatePerDayField;

		private bool fineRatePerDayFieldSpecified;

		private InvoiceInformationPeriod periodField;

		private ContactDataRecord invoiceDelivererField;

		private ExtensionRecord[] extensionField;

		
		public InvoiceInformationType Type
		{
			get => this.typeField;
			set => this.typeField = value;
		}

		
		public string FactorContractNumber
		{
			get => this.factorContractNumberField;
			set => this.factorContractNumberField = value;
		}

		
		public string ContractNumber
		{
			get => this.contractNumberField;
			set => this.contractNumberField = value;
		}

		
		public string DocumentName
		{
			get => this.documentNameField;
			set => this.documentNameField = value;
		}

		
		public string InvoiceNumber
		{
			get => this.invoiceNumberField;
			set => this.invoiceNumberField = value;
		}

		
		public string InvoiceContentCode
		{
			get => this.invoiceContentCodeField;
			set => this.invoiceContentCodeField = value;
		}

		
		public string InvoiceContentText
		{
			get => this.invoiceContentTextField;
			set => this.invoiceContentTextField = value;
		}

		
		public string PaymentReferenceNumber
		{
			get => this.paymentReferenceNumberField;
			set => this.paymentReferenceNumberField = value;
		}

		
		public string PaymentMethod
		{
			get => this.paymentMethodField;
			set => this.paymentMethodField = value;
		}

		
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime InvoiceDate
		{
			get => this.invoiceDateField;
			set => this.invoiceDateField = value;
		}

		
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime DueDate
		{
			get => this.dueDateField;
			set => this.dueDateField = value;
		}

		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DueDateSpecified
		{
			get => this.dueDateFieldSpecified;
			set => this.dueDateFieldSpecified = value;
		}

		
		public string PaymentTerm
		{
			get => this.paymentTermField;
			set => this.paymentTermField = value;
		}

		
		public decimal FineRatePerDay
		{
			get => this.fineRatePerDayField;
			set => this.fineRatePerDayField = value;
		}

		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool FineRatePerDaySpecified
		{
			get => this.fineRatePerDayFieldSpecified;
			set => this.fineRatePerDayFieldSpecified = value;
		}

		
		public InvoiceInformationPeriod Period
		{
			get => this.periodField;
			set => this.periodField = value;
		}

		
		public ContactDataRecord InvoiceDeliverer
		{
			get => this.invoiceDelivererField;
			set => this.invoiceDelivererField = value;
		}

		
		[System.Xml.Serialization.XmlElementAttribute("Extension")]
		public ExtensionRecord[] Extension
		{
			get => this.extensionField;
			set => this.extensionField = value;
		}

	}
}
