using System;

namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public class Invoice {
		private InvoiceParties invoicePartiesField;

		private InvoiceInformation invoiceInformationField;

		private InvoiceSumGroup[] invoiceSumGroupField;

		private InvoiceItem invoiceItemField;

		private ExtensionRecord[] additionalInformationField;

		private AttachmentRecord attachmentFileField;

		private PaymentInfo paymentInfoField;

		private string invoiceIdField;

		private string serviceIdField;

		private string regNumberField;

		private string channelIdField;

		private string channelAddressField;

		private string factoringField;

		private string templateIdField;

		private string languageIdField;

		private string presentmentField;

		private string invoiceGlobUniqIdField;

		private string sellerContractIdField;

		private string sellerRegnumberField;

		
		public InvoiceParties InvoiceParties
		{
			get => this.invoicePartiesField;
			set => this.invoicePartiesField = value;
		}

		
		public InvoiceInformation InvoiceInformation
		{
			get => this.invoiceInformationField;
			set => this.invoiceInformationField = value;
		}

		
		[System.Xml.Serialization.XmlElementAttribute("InvoiceSumGroup")]
		public InvoiceSumGroup[] InvoiceSumGroup
		{
			get => this.invoiceSumGroupField;
			set => this.invoiceSumGroupField = value;
		}

		
		public InvoiceItem InvoiceItem
		{
			get => this.invoiceItemField;
			set => this.invoiceItemField = value;
		}

		
		[System.Xml.Serialization.XmlElementAttribute("AdditionalInformation")]
		public ExtensionRecord[] AdditionalInformation
		{
			get => this.additionalInformationField;
			set => this.additionalInformationField = value;
		}

		
		public AttachmentRecord AttachmentFile
		{
			get => this.attachmentFileField;
			set => this.attachmentFileField = value;
		}

		
		public PaymentInfo PaymentInfo
		{
			get => this.paymentInfoField;
			set => this.paymentInfoField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string invoiceId
		{
			get => this.invoiceIdField;
			set => this.invoiceIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string serviceId
		{
			get => this.serviceIdField;
			set => this.serviceIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string regNumber
		{
			get => this.regNumberField;
			set => this.regNumberField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string channelId
		{
			get => this.channelIdField;
			set => this.channelIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string channelAddress
		{
			get => this.channelAddressField;
			set => this.channelAddressField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
		public string factoring
		{
			get => this.factoringField;
			set => this.factoringField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string templateId
		{
			get => this.templateIdField;
			set => this.templateIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string languageId
		{
			get => this.languageIdField;
			set => this.languageIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
		public string presentment
		{
			get => this.presentmentField;
			set => this.presentmentField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string invoiceGlobUniqId
		{
			get => this.invoiceGlobUniqIdField;
			set => this.invoiceGlobUniqIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sellerContractId
		{
			get => this.sellerContractIdField;
			set => this.sellerContractIdField = value;
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string sellerRegnumber
		{
			get => this.sellerRegnumberField;
			set => this.sellerRegnumberField = value;
		}
	}
}
