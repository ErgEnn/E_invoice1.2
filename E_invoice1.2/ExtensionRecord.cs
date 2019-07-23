namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute("AdditionalInformation", Namespace="", IsNullable=false)]
	public  class ExtensionRecord {
    
		private string informationNameField;
    
		private string informationContentField;
    
		private System.Xml.XmlElement customContentField;
    
		private string extensionIdField;
    
		
		public string InformationName {
			get => this.informationNameField;
			set => this.informationNameField = value;
		}
    
		
		public string InformationContent {
			get => this.informationContentField;
			set => this.informationContentField = value;
		}
    
		
		public System.Xml.XmlElement CustomContent {
			get => this.customContentField;
			set => this.customContentField = value;
		}
    
		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string extensionId {
			get => this.extensionIdField;
			set => this.extensionIdField = value;
		}
	}
}