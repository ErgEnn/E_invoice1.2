namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class PaymentInfo {
    
		private string currencyField;
    
		private string[] itemsField;
    
		private ItemsChoiceType[] itemsElementNameField;
    
		private string payableField;
    
		private System.DateTime payDueDateField;
    
		private bool payDueDateFieldSpecified;
    
		private decimal paymentTotalSumField;
    
		private string payerNameField;
    
		private string paymentIdField;
    
		private string payToAccountField;
    
		private string payToNameField;
    
		private string payToBICField;
    
		private string directDebitPayeeContractNumberField;
    
		private string directDebitPayerNumberField;
    
		
		public string Currency {
			get => this.currencyField;
			set => this.currencyField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("PaymentDescription", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("PaymentRefId", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public string[] Items {
			get => this.itemsField;
			set => this.itemsField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType[] ItemsElementName {
			get => this.itemsElementNameField;
			set => this.itemsElementNameField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN")]
		public string Payable {
			get => this.payableField;
			set => this.payableField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="date")]
		public System.DateTime PayDueDate {
			get => this.payDueDateField;
			set => this.payDueDateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PayDueDateSpecified {
			get => this.payDueDateFieldSpecified;
			set => this.payDueDateFieldSpecified = value;
		}
    
		
		public decimal PaymentTotalSum {
			get => this.paymentTotalSumField;
			set => this.paymentTotalSumField = value;
		}
    
		
		public string PayerName {
			get => this.payerNameField;
			set => this.payerNameField = value;
		}
    
		
		public string PaymentId {
			get => this.paymentIdField;
			set => this.paymentIdField = value;
		}
    
		
		public string PayToAccount {
			get => this.payToAccountField;
			set => this.payToAccountField = value;
		}
    
		
		public string PayToName {
			get => this.payToNameField;
			set => this.payToNameField = value;
		}
    
		
		public string PayToBIC {
			get => this.payToBICField;
			set => this.payToBICField = value;
		}
    
		
		public string DirectDebitPayeeContractNumber {
			get => this.directDebitPayeeContractNumberField;
			set => this.directDebitPayeeContractNumberField = value;
		}
    
		
		public string DirectDebitPayerNumber {
			get => this.directDebitPayerNumberField;
			set => this.directDebitPayerNumberField = value;
		}
	}
}