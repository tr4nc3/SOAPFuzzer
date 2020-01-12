# SOAPFuzzer	
A utility that relies on WSDL files to generate the XML Payloads that are consistent with the WSDL.  

# Description
This is an old, unsupported utility.  Back in the day, web services used to rely on SOAP requests.  The data definition used to be maintained in WSDL files which would indicate what the request format should be.  This utility takes a WSDL file and generates a well-formed XML payload for the SOAP requests so that the XML Parsers can accept the payloads.  The utility support proxies, Basic authentication, custom headers, fuzzed XML payloads.  This was written in 2009.  Unsupported and replicated for backup/historical purposes. 

