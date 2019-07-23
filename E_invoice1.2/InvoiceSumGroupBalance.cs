namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public  class InvoiceSumGroupBalance {
    
		private System.DateTime balanceDateField;
    
		private bool balanceDateFieldSpecified;
    
		private decimal balanceBeginField;
    
		private bool balanceBeginFieldSpecified;
    
		private decimal[] inboundField;
    
		private decimal[] outboundField;
    
		private decimal balanceEndField;
    
		private bool balanceEndFieldSpecified;
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="date")]
		public System.DateTime BalanceDate {
			get => this.balanceDateField;
			set => this.balanceDateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BalanceDateSpecified {
			get => this.balanceDateFieldSpecified;
			set => this.balanceDateFieldSpecified = value;
		}
    
		
		public decimal BalanceBegin {
			get => this.balanceBeginField;
			set => this.balanceBeginField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BalanceBeginSpecified {
			get => this.balanceBeginFieldSpecified;
			set => this.balanceBeginFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Inbound")]
		public decimal[] Inbound {
			get => this.inboundField;
			set => this.inboundField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Outbound")]
		public decimal[] Outbound {
			get => this.outboundField;
			set => this.outboundField = value;
		}
    
		
		public decimal BalanceEnd {
			get => this.balanceEndField;
			set => this.balanceEndField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BalanceEndSpecified {
			get => this.balanceEndFieldSpecified;
			set => this.balanceEndFieldSpecified = value;
		}
	}
}