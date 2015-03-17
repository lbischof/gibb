import csv
import re

OK = '\033[92m'
FAIL = '\033[91mFAIL: '
ENDC = '\033[0m'

patterns = [
	'[0-9]+', # 0 AdressNr
	'.{2,}\s.{2,}', # 1 Vorname Name
	'[a-zA-Züäö]+ [0-9]+', # 2 Strasse Hausnummer
	'\d{4,5} [A-Z][a-z]+', # 3 PLZ Ort
	'', # 4 Telefonnummer
	'[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}', # 5 Emailadresse
	'(([0-9]|[0-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[0-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])', # 6 IP4 Adresse
	''  # 7 Datum
	]
def validate(patternIdx,string):
	if re.match('^'+patterns[patternIdx]+'$', string):
		print(OK+string+ENDC)
	else:
		print(FAIL+string+ENDC)

with open('Data1.csv', newline='') as f:
	reader = csv.reader(f, delimiter=';')
	for row in reader:
		print('----- Neue Zeile -----')
		for i,col in enumerate(row):
			validate(i,row[i])	
