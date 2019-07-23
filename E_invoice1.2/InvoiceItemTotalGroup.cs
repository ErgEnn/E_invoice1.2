namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class InvoiceItemTotalGroup {
    
		private string invoiceItemTotalDescriptionField;
    
		private ExtensionRecord[] extensionField;
    
		private AccountingRecord accountingField;
    
		private decimal invoiceItemTotalAmountField;
    
		private bool invoiceItemTotalAmountFieldSpecified;
    
		private decimal invoiceItemTotalSumField;
    
		private bool invoiceItemTotalSumFieldSpecified;
    
		private AdditionRecord[] additionField;
    
		private VATRecord vATField;
    
		private decimal invoiceItemTotalField;
    
		private bool invoiceItemTotalFieldSpecified;
    
		
		public string InvoiceItemTotalDescription {
			get => this.invoiceItemTotalDescriptionField;
			set => this.invoiceItemTotalDescriptionField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Extension")]
		public ExtensionRecord[] Extension {
			get => this.extensionField;
			set => this.extensionField = value;
		}
    
		
		public AccountingRecord Accounting {
			get => this.accountingField;
			set => this.accountingField = value;
		}
    
		
		public decimal InvoiceItemTotalAmount {
			get => this.invoiceItemTotalAmountField;
			set => this.invoiceItemTotalAmountField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool InvoiceItemTotalAmountSpecified {
			get => this.invoiceItemTotalAmountFieldSpecified;
			set => this.invoiceItemTotalAmountFieldSpecified = value;
		}
    
		
		public decimal InvoiceItemTotalSum {
			get => this.invoiceItemTotalSumField;
			set => this.invoiceItemTotalSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool InvoiceItemTotalSumSpecified {
			get => this.invoiceItemTotalSumFieldSpecified;
			set => this.invoiceItemTotalSumFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Addition")]
		public AdditionRecord[] Addition {
			get => this.additionField;
			set => this.additionField = value;
		}
    
		
		public VATRecord VAT {
			get => this.vATField;
			set => this.vATField = value;
		}
    
		
		public decimal InvoiceItemTotal {
			get => this.invoiceItemTotalField;
			set => this.invoiceItemTotalField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool InvoiceItemTotalSpecified {
			get => this.invoiceItemTotalFieldSpecified;
			set => this.invoiceItemTotalFieldSpecified = value;
		}
	}
}