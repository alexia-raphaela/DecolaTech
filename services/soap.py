# coding: utf-8
from zeep import Client

# instancia de client passando a URI do meu serviço
client = Client('http://www.soapclient.com/xml/soapresponder.wsdl')
result = client.service.Method1(bstrParam1='oi', bstrParam2='tchau')
print(result)