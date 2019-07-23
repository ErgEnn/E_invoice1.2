namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class GroupEntry {
    
		private string groupDescriptionField;
    
		private ExtensionRecord[] extensionField;
    
		private AccountingRecord accountingField;
    
		private decimal groupAmountField;
    
		private bool groupAmountFieldSpecified;
    
		private decimal groupSumField;
    
		private bool groupSumFieldSpecified;
    
		private AdditionRecord[] additionField;
    
		private VATRecord vATField;
    
		private decimal groupTotalField;
    
		private bool groupTotalFieldSpecified;
    
		
		public string GroupDescription {
			get => this.groupDescriptionField;
			set => this.groupDescriptionField = value;
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
    
		
		public decimal GroupAmount {
			get => this.groupAmountField;
			set => this.groupAmountField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GroupAmountSpecified {
			get => this.groupAmountFieldSpecified;
			set => this.groupAmountFieldSpecified = value;
		}
    
		
		public decimal GroupSum {
			get => this.groupSumField;
			set => this.groupSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GroupSumSpecified {
			get => this.groupSumFieldSpecified;
			set => this.groupSumFieldSpecified = value;
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
    
		
		public decimal GroupTotal {
			get => this.groupTotalField;
			set => this.groupTotalField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GroupTotalSpecified {
			get => this.groupTotalFieldSpecified;
			set => this.groupTotalFieldSpecified = value;
		}
	}
}