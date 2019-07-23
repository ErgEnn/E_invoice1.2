# E_invoice1.2

C# implementation for Estonian E-invoice 1.2

Auto-generated according to XSD from https://www.pangaliit.ee/arveldused/e-arve

Allow easy deserialization of e-invoice XML files:
```cs
XmlSerializer serializer = new XmlSerializer(typeof(E_Invoice));
var invoice = serializer.Deserialize(serializedEInvoiceXML) as E_Invoice;
```
