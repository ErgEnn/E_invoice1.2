namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public class AdditionRecord {
    
		private string addContentField;
    
		private decimal addRateField;
    
		private bool addRateFieldSpecified;
    
		private decimal addSumField;
    
		private bool addSumFieldSpecified;
    
		private string addCodeField;
    
		
		public string AddContent {
			get => this.addContentField;
			set => this.addContentField = value;
		}
    
		
		public decimal AddRate {
			get => this.addRateField;
			set => this.addRateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AddRateSpecified {
			get => this.addRateFieldSpecified;
			set => this.addRateFieldSpecified = value;
		}
    
		
		public decimal AddSum {
			get => this.addSumField;
			set => this.addSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AddSumSpecified {
			get => this.addSumFieldSpecified;
			set => this.addSumFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
		public string addCode {
			get => this.addCodeField;
			set => this.addCodeField = value;
		}
	}
}