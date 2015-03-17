import csv
import re

patterns = [
	'[0-9]', # 0 AdressNr
	'([a-zA-Z]{2}){2,}', # 1 Vorname Name
	'[a-zA-Z] [0-9]+', # 2 Strasse Hausnummer
	'\d{4,5} [A-Z][a-z]+', # 3 PLZ Ort
	'', # 4 Telefonnummer
	'', # 5 Emailadresse
	'', # 6 IP4 Adresse
	''  # 7 Datum
	]
def validate(patternIdx,string):
	if len(patterns) > pattern and re.match(patterns[patternIdx], string):
		writeFile(True, string)
	else:
		writeFile(False, string)

with open('Data1.csv', newline='') as f:
	reader = csv.reader(f, delimiter=';')
	for row in reader:
		for i,col in enumerate(row):
			validate(i,row[i])
			
