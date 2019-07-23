namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class Footer {
    
		private string totalNumberInvoicesField;
    
		private decimal totalAmountField;
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
		public string TotalNumberInvoices {
			get => this.totalNumberInvoicesField;
			set => this.totalNumberInvoicesField = value;
		}
    
		
		public decimal TotalAmount {
			get => this.totalAmountField;
			set => this.totalAmountField = value;
		}
	}
}