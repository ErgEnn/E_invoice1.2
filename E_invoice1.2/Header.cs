namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class Header {
    
		private string testField;
    
		private System.DateTime dateField;
    
		private string fileIdField;
    
		private string appIdField;
    
		private string versionField;
    
		private string senderIdField;
    
		private string receiverIdField;
    
		private string contractIdField;
    
		private string payeeAccountNumberField;
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN")]
		public string Test {
			get => this.testField;
			set => this.testField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="date")]
		public System.DateTime Date {
			get => this.dateField;
			set => this.dateField = value;
		}
    
		
		public string FileId {
			get => this.fileIdField;
			set => this.fileIdField = value;
		}
    
		
		public string AppId {
			get => this.appIdField;
			set => this.appIdField = value;
		}
    
		
		public string Version {
			get => this.versionField;
			set => this.versionField = value;
		}
    
		
		public string SenderId {
			get => this.senderIdField;
			set => this.senderIdField = value;
		}
    
		
		public string ReceiverId {
			get => this.receiverIdField;
			set => this.receiverIdField = value;
		}
    
		
		public string ContractId {
			get => this.contractIdField;
			set => this.contractIdField = value;
		}
    
		
		public string PayeeAccountNumber {
			get => this.payeeAccountNumberField;
			set => this.payeeAccountNumberField = value;
		}
	}
}