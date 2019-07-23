namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public  class InvoiceInformationPeriod {
    
		private string periodNameField;
    
		private System.DateTime startDateField;
    
		private bool startDateFieldSpecified;
    
		private System.DateTime endDateField;
    
		private bool endDateFieldSpecified;
    
		
		public string PeriodName {
			get => this.periodNameField;
			set => this.periodNameField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="date")]
		public System.DateTime StartDate {
			get => this.startDateField;
			set => this.startDateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool StartDateSpecified {
			get => this.startDateFieldSpecified;
			set => this.startDateFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="date")]
		public System.DateTime EndDate {
			get => this.endDateField;
			set => this.endDateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool EndDateSpecified {
			get => this.endDateFieldSpecified;
			set => this.endDateFieldSpecified = value;
		}
	}
}