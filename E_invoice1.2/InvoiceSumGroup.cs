namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class InvoiceSumGroup {
    
		private InvoiceSumGroupBalance balanceField;
    
		private decimal invoiceSumField;
    
		private bool invoiceSumFieldSpecified;
    
		private decimal penaltySumField;
    
		private bool penaltySumFieldSpecified;
    
		private AdditionRecord[] additionField;
    
		private decimal roundingField;
    
		private bool roundingFieldSpecified;
    
		private VATRecord[] vATField;
    
		private decimal totalVATSumField;
    
		private bool totalVATSumFieldSpecified;
    
		private decimal totalSumField;
    
		private decimal totalToPayField;
    
		private bool totalToPayFieldSpecified;
    
		private string currencyField;
    
		private AccountingRecord accountingField;
    
		private ExtensionRecord[] extensionField;
    
		
		public InvoiceSumGroupBalance Balance {
			get => this.balanceField;
			set => this.balanceField = value;
		}
    
		
		public decimal InvoiceSum {
			get => this.invoiceSumField;
			set => this.invoiceSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool InvoiceSumSpecified {
			get => this.invoiceSumFieldSpecified;
			set => this.invoiceSumFieldSpecified = value;
		}
    
		
		public decimal PenaltySum {
			get => this.penaltySumField;
			set => this.penaltySumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PenaltySumSpecified {
			get => this.penaltySumFieldSpecified;
			set => this.penaltySumFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Addition")]
		public AdditionRecord[] Addition {
			get => this.additionField;
			set => this.additionField = value;
		}
    
		
		public decimal Rounding {
			get => this.roundingField;
			set => this.roundingField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RoundingSpecified {
			get => this.roundingFieldSpecified;
			set => this.roundingFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("VAT")]
		public VATRecord[] VAT {
			get => this.vATField;
			set => this.vATField = value;
		}
    
		
		public decimal TotalVATSum {
			get => this.totalVATSumField;
			set => this.totalVATSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalVATSumSpecified {
			get => this.totalVATSumFieldSpecified;
			set => this.totalVATSumFieldSpecified = value;
		}
    
		
		public decimal TotalSum {
			get => this.totalSumField;
			set => this.totalSumField = value;
		}
    
		
		public decimal TotalToPay {
			get => this.totalToPayField;
			set => this.totalToPayField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalToPaySpecified {
			get => this.totalToPayFieldSpecified;
			set => this.totalToPayFieldSpecified = value;
		}
    
		
		public string Currency {
			get => this.currencyField;
			set => this.currencyField = value;
		}
    
		
		public AccountingRecord Accounting {
			get => this.accountingField;
			set => this.accountingField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Extension")]
		public ExtensionRecord[] Extension {
			get => this.extensionField;
			set => this.extensionField = value;
		}
	}
}