import csv
import re

OK = '\033[92m'
FAIL = '\033[91m'
ENDC = '\033[0m'

patterns = [
	'[0-9]+', # 0 AdressNr
	'.{2,}\s.{2,}', # 1 Vorname Name
	'[\w\' ]+\.? [0-9]+\w?', # 2 Strasse Hausnummer
	'\d{4,5} [A-Z][a-zäüö]+', # 3 PLZ Ort
	'((0{1,2}|\+)?41\s?|0)([1-9]\d)(\s|\s\/\s)?(\d{3})\s?(\d{2})\s?(\d{2})', # 4 Telefonnummer
	'[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}', # 5 Emailadresse
	'(([0-9]|[0-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[0-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])', # 6 IP4 Adresse
	'(0?[1-9]|[12]\d|30|31(?=\.(0?[13578]|10|12)))\.(0?[1-9]|1[012])\.\d{4}'  # 7 Datum
	]
def validate(line):
	for i,col in enumerate(line): # Go through each field in the line
		if not re.match(patterns[i]+'$', col): # If it fails then yield the error
			yield col

with open('Data1.csv', newline='') as f:
	reader = csv.reader(f, delimiter=';')
	for lineNumber, line in enumerate(reader): # Go through every line in the csv
		lineNumber += 1 # Because lineNumber is zero based and displayed to user
		errors = validate(line)
		if not any(errors):
			print("{}Zeile {} erfolgreich{}".format(OK, lineNumber, ENDC))
		else:
			print("{}Fehler auf Zeile {}:".format(FAIL, lineNumber))
			errors = validate(line) # Get the errors again because any() ate the first element
			for error in errors:
				print(error or "leer")
			print(ENDC)
