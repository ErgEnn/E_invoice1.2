namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute("AttachmentFile", Namespace="", IsNullable=false)]
	public class AttachmentRecord {
    
		private string fileNameField;
    
		private byte[] fileBase64Field;
    
		private string fileSizeField;
    
		
		public string FileName {
			get => this.fileNameField;
			set => this.fileNameField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] FileBase64 {
			get => this.fileBase64Field;
			set => this.fileBase64Field = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
		public string FileSize {
			get => this.fileSizeField;
			set => this.fileSizeField = value;
		}
	}
}