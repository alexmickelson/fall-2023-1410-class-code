import csv
import json

def csv_to_json(csv_filename, json_filename):
    """Convert a CSV file to a JSON file."""
    data = []

    with open(csv_filename, 'r') as csv_file:
        csv_reader = csv.DictReader(csv_file)

        for row in csv_reader:
            data.append(row)

    with open(json_filename, 'w') as json_file:
        json.dump(data, json_file, indent=4)


csv_to_json('pokemon.csv', 'pokemon.json')
