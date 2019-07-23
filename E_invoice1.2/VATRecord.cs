namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public  class VATRecord {
    
		private decimal sumBeforeVATField;
    
		private bool sumBeforeVATFieldSpecified;
    
		private decimal vATRateField;
    
		private decimal vATSumField;
    
		private string currencyField;
    
		private decimal sumAfterVATField;
    
		private bool sumAfterVATFieldSpecified;
    
		private ExtensionRecord referenceField;
    
		private string vatIdField;
    
		
		public decimal SumBeforeVAT {
			get => this.sumBeforeVATField;
			set => this.sumBeforeVATField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SumBeforeVATSpecified {
			get => this.sumBeforeVATFieldSpecified;
			set => this.sumBeforeVATFieldSpecified = value;
		}
    
		
		public decimal VATRate {
			get => this.vATRateField;
			set => this.vATRateField = value;
		}
    
		
		public decimal VATSum {
			get => this.vATSumField;
			set => this.vATSumField = value;
		}
    
		
		public string Currency {
			get => this.currencyField;
			set => this.currencyField = value;
		}
    
		
		public decimal SumAfterVAT {
			get => this.sumAfterVATField;
			set => this.sumAfterVATField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SumAfterVATSpecified {
			get => this.sumAfterVATFieldSpecified;
			set => this.sumAfterVATFieldSpecified = value;
		}
    
		
		public ExtensionRecord Reference {
			get => this.referenceField;
			set => this.referenceField = value;
		}
    
		
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
		public string vatId {
			get => this.vatIdField;
			set => this.vatIdField = value;
		}
	}
}